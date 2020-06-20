using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PayPal.Api;
using QuanLyBanGiayASP.Data;
using QuanLyBanGiayASP.Extensions;

using QuanLyBanGiayASP.Helper;
using QuanLyBanGiayASP.Models;
using QuanLyBanGiayASP.Models.ViewModels;

namespace QuanLyBanGiayASP.Areas.Customer
{
    [Area("Customer")]
    public class PaypalController : Controller
    {
        private PayPal.Api.Payment payment;

        private readonly ApplicationDbContext _db;
        private int invoiceID;
        private int paymentTotal;

        [BindProperty]
        public ShoppingCartViewModels ShoppingCartVM { get; set; }
        public PaypalController(ApplicationDbContext db)
        {
            _db = db;
            ShoppingCartVM = new ShoppingCartViewModels()
            {
                Products = new List<Models.Products>()
            };
        }
        public IActionResult Index()
        {
            return View();
        }

        [ActionName("PaymentWithPaypal")]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> PaymentWithPaypal()
        {
            APIContext apiContext = Configuration.GetAPIContext();
            try
            {
                List<Amount_Product> lstCartItems = HttpContext.Session.Get<List<Amount_Product>>("ssShoppingCart");
                string payerId = Request.Query["PayerID"].ToString();
                var user = await _db.ApplicationUser.Where(u => u.Email == User.Identity.Name).FirstOrDefaultAsync();

                Customers customer = new Customers();
                if (string.IsNullOrEmpty(payerId))
                {

                   
                    customer.Status = "Just Order";
                    _db.Customers.Add(customer);
                    _db.SaveChanges();

                    int idcustomer = customer.ID;

                    Orders orders = ShoppingCartVM.Orders;
                    orders.CustomerID = idcustomer;
                    _db.Orders.Add(orders);
                    _db.SaveChanges();

                    int orderId = orders.ID;

                    var ProductDB = _db.Products.ToList();

                    foreach (Amount_Product item in lstCartItems)
                    {
                        OrderItems orderItems = new OrderItems()
                        {
                            OrderID = orderId,
                            ProductID = item.IDProduct,
                            Amount = item.Amount
                        };
                        for (int i = 0; i < ProductDB.Count(); i++)
                        {
                            if (item.IDProduct == ProductDB[i].ID)
                            {
                                ProductDB[i].InStock -= item.Amount;
                                orderItems.tongtien = orderItems.Amount * ProductDB[i].Price;
                                break;
                            }
                        }
                        _db.SaveChanges();
                        _db.OrderItems.Add(orderItems);

                    }
                    _db.SaveChanges();
                    //this section will be executed first because PayerID doesn't exist
                    //it is returned by the create function call of the payment class

                    // Creating a payment
                    // baseURL is the url on which paypal sendsback the data.
                    // So we have provided URL of this controller only
                    invoiceID = orderId;
                    string baseURL = GetRawUrl(Request) + "?";

                    //guid we are generating for storing the paymentID received in session
                    //after calling the create function and it is used in the payment execution

                    var guid = Convert.ToString((new Random()).Next(100000));

                    //CreatePayment function gives us the payment approval url
                    //on which payer is redirected for paypal account payment

                    var createdPayment = this.CreatePayment(apiContext, baseURL + "guid=" + guid,lstCartItems);

                    //get links returned from paypal in response to Create function call

                    var links = createdPayment.links.GetEnumerator();

                    string paypalRedirectUrl = null;

                    while (links.MoveNext())
                    {
                        Links lnk = links.Current;

                        if (lnk.rel.ToLower().Trim().Equals("approval_url"))
                        {
                            //saving the payapalredirect URL to which user will be redirected for payment
                            paypalRedirectUrl = lnk.href;
                        }
                    }

                    // saving the paymentID in the key guid
                    HttpContext.Session.SetString(guid, createdPayment.id);
                    HttpContext.Session.SetString("invoiceId", invoiceID.ToString());
                    return Redirect(paypalRedirectUrl);
                }
                else
                {
                    // This section is executed when we have received all the payments parameters

                    // from the previous call to the function Create

                    // Executing a payment
                    var getInvoiceId = Int32.Parse(HttpContext.Session.GetString("invoiceId"));
                    double total = 0;

                    foreach (var item in lstCartItems)
                    {
                        var product = _db.Products.Where(u => u.ID == item.IDProduct).FirstOrDefault();
                        product.InStock -= item.Amount;
                        double price = product.Price;
                        _db.Products.Update(product);
                        await _db.SaveChangesAsync();
                        OrderItems orderiTems = new OrderItems()
                        {
                            ProductID = item.IDProduct,
                            OrderID = getInvoiceId,
                            Amount = item.Amount,
                            tongtien = price * item.Amount
                        };
                        total += price * item.Amount;
                        _db.OrderItems.Add(orderiTems);
                        await _db.SaveChangesAsync();
                    }

                    var guid = Request.Query["guid"];

                    var executedPayment = ExecutePayment(apiContext, payerId, HttpContext.Session.GetString(guid));

                    var getOrder = _db.Orders.Where(u => u.ID == getInvoiceId).FirstOrDefault();
                    getOrder.isConfirmed = true;
                    _db.Orders.Update(getOrder);
                    _db.SaveChanges();
                    lstCartItems = new List<Amount_Product>();
                    HttpContext.Session.Set("ssShoppingCart", lstCartItems);

                    if (executedPayment.state.ToLower() != "approved")
                    {

                        return View("FailureView");
                    }
                }
            }
            catch (Exception ex)
            {
                var getInvoiceId = Int32.Parse(HttpContext.Session.GetString("invoiceId"));
                var getOrder = _db.Orders.Where(u => u.ID == getInvoiceId).FirstOrDefault();
                _db.Orders.Remove(getOrder);
                await _db.SaveChangesAsync();
                Logger.Log("Error" + ex.Message);
                return View("FailureView");
            }
            return View("Success");
        }
        private Payment CreatePayment(APIContext apiContext, string redirectUrl, List<Amount_Product> lstCartItems)
        {
            var itemList = new ItemList() { items = new List<Item>() };
            double withoutTax = 0;
            var ProductDB = _db.Products.ToList();
           
            foreach (var item in lstCartItems)
            {
                for (int i = 0; i < ProductDB.Count(); i++)
                {
                    if (item.IDProduct == ProductDB[i].ID)
                    {
                        var priceToUSD = Math.Round(ProductDB[i].Price / 22000, MidpointRounding.AwayFromZero);
                        itemList.items.Add(new Item
                        {
                            name = ProductDB[i].Name,
                            currency = "USD",
                            price = priceToUSD.ToString(),
                            quantity = item.Amount.ToString(),
                            sku = item.IDProduct.ToString(),
                        });
                        withoutTax += priceToUSD * item.Amount;
                    }
                  
                }
            }
           

            var payer = new Payer() { payment_method = "paypal" };


            // Configure Redirect Urls here with RedirectUrls object
            var redirUrls = new RedirectUrls()
            {
                cancel_url = redirectUrl,
                return_url = redirectUrl
            };


            var tax = withoutTax * 0.1;
            var shipping = withoutTax * 0.05;

            // similar as we did for credit card, do here and create details object
            var details = new Details()
            {
                tax = Math.Round(tax, MidpointRounding.AwayFromZero).ToString(),
                shipping = Math.Round(shipping, MidpointRounding.AwayFromZero).ToString(),
                subtotal = Math.Round(withoutTax, MidpointRounding.AwayFromZero).ToString()
            };
            var total = withoutTax + tax + shipping;
            paymentTotal = Int32.Parse(Math.Round(total, MidpointRounding.AwayFromZero).ToString());

            // similar as we did for credit card, do here and create amount object
            var amount = new Amount()
            {
                currency = "USD",
                total = paymentTotal.ToString(), // Total must be equal to sum of shipping, tax and subtotal.
                details = details
            };

            //Tạo danh sách giao dịch
            var transactionList = new List<Transaction>();
            transactionList.Add(new Transaction()
            {
                description = "Thank you for using us.",
                invoice_number = invoiceID.ToString(),
                amount = amount,
                item_list = itemList
            });

            this.payment = new Payment()
            {
                intent = "sale",
                payer = payer,
                transactions = transactionList,
                redirect_urls = redirUrls
            };

            // Create a payment using a APIContext
            return this.payment.Create(apiContext);
        }

        public static string GetRawUrl(HttpRequest request)
        {
            var httpContext = request.HttpContext;
            return $"{httpContext.Request.Scheme}://{httpContext.Request.Host}{httpContext.Request.Path}{httpContext.Request.QueryString}";
        }
        private Payment ExecutePayment(APIContext apiContext, string payerId, string paymentId)
        {
            var paymentExecution = new PaymentExecution() { payer_id = payerId };
            this.payment = new Payment() { id = paymentId };
            return this.payment.Execute(apiContext, paymentExecution);
        }
    }
}
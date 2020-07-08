using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyBanGiayASP.Models.ViewModels
{
    public class Access
    {
        public string access { get; set; }

        public void getaccess(string get)
        {
            access = get;
        }

    }
}

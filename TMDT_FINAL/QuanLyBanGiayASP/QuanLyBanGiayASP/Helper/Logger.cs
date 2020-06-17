using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace QuanLyBanGiayASP.Helper
{
    public class Logger
    {
        public static string LogDirectoryPath = Environment.CurrentDirectory;

        public static void Log(String lines)
        {
            try
            {
                StreamWriter file = new StreamWriter(LogDirectoryPath + "\\Error.log", true);
                file.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " --> " + lines);
                file.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

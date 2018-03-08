using Google.Apis.Books.v1;
using Google.Apis.Services;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Mybrary
{
    static class Program
    {
        public static BooksService service = new BooksService(new BaseClientService.Initializer()
        {
            ApplicationName = ConfigurationManager.AppSettings["appName"],
            ApiKey = ConfigurationManager.AppSettings["apiKey"]
        });

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

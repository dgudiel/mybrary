using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; 

namespace Mybrary
{
    public partial class Form1 : Form
    {
        BooksService service = new BooksService(new BaseClientService.Initializer()
        {
            ApplicationName = ConfigurationSettings.AppSettings["appName"],
            ApiKey = ConfigurationSettings.AppSettings["apiKey"]
        });

        public Form1()
        {

            InitializeComponent();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            var request = service.Volumes.List(textBox1.Text);
            var results = request.Execute().Items.ToArray();
            label1.Text = results[0].VolumeInfo.Title;
            pictureBox1.ImageLocation = results[0].VolumeInfo.ImageLinks.SmallThumbnail; 
        }

       
    }
}

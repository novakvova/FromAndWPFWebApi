using ServiceDLL.Concrete;
using ServiceDLL.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFClient
{
    public partial class ProductAddForm : Form
    {
        private string _base64Image;
        public ProductAddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                IProductApiService service = new IProductApiService();
                service.Create(new ServiceDLL.Models.ProductAddModel
                {
                    Name = txtName.Text,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    Image=_base64Image
                });
            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    using (var errorResponse = (HttpWebResponse)wex.Response)
                    {
                        using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                        {
                            string error = reader.ReadToEnd();
                            MessageBox.Show(error);
                            //TODO: use JSON.net to parse this string and look at the error message
                        }
                    }
                }
                MessageBox.Show("Гюстон у нас проблеми");
            }
            
        }

        private void ProductAddForm_Load(object sender, EventArgs e)
        {
            try
            {
                //WebRequest req = WebRequest.Create("https://localhost:44356/images/borodata.jpg");
                //WebResponse response = req.GetResponse();
                //Stream stream = response.GetResponseStream();
                //pbImage.Image = Image.FromStream(stream);

                WebRequest req = WebRequest.Create("https://localhost:44356/images/50_jsbe33x2.hbr.jpg");
                WebResponse response = req.GetResponse();
                Stream stream = response.GetResponseStream();
                var image = Image.FromStream(stream);
                pbImage.Image = image;
                //string base64=image.ConvertToBase64String();


            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem downloading the file");
            }
            
        }

        private void btnSelectФото_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                txtImagePath.Text= dlg.FileName;
                var image = Image.FromFile(dlg.FileName);
                pbImage.Image = image;
                _base64Image = image.ConvertToBase64String();
            }
        }
    }
}

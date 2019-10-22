using ServiceDLL.Concrete;
using ServiceDLL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFClient
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {

            ///Thread thread = new Thread(() =>
            ///{
            ///    ProductApiService service = new ProductApiService();
            ///    var list = service.GetProducts();
            ///    foreach (var p in list)
            ///    {
            ///        object[] row = { p.Id, p.Name, p.Price };
            ///        dgvProducts.Rows.Add(row);
            ///    }
            ///    lblTredInfo.Text = "Завершено успішно";
            ///});
            ///thread.Start();
            ///
            Debug.WriteLine("-----Main thread----- {0}", Thread.CurrentThread.ManagedThreadId);
            ProductApiService service = new ProductApiService();
            var list = await service.GetProductsAsync();
            Debug.WriteLine("-----Main thread----- {0}", Thread.CurrentThread.ManagedThreadId);
            foreach (var p in list)
            {
                object[] row = { p.Id, p.Name, p.Price };
                dgvProducts.Rows.Add(row);
            }
            lblTredInfo.Text = "Завершено успішно";
        }

        private void btnAddProductForm_Click(object sender, EventArgs e)
        {
            ProductAddForm dlg = new ProductAddForm();
            dlg.ShowDialog();
        }

        private void btnShowLoginForm_Click(object sender, EventArgs e)
        {
            LoginForm dlg = new LoginForm();
            dlg.ShowDialog();
        }
    }
}

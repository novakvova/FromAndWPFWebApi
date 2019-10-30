using ServiceDLL.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFClient
{
    public partial class EditProductForm : Form
    {
        public int IdProduct { get; set; }
        IProductApiService service = new IProductApiService();
        public EditProductForm()
        {
            InitializeComponent();
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            var product = service.EditGetById(this.IdProduct);
            txtName.Text = product.Name;
            txtPrice.Text = product.Price.ToString();
            

        }
    }
}

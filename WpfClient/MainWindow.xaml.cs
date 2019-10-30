using ServiceDLL.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products = new ObservableCollection<Product>();
        public MainWindow()
        {
            InitializeComponent();
            dgProducts.ItemsSource = products;
        }
        private async void BtnGetData_Click(object sender, RoutedEventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                IProductApiService service = new IProductApiService();
                var list = service.GetProducts();
                foreach (var p in list)
                {
                    Product prod = new Product
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Price = p.Price
                    };
                    products.Add(prod);
                }
            });
            thread.Start();


            ///Debug.WriteLine("-----Main thread----- {0}", Thread.CurrentThread.ManagedThreadId);
            ///ProductApiService service = new ProductApiService();
            ///var list = await service.GetProductsAsync();
            ///Debug.WriteLine("-----Main thread----- {0}", Thread.CurrentThread.ManagedThreadId);
            ///foreach (var p in list)
            ///{
            ///    Product prod = new Product
            ///    {
            ///        Id = p.Id,
            ///        Name = p.Name,
            ///        Price=p.Price
            ///    };
            ///    products.Add(prod);
            ///}
        }
    }
}

using Newtonsoft.Json;
using ServiceDLL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Дані із сервера");
            ProductApiService sp = new ProductApiService(); 
            foreach (var item in sp.GetProducts())
            {
                Console.WriteLine("Id: {0}\tName: {1}\tPrice:{2}", 
                    item.Id, item.Name,item.Price);
            }
            Console.WriteLine(DateTime.Now);
        }
    }
}

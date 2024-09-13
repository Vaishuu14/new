using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern2_08_20
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }

        public Product(int id , string name , float price)
        {
            ProductId = id;
            ProductName = name;
            Price = price;

        }

        public void GetProductDetails()
        {
            Console.WriteLine("Fetching the Product Details ....");
            Console.WriteLine($"Product Id : {ProductId} , Product Name : {ProductName} , Product Price : {Price}");
        }
        public bool CheckStock()
        {
            Console.WriteLine($"Checking stock for {ProductName}...");
            return true; 
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern2_08_20
{
    class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Placing order started ..");
            Product product = new Product(01,"Book",200.00f);
            product.GetProductDetails();

           if (product.CheckStock())
            {

                Payment pay = new Payment(1001 , "Creadit Card" , product.Price);
                pay.ValidatePayment();
                pay.MakePayment();

                Console.WriteLine("Order place successfully");

            }
            else
            {
                Console.WriteLine("Producr is out of stock ...");
            }

        }


    }
}

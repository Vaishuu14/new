using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackEx_08_08
{
     class Program
    {

      static ShoppingCart cart;
        static void Main(string[] args)
        {

            int option = 0;

            cart = new ShoppingCart();

            while(option != 5)
            { 


            Console.WriteLine("\n\t\tMenu - Select an Option ");
            Console.WriteLine("\t\t------------------------");
            Console.WriteLine("\t\t1.Add an Item in Cart");
            Console.WriteLine("\t\t2.Undo Items");
            Console.WriteLine("\t\t3.Redu Items");
            Console.WriteLine("\t\t4.View Cart");
            Console.WriteLine("\t\t5.Exit");
            Console.Write("Option : ");
             option = int.Parse(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        bool repeat = true;
                        while (repeat)
                        {
                            Console.Write("Enter Item name (type n to stop ) :  ");
                            String ItemName = Console.ReadLine();

                            if (ItemName != "n")
                            {
                                cart.Add(ItemName);
                            }

                            repeat = ItemName == "n" ? false : true;


                        }
                        ShowCartItem();
                        break;

                    case 2:
                        cart.Undo();
                        ShowCartItem();
                        break;

                    case 3:
                        cart.Redu();
                        ShowCartItem();
                        break;

                    case 4:
                        ShowCartItem();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Option...");
                        break;


                }
            }

            Console.ReadLine();
        
        }

        public static void ShowCartItem()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tCart Items");
            Console.WriteLine("\t------------");
            cart.ViewCart();
            Console.WriteLine("\t------------");
            Console.ForegroundColor = ConsoleColor.White;

        }


    }
}

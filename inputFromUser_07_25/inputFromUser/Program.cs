using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inputFromUser
{
     class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("How many items you want to store");
            //int num = int.Parse(Console.ReadLine());
            //int[] numbers = new int[num];

            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine("Enter Data ");
            //    int data = int.Parse(Console.ReadLine());
            //    numbers[i] = data;

            //}
            //Console.WriteLine("----- Your Data -------");

            //foreach(int items in numbers)
            //{
            //    Console.WriteLine(items);
            //}
            //Console.ReadLine();


            String confirm;
            do
            {   
                Console.WriteLine("Which type of Array you want to create");
                Console.WriteLine("Integer , String , Character ");
                Console.WriteLine("-----------------------------");
                String type = Console.ReadLine().ToLower();

                switch (type)
                {
                    case "integer":
                        Console.WriteLine("How many items you want to store");
                        int num = int.Parse(Console.ReadLine());
                        int[] numbers = new int[num];

                        for (int i = 0; i < num; i++)
                        {
                            Console.WriteLine("Enter Data");
                            int data = int.Parse(Console.ReadLine());
                            numbers[i] = data;
                        }
                        Console.WriteLine("------- Your Data --------");
                        foreach (int items in numbers)
                        {
                            Console.Write(items + " ");
                        }
                        Console.ReadLine();
                        break;

                    case "string":

                        Console.WriteLine("How many items you want to store");
                        int num1 = int.Parse(Console.ReadLine());
                        String[] names = new string[num1];

                        for (int i = 0; i < num1; i++)
                        {
                            Console.WriteLine("Enter Data");
                            String data = Console.ReadLine();
                            names[i] = data;
                        }
                        Console.WriteLine("------- Your Data --------");
                        foreach (String items in names)
                        {
                            Console.Write(items + " ");
                        }
                        Console.ReadLine();

                        break;


                    case "character":

                        Console.WriteLine("How many items you want to store");
                        int num2 = int.Parse(Console.ReadLine());
                        char[] word = new char[num2];

                        for (int i = 0; i < num2; i++)
                        {
                            Console.WriteLine("Enter Data");
                            char data = Convert.ToChar(Console.ReadLine());
                            word[i] = data;
                        }
                        Console.WriteLine("------- Your Data --------");

                        foreach (char items in word)
                        {
                            Console.Write(items + " ");
                        }
                        Console.ReadLine();

                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;





                }
                Console.WriteLine("----------------------");nameof b   
                Console.WriteLine("Do u want to reapete this ?? Yes / No ");
                 confirm = Console.ReadLine().ToLower();
                Console.WriteLine("----------------------");
            } while (confirm == "yes");



        }
    }
}

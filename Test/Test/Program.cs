using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        public void Data()
        {

            StreamWriter sw = new StreamWriter("C:\\New folder\\new.txt");
            Console.WriteLine("Enter the text that u want to write in a file .");

            string str = Console.ReadLine();

            sw.WriteLine(str);

            sw.Flush();
            sw.Close();


        }
     
        static void Main(string[] args)
        {

            Program p = new Program();
            p.Data();
            Console.ReadLine();

        }
    }
}

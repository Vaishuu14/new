using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileReadAndWrite
{
     class Program
    {
        static void Main(string[] args)
        {

            String writeText = "Hii , I am Vaishnavi ";
            File.WriteAllText("file.txt", writeText);

            String readText = File.ReadAllText("file.txt");
            Console.WriteLine( readText);

            Console.ReadLine();

        }
    }
}

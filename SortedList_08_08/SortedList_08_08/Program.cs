using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList_08_08
{
     class Program
    {
        static void Main(string[] args)
        {

            SortedList sl = new SortedList();

            sl.Add(2, "Two");
            sl.Add(3, "Three");
            sl.Add(5, "Five");
            sl.Add(4, "Four");

            var s = sl.IndexOfKey(2);
            Console.WriteLine(s);


            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine($"Key = {item.Key} , Value = {item.Value}" );
            }
            Console.ReadLine();








        }
    }
}

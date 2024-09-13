using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shop s = new Shop();
            CellPhone p =  s.SumsungConstructor();
            Console.WriteLine(p);
            Console.ReadLine();

        }
    }

    class Shop
    {
        public CellPhone SumsungConstructor()
        {

            ICellPhoneBuilder builder = new SamsungPhoneBuilder();
           return builder.SetProcessor("Android").SetCamera(20).GetPhone();


        }

    }
}

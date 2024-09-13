using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackEx_08_08
{
     class ShoppingCart
    {
        Stack<string> cart = new Stack<string>();
        Stack<string> reduStack = new Stack<string>();

        public void Add(string item)
        {
            cart.Push(item);

        }

        public void Undo()
        {
            var i = cart.Pop();
            reduStack.Push(i);
        }

        public void Redu()
        {
            var item = reduStack.Pop();
            cart.Push(item);

        }

        public void ViewCart()
        {
            foreach (var item in cart)
            {
                Console.WriteLine("\t" + item);
            }



        }





    }
}

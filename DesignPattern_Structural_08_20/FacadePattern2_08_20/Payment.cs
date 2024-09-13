using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern2_08_20
{
    class Payment
    {
        public int PaymentId { get; set; }
        public string PaymentType { get; set; }
        public float Amount { get; set; }

        public Payment(int id , string type , float amount)
        {
            PaymentId = id;
            PaymentType = type;
            Amount = amount;
        }

        public void MakePayment()
        {
            Console.WriteLine($"Payment Id : {PaymentId} , Payment Type : {PaymentType} , Amount : {Amount}");
        }
        public bool ValidatePayment()
        {
            Console.WriteLine("Validating payment...");
            return true; 
        }
    }
}

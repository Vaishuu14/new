using System;

namespace EventsAndDelegates_08_07
{
    public class MailService
    {

        public void OnVideoEncoded(object obj , EventArgs args)
        {
            Console.WriteLine("MailService : Sending an Email...");
        }


    }




}

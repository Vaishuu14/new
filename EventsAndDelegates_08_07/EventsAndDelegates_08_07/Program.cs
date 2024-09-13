using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates_08_07
{

    class Program
    {
        static void Main(string[] args)
        {

            var videoEncoder = new VideoEncoder();
            var video = new Video() {Title = " Video 1"};

            var mailService = new MailService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.Encode(video);

            Console.ReadLine();

        }
   
    }




}

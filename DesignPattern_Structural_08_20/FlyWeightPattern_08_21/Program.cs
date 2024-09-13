using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FlyWeightPattern_08_21.CharacterB;

namespace FlyWeightPattern_08_21
{
    class Program
    {
        static void Main(string[] args)
        {

            var bunchOfCharacter = "abba";
            var characterFactory = new CharacterFactory();

            var characterObject = characterFactory.GetCharacter(bunchOfCharacter[0]);
            characterObject?.Draw("Arial", 12);

            Console.WriteLine();

            characterObject = characterFactory.GetCharacter(bunchOfCharacter[1]);
            characterObject?.Draw("Times New Roman", 16);

            Console.WriteLine();

            characterObject = characterFactory.GetCharacter(bunchOfCharacter[2]);
            characterObject?.Draw("Trebuchet MS",19);


            Console.ReadLine();




        }
    }
}

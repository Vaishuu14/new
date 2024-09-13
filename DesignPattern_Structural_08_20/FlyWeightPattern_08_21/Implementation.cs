using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern_08_21
{

    public interface ICharacter
    {
        void Draw(string fontFamily, int fontSize);
    }

    public class CharacterA : ICharacter
    {
        private char actualCharacter = 'a';
        private string FontFamily = string.Empty;
        private int FontSize;

        public void Draw(string fontFamily , int fontSize)
        {
            FontFamily = fontFamily;
            FontSize = fontSize;

            Console.WriteLine($"Drawing : {actualCharacter} , {FontFamily} , {FontSize}");
        }

    }

    public class CharacterB : ICharacter
    {
        private char actualCharacter = 'b';
        private string FontFamily = string.Empty;
        private int FontSize;

        public void Draw( string fontFamily , int fontSize)
        {
            FontFamily = fontFamily;
            FontSize = fontSize;

            Console.WriteLine($"Drawing : {actualCharacter} , {FontFamily} , {FontSize}");
        }
        

        public class CharacterFactory
        {
            private readonly Dictionary<char, ICharacter> _characters = new Dictionary<char, ICharacter>();

            public ICharacter GetCharacter(char characterIdentifier)
            {
                if (_characters.ContainsKey(characterIdentifier))
                {
                    Console.WriteLine("Character Reuse");
                     return _characters[characterIdentifier];               
                                
                }

                Console.WriteLine("Character Construction");
                switch (characterIdentifier)
                {
                    case 'a':
                        _characters[characterIdentifier] = new CharacterA();
                        return _characters[characterIdentifier];

                    case 'b':
                        _characters[characterIdentifier] = new CharacterB();
                        return _characters[characterIdentifier];
                }
                return null;
            }


        }

    }


    class Implementation
    {
    }
}

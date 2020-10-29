using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passgen
{
    class PasswordGenerator
    {
        private string[] DictionaryFive = { "dream", "apple", "playa", "cache", "money", "place", 
            "runny", "mover", "worky", "creed", "moler","fixer"};

        private string[] DictionarySix = {"snitch", "cooler", "python", "seller", "clothy","wilder", "gunner",
        "helper","wizard"};

        private string[] DictionarySeven = { "banking", "Heheh", "dfogdfgodf" };

        private string[] DictionaryEight = { "strenght" };

        private int[] NumberRange = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        private string[] SymbolRange = { "!", "@", "#", "$", "%", "&" };

        public string GeneratePass(Password pass)
        {
            
            string word = "";
            int number = 0;

            switch (pass.Length)
            {
                case 8:
                    Random rWord_EIGTH = new Random();
                    Random rFirstNumber_EIGHT = new Random();
                    Random rSecondNumber_EIGHT = new Random();
                    if (pass.HasSpecialKeys)
                    {
                        word = DictionaryFive[rWord_EIGTH.Next(DictionaryFive.Length)];
                    } else
                    {
                        word = DictionarySix[rWord_EIGTH.Next(DictionarySix.Length)];
                    }
                    number = NumberRange[rFirstNumber_EIGHT.Next(NumberRange.Length)] + NumberRange[rSecondNumber_EIGHT.Next(NumberRange.Length)];
                    break;

                case 10:
                    Random rWord_TEN = new Random();
                    Random rFirstNumber_TEN = new Random();
                    Random rSecondNumber_TEN = new Random();
                    Random rThirdNumber_TEN = new Random();
                    if (pass.HasSpecialKeys)
                    {
                        word = DictionarySeven[rWord_TEN.Next(DictionarySeven.Length)];
                    }
                    else
                    {
                        word = DictionarySix[rWord_TEN.Next(DictionarySix.Length)];
                    }
                    number = NumberRange[rFirstNumber_TEN.Next(NumberRange.Length)] + NumberRange[rSecondNumber_TEN.Next(NumberRange.Length)] + NumberRange[rThirdNumber_TEN.Next(NumberRange.Length)];
                    break;

                case 12:
                    Random rWord_TWENTY = new Random();
                    Random rFirstNumber_TWENTY = new Random();
                    Random rSecondNumber_TWENTY = new Random();
                    Random rThirdNumber_TWENTY = new Random();
                    Random rFourthNumber_TWENTY = new Random();
                    if (pass.HasSpecialKeys)
                    {
                        word = DictionaryEight[rWord_TWENTY.Next(DictionaryEight.Length)];
                    }
                    else
                    {
                        word = DictionarySeven[rWord_TWENTY.Next(DictionarySeven.Length)];
                    }
                    number = NumberRange[rFirstNumber_TWENTY.Next(NumberRange.Length)] + NumberRange[rSecondNumber_TWENTY.Next(NumberRange.Length)] + NumberRange[rThirdNumber_TWENTY.Next(NumberRange.Length)] + NumberRange[rFourthNumber_TWENTY.Next(NumberRange.Length)];
                    break;

                default:
                    break;

            }

            if (pass.HasSpecialKeys)
            {
                Random rSymbol = new Random();
                string symbol = SymbolRange[rSymbol.Next(SymbolRange.Length)];
                return word + number.ToString() + symbol;

            } else
            {
                return word + number.ToString();
            }

        }

    }
}

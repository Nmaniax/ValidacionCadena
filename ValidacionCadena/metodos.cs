using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionCadena
{
    public static class Metodos
    {
        private static bool ValidateString(String str, char[] specialChar, Func<char, bool> fn, bool acceptSpace =  true)
        {
            List<char> tempStr = str.ToList();
            bool result = true;

            if(acceptSpace)
                tempStr.RemoveAll(c => c == ' ');

            if (specialChar != null)
                tempStr.RemoveAll(c => specialChar.Contains(c));

            result = tempStr.All(c => fn(c));

            if(result == false)
            {
                Console.WriteLine("¡Caracter invalido detectado!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("¡Valido!");
                Console.ReadKey();
            }

            return result;
        }

        public static bool ValidateAlphabeticString(this String str, char[] specialChar, bool acceptSpace = true)
        {
            return ValidateString(str, specialChar, char.IsLetter, acceptSpace);
        }

        public static bool ValidateAlphanumericString(this String str, char[] specialChar, bool acceptSpace = true)
        {
            return ValidateString(str, specialChar, char.IsLetterOrDigit, acceptSpace);
        }

        public static bool ValidateNumericString(this String str, char[] specialChar, bool acceptSpace = true)
        {
            return ValidateString(str, specialChar, char.IsNumber, acceptSpace);
        }
    }
}

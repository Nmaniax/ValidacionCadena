using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionCadena
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            String s = "";
            char[] c = new char[] { '#', '@', '}' };

            Console.WriteLine("1) alphabetic \n 2) alphanumeric \n 3) numeric: ");
            i = int.Parse(Console.ReadLine());

            Console.WriteLine("Linea: ");
            s = Console.ReadLine();

            switch(i)
            {
                case 1:
                    s.ValidateAlphabeticString(c);
                    break;
                case 2:
                    s.ValidateAlphanumericString(c);
                    break;
                case 3:
                    s.ValidateNumericString(c);
                    break;
            }

        }
    }
}

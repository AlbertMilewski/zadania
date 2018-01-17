using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_7
{
    class Program
    {
        static string wczysc (string a, string b, string builder)

        static void Main(string[] args)
        {
            
            StringBuilder builder = new StringBuilder("Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMaker");
            Console.WriteLine("Jakiego wyrazu lub litery chcesz się pozbyć lub go wymienić?");
            string a = Console.ReadLine();
            Console.WriteLine("Wpisz wyraz na któryc chcesz wymienić, wpisz spacje jeśli chcesz go wykasować");
            string b = Console.ReadLine();
            builder.Replace(a, b);
            Console.WriteLine(builder.ToString());
            Console.ReadLine();
        }
    }
}

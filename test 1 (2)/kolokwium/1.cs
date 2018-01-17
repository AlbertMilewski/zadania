using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace kolokwium
{
    class Program
    {
        static int FindChar(string str, char b, ref int a)
        {
            
            
                foreach (char c in str)
                {
                    if (c == b)
                    {
                        a = str.IndexOf(b) + 1;
                    }
                }
            
            return a;
        }
        static void Main(string[] args)
        {
           
            string str;
            int a = 0;
            Console.WriteLine("Podaj swój string");
            str = Console.ReadLine();
            Console.WriteLine("Podaj litere do sprawdzenia");
            char b = char.Parse(Console.ReadLine());
                FindChar(str, b, ref a);
            Console.WriteLine("podana litera występuję pierwszy raz na pozycji "+ a);
               
                Console.ReadKey();

            }

        }

    }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium_3
{
    class Program
    {
        static string sklej (string[] words,ref string a)
            {
            StringBuilder builder2 = new StringBuilder(
               "Twoje słowa:  ");
            foreach (string item in words)
            {
                builder2.Append(item).Append(" c ");
            }
            
            a = builder2.ToString();
            return a;
          
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ile wyrazów chcesz podać?");
            int n = int.Parse(Console.ReadLine());
            string a="";
            string[] words = new string[n];
            for(int i=0; i<n; i++)
            {
                words[i] = Console.ReadLine();
            }


            sklej(words,ref a);
            Console.WriteLine(a);

              Console.ReadLine();
        }
    }
}

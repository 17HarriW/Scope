using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello("English");
            SayHello("German");
            SayHello("French");
        }
        /// <summary>
        /// Returns hello in parameter language
        /// </summary>
        /// <param name="language"> Desired language </param>
        private static void SayHello(string language)
        {
            switch (language)
            {
                case "English":
                    Console.WriteLine("Hello");
                    break;
                case "German":
                    Console.WriteLine("Guten tag");
                    break;
                case "French":
                    Console.WriteLine("Bonjour");
                    break;
                default:
                    Console.WriteLine("How?");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    class Program
    {
        static string language = "English";

        static void Main(string[] args)
        {

            string language = "Japanese";
            SayHello(language);
            Console.WriteLine($"I just said hello in {language}");

            Console.ReadLine();
        }

        /// <summary>
        /// Returns a greeting in all listed languages
        /// </summary>
        private static void ShowOff()
        {
            List<string> languages = new List<string> {
                "English", "German","French","Yorkshire"
            };

            foreach(string language in languages)
            {
                SayHello(language);
            }

        }

        /// <summary>
        /// Returns a greeting in a given language
        /// </summary>
        /// <param name="language"> Desired language </param>
        private static void SayHello(string language)
        {
            language = "English";
            Console.Write($"You can say a greeting in {language} by saying ");
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
                case "Japanese":
                    Console.WriteLine("Kon'ichiwa");
                    break;
                default:
                    Console.WriteLine("Allo");
                    break;
            }
        }
    }
}

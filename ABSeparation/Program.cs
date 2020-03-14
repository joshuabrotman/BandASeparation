using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSeparation
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteBanner();

            Console.WriteLine("Enter a String of characters with A and B in it:");
            string userInput = Console.ReadLine();
            char[] arr;
            arr = userInput.ToCharArray();

            for(int i = 0; i < arr.Length; i++)
            {
                //test only left numbers only if index is at least 3
                //test only right as long as index is at least max length - 3
                if(i < (arr.Length - 4) )
                {
                    if(arr[i+4] == 'a' && arr[i] == 'b' || arr[i+4] == 'b' && arr[i] == 'a')
                    {
                        Console.WriteLine("String contains a and b separated by 3 digits!");
                        Console.ReadKey();
                        return;
                    }
                }

            }
            Console.WriteLine("String does not contain a and b separated by 3 digits!");
            Console.ReadKey();
            return;
        }

        static void WriteBanner()
        {
            Console.WriteLine(@"+--------------------------------------------------------+");
            Console.WriteLine(@"|      __         _____        __    _____               |");
            Console.WriteLine(@"|  ___/ /__ _  __/ ___/__  ___/ /__ / ___/__ ___ _  ___  |");
            Console.WriteLine(@"| / _  / -_) |/ / /__/ _ \/ _  / -_) /__/ _ `/  ' \/ _ \ |");
            Console.WriteLine(@"| \_,_/\__/|___/\___/\___/\_,_/\__/\___/\_,_/_/_/_/ .__/ |");
            Console.WriteLine(@"|                                                /_/     |");
            Console.WriteLine(@"+--------------------------------------------------------+");
            Console.WriteLine("");
        }
    }
}

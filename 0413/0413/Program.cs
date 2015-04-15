using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0413
{
    class Program
    {
        static void Main(string[] args)
        {
            string sha = Console.ReadLine();
            switch(sha)
            {
                case "1":
                    Console.WriteLine("one");
                    break;
                case "2":
                    Console.WriteLine("two");
                    break;
                case "3":
                    Console.WriteLine("three");
                    break;
                case "4":
                    Console.WriteLine("four");
                    break;
                case "5":
                    Console.WriteLine("five");
                    break;

                default:
                    Console.WriteLine("other value");
                    break;
                    
            }
            Console.ReadLine();
        }
    }
}

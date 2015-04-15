using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, string>();
            dic["やくそう"] = "50";
            dic["どくけしのそう"] = "20";
            dic["せかいじゅのは"] = "1";
            dic["せいすい"] = "3";
          


            foreach (var item in dic)
            {
                Console.Write(item.Key+"\t");

                //for (int i=0; i < (8 - item.Key.Length); i++)
                //{
                //    Console.Write("  ");
                //}
                    Console.WriteLine("{0,2}個",  item.Value);
            }

            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, int>();
            dic["矢吹"] = 2;
            dic["丹下"] = 74;
            dic["力石"] = 80;
            dic["白木"] = 100;
            dic["西"] = 10;

            //Console.WriteLine(dic["北海道"]);
            //Console.WriteLine(dic["ダイコン"]);

            foreach (var point in dic)
            {
                Console.Write("氏名：{0}", point.Key+"\t");

                //for (int i = 0; i < (3 - point.Key.Length); i++)
                //{
                //    Console.Write("　");
                //}
                Console.Write("点数：{0,3}  ", point.Value);

               //int stock=int.Parse(input)
                if ( point.Value >= 80)
                {
                    Console.WriteLine("評価：優");
                }
                else if (point.Value <= 60)
                {
                    Console.WriteLine("評価：不可");
                }
                else if (point.Value <= 69)
                {
                    Console.WriteLine("評価：可");
                }
                else if (point.Value <= 79)
                {
                    Console.WriteLine("評価：良");
                }
                
              
              

            }



            Console.ReadLine();


        }
    }
}

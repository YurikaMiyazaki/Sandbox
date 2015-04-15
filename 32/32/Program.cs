using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, string>();
            dic["矢吹"] = "2";
            dic["丹下"] = "74";
            dic["力石"] = "80";
            dic["白木"] = "100";
            dic["西"] = "10";
        

            //Console.WriteLine(dic["北海道"]);
            //Console.WriteLine(dic["ダイコン"]);

            foreach (var point in dic)
            {
                Console.Write("氏名:{0}",point.Key);

                for (int i = 0; i < (3 - point.Key.Length); i++)
                {
                    Console.Write("　");
                }
                Console.WriteLine("点数:{0,3}", point.Value);
            }

            Console.ReadLine();


        }
    }
}

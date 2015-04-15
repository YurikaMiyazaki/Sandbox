using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
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

            int Sum = 0;
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
                Sum += point.Value;
            }

            Console.WriteLine("受験者{0,4}名",dic.Count);
            Console.WriteLine("合計点{0,4}点",Sum);
            Console.WriteLine("平均点{0,4}点",Sum/5);
           
            Console.ReadLine();


        }
    }
}

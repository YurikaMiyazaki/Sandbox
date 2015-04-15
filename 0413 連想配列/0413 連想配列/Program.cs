using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0413_連想配列
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, string>();
            dic["北海道"] = "札幌市";
            dic["青森"] = "青森市";
            dic["秋田"] = "秋田市";
            dic["岩手"] = "盛岡市";
            dic["山形"] = "山形市";
            dic["宮城"] = "仙台市";
            dic["福島"] = "福島市";
            dic["新潟"] = "新潟市";
            dic["長野"] = "長野市";
            dic["富山"] = "富山市";

            //Console.WriteLine(dic["北海道"]);
            //Console.WriteLine(dic["ダイコン"]);
            
            foreach(var shop in dic)
            {
                Console.WriteLine(shop.Value);
            }

            Console.ReadLine();


        }

    }
}

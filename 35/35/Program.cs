using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35
{
    class Program
    {
        static void Main(string[] args)
　　　　{
        Console.WriteLine("0～6 の数字を入力してください。対応した曜日を表示します。");
            string week = Console.ReadLine();
            int result=0;
            int.TryParse(week, out result);
            while (int.TryParse(week, out result) == false || 0 > result || 6 < result)
            {
                if (int.TryParse(week, out result) == false)
                {
                    Console.WriteLine("数字を入力してください");
                }
                else
                {
                    Console.WriteLine("0～6 の範囲で入力してください");
                }
                week = Console.ReadLine();
                int.TryParse(week, out result);
            }


            //while (int.TryParse(week, out result) == false  )
            //{
            //    Console.WriteLine("数字を入力してください");
            //    week = Console.ReadLine();
            //    int.TryParse(week, out result);
            //}
            //while (0 > result || 6 < result)
            //{
            //    Console.WriteLine("0～6 の範囲で入力してください");
            //    week = Console.ReadLine();
            //    int.TryParse(week, out result);
            //}
            switch (week)
            {
                case "0":
                    Console.WriteLine("日曜日");
                    break;
                case "1":
                    Console.WriteLine("月曜日");
                    break;
                case "2":
                    Console.WriteLine("火曜日");
                    break;
                case "3":
                    Console.WriteLine("水曜日");
                    break;
                case "4":
                    Console.WriteLine("木曜日");
                    break;
                case "5":
                    Console.WriteLine("金曜日");
                    break;
                case "6":
                    Console.WriteLine("土曜日");
                    break;

                //default:
                //    Console.WriteLine("数字を入力してください。");
                //    break;

            }
            Console.ReadLine();
        }
    }
}

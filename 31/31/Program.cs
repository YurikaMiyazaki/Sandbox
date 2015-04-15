using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] hyo = { { 1, 99, 100, 50 }, { 2, 200, 5000, 3000 }, { 3, 50, 90, 33 } };

            Console.WriteLine("商品番号　在庫　販売価格　仕入れ価格");
            Console.WriteLine("------------------------------------");
            for (int i= 0; i < 3; i++) 
            {
                for (int j = 0; j < 4;j++)
                {
                    Console.Write("{0,4}",hyo[i, j]);
                    Console.Write("     ");
                }
                
                Console.WriteLine();

                   
            }
            
            
            Console.ReadLine();
        }
    }
}

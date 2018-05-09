using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 將號碼放入List
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 42; i++)
            {
                numbers.Add(i);
            }

            // 隨機挑選6個數字印出並從List中刪除
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                int random = rand.Next(1, numbers.Count);
                Console.WriteLine(numbers[random]);

                numbers.RemoveAt(random);
            }

            // 停止畫面且按下任一鍵關閉
            Console.ReadKey();
        }
    }
}

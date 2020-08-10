using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson003_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть, будь ласка, число: ");
            string number = Console.ReadLine();
            int num = Convert.ToInt32(number);
            if (num % 2 == 0)
            {
                Console.WriteLine("Число парне");
            }
            else
            {
                Console.WriteLine("Число непарне");
            }
            Console.ReadKey();




        }
    }
}

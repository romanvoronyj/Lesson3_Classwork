using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\t\t\t\t\t\tЗагадка:\nХто завжди правду каже?");
            Console.Write("\nВведіть відповідь:");
            string answer = Console.ReadLine();

            if (answer == "Дзеркало")
            {
                Console.WriteLine("Відповідь вірна!");
            }
            else 
            {
                Console.WriteLine("Нажаль,відповідь неправильна.");
            }
            Console.ReadKey();


        }
    }
}

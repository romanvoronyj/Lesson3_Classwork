using System;
using System.Text;

namespace Lesson003_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Товари, доступні на складі: \nНавушники \nКабель \nЧохол \nЗахисне скло \nЗахисна плівка");
            Console.Write("\nВведіть назву товару, що Вас цікавить: ");

            string good = Console.ReadLine();

            int cost = 0;

            switch (good)
            {
                case "Навушники":
                    cost += 200;
                    Console.WriteLine("Навушники Airpods :{0} гривень", cost);
                    break;
                case "Кабель":
                    cost += 10;
                    Console.WriteLine("Кабель Power :{0} гривень", cost);
                    break;
                case "Чохол":
                    cost += 25;
                    Console.WriteLine("Чохол Silicon :{0} гривень", cost);
                    break;
                case "Захисне скло":
                    cost += 15;
                    Console.WriteLine("Захисне скло Gorilla :{0} гривень", cost);
                    break;
                case "Захисна пл?вка":
                    cost += 5;
                    Console.WriteLine("Захисна плівка Aluminium :{0} гривень", cost);
                    break;
                default:
                    Console.WriteLine("Невірно введені дані.Оберіть товар, доступний на складі!");
                    break;
           
            }
            Console.ReadKey();
        }
    }
}

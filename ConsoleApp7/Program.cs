using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            string z;
            Console.Write("Введите x ");//вывод на экран
            x = Convert.ToDouble(Console.ReadLine());//ввод и конвертация значения переменной
            Console.Write("Введите функцию ");//вывод на экран
            z = Console.ReadLine();
            switch (z)//"z"выражение селектор
            {
                case "log"://Постоянное выражение
                    Console.WriteLine("log10(x)=" + Math.Log(x));
                    break;
                case "sin"://Постоянное выражение
                    Console.WriteLine("sin(x)=" + Math.Sin(x));
                    break;
                case "cos"://Постоянное выражение
                    Console.WriteLine("cos(x)= " + Math.Cos(x));
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите первое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Выберите действие: " +
                    "\t\n1 - сложить" +
                    "\t\n2 - умножить" +
                    "\t\n3 - разделить" +
                    "\t\n4 - вычесть: ");
                int sym = Convert.ToInt32(Console.ReadLine());
                var result = 0;
                if (sym == 1)
                    result = a + b;
                else if (sym == 2)
                    result = a * b;
                else if (sym == 3)
                    result = a / b;
                else if (sym == 4)
                    result = a - b;
                Console.WriteLine();
                Console.WriteLine("Результат: " + result);
                Console.WriteLine("\n---------------------------------------------\n");
            }
        }
    }
}

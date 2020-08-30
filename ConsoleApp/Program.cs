using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathExpression;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //TaskOne taskOne = new TaskOne("7 + 6 * 5 - 4 / 2");
            TaskOne taskOne = new TaskOne();
            string line = string.Empty;
            do
            {
                Console.WriteLine("Введите пример");
                line = Console.ReadLine();
                if (line.Length == 0 || line.ToLower() == "exit")
                {
                    break;
                }

                Console.WriteLine(taskOne.GetResult(line));
                Console.WriteLine("Для продолжения нажмите любую кнопку");
                Console.ReadLine();
            } while (true);

            /*Console.WriteLine(taskOne.GetResult("5 + -3"));
            Console.WriteLine(taskOne.GetResult("5 + 3"));
            Console.WriteLine(taskOne.GetResult("5 + 99"));

            Console.WriteLine(taskOne.GetResult("55 + 3"));***/
        }
    }
}

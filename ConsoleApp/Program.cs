using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathExpression;
using Calculator;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Добро пожаловать Вам представлены 2 задачи. Под 1 это решение математического выражения без скобок к примеру 7 + 6 * 5 - 4 / 2. Под 2 это калькулятор");
                Console.WriteLine("Для выхода из подпрограммы напишите stop. Для остановки приложения q");
                string line = Console.ReadLine();
                switch (line)
                {
                    case "1": MathExpression(); break;
                    case "2": Calculate(); break;
                    case "Q":
                    case "q": flag = false; break;
                }
            }
            

        }

        static void MathExpression()
        {
            TaskOne taskOne = new TaskOne();
            string line = string.Empty;
            do
            {
                Console.WriteLine("Введите пример");
                line = Console.ReadLine();
                if (line.Length == 0 || line.ToLower() == "stop")
                {
                    break;
                }

                Console.WriteLine(taskOne.GetResult(line));
                Console.WriteLine("Для продолжения нажмите любую кнопку");
                Console.ReadLine();
            } while (true);
        }

        static void Calculate()
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            Console.WriteLine("Вы вошли в калькулятор. Вводится по цифре за раз потом операция и снова цифры и операция");
            bool flag = true;
            while (flag)
            {
                string key = Console.ReadLine();
                if (key.Length == 4 && key.ToLower() == "stop")
                {
                    flag = false;
                }
                calculator.Push(key);
                Console.WriteLine(calculator.ToString());
            }
        }
    }
}

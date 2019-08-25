using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColumnDecision;

namespace ConsoleColumnDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            //TaskOne taskOne = new TaskOne("7 + 6 * 5 - 4 / 2");
            TaskOne taskOne = new TaskOne();
            Console.WriteLine(taskOne.GetResult("5545 + 35"));
            Console.WriteLine(taskOne.GetResult("5 + 94,9"));
            Console.WriteLine(taskOne.GetResult("-5 + 3"));

            Console.WriteLine(taskOne.GetResult("5 + -3"));
            Console.WriteLine(taskOne.GetResult("5 + 3"));
            Console.WriteLine(taskOne.GetResult("5 + 99"));

            Console.WriteLine(taskOne.GetResult("55 + 3"));
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            Console.WriteLine("Видалено " + stack.Pop());
            Console.WriteLine("Видалено " + stack.Pop());

            Console.WriteLine("Вміст стеку після видалення: ");
            foreach (var item in stack)
            { Console.Write(item + " "); }            

            Console.ReadKey();
        }
    }
}


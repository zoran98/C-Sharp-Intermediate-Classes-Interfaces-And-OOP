using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the stack!");
            var stack = new Stack();

            var input = new object[] { 1, 2, null };

            foreach (var item in input)
            {
                if(item != null)
                {
                    stack.Push(item);
                    Console.WriteLine($"added {item.ToString()} to the stack");
                }
            }

            //stack.Clear();

            Console.WriteLine(stack.Pop().ToString());
            Console.WriteLine(stack.Pop().ToString());
            Console.WriteLine(stack.Pop().ToString());
            Console.WriteLine(stack.Pop().ToString());
            Console.WriteLine(stack.Pop().ToString());


        }
    }
}

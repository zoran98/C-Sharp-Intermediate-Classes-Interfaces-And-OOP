using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        private List<object> stack {  get; set; }

        public Stack()
        {
            stack = new List<object>();
        }

        public void Push(object obj)
        {
            stack.Add(obj);
            Console.WriteLine("Object added successfully!");
        }

        public object Pop()
        {
            if(stack.Count > 0)
            {
                var popedStack = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                return popedStack;
            }
            else
            {
                Console.WriteLine("No items left to pop.");
                return -1;
            }
        }

        public void Clear()
        {
            stack.Clear();
        }
    }
}

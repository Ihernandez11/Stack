using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new StackProject();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            //stack.Clear();

        }
    }
}

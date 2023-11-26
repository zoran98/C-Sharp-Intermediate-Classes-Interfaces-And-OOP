using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            while (true)
            {
                var input = Console.ReadLine();
                if(input.ToLower() == "start")
                {
                    sw.Start();
                    Console.WriteLine("Stopwatch is started!");
                } else if(input.ToLower() == "stop")
                {
                    sw.Stop();
                    Console.WriteLine("Stopwatch is stopped!");
                } else if( input.ToLower() == "display time")
                {
                    Console.WriteLine(sw.DisplayTime());
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                }
                                                               
            }          
        }

    }
}

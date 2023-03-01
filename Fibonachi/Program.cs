using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> fib = new List<int>();
            fib.Add(1);
            fib.Add(1);
            Console.Write("do koe chislo na fibonachi iskash da vkarash" +
                "\n N= ");
            byte broika = byte.Parse(Console.ReadLine());
            for (int i = 2; i < broika; i++)
            {
                fib.Add(fib[i - 2] + fib[i - 1]);
            }
            Console.WriteLine(string.Join(", ",fib));
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine(SubMessage());
            Console.ReadKey();
        }

        private static string SubMessage() => $"3=={3}";
    }
}

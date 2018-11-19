using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Console.WriteLine("Args len:" + args.Length);

            for( int i=0; i<args.Length; i++)
            {
                Console.WriteLine("args[" + i + "] = " + args[i]);
            }

            Console.WriteLine(args);

            Console.ReadKey();
        }
    }
}

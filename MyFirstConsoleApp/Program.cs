using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Add(int x)
        {
            Console.WriteLine("In Add(int x) before      x = " + x);
            x += 4;
            Console.WriteLine("In Add(int x) after       x = " + x);
        }

        static void Add(ref int x)
        {
            Console.WriteLine("In Addr(ref int x) before x = " + x);
            x += 4;
            Console.WriteLine("In Addr(ref int x) after  x = " + x);
        }

        static void Add(int? x)
        {
            Console.WriteLine("In Addr(ref int x) before x = " + x);
            x += 4;
            Console.WriteLine("In Addr(ref int x) after  x = " + x);
        }

        static void Main(string[] args)
        {

            int a = 7;

            Console.WriteLine("before call Add       a = " + a);
            Add(a);
            Console.WriteLine("after call Add        a = " + a);

            Console.WriteLine("before call Addr      a = " + a);
            Add(ref a);
            Console.WriteLine("after call Addr       a = " + a);

            int? b=null;
            Console.WriteLine("before call Add       b = " + b);
            Add(b);
            Console.WriteLine("after call Add        b = " + b);


            Console.ReadKey();

            Console.WriteLine("Hello World!");
            Console.WriteLine("Args len:" + args.Length);

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("args[" + i + "] = " + args[i]);
            }

            Console.WriteLine(args);

            Console.ReadKey(false);
        }
    }
}

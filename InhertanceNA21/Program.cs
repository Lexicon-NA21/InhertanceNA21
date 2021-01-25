using System;
using System.Collections.Generic;

namespace InhertanceNA21
{
    class Program
    {
        static void Main(string[] args)
        {
            A c = new C();

            Console.WriteLine();

            var name = c.Name;

            C cc = (C)c;
            Double[] x = new [] { 1.0 , 2, 3, 4,6 };

            var dict = new Dictionary<string, int>();
        }
    }
}

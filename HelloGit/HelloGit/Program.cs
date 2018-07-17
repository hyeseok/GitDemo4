using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelloGit");

            double sum = 0;
            for(int i=0; i<100; i++)
            {
                sum += 0.1;
            }
            Console.WriteLine(sum);
        }
    }
}

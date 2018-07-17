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
            //int d = 0;

            //for(int i=0; i<10000; i++)
            //{
            //    d = d + i;

            //    if (i == 5001)
            //        d = d / 0;
            //}
            //Console.WriteLine(d);

            ////========================
            //Console.WriteLine("HelloGit");

            //double sum = 0;
            //double sum2 = 0;
            //for(int i=0; i<100; i++)
            //{
            //    sum += 0.1;
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine("\n");

            //for(int i=0; i<100; i++)
            //{
            //    sum2 += 0.5;
            //}
            //Console.WriteLine(sum2);


            //================================================================
            // java에서는 BigDecimal
            //decimal sum3 = 0;

            //for(int i=0; i<100; i++)
            //{
            //    // 0.5 <- double
            //    // 0.5m <- decimal (16byte 이기때문에 double형인 8byte보다 메모리를 많이 차지한다.)
            //    // 0.5f <- float
            //    sum3 = sum3 + 0.1m;  // 상수 리터럴
            //}
            //Console.WriteLine(sum3);


            // 마린의 체력이 10감소된 것을 Maring클래스의 MinusPh메서드를 불러서 적용.
            int hp = 0;
            int AfterHp;
            Marine marine = new Marine();
            AfterHp = marine.MinusPh(hp);
            Console.WriteLine("당신의 체력은 " +AfterHp + "입니다.");

            // =================================================
            // 팩토리얼 메인
            int a = GetFactorial(1);
            Console.WriteLine(a);

            int b = GetFactorial(2);
            Console.WriteLine(b);

            int c = GetFactorial(3);
            Console.WriteLine(c);
            
        }// end of main

        // 팩토리얼 메서드
        static int GetFactorial(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * GetFactorial(n - 1);

        }
    }
}

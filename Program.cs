using System;

namespace ข้อสอบข้อ_6
{
    class Program
    {
        static void Stair(int n,  char alp)
        {

            for (int i = 1; i <= n; i++)
            {
                int k;

                if (i % 2 != 0)
                    k = i + 1;
                else
                    k = i;

                for (int j = 0; j < k; j++)
                    Console.Write("{0}",alp);
                Console.WriteLine();
            }
        }
         static void Main()
        {
            char alp;
            alp = char.Parse(Console.ReadLine());
            int n ;
            n = int.Parse(Console.ReadLine());

            Stair(n, alp);
        }
    }
}

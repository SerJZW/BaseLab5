using System;

namespace BaseLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random f = new Random();
            int n1 = f.Next(2, 22);
            int n2 = f.Next(2, 22);
            int n3 = f.Next(2, 22);
            int n4 = f.Next(2, 22);
            int[,,,] M = new int[n1, n2, n3, n4];
            int[] result = new int[11];
            for (int i1 = 0; i1 < n1; ++i1)
            {
                for (int i2 = 0; i2 < n2; ++i2)
                {
                    for (int i3 = 0; i3 < n3; ++i3)
                    {
                        for (int i4 = 0; i4 < n4; ++i4)
                        {
                            M[i1, i2, i3, i4] = f.Next(0, 101);

                        }
                    }
                }

            }
            foreach (int i in M)
            {
                if (i % 10 == 0)
                {
                    if (i == 0) result[0] = result[0] + 1;
                    else if (i == 10) result[1] = result[1] + 1;
                    else if (i == 20) result[2] = result[2] + 1;
                    else if (i == 30) result[3] = result[3] + 1;
                    else if (i == 40) result[4] = result[4] + 1;
                    else if (i == 50) result[5] = result[5] + 1;
                    else if (i == 60) result[6] = result[6] + 1;
                    else if (i == 70) result[7] = result[7] + 1;
                    else if (i == 80) result[8] = result[8] + 1;
                    else if (i == 90) result[9] = result[9] + 1;
                    else if (i == 100) result[10] = result[10] + 1;
                }
            }
                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine($" { i * 10} - {result[i]}");
                }
            

        
        }
    }
}

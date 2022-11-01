using System;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace lab13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number 1
            int a, b, c;
            Console.WriteLine("Type 2 numbers 1 in line");
            Console.Write("-> ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("-> ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The summ of {a} and {b} is {a + b}");
            Console.WriteLine($"The substruction of {a} and {b} is {a - b}");
            Console.WriteLine($"The multiplication of {a} and {b} is {a * b}");
            Console.WriteLine($"The divigion of {a} and {b} is {a / b}");


            // Number 2
            Console.WriteLine($"The minimun!"); ;
            Console.WriteLine("Type 3 numbers 1 in line");
            Console.Write("-> ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("-> ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("-> ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The minimum of {a}, {b}, {c} is {Num2(a, b, c)}");
            Console.WriteLine($"The minimum of {a}, {b}, {c} is {Num2_2(a, b, c)}");

            // Number 3
            Console.WriteLine($"Amount of goods(t)   sale (rub)   Price(rub)");
            double sale = 0.1;
            int amountS = 100;
            int price = 300;
            for (int i = 20; i <= 200; i += 20)
            {
                if (i > amountS)
                    Console.WriteLine($"{i}   0   {i * price}");
                else
                    Console.WriteLine($"{i}   {i * sale}   {i * sale * price}");
            }

            // Number 4
            Mini(1, 2);
            Maxi(1, 2);


            // Number 5
            Task5();


            // Number 6
            Task6();
        }
        static int Num2(int a, int b, int c)
        {
            if (a > b)
                a = b;
            if (a > c)
                a = c;
            return a;
        }
        static int Num2_2(int a, int b, int c)
        {
            if (a < b) a = b;
            if (a > c) c = a;
            return c;
        }
        static void Mini(int a, int b)
        {
            if (a > b)
                Console.WriteLine($"The minimum is {b}");
            else
                Console.WriteLine($"The minimum is {a}");
        }
        static int Maxi(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        // Number 5
        static void Task5()
        {
            // 5.1
            int[] a = { 5, 7, 8, 123, 324, 43 };
            int[] b = new int[5];
            int[] c = new int[5];
            int minis = 1000000,
                minii = 0;
            int maxis = -1000000,
                maxii = 0;
            var rand = new Random();
            Console.WriteLine("Type massive of 5 numbers");
            for (int i = 0; i < 5; i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                new Random();
                c[i] = rand.Next(101);
            }

            // 5.2
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            // 5.3
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < minis)
                {
                    minis = a[i];
                    minii = i;
                }
                if (a[i] > maxis)
                {
                    maxis = a[i];
                    maxii = i;
                }
            }
            Console.WriteLine($"The max of 1st mass is {maxis} with {maxii} index");
            Console.WriteLine($"The min of 1st mass is {minis} with {minii} index");

            //5.3 (2 var)
            minis = 1000000;
            minii = 0;
            maxis = -1000000;
            maxii = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] < minis)
                {
                    minis = b[i];
                    minii = i;
                }
                if (b[i] > maxis)
                {
                    maxis = b[i];
                    maxii = i;
                }
            }

            // 5.3 (3 var) 
            Console.WriteLine($"The max of 2nd mass is {maxis} with {maxii} index");
            Console.WriteLine($"The min of 2nd mass is {minis} with {minii} index");
            minis = 1000000;
            minii = 0;
            maxis = -1000000;
            maxii = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] < minis)
                {
                    minis = c[i];
                    minii = i;
                }
                if (c[i] > maxis)
                {
                    maxis = c[i];
                    maxii = i;
                }
            }
            Console.WriteLine($"The max of 3nd mass is {maxis} with {maxii} index");
            Console.WriteLine($"The min of 3nd mass is {minis} with {minii} index");

            // 5.4
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }
            double midl = (s / (double)a.Length);
            Console.WriteLine($"The summ of 1st mass is {s}");
            Console.WriteLine($"The middle amount is {midl}");

            // 5.5
            int[] ish = a;
            int[] iis = a;
            int[] iisn = new int[a.Length];
            Array.Sort(a);
            int[] ai = a;
            Console.WriteLine($"The mass has been formated");
            for (int i = 0; i < ai.Length; i++)
            {
                ai[i] += (int)midl;
            }
            Console.WriteLine($"The mass is {ai}");
            Array.Reverse(ish);
            Array.Copy(iis, 1, iisn, 0, iis.Length - 1);
        }

        // Number 6
        static void Task6()
        {
            // 6.1
            var rand = new Random();
            int[,] array2d1 = new int[5, 2];
            int[,] array2d2 = new int[5, 2];
            int[,] array2d3 = new int[5, 2] { { 1, 2 }, { 2, 3 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            for (int i = 0; i < array2d1.Rank; i++)
            {
                for (int j = 0; j < array2d1.GetLength(i); j++)
                {
                    new Random();
                    Console.WriteLine($"Type element of {i} line and {j} index -> ");
                    array2d1[i, j] = Convert.ToInt32(Console.ReadLine());
                    array2d2[i, j] = rand.Next(101);
                }
            }

            // 6.2
            Outputer(array2d1);
            Outputer(array2d2);
            Outputer(array2d3);

            // 6.3
            int[] inex = Maxi2d(array2d1);
            Console.WriteLine($"The maximum of 1st is {inex[0]} with coord {inex[1]} , {inex[2]}.");
            inex = Mini2d(array2d1);
            Console.WriteLine($"The minimum of 1st is {inex[1]} with coord {inex[1]} , {inex[2]}.");
            inex = Maxi2d(array2d2);
            Console.WriteLine($"The maximum of 2nd is {inex[0]} with coord {inex[1]} , {inex[2]}.");
            inex = Mini2d(array2d2);
            Console.WriteLine($"The minimum of 2nd is {inex[1]} with coord {inex[1]} , {inex[2]}.");
            inex = Maxi2d(array2d3);
            Console.WriteLine($"The maximum of 3th is {inex[0]} with coord {inex[1]} , {inex[2]}.");
            inex = Mini2d(array2d3);
            Console.WriteLine($"The minimum of 3th is {inex[1]} with coord {inex[1]} , {inex[2]}.");


            //6.4
            int[] mas1d = Summa2d(array2d1);
            Console.Write("The summs are ");
            for (int i = 0; i < mas1d.Length; i++)
            {
                Console.Write(mas1d[i] + " ");
            }
            Console.WriteLine();

            //6.5
            

        }
        static void Outputer(int[,] a)
        {
            for (int i = 0; i < a.Rank; i++)
            {
                for (int j = 0; j < a.GetLength(i); j++)
                {
                    Console.WriteLine($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static int[] Maxi2d(int[,] a)
        {
            int[] index = new int[3];
            index[0] = 0;
            for (int i = 0; i < a.Rank; i++)
            {
                for (int j = 0; j < a.GetLength(i); j++)
                {
                    if (a[i, j] >= index[0])
                    {
                        index[0] = a[i, j];
                        index[1] = i;
                        index[2] = j;
                    }
                    
                }
            }
            return index;
        }
        static int[] Mini2d(int[,] a)
        {
            int[] index = new int[3];
            index[0] = 10000000;
            for (int i = 0; i < a.Rank; i++)
            {
                for (int j = 0; j < a.GetLength(i); j++)
                {
                    if (a[i, j] <= index[0])
                    {
                        index[0] = a[i, j];
                        index[1] = i;
                        index[2] = j;
                    }

                }
            }
            return index;
        }
        static int[] Summa2d(int[,] a)
        {
            int[] s = new int[a.Length];
            for (int i = 0; i < a.Rank; i++)
            {
                s[i] = 0;
                for (int j = 0; j < a.GetLength(i); j++)
                {
                    s[i] += a[i, j];
                }
            }
            return s;
        }
        static int Getlen2d(int[,] a)
        {
            int leng = 1;
            for (int i = 0; i < a.Rank; i++)
            {
                leng *= a.GetLength(i);
            }
            return leng;
        }
    }
}

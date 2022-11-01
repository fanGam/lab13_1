using System;
using System.IO;
using System.Text;
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

            // Number 7
            Task7();
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
            int temp = 0;
            for (int i = 0; i < array2d1.Rank; i++)
            {
                for (int j = 0; j < array2d1.GetLength(i) - 1; j++)
                {
                    for (int h = 0; h < array2d1.GetLength(i); h++)
                    {
                        if (array2d1[i, j] > array2d1[j, h])
                        {
                            temp = array2d1[i, j];
                            array2d1[i, j] = array2d1[j, h];
                            array2d1[j, h] = temp;
                        }
                    }
                }
            }

            //
        }
        static void Task7()
        {
            // 7.3
            string input;
            string output = "";
            bool Name = true;
            Console.WriteLine("Type full name of person!");
            input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ') Name = false;
                if (Name)
                {
                    output += input[i];
                }
                else
                {
                    if (input[i] == ' ') output += " " + input[i + 1] + ".";
                }
            }
            Console.WriteLine(output);

            // 7.2
            input = "";
            string temp = "";
            int Day = -1, Month = -1, Year = -1;
            Console.WriteLine("Type data in string!");
            input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    if (Day == -1)
                    {
                        Day = Convert.ToInt32(temp);
                    }
                    else if (Month == -1)
                    {
                        switch (temp)
                        {
                            case "January": Month = 1; break;
                            case "February": Month = 2; break;
                            case "March": Month = 3; break;
                            case "April": Month = 4; break;
                            case "May": Month = 5; break;
                            case "June": Month = 6; break;
                            case "July": Month = 7; break;
                            case "August": Month = 8; break;
                            case "September": Month = 9; break;
                            case "October": Month = 10; break;
                            case "November": Month = 11; break;
                            case "December": Month = 12; break;
                            default: Month = 1; break;
                        }
                    }
                    else if (Year == -1)
                    {
                        Year = Convert.ToInt32(temp);
                    }
                }
                else
                {
                    temp += input[i];
                }
            }
            Console.WriteLine($"{Year}-{Month}-{Day}");
        }
        static void Task8()
        {

        }
        struct Worker
        {
            public int Id;
            public string Name;
            public string Department;
            public int Salary;
            public void GetInfo()
            {
                Console.WriteLine("Type new Id");
                Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type name");
                Name = Console.ReadLine();
                Console.WriteLine("Type department");
                Department = Console.ReadLine();
                Console.WriteLine("Type salary");
                Salary = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Task9()
        {
            // 9.1
            string path = "MyDir\\file.txt";
            string input = File.ReadAllText(path);
            int[] mass = new int[input.Length];
            string[] readEveryLine = new string[input.Length];
            for (int i = 0; i < readEveryLine.Length; i++)
            {
                mass[i] = Convert.ToInt32(readEveryLine[i]);
            }
            Console.WriteLine($"The summ is {SummerMass(mass)}");

            // 9.2
            Array.Sort(mass);
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }

            // 9.3
            File.Create("Newfile.txt");
            string path2 = "MyDir\\Newfile.txt";
            for (int i = 0; i < mass.Length; i++)
            {
                File.WriteAllText(path2, Convert.ToString(mass[i]));
            }
        }

        class Person
        {
            private string _name = "";

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public void Print()
            {
                Console.WriteLine(Name);
            }
        }

        class Employee : Person
        {
            private int _id = 0;
            private string _Department = "";

            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }
            public string Department
            {
                get { return _Department; }
                set { _Department = value; }
            }

            public void PrintID()
            {
                Console.WriteLine(Id);
            }
            public void PrintDep()
            {
                Console.WriteLine(Department);
            }
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
        static int[] Sorter(int[] a)
        {
            Array.Sort(a);
            return a;
        }
        static int SummerMass(int[] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }
            return s;
        }
    }
}

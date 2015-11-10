using System;

namespace ProgrammingSkills
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(Playground.MinAvgTwoSlice(new[] { 4, 2, 2, 5, 1, 5, 8 }));

            //Console.WriteLine(Playground.CountDiv(6, 11, 2));
            //Console.WriteLine(Playground.CountDiv(6, 11, 3));
            //Console.WriteLine(Playground.CountDiv(6, 11, 4));
            //Console.WriteLine(Playground.CountDiv(6, 12, 4));

            //Playground.SwapElementsForEqualSum(new[] { 1, 3, 5, 7 }, new[] { 1, 2, 4, 3 });

            //Console.WriteLine(Playground.TapeEquilibrium(new[] { 3, 1, 2, 4, 3 }));

            //TestPrefixSetS1();

            //TestEquiS1();

            Console.WriteLine(Playground.MaxCounters(5, new[] { 3, 4, 4, 6, 1, 4, 4 }));

            Console.WriteLine("////////////////");

            //Console.WriteLine(Playground.CountDiv2(6, 11, 2));
            //Console.WriteLine(Playground.CountDiv2(6, 11, 3));
            //Console.WriteLine(Playground.CountDiv2(6, 11, 4));
            //Console.WriteLine(Playground.CountDiv2(6, 12, 4));

            //Playground.SwapElementsForEqualSum(new[] { 1, 3, 5, 8 }, new[] { 1, 2, 4, 3 });

            long a = 6;
            long b = 2;
            long res;
            long rem;
            
            //rem = Math.DivRem(a, b, out res);

            //Console.WriteLine(res + " " + rem);

            //TestPrefixSetS2();

            //TestequiS2();

            // Filtering
            Console.WriteLine("Filtering");

            var list = new List<int>();
            for (var i = 0; i < 20; i++)
            {
                list.Add(i);
            }

            var filteredList = Filtering.FilterEnumerable(list, 8).ToList();

            Console.WriteLine("Original list: ");
            foreach (var num in list)
            {
                Console.Write("{0} ", num);
            }

            Console.WriteLine("\nFiltered list: ");
            foreach (var num in filteredList)
            {
                Console.Write("{0} ", num);
            }

            Console.WriteLine();
            Console.ReadLine();
        }

        private static void TestEquiS1()
        {
            // Test Equi
            var equi = new Equi();

            Console.WriteLine(equi.Solution(new[] { -1, 3, -4, 5, 1, -6, 2, 1 }, 8));
            Console.WriteLine(equi.Solution(new int[0], 0));
            Console.WriteLine(equi.Solution(new[] { 5 }, 1));
            Console.WriteLine(equi.Solution(new[] { 1, 2 }, 2));

            Console.WriteLine("--------------");

            Console.WriteLine(equi.Solution(new[] { 2147483647 }, 1));
            Console.WriteLine(equi.Solution(new[] { 2147483647, 2147483647, 2147483647 }, 3));

            Console.WriteLine(equi.Solution(new[] { -2147483647 }, 1));
            Console.WriteLine(equi.Solution(new[] { -2147483647, -2147483647, -2147483647 }, 3));

            Console.WriteLine("--------------");

            Console.WriteLine(equi.Solution(new[] { 3, 2, -5, 1 }, 4));
            Console.WriteLine(equi.Solution(new[] { 2, 2, -4 }, 3));

            Console.WriteLine("--------------");

            var largeNegOnesSeq = new int[100000];
            for (int i = 0; i < 100000; i++)
            {
                largeNegOnesSeq[i] = -1;
            }

            Console.WriteLine(equi.Solution(largeNegOnesSeq, 100000));
        }

        private static void TestequiS2()
        {
            // Test Equi
            var equi = new Equi();

            Console.WriteLine(equi.Solution2(new[] { -1, 3, -4, 5, 1, -6, 2, 1 }, 8));
            Console.WriteLine(equi.Solution2(new int[0], 0));
            Console.WriteLine(equi.Solution2(new[] { 5 }, 1));
            Console.WriteLine(equi.Solution2(new[] { 1, 2 }, 2));

            Console.WriteLine("--------------");

            Console.WriteLine(equi.Solution2(new[] { 2147483647 }, 1));
            Console.WriteLine(equi.Solution2(new[] { 2147483647, 2147483647, 2147483647 }, 3));

            Console.WriteLine(equi.Solution2(new[] { -2147483647 }, 1));
            Console.WriteLine(equi.Solution2(new[] { -2147483647, -2147483647, -2147483647 }, 3));

            Console.WriteLine("--------------");

            Console.WriteLine(equi.Solution2(new[] { 3, 2, -5, 1 }, 4));
            Console.WriteLine(equi.Solution2(new[] { 2, 2, -4 }, 3));

            Console.WriteLine("--------------");

            var largeNegOnesSeq = new int[100000];
            for (int i = 0; i < 100000; i++)
            {
                largeNegOnesSeq[i] = -1;
            }

            Console.WriteLine(equi.Solution2(largeNegOnesSeq, 100000));
        }

        private static void TestPrefixSetS1()
        {
            var pref = new PrefixSet();

            Console.WriteLine(pref.Solution(new[] { 2, 2, 1, 0, 1 }));

            const int Capacity = 100000;
            var rand = new Random();
            var extremeSequence = new List<int>(Capacity);
            for (int i = 0; i < Capacity; i++)
            {
                extremeSequence.Add(rand.Next(-100000, 100000));
            }

            var stopwatch = new Stopwatch();

            stopwatch.Start();
            var result = pref.Solution(extremeSequence.ToArray());
            stopwatch.Stop();

            Console.WriteLine(result + "|| Elapsed time: " + stopwatch.Elapsed);
        }

        private static void TestPrefixSetS2()
        {
            var pref = new PrefixSet();

            Console.WriteLine(pref.Solution2(new[] { 2, 2, 1, 0, 1 }));

            const int Capacity = 100000;
            var rand = new Random();
            var extremeSequence = new List<int>(Capacity);
            for (int i = 0; i < Capacity; i++)
            {
                extremeSequence.Add(rand.Next(-100000, 100000));
            }

            var stopwatch = new Stopwatch();

            stopwatch.Start();
            var result = pref.Solution2(extremeSequence.ToArray());
            stopwatch.Stop();

            Console.WriteLine(result + "|| Elapsed time: " + stopwatch.Elapsed);
        }
    }
}


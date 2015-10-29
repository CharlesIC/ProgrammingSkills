namespace ProgrammingSkills
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Playground
    {
        public static void SwapElementsForEqualSum(int[] A, int[] B)
        {
            decimal sumA = A.Sum();
            decimal sumB = B.Sum();

            decimal dSum = sumA - sumB;

            if (dSum % 2 == 1)
            {
                Console.WriteLine("No swaps possible");
                return;
            }

            var d = (int)dSum / 2;

            var dictB = new Dictionary<int, List<int>>();
            for (int i = 0; i < B.Count(); i++)
            {
                if (!dictB.ContainsKey(B[i]))
                {
                    dictB.Add(B[i], new List<int>());
                }

                dictB[B[i]].Add(i);
            }

            var swaps = new List<Tuple<int, List<int>>>();
            for (int i = 0; i < A.Count(); i++)
            {
                List<int> idx;
                if (dictB.TryGetValue(A[i] - d, out idx))
                {
                    swaps.Add(new Tuple<int, List<int>>(i, idx));
                }
            }

            Console.WriteLine("Possible swaps:");
            foreach (var tuple in swaps)
            {
                Console.Write(A[tuple.Item1] + " & [");
                tuple.Item2.ForEach(x => Console.Write(B[x] + ","));
                Console.Write("]\n");
            }
        }

        public static int TapeEquilibrium(int[] A)
        {
            if (A.Count() == 0)
            {
                return -1;
            }

            decimal sum = 0;
            foreach (var num in A)
            {
                sum += num;
            }

            decimal leftSum = A[0];
            decimal diff = Math.Abs(sum - (2 * leftSum));
            for (int i = 2; i < A.Count(); i++)
            {
                leftSum += A[i];

                decimal currDiff = Math.Abs(sum - (2 * leftSum));

                if (currDiff < diff)
                {
                    diff = currDiff;
                }
            }

            return (int)diff;
        }

        public static int PermCheck(int[] A)
        {
            var counter = new HashSet<int>();
            var max = 0;

            foreach (var num in A)
            {
                if (counter.Contains(num))
                {
                    return 0;
                }
                counter.Add(num);
                max = num > max ? num : max;
            }

            if (counter.Count < max)
            {
                return 0;
            }

            return 1;
        }

        public static int FrogRiverOne(int X, int[] A)
        {
            var positionsWithLeaves = new HashSet<int>();

            for (int i = 0; i < A.Count(); i++)
            {
                if (!positionsWithLeaves.Contains(A[i]))
                {
                    positionsWithLeaves.Add(A[i]);
                }

                if (positionsWithLeaves.Count == X)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int MissingInteger(int[] A)
        {
            if (A.Count() == 0)
            {
                return 1;
            }

            var counter = new HashSet<int>();

            foreach (var num in A)
            {
                if (num > 0 && !counter.Contains(num))
                {
                    counter.Add(num);
                }
            }

            for (int i = 1; i <= counter.Count; i++)
            {
                if (!counter.Contains(i))
                {
                    return i;
                }
            }

            return counter.Count + 1;
        }

        public static int[] MaxCounters(int N, int[] A)
        {
            var counters = new int[N];
            var excess = new Dictionary<int, int>();
            var baseValue = 0;
            var maxExcess = 0;

            foreach (var op in A)
            {
                var idx = op - 1;
                if (idx < N)
                {
                    if (excess.ContainsKey(idx)) { excess[idx]++; }
                    else { excess.Add(idx, 1); }
                    maxExcess = excess[idx] > maxExcess ? excess[idx] : maxExcess;
                }
                else if (idx == N)
                {
                    baseValue += maxExcess;
                    maxExcess = 0;
                    excess.Clear();
                }
            }

            for (int i = 0; i < counters.Count(); i++)
            {
                counters[i] = baseValue;
                if (excess.ContainsKey(i)) { counters[i] += excess[i]; }
            }

            return counters;
        }

        public static int MushroomPicker(int[] A)
        {
            return -1;
        }

        public static int PassingCars(int[] A)
        {
            var prefixSums = new int[A.Count() + 1];
            for (int i = 1; i <= A.Count(); i++)
            {
                prefixSums[i] = prefixSums[i - 1] + A[i - 1];
            }

            decimal passingPairs = 0;
            for (int i = 0; i < A.Count(); i++)
            {
                if (A[i] == 0)
                {
                    passingPairs += prefixSums[A.Count()] - prefixSums[i + 1];
                }
            }

            return passingPairs > 1000000000 ? -1 : (int)passingPairs;
        }

        public static int CountDiv(int A, int B, int K)
        {
            var multiplier = Math.Ceiling((double)A / K);
            int firstMultipleInRange = K * (int)multiplier;

            return (int)Math.Ceiling((double)(B - firstMultipleInRange + 1) / K);
        }

        public static int CountDiv2(int A, int B, int K)
        {
            return (int)(Math.Floor((double)B / K) - Math.Floor((double)(A - 1) / K));
        }

        public static int MinAvgTwoSlice(int[] A)
        {
            int N = A.Count();

            double minAvg = double.MaxValue;
            int minAvgSliceStart = 0;

            // Try 2-element slices
            for (int i = 0; i < N - 2; i++)
            {
                double sliceAvg = (double)(A[i] + A[i + 1]) / 2;

                if (sliceAvg < minAvg)
                {
                    minAvg = sliceAvg;
                    minAvgSliceStart = i;
                }
            }

            // Try 3-element slices
            for (int i = 0; i < N - 3; i++)
            {
                double sliceAvg = (double)(A[i] + A[i + 1] + A[i + 2]) / 3;

                if (sliceAvg < minAvg)
                {
                    minAvg = sliceAvg;
                    minAvgSliceStart = i;
                }
            }

            return minAvgSliceStart;
        }
    }
}


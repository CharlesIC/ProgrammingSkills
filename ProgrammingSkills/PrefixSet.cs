namespace ProgrammingSkills
{
    using System.Collections.Generic;
    using System.Linq;

    // you can also use other imports, for example:
    // using System.Collections.Generic;

    // you can use Console.WriteLine for debugging purposes, e.g.
    // Console.WriteLine("this is a debug message");

    public class PrefixSet
    {
        public int Solution(int[] a)
        {
            var uniqueValues = a.Distinct().ToList();

            for (int i = 0; i < a.Count(); i++)
            {
                if (uniqueValues.Contains(a[i]))
                {
                    uniqueValues.Remove(a[i]);
                }

                if (uniqueValues.Count == 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public int Solution2(int[] a)
        {
            var uniqueValues = new HashSet<int>();
            foreach (var num in a)
            {
                if (!uniqueValues.Contains(num))
                {
                    uniqueValues.Add(num);
                }
            }

            for (int i = 0; i < a.Count(); i++)
            {
                if (uniqueValues.Contains(a[i]))
                {
                    uniqueValues.Remove(a[i]);
                }

                if (uniqueValues.Count == 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

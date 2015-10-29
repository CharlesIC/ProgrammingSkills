namespace ProgrammingSkills
{
    public class Equi
    {
        public int Solution(int[] a, int n)
        {
            // Special cases
            if (n == 0)
            {
                return -1;
            }
            
            if (n == 1)
            {
                return 0;
            }

            // Initialise cumulative sum array
            var cumLeftSum = new int[n + 1];
            cumLeftSum[0] = cumLeftSum[n - 1] = 0;

            for (int i = 1; i <= n; i++)
            {
                cumLeftSum[i] = cumLeftSum[i - 1] + a[i - 1];
            }

            // Find total sum
            var totalSum = cumLeftSum[n];

            // Find equilibrium index
            for (int i = 0; i < n; i++)
            {
                var rightSum = totalSum - cumLeftSum[i + 1];

                if (cumLeftSum[i] == rightSum)
                {
                    return i;
                }
            }

            return -1;
        }

        public int Solution2(int[] a, int n)
        {
            if (n == 0)
            {
                return -1;
            }

            // Find total sum
            decimal totalSum = 0;
            foreach (var num in a)
            {
                totalSum += num;
            }

            // Find equilibrium index
            long leftSum = 0;
            for (int i = 0; i < n; i++)
            {
                decimal rightSum = totalSum - leftSum - a[i];

                if (leftSum == rightSum)
                {
                    return i;
                }

                leftSum += a[i];
            }

            return -1;
        }
    }
}

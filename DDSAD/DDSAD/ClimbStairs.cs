namespace DDSAD
{
    internal class ClimbStairs
    {
        public int DistinctWayToClimbStairs(int n)
        {
            if (n < 0)
                return 0;
            if (n == 0)
                return 1;
            int ans = DistinctWayToClimbStairs(n - 1) + DistinctWayToClimbStairs(n - 2);
            return ans;
        }
    }
}

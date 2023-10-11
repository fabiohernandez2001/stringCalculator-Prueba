namespace stringCalculator
{
    public static class stringCalculator
    {
        public static int add(string op)
        {
            string[] argvs = op.Split(',');
            int sum = 0;
            for (int i = 0;i<argvs.Length;i++)
            {
                sum += Int32.Parse(argvs[i]);
            }
            return sum; 
        }
    }
}
namespace stringCalculator
{
    public static class stringCalculator
    {
        public static int add(string op)
        {
            if (op.Equals("")){return 0;}
            string[3] argvs = op.Split(',');
            int sum = 0;
            for (int i = 0;i<3;i++)
            {
                sum += Int32.Parse(argvs[i]);
            }
            return sum; 
        }
    }
}
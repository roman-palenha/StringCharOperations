namespace StringCharOperations
{
    internal class InsertOperation : IOperationStrategy
    {
        public string Solve(string s, string t)
        {
            for (int i = 0; i <= s.Length; i++)
            {
                string temp = s.Substring(0, i) + t[i] + s.Substring(i);
                if (temp.Equals(t))
                {
                    return Constants.Insert + $" {t[i]}";
                }
            }

            return Constants.Impossible;
        }
    }
}

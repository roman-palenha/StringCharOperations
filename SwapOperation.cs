namespace StringCharOperations
{
    public class SwapOperation : IOperationStrategy
    {
        public string Solve(string s, string t)
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] != t[i])
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[j] == t[i] && s[i] == t[j])
                        {
                            string temp = s.Substring(0, i) + s[j] + s.Substring(i + 1, j - i - 1) + s[i] + s.Substring(j + 1);
                            if (temp.Equals(t))
                            {
                                return Constants.Swap + $" {s[i]} {s[j]}";
                            }
                        }
                    }
                }
            }

            return Constants.Impossible;
        }
    }
}

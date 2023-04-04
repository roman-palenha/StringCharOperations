namespace StringCharOperations
{
    public class ReplaceOperation : IOperationStrategy
    {
        public string Solve(string s, string t)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != t[i])
                {
                    string temp = s.Substring(0, i) + t[i] + s.Substring(i + 1);
                    if (temp.Equals(t))
                    {
                        return Constants.Replace + $" {s[i]} {t[i]}";
                    }
                }
            }

            return Constants.Impossible;
        }
    }
}

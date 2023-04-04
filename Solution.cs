namespace StringCharOperations
{
    public class Solution
    {
        private IOperationStrategy? _operationStrategy;
        public string Solve(string S, string T)
        {
            if (S.Equals(T))
                return Constants.Equal;

            if (T.Length == S.Length + 1)
            {
                _operationStrategy = new InsertOperation();
            }
            else if (S.Length == T.Length)
            {
                _operationStrategy = CheckChars(S, T) ? new SwapOperation() : new ReplaceOperation();
            }

            var result = _operationStrategy?.Solve(S, T);
            return result ?? Constants.Impossible;
        }

        private bool CheckChars(string s, string t)
        {
            var sChars = s.ToCharArray();
            var tChars = t.ToCharArray();

            Array.Sort(sChars);
            Array.Sort(tChars);

            return sChars.SequenceEqual(tChars);
        }
    }
}

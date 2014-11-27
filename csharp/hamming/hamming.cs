namespace Exercism.hamming
{
    public static class Hamming
    {
        public static int Compute(string left, string right)
        {
            left = left.ToUpper();
            right = right.ToUpper();
            if (left.Length > right.Length)
                left = left.Substring(0, right.Length);
            else if (right.Length > left.Length)
                right = right.Substring(0, left.Length);
            if (left.Length == 0)
                return 0;

            int hammingDiff = 0;
            for (int i = 0; i < left.Length; i++)
            {
                if (left[i] != right[i])
                    ++hammingDiff;
            }

            return hammingDiff;
        }
    }
}

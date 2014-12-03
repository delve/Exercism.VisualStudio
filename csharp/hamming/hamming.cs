using System.Linq;
namespace Exercism.hamming
{
    public static class Hamming
    {
        public static int Compute(string left, string right)
        {
            left = left.ToUpper();
            right = right.ToUpper();
            if (left.Length != right.Length)
            {
                int minLen = System.Math.Min(left.Length, right.Length);
                if (minLen == 0)
                    return 0;
                left = left.Substring(0, minLen);
                right = right.Substring(0, minLen);
            }

            return left.Zip(right, (lchar, rchar) => lchar != rchar)
                .Count(val => val);
        }
    }
}
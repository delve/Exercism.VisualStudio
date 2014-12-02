using System.Linq;
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

            return (left.Zip(right, (lchar, rchar) => lchar != rchar ? 1 : 0)).Sum();
        }
    }
}

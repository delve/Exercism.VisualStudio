using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.anagram
{
    public class Anagram
    {
        public string MasterWord { get; set; }
        public Dictionary<char, int> MasterHash { get; set; }

        public Anagram(string master)
        {
            this.MasterWord = master.ToLower();
            this.MasterHash = HashString(this.MasterWord);
        }

        public string[] Match(string[] candidates)
        {
            List<string> results = new List<string>();

            foreach (string mixedCaseCandidate in candidates)
            {
                string candidate = mixedCaseCandidate.ToLower();

                if (candidate.Length != this.MasterWord.Length) continue;
                if (candidate == MasterWord) continue;
                if (DictionaryEquals(this.MasterHash, HashString(candidate)))
                    results.Add(mixedCaseCandidate);
            }

            return results.ToArray();
        }

        private Dictionary<char, int> HashString(string input)
        {
            Dictionary<char, int> output = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (output.ContainsKey(input[i]))
                    output[input[i]] = ++output[input[i]];
                else
                    output.Add(input[i], 1);
            }

            return output;
        }

        public static bool DictionaryEquals<TKey, TVal>(IDictionary<TKey,TVal> left, IDictionary<TKey,TVal> right)
        {
            if (left == right) return true;
            if (left.Count != right.Count) return false;
            if (left == null || right == null) return false;

            IEqualityComparer<TVal> compare = EqualityComparer<TVal>.Default;
            foreach (KeyValuePair<TKey,TVal> leftPair in left)
            {
                TVal rightVal;
                if (!right.TryGetValue(leftPair.Key, out rightVal)) return false;
                if (!compare.Equals(leftPair.Value, rightVal)) return false;
            }

            return true;
        }
    }
}

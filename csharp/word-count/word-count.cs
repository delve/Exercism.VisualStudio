using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.word_count
{
    public class Phrase
    {
        private readonly string inputPhrase;
        private static readonly char[] delimiters = { ' ', '!', '&', '@', '$', '%', '^', '&', ':', ',', '.' };

        public Phrase(string input)
        {
            this.inputPhrase = input.ToLower();
        }

        public Dictionary<string, int> WordCount()
        {
            return inputPhrase.Split(delimiters)
                .Where(word => word.Any(c => Char.IsLetterOrDigit(c)))
                .Select(word => word.First() == '\'' ? word.Substring(1) : word)
                .Select(word => word.Last() == '\'' ? word.Substring(0, word.Length - 1) : word)
                .GroupBy(word => word)
                .Select(group => new KeyValuePair<string, int>(group.Key, group.Count()))
                .ToDictionary(pair => pair.Key, pair => pair.Value);
        }
    }
}

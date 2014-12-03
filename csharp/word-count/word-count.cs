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
                .Where(word => word.Any(Char.IsLetterOrDigit))
                .Select(word => word.TrimStart('\'').TrimEnd('\''))
                .GroupBy(word => word)
                .Select(group => new Tuple<string, int>(group.Key, group.Count()))
                .ToDictionary(pair => pair.Item1, pair => pair.Item2);
        }
    }
}

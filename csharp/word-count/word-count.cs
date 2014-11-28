using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.word_count
{
    public class Phrase
    {
        public string InputPhrase { get; set; }

        public Phrase(string input)
        {
            this.InputPhrase = input.ToLower();
        }

        public Dictionary<string, int> WordCount()
        {

            return new Dictionary<string,int>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            string testPhrase = "go ' Go '' GO";
            testPhrase = "She said, 'let's meet at twelve o'clock'";

            var phrase = new Exercism.word_count.Phrase(testPhrase);
            phrase.WordCount();
        }
    }
}

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
            var detector = new Exercism.anagram.Anagram("Orchestra");
            var words = new[] { "cashregister", "Carthorse", "radishes" };
            var results = new[] { "Carthorse" };
            detector.Match(words);
        }
    }
}

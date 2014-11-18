using System.Linq;
using System.Text.RegularExpressions;

namespace Exercism.bob
{
    class Bob
    {
        public string Hey(string wahWahWah)
        {
            if (IsSilence(wahWahWah))
                return "Fine. Be that way!";
            if (IsYelling(wahWahWah))
                return "Whoa, chill out!";
            if (IsQuestion(wahWahWah))
                return "Sure.";
            // Yeah, whatever dude.
            return "Whatever.";
        }

        private bool IsQuestion(string wahWahWah)
        {
            if (wahWahWah.Last() == '?')
                return true;
            return false;
        }

        private bool IsYelling(string wahWahWah)
        {
            Regex search = new Regex("[a-z]", RegexOptions.IgnoreCase);
            if (wahWahWah.ToUpper() == wahWahWah && search.IsMatch(wahWahWah))
                return true;
            return false;
        }

        private bool IsSilence(string wahWahWah)
        {
            if (wahWahWah.Trim().Length == 0)
                return true;
            return false;
        }
    }
}

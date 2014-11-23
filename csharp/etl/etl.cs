using System.Collections.Generic;
using System.Linq;

namespace Exercism.etl
{
    public static class ETL
    {
        public static Dictionary<string, int> Transform(Dictionary<int, IList<string>> rows)
        {
            IEnumerable<KeyValuePair<string, int>> output;

            output = rows.SelectMany(
                row => row.Value.Select(
                    letter => new KeyValuePair<string, int>(letter.ToLower(), row.Key)));

            return output.ToDictionary(row => row.Key, row => row.Value);
        }
    }
}

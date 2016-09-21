using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDiacritics
{
    public class TextProcessor
    {

        public Dictionary<char, char> correspondances = new Dictionary<char, char>()
        {
            {'à', 'a' },
            {'â', 'a' },
            {'ä', 'a' },
            {'ç', 'c' },
            {'è', 'e' },
            {'é', 'e' },
            {'ê', 'e' },
            {'ë', 'e' },
            {'î', 'i' },
            {'ï', 'i' },
            {'ô', 'o' },
            {'ö', 'o' },
            {'ù', 'u' },
            {'û', 'u' },
            {'ü', 'u' }
        };

        public string Strip(string input)
        {
            string output = input;
            foreach (var pair in correspondances)
            {
                output = output.Replace(pair.Key, pair.Value);
            }
            return output;
        }

    }
}

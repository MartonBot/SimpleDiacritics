using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDiacritics
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "j’ai mangé du gâteau blanc la semaine dernière";
            var normalizedString = text.Normalize(NormalizationForm.FormC);

            Console.Write(normalizedString);
        }
    }
}

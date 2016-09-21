using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vec = MathNet.Numerics.LinearAlgebra.Vector<double>;
using _V = MathNet.Numerics.LinearAlgebra.VectorBuilder<double>;

namespace SimpleDiacritics
{

    class RawSample
    {

        private _V Vb = Vec.Build;

        private static char[] letters = { 'a', 'c', 'e', 'i', 'o', 'u' };

        // the number of characters taken into account on each side of the current character
        private int span = 4;
        // the character that we are trying to evaluate, could be a, c, e, i, o , u
        private char letter;

        // the characters spanning araound the central letter
        private char[] characters;

        public RawSample(string text, int index)
        {
            if (!letters.Contains(text[index]))
            {
                throw new Exception("This is not a valid letter to produce a sample.");
            }
            letter = text[index];
            characters = text.Substring(index - span, 2 * span + 1).ToCharArray();
        }

        // to produce a vector sample,
        // the structure is the following
        // 6 features for the central letter
        // then 27 features for each of the letters before
        // then 27 features for each of the letters after
        // so a total of 6 + 2 * span * 27 features

        public Vec ToVectorSample()
        {
            Vec sample = Vb.Dense(6 + 2 * span * 27);


            return sample;
        }

        private int[] ToAlphabetIndices(string s)
        {
            s = s.ToLower();
            byte[] bytes = Encoding.ASCII.GetBytes(s);
            int[] indices = bytes.Select(b => b - 96).Select(i => (i < 1 || i > 26) ? 0 : i).ToArray();
            return indices;
        }


    }
}

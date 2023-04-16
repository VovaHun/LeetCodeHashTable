using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableProblem
{
    internal class UniqueMorseCodeWords
    {
        char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        string[] morze = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

        Dictionary<char, string> AlphaMorze;

        public int UniqueMorseRepresentations(string[] words)
        {
            AlphaMorze = new Dictionary<char, string>();

            List<string> morzeWord = new List<string>();

            for (int i = 0; i < morze.Length; i++)
            {
                AlphaMorze.Add(alpha[i], morze[i]);
            }

            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToCharArray();

                string word = "";

                for (int j = 0; j < chars.Length; j++)
                {
                    word += AlphaMorze[chars[j]];
                }

                morzeWord.Add(word);
            }



            int different = 0;

            var a = morzeWord.GroupBy(x => x).Count();



            return different;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions
{
    internal class _804___Unique_Morse_Code_Words
    {

        public int UniqueMorseRepresentations(string[] words)
        {
            string[] transformations = new string[words.Length];
            int countWords = 0;

            Dictionary<string, string> dic = new Dictionary<string, string>
        {
            {"a", ".-"   },
            {"b", "-..." },
            {"c", "-.-." },
            {"d", "-.."  },
            {"e", "."    },
            {"f", "..-." },
            {"g", "--."  },
            {"h", "...." },
            {"i", ".."   },
            {"j", ".---" },
            {"k", "-.-"  },
            {"l", ".-.." },
            {"m", "--"   },
            {"n", "-."   },
            {"o", "---"  },
            {"p", ".--." },
            {"q", "--.-" },
            {"r", ".-."  },
            {"s", "..."  },
            {"t", "-"    },
            {"u", "..-"  },
            {"v", "...-" },
            {"w", ".--"  },
            {"x", "-..-" },
            {"y", "-.--" },
            {"z", "--.." }
        };

            foreach (string word in words)
            {
                string morseWord = "";

                foreach (char c in word)
                {
                    morseWord = morseWord + dic[c.ToString()].ToString();
                }

                bool achou = false;

                foreach (string s in transformations)
                {
                    if (s is not null && s.Equals(morseWord))
                    {
                        achou = true;
                    }
                }

                if (!achou)
                {
                    transformations[countWords] = morseWord;
                    countWords++;
                }

            }

            return countWords;


        }
    }
}

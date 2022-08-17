// See https://aka.ms/new-console-template for more information

string[] words = { "gin", "zen", "gig", "msg" };

int resultado = UniqueMorseRepresentations(words);


Console.WriteLine(resultado);


static int UniqueMorseRepresentations(string[] words)
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
using System;
using System.Text;
using System.Collections.Generic;

/*
 * Module Name: BrunoShifter
*/

namespace Pretentious.Components
{
    public static class BrunoShifter
    {
        private static Dictionary<string, string> _KEYMAP;

        public static void Initialize()
        {
            _KEYMAP = new Dictionary<string, string>();

            _KEYMAP.Add("a", "z");
            _KEYMAP.Add("b", "y");
            _KEYMAP.Add("c", "x");
            _KEYMAP.Add("d", "w");
            _KEYMAP.Add("e", "v");
            _KEYMAP.Add("f", "u");
            _KEYMAP.Add("g", "t");
            _KEYMAP.Add("h", "s");
            _KEYMAP.Add("i", "r");
            _KEYMAP.Add("j", "q");
            _KEYMAP.Add("k", "p");
            _KEYMAP.Add("l", "o");
            _KEYMAP.Add("m", "n");
            _KEYMAP.Add("n", "m");
            _KEYMAP.Add("o", "l");
            _KEYMAP.Add("p", "k");
            _KEYMAP.Add("q", "j");
            _KEYMAP.Add("r", "i");
            _KEYMAP.Add("s", "h");
            _KEYMAP.Add("t", "g");
            _KEYMAP.Add("u", "f");
            _KEYMAP.Add("v", "e");
            _KEYMAP.Add("w", "d");
            _KEYMAP.Add("x", "c");
            _KEYMAP.Add("y", "b");
            _KEYMAP.Add("z", "a");
        }

        public static string Bruno(string input)
        {
            StringBuilder start = new StringBuilder();
            StringBuilder end = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                    end.Append(input[i]);
                else
                    start.Append(input[i]);
            }
            input = start.ToString() + end.ToString();

            StringBuilder reform = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                string character = input[i].ToString();
                if (character == character.ToUpper())
                    character = character.ToUpper();

                if (_KEYMAP.ContainsKey(character))
                    reform.Append(_KEYMAP[character]);
                else
                    reform.Append(character);
            }
            return reform.ToString();
        }

        public static string DeBruno(string input)
        {
            StringBuilder reform = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                string character = input[i].ToString();
                if (character == character.ToUpper())
                    character = character.ToUpper();

                foreach (KeyValuePair<string, string> kvp in _KEYMAP)
                {
                    if (kvp.Value == character)
                        reform.Append(kvp.Key);
                }
                if (reform.Length - 1 != i)
                    reform.Append(character);
            }
            input = reform.ToString();

            int halfIndex = input.Length / 2;
            string start = input.Substring(0, halfIndex);
            string end = input.Substring(halfIndex, input.Length - halfIndex);
            reform = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                    reform.Append(end[i / 2]);
                else
                    reform.Append(start[i / 2]);
            }
            return reform.ToString();
        }
    }
}
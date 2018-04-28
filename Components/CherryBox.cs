using System;

/*
 * Module Name: CherryBox
*/

namespace Pretentious.Components
{
    public class CherryBox
    {
        private string[] _ITEMS;

        public void Initialize(int parts)
        {
            _ITEMS = new string[parts];
        }

        public void SeparateElements(string input)
        {
            int indexPositionIncrement = input.Length / _ITEMS.Length;
            int currentIndex = 0;

            for (int i = 0; i < _ITEMS.Length; i++)
            {
                if (i == _ITEMS.Length - 1)
                {
                    string finalPart = input.Substring(currentIndex, input.Length - currentIndex);
                    currentIndex += indexPositionIncrement;
                    _ITEMS[i] = finalPart;
                    continue;
                }

                string part = input.Substring(currentIndex, indexPositionIncrement);
                currentIndex += indexPositionIncrement;
                _ITEMS[i] = part;
            }
        }

        public string[] GetItems()
        {
            return _ITEMS;
        }
    }
}
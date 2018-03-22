using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day2_Corruption_Checksum
{
    public class RowManager
    {
        private List<int> rowNumbers = new List<int>();

        public RowManager()
        {
        }

        public int CalculateLargerMinusSmaller(string rowInput)
        {
            FormatRow(rowInput);
            int max = rowNumbers.Max();
            int min = rowNumbers.Min();

            var result = max - min;

            rowNumbers.Clear();

            return result;
        }

        private void FormatRow(string rowInput)
        {
            string[] rowtable = Regex.Split(rowInput, @"\s+");
            foreach (string number in rowtable)
            {
                rowNumbers.Add(int.Parse(number));
            }
        }
    }
}

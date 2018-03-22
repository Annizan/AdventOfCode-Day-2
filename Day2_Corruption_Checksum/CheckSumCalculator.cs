using Day2_Corruption_Checksum;
using System.Collections.Generic;

namespace Day2_Corruption_Checksum
{
    public class CheckSumCalculator
    {
        private List<string> rowList;
        private RowManager rowManager;

        public CheckSumCalculator(List<string> rowsList)
        {
            this.rowList = rowsList;
            rowManager = new RowManager();
        }

        public int Calculate()
        {
            var result = 0;

            foreach(string row in rowList)
            {
                result += rowManager.CalculateLargerMinusSmaller(row);
            }

            return result;
        }
    }
}

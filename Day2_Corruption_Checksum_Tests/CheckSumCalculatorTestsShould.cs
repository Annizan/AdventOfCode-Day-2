using Day2_Corruption_Checksum;
using NFluent;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Corruption_Checksum_Tests
{
    class CheckSumCalculatorTestsShould
    {
        [Test]
        public void Return_The_CheckSum_Of_The_Puzzle_Entered()
        {
            List<string> rowsList = new List<string> { "5 1 9 5", "7 5 3", "2 4 6 8" };
            CheckSumCalculator checkSumCalculator = new CheckSumCalculator(rowsList);
            Check.That(checkSumCalculator.Calculate()).IsEqualTo(18);
        }

    }
}

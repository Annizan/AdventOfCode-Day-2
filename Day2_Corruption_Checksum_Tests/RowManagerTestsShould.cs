using System;
using System.Linq;
using Day2_Corruption_Checksum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using NUnit.Framework;


namespace Day2_Corruption_Checksum_Tests
{
    public class RowManagerTestsShould
    {
        [TestCase("2 4 6 8", 6)]
        [TestCase("2 4 12 8", 10)]
        [TestCase("2 4   12 8", 10)]
        [TestCase("250    400 165 1000 56 1 876 172 4657 5001 574", 5000)]
        public void Give_The_Difference_Between_Smaller_And_Larger_Number_Of_A_Row(string rowInput, int expected)
        {
            RowManager rowManager = new RowManager();
            Check.That(rowManager.CalculateLargerMinusSmaller(rowInput)).IsEqualTo(expected);
        }
    }
}

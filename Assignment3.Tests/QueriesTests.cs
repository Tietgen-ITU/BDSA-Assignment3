using System;
using System.Collections.Generic;
using Xunit;

namespace BDSA2020.Assignment02.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void GetRowlingsWizards_returns_Hermione_Harry_Voldemort_Albus_Severus_Harry()
        {
            string[] expected = { "Hermione Granger", "Harry Potter", "Voldemort", "Albus Dumbledore", "Severus Snape", "Harry Potter" };
            var actual = Queries.GetRowlingsWizards();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetRowlingsWizardsLinq_returns_Hermione_Harry_Voldemort_Albus_Severus_Harry()
        {
            string[] expected = { "Hermione Granger", "Harry Potter", "Voldemort", "Albus Dumbledore", "Severus Snape", "Harry Potter" };
            var actual = Queries.GetRowlingsWizardsLinq();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSithYear_returns_1977()
        {
            var expected = 1977;
            var actual = Queries.GetSithYear();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSithYearLinq_returns_1977()
        {
            var expected = 1977;
            var actual = Queries.GetSithYearLinq();
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void GetUniqueHarryWizards_returns_Hermione_Harry_Voldemort_Albus_Severus_And_1997()
        {
            var expected = new List<(string, int?)> { ("Hermione Granger", 1997), ("Harry Potter", 1997), ("Voldemort", 1997), ("Albus Dumbledore", 1997), ("Severus Snape", 1997) };
            var actual = Queries.GetUniqueHarryWizards();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetUniqueHarryWizardsLinq_returns_Hermione_Harry_Voldemort_Albus_Severus_And_1997()
        {
            var expected = new List<(string, int?)> { ("Hermione Granger", 1997), ("Harry Potter", 1997), ("Voldemort", 1997), ("Albus Dumbledore", 1997), ("Severus Snape", 1997) };
            var actual = Queries.GetUniqueHarryWizardsLinq();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetWizardNamesInReverse_returns_Hermione_Harry_Voldemort_Albus_Severus_And_1997()
        {
            string[] expected = { "Gandalf The Gray", "Sauron", "Albus Dumbledore", "Harry Potter", "Harry Potter", "Hermione Granger", "Severus Snape", "Voldemort", "Darth Vader", "Digory Kirke", "Polly Plummer" };
            var actual = Queries.GetWizardNamesInReverse();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetWizardNamesInReverseLinq_returns_Hermione_Harry_Voldemort_Albus_Severus_And_1997()
        {
            string[] expected = { "Gandalf The Gray", "Sauron", "Albus Dumbledore", "Harry Potter", "Harry Potter", "Hermione Granger", "Severus Snape", "Voldemort", "Darth Vader", "Digory Kirke", "Polly Plummer" };
            var actual = Queries.GetWizardNamesInReverseLinq();
            Assert.Equal(expected, actual);
        }



    }
}

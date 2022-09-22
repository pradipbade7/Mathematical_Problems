using System.Collections.Generic;
using FluentAssertions;
using Implementation;
using TestTypes;
using Xunit;

namespace Tests
{
    public class TestCases
    {
        [Theory]
        [MemberData(nameof(TestData.SymmetricPointTestData), MemberType = typeof(TestData))]
        public void SymmetricPointTests(Point p, Point q, Point expected)
        {
            Assert.Equal(expected, SymmetricPoint.Calculate(p, q));
        }

        [Theory]
        [MemberData(nameof(TestData.JadenCasingTestData), MemberType = typeof(TestData))]
        public void JadenCasingTests(string input, string expected)
        {
            Assert.Equal(expected, JadenCasing.JadenCase(input));
        }

        [Theory]
        [MemberData(nameof(TestData.OutlierTestData), MemberType = typeof(TestData))]
        public void ParityOutlierTest(IReadOnlyCollection<int> numbers, int expected)
        {
            Assert.Equal(expected, ParityOutlier.Outlier(numbers));
        }

        [Theory]
        [MemberData(nameof(TestData.RgbToHexTestData), MemberType = typeof(TestData))]
        public void RgbToHexTest(Rgb value, string expected)
        {
            Assert.Equal(expected, RgbToHex.ConvertRgbToHex(value));
        }

        [Theory]
        [MemberData(nameof(TestData.PermutateTestData), MemberType = typeof(TestData))]
        public void PermutateTest(string str, IReadOnlyCollection<string> expected)
        {
            Permutation.Permutate(str).Should().BeEquivalentTo(expected);
        }

        [Theory(Timeout = 2000)]
        [MemberData(nameof(TestData.FibonacciTestData), MemberType = typeof(TestData))]
        public void FibonacciTest(int n, long expected)
        {
            Assert.Equal(expected, Fibonacci.CalculateNth(n));
        }
    }
}
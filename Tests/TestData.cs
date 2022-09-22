using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using TestTypes;

namespace Tests
{
    public class TestData
    {
        private static Faker _faker = new();
        public static IEnumerable<object[]> SymmetricPointTestData => new List<object[]>
        {
            new object[] { new Point(0, 0), new Point(1,1), new Point(2, 2) },
            new object[] { new Point(2, 6), new Point(-2, -6), new Point(-6, -18) },
            new object[] { new Point(10, -10), new Point(-10, 10), new Point(-30, 30) },
            new object[] { new Point(1, -35), new Point(-12, 1), new Point(-25, 37)},
            new object[] { new Point(1000, 15), new Point(-7, -214), new Point(-1014, -443)},
            new object[]{ new Point(0,0), new Point(0, 0), new Point(0, 0)}
        };

        public static IEnumerable<object[]> JadenCasingTestData => new List<string[]>
        {
            new []{ "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "Lorem Ipsum Dolor Sit Amet, Consectetur Adipiscing Elit, Sed Do Eiusmod Tempor Incididunt Ut Labore Et Dolore Magna Aliqua." },
            new []{ "The fact that there's a stairway to heaven and a highway to hell explains life well.", "The Fact That There's A Stairway To Heaven And A Highway To Hell Explains Life Well." },
            new []{ "The busker hoped that the people passing by would throw money, but they threw tomatoes instead, so he exchanged his hat for a juicer.", "The Busker Hoped That The People Passing By Would Throw Money, But They Threw Tomatoes Instead, So He Exchanged His Hat For A Juicer." },
        };

        public static IEnumerable<object[]> OutlierTestData => new List<object[]>
        {
            new object[]{ Enumerable.Range(0, 100).Select(_ => _faker.Random.Even(0, 2000)).Concat(new List<int>{1455}).OrderBy(i => i).ToImmutableList(), 1455 },
            new object[]{ Enumerable.Range(0, 100).Select(_ => _faker.Random.Odd(0, 2000)).Concat(new List<int> { 846 }).OrderBy(i => i).ToImmutableList(), 846 },

        };
        
        public static IEnumerable<object[]> RgbToHexTestData => new List<object[]>
        {
            new object[]{ new Rgb(255, 255, 255), "FFFFFF" },
            new object[]{ new Rgb(0, 255, 0), "00FF00" },
            new object[]{ new Rgb(255, 255, 0), "FFFF00" },
            new object[]{ new Rgb(0, 0, 0), "000000" },
            new object[]{ new Rgb(122, 122, 122), "7A7A7A" },
            new object[]{ new Rgb(23, 56, 200), "1738C8" },
        };

        public static IEnumerable<object[]> PermutateTestData => new List<object[]>
        {
            new object[]{"baab", new[]{ "baab", "baba", "bbaa", "abab", "abba", "aabb" } },
            new object[]{"1234", new[]{ "1234", "1243", "1324", "1342", "1423", "1432", "2134", "2143", "2314", "2341", "2413", "2431", "3124", "3142", "3214", "3241", "3412", "3421", "4123", "4132", "4213", "4231", "4312", "4321" } },
            new object[]{"c", new[]{ "c" } },
            new object[]{"", new string[]{  } },
        };

        public static IEnumerable<object[]> FibonacciTestData => new List<object[]>
        {
            new object[] { 0, 0L },
            new object[] { 1, 1L },
            new object[] { 2, 1L },
            new object[] { 3, 2L },
            new object[] { 4, 3L },
            new object[] { 5, 5L },
            new object[] { 6, 8L },
            new object[] { 7, 13L },
            new object[] { 28, 317811L },
            new object[] { 40, 102334155L },
            new object[] { 92, 7540113804746346429L }
        };
    }
}

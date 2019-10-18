using System;
using Xunit;
using static BinarySearch.Program;

namespace BinarySearchTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] one = { 1, 2, 3, 4, 5, 6, 7 };
            int one1 = 3;
            Assert.Equal(2, BinSearch(one, one1));
        }

        [Fact]
        public void Test2()
        {
            int[] two = { 8, 13, 27, 55, 57 };
            int two2 = 57;
            Assert.Equal(4, BinSearch(two, two2));
        }
        [Fact]
        public void Test3()
        {
            int[] three = { 6, 66, 666, 6666 };
            int three3 = 69;
            Assert.Equal(-1, BinSearch(three, three3));
        }
        [Fact]
        public void Test4()
        {
            int[] four = { };
            int four4 = 100;
            Assert.Equal(-1, BinSearch(four, four4));
        }

    }
}

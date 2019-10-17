using System;
using Xunit;
using static ArrayShift.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] tryarr = { 1, 4, 7, 2, 6 };
            int trynumb = 15;
            Assert.Equal(new int[] { 1, 4, 7, 15, 2, 6 }, insertShiftArray(tryarr, trynumb));
        }

        [Fact]
        public void Test2()
        {
            int[] tryarr = { 3, 5, 88, 11, 24, 9 };
            int trynumb = 0;
            Assert.Equal(new int[] { 3, 5, 88, 0, 11, 24, 9 }, insertShiftArray(tryarr, trynumb));
        }

        [Fact]
        public void Test3()
        {
            int[] tryarr = { };
            int trynumb = 1;
            Assert.Equal(new int[] { 1 }, insertShiftArray(tryarr, trynumb));
        }
        [Fact]
        public void Test4()
        {
            int[] tryarr = { 77 };
            int trynumb = 777;
            Assert.Equal(new int[] { 77, 777 }, insertShiftArray(tryarr, trynumb));
        }

    }
}

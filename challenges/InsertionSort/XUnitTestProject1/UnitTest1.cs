using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] arraytemp = { 5, 7, 2, 77, 12 };
            Assert.Equal(arraytemp[0], insertSort(arraytemp));
        }
    }
}

using System;
using HelloWorld;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void goodTest()
        {
            double a = 1;
            double b = 2;

            double result = MainClass.dzielenie(a,b);

            Assert.True(result == 0.5);
        }

        [Fact]
        public void badTest()
        {
            double a = 1;
            double b = 0;

            double result = MainClass.dzielenie(a,b);

            Assert.True(result == double.PositiveInfinity);
        }
    }
}
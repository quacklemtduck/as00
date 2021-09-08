using System;
using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsDivisibleByFourTest()
        {
            Assert.False(Program.IsLeapYear(2021));
            Assert.True(Program.IsLeapYear(2020));
            Assert.True(Program.IsLeapYear(2004));
            Assert.False(Program.IsLeapYear(2009));
            Assert.True(Program.IsLeapYear(2008));
        }

        [Fact]
        public void IsDivisibleBy100Test()
        {
            Assert.False(Program.IsLeapYear(1800));
            Assert.False(Program.IsLeapYear(2100));
        }

        [Fact]
        public void IsDivisibleBy400Test()
        {
            Assert.True(Program.IsLeapYear(1600));
            Assert.True(Program.IsLeapYear(2000));
        }
    }
}

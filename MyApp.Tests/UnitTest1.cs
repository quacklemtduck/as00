using System;
using Xunit;
using System.IO;

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

        [Fact]
        public void CorrectInputTest()
        {
            StringReader input = new StringReader("2000");
            Console.SetIn(input);
            StringWriter output = new StringWriter();
            Console.SetOut(output);
            Program.Main();
            string actual = output.ToString().Split(Environment.NewLine)[1];
            string expected = "yay";
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void NonIntegerInputTest()
        {
            StringReader input = new StringReader("Hello, World!");
            Console.SetIn(input);
            StringWriter output = new StringWriter();
            Console.SetOut(output);
            Program.Main();
            string actual = output.ToString().Split(Environment.NewLine)[1];
            string expected = "The input is not a number";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TooLowInputTest()
        {
            StringReader input = new StringReader("10");
            Console.SetIn(input);
            StringWriter output = new StringWriter();
            Console.SetOut(output);
            Program.Main();
            string actual = output.ToString().Split(Environment.NewLine)[1];
            string expected = "The input must be 1582 or higher";
            Assert.Equal(expected, actual);
        }
    }
}

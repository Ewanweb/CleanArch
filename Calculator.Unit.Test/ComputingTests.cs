using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Unit.Test
{
    public class ComputingTests
    {
        [Fact(DisplayName ="Check Odd Calculator")]
        public void OddOrEven_Should_Return_Odd_When_Input_Is_OddValue()
        {
            var computing = new Computing();

            var result = computing.OddOrEven(11);

            Assert.Equal("Odd", result);

        }

        [Theory(DisplayName = "Check Even Calculator")]
        [InlineData(10)]
        public void OddOrEven_Should_Return_Even_When_Input_Is_EvenValue(int value)
        {
            var computing = new Computing();

            var result = computing.OddOrEven(value);

            Assert.Equal("Even", result);

        }
    }
}

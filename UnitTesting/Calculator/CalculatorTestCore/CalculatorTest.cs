using Domain;
using FluentAssertions;
using System.Security.Cryptography.X509Certificates;

namespace CalculatorTestCore
{
    public class CalculatorTest
    {
        [Fact]
        public void Sum_of_2_and_2_shuld_be_4()=>
            new Calculator().Sum(2, 2).Should().Be(4);

    }
}
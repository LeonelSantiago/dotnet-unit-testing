﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PrimeService.Tests
{
    public class MathOperationsService_IsPrimeShould
    {
        private readonly MathOperationsService _primeService;

        public MathOperationsService_IsPrimeShould()
        {
            _primeService = new MathOperationsService();
        }

        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
    }
}

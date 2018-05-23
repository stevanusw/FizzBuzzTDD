using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void CanCreateFizzBuzz()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            Assert.IsInstanceOfType(fizzBuzz, typeof(FizzBuzz.FizzBuzz));
        }

        [TestMethod]
        public void CanPrintANumber()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            var i = fizzBuzz.Print(7);

            Assert.AreEqual("7", i);
        }

        [TestMethod]
        public void CanPrintFizzForMultiplesOf3()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            var i = fizzBuzz.Print(6);

            Assert.AreEqual("Fizz", i);
        }

        [TestMethod]
        public void CanPrintBuzzForMultiplesOf5()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            var i = fizzBuzz.Print(20);

            Assert.AreEqual("Buzz", i);
        }

        [TestMethod]
        public void CanPrintFizzBuzzForMultiplesOf3And5()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            var i = fizzBuzz.Print(15);

            Assert.AreEqual("FizzBuzz", i);
        }
    }
}

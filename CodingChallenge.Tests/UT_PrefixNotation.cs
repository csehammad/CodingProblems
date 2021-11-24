using CodingChallenge.HackerRank;
using NUnit.Framework;
using System;
using System.IO;

namespace CodingChallenge.Tests
{
    public class UT_PrefixNotation
    {
        private PrefixNotation _prefixNotation;

        [SetUp]
        public void Setup()
        {
            _prefixNotation = new PrefixNotation(); 
        }

        [Test]
        public void CheckAddExpression()
        {
            var result = _prefixNotation.CalculateExpression("+ 7 5 ","{}");

            Assert.AreEqual(12, result);
        }


        [Test]
        public void CheckInvalidData()
        {
          

            try
            {
                var result = _prefixNotation.CalculateExpression("+ 5  ", "{}");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType() == typeof(InvalidOperationException), "Expected exception of type " + typeof(InvalidOperationException) + " but type of " + ex.GetType() + " was thrown instead.");
                return;
            }

            Assert.Fail("Expected exception of type " + typeof(InvalidOperationException) + " but no exception was thrown.");

        }

        [Test]
        public void CheckSingleValue()
        {
         var result = _prefixNotation.CalculateExpression("6", "{}");
         Assert.AreEqual(6, result);

        }

        [Test]
        public void CheckTwoOperand_TwoValues()
        {
            var result = _prefixNotation.CalculateExpression("* + 1 2 3", "{}");
            Assert.AreEqual(9, result);

        }


        [Test]
        public void CheckNegativeNumericOperands()
        {
            var result = _prefixNotation.CalculateExpression("+ 6 * - 4 + 2 3 8 ", "{}");
            Assert.AreEqual(-2, result);

        }

        [Test]
        public void CheckExpressionWithVariable()
        {
            var result = _prefixNotation.CalculateExpression("* + 2 x y", "{\"x\":1,\"y\":3}");

            Assert.AreEqual(9, result);

        }

        [Test]
        public void CheckIfSeperatedCorrected()
        {
           

            try
            {
                var result = _prefixNotation.CalculateExpression("-+1 5 3", "{}");

            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType() == typeof(InvalidOperationException), "Expected exception of type " + typeof(InvalidOperationException) + " but type of " + ex.GetType() + " was thrown instead.");
                return;
            }

            Assert.Fail("Expected exception of type " + typeof(InvalidOperationException) + " but no exception was thrown.");


        }





        [Test]
        public void CheckInvalidData2()
        {
            try
            {
                var result = _prefixNotation.CalculateExpression("+ 7 5 3 ", "{}");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType() == typeof(InvalidDataException), "Expected exception of type " + typeof(InvalidDataException) + " but type of " + ex.GetType() + " was thrown instead.");
                return;
            }

            Assert.Fail("Expected exception of type " + typeof(InvalidDataException) + " but no exception was thrown.");

        }
    }
}
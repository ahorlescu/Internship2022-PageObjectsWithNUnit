using NUnit.Framework;
using PageObjectsWithNUnit.Math;
using System;

namespace PageObjectsWithNUnit.Tests
{

    [TestFixture]
    public class BasicMathsTests
    {
        BasicMaths basicMaths;

        [SetUp]
        public void Init()
        {
            basicMaths = new BasicMaths();
        }

        [Test]
        public void ValidateAddOperation()
        {
            // Act
            var result = basicMaths.Add(1, 1);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [TestCase(0, 1, 1)]
        [TestCase(1, 1, 2)]
        public void ValidateAddOperation(decimal opt1, decimal opt2, decimal expected)
        {
            // Act
            var result = basicMaths.Add(opt1, opt2);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ValidateExceptionIsThrownNewStyle()
        {
            // Assert
            Assert.That(() => basicMaths.Divide(1, 0), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void ValidateExceptionIsThrownClassicStyle()
        {
            // Assert
            Assert.Throws<DivideByZeroException>(() => basicMaths.Divide(1, 0));
        }
    }
}
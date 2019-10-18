using System;
using Writing_a_simple_UnitTest2_6.Fandementals;
using NUnit.Framework;


namespace MathTests_2_6
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var math = new Math();

            var result = math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }
    }
}

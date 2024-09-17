using NanisGuard.src;

namespace Test
{
    [TestClass]
    public class GuardDigitRestrictionTest
    {
        [TestMethod]
        public void LongAsPositiveExpectedTrue()
        {
            long number = 57456456456;

            var result = NanisGuardV.validation.DigitNotBeNegative(number);

            Assert.IsNotNull(result);
            Assert.AreEqual(number, result);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void IntAsNegativeExpectedError()
        {
            int number = -57;

            var result = NanisGuardV.validation.DigitNotBeNegative(number);

            Assert.IsNull(result);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void LongAsNegativeExpectedError()
        {
            long number = -57456456456;

            var result = NanisGuardV.validation.DigitNotBeNegative(number);

            Assert.IsNull(result);
        }
    }
}

using NanisGuard;
using NanisGuard.src;

namespace Test
{
    [TestClass]
    public class GuardStringRangeExtentionTest
    {
        [TestMethod]
        public void NumberMax_ValidInput()
        {
            long number = 10;

            var result = NanisGuardV.validation.NumberMax(number, 11);

            Assert.IsNotNull(result);
            Assert.AreEqual(number, result);

        }

        [TestMethod]
        public void NumberMin_ValidInput()
        {
            long number = 12;

            var result = NanisGuardV.validation.NumberMin(number, 11);

            Assert.IsNotNull(result);
            Assert.AreEqual(number, result);

        }
        [TestMethod]
        public void LongMaxLength_ValidInputRange()
        {
            long fact = 12345678;

            var result = NanisGuardV.validation.DigitMaxLength(fact, 9);

            Assert.IsNotNull(result);
            Assert.AreEqual(fact, result);

        }

        [TestMethod]
        public void StringMaxLength_ValidInputRange()
        {
            string name = "camilo";

            var result = NanisGuardV.validation.StringMaxLength(name,9);

            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void StringMinLength_ValidInputRange()
        {
            string name = "cam";

            var result = NanisGuardV.validation.StringMinLength(name,2);

            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void IntMaxLength_ValidInputRange()
        {
            int number = 12;

            var result = NanisGuardV.validation.IntMaxLength(number, 2);

            Assert.IsNotNull(result);
            Assert.AreEqual(number, result);

        }

        [TestMethod]
        public void IntMinLength_ValidInputRange()
        {
            int number = 125;

            var result = NanisGuardV.validation.IntMinLength(number, 2);

            Assert.IsNotNull(result);
            Assert.AreEqual(number, result);

        }


        [TestMethod]
        public void StringRange_ValidInputRange()
        {
            string name = "camilo";

            var result = NanisGuardV.validation.StringLengthRange(name, 2, 7);

            Assert.IsNotNull(result);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StringMinLength_InvalidInputRange()
        {
            string name = "c";

            var result = NanisGuardV.validation.StringMinLength(name, 2);

            Assert.IsNull(result);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StringMaxLength_InvalidInputRange()
        {
            string name = "camilocu";

            var result = NanisGuardV.validation.StringMaxLength(name, 5);

            Assert.IsNull(result);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StringRange_InvalidInputRange()
        {
            string name = "cdfxvxcvxcvxcv";

            var result = NanisGuardV.validation.StringLengthRange(name, 2, 5);

            Assert.IsNull(result);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IntMinLength_InvalidInputRange()
        {
            int number = 125;

            var result = NanisGuardV.validation.IntMinLength(number, 5);

            Assert.IsNull(result);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IntMaxLength_InvalidInputRange()
        {
            int number = 1257777;

            var result = NanisGuardV.validation.IntMaxLength(number, 5);

            Assert.IsNull(result);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LongMaxLength_InvalidInputRange()
        {
            long fact = 1234567891011;

            var result = NanisGuardV.validation.DigitMaxLength(fact, 9);

            Assert.IsNull(result);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NumberMax_InvalidInput()
        {
            long number = 15;

            var result = NanisGuardV.validation.NumberMax(number, 11);

            Assert.IsNull(result);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NumberMin_InvalidInput()
        {
            long number = 15;

            var result = NanisGuardV.validation.NumberMin(number, 10);

            Assert.IsNull(result);

        }
    }
}

using NanisGuard;
using NanisGuard.src;

namespace Test
{
    [TestClass]
    public class GuardParseStringToDigitsTest
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void String_NotParseToInt_expectedException()
        {
            string number = "1234gh";

            var result = NanisGuardV.validation.ValidateParseStringToInt(number);

            Assert.IsNull(result);

        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void String_NotParseToLong_expectedException()
        {
            string number = "1234xcsdfgh";

            var result = NanisGuardV.validation.ValidateParseStringToLong(number);

            Assert.IsNull(result);

        }

        [TestMethod]
        public void String_ParseToInt_expectedTrue()
        {
            string number = "1234";

            var result = NanisGuardV.validation.ValidateParseStringToInt(number);

            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void String_ParseToLong_expectedTrue()
        {
            string number = "123445645645565";

            var result = NanisGuardV.validation.ValidateParseStringToLong(number);

            Assert.IsNotNull(result);

        }
    }
}

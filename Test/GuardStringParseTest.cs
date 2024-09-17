using NanisGuard;
using NanisGuard.src;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Test
{
    [TestClass]
    public class GuardStringParseTest
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
        [ExpectedException(typeof(FormatException))]
        public void String_ParseToDate_expectedFalse()
        {
            string date = "23/04/20247";

            var result = NanisGuardV.validation.ValidateParseStringToDate(date);

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

        [TestMethod]
        public void String_ParseToDate_expectedTrue()
        {
            string date = "23/04/2024";

            var result = NanisGuardV.validation.ValidateParseStringToDate(date);

            Assert.IsNotNull(result);

        }
    }
}

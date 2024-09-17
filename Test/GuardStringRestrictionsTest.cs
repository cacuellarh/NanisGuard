using NanisGuard;
using NanisGuard.src;

namespace Test
{
    [TestClass]
    public class GuardStringRestrictionsTest
    {
        [TestMethod]
        public void String_AsValidEmailFormat()
        {
            string email = "camilotedi@gmail.com";

            var result = NanisGuardV.validation.StringAsValidEmailFormat(email);

            Assert.IsNotNull(result);
            Assert.AreEqual(email, result);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void String_AsInvalidStringContainDigit()
        {
            string name = "camilot45";

            var result = NanisGuardV.validation.StringOnlyContainsLetters(name);

            Assert.IsNull(result);
        }
    }
}

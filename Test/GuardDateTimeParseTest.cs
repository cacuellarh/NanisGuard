using NanisGuard.src;

namespace Test
{

    [TestClass]
    public class GuardDateTimeParseTest
    {
        [TestMethod]
        public void CreateTimeSpanWithValidInput()
        {
            var hour = "12:00:00";

            var result = NanisGuardV.validation.ValidateTryParseStringToTimeSpan(hour);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void CreateTimeSpanWithInvalidInput()
        {
            var hour = "12:00y00";

            var result = NanisGuardV.validation.ValidateTryParseStringToTimeSpan(hour);

            Assert.IsNotNull(result);
        }
    }
}

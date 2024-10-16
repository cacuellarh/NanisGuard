using NanisGuard;
using NanisGuard.src;

namespace Test
{
    [TestClass]
    public class GuardNullExtensionTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Null_ArgumentExceptionExpected()
        {
            // Arrange
            int? num = null;
            var res = NanisGuardV.validation.NotNull(num, nameof(num));

            Assert.IsNull(res);

        }

        [TestMethod]
        public void Null_ArgumentNotNull()
        {
            int? num = 9;
            var res = NanisGuardV.validation.NotNull(num, nameof(num));

            Assert.IsNotNull(res);
        }

        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void Null_ArgumentWithCustomException()
        {
            int? num = null;
            var res = NanisGuardV.validation.NotNull(num, nameof(num), customException:() => new CustomException());

            Assert.IsNotNull(res);
        }
    }

    internal class CustomException : Exception
    {
        public CustomException() : base("Custom Exceotion throw") { }

    }
}
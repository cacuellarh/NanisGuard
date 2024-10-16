using NanisGuard.src;

namespace Test
{
    [TestClass]
    public class GuardEnumerableEmptyOrNull
    {
        [TestMethod]
        public void ListWihValidInput()
        {
            var users = new List<string>() { "andres", "carlos" };

            var result = NanisGuardV.validation.EnumerableNotEmpty(users);

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void CompareLengthWithTwoList()
        {
            var users = new List<string>() { "andres", "carlos" };
            var numbers = new List<int>() { 1,2 };

            var result = NanisGuardV.validation.EnumerableCompareLength(users, numbers);

            Assert.IsNotNull(result);
        }
        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod]
        public void CompareLengthWithTwoListInvalid()
        {
            var users = new List<string>() { "andres", "carlos" };
            var numbers = new List<int>() { 1, 2,5,8 };

            var result = NanisGuardV.validation.EnumerableCompareLength(users,numbers);

            Assert.IsNull(result);
            Assert.IsFalse(result);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void ListWihInvalidInput()
        {
            var users = new List<string>();

            var result = NanisGuardV.validation.EnumerableNotEmpty(users);

            Assert.IsNull(result);
            Assert.AreEqual(0, result.Count());
        }
    }
}

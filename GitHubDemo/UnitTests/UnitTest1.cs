using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestClass
    {
        private readonly GitHubDemo.ApsecCoreDemo _program;

        public TestClass()
        {
            _program = new GitHubDemo.ApsecCoreDemo();
        }


        [TestMethod]
        public void isTrueReturnsTrue()
        {
            bool result = _program.isTrue();
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void isFalseReturnsFalse()
        {
            bool result = _program.isFalse();
            Assert.IsFalse(result);
        }
    }
}

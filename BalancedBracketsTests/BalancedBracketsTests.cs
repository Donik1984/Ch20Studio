using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTestsNS
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        BalancedBrackets balancedBrackets;
        [TestInitialize]
        public void Test()
        {
            balancedBrackets = new BalancedBrackets();
        }
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("]["));
        }
        [TestMethod]
        public void BracketsAreNotNull()
        {
            Assert.IsNotNull(BalancedBrackets.HasBalancedBrackets("]["));
        }
        [TestMethod]
        public void BracketsAreFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }
        [TestMethod]
        public void OnlyBracketsReturnsTrue2()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }


        [TestMethod]
        public void SpeedTest()
        {
            //BalancedBrackets balancedBrackets = new BalancedBrackets();
            double jetSpeedTest = balancedBrackets.JetSpeed(999, 3);
            Assert.AreEqual(jetSpeedTest, 333, 0.01);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Studio6_Unit_Tests_Balanced_Brackets;

namespace Studio6_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckBalanceShouldReturnTrueWhenNoBrackets()
        {
            BalancedBrackets balancedBrackets = new BalancedBrackets("test string");
            Assert.IsFalse(balancedBrackets.CheckBalance());
        }
        [TestMethod]
        public void CheckBalanceShouldReturnFalseWhenCloseBracketIsFirst()
        {
            BalancedBrackets balancedBrackets = new BalancedBrackets("tes]t string");
            Assert.IsFalse(balancedBrackets.CheckBalance());
        }
        [TestMethod]
        public void CheckBalanceShouldReturnFalseWhenBracketsUnbalanced()
        {
            BalancedBrackets balancedBrackets = new BalancedBrackets("t[es]t st[ring");
            Assert.IsFalse(balancedBrackets.CheckBalance());
        }
        [TestMethod]
        public void CheckBalanceShouldReturnTrueWhenBracketsAreBalanced()
        {
            BalancedBrackets balancedBrackets = new BalancedBrackets("t[es]t st[r[i]n]g");
            Assert.IsFalse(balancedBrackets.CheckBalance());
        }
    }
}

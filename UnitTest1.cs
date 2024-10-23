using Calc;

namespace FindMinAndMax
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] ar1 ={2,4,6,7,8,35,89,75,23,53,46};
            int[] ar2 = {3,5,4,67,565,76,89,65,43,24,2,5,1 };
           
            MyCalc cl = new MyCalc();
            Assert.AreEqual(89, cl.FindMax(ar1));
            Assert.AreEqual(2, cl.FindMin(ar1));
            Assert.AreEqual(565, cl.FindMax(ar2));
            Assert.AreEqual(1, cl.FindMin(ar2));
        }
    }
}
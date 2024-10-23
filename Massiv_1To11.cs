using Calc;

namespace CalcTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void returnetIs30()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] arr2 = { 0,1,2,3,4,5,6,7,8,9,10,11 };
            MyCalc mc= new MyCalc();
            Assert.AreEqual(11, mc.FindMax(arr1));
          
        }
        public void findMin()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11,32 };  
            int[] arr2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            MyCalc mc = new MyCalc();
            Assert.AreEqual(0, mc.FindMin(arr2));

        }
    }
}

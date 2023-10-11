using stringCalculator;
namespace stringCalculatorTest
{
    [TestClass]
    public class stringcalculatortest1
    {
        /*Test 1: la función add tiene que retornar un resultado correcto
         * de la suma que se le pase como parametro de tipo string
         * 
         * Tendrá que tener en cuenta
         */
        [TestMethod]
        public void addShouldSum()
        {
            string op = "1,2";
            int result = stringCalculator.stringCalculator.add(op); 
            Assert.AreEqual(3, result,
                       string.Format("Expected for '{0}'; Actual: {1}",
                                     3, result));
        }
        [TestMethod]
        public void addShouldNotHandleEmptyString() 
        {
            string empty = "";
            int result = stringCalculator.stringCalculator.add(empty);
            Assert.AreEqual(0, result, string.Format("Expected for '{0}'; Actual: {1}", 0, result));
        }
    }
}

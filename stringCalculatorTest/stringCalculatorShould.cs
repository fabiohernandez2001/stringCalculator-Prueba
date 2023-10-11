
namespace stringCalculatorTest
{
    [TestClass]
    public class stringCalculatorShould
    {
        /*Test 1: la funci�n add tiene que retornar un resultado correcto
         * de la suma que se le pase como parametro de tipo string
         * 
         * Tendr� que tener en cuenta
         */
        private stringCalculator.stringCalculator calculator = 
            new stringCalculator.stringCalculator();
        [TestMethod]
        public void when_adding_should_return_sum()
        {
            string op = "1,2";
            int result = calculator.add(op); 
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void when_empty_string_should_return_0() 
        {
            string empty = "";
            int result = calculator.add(empty);
            Assert.AreEqual(0, result);
        }
    }
}

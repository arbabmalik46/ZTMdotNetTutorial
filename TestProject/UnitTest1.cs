using CalculationEngine;

namespace TestProject;

[TestClass]
public class UnitTest1
{
    private Calculator _calculator = new Calculator();
    [TestMethod]
    public void SumTest()
    {
       var result = _calculator.Sum(23, 30);
       Assert.AreEqual(53,result);
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void NullExcenptionException()
    {
        _calculator.Sum(null,98);
    }

}
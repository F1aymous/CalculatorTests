using NUnit.Framework;          
using Practices;               

namespace CalculatorTests
{
    [TestFixture]                    
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void SetUp()
        {
            calc = new Calculator();  
        }

        [Test]
        public void Additional_ShouldReturnSum()
        {
            
            int a = 5, b = 3;
            int result = calc.Additional(a, b);
            Assert.AreEqual(8, result);  
        }

        [Test]
        public void Subtraction_ShouldReturnDifference()
        {
            
            int a = 10, b = 4;
            int result = calc.Subtraction(a, b);
            Assert.AreEqual(6, result);   
        }

        [Test]
        public void Miltiplication_ShouldReturnProduct()
        {
            
            int a = 6, b = 7;
            int result = calc.Miltiplication(a, b);
            Assert.AreEqual(42, result); 
        }

        [Test]
        public void Division_ShouldReturnQuotient()
        {
           
            int a = 20, b = 4;
            int result = calc.Division(a, b);
            Assert.AreEqual(5, result);   
        }

        [Test]
        public void Division_ByZero_ShouldThrowDivideByZeroException()
        {
           
            int a = 10, b = 0;
            Assert.Throws<DivideByZeroException>(() => calc.Division(a, b));
        }
    }
}
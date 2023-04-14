namespace Nunit_Test
{
    public class Tests
    {
        Calculator calculator = new Calculator();
                
        [SetUp]
        public void SetupForEeachMethod()
        {
            calculator = new Calculator();
        }

        [Test, Description("Testing the calculator function plus")]
        [Category("Calculator test")]
        [TestCase(5, 7, 12)]
        [TestCase(-1, -9, -10)]
        [TestCase(-6, 9, 3)]
        public void SummTest(int opersand_1, int operand_2, int result)
        {         
            var actualResult = calculator.Summ(opersand_1, operand_2);
            Console.Write($"Expected result is {result}, actual result is {actualResult}");
                        
            Assert.That(result, Is.EqualTo(actualResult), $"Summ {opersand_1} + {operand_2} = {actualResult}");                        
        }

        [Category("Calculator test")]
        [Test, Description("Testing the calculator function minus")]
        public void MinusTest(
            [Values(10)] int opersand_1,
            [Range(1, 10, 1)] int operand_2)
        {
            var actualResult = calculator.Minus(opersand_1, operand_2);
            Console.WriteLine($"Operand 1 = {opersand_1}, operand 2 = {operand_2}");
            Console.Write($"Minus result is {actualResult}");

            Assert.That(2, Is.LessThan(actualResult), $"Minus {opersand_1} - {operand_2} = {actualResult}");
        }

        
        [Category("Calculator test")]
        [Test, Description("Testing the calculator function divide")]
        [Retry(3)]
        public void DivideTest(
            [Values(16)] int opersand_1,
            [Random(1, 5, 10)] int operand_2)
        {
            var actualResult = calculator.Divide(opersand_1, operand_2);
            Console.WriteLine($"Operand 1 = {opersand_1}, operand 2 = {operand_2}");
            Console.Write($"Divide result is {actualResult}");

            Assert.That(4, Is.LessThan(actualResult), $"Divide: {opersand_1} / {operand_2} = {actualResult}");
        }

        [Test, Description("Testing the calculator function multiply")]
        public void MultiplyTest(
            [Values(16)] int opersand_1,
            [Random(1, 5, 10)] int operand_2)
        {
            var actualResult = calculator.Divide(opersand_1, operand_2);
            Console.WriteLine($"Operand 1 = {opersand_1}, operand 2 = {operand_2}");
            Console.Write($"Divide result is {actualResult}");

            Assert.That(15, Is.GreaterThan(actualResult), $"Multiply: {opersand_1} * {operand_2} = {actualResult}");
        }

        [TearDown]
        public void TearDown() 
        {
            Console.WriteLine("Test");
        }
    }
}

using Aboba;
namespace TestProject2
{
    public class MathOperations
    {
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public int CalculateFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * CalculateFactorial(n - 1);
        }
    }

    public class StringOperations
    {
        public string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }

    public class TestSetup
    {
        public void Setup()
        {
            // Настройка для тестов
        }
    }

    public class Calculator
    {
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public int CalculateFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * CalculateFactorial(n - 1);
        }
    }

    public class Tests
    {
        private MathOperations _mathOperations;
        private StringOperations _stringOperations;
        private TestSetup _testSetup;
        private Calculator _calculator;

        public Tests()
        {
            _mathOperations = new MathOperations();
            _stringOperations = new StringOperations();
            _testSetup = new TestSetup();
            _calculator = new Calculator();
        }

        [SetUp]
        public void Setup()
        {
            _testSetup.Setup();
        }

        [Test]
        public static void AddNumbers_WhenGiven5And7_Returns12()
        {
            int a = 10;
            int b = 20;
            int expected = 30;

            var mathOperations = new MathOperations();
            int actual = mathOperations.AddNumbers(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void ReverseString_WhenGivenHello_ReturnsOlleh()
        {
            string input = "Hello";
            string expected = "olleH";

            var stringOperations = new StringOperations();
            string actual = stringOperations.ReverseString(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void CalculateFactorial_WhenGiven5_Returns120()
        {
            int n = 5;
            int expected = 120;

            var mathOperations = new MathOperations();
            int actual = mathOperations.CalculateFactorial(n);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void AddNumbersUsingCalculator_WhenGiven5And7_Returns12()
        {
            int a = 10;
            int b = 20;
            int expected = 30;

            var calculator = new Calculator();
            int actual = calculator.AddNumbers(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void CalculateFactorialUsingCalculator_WhenGiven5_Returns120()
        {
            int n = 5;
            int expected = 120;

            var calculator = new Calculator();
            int actual = calculator.CalculateFactorial(n);

            Assert.AreEqual(expected, actual);
        }
    }
}

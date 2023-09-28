using Algorithms;

namespace AlgorithmsTest
{
    [TestClass]
    public class UnitTest1
    {
        Primes primes;
        Fibonacci fib;
        Invert flip;

        [TestMethod]
        public void TestPrimeCheck()
        {
            primes = new Primes();

            Assert.IsTrue(primes.checkifPrime(7));
        }

        [TestMethod]
        public void TestSumOf()
        {
            primes = new Primes();

            int solution = 76127;

            Assert.AreEqual(solution, primes.sumOfAllPrime(1000));
        }

        [TestMethod]
        public void TestLargestPrime()
        {
            primes = new Primes();

            int solution = 7;

            Assert.AreEqual(solution, primes.LargestPrime(7));
        }

        [TestMethod]
        public void TestFib()
        {
            fib = new Fibonacci();

            int solution = 2;

            Assert.AreEqual(solution, fib.numberOfFib(4));
        }

        [TestMethod]
        public void TestIntFlip()
        {
            flip = new Invert();

            int solution = 65;

            Assert.AreEqual(solution, flip.invertInt(56));
        }
    }
}
namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Primes primes = new Primes();
            Invert flip = new Invert();
            Fibonacci fib = new Fibonacci();

            //get nth number of the Fibonacci Sequence
            Console.WriteLine(fib.numberOfFib(10));
            //Reverse a Integer
            Console.WriteLine(flip.invertInt(425));
            //Get The Largest Prime Factor of n
            Console.WriteLine(primes.LargestPrime(10));
            //Find the sum of all prime numbers below 1000
            Console.WriteLine(primes.sumOfAllPrime(1000));
        }
    }
}
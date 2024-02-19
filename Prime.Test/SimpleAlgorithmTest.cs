using Prime.Algorithms.Simple;

namespace Prime.Test
{
    public class SimpleAlgorithmTest
    {
        private readonly IPrimeAlgorithm _primeAlgorithm;
        private readonly IPrimeAlgorithm _primeAlgorithmNew;

        public SimpleAlgorithmTest()
        {
            _primeAlgorithm = new SimplePrimeAlgorithm();
            _primeAlgorithmNew = new SimplePrimeAlgorithmNew();
        }
        [Fact]
        public void TestNormal()
        {
            // get a IEnumerable<int> of the first 25 prime numbers
            var primes = new List<int>();
            for (int i = 0; i < 25; i++)
            {
                primes.Add(_primeAlgorithm.GetNextPrime());
            }

            // validate the set
            Assert.True(PrimeSetValidation.ValidateSet(primes));
        }
        [Fact]
        public void TestNew()
        {
            // get a IEnumerable<int> of the first 25 prime numbers
            var primes = new List<int>();
            for (int i = 0; i < 25; i++)
            {
                primes.Add(_primeAlgorithmNew.GetNextPrime());
            }

            // validate the set
            Assert.True(PrimeSetValidation.ValidateSet(primes));
        }
    }
}
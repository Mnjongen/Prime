using BenchmarkDotNet.Attributes;
using Prime.Algorithms.Simple;

namespace Prime.Benchmarks
{
    public class SimplePrimeBenchmarks
    {
        private readonly IPrimeAlgorithm _primeAlgorithm;
        private readonly IPrimeAlgorithm _primeAlgorithmNew;

        public SimplePrimeBenchmarks()
        {
            _primeAlgorithm = new SimplePrimeAlgorithm();
            _primeAlgorithmNew = new SimplePrimeAlgorithmNew();
        }
        [Benchmark(Baseline = true)]
        public void NormalPrime()
        {
            var primes = new List<int>();
            for (int i = 0; i < 25; i++)
            {
                primes.Add(_primeAlgorithm.GetNextPrime());
            }
            _primeAlgorithm.Reset();
        }
        [Benchmark]
        public void NewPrime()
        {
            var primes = new List<int>();
            for (int i = 0; i < 25; i++)
            {
                primes.Add(_primeAlgorithmNew.GetNextPrime());
            }
            _primeAlgorithmNew.Reset();
        }
    }
}

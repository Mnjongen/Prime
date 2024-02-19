

namespace Prime.Algorithms.Simple
{
    public class SimplePrimeAlgorithm : IPrimeAlgorithm
    {
        private int _current = 1;

        /// <inheritdoc/>
        public void Reset() => _current = 1;

        /// <inheritdoc/>
        public int GetNextPrime()
        {
            decimal next = _current <= 2
                ? _current + 1
                : _current + 2;

            while (true)
            {
                if (IsPrime((int)next))
                {
                    _current = (int)next;
                    return _current;
                }
                if (next == 2)
                    next++;
                else
                    next += 2;
            }
        }

        private static bool IsPrime(int i)
        {
            for (int j = 2; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

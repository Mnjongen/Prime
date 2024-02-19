namespace Prime.Test
{
    internal class PrimeSetValidation
    {
        public static bool ValidateSet(IEnumerable<int> set)
        {
            var primes = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            return set.SequenceEqual(primes);
        }
    }
}

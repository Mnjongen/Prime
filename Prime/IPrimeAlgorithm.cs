namespace Prime
{
    /// <summary>
    /// Interface for prime algorithms.
    /// </summary>
    public interface IPrimeAlgorithm
    {
        /// <summary>
        /// Get the next prime number.
        /// </summary>
        /// <returns>The next prime number.</returns>
        int GetNextPrime();
        /// <summary>
        /// Reset the algorithm to its initial state.
        /// </summary>
        void Reset();
    }
}

namespace OmniNumbers
{
    /// <summary>
    /// Simply represents any number from minus infinite to plus infinite.
    /// Only your computer memory is the limit.
    /// Numbers are build of multiple <see cref="NumberChunk"/>s.
    /// </summary>
    /// <author>
    /// Krzysztof Dobrzyński - https://github.com/Sejoslaw/OmniNumbers
    /// </author>
    public partial class Number
    {
        /// <summary>
        /// First chunk which contains initial values.
        /// Each chunk knows the next one.
        /// </summary>
        protected NumberChunk FirstChunk { get; }
        
        /// <summary>
        /// Default constructor which allows for initializing new Number object.
        /// </summary>
        /// <param name="initialValue">Initial value for this </param>
        public Number(string initialValue = "0")
        {
            this.FirstChunk = new NumberChunk(initialValue);
        }
    }
}
namespace OmniNumbers
{
    /// <summary>
    /// Represents single chunk of a complex number.
    /// This class is an internal part of the OmniNumbers library.
    /// For more usage please see <see cref="Number"/> class.
    /// </summary>
    /// <author>
    /// Krzysztof Dobrzyński - https://github.com/Sejoslaw/OmniNumbers
    /// </author>
    public class NumberChunk
    {
        /// <summary>
        /// Currently stored number chunk.
        /// </summary>
        protected string Value { get; }
        
        /// <summary>
        /// Represents next chunk.
        /// Each next chunk contains numbers which should go in front of the current number.
        /// 
        /// So the string representation of a full number would be:
        /// "next...current"
        /// and (in mathematical equation)
        /// Next.Value[Last_Digit] > Current.Value
        /// So the number which represents the last digit of the Next.Value is greater then the whole number represented by the Current.Value.
        /// </summary>
        protected NumberChunk Next { get; set; }

        /// <summary>
        /// Default constructor which allows for initializing new NumberChunk object.
        /// </summary>
        /// <param name="initialValue"></param>
        public NumberChunk(string initialValue = "0")
        {
            NumberValidator.ValidateIfContainsOnlyNumbers(initialValue);
            
            this.Value = initialValue;
        }

        /// <summary>
        /// </summary>
        /// <returns>Currently stored number.</returns>
        public override string ToString() => this.Value;
    }
}
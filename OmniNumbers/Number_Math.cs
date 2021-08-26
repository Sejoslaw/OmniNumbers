namespace OmniNumbers
{
    /// <summary>
    /// Part of the <see cref="Number"/> responsible for math operations.
    /// </summary>
    /// <author>
    /// Krzysztof Dobrzyński - https://github.com/Sejoslaw/OmniNumbers
    /// </author>
    public partial class Number
    {
        public static Number operator +(Number n1, Number n2) => n1.Add(n2);
        public static Number operator -(Number n1, Number n2) => n1.Subtract(n2);
        public static Number operator *(Number n1, Number n2) => n1.Multiply(n2);
        public static Number operator /(Number n1, Number n2) => n1.Divide(n2);
        public static Number operator ^(Number n1, Number n2) => n1.Power(n2);
        
        public virtual Number Add(Number n)
        {
            // TODO: Add logic
        }

        public virtual Number Subtract(Number n)
        {
            // TODO: Add logic
        }

        public virtual Number Multiply(Number n)
        {
            // TODO: Add logic
        }

        public virtual Number Divide(Number n)
        {
            // TODO: Add logic
        }

        public virtual Number Power(Number n)
        {
            // TODO: Add logic
        }
    }
}
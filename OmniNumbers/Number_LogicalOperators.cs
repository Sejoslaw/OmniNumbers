namespace OmniNumbers
{
    /// <summary>
    /// Part of the <see cref="Number"/> responsible for logical operations.
    /// </summary>
    /// <author>
    /// Krzysztof Dobrzyński - https://github.com/Sejoslaw/OmniNumbers
    /// </author>
    public partial class Number // TODO: IComparable ???, IComparable<Number> ???, IEquatable<Number> ???
    {
        public static bool operator !=(Number n1, Number n2) => !(n1 == n2);

        public static bool operator ==(Number n1, Number n2)
        {
        }

        public static bool operator <=(Number n1, Number n2) => n1 < n2 || n1 == n2;
        
        public static bool operator >=(Number n1, Number n2) => n1 > n2 || n1 == n2;

        public static bool operator >(Number n1, Number n2)
        {
        }
        
        public static bool operator <(Number n1, Number n2)
        {
        }
    }
}
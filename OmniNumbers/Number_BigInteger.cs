using System.Numerics;

namespace OmniNumbers
{
    /// <summary>
    /// Part of the <see cref="Number"/> responsible for interaction with <see cref="BigInteger"/>.
    /// </summary>
    /// <author>
    /// Krzysztof Dobrzyński - https://github.com/Sejoslaw/OmniNumbers
    /// </author>
    public partial class Number
    {
        public static implicit operator BigInteger(Number n) => BigInteger.Parse(n.FirstChunk.ToString());
        public static implicit operator Number(BigInteger value) => new(value.ToString());
    }
}
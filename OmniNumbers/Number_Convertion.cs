using System;

namespace OmniNumbers
{
    /// <summary>
    /// Part of the <see cref="Number"/> responsible for convertion.
    /// </summary>
    /// <author>
    /// Krzysztof Dobrzyński - https://github.com/Sejoslaw/OmniNumbers
    /// </author>
    public partial class Number : IConvertible
    {
        #region Implicit Operators

        public static implicit operator bool(Number n) => n.FirstChunk.ToString()[0].Equals('1');
        public static implicit operator Number(bool value) => new(value.GetHashCode().ToString());
        public static implicit operator byte(Number n) => byte.Parse(n.FirstChunk.ToString());
        public static implicit operator Number(byte value) => new(value.ToString());
        public static implicit operator sbyte(Number n) => sbyte.Parse(n.FirstChunk.ToString());
        public static implicit operator Number(sbyte value) => new(value.ToString());
        public static implicit operator char(Number n) => char.Parse(n.FirstChunk.ToString());
        public static implicit operator Number(char value) => new(value.GetHashCode().ToString());
        public static implicit operator decimal(Number n) => decimal.Parse(n.FirstChunk.ToString());
        public static implicit operator Number(decimal value) => new(value.ToString());
        public static implicit operator double(Number n) => double.Parse(n.FirstChunk.ToString());
        public static implicit operator Number(double value) => new(value.ToString());
        public static implicit operator float(Number n) => float.Parse(n.FirstChunk.ToString());
        public static implicit operator Number(float value) => new(value.ToString());
        public static implicit operator int(Number n) => int.Parse(n.FirstChunk.ToString());
        public static implicit operator Number(int value) => new(value.ToString());
        public static implicit operator uint(Number n) => uint.Parse(n.FirstChunk.ToString());
        public static implicit operator Number(uint value) => new(value.ToString());
        public static implicit operator nint(Number n) => nint.Parse(n.FirstChunk.ToString());
        public static implicit operator Number(nint value) => new(value.ToString());
        public static implicit operator nuint(Number n) => nuint.Parse(n.FirstChunk.ToString());
        public static implicit operator Number(nuint value) => new(value.ToString());
        public static implicit operator long(Number n) => long.Parse(n.FirstChunk.ToString());
        public static implicit operator Number(long value) => new(value.ToString());
        public static implicit operator ulong(Number n) => ulong.Parse(n.FirstChunk.ToString());
        public static implicit operator Number(ulong value) => new(value.ToString());
        public static implicit operator short(Number n) => short.Parse(n.FirstChunk.ToString());
        public static implicit operator Number(short value) => new(value.ToString());
        public static implicit operator ushort(Number n) => ushort.Parse(n.FirstChunk.ToString());
        public static implicit operator Number(ushort value) => new(value.ToString());
        public static implicit operator string(Number n) => n.FirstChunk.ToString();
        public static implicit operator Number(string value) => new(value);

        #endregion

        #region IConvertible

        public TypeCode GetTypeCode() => TypeCode.Object;
        public bool ToBoolean(IFormatProvider? provider) => bool.Parse(this.FirstChunk.ToString());
        public byte ToByte(IFormatProvider? provider) => byte.Parse(this.FirstChunk.ToString());
        public char ToChar(IFormatProvider? provider) => char.Parse(this.FirstChunk.ToString());
        public DateTime ToDateTime(IFormatProvider? provider) => throw new InvalidCastException("Number cannot be casted to DateTime.");
        public decimal ToDecimal(IFormatProvider? provider) => decimal.Parse(this.FirstChunk.ToString());
        public double ToDouble(IFormatProvider? provider) => double.Parse(this.FirstChunk.ToString());
        public short ToInt16(IFormatProvider? provider) => short.Parse(this.FirstChunk.ToString());
        public int ToInt32(IFormatProvider? provider) => int.Parse(this.FirstChunk.ToString());
        public long ToInt64(IFormatProvider? provider) => long.Parse(this.FirstChunk.ToString());
        public sbyte ToSByte(IFormatProvider? provider) => sbyte.Parse(this.FirstChunk.ToString());
        public float ToSingle(IFormatProvider? provider) => float.Parse(this.FirstChunk.ToString());
        public string ToString(IFormatProvider? provider) => this.FirstChunk.ToString();
        public object ToType(Type conversionType, IFormatProvider? provider) => throw new InvalidCastException("Number cannot be casted to an unknown type.");
        public ushort ToUInt16(IFormatProvider? provider) => ushort.Parse(this.FirstChunk.ToString());
        public uint ToUInt32(IFormatProvider? provider) => uint.Parse(this.FirstChunk.ToString());
        public ulong ToUInt64(IFormatProvider? provider) => ulong.Parse(this.FirstChunk.ToString());

        #endregion
    }
}
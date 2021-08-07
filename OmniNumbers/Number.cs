using System.IO;
using System.Numerics;

namespace OmniNumbers
{
    /// <summary>
    /// </summary>
    public partial class Number
    {
        // TODO: Add chained collection
        // TODO: Chained collection should keep head
        // TODO: Chained collection element should keep string value and pointer to next element
        // TODO: Number should operate on given strings and perform operations on them

        #region Public Math Methods

        public virtual void Add(Number n)
        {
            // TODO: Add logic
        }

        public virtual void Subtract(Number n)
        {
            // TODO: Add logic
        }

        public virtual void Multiply(Number n)
        {
            // TODO: Add logic
        }

        public virtual void Divide(Number n)
        {
            // TODO: Add logic
        }

        public virtual void Power(Number n)
        {
            // TODO: Add logic
        }
        
        #endregion

        #region Public Interaction Methods

        public virtual void Write(Stream stream)
        {
            // TODO: Add logic
            // TODO: Maybe as an input get function which will allow for custom writing part of the current number
        }

        #endregion

        #region Operators

        public static implicit operator bool(Number n)
        {
        }
        
        public static implicit operator Number(bool value)
        {
        }

        public static implicit operator byte(Number n)
        {
        }
        
        public static implicit operator Number(byte value)
        {
        }
        
        public static implicit operator sbyte(Number n)
        {
        }
        
        public static implicit operator Number(sbyte value)
        {
        }
        
        public static implicit operator char(Number n)
        {
        }
        
        public static implicit operator Number(char value)
        {
        }
        
        public static implicit operator decimal(Number n)
        {
        }
        
        public static implicit operator Number(decimal value)
        {
        }
        
        public static implicit operator double(Number n)
        {
        }
        
        public static implicit operator Number(double value)
        {
        }
        
        public static implicit operator float(Number n)
        {
        }
        
        public static implicit operator Number(float value)
        {
        }
        
        public static implicit operator int(Number n)
        {
        }
        
        public static implicit operator Number(int value)
        {
        }
        
        public static implicit operator uint(Number n)
        {
        }
        
        public static implicit operator Number(uint value)
        {
        }
        
        public static implicit operator nint(Number n)
        {
        }
        
        public static implicit operator Number(nint value)
        {
        }
        
        public static implicit operator nuint(Number n)
        {
        }
        
        public static implicit operator Number(nuint value)
        {
        }
        
        public static implicit operator long(Number n)
        {
        }
        
        public static implicit operator Number(long value)
        {
        }
        
        public static implicit operator ulong(Number n)
        {
        }
        
        public static implicit operator Number(ulong value)
        {
        }
        
        public static implicit operator short(Number n)
        {
        }
        
        public static implicit operator Number(short value)
        {
        }
        
        public static implicit operator ushort(Number n)
        {
        }
        
        public static implicit operator Number(ushort value)
        {
        }
        
        public static implicit operator BigInteger(Number n)
        {
        }
        
        public static implicit operator Number(BigInteger value)
        {
        }
        
        public static implicit operator string(Number n)
        {
        }
        
        public static implicit operator Number(string value)
        {
        }
        
        #endregion
    }
}
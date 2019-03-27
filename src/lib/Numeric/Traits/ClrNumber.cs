namespace Z0
{
    using System;
    using System.Numerics;

    using Currency = Traits.Currency<decimal>;
    partial class Traits
    {
        /// <summary>
        /// Characterizes finite unsigned integer operations over byte,
        /// ushort, uint and ulong values
        /// </summary>
        public interface UnsignedFiniteRealInt<T> : FiniteNatural<T>, FiniteReal<T>        
        {
            
        }

        /// <summary>
        /// Characterizes finite signed integer operations over sbyte,
        /// short, int and long values
        /// </summary>
        public interface SignedFiniteRealInt<T> : FiniteSignedInt<T>, FiniteReal<T>
        {
            
        }

        /// <summary>
        /// Characterizes real floating point operations that include float and double
        /// </summary>
        public interface FiniteRealFloat<T> : FiniteFloat<T>, FiniteReal<T>
        {
            
        }

        /// <summary>
        /// Characterizes BigInteger operations
        /// </summary>
        public interface SignedInfiniteRealInt : Real<BigInteger>,  InfiniteSignedInt<BigInteger>
        {

        }

        /// <summary>
        /// Characterizes decimal operations
        /// </summary>
        public interface FiniteCurrency : Currency, Traits.FiniteReal<decimal>
        {

        }
    }

}
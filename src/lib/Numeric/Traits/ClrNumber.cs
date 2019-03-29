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
        public interface FiniteUInt<T> : FiniteNatural<T>, BoundReal<T>        
        {
            
        }

        /// <summary>
        /// Characterizes operational reifications of RealFiniteUInt 
        /// </summary>        
        /// <typeparam name="R">The reification type</typeparam>
        /// <typeparam name="T">The operand type</typeparam>
        public interface FiniteUInt<R,T> : FiniteUInt<T>, Operational<R,T>
            where R : FiniteUInt<R,T>, new()
        {
            
        }


        /// <summary>
        /// Characterizes operational reifications of RealFiniteUInt 
        /// </summary>
        /// <typeparam name="R">The reification type</typeparam>
        /// <typeparam name="T">The operand type</typeparam>
        public interface RealFiniteInt<R,T> : FiniteSignedInt<T>, Operational<R,T>
            where R : RealFiniteInt<R,T>, new()
        {
            
        }


        /// <summary>
        /// Characterizes operational reifications of RealFiniteUInt 
        /// </summary>
        /// <typeparam name="R">The reification type</typeparam>
        /// <typeparam name="T">The operand type</typeparam>
        public interface FiniteFloat<R,T> : FiniteFloat<T>, Operational<R,T>
            where R : FiniteFloat<R,T>, new()
        {
            
        }

        /// <summary>
        /// Characterizes BigInteger operations
        /// </summary>
        public interface RealInfiniteInt<T> : RealNumber<T>, InfiniteSignedInt<T>
        {

        }

        /// <summary>
        /// Characterizes operational reifications of RealFiniteUInt 
        /// </summary>
        /// <typeparam name="R">The reification type</typeparam>
        /// <typeparam name="T">The operand type</typeparam>
        public interface RealInfiniteInt<R,T> : RealInfiniteInt<T>, Operational<R,T>
            where R : RealInfiniteInt<R,T>, new()
        {
            
        }

        /// <summary>
        /// Characterizes a bounded fractional operation provider
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public interface Currency<T> : BoundReal<T>, Fractional<T> 
        {

        }


        /// <summary>
        /// Characterizes operational reifications of Currency 
        /// </summary>
        /// <typeparam name="R">The reification type</typeparam>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Currency<R,T> : Currency<T>, Operational<R,T>
            where R : Currency<R,T>, new()
        {
            
        }

    }

}
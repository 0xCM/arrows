//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using static zcore;

    partial class C
    {
        public interface ISignable<S> : IOrderable<S>
            where S : ISignable<S>, new()
        {
            /// <summary>
            /// Specifies the sign of the structure
            /// </summary>
            /// <returns>
            /// If x > 0, returns 1
            /// If x < 0, returns -1
            /// If x == 0, returns 0
            /// </returns>
            S sign {get;}

            /// <summary>
            /// Specifies whether a structure is positive
            /// </summary>
            /// <returns>Returns 1 if x:S => x > 0, 0 otherwise</returns>
            S positive {get;}

            /// <summary>
            /// Determines whether a structure is negative
            /// </summary>
            /// <returns>Returns 1 if x:S => x < 0, 0 otherwise</returns>
            S negative {get;}           

            S abs();

            S negate();
        }

        /// <summary>
        /// Characterizes a number upon which a total order is defined
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        public interface OrdNum<S> : ICNumber<S>, IOrderable<S> 
            where S : OrdNum<S>, new()
        {

        }

        /// <summary>
        /// Characterizes a number upon which a total order is defined
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        public interface OrdNum<S,T> : ICNumber<S,T>, OrdNum<S>
            where S : OrdNum<S,T>, new()
        {

        }

        public interface RealNum<S> : OrdNum<S>
            where S : RealNum<S>, new()
        {

        }

        public interface RealNum<S,T> : RealNum<S>, OrdNum<S,T>
            where S : RealNum<S,T>,new()
        {


        }

        /// <summary>
        /// Characterizes a structural integer
        /// </summary>
        /// <typeparam name="S">The reifying type</typeparam>
        public interface Int<S> : RealNum<S>, IBitwise<S>
            where S : Int<S>, new()
        {

        }

        public interface Int<S,T> : Int<S>, RealNum<S,T>
            where S : Int<S,T>, new()
        {


        }


        public interface UNum<S> : RealNum<S>
            where S : UNum<S>, new()
        {

        }

        public interface SNum<S> : RealNum<S>, ISignable<S> 
            where S : SNum<S>, new()
        {

        }

        public interface SNum<S,T> : SNum<S>, RealNum<S,T>
            where S : SNum<S,T>, new()
        {

        }


        /// <summary>
        /// Characterizes a structural unsignable integer
        /// </summary>
        /// <typeparam name="S">The reifying type</typeparam>
        public interface UInt<S> : Int<S>
            where S : UInt<S>, new()
        {


        }

        public interface UInt<S,T> : UInt<S>, Int<S,T>
            where S : UInt<S,T>, new()
        {


        }


        /// <summary>
        /// Characterizes a structural signable integer
        /// </summary>
        /// <typeparam name="S">The reifying type</typeparam>
        public interface SInt<S> : ISignable<S>, Int<S>
            where S : SInt<S>, new()
        {

            
        }

        public interface SInt<S,T> : SInt<S>, Int<S,T>
            where S : SInt<S,T>, new()
        {

        }

        public interface Lifting<S,T>            
        {
            /// <summary>
            /// Elevates a primitive to a structure
            /// </summary>
            /// <param name="src">The primitive source</param>
            IEnumerable<S> lift(IEnumerable<T> src);

            /// <summary>
            /// Unwraps a lifted primitivie
            /// </summary>
            /// <param name="src">The lifted source</param>
            IEnumerable<T> drop(IEnumerable<S> src);
        }

        public interface RealCalc<T>
            where T : RealNum<T>, new()

        {

            T min(T x, T y);

            T max(T x, T y);

        }


        /// <summary>
        /// Characterizes operational equality in the C adaptation context
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface IEquator<T>
        {
            T eq(T lhs, T rhs);
            
            T neq(T lhs, T rhs);

        }

        /// <summary>
        /// Characterizes operational order
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface IOrderer<T> : IEquator<T>
        {
            T lt(T lhs, T rhs);

            T lteq(T lhs, T rhs);

            T gt(T lhs, T rhs);

            T gteq(T lhs, T rhs);
        }
        
        public interface INumOps<T>            
            : IAdditiveOps<T>, 
              IOrderer<T>,
              IMultiplicativeOps<T>, 
              IDivisiveOps<T>, 
              IBitwiseOps<T>
            where T : struct
        {
            
            NumberInfo<T> numinfo(T x);

            /// <summary>
            /// Specifies the (fixed) number of data allocation bits
            /// </summary>
            /// <param name="x"></param>
            T bitsize(T x);
            
            /// <summary>
            /// Returns the onevalue of T
            /// </summary>
            /// <param name="x">Any value</param>
            T one(T x);

            /// <summary>
            /// Determines whether a number is positive
            /// </summary>
            /// <param name="x">The test number</param>
            /// <returns>Returns 1 if x > 0 and 0 otherwise</returns>
            T positive(T x);

            /// <summary>
            /// Determines whether a number is negative
            /// </summary>
            /// <param name="x">The number to test</param>
            /// <returns>Returns 1 if x < 0 and 0 otherwise</returns>
            T negative(T x);            

            /// <summary>
            /// Determines the sign of a number
            /// </summary>
            /// <param name="x">The number to evaluate</param>
            /// <returns>
            /// If x > 0, returns 1
            /// If x < 0, returns -1
            /// If x == 0, returns 0
            /// </returns>
            T sign(T x);

            /// <summary>
            /// Computes the absolute value of the source
            /// </summary>
            /// <param name="x">The source value</param>
            T abs(T x); 
        }
    }
}
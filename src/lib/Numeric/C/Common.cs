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
     
        public interface Ordered<T>
        {
            T lt(T lhs, T rhs);

            T lteq(T lhs, T rhs);

            T gt(T lhs, T rhs);

            T gteq(T lhs, T rhs);


        }
        
        public interface Number<T>            
            : Operative.Additive<T>, 
              Ordered<T>,
              Operative.Multiplicative<T>, 
              Operative.Divisive<T>, 
              Operative.Bitwise<T> 
        {
            
            NumberInfo<T> numinfo(T x);

            T eq(T lhs, T rhs);
            
            T neq(T lhs, T rhs);

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

        }

        public interface SignableNumber<T> : Number<T>, Operative.Negatable<T>
        {
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


            T abs(T x); 
        }
    }

}
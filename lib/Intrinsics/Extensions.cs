//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zcore;
    using static inxfunc;
    using static Operative;

    partial class InXX
    {
        /// <summary>
        /// Divides one floating-point scalar by another
        /// </summary>
        /// <param name="lhs">The dividend</param>
        /// <param name="rhs">The divisor</param>
        /// <typeparam name="T">The primitive type, either single or double</typeparam>
        [MethodImpl(Inline)]
        public static Num128<T> DivF<T>(this in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
                => InXG.divf(lhs,rhs);
        
        /// <summary>
        /// Divides the components of two floating-point vectors
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type, either single or double</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> DivF<T>(this in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => InXG.divf(lhs,rhs);

        /// <summary>
        /// Compares two floating-point scalars
        /// </summary>
        /// <param name="lhs">The first scalar</param>
        /// <param name="rhs">The second scalar</param>
        /// <param name="mode">The comparison algorithm</param>
        /// <typeparam name="T">The primitive float type, either single or double</typeparam>
        [MethodImpl(Inline)]
        public static bool CmpF<T>(this in Num128<T> lhs, in Num128<T> rhs, FloatComparisonMode mode)
            where T : struct, IEquatable<T>
                => InXG.cmpf(lhs,rhs,mode);

        /// <summary>
        /// Compares two floating-point vectors
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <param name="mode">The comparison algorithm</param>
        /// <typeparam name="T">The primitive float type, either single or double</typeparam>
        [MethodImpl(Inline)]
        public static bool[] CmpF<T>(this in Vec128<T> lhs, in Vec128<T> rhs, FloatComparisonMode mode)
            where T : struct, IEquatable<T>
                => InXG.cmpf(lhs,rhs,mode);
 

        /// <summary>
        /// Computes the bitwise and of two vectors
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> And<T>(this in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => Vec128Ops.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<T> Add<T>(this in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => Vec128Ops.add(lhs,rhs);

        /// <summary>
        /// Computes the bitwise or of two vectors
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> Or<T>(this in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => Vec128Ops.or(lhs,rhs);


        /// <summary>
        /// Defines a stream of vectors over an array
        /// </summary>
        /// <param name="lhs">The source array</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<T>> Stream128<T>(this T[] src)
            where T : struct, IEquatable<T>
                => InXG.stream128(src); 

    }
}
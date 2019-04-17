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
    using static inX;
    using static Operative;

    
    partial class InXG
    {
        /// <summary>
        /// Obtains the add operator bundle for a specified primitive type
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXAdd<T> add<T>()
            where T : struct, IEquatable<T>
                => SSR.InXAddG<T>.Operator;

        /// <summary>
        /// Applies the generic add operator to supplied operands
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> add<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXAddG<T>.TheOnly.add(lhs,rhs);

        /// <summary>
        /// Obtains the div operator bundle for a specified primitive type
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXDiv<T> div<T>()
            where T : struct, IEquatable<T>
                => SSR.InXDivG<T>.Operator;


        [MethodImpl(Inline)]
        public static Vec128<T> div<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXDivG<T>.TheOnly.div(lhs,rhs);

        [MethodImpl(Inline)]
        public static Num128<T> div<T>(Num128<T> lhs, Num128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXDivG<T>.TheOnly.div(lhs,rhs);


        /// <summary>
        /// Obtains the and operator bundle for a specified primitive type
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXAnd<T> and<T>()
            where T : struct, IEquatable<T>
                => SSR.InXAndG<T>.Operator;

        /// <summary>
        /// Applies the generic and operator to supplied operands
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> and<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXAndG<T>.TheOnly.and(lhs,rhs);


        /// <summary>
        /// Obtains the bittest operator bundle for a specified primitive type
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXBitTest<T> bittest<T>()
            where T : struct, IEquatable<T>
                => SSR.InXBitTestG<T>.Operator;

        [MethodImpl(Inline)]
        public static bool allOn<T>(Vec128<T> src)
            where T : struct, IEquatable<T>
                => SSR.InXBitTestG<T>.TheOnly.allOn(src);
        
        [MethodImpl(Inline)]
        public static bool allOff<T>(Vec128<T> src, Vec128<T> mask)
            where T : struct, IEquatable<T>
                => SSR.InXBitTestG<T>.TheOnly.allOff(src, mask);


        [MethodImpl(Inline)]
        public static bool testC<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXBitTestG<T>.TheOnly.testC(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool testZ<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXBitTestG<T>.TheOnly.testZ(lhs, rhs);

        /// <summary>
        /// Obtains the generic eq operator for a parametric primitive type
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXEq<T> eq<T>()
            where T : struct, IEquatable<T>
                => SSR.InXEqG<T>.Operator;

        /// <summary>
        /// Applies the generic eq operator to supplied operands
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> eq<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXEqG<T>.TheOnly.eq(lhs,rhs);

        /// <summary>
        /// Obtains the generic load operator for a specified primitive type
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXLoad<T> load<T>()
            where T : struct, IEquatable<T>
                => SSR.InXLoadG<T>.Operator;

        /// <summary>
        /// Loads a vector from a source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> load<T>(Span128<T> src)
            where T : struct, IEquatable<T>
                => SSR.InXLoadG<T>.TheOnly.load(src);

        /// <summary>
        /// Obtains the generic or operator for a parametric primitive type
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public static InXOr<T> or<T>()
            where T : struct, IEquatable<T>
                => SSR.InXOrG<T>.Operator;

        /// <summary>
        /// Applies the generic or operator to supplied operands
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> or<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXOrG<T>.TheOnly.or(lhs,rhs);

        /// <summary>
        /// Obtains the generic store operator for a parametric primitive type
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXStore<T> store<T>()
            where T : struct, IEquatable<T>
                => SSR.InXStoreG<T>.Operator;

        /// <summary>
        /// Writes data data in a source vector to a target array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target array</param>
        /// <param name="offset">The position in the target array where receipt of source data can begin</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static void store<T>(Vec128<T> src, T[] dst, int offset = 0)
            where T : struct, IEquatable<T>
                => SSR.InXStoreG<T>.TheOnly.store(src, dst, offset);

        /// <summary>
        /// Writes data data in a list of source vectors to a target array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target array</param>
        /// <param name="offset">The position in the target array where receipt of source data can begin</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static void store<T>(IReadOnlyList<Vec128<T>> src, T[] dst, int offset = 0)
            where T : struct, IEquatable<T>
                => SSR.InXStoreG<T>.TheOnly.store(src, dst, offset);

        /// <summary>
        /// Obtains the generic stream operator for a parametric primitive type
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXStream<T> stream<T>()
            where T : struct, IEquatable<T>
                => SSR.InX128StreamG<T>.Operator;

        /// <summary>
        /// Applies the generic stream operator to an array
        /// </summary>
        /// <param name="lhs">The source array</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<T>> stream<T>(T[] src)
            where T : struct, IEquatable<T>
                => SSR.InX128StreamG<T>.TheOnly.stream(src); 

        /// <summary>
        /// Obtains the generic xor operator for a specified primitive type
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public static InXXOr<T> xor<T>()
            where T : struct, IEquatable<T>
                => SSR.InXXOrG<T>.Operator;

        /// <summary>
        /// Applies the generic xor operator to supplied operands
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> xor<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXXOrG<T>.TheOnly.xor(lhs,rhs);
    }

}
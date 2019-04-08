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

    public static class ConvertG
    {
        
        /// <summary>
        /// Converts a primitive s:S  to a real t:real[T]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The underlying target type</typeparam>
        [MethodImpl(Inline)]
        public static real<T> toReal<S,T>(S src)
            where T : struct, IEquatable<T>
                => ClrConvert.apply<S,T>(src);


        /// <summary>
        /// Converts a list of primitives s:list[S] to a list of reals t:list[real[T]]
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The underlying target type</typeparam>
        [MethodImpl(Inline)]
        public static IReadOnlyList<real<T>> toReal<S,T>(IReadOnlyList<S> src)
            where T : struct, IEquatable<T>
                => map(ClrConvert.apply<S,T>(src), x => real(x));

        /// <summary>
        /// Converts a primitive s:S  to an integer t:intg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The underlying target type</typeparam>
        [MethodImpl(Inline)]
        public static intg<T> toInt<S,T>(S src)
            where T : struct, IEquatable<T>
                => ClrConvert.apply<S,T>(src);

        /// <summary>
        /// Converts a list of primitives s:list[S] to a list of integers t:list[intg[T]]
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The underlying target type</typeparam>
        [MethodImpl(Inline)]
        public static IReadOnlyList<intg<T>> toInt<S,T>(IReadOnlyList<S> src)
            where T : struct, IEquatable<T>
                => map(ClrConvert.apply<S,T>(src), x => intg(x));

        /// <summary>
        /// Converts a primitive s:S to a float t:floatg[T]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The underlying target type</typeparam>
        public static floatg<T> toFloat<S,T>(S src)
            where T : struct, IEquatable<T>
                => ClrConvert.apply<S,T>(src);

        /// <summary>
        /// Converts a list of primitive s:list[S] to a list of floats t:list[floatg[T]]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The underlying target type</typeparam>
        [MethodImpl(Inline)]
        public static IReadOnlyList<floatg<T>> toFloat<S,T>(IReadOnlyList<S> src)
            where T : struct, IEquatable<T>
                => map(ClrConvert.apply<S,T>(src), x => floatg(x));

    }
}
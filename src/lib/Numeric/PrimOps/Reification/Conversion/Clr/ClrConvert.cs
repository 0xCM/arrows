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
    
    using static Operative;
    using static ClrConverters;


    public static class ClrConversion
    {
        /// <summary>
        /// Fetches the S => T converter
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>        
        [MethodImpl(Inline)]
        static ClrConverter<S,T> singleton<S,T>()
            => ClrConverter<S,T>.Inhabitant;

        /// <summary>
        /// Effects x:S => convert(x):T
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>        
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static T convert<S,T>(S src)
            => singleton<S,T>().convert(src);

        /// <summary>
        /// Applies s:S => convert(s):T
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline)]
        public static T convert<S,T>(S src, out T dst)
            => singleton<S,T>().convert(src, out dst);

        /// <summary>
        /// Effects x:array[S] => convert(x):array[T]
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="src">The source array</param>
        public static IReadOnlyList<T> convert<S,T>(IReadOnlyList<S> src)
            => singleton<S,T>().convert(src);

    }

}
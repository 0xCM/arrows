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


    public static class ClrConvert
    {
        /// <summary>
        /// Fetches the raw S => T converter
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>The more extensible approach, obtaining a converter via a hash lookup
        /// is much slower than conditional logic, at least for a small number of entries</remarks>
        [MethodImpl(Inline)]
        public static Conversion<S,T> raw<S,T>()
        {
            var target = typeof(T);

            //x => int
            if(target == ToClrInt32.TargetType) 
                return cast<Conversion<S,T>>(ToClrInt32.Inhabitant);

            //x => double
            if(target == ToClrFloat64.TargetType) 
                return cast<Conversion<S,T>>(ToClrFloat64.Inhabitant);

            //x => long
            if(target == ToClrInt64.TargetType) 
                return cast<Conversion<S,T>>(ToClrInt64.Inhabitant);

            //x => float
            if(target == ToClrFloat32.TargetType) 
                return cast<Conversion<S,T>>(ToClrFloat32.Inhabitant);

            //x => uint
            if(target == ToClrUInt32.TargetType) 
                return cast<Conversion<S,T>>(ToClrUInt32.Inhabitant);

            //x => short
            if(target == ToClrInt16.TargetType) 
                return cast<Conversion<S,T>>(ToClrInt16.Inhabitant);

            //x => ulong
            if(target == ToClrUInt64.TargetType) 
                return cast<Conversion<S,T>>(ToClrUInt64.Inhabitant);

            //x => sbyte
            if(target == ToClrInt8.TargetType) 
                return cast<Conversion<S,T>>(ToClrInt8.Inhabitant);

            //x => byte
            if(target == ToClrUInt8.TargetType) 
                return cast<Conversion<S,T>>(ToClrUInt8.Inhabitant);

            //x => ushort
            if(target == ToClrUInt16.TargetType) 
                return cast<Conversion<S,T>>(ToClrUInt16.Inhabitant);

            //x => decimal
            if(target == ToClrDecimal.TargetType) 
                return cast<Conversion<S,T>>(ToClrDecimal.Inhabitant);

            //x => BigInteger
            if(target == ToClrBigInt.TargetType) 
                return cast<Conversion<S,T>>(ToClrBigInt.Inhabitant);

            throw new NotSupportedException();                        
        }

        /// <summary>
        /// Fetches the S => T converter
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>        
        [MethodImpl(Inline)]
        public static ClrConverter<S,T> converter<S,T>()
            => ClrConverter<S,T>.Inhabitant;

        /// <summary>
        /// Effects x:S => convert(x):T
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>        
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static T apply<S,T>(S src)
            => converter<S,T>().convert(src);

        /// <summary>
        /// Applies s:S => convert(s):T
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline)]
        public static T apply<S,T>(S src, out T dst)
            => converter<S,T>().convert(src, out dst);

        /// <summary>
        /// Effects x:stream[S] => convert(x):stream[T]
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="src">The source stream</param>
        /// <param name="pll">Specifies whether the stream should be converted concurrently</param>
        [MethodImpl(Inline)]
        public static IEnumerable<T> apply<S,T>(IEnumerable<S> src, bool pll = false)
            => converter<S,T>().convert(src,pll);

        /// <summary>
        /// Effects x:array[S] => convert(x):array[T]
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="src">The source array</param>
        public static IReadOnlyList<T> apply<S,T>(IReadOnlyList<S> src)
            => converter<S,T>().convert(src);

    }

}
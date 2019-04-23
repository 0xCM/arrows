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

    /// <summary>
    /// Defines conversion operations from a clr numeric primitive s:S
    /// to another clr primitive t:T. The operation convert:S -> T always succeeds
    /// as the source values are truncated as necessary.
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public readonly struct ClrConverter<S, T> : Operative.ClrConverter<S, T>
    {
        public static readonly ClrConverter<S, T> Inhabitant = default;
        
        static readonly Conversion<S,T> Convert = choose();

        [MethodImpl(Inline)]
        public Index<T> convert(Index<S> src)
        {
            var dst = array<T>(src.Count);
            iter(src.Count, i => dst[i] = Convert.convert(src[i]));
            return dst;
        }

        [MethodImpl(Inline)]
        public T convert(S src)
            => Convert.convert(src);

        [MethodImpl(Inline)]
        public T convert(S src, out T dst)
            => Convert.convert(src, out dst);


        /// <summary>
        /// Fetches the raw S => T converter
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>The more extensible approach, obtaining a converter via a hash lookup
        /// is much slower than conditional logic, at least for a small number of entries</remarks>
        static Conversion<S,T> choose()
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
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;
using static Z0.As;
using static Constants;

partial class zfunc
{

    [MethodImpl(Inline)]
    public static bool testbit(in ulong src, in int pos)
        => (src & (U64One << pos)) != 0ul;


    [MethodImpl(Inline)]
    public static Span<float> floats<T>(params T[] src)
        where T : struct
            =>  convert<T,float>(src.ToReadOnlySpan());

    [MethodImpl(Inline)]
    public static Span<double> doubles<T>(params T[] src)
        where T : struct
            =>  convert<T,double>(src.ToReadOnlySpan());


    public static IEnumerable<T> range<T>(T min, T max, T? step = null)
        where T : struct
    {
        if(typeof(T) == typeof(sbyte))
        {
            var _min = int8(min);
            var _max = int8(max);
            var _step = int8(step) ??(sbyte)1;
            for(var i =_min; i <=_max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(byte))
        {
            var _min = uint8(min);
            var _max = uint8(max);
            var _step = uint8(step) ??(byte)1;
            for(var i =_min; i <=_max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(short))
        {
            var _min = int16(min);
            var _max = int16(max);
            var _step = int16(step) ?? (short)1;
            for(var i =_min; i <=_max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(ushort))
        {
            var _min = uint16(min);
            var _max = uint16(max);
            var _step = uint16(step) ?? (ushort)1;
            for(var i =_min; i <=_max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(int))
        {
            var _min = int32(min);
            var _max = int32(max);
            var _step = int32(step) ?? 1;
            for(var i =_min; i <=_max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(uint))
        {
            var _min = uint32(min);
            var _max = uint32(max);
            var _step = uint32(step) ?? 1u;
            for(var i =_min; i <=_max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(long))
        {
            var _min = int64(min);
            var _max = int64(max);
            var _step = int64(step) ?? 1L;
            for(var i =_min; i <_max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(ulong))
        {
            var _min = uint64(min);
            var _max = uint64(max);
            var _step = uint64(step) ?? 1ul;
            for(var i =_min; i <=_max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(float))
        {
            var _min = float32(min);
            var _max = float32(max);
            var _step = float32(step) ?? 1f;
            for(var i =_min; i <_max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(double))
        {
            var _min = float64(min);
            var _max = float64(max);
            var _step = float64(step) ?? 1d;
            for(var i =_min; i <=_max; i += _step)            
                yield return generic<T>(i);
        }
        else
            throw unsupported<T>();

    }

    public static IEnumerable<T> range<T>(T count)
        where T : struct
            => range(default(T), count);


}
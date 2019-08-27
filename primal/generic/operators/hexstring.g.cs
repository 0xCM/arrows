//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Runtime.Intrinsics.X86;
        
    using static zfunc;

    using static As;

    partial class gmath
    {
        public static string hexstring<T>(T src, bool zpad = true, bool specifier = true)
            where T : struct
        {
            var digits = string.Empty;
            var fmt = "X";
            if(typeof(T) == typeof(sbyte))
                digits = As.int8(src).ToString(fmt);
            else if(typeof(T) == typeof(byte))
                digits = As.uint8(src).ToString(fmt);
            else if(typeof(T) == typeof(short))
                digits = As.int16(src).ToString(fmt);
            else if(typeof(T) == typeof(ushort))
                digits = As.uint16(src).ToString(fmt);
            else if(typeof(T) == typeof(int))
                digits = As.int32(src).ToString(fmt);
            else if(typeof(T) == typeof(uint))
                digits = As.uint32(src).ToString(fmt);
            else if(typeof(T) == typeof(long))
                digits = As.int64(src).ToString(fmt);
            else if(typeof(T) == typeof(ulong))
                digits = As.uint64(src).ToString(fmt);
            else if(typeof(T) == typeof(float))
                digits = convert<float,int>(As.float32(src)).ToString(fmt);
            else if(typeof(T) == typeof(double))
                digits = convert<double,long>(As.float64(src)).ToString(fmt);
            else
                throw unsupported<T>();

            var spec = specifier ? "0x" : string.Empty;
            return zpad ?  (spec + digits.PadLeft(SizeOf<T>.Size * 2, '0')) : (spec + digits);
        } 
    }
}
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

    
    public static partial class x86
    {
        [MethodImpl(Inline)]
        public static IReadOnlyList<T> datasource<T>(object data, int count)
        {
            var src = (IReadOnlyList<T>)data;
            if(src.Count != count)
                throw new Exception($"The actual value was {src.Count} but the expected value was {count}");
            return src;

        }
            
        

        [MethodImpl(Inline)]
        public static unsafe void* i8num(object value, int count)
        {
            var dst =  stackalloc sbyte[count];
            dst[0] = cast<sbyte>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* i8vec(object data, int count)
        {
            var src = datasource<sbyte>(data,count);
            var dst =  stackalloc sbyte[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe void* u8num(object value, int count)
        {
            var dst =  stackalloc byte[count];
            dst[0] = cast<byte>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* u8vec(object data, int count)
        {
            var src = datasource<byte>(data,count);
            var dst =  stackalloc byte[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe void* i16vec(object data, int count)
        {
            var src = datasource<short>(data,count);
            var dst =  stackalloc short[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe void* i16num(object value, int count)
        {
            var dst =  stackalloc short[count];
            dst[0] = cast<short>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* u16num(object value, int count)
        {
            var dst =  stackalloc ushort[count];
            dst[0] = cast<ushort>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* u16vec(object data, int count)
        {
            var src = datasource<ushort>(data,count);
            var dst =  stackalloc ushort[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe void* i32num(object value, int count)
        {
            var dst =  stackalloc int[count];
            dst[0] = cast<int>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* i32vec(object data, int count)
        {
            var src = datasource<int>(data,count);
            var dst =  stackalloc int[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe uint* u32num(object value, int count)
        {
            var dst =  stackalloc uint[count];
            dst[0] = cast<uint>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe uint* u32vec(object data, int count)
        {
            var src = datasource<uint>(data,count);
            var dst =  stackalloc uint[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe long* i64num(object value, int count)
        {
            var dst =  stackalloc long[count];
            dst[0] = cast<long>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe long* i64vec(object data, int count)
        {
            var src = datasource<long>(data,count);
            var dst =  stackalloc long[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe ulong* u64num(object value, int count)
        {
            var dst =  stackalloc ulong[count];
            dst[0] = cast<ulong>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ulong* u64vec(object data, int count)
        {
            var src = datasource<ulong>(data,count);
            var dst =  stackalloc ulong[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe void* f32num(object value, int count)
        {
            var dst =  stackalloc float[count];
            dst[0] = cast<float>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* f32vec(object data, int count)
        {
            var src = datasource<float>(data,count);
            var dst =  stackalloc float[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe void* f64num(object value, int count)
        {
            var dst =  stackalloc double[count];
            dst[0] = cast<double>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* f64vec(object data, int count)
        {
            var src = datasource<double>(data,count);
            var dst =  stackalloc double[count];
            return copy(src,dst);
        }
    }
}
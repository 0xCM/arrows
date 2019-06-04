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
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Sse;
    
    using static zfunc;
    using static As;
    using static AsInX;
    
    public static partial class Vec128
    {

        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> define(byte x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> define(
            byte x0, byte x1, byte x2, byte x3,  
            byte x4, byte x5, byte x6, byte x7, 
            byte x8, byte x9, byte x10, byte x11,
            byte x12, byte x13, byte x14, byte x15) 
                =>  Vector128.Create(x0, x1, x2, x3, x4, x5, x6, x7, 
                    x8, x9, x10, x11,x12, x13, x14, x15);


        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> define(sbyte x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> define(
                sbyte x00, sbyte x01, sbyte x02, sbyte x03, 
                sbyte x04, sbyte x05, sbyte x06, sbyte x07,
                sbyte x08, sbyte x09, sbyte x10, sbyte x11,
                sbyte x12, sbyte x13, sbyte x14, sbyte x15)
                    => Vector128.Create(
                        x00, x01, x02, x03, x04, x05, x06, x07, 
                        x08, x09, x10, x11,x12, x13, x14, x15);


        [MethodImpl(Inline)]
        public static unsafe Vec128<short> define(short x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> define(
                short x0, short x1, short x2, short x3, 
                short x4, short x5, short x6, short x7) 
                    => Vector128.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        
        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> define(ushort x0)
            => Vector128.Create(x0);
        
        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> define(
                ushort x0, ushort x1, ushort x2, ushort x3, 
                ushort x4, ushort x5, ushort x6, ushort x7)
                    => Vector128.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> define(int x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> define(int x0, int x1, int x2, int x3)
            => Vector128.Create(x0,x1,x2,x3);
        
        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> define(uint x0)
            => Vector128.Create(x0);
        
        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> define(uint x0, uint x1, uint x2, uint x3)
            => Vector128.Create(x0,x1,x2,x3);
        
        [MethodImpl(Inline)]
        public static unsafe Vec128<long> define(long x0)
            => Vector128.Create(x0);
        
        [MethodImpl(Inline)]
        public static unsafe Vec128<long> define(long x0, long x1)
            => Vector128.Create(x0,x1);

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> define(ulong x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> define(ulong x0, ulong x1)
            => Vector128.Create(x0,x1);

        [MethodImpl(Inline)]
        public static unsafe Vec128<float> define(float x0)
            => Vector128.Create(x0);
        
        [MethodImpl(Inline)]
        public static unsafe Vec128<float> define(float x0, float x1, float x2, float x3)
            => Vector128.Create(x0,x1,x2,x3);
    
        [MethodImpl(Inline)]
        public static unsafe Vec128<double> define(double x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static unsafe Vec128<double> define(double x0, double x1)
            => Vector128.Create(x0,x1);

        [MethodImpl(Inline)]
        static Vec128<T> vInt8<T>(ref T[] data, int offset)
            where T : struct
        {
            var i = offset;
            var src = int8(ref data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]
            );
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Vec128<T> vUInt8<T>(ref T[] data, int offset)
            where T : struct
        {
            var src = uint8(data);
            var i = offset;
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]
            );
            return generic<T>(dst);
        }


        [MethodImpl(Inline)]
        static Vec128<T> vInt16<T>(ref T[] data, int offset)
            where T : struct            
        {
            var i = offset;
            var src = int16(data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]
                );
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vUInt16<T>(ref T[] data, int offset)
            where T : struct            
        {
            var i = offset;
            var src = uint16(data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]
                );
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vInt32<T>(ref T[] data, int offset)
            where T : struct            
        {
            var i = offset;
            var src = int32(data);
            var dst = define(src[i++],src[i++],src[i++],src[i++]);
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vUInt32<T>(ref T[] data, int offset)
            where T : struct            
        {
            var i = offset;
            var src = uint32(data);
            var dst = define(src[i++],src[i++],src[i++],src[i++]);
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vInt64<T>(ref T[] data,int startpos)
            where T : struct            
        {
            var i = startpos;
            var src = int64(data);
            var dst = define(src[i++],src[i++]);
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vUInt64<T>(ref T[] data, int offset)
            where T : struct            
        {
            var i = offset;
            var src = uint64(data);
            var dst = define(src[i++],src[i++]);
            return generic<T>(dst);
        }


        [MethodImpl(Inline)]
        static Vec128<T> vFloat32<T>(ref T[] data, int offset)
            where T : struct            
        {
            var i = offset;
            var src = float32(data);
            var dst = define(src[i++],src[i++],src[i++],src[i++]);
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vFloat64<T>(ref T[] data, int offset)
            where T : struct            
        {
            var i = offset;
            var src = float64(data);
            var dst = define(src[i++],src[i++]);
            return generic<T>(dst);
        }

    }

}
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

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    
    using static zfunc;
    using static As;
    using static AsInX;

    partial class Vec256
    {

       /// <summary>
        /// Constructs a 256-bit vector from the contents of a list. An error will
        /// be raised if the length of the list does not match the length of the
        /// target vector
        /// </summary>
        /// <param name="src">The source list</param>
        /// <typeparam name="T">The primitive type</typeparam>        
        [MethodImpl(Inline)]
        public static unsafe Vec256<T> define<T>(ref T[] src, int offset = 0)
            where T : struct
        {            

            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)            
                return vInt8(ref src, offset);

            if(kind == PrimalKind.uint8)            
                return vUInt8(ref src, offset);

            if(kind == PrimalKind.int16)            
                return vInt16(ref src, offset);

            if(kind == PrimalKind.uint16)            
                return vUInt16(ref src, offset);

            if(kind == PrimalKind.int32)            
                return vInt32(ref src, offset);

            if(kind == PrimalKind.uint32)            
                return vUInt32(ref src, offset);

            if(kind == PrimalKind.int64)            
                return vInt64(ref src, offset);

            if(kind == PrimalKind.uint64)            
                return vUInt64(ref src, offset);

            if(kind == PrimalKind.float32)            
                return vFloat32(ref src, offset);

            if(kind == PrimalKind.float64)            
                return vFloat64(ref src, offset);

            throw new NotSupportedException($"Kind {kind} not supported");
        }        

        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> define(
            sbyte x0, sbyte x1, sbyte x2, sbyte x3,  
            sbyte x4, sbyte x5, sbyte x6, sbyte x7, 
            sbyte x8, sbyte x9, sbyte x10, sbyte x11,
            sbyte x12, sbyte x13, sbyte x14, sbyte x15,
            sbyte x16, sbyte x17, sbyte x18, sbyte x19,  
            sbyte x20, sbyte x21, sbyte x22, sbyte x23, 
            sbyte x24, sbyte x25, sbyte x26, sbyte x27,
            sbyte x28, sbyte x29, sbyte x30, sbyte x31)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7,
                    x8,x9,x10,x11,x12,x13,x14,x15,
                    x16,x17,x18,x19,x20,x21,x22,x23,
                    x24,x25,x26,x27,x28,x29,x30,x31);


        [MethodImpl(Inline)]
        public static Vec256<byte> define(
            byte x0, byte x1, byte x2, byte x3,  
            byte x4, byte x5, byte x6, byte x7, 
            byte x8, byte x9, byte x10, byte x11,
            byte x12, byte x13, byte x14, byte x15,
            byte x16, byte x17, byte x18, byte x19,  
            byte x20, byte x21, byte x22, byte x23, 
            byte x24, byte x25, byte x26, byte x27,
            byte x28, byte x29, byte x30, byte x31)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7,
                    x8,x9,x10,x11,x12,x13,x14,x15,
                    x16,x17,x18,x19,x20,x21,x22,x23,
                    x24,x25,x26,x27,x28,x29,x30,x31);


        [MethodImpl(Inline)]
        public static unsafe Vec256<short> define(
            short x0, short x1, short x2, short x3,  
            short x4, short x5, short x6, short x7, 
            short x8, short x9, short x10, short x11,
            short x12, short x13, short x14, short x15)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7,
                    x8,x9,x10,x11,x12,x13,x14,x15);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> define(
            ushort x0, ushort x1, ushort x2, ushort x3,  
            ushort x4, ushort x5, ushort x6, ushort x7, 
            ushort x8, ushort x9, ushort x10, ushort x11,
            ushort x12, ushort x13, ushort x14, ushort x15)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7,
                    x8,x9,x10,x11,x12,x13,x14,x15);

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> define(
            int x0, int x1, int x2, int x3,  
            int x4, int x5, int x6, int x7 )
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> define(
            uint x0, uint x1, uint x2, uint x3,  
            uint x4, uint x5, uint x6, uint x7)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> define(long x0, long x1, long x2, long x3)
                => Vector256.Create(x0,x1,x2,x3);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> define(ulong x0, ulong x1, ulong x2, ulong x3)
                => Vector256.Create(x0,x1,x2,x3);

       [MethodImpl(Inline)]
        public static unsafe Vec256<float> define(
            float x0, float x1, float x2, float x3,  
            float x4, float x5, float x6, float x7 )
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

 
        [MethodImpl(Inline)]
        public static unsafe Vec256<double> define(double x0, double x1, double x2, double x3)
                => Vector256.Create(x0,x1,x2,x3);


        [MethodImpl(Inline)]
        static Vec256<T> vInt8<T>(ref T[] data, int offset)
            where T : struct
        {
            var i = offset;
            ref var src = ref int8(ref data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]
            );
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec256<T> vUInt8<T>(ref T[] data,int offset)
            where T : struct
        {
            var i = offset;
            ref var src = ref uint8(ref data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]

            );
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec256<T> vInt16<T>(ref T[] data,int offset)
            where T : struct
        {
            var i = offset;
            ref var src = ref int16(ref data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]

            );
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec256<T> vUInt16<T>(ref T[] data,int offset)
            where T : struct
        {
            var i = offset;
            ref var src = ref uint16(ref data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]

            );
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec256<T> vInt32<T>(ref T[] data,int offset)
            where T : struct
        {
            var i = offset;
            ref var src = ref uint32(ref data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]

            );
            return generic<T>(in dst);
        }

        [MethodImpl(Inline)]
        static Vec256<T> vUInt32<T>(ref T[] data,int offset)
            where T : struct
        {
            var i = offset;
            ref var src = ref uint32(ref data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]

            );
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec256<T> vInt64<T>(ref T[] data,int offset)
            where T : struct
        {
            var i = offset;
            ref var src = ref int64(ref data);
            var dst = define(src[i++], src[i++], src[i++], src[i++]);
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec256<T> vUInt64<T>(ref T[] data,int offset)
            where T : struct
        {
            var i = offset;
            ref var src = ref uint64(ref data);
            var dst = define(src[i++], src[i++], src[i++], src[i++]);
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec256<T> vFloat32<T>(ref T[] data,int offset)
            where T : struct
        {
            var i = offset;
            ref var src = ref float32(ref data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]                

            );
            return generic<T>(dst);
        }


        [MethodImpl(Inline)]
        static Vec256<T> vFloat64<T>(ref T[] data,int offset)
            where T : struct
        {
            var i = offset;
            ref var src = ref float64(ref data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++]

            );
            return generic<T>(dst);
        }

    }

}
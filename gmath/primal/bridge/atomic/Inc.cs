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
    
    
    using static mfunc;
    using static As;

    partial class bridge
    {
        [MethodImpl(Inline)]
        public static T incI8<T>(T src)
            => generic<T>(math.inc(ref int8(ref src)));

        [MethodImpl(Inline)]
        public static T incU8<T>(T src)
            => generic<T>(math.inc(ref uint8(ref src)));

        [MethodImpl(Inline)]
        public static T incI16<T>(T src)
            => generic<T>(math.inc(ref int16(ref src)));

        [MethodImpl(Inline)]
        public static T incU16<T>(T src)
            => generic<T>(math.inc(ref uint16(ref src)));

        [MethodImpl(Inline)]
        public static T incI32<T>(T src)
            => generic<T>(math.inc(ref int32(ref src)));
        
        [MethodImpl(Inline)]
        public static T incU32<T>(T src)
            => generic<T>(math.inc(ref uint32(ref src)));

        [MethodImpl(Inline)]
        public static T incI64<T>(T src)
            => generic<T>(math.inc(ref int64(ref src)));

        [MethodImpl(Inline)]
        public static T incU64<T>(T src)
            => generic<T>(math.inc(ref uint64(ref src)));

        [MethodImpl(Inline)]
        public static T incF32<T>(T src)
            => generic<T>(math.inc(ref float32(ref src)));

        [MethodImpl(Inline)]
        public static T incF64<T>(T src)
            => generic<T>(math.inc(ref float64(ref src)));

        [MethodImpl(Inline)]
        public static ref T incI8<T>(ref T io)
        {
            math.inc(ref int8(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T incU8<T>(ref T io)
        {
            math.inc(ref uint8(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T incI16<T>(ref T io)
        {
            math.inc(ref int16(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T incU16<T>(ref T io)
        {
            math.inc(ref uint16(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T incI32<T>(ref T io)
        {
            math.inc(ref int32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T incU32<T>(ref T io)
        {
            math.inc(ref uint32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T incI64<T>(ref T io)
        {
            math.inc(ref int64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T incU64<T>(ref T io)
        {
            math.inc(ref uint64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T incF32<T>(ref T io)
        {
            math.inc(ref float32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T incF64<T>(ref T io)
        {
            math.inc(ref float64(ref io));
            return ref io;
        }



    }

}
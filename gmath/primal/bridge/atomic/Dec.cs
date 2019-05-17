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
        public static ref T decI8<T>(ref T io)
        {
            math.dec(ref int8(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T decU8<T>(ref T io)
        {
            math.dec(ref uint8(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T decI16<T>(ref T io)
        {
            math.dec(ref int16(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T decU16<T>(ref T io)
        {
            math.dec(ref uint16(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T decI32<T>(ref T io)
        {
            math.dec(ref int32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T decU32<T>(ref T io)
        {
            math.dec(ref uint32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T decI64<T>(ref T io)
        {
            math.dec(ref int64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T decU64<T>(ref T io)
        {
            math.dec(ref uint64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T decF32<T>(ref T io)
        {
            math.dec(ref float32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T decF64<T>(ref T io)
        {
            math.dec(ref float64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static T decI8<T>(T src)
            => decI8(ref src);

        [MethodImpl(Inline)]
        public static T decU8<T>(T src)
            => decU8(ref src);

        [MethodImpl(Inline)]
        public static T decI16<T>(T src)
            => decI16(ref src);

        [MethodImpl(Inline)]
        public static T decU16<T>(T src)
            => decU16(ref src);

        [MethodImpl(Inline)]
        public static T decI32<T>(T src)
            => decI32(ref src);
        
        [MethodImpl(Inline)]
        public static T decU32<T>(T src)
            => decU32(ref src);

        [MethodImpl(Inline)]
        public static T decI64<T>(T src)
            => decI64(ref src);

        [MethodImpl(Inline)]
        public static T decU64<T>(T src)
            => decU64(ref src);

        [MethodImpl(Inline)]
        public static T decF32<T>(T src)
            => decF32(ref src);

        [MethodImpl(Inline)]
        public static T decF64<T>(T src)
            => decF64(ref src);

    }

}
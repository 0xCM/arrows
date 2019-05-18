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
        public static T squareI8<T>(T src)
            => squareI8(ref src);

        [MethodImpl(Inline)]
        public static T squareU8<T>(T src)
            => squareU8(ref src);

        [MethodImpl(Inline)]
        public static T squareI16<T>(T src)
            => squareI16(ref src);

        [MethodImpl(Inline)]
        public static T squareU16<T>(T src)
            => squareU16(ref src);

        [MethodImpl(Inline)]
        public static T squareI32<T>(T src)
            => squareI32(ref src);
        
        [MethodImpl(Inline)]
        public static T squareU32<T>(T src)
            => squareU32(ref src);

        [MethodImpl(Inline)]
        public static T squareI64<T>(T src)
            => squareI64(ref src);

        [MethodImpl(Inline)]
        public static T squareU64<T>(T src)
            => squareU64(ref src);

        [MethodImpl(Inline)]
        public static T squareF32<T>(T src)
            => squareU32(ref src);

        [MethodImpl(Inline)]
        public static T squareF64<T>(T src)
            => squareI64(ref src);

        [MethodImpl(Inline)]
        public static ref T squareI8<T>(ref T src)
        {
            math.square(ref int8(ref src));            
            return ref src;
        }            

        [MethodImpl(Inline)]
        public static ref T squareU8<T>(ref T src)
        {
            math.square(ref uint8(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T squareI16<T>(ref T src)
        {
            math.square(ref int16(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T squareU16<T>(ref T src)
        {
            math.square(ref uint16(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T squareI32<T>(ref T src)
        {
            math.square(ref int32(ref src));            
            return ref src;
        }
        
        [MethodImpl(Inline)]
        public static ref T squareU32<T>(ref T src)
        {
            math.square(ref uint32(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T squareI64<T>(ref T src)
        {
            math.square(ref int64(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T squareU64<T>(ref T src)
        {
            math.square(ref uint64(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T squareF32<T>(ref T src)
        {
            math.square(ref float32(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T squareF64<T>(ref T src)
        {
            math.square(ref float64(ref src));            
            return ref src;
        }
    }
}
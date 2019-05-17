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
        public static ref T sqrtI8<T>(ref T src)
        {
            math.sqrt(ref int8(ref src));            
            return ref src;
        }            

        [MethodImpl(Inline)]
        public static ref T sqrtU8<T>(ref T src)
        {
            math.sqrt(ref uint8(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T sqrtI16<T>(ref T src)
        {
            math.sqrt(ref int16(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T sqrtU16<T>(ref T src)
        {
            math.sqrt(ref uint16(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T sqrtI32<T>(ref T src)
        {
            math.sqrt(ref int32(ref src));            
            return ref src;
        }
        
        [MethodImpl(Inline)]
        public static ref T sqrtU32<T>(ref T src)
        {
            math.sqrt(ref uint32(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T sqrtI64<T>(ref T src)
        {
            math.sqrt(ref int64(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T sqrtU64<T>(ref T src)
        {
            math.sqrt(ref uint64(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T sqrtF32<T>(ref T src)
        {
            math.sqrt(ref float32(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T sqrtF64<T>(ref T src)
        {
            math.sqrt(ref float64(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static T sqrtI8<T>(T src)
            => sqrtI8(ref src);

        [MethodImpl(Inline)]
        public static T sqrtU8<T>(T src)
            => sqrtU8(ref src);

        [MethodImpl(Inline)]
        public static T sqrtI16<T>(T src)
            => sqrtI16(ref src);

        [MethodImpl(Inline)]
        public static T sqrtU16<T>(T src)
            => sqrtU16(ref src);

        [MethodImpl(Inline)]
        public static T sqrtI32<T>(T src)
            => sqrtI32(ref src);
        
        [MethodImpl(Inline)]
        public static T sqrtU32<T>(T src)
            => sqrtU32(ref src);

        [MethodImpl(Inline)]
        public static T sqrtI64<T>(T src)
            => sqrtI64(ref src);

        [MethodImpl(Inline)]
        public static T sqrtU64<T>(T src)
            => sqrtU64(ref src);

        [MethodImpl(Inline)]
        public static T sqrtF32<T>(T src)
            => sqrtU32(ref src);

        [MethodImpl(Inline)]
        public static T sqrtF64<T>(T src)
            => sqrtI64(ref src);


    }

}
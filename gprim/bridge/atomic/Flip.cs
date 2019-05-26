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
        
    using static zfunc;    
    using static As;

    partial class bridge
    {
        [MethodImpl(Inline)]
        public static T flipI8<T>(T src)
            => generic<T>(math.flip(ref int8(ref src)));            
            

        [MethodImpl(Inline)]
        public static T flipU8<T>(T src)
        {
            math.flip(ref uint8(ref src));            
            return src;
        }

        [MethodImpl(Inline)]
        public static T flipI16<T>(T src)
        {
            math.flip(ref int16(ref src));            
            return src;
        }

        [MethodImpl(Inline)]
        public static T flipU16<T>(T src)
        {
            math.flip(ref uint16(ref src));            
            return src;
        }

        [MethodImpl(Inline)]
        public static T flipI32<T>(T src)
        {
            math.flip(ref int32(ref src));            
            return src;
        }
        
        [MethodImpl(Inline)]
        public static T flipU32<T>(T src)
        {
            math.flip(ref uint32(ref src));            
            return src;
        }

        [MethodImpl(Inline)]
        public static T flipI64<T>(T src)
        {
            math.flip(ref int64(ref src));            
            return src;
        }

        [MethodImpl(Inline)]
        public static T flipU64<T>(T src)
        {
            math.flip(ref uint64(ref src));            
            return src;
        }

        [MethodImpl(Inline)]
        public static ref T flipI8<T>(ref T src)
        {
            math.flip(ref int8(ref src));            
            return ref src;
        }            

        [MethodImpl(Inline)]
        public static ref T flipU8<T>(ref T src)
        {
            math.flip(ref uint8(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T flipI16<T>(ref T src)
        {
            math.flip(ref int16(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T flipU16<T>(ref T src)
        {
            math.flip(ref uint16(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T flipI32<T>(ref T src)
        {
            math.flip(ref int32(ref src));            
            return ref src;
        }
        
        [MethodImpl(Inline)]
        public static ref T flipU32<T>(ref T src)
        {
            math.flip(ref uint32(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T flipI64<T>(ref T src)
        {
            math.flip(ref int64(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref T flipU64<T>(ref T src)
        {
            math.flip(ref uint64(ref src));            
            return ref src;
        }



    }

}
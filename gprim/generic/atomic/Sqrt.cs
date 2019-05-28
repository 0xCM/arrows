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

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T sqrt<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return sqrtI8(src);
            else if(typeof(T) == typeof(byte))
                return sqrtU8(src);
            else if(typeof(T) == typeof(short))
                return sqrtI16(src);
            else if(typeof(T) == typeof(ushort))
                return sqrtU16(src);
            else if(typeof(T) == typeof(int))
                return sqrtI32(src);
            else if(typeof(T) == typeof(uint))
                return sqrtU32(src);
            else if(typeof(T) == typeof(long))
                return sqrtI64(src);
            else if(typeof(T) == typeof(ulong))
                return sqrtU64(src);
            else if(typeof(T) == typeof(float))
                return sqrtF32(src);
            else if(typeof(T) == typeof(double))
                return sqrtF64(src);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        [MethodImpl(Inline)]
        public static ref T sqrt<T>(ref T src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return ref sqrtI32(ref src);

            if(kind == PrimalKind.uint32)
                return ref src;

            if(kind == PrimalKind.int64)
                return ref sqrtI64(ref src);

            if(kind == PrimalKind.uint64)
                return ref src;

            if(kind == PrimalKind.int16)
                return ref sqrtI16(ref src);

            if(kind == PrimalKind.uint16)
                return ref src;

            if(kind == PrimalKind.int8)
                return ref sqrtI8(ref src);

            if(kind == PrimalKind.uint8)
                return ref src;

            if(kind == PrimalKind.float32)
                return ref sqrtF32(ref src);

            if(kind == PrimalKind.float64)
                return ref sqrtF64(ref src);

            throw unsupported(kind);
        }           



        [MethodImpl(Inline)]
        static T sqrtI8<T>(T src)
            => sqrtI8(ref src);

        [MethodImpl(Inline)]
        static T sqrtU8<T>(T src)
            => sqrtU8(ref src);

        [MethodImpl(Inline)]
        static T sqrtI16<T>(T src)
            => sqrtI16(ref src);

        [MethodImpl(Inline)]
        static T sqrtU16<T>(T src)
            => sqrtU16(ref src);

        [MethodImpl(Inline)]
        static T sqrtI32<T>(T src)
            => sqrtI32(ref src);
        
        [MethodImpl(Inline)]
        static T sqrtU32<T>(T src)
            => sqrtU32(ref src);

        [MethodImpl(Inline)]
        static T sqrtI64<T>(T src)
            => sqrtI64(ref src);

        [MethodImpl(Inline)]
        static T sqrtU64<T>(T src)
            => sqrtU64(ref src);

        [MethodImpl(Inline)]
        static T sqrtF32<T>(T src)
            => sqrtU32(ref src);

        [MethodImpl(Inline)]
        static T sqrtF64<T>(T src)
            => sqrtI64(ref src);


        [MethodImpl(Inline)]
        static ref T sqrtI8<T>(ref T src)
        {
            math.sqrt(ref int8(ref src));            
            return ref src;
        }            

        [MethodImpl(Inline)]
        static ref T sqrtU8<T>(ref T src)
        {
            math.sqrt(ref uint8(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T sqrtI16<T>(ref T src)
        {
            math.sqrt(ref int16(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T sqrtU16<T>(ref T src)
        {
            math.sqrt(ref uint16(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T sqrtI32<T>(ref T src)
        {
            math.sqrt(ref int32(ref src));            
            return ref src;
        }
        
        [MethodImpl(Inline)]
        static ref T sqrtU32<T>(ref T src)
        {
            math.sqrt(ref uint32(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T sqrtI64<T>(ref T src)
        {
            math.sqrt(ref int64(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T sqrtU64<T>(ref T src)
        {
            math.sqrt(ref uint64(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T sqrtF32<T>(ref T src)
        {
            math.sqrt(ref float32(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T sqrtF64<T>(ref T src)
        {
            math.sqrt(ref float64(ref src));            
            return ref src;
        }
    }
}
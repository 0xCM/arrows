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
        public static bool nonzero<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return nonzeroI8(src);
            else if(typeof(T) == typeof(byte))
                return nonzeroU8(src);
            else if(typeof(T) == typeof(short))
                return nonzeroI16(src);
            else if(typeof(T) == typeof(ushort))
                return nonzeroU16(src);
            else if(typeof(T) == typeof(int))
                return nonzeroI32(src);
            else if(typeof(T) == typeof(uint))
                return nonzeroU32(src);
            else if(typeof(T) == typeof(long))
                return nonzeroI64(src);
            else if(typeof(T) == typeof(ulong))
                return nonzeroU64(src);
            else if(typeof(T) == typeof(float))
                return nonzeroF32(src);
            else if(typeof(T) == typeof(double))
                return nonzeroF64(src);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }


        [MethodImpl(Inline)]
        static bool nonzeroI8<T>(T src)
            => math.nonzero(int8(ref src));

        [MethodImpl(Inline)]
        static bool nonzeroU8<T>(T src)
            => math.nonzero(uint8(ref src));

        [MethodImpl(Inline)]
        static bool nonzeroI16<T>(T src)
            => math.nonzero(int16(ref src));

        [MethodImpl(Inline)]
        static bool nonzeroU16<T>(T src)
            => math.nonzero(uint16(ref src));

        [MethodImpl(Inline)]
        static bool nonzeroI32<T>(T src)
            => math.nonzero(int32(ref src));
        
        [MethodImpl(Inline)]
        static bool nonzeroU32<T>(T src)
            => math.nonzero(uint32(ref src));

        [MethodImpl(Inline)]
        static bool nonzeroI64<T>(T src)
            => math.nonzero(int64(ref src));

        [MethodImpl(Inline)]
        static bool nonzeroU64<T>(T src)
            => math.nonzero(uint64(ref src));

        [MethodImpl(Inline)]
        static bool nonzeroF32<T>(T src)
            => math.nonzero(float32(ref src));

        [MethodImpl(Inline)]
        static bool nonzeroF64<T>(T src)
            => math.nonzero(float64(ref src));


    }

}
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
        public static T pow<T>(T src, uint exp)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return powI8(src, exp);
            else if(typeof(T) == typeof(byte))
                return powU8(src, exp);
            else if(typeof(T) == typeof(short))
                return powI16(src, exp);
            else if(typeof(T) == typeof(ushort))
                return powU16(src, exp);
            else if(typeof(T) == typeof(int))
                return powI32(src, exp);
            else if(typeof(T) == typeof(uint))
                return powU32(src, exp);
            else if(typeof(T) == typeof(long))
                return powI64(src, exp);
            else if(typeof(T) == typeof(ulong))
                return powU64(src, exp);
            else if(typeof(T) == typeof(float))
                return powF32(src, exp);
            else if(typeof(T) == typeof(double))
                return powF64(src, exp);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        [MethodImpl(Inline)]
        public static T pow<T>(T src, T exp)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return powF32(src,exp);

            if(kind == PrimalKind.float64)
                return powF64(src,exp);

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        static T powU8<T>(T src, uint exp)
            => generic<T>(math.pow(int8(src), exp));

        [MethodImpl(Inline)]
        static T powI8<T>(T src, uint exp)
            => generic<T>(math.pow(uint8(src), exp));

        [MethodImpl(Inline)]
        static T powI16<T>(T src, uint exp)
            => generic<T>(math.pow(int16(src), exp));

        [MethodImpl(Inline)]
        static T powU16<T>(T src, uint exp)
            => generic<T>(math.pow(uint16(src), exp));

        [MethodImpl(Inline)]
        static T powI32<T>(T src, uint exp)
            => generic<T>(math.pow(int32(src), exp));
        
        [MethodImpl(Inline)]
        static T powU32<T>(T src, uint exp)
            => generic<T>(math.pow(uint32(src), exp));

        [MethodImpl(Inline)]
        static T powI64<T>(T src, uint exp)
            => generic<T>(math.pow(int64(src), exp));

        [MethodImpl(Inline)]
        static T powU64<T>(T src, uint exp)
            => generic<T>(math.pow(uint64(src), exp));

        [MethodImpl(Inline)]
        static T powF32<T>(T src, uint exp)
            => generic<T>(math.pow(float32(src), exp));

        [MethodImpl(Inline)]
        static T powF64<T>(T src, uint exp)
            => generic<T>(math.pow(float64(src), exp));

        [MethodImpl(Inline)]
        static T powF32<T>(T src, T exp)
            => generic<T>(math.pow(float32(src), float32(exp)));

        [MethodImpl(Inline)]
        static T powF64<T>(T src, T exp)
            => generic<T>(math.pow(float64(src), float64(exp)));


    }

}
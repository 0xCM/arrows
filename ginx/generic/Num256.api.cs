//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    
    using static zfunc;    

    public static class Num256
    {
        public static Num256<T> define<T>(T value)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            
            if (kind == PrimalKind.int8)
                return  scalar<T>(As.int8(value));

            if(kind == PrimalKind.uint8)
                return  scalar<T>(As.uint8(value));

            if(kind == PrimalKind.int16)
                return  scalar<T>(As.int16(value));

            if(kind == PrimalKind.uint16)
                return  scalar<T>(As.uint16(value));

            if(kind == PrimalKind.int32)
                return  scalar<T>(As.int32(value));

            if(kind == PrimalKind.uint32)
                return  scalar<T>(As.uint32(value));

            if(kind == PrimalKind.int64)
                return  scalar<T>(As.int64(value));

            if(kind == PrimalKind.uint64)
                return  scalar<T>(As.uint64(value));

            if(kind == PrimalKind.float32)
                return  scalar<T>(As.float32(value));

            if(kind == PrimalKind.float64)
                return  scalar<T>(As.float64(value));

            throw new NotSupportedException($"Kind {kind} not supported");
        }

 
         [MethodImpl(Inline)]
        static unsafe Num256<T> scalar<T>(byte src)
            where T : struct
        {
            var dst = stackalloc byte[16];            
            dst[0] = src;
            return Unsafe.AsRef<Num256<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num256<T> scalar<T>(sbyte src)
            where T : struct
        {
            var dst = stackalloc sbyte[16];            
            dst[0] = src;
            return Unsafe.AsRef<Num256<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num256<T> scalar<T>(short src)
            where T : struct
        {
            var dst = stackalloc short[8];            
            dst[0] = src;
            return Unsafe.AsRef<Num256<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num256<T> scalar<T>(ushort src)
            where T : struct
        {
            var dst = stackalloc ushort[8];            
            dst[0] = src;
            return Unsafe.AsRef<Num256<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num256<T> scalar<T>(int src)
            where T : struct
        {
            var dst = stackalloc int[4];            
            dst[0] = src;
            return Unsafe.AsRef<Num256<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num256<T> scalar<T>(uint src)
            where T : struct
        {
            var dst = stackalloc uint[4];            
            dst[0] = src;
            return Unsafe.AsRef<Num256<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num256<T> scalar<T>(long src)
            where T : struct
        {
            var dst = stackalloc long[2];            
            dst[0] = src;
            return Unsafe.AsRef<Num256<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num256<T> scalar<T>(ulong src)
            where T : struct
        {
            var dst = stackalloc ulong[2];            
            dst[0] = src;
            return Unsafe.AsRef<Num256<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num256<T> scalar<T>(float src)
            where T : struct
        {
            var dst = stackalloc float[4];            
            dst[0] = src;
            return Unsafe.AsRef<Num256<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num256<T> scalar<T>(double src)
            where T : struct
        {
            var dst = stackalloc double[2];            
            dst[0] = src;
            return Unsafe.AsRef<Num256<T>>(dst);
        }

    }

}
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
        public static T zero<T>()
            where T : struct
                => convert(0, out T x);

        [MethodImpl(Inline)]
        public static T one<T>()
            where T : struct
                => convert(1, out T x);

        [MethodImpl(Inline)]
        public static T minval<T>()
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return generic<T>(int.MinValue);

            if(kind == PrimalKind.uint32)
                return generic<T>(uint.MinValue);

            if(kind == PrimalKind.int64)
                return generic<T>(long.MinValue);

            if(kind == PrimalKind.uint64)
                return generic<T>(ulong.MinValue);

            if(kind == PrimalKind.int16)
                return generic<T>(short.MinValue);

            if(kind == PrimalKind.uint16)
                return generic<T>(ushort.MinValue);

            if(kind == PrimalKind.int8)
                return generic<T>(sbyte.MinValue);

            if(kind == PrimalKind.uint8)
                return generic<T>(byte.MinValue);
            
            if(kind == PrimalKind.float32)
                return generic<T>(float.MinValue);

            if(kind == PrimalKind.float64)
                return generic<T>(double.MinValue);

            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static T maxval<T>()
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return generic<T>(int.MaxValue);

            if(kind == PrimalKind.uint32)
                return generic<T>(uint.MaxValue);

            if(kind == PrimalKind.int64)
                return generic<T>(long.MaxValue);

            if(kind == PrimalKind.uint64)
                return generic<T>(ulong.MaxValue);

            if(kind == PrimalKind.int16)
                return generic<T>(short.MaxValue);

            if(kind == PrimalKind.uint16)
                return generic<T>(ushort.MaxValue);

            if(kind == PrimalKind.int8)
                return generic<T>(sbyte.MaxValue);

            if(kind == PrimalKind.uint8)
                return generic<T>(byte.MaxValue);
            
            if(kind == PrimalKind.float32)
                return generic<T>(float.MaxValue);

            if(kind == PrimalKind.float64)
                return generic<T>(double.MaxValue);

            throw unsupported(kind);
        }



    }

}
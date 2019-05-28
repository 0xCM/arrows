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
        public static T parse<T>(string src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return parseI8<T>(src);
            else if(typeof(T) == typeof(byte))
                return parseU8<T>(src);
            else if(typeof(T) == typeof(short))
                return parseI16<T>(src);
            else if(typeof(T) == typeof(ushort))
                return parseU16<T>(src);
            else if(typeof(T) == typeof(int))
                return parseI32<T>(src);
            else if(typeof(T) == typeof(uint))
                return parseU32<T>(src);
            else if(typeof(T) == typeof(long))
                return parseI64<T>(src);
            else if(typeof(T) == typeof(ulong))
                return parseU64<T>(src);
            else if(typeof(T) == typeof(float))
                return parseF32<T>(src);
            else if(typeof(T) == typeof(double))
                return parseF64<T>(src);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        static T parseI8<T>(string src)
            => generic<T>(math.parse(src, out sbyte x));
            
        [MethodImpl(Inline)]
        static T parseU8<T>(string src)
            => generic<T>(math.parse(src, out byte x));

        [MethodImpl(Inline)]
        static T parseI16<T>(string src)
            => generic<T>(math.parse(src, out short x));

        [MethodImpl(Inline)]
        static T parseU16<T>(string src)
            => generic<T>(math.parse(src, out ushort x));

        [MethodImpl(Inline)]
        static T parseI32<T>(string src)
            => generic<T>(math.parse(src, out int x));
        
        [MethodImpl(Inline)]
        static T parseU32<T>(string src)
            => generic<T>(math.parse(src, out uint x));

        [MethodImpl(Inline)]
        static T parseI64<T>(string src)
            => generic<T>(math.parse(src, out long x));

        [MethodImpl(Inline)]
        static T parseU64<T>(string src)
            => generic<T>(math.parse(src, out ulong x));

        [MethodImpl(Inline)]
        static T parseF32<T>(string src)
            => generic<T>(math.parse(src, out float x));

        [MethodImpl(Inline)]
        static T parseF64<T>(string src)
            => generic<T>(math.parse(src, out double x));

        [MethodImpl(Inline)]
        static T parseF128<T>(string src)
            => generic<T>(math.parse(src, out decimal x));
    }

}
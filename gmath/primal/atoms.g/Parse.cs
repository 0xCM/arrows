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

    partial class atoms
    {

        [MethodImpl(Inline)]
        public static T parseI8<T>(string src)
            => generic<T>(math.parse(src, out sbyte x));
            
        [MethodImpl(Inline)]
        public static T parseU8<T>(string src)
            => generic<T>(math.parse(src, out byte x));

        [MethodImpl(Inline)]
        public static T parseI16<T>(string src)
            => generic<T>(math.parse(src, out short x));

        [MethodImpl(Inline)]
        public static T parseU16<T>(string src)
            => generic<T>(math.parse(src, out ushort x));

        [MethodImpl(Inline)]
        public static T parseI32<T>(string src)
            => generic<T>(math.parse(src, out int x));
        
        [MethodImpl(Inline)]
        public static T parseU32<T>(string src)
            => generic<T>(math.parse(src, out uint x));

        [MethodImpl(Inline)]
        public static T parseI64<T>(string src)
            => generic<T>(math.parse(src, out long x));

        [MethodImpl(Inline)]
        public static T parseU64<T>(string src)
            => generic<T>(math.parse(src, out ulong x));

        [MethodImpl(Inline)]
        public static T parseF32<T>(string src)
            => generic<T>(math.parse(src, out float x));

        [MethodImpl(Inline)]
        public static T parseF64<T>(string src)
            => generic<T>(math.parse(src, out double x));

        [MethodImpl(Inline)]
        public static T parseF128<T>(string src)
            => generic<T>(math.parse(src, out decimal x));
    }

}
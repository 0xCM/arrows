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
        public static bool nonzeroI8<T>(T src)
            => math.nonzero(int8(ref src));

        [MethodImpl(Inline)]
        public static bool nonzeroU8<T>(T src)
            => math.nonzero(uint8(ref src));

        [MethodImpl(Inline)]
        public static bool nonzeroI16<T>(T src)
            => math.nonzero(int16(ref src));

        [MethodImpl(Inline)]
        public static bool nonzeroU16<T>(T src)
            => math.nonzero(uint16(ref src));

        [MethodImpl(Inline)]
        public static bool nonzeroI32<T>(T src)
            => math.nonzero(int32(ref src));
        
        [MethodImpl(Inline)]
        public static bool nonzeroU32<T>(T src)
            => math.nonzero(uint32(ref src));

        [MethodImpl(Inline)]
        public static bool nonzeroI64<T>(T src)
            => math.nonzero(int64(ref src));

        [MethodImpl(Inline)]
        public static bool nonzeroU64<T>(T src)
            => math.nonzero(uint64(ref src));

        [MethodImpl(Inline)]
        public static bool nonzeroF32<T>(T src)
            => math.nonzero(float32(ref src));

        [MethodImpl(Inline)]
        public static bool nonzeroF64<T>(T src)
            => math.nonzero(float64(ref src));


    }

}
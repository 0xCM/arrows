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
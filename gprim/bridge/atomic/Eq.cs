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
        static bool eqI8<T>(T lhs, T rhs)
            => int8(lhs) == int8(rhs);

        [MethodImpl(Inline)]
        static bool eqU8<T>(T lhs, T rhs)
            => uint8(lhs) == uint8(rhs);

        [MethodImpl(Inline)]
        static bool eqI16<T>(T lhs, T rhs)
            => int16(lhs) == int16(rhs);

        [MethodImpl(Inline)]
        static bool eqU16<T>(T lhs, T rhs)
            => uint16(lhs) == uint16(rhs);

        [MethodImpl(Inline)]
        static bool eqI32<T>(T lhs, T rhs)
            => int32(lhs) == int32(rhs);
        
        [MethodImpl(Inline)]
        static bool eqU32<T>(T lhs, T rhs)
            => uint32(lhs) == uint32(rhs);

        [MethodImpl(Inline)]
        static bool eqI64<T>(T lhs, T rhs)
            => int64(lhs) == int64(rhs);

        [MethodImpl(Inline)]
        static bool eqU64<T>(T lhs, T rhs)
            => uint64(lhs) == uint64(rhs);

        [MethodImpl(Inline)]
        static bool eqF32<T>(T lhs, T rhs)
        {
            var x = float32(lhs);
            var y = float32(rhs);
            if(x.IsNaN() && y.IsNaN())
                return true;
            else if(x.IsPosInf() && y.IsPosInf())
                return true;
            else if(x.IsNegInf() && y.IsNegInf())
                return true;
            else return x == y;
        }
            
        [MethodImpl(Inline)]
        static bool eqF64<T>(T lhs, T rhs)
        {
            var x = float64(lhs);
            var y = float64(rhs);
            if(x.IsNaN() && y.IsNaN())
                return true;
            else if(x.IsPosInf() && y.IsPosInf())
                return true;
            else if(x.IsNegInf() && y.IsNegInf())
                return true;
            else return x == y;
        }
    }
}
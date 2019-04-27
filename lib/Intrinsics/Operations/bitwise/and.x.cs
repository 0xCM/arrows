//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zcore;
    using static inxfunc;
    using static vec128;


    partial class InXX
    {
        [MethodImpl(Inline)]
        public static Index<T> AndG<T>(this Index<T> lhs, Index<T> rhs)
            where T : struct, IEquatable<T>
                => InXFusionOps.add<T>()(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static unsafe Index<sbyte> InXAnd(this Index<sbyte> lhs, Index<sbyte> rhs)
            => InX.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe Index<byte> InXAnd(this Index<byte> lhs, Index<byte> rhs)
            => InX.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe Index<short> InXAnd(this Index<short> lhs, Index<short> rhs)
            => InX.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe Index<ushort> InXAnd(this Index<ushort> lhs, Index<ushort> rhs)
            => InX.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe Index<int> InXAnd(this Index<int> lhs, Index<int> rhs)
            => InX.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe Index<uint> InXAnd(this Index<uint> lhs, Index<uint> rhs)
            => InX.and(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static unsafe Index<long> InXAnd(this Index<long> lhs, Index<long> rhs)
            => InX.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe Index<ulong> InXAnd(this Index<ulong> lhs, Index<ulong> rhs)
            => InX.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe Index<float> InXAnd(this Index<float> lhs, Index<float> rhs)
            => InX.and(lhs,rhs);
 
        [MethodImpl(Inline)]
        public static unsafe Index<double> InXAnd(this Index<double> lhs, Index<double> rhs)
            => InX.and(lhs,rhs);
    }
}
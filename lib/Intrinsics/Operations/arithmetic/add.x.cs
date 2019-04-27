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
        public static Index<T> AddG<T>(this Index<T> lhs, Index<T> rhs)
            where T : struct, IEquatable<T>
                => InXFusionOps.add<T>()(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static unsafe Index<sbyte> InXAdd(this Index<sbyte> lhs, Index<sbyte> rhs)
            => InX.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe Index<byte> InXAdd(this Index<byte> lhs, Index<byte> rhs)
            => InX.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe Index<short> InXAdd(this Index<short> lhs, Index<short> rhs)
            => InX.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe Index<ushort> InXAdd(this Index<ushort> lhs, Index<ushort> rhs)
            => InX.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe Index<int> InXAdd(this Index<int> lhs, Index<int> rhs)
            => InX.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe Index<uint> InXAdd(this Index<uint> lhs, Index<uint> rhs)
            => InX.add(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static unsafe Index<long> InXAdd(this Index<long> lhs, Index<long> rhs)
            => InX.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe Index<ulong> InXAdd(this Index<ulong> lhs, Index<ulong> rhs)
            => InX.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe Index<float> InXAdd(this Index<float> lhs, Index<float> rhs)
            => InX.add(lhs,rhs);
 
        [MethodImpl(Inline)]
        public static unsafe Index<double> InXAdd(this Index<double> lhs, Index<double> rhs)
            => InX.add(lhs,rhs);
    }
}
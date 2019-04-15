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
    using static x86;

   partial class InXX
    {
        [MethodImpl(Inline)]
        public static Vector128<byte> Add(this Vector128<byte> lhs, Vector128<byte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<sbyte> Add(this Vector128<sbyte> lhs, Vector128<sbyte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<short> Add(this Vector128<short> lhs, Vector128<short> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<ushort> Add(this Vector128<ushort> lhs, Vector128<ushort> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<int> Add(this Vector128<int> lhs, Vector128<int> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<uint> Add(this Vector128<uint> lhs, Vector128<uint> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<long> Add(this Vector128<long> lhs, Vector128<long> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<ulong> Add(this Vector128<ulong> lhs, Vector128<ulong> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<double> Add(this Vector128<double> lhs, Vector128<double> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<float> Add(this Vector128<float> lhs, Vec128<float> rhs)
            => Avx2.Add(lhs, rhs); 
    } 


}
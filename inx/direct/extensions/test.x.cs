//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using Avx = System.Runtime.Intrinsics.X86.Avx;   
    using static zfunc;    

    partial class dinxx
    {
        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec128<short> lhs, in Vec128<short> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec128<int> lhs, in Vec128<int> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec128<long> lhs, in Vec128<long> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec128<float> lhs, in Vec128<float> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec128<double> lhs, in Vec128<double> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec256<short> lhs, in Vec256<short> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec256<int> lhs, in Vec256<int> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec256<long> lhs, in Vec256<long> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec256<float> lhs, in Vec256<float> rhs)
            => Avx.TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool TestZ(this in Vec256<double> lhs, in Vec256<double> rhs)
            => Avx.TestZ(lhs,rhs);        

    }

}
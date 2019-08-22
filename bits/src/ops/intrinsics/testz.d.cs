//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using Avx = System.Runtime.Intrinsics.X86.Avx;   
    using static zfunc;    

    partial class Bits
    {
        [MethodImpl(Inline)]
        public static bool testz(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec128<short> lhs, in Vec128<short> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec128<int> lhs, in Vec128<int> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec128<long> lhs, in Vec128<long> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec128<float> lhs, in Vec128<float> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec128<double> lhs, in Vec128<double> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec256<short> lhs, in Vec256<short> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec256<int> lhs, in Vec256<int> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec256<long> lhs, in Vec256<long> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec256<float> lhs, in Vec256<float> rhs)
            => TestZ(lhs,rhs);        

        [MethodImpl(Inline)]
        public static bool testz(in Vec256<double> lhs, in Vec256<double> rhs)
            => TestZ(lhs,rhs);        

    }    

}
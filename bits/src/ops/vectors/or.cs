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
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;    
    using static As;

    partial class Bits
    {
        [MethodImpl(Inline)]
        public static UInt128 or(in UInt128 lhs, in UInt128 rhs)
            => or(lhs.ToVec128(), rhs.ToVec128()).ToUInt128();

        [MethodImpl(Inline)]
        public static ref UInt128 or(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
        {
            dst = or(lhs.ToVec128(), rhs.ToVec128()).ToUInt128();
            return ref dst;            
        }
                
        [MethodImpl(Inline)]
        public static Vec128<byte> or(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> or(in Vec128<short> lhs, in Vec128<short> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> or(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> or(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> or(in Vec128<int> lhs, in Vec128<int> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> or(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> or(in Vec128<long> lhs, in Vec128<long> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> or(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> or(in Vec128<float> lhs, in Vec128<float> rhs)
            => Or(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> or(in Vec128<double> lhs, in Vec128<double> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> or(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> or(in Vec256<short> lhs, in Vec256<short> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> or(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> or(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> or(in Vec256<int> lhs, in Vec256<int> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> or(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> or(in Vec256<long> lhs, in Vec256<long> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> or(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> or(in Vec256<float> lhs, in Vec256<float> rhs)
            => Or(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec256<double> or(in Vec256<double> lhs, in Vec256<double> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, ref sbyte dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<byte> lhs, in Vec128<byte> rhs, ref byte dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ref ushort dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<long> lhs, in Vec128<long> rhs, ref long dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => vstore(or(lhs, rhs), ref dst);
 
    }

}
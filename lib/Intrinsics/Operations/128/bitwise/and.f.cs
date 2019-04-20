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

    partial class InX
    {
        static readonly SSR.InXAnd andOp = SSR.InXAnd.TheOnly;

        //! and: vec -> vec -> vec
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static Vec128<byte> and(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => andOp.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> and(in Vec128<short> lhs, in Vec128<short> rhs)
            => andOp.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => andOp.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> and(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => andOp.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> and(in Vec128<int> lhs, in Vec128<int> rhs)
            => andOp.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> and(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => andOp.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> and(in Vec128<long> lhs, in Vec128<long> rhs)
            => andOp.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> and(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => andOp.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> and(in Vec128<float> lhs, in Vec128<float> rhs)
            => andOp.and(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> and(in Vec128<double> lhs, in Vec128<double> rhs)
            => andOp.and(lhs,rhs);
 
        //! and: vec -> vec -> out vec
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static void and(in Vec128<byte> lhs, in Vec128<byte> rhs, out Vec128<byte> dst)
            => andOp.and(lhs, rhs, out dst);

        [MethodImpl(Inline)]
        public static void and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, out Vec128<sbyte> dst)
            => andOp.and(lhs, rhs, out dst);

        [MethodImpl(Inline)]
        public static void and(in Vec128<short> lhs, in Vec128<short> rhs, out Vec128<short> dst)
            => andOp.and(lhs, rhs, out dst);

        [MethodImpl(Inline)]
        public static void and(in Vec128<ushort> lhs, in Vec128<ushort> rhs, out Vec128<ushort> dst)
            => andOp.and(lhs, rhs, out dst);

        [MethodImpl(Inline)]
        public static void and(in Vec128<int> lhs, in Vec128<int> rhs, out Vec128<int> dst)
            => andOp.and(lhs, rhs, out dst);

        [MethodImpl(Inline)]
        public static void and(in Vec128<uint> lhs, in Vec128<uint> rhs, out Vec128<uint> dst)
            => andOp.and(lhs, rhs, out dst);

        [MethodImpl(Inline)]
        public static void and(in Vec128<long> lhs, in Vec128<long> rhs, out Vec128<long> dst)
            => andOp.and(lhs, rhs, out dst);

        [MethodImpl(Inline)]
        public static void and(in Vec128<ulong> lhs, in Vec128<ulong> rhs, out Vec128<ulong> dst)
            => andOp.and(lhs, rhs, out dst);

        [MethodImpl(Inline)]
        public static void and(in Vec128<float> lhs, in Vec128<float> rhs, out Vec128<float> dst)
            => andOp.and(lhs, rhs, out dst);

        [MethodImpl(Inline)]
        public static void and(in Vec128<double> lhs, in Vec128<double> rhs, out Vec128<double> dst)
            => andOp.and(lhs, rhs, out dst);
 
        //! add: vec -> vec -> array -> offset -> void
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<byte> lhs, in Vec128<byte> rhs, byte[] dst, int offset = 0)
            => andOp.and(in lhs, in rhs, dst, offset);

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, sbyte[] dst, int offset = 0)
            => andOp.and(in lhs, in rhs, dst, offset);

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<short> lhs, in Vec128<short> rhs, short[] dst, int offset = 0)
            => andOp.and(in lhs, in rhs, dst, offset);

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ushort[] dst, int offset = 0)
            => andOp.and(in lhs, in rhs, dst, offset);

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<int> lhs, in Vec128<int> rhs, int[] dst, int offset = 0)
            => andOp.and(in lhs, in rhs, dst, offset);

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<uint> lhs, in Vec128<uint> rhs, uint[] dst, int offset = 0)
            => andOp.and(in lhs, in rhs, dst, offset);
                
        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<long> lhs, in Vec128<long> rhs, long[] dst, int offset = 0)
            => andOp.and(in lhs, in rhs, dst, offset);

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ulong[] dst, int offset = 0)
            => andOp.and(in lhs, in rhs, dst, offset);

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<float> lhs, in Vec128<float> rhs, float[] dst, int offset = 0)
            => andOp.and(in lhs, in rhs, dst, offset);

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<double> lhs, in Vec128<double> rhs, double[] dst, int offset = 0)
            => andOp.and(in lhs, in rhs, dst, offset);

        //! add: vec -> vec -> dst* -> void
        //! -------------------------------------------------------------------
        
        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<byte> lhs, in Vec128<byte> rhs, byte* dst)
            => andOp.and(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, sbyte* dst)
            => andOp.and(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<short> lhs, in Vec128<short> rhs, short* dst)
            => andOp.and(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ushort* dst)
            => andOp.and(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<int> lhs, in Vec128<int> rhs, int* dst)
            => andOp.and(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<uint> lhs, in Vec128<uint> rhs, uint* dst)
            => andOp.and(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<long> lhs, in Vec128<long> rhs, long* dst)
            => andOp.and(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ulong* dst)
            => andOp.and(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<float> lhs, in Vec128<float> rhs, float* dst)
            => andOp.and(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<double> lhs, in Vec128<double> rhs, double* dst)
            => andOp.and(lhs,rhs,dst);  
    }
}
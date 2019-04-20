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
    using static Operative;


    public partial class InX
    {
        static readonly SSR.InXAdd addVecOp = SSR.InXAdd.TheOnly;
        static readonly SSR.InXAddScalar addNumOp = SSR.InXAddScalar.TheOnly;

        //! add: vec -> vec -> vec
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static Num128<float> add(in Num128<float> lhs, in Num128<float> rhs)
            => addNumOp.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Num128<double> add(in Num128<double> lhs, in Num128<double> rhs)
            => addNumOp.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> add(in Vec128<float> lhs, in Num128<float> rhs)
            => Avx2.AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> add(in Vec128<double> lhs, in Num128<double> rhs)
            => Avx2.AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> add(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => addVecOp.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => addVecOp.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> add(in Vec128<short> lhs, in Vec128<short> rhs)
            => addVecOp.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> add(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => addVecOp.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> add(in Vec128<int> lhs, in Vec128<int> rhs)
            => addVecOp.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> add(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => addVecOp.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> add(in Vec128<long> lhs, in Vec128<long> rhs)
            => addVecOp.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> add(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => addVecOp.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> add(in Vec128<float> lhs, in Vec128<float> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> add(in Vec128<double> lhs, in Vec128<double> rhs)
            => addVecOp.add(lhs,rhs);

        //! add: vec -> vec -> out vec
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static void add(in Num128<float> lhs, in Num128<float> rhs, out Num128<float> dst)
            => addNumOp.add(lhs,rhs, out dst);


        [MethodImpl(Inline)]
        public static void add(in Num128<double> lhs, in Num128<double> rhs, out Num128<double> dst)
            => addNumOp.add(lhs,rhs, out dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<byte> lhs, in Vec128<byte> rhs, out Vec128<byte> dst)
            => addVecOp.add(lhs,rhs, out dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, out Vec128<sbyte> dst)
            => addVecOp.add(lhs,rhs, out dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<short> lhs, in Vec128<short> rhs, out Vec128<short> dst)
            => addVecOp.add(lhs,rhs, out dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<ushort> lhs, in Vec128<ushort> rhs, out Vec128<ushort> dst)
            => addVecOp.add(lhs,rhs, out dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<int> lhs, in Vec128<int> rhs, out Vec128<int> dst)
            => addVecOp.add(lhs,rhs, out dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<uint> lhs, in Vec128<uint> rhs, out Vec128<uint> dst)
            => addVecOp.add(lhs,rhs, out dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<long> lhs, in Vec128<long> rhs, out Vec128<long> dst)
            => addVecOp.add(lhs,rhs, out dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<ulong> lhs, in Vec128<ulong> rhs, out Vec128<ulong> dst)
            => addVecOp.add(lhs,rhs, out dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<float> lhs, in Vec128<float> rhs, out Vec128<float> dst)
            => addVecOp.add(lhs,rhs, out dst);  

        [MethodImpl(Inline)]
        public static void add(in Vec128<double> lhs, in Vec128<double> rhs, out Vec128<double> dst)
            => addVecOp.add(lhs,rhs, out dst);


        //! add: vec -> vec -> array -> offset -> void
        //! -------------------------------------------------------------------
        
        [MethodImpl(Inline)]
        public static unsafe void add(in Num128<float> lhs, in Num128<float> rhs,  float[] dst, int offset = 0)
            => addNumOp.add(lhs,rhs,dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void add(in Num128<double> lhs, in Num128<double> rhs, double[] dst, int offset = 0)
            => addNumOp.add(lhs,rhs,dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<byte> lhs, in Vec128<byte> rhs, byte[] dst, int offset = 0)
            => addVecOp.add(lhs,rhs,dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, sbyte[] dst, int offset = 0)
            => addVecOp.add(lhs,rhs,dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<short> lhs, in Vec128<short> rhs, short[] dst, int offset = 0)
            => addVecOp.add(lhs,rhs,dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ushort[] dst, int offset = 0)
            => addVecOp.add(lhs,rhs,dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<int> lhs, in Vec128<int> rhs, int[] dst, int offset = 0)
            => addVecOp.add(lhs,rhs,dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<uint> lhs, in Vec128<uint> rhs, uint[] dst, int offset = 0)
            => addVecOp.add(lhs,rhs,dst,offset);                

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<long> lhs, in Vec128<long> rhs, long[] dst, int offset = 0)
            => addVecOp.add(lhs,rhs,dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ulong[] dst, int offset = 0)
            => addVecOp.add(lhs,rhs,dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<float> lhs, in Vec128<float> rhs, float[] dst, int offset = 0)
            => addVecOp.add(lhs,rhs,dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void add(in Vec128<double> lhs, in Vec128<double> rhs, double[] dst, int offset = 0)
            => addVecOp.add(lhs,rhs,dst,offset);

        //! add: vec -> vec -> dst*
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static unsafe void add(in Num128<float> lhs, in Num128<float> rhs, float* dst)
            => Sse.StoreScalar(dst,Sse.AddScalar(lhs, rhs));


        [MethodImpl(Inline)]
        public static unsafe void add(in Num128<double> lhs, in Num128<double> rhs, double* dst)
            => addNumOp.add(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<byte> lhs, in Vec128<byte> rhs, byte* dst)
            => addVecOp.add(in lhs, in rhs, dst);

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, sbyte* dst)
            => addVecOp.add(in lhs, in rhs, dst);

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<short> lhs, in Vec128<short> rhs, short* dst)
            => addVecOp.add(in lhs, in rhs, dst);

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ushort* dst)
            => addVecOp.add(in lhs, in rhs, dst);

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<int> lhs, in Vec128<int> rhs, int* dst)
            => addVecOp.add(in lhs, in rhs, dst);

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<uint> lhs, in Vec128<uint> rhs, uint* dst)
            => addVecOp.add(in lhs, in rhs, dst);

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<long> lhs, in Vec128<long> rhs, long* dst)
            => addVecOp.add(in lhs, in rhs, dst);

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ulong* dst)
            => addVecOp.add(in lhs, in rhs, dst);

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<float> lhs, in Vec128<float> rhs, float* dst)
            => Sse.Store(dst, Sse.Add(lhs, rhs));

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<double> lhs, in Vec128<double> rhs, double* dst)
            => addVecOp.add(in lhs, in rhs, dst);
    }

}
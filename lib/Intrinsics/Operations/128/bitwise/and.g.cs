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

    partial class InXG
    {
        /// <summary>
        /// Obtains the and[T] operator bundle
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXAnd<T> and<T>()
            where T : struct, IEquatable<T>
                => SSR.InXAndG<T>.Operator;

        /// <summary>
        /// Applies the generic and operator to supplied operands
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> and<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXAndG<T>.TheOnly.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static void and<T>(in Vec128<T> lhs, in Vec128<T> rhs, out Vec128<T> dst)
            where T : struct, IEquatable<T>
                => SSR.InXAndG<T>.TheOnly.and(lhs,rhs, out dst);

        [MethodImpl(Inline)]
        public static void and<T>(in Vec128<T> lhs, in Vec128<T> rhs, T[] dst, int offset = 0)
            where T : struct, IEquatable<T>
                => SSR.InXAndG<T>.TheOnly.and(lhs, rhs, dst, offset);


    }

    partial class SSR
    {
        public readonly struct InXAndG<T> : InXAnd<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXAnd<T> Operator = cast<InXAnd<T>>(InXAnd.TheOnly);
            
            public static readonly InXAndG<T> TheOnly = default;


            [MethodImpl(Inline)]
            public Vec128<T> and(in Vec128<T> lhs, in Vec128<T> rhs)
                => Operator.and(lhs,rhs);

            [MethodImpl(Inline)]
            public void and(in Vec128<T> lhs, in Vec128<T> rhs, out Vec128<T> dst)
                => Operator.and(lhs,rhs, out dst);

            [MethodImpl(Inline)]
            public void and(in Vec128<T> lhs, in Vec128<T> rhs, T[] dst, int offset = 0)
                => Operator.and(lhs,rhs, dst,offset);

        }

        public readonly struct InXAnd :
            InXAnd<byte>,
            InXAnd<sbyte>,
            InXAnd<short>,
            InXAnd<ushort>,
            InXAnd<int>,
            InXAnd<uint>,
            InXAnd<long>,
            InXAnd<ulong>,
            InXAnd<float>,
            InXAnd<double>
        {

            public static readonly InXAnd TheOnly = default;

            [MethodImpl(Inline)]
            public Vec128<byte> and(in Vec128<byte> lhs, in Vec128<byte> rhs)
                => Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<short> and(in Vec128<short> lhs, in Vec128<short> rhs)
                => Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<sbyte> and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
                => Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<ushort> and(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
                => Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<int> and(in Vec128<int> lhs, in Vec128<int> rhs)
                => Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<uint> and(in Vec128<uint> lhs, in Vec128<uint> rhs)
                => Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<long> and(in Vec128<long> lhs, in Vec128<long> rhs)
                => Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<ulong> and(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
                => Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<float> and(in Vec128<float> lhs, in Vec128<float> rhs)
                => Avx2.And(lhs, rhs);
            
            [MethodImpl(Inline)]
            public Vec128<double> and(in Vec128<double> lhs, in Vec128<double> rhs)
                => Avx2.And(lhs, rhs);   
        
            //! and: vec -> vec -> out vec
            //! -------------------------------------------------------------------

            [MethodImpl(Inline)]
            public void and(in Vec128<byte> lhs, in Vec128<byte> rhs, out Vec128<byte> dst)
                => dst = Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public void and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, out Vec128<sbyte> dst)
                => dst = Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public void and(in Vec128<short> lhs, in Vec128<short> rhs, out Vec128<short> dst)
                => dst = Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public void and(in Vec128<ushort> lhs, in Vec128<ushort> rhs, out Vec128<ushort> dst)
                => dst = Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public void and(in Vec128<int> lhs, in Vec128<int> rhs, out Vec128<int> dst)
                => dst = Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public void and(in Vec128<uint> lhs, in Vec128<uint> rhs, out Vec128<uint> dst)
                => dst = Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public void and(in Vec128<long> lhs, in Vec128<long> rhs, out Vec128<long> dst)
                => dst = Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public void and(in Vec128<ulong> lhs, in Vec128<ulong> rhs, out Vec128<ulong> dst)
                => dst = Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public void and(in Vec128<float> lhs, in Vec128<float> rhs, out Vec128<float> dst)
                => dst = Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public void and(in Vec128<double> lhs, in Vec128<double> rhs, out Vec128<double> dst)
                => dst = Avx2.And(lhs, rhs);
    

            //! add: vec -> vec -> array -> offset -> void
            //! -------------------------------------------------------------------

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<byte> lhs, in Vec128<byte> rhs, byte[] dst, int offset = 0)
            {
                fixed(byte* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.And(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, sbyte[] dst, int offset = 0)
            {
                fixed(sbyte* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.And(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<short> lhs, in Vec128<short> rhs, short[] dst, int offset = 0)
            {
                fixed(short* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.And(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ushort[] dst, int offset = 0)
            {
                fixed(ushort* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.And(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<int> lhs, in Vec128<int> rhs, int[] dst, int offset = 0)
            {
                fixed(int* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.And(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<uint> lhs, in Vec128<uint> rhs, uint[] dst, int offset = 0)
            {
                fixed(uint* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.And(lhs, rhs));
            }
                 

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<long> lhs, in Vec128<long> rhs, long[] dst, int offset = 0)
            {
                fixed(long* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.And(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ulong[] dst, int offset = 0)
            {
                fixed(ulong* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.And(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<float> lhs, in Vec128<float> rhs, float[] dst, int offset = 0)
            {
                fixed(float* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.And(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<double> lhs, in Vec128<double> rhs, double[] dst, int offset = 0)
            {
                fixed(double* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.And(lhs, rhs));
            }

    
            //! and: vec -> vec -> dst*
            //! -------------------------------------------------------------------
            
            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<byte> lhs, in Vec128<byte> rhs, byte* dst)
                => Avx2.Store(dst, Avx2.And(lhs,rhs));

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, sbyte* dst)
                => Avx2.Store(dst, Avx2.And(lhs, rhs));

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<short> lhs, in Vec128<short> rhs, short* dst)
                => Avx2.Store(dst, Avx2.And(lhs, rhs));

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ushort* dst)
                => Avx2.Store(dst, Avx2.And(lhs, rhs));

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<int> lhs, in Vec128<int> rhs, int* dst)
                => Avx2.Store(dst, Avx2.And(lhs, rhs));

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<uint> lhs, in Vec128<uint> rhs, uint* dst)
                => Avx2.Store(dst, Avx2.And(lhs, rhs));

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<long> lhs, in Vec128<long> rhs, long* dst)
                => Avx2.Store(dst, Avx2.And(lhs, rhs));

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ulong* dst)
                => Avx2.Store(dst, Avx2.And(lhs, rhs));

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<float> lhs, in Vec128<float> rhs, float* dst)
                => Avx2.Store(dst, Avx2.And(lhs, rhs));

            [MethodImpl(Inline)]
            public unsafe void and(in Vec128<double> lhs, in Vec128<double> rhs, double* dst)
                => Avx2.Store(dst, Avx2.And(lhs, rhs));

        
        
        }
    }
}
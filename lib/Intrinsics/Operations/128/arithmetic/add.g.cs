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
        /// Obtains the add[T] operator bundle where
        /// T: sbyte | byte | short | ushort | int | uint | long | ulong | single | double
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXAdd<T> add<T>()
            where T : struct, IEquatable<T>
                => SSR.InXAddG<T>.Operator;

        [MethodImpl(Inline)]
        public static InXAddScalar<T> addscalar<T>()
            where T : struct, IEquatable<T>
                => SSR.InXAddScalarG<T>.Operator;

        [MethodImpl(Inline)]
        public static Vec128<T> add<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXAddG<T>.TheOnly.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static void add<T>(in Vec128<T> lhs, in Vec128<T> rhs, out Vec128<T> dst)
            where T : struct, IEquatable<T>
                => SSR.InXAddG<T>.TheOnly.add(lhs,rhs, out dst);

        [MethodImpl(Inline)]
        public static void add<T>(in Vec128<T> lhs, in Vec128<T> rhs, T[] dst, int offset = 0)
            where T : struct, IEquatable<T>
                => SSR.InXAddG<T>.TheOnly.add(lhs,rhs, dst, offset);

        [MethodImpl(Inline)]
        public static Num128<T> add<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXAddScalarG<T>.TheOnly.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static void add<T>(in Num128<T> lhs, in Num128<T> rhs, out Num128<T> dst)
            where T : struct, IEquatable<T>
                => SSR.InXAddScalarG<T>.TheOnly.add(lhs,rhs, out dst);

    }

    partial class SSR
    {
        public readonly struct InXAddScalarG<T> : InXAddScalar<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXAddScalar<T> Operator = cast<InXAddScalar<T>>(InXAddScalar.TheOnly);
            
            public static readonly InXAddScalarG<T> TheOnly = default;

            [MethodImpl(Inline)]
            public Num128<T> add(in Num128<T> lhs, in Num128<T> rhs)
                => Operator.add(lhs,rhs);

            [MethodImpl(Inline)]
            public void add(in Num128<T> lhs, in Num128<T> rhs, out Num128<T> dst)
                => Operator.add(lhs,rhs, out dst);

            [MethodImpl(Inline)]
            public void add(in Num128<T> lhs, in Num128<T> rhs, T[] dst, int offset = 0)
                => Operator.add(lhs,rhs,dst,offset);
        }

        /// <summary>
        /// The generic add operator via singleton reification
        /// </summary>
        public readonly struct InXAddG<T> : InXAdd<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXAdd<T> Operator = cast<InXAdd<T>>(InXAdd.TheOnly);
            
            public static readonly InXAddG<T> TheOnly = default;


            [MethodImpl(Inline)]
            public Vec128<T> add(in Vec128<T> lhs, in Vec128<T> rhs)
                => Operator.add(lhs,rhs);

            [MethodImpl(Inline)]
            public void add(in Vec128<T> lhs, in Vec128<T> rhs, out Vec128<T> dst)
                => Operator.add(lhs,rhs, out dst);

            [MethodImpl(Inline)]
            public void add(in Vec128<T> lhs, in Vec128<T> rhs, T[] dst, int offset = 0)
                => Operator.add(lhs,rhs, dst, offset);
        }

        public readonly struct InXAddScalar :
            InXAddScalar<float>,
            InXAddScalar<double>

        {
            public static readonly InXAddScalar TheOnly = default;

            [MethodImpl(Inline)]
            public Num128<float> add(in Num128<float> lhs, in Num128<float> rhs)
                => Avx2.AddScalar(lhs, rhs);

            [MethodImpl(Inline)]
            public void add(in Num128<float> lhs, in Num128<float> rhs, out Num128<float> dst)
                => dst = Avx2.AddScalar(lhs, rhs);

            [MethodImpl(Inline)]
            public Num128<double> add(in Num128<double> lhs, in Num128<double> rhs)
                => Avx2.AddScalar(lhs, rhs);

            [MethodImpl(Inline)]
            public void add(in Num128<double> lhs, in Num128<double> rhs, out Num128<double> dst)
                => dst = Avx2.AddScalar(lhs, rhs);

            [MethodImpl(Inline)]
            public unsafe void add(in Num128<float> lhs, in Num128<float> rhs, float[] dst, int offset = 0)
            {
                fixed(float* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.AddScalar(lhs, rhs));
            }
            
            [MethodImpl(Inline)]
            public unsafe void add(in Num128<double> lhs, in Num128<double> rhs, double[] dst, int offset = 0)
            {
                fixed(double* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.AddScalar(lhs, rhs));
            } 


            [MethodImpl(Inline)]
            public unsafe void add(in Num128<float> lhs, in Num128<float> rhs, float* dst)
                => Avx2.StoreScalar(dst,Avx2.AddScalar(lhs, rhs));

            [MethodImpl(Inline)]
            public unsafe void add(in Num128<double> lhs, in Num128<double> rhs, double* dst)
                => Avx2.StoreScalar(dst,Avx2.AddScalar(lhs, rhs));

        }


        public readonly struct InXAdd : 
            InXAdd<byte>,
            InXAdd<sbyte>,
            InXAdd<short>,
            InXAdd<ushort>,
            InXAdd<int>,
            InXAdd<uint>,
            InXAdd<long>,
            InXAdd<ulong>,
            InXAdd<float>,
            InXAdd<double>

        {        
            public static readonly InXAdd TheOnly = default;


            //! add: vec -> vec -> vec
            //! -------------------------------------------------------------------
            
            [MethodImpl(Inline)]
            public Vec128<byte> add(in Vec128<byte> lhs, in Vec128<byte> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<sbyte> add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<short> add(in Vec128<short> lhs, in Vec128<short> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<ushort> add(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<int> add(in Vec128<int> lhs, in Vec128<int> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<uint> add(in Vec128<uint> lhs, in Vec128<uint> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<long> add(in Vec128<long> lhs, in Vec128<long> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<ulong> add(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<double> add(in Vec128<double> lhs, in Vec128<double> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<float> add(in Vec128<float> lhs, in Vec128<float> rhs)
                => Avx2.Add(lhs, rhs);
 
            //! add: vec -> vec -> out vec
            //! -------------------------------------------------------------------

            [MethodImpl(Inline)]
            public void add(in Vec128<byte> lhs, in Vec128<byte> rhs, out Vec128<byte> dst)
                => dst = Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public void add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, out Vec128<sbyte> dst)
                => dst = Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public void add(in Vec128<short> lhs, in Vec128<short> rhs, out Vec128<short> dst)
                => dst = Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public void add(in Vec128<ushort> lhs, in Vec128<ushort> rhs, out Vec128<ushort> dst)
                => dst = Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public void add(in Vec128<int> lhs, in Vec128<int> rhs, out Vec128<int> dst)
                => dst = Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public void add(in Vec128<uint> lhs, in Vec128<uint> rhs, out Vec128<uint> dst)
                => dst = Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public void add(in Vec128<long> lhs, in Vec128<long> rhs, out Vec128<long> dst)
                => dst = Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public void add(in Vec128<ulong> lhs, in Vec128<ulong> rhs, out Vec128<ulong> dst)
                => dst = Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public void add(in Vec128<float> lhs, in Vec128<float> rhs, out Vec128<float> dst)
                => dst = Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public void add(in Vec128<double> lhs, in Vec128<double> rhs, out Vec128<double> dst)
                => dst = Avx2.Add(lhs, rhs);

            //! add: vec -> vec -> array -> offset -> void
            //! -------------------------------------------------------------------

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<byte> lhs, in Vec128<byte> rhs, byte[] dst, int offset = 0)
            {
                fixed(byte* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, sbyte[] dst, int offset = 0)
            {
                fixed(sbyte* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<short> lhs, in Vec128<short> rhs, short[] dst, int offset = 0)
            {
                fixed(short* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ushort[] dst, int offset = 0)
            {
                fixed(ushort* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<int> lhs, in Vec128<int> rhs, int[] dst, int offset = 0)
            {
                fixed(int* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<uint> lhs, in Vec128<uint> rhs, uint[] dst, int offset = 0)
            {
                fixed(uint* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }
                 

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<long> lhs, in Vec128<long> rhs, long[] dst, int offset = 0)
            {
                fixed(long* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ulong[] dst, int offset = 0)
            {
                fixed(ulong* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<float> lhs, in Vec128<float> rhs, float[] dst, int offset = 0)
            {
                fixed(float* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<double> lhs, in Vec128<double> rhs, double[] dst, int offset = 0)
            {
                fixed(double* pDst = &dst[offset])
                    Avx.Store(pDst, Avx2.Add(lhs, rhs));
            }

            //! add: vec -> vec -> dst*
            //! -------------------------------------------------------------------

            
            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<byte> lhs, in Vec128<byte> rhs, byte* dst)
                => Avx2.Store(dst, Avx2.Add(lhs,rhs));

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, sbyte* dst)
                => Avx2.Store(dst, Avx2.Add(lhs, rhs));

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<short> lhs, in Vec128<short> rhs, short* dst)
                => Avx2.Store(dst, Avx2.Add(lhs, rhs));

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ushort* dst)
                => Avx2.Store(dst, Avx2.Add(lhs, rhs));

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<int> lhs, in Vec128<int> rhs, int* dst)
                => Avx2.Store(dst, Avx2.Add(lhs, rhs));

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<uint> lhs, in Vec128<uint> rhs, uint* dst)
                => Avx2.Store(dst, Avx2.Add(lhs, rhs));

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<long> lhs, in Vec128<long> rhs, long* dst)
                => Avx2.Store(dst, Avx2.Add(lhs, rhs));

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ulong* dst)
                => Avx2.Store(dst, Avx2.Add(lhs, rhs));

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<float> lhs, in Vec128<float> rhs, float* dst)
                => Avx2.Store(dst, Avx2.Add(lhs, rhs));

            [MethodImpl(Inline)]
            public unsafe void add(in Vec128<double> lhs, in Vec128<double> rhs, double* dst)
                => Avx2.Store(dst, Avx2.Add(lhs, rhs));


        }
    }
}
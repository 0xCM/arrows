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



    }

}

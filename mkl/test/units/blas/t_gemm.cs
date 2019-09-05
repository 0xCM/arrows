//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;
    using static nfunc;
    
    using Z0.Test;

    public class t_gemm : UnitTest<t_gemm>
    {

        public t_gemm()
        {

        }

        
        public void Dot()
        {
            var v1 = Random.NatVec<N256,double>();
            var v2 = Random.NatVec<N256,double>();

            var x = mkl.dot(v1,v2).Round(4);
            var y = Dot(v1,v2).Round(4);
            Claim.eq(x,y);
        }
        
        public void GemmInt16()
        {
            gemm_bench(closed((short)-1024, (short)1024));
        }

        public void GemmUInt16()
        {
            gemm_bench(closed((ushort)0, (ushort)1024));
        }

        
        
        public void gemm32i()
        {
            gemm_bench(closed(-Pow2.T10, Pow2.T10));
        }

        public void gemm32u()
        {
            gemm_bench(closed(0u, 1024u));
        }


        public void gemm64i()
        {
            gemm_bench(closed((long)-Pow2.T21, (long)Pow2.T21));
        }

        public void gemm64u()
        {
            gemm_bench(closed(0ul, (ulong)Pow2.T21));
        }

        public void gemm32f()
        {
            gemm_bench(closed(-1024f, 1024f),5f);
        }


        public void gemm64f()
        {
            gemm_bench(closed(-(double)Pow2.T21, (double)Pow2.T21),2d);
        }

        void gemm32f_direct()
        {
            var src = Random.Stream(closed(-Pow2.T21, Pow2.T21)).Select(x => (float)x);
            var pad = 30;

            Collect(gemm_direct_check<N64,N64,N64>(src), pad);
            Collect(gemm_direct_check<N3, N3, N3>(src), pad);
            Collect(gemm_direct_check<N3, N5, N4>(src), pad);
            Collect(gemm_direct_check<N5, N5, N7>(src), pad);
            Collect(gemm_direct_check<N10,N10,N10>(src), pad);
            Collect(gemm_direct_check<N17,N3,N17>(src), pad);
            Collect(gemm_direct_check<N2, N2, N2>(src), pad);
            Collect(gemm_direct_check<N4, N4, N4>(src), pad);
            Collect(gemm_direct_check<N8, N8, N8>(src), pad);
            Collect(gemm_direct_check<N16,N16,N16>(src), pad);
            Collect(gemm_direct_check<N32,N32,N32>(src), pad);
        }

        void gemm64f_direct()
        {
            var src = Random.Stream(closed(-Pow2.T21, Pow2.T21)).Select(x => (double)x);
            var pad = 30;

            Collect(gemm_direct_check<N64,N64,N64>(src), pad);
            Collect(gemm_direct_check<N3, N3, N3>(src), pad);
            Collect(gemm_direct_check<N3, N5, N4>(src), pad);
            Collect(gemm_direct_check<N5, N5, N7>(src), pad);
            Collect(gemm_direct_check<N10,N10,N10>(src), pad);
            Collect(gemm_direct_check<N17,N3,N17>(src), pad);
            Collect(gemm_direct_check<N2, N2, N2>(src), pad);
            Collect(gemm_direct_check<N4, N4, N4>(src), pad);
            Collect(gemm_direct_check<N8, N8, N8>(src), pad);
            Collect(gemm_direct_check<N16,N16,N16>(src), pad);
            Collect(gemm_direct_check<N32,N32,N32>(src), pad);
        }

        void gemm_bench<T>(Interval<T> domain,  T epsilon = default)
            where T : struct
        {
            
            var src = Random.Stream(domain);
            var pad = 30;

            Collect(gemm_check(src, epsilon, n64,  n64, n64), pad);
            Collect(gemm_check(src,epsilon, n3,  n3, n3), pad);
            Collect(gemm_check(src,epsilon, n3,  n5, n4), pad);
            Collect(gemm_check(src,epsilon, n5,  n5, n7), pad);
            Collect(gemm_check(src,epsilon, n10, n10, n10), pad);
            Collect(gemm_check(src,epsilon, n17, n3, n17), pad);
            Collect(gemm_check(src,epsilon, n2,  n2, n2), pad);
            Collect(gemm_check(src,epsilon, n4,  n4, n4), pad);
            Collect(gemm_check(src,epsilon, n8,  n8, n8), pad);
            Collect(gemm_check(src,epsilon, n16, n16, n16), pad);
            Collect(gemm_check(src,epsilon, n32, n32, n32), pad);
        }

        

        OpTime gemm_check<M,K,N,T>(IEnumerable<T> src, T epsilon = default, M m = default, K k = default, N n = default, bool trace = false)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct

        {
            var A = Matrix.Alloc<M,K,T>();
            var B = Matrix.Alloc<K,N,T>();
            var X = Matrix.Alloc<M,N,T>();
            var E = Matrix.Alloc<M,N,T>();
        
            var runtime = Duration.Zero;
            for(var i=0; i<CycleCount; i++)
            {
                src.StreamTo(A.Unblocked);
                src.StreamTo(B.Unblocked);
                var sw = stopwatch();
                mkl.gemm(A, B, ref X);            
                runtime += snapshot(sw);
                
                MatMulRef.Mul(A, B, ref E);

                if(trace)       
                {
                    var padlen = Int32.MinValue.ToString().Length + 2;
                    Trace($"X = {X.Format()}");
                    Trace($"E = {E.Format()}");
                }
            
                E.Unblocked.ClaimEqual(X.Unblocked,epsilon);

            }

            var label = $"gemm<N{nati<M>()},N{nati<K>()},N{nati<N>()},{typeof(T).Name}>";
            return optime(CycleCount, runtime, label);

        }

        OpTime gemm_direct_check<M,K,N>(IEnumerable<float> src, M m = default, K k = default, N n = default)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()

        {
            var A = Matrix.Alloc<M,K,float>();
            var B = Matrix.Alloc<K,N,float>();
            var X = Matrix.Alloc<M,N,float>();
            var E = Matrix.Alloc<M,N,float>();
        
            var runtime = Duration.Zero;
            for(var i=0; i<CycleCount; i++)
            {
                src.StreamTo(A.Unblocked);
                src.StreamTo(B.Unblocked);
                var sw = stopwatch();
                mkl.gemm(A,B,ref X);            
                runtime += snapshot(sw);
                
                // Mul(A, B, ref E);
                // E.Unblocked.ClaimEqual(X.Unblocked,10);

            }

            var label = $"gemm<{nati<M>()},{nati<K>()},{nati<N>()}>";
            return optime(CycleCount, runtime, label);

        }


        OpTime gemm_direct_check<M,K,N>(IEnumerable<double> src, M m = default, K k = default, N n = default)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()

        {
            var A = Matrix.Alloc<M,K,double>();
            var B = Matrix.Alloc<K,N,double>();
            var X = Matrix.Alloc<M,N,double>();
            var E = Matrix.Alloc<M,N,double>();
        
            var runtime = Duration.Zero;
            for(var i=0; i<CycleCount; i++)
            {
                src.StreamTo(A.Unblocked);
                src.StreamTo(B.Unblocked);
                var sw = stopwatch();
                mkl.gemm(A,B,ref X);            
                runtime += snapshot(sw);
                
                Mul(A, B, ref E);
                Claim.yea(E == X);

            }

            var label = $"gemm<{nati<M>()},{nati<K>()},{nati<N>()}>";
            return optime(CycleCount, runtime, label);

        }


        OpTime Gemv64<M,N>(IEnumerable<double> src, int cycles, M m = default, N n = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var A = Matrix.Alloc<M,N,double>();
            var x = Vector.Alloc<N,double>();
            var y = Vector.Alloc<M,double>();
            var z = Vector.Alloc<M,double>();
            var sw = stopwatch(false);


            for(var i=0; i<cycles; i++)
            {
                src.StreamTo(A.Unsized);
                src.StreamTo(x.Unsized);
                src.StreamTo(y.Unsized);
                
                sw.Start();
                mkl.gemv(A,x, ref y);                
                sw.Stop();
                MatrixRefOps.Mul(A,x,z);
                Claim.yea(z == y);
            }

            var label = $"gemv<{nati<M>()},{nati<N>()},{PrimalKinds.kind<double>()}>";
            return optime(cycles, sw, label);
        }

        static double Dot<N>(Vector<N,double> x, Vector<N,double> y)
            where N : ITypeNat, new()
        {
            var result = 0d;
            for(var i=0; i< nati<N>(); i++)
            {
                result += x[i]*y[i];
            }
            return result;
        }

        static float Dot<N>(Vector<N,float> x, Vector<N,float> y)
            where N : ITypeNat, new()
        {
            var result = 0f;
            for(var i=0; i< nati<N>(); i++)
            {
                result += x[i]*y[i];
            }
            return result;
        }

        static float Dot(Span<float> x, Span<float> y)
        {
            var result = 0f;
            for(var i=0; i< length(x,y); i++)
            {
                result += x[i]*y[i];
            }
            return result;
        }

        static double Dot(Span<double> x, Span<double> y)
        {
            var result = 0d;
            for(var i=0; i< length(x,y); i++)
            {
                result += x[i]*y[i];
            }
            return result;
        }

        static ref Matrix<M,N,float> Mul<M,K,N>(Matrix<M,K,float> A, Matrix<K,N,float> B, ref Matrix<M,N,float> X)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var m = nati<M>();
            var n = nati<N>();
            for(var i=0; i< m; i++)
            {
                var row = A.GetRow(i);                
                for(var j=0; j< n; j++)
                {
                    var col = B.GetCol(j);
                    X[i,j] = Dot(row,col);
                }
            }
            return ref X;

        }

        static ref Matrix<M,N,double> Mul<M,K,N>(Matrix<M,K,double> A, Matrix<K,N,double> B, ref Matrix<M,N,double> X)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var m = nati<M>();
            var n = nati<N>();
            for(var i=0; i< m; i++)
            {
                var row = A.GetRow(i);                
                for(var j=0; j< n; j++)
                {
                    var col = B.GetCol(j);
                    X[i,j] = Dot(row,col);
                }
            }
            return ref X;

        }

        void GemmInt32Format()
        {
            var domain = closed(-32768, 32768);
            var n = n5;
            var m = n5;
            var m1 = Random.Matrix(domain, m, n);
            var m2 = Random.Matrix(domain, m, n);
            var m3 = Matrix.Alloc(m,n,0);
            var m4 = mkl.gemm(m1,m2,ref m3);
        }

    }
}
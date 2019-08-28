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
    using static Nats;

    public class tgemm : UnitTest<tgemm>
    {

        public tgemm()
        {

        }

        const int MMCycles = Pow2.T07;
        
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
            Gemm(closed((short)-1024, (short)1024));
        }

        public void GemmUInt16()
        {
            Gemm(closed((ushort)0, (ushort)1024));
        }

        void GemmInt32Format()
        {
            var domain = closed(-32768, 32768);
            var n = N5;
            var m = N5;
            var m1 = Random.Matrix(domain, m, n);
            var m2 = Random.Matrix(domain, m, n);
            var m3 = Matrix.Alloc(m,n,0);
            var m4 = mkl.gemm(m1,m2,ref m3);
            Trace(m4.Format(10));
        }
        
        
        public void GemmInt32()
        {
            Gemm(closed(-Pow2.T10, Pow2.T10));
        }

        public void GemmUInt32()
        {
            Gemm(closed(0u, 1024u));
        }


        public void GemmInt64()
        {
            Gemm(closed((long)-Pow2.T21, (long)Pow2.T21));
        }

        public void GemmUInt64()
        {
            Gemm(closed(0ul, (ulong)Pow2.T21));
        }

        public void GemmFloat32()
        {
            Gemm(closed(-1024f, 1024f),5f);
        }


        public void GemmFLoat64()
        {
            Gemm(closed(-(double)Pow2.T21, (double)Pow2.T21),2d);
        }

        public void GemmFloat32D()
        {
            var src = Random.Stream(closed(-Pow2.T21, Pow2.T21)).Select(x => (float)x);
            var pad = 30;

            Collect(GemmDirect<N64,N64,N64>(src), pad);
            Collect(GemmDirect<N3, N3, N3>(src), pad);
            Collect(GemmDirect<N3, N5, N4>(src), pad);
            Collect(GemmDirect<N5, N5, N7>(src), pad);
            Collect(GemmDirect<N10,N10,N10>(src), pad);
            Collect(GemmDirect<N17,N3,N17>(src), pad);
            Collect(GemmDirect<N2, N2, N2>(src), pad);
            Collect(GemmDirect<N4, N4, N4>(src), pad);
            Collect(GemmDirect<N8, N8, N8>(src), pad);
            Collect(GemmDirect<N16,N16,N16>(src), pad);
            Collect(GemmDirect<N32,N32,N32>(src), pad);
        }

        public void GemmFloat64D()
        {
            var src = Random.Stream(closed(-Pow2.T21, Pow2.T21)).Select(x => (double)x);
            var pad = 30;

            Collect(GemmDirect<N64,N64,N64>(src), pad);
            Collect(GemmDirect<N3, N3, N3>(src), pad);
            Collect(GemmDirect<N3, N5, N4>(src), pad);
            Collect(GemmDirect<N5, N5, N7>(src), pad);
            Collect(GemmDirect<N10,N10,N10>(src), pad);
            Collect(GemmDirect<N17,N3,N17>(src), pad);
            Collect(GemmDirect<N2, N2, N2>(src), pad);
            Collect(GemmDirect<N4, N4, N4>(src), pad);
            Collect(GemmDirect<N8, N8, N8>(src), pad);
            Collect(GemmDirect<N16,N16,N16>(src), pad);
            Collect(GemmDirect<N32,N32,N32>(src), pad);
        }

        void Gemm<T>(Interval<T> domain,  T epsilon = default)
            where T : struct
        {
            
            var src = Random.Stream(domain);
            var pad = 30;

            Collect(GemmExec(src, epsilon, N64,  N64, N64), pad);
            Collect(GemmExec(src,epsilon, N3,  N3, N3), pad);
            Collect(GemmExec(src,epsilon, N3,  N5, N4), pad);
            Collect(GemmExec(src,epsilon, N5,  N5, N7), pad);
            Collect(GemmExec(src,epsilon, N10, N10, N10), pad);
            Collect(GemmExec(src,epsilon, N17, N3, N17), pad);
            Collect(GemmExec(src,epsilon, N2,  N2, N2), pad);
            Collect(GemmExec(src,epsilon, N4,  N4, N4), pad);
            Collect(GemmExec(src,epsilon, N8,  N8, N8), pad);
            Collect(GemmExec(src,epsilon, N16, N16, N16), pad);
            Collect(GemmExec(src,epsilon, N32, N32, N32), pad);
        }

        

        OpTime GemmExec<M,K,N,T>(IEnumerable<T> src, T epsilon = default, M m = default, K k = default, N n = default, bool trace = false)
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
            for(var i=0; i<MMCycles; i++)
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
            return optime(MMCycles, runtime, label);

        }

        OpTime GemmDirect<M,K,N>(IEnumerable<float> src, M m = default, K k = default, N n = default)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()

        {
            var A = Matrix.Alloc<M,K,float>();
            var B = Matrix.Alloc<K,N,float>();
            var X = Matrix.Alloc<M,N,float>();
            var E = Matrix.Alloc<M,N,float>();
        
            var runtime = Duration.Zero;
            for(var i=0; i<MMCycles; i++)
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
            return optime(MMCycles, runtime, label);

        }


        OpTime GemmDirect<M,K,N>(IEnumerable<double> src, M m = default, K k = default, N n = default)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()

        {
            var A = Matrix.Alloc<M,K,double>();
            var B = Matrix.Alloc<K,N,double>();
            var X = Matrix.Alloc<M,N,double>();
            var E = Matrix.Alloc<M,N,double>();
        
            var runtime = Duration.Zero;
            for(var i=0; i<MMCycles; i++)
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
            return optime(MMCycles, runtime, label);

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

    }
}
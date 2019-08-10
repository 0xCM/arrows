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

    public class GemmTest : UnitTest<GemmTest>
    {
        public void Dot()
        {
            var v1 = Random.NatVector<N256,double>();
            var v2 = Random.NatVector<N256,double>();

            var x = mkl.dot(v1,v2).Round(4);
            var y = Dot(v1,v2).Round(4);
            Claim.eq(x,y);
        }

        public void Gemm32()
        {
            var cycles = Pow2.T03;
            var src = Random.Stream(closed(-Pow2.T10, Pow2.T10)).Select(x => (float)x);                                        

            TracePerf(GemmDrive<N3, N3, N3>(src,cycles));
            TracePerf(GemmDrive<N3, N5, N4>(src,cycles));
            TracePerf(GemmDrive<N5, N5, N7>(src,cycles));
            TracePerf(GemmDrive<N10,N10,N10>(src,cycles));
            TracePerf(GemmDrive<N17,N3,N17>(src,cycles));
            TracePerf(GemmDrive<N4, N4, N4>(src,cycles));
            TracePerf(GemmDrive<N2,N2,N2>(src,cycles));
            TracePerf(GemmDrive<N8,N8,N8>(src,cycles));
            TracePerf(GemmDrive<N16,N16,N16>(src,cycles));
            TracePerf(GemmDrive<N32,N32,N32>(src,cycles));
        }

        public void Gemm64()
        {
            var cycles = Pow2.T03;
            var src = Random.Stream(closed(-Pow2.T21, Pow2.T21)).Select(x => (double)x);

            TracePerf(GemmDrive<N128,N128,N128>(src,cycles));
            TracePerf(GemmDrive<N3, N5, N4>(src,cycles));
            TracePerf(GemmDrive<N5, N5, N7>(src,cycles));
            TracePerf(GemmDrive<N10,N10,N10>(src,cycles));
            TracePerf(GemmDrive<N17,N3,N17>(src,cycles));
            TracePerf(GemmDrive<N16,N16,N16>(src,cycles));
            TracePerf(GemmDrive<N32,N32,N32>(src,cycles));
            TracePerf(GemmDrive<N64,N64,N64>(src,cycles));
            TracePerf(GemmDrive<N4, N4, N4>(src,cycles));
            TracePerf(GemmDrive<N3, N3, N3>(src,cycles));

        }

        OpTime GemmDrive<M,K,N>(IEnumerable<float> src, int cycles, bool trace = false)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()

        {
            var A = Matrix.Load<M,K,float>(Span256.AllocUnaligned<M,K,float>());
            var B = Matrix.Load<K,N,float>(Span256.AllocUnaligned<K,N,float>());
            var X = Matrix.Load<M,N,float>(Span256.AllocUnaligned<M,N,float>());
            var E = Matrix.Load<M,N,float>(Span256.AllocUnaligned<M,N,float>());
        
            var runtime = Duration.Zero;
            for(var i=0; i<cycles; i++)
            {
                src.StreamTo(A.Unblocked);
                src.StreamTo(B.Unblocked);
                var sw = stopwatch();
                mkl.gemm(A, B, ref X);            
                runtime += snapshot(sw);
                
                Mul(A, B, ref E);

                if(trace)       
                {
                    var padlen = Int32.MinValue.ToString().Length + 2;
                    Trace($"X = {X.Format()}");
                    Trace($"E = {E.Format()}");
                }

                Claim.eq(E.Unblocked,X.Unblocked);

            }

            var label = $"gemm<{nati<M>()},{nati<K>()},{nati<N>()}>";
            return optime(cycles, runtime, label);

        }

        OpTime GemmDrive<M,K,N>(IEnumerable<double> src, int cycles, bool trace = false)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()

        {
            var A = Matrix.Alloc<M,K,double>();
            var B = Matrix.Alloc<K,N,double>();
            var X = Matrix.Alloc<M,N,double>();
            var E = Matrix.Alloc<M,N,double>();
        
            var runtime = Duration.Zero;
            for(var i=0; i<cycles; i++)
            {
                src.StreamTo(A.Unblocked);
                src.StreamTo(B.Unblocked);
                var sw = stopwatch();
                mkl.gemm(A,B,ref X);            
                runtime += snapshot(sw);
                
                Mul(A, B, ref E);
                Claim.yea(E == X);

                if(trace)       
                {
                    var padlen = Int32.MinValue.ToString().Length + 2;
                    Trace($"X = {X.Format()}");
                    Trace($"E = {E.Format()}");
                }
            }

            var label = $"gemm<{nati<M>()},{nati<K>()},{nati<N>()}>";
            return optime(cycles, runtime, label);

        }


        OpTime Gemv64<M,N>(IEnumerable<double> src, int cycles, M m = default, N n = default, bool trace = false)
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

        void Gemv64()
        {
            var src = Random.Stream(closed(-Pow2.T07, Pow2.T07)).Select(x => (double)x);
            var cycles = Pow2.T08;
            TracePerf(Gemv64(src, cycles, N4, N5));
            TracePerf(Gemv64(src, cycles, N16, N20));
            TracePerf(Gemv64(src, cycles, N64, N64));
            TracePerf(Gemv64(src, cycles, N9, N9));
            TracePerf(Gemv64(src, cycles, N17, N21));

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
                var row = A.Row(i);                
                for(var j=0; j< n; j++)
                {
                    var col = B.Col(j);
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
                var row = A.Row(i);                
                for(var j=0; j< n; j++)
                {
                    var col = B.Col(j);
                    X[i,j] = Dot(row,col);
                }
            }
            return ref X;

        }

    }
}
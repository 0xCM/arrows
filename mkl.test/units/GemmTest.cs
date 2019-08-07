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
    using static Examples;

    public class GemmTest : UnitTest<GemmTest>
    {

        OpTime GemmDrive<M,K,N>(IEnumerable<float> src, int cycles, bool trace = false)
            where M : ITypeNat, new()
            where K : ITypeNat, new()
            where N : ITypeNat, new()

        {
            var A = Matrix.Load<M,K,float>(Span256.alloc<M,K,float>());
            var B = Matrix.Load<K,N,float>(Span256.alloc<K,N,float>());
            var X = Matrix.Load<M,N,float>(Span256.alloc<M,N,float>());
            var E = Matrix.Load<M,N,float>(Span256.alloc<M,N,float>());
        
            var runtime = Duration.Zero;
            for(var i=0; i<cycles; i++)
            {
                src.StreamTo(A.Unblocked);
                src.StreamTo(B.Unblocked);
                var sw = stopwatch();
                mkl.gemm<M,K,N>(A.Unsized, B.Unsized, X.Unsized);            
                runtime += snapshot(sw);
                
                MatMul.MulSlow(A, B, E);

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
            var A = NatSpan.alloc<M,K,double>();
            var B = NatSpan.alloc<K,N,double>();
            var X = NatSpan.alloc<M,N,double>();
            var E = NatSpan.alloc<M,N,double>();
        
            var runtime = Duration.Zero;
            for(var i=0; i<cycles; i++)
            {
                src.StreamTo(A);
                src.StreamTo(B);
                var sw = stopwatch();
                mkl.gemm(A,B,X);            
                runtime += snapshot(sw);
                
                MatMul.MulSlow(A, B, E);
                Claim.eq(E,X);

                if(trace)       
                {
                    var padlen = Int32.MinValue.ToString().Length + 2;
                    Trace($"X = {X.Format(padlen)}");
                    Trace($"E = {E.Format(padlen)}");

                }
            }

            var label = $"gemm<{nati<M>()},{nati<K>()},{nati<N>()}>";
            return optime(cycles, runtime, label);

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


        public void Dot()
        {
            var lhs = Random.Span<double>(Pow2.T08);
            var rhs = Random.Span<double>(Pow2.T08);

            var x = mkl.dot(lhs,rhs).Round(4);
            var y = lhs.ReadOnly().Dot(rhs).Round(4);
            Claim.eq(x,y);
        }


    }
}
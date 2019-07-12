//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl.Test
{
    using System;
    using System.Linq;

    using static zfunc;
    using static nfunc;
    
    using Z0.Test;
    using static Examples;

    public class GemmTest : UnitTest<GemmTest>
    {
        static void gemm<M,N>()
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var m = nati<M>();
            var n = nati<N>();
            var method = varintro($"{m}x{n} * {n}x{m} = {m}x{m}");
            var count = m*n;
            
            var srcA = span<double>(count);
            for(var i=1; i<= count; i++)
                srcA[i-1] = i;
            var a = NatSpan.load<M,N,double>(ref srcA[0]);

            var srcB = span<double>(m*n);
            for(var i=1; i<= count; i++)
                srcB[i-1] = i;
            var b = NatSpan.load<N,M,double>(ref srcB[0]);

            var timer = input(
                nameof(a), a.Format(zpad: a.EntryPadWidth()), 
                nameof(b), b.Format(zpad: b.EntryPadWidth())
                );            
            var c = mkl.gemm(a,b);            
            var time = snapshot(timer);   
        
            finale(nameof(c), c.Format(zpad: c.EntryPadWidth()), timer, method);
        }
        
        public static void Gemm()
        {
            gemm<N3,N4>();
            gemm<N5,N7>();
            gemm<N10,N10>();
            gemm<N16,N16>();
            gemm<N17,N17>();

        }

        public void Dot()
        {
            var lhs = Random.Span<double>(Pow2.T08);
            var rhs = Random.Span<double>(Pow2.T08);

            var x = mkl.dot(lhs,rhs).Round(4);
            var y = lhs.ReadOnly().Dot(rhs).Round(4);
            Claim.eq(x,y);
        }

        public void VSlInit()
        {
            //IntPtr stream = IntPtr.Zero;
            //VSL.vslNewStream(ref stream, BRNG.VSL_BRNG_MCG59, 28923892).ThrowOnError();            
            using(var stream = mkl.stream(BRNG.VSL_BRNG_NONDETERM, 1))
            {
                //VSL.viRngUniform(0, stream, buffer.Length, ref buffer[0], -200, 200).ThrowOnError();
                var i32 = mkl.uniform(stream, closed(-200, 200), span<int>(10));
                var i32Fmt = i32.Format();
                Trace($"Discrete uniform i32 {appMsg(i32Fmt)}");

                var f32 = mkl.uniform(stream, closed(-250f, 250f), span<float>(10));
                Trace($"Continuous uniform f32 {appMsg(f32.Format())}");

                var f64 = mkl.uniform(stream, closed(-250d, 250d), span<double>(10));
                Trace($"Continuous uniform f64 {appMsg(f64.Format())}");


                var u32 = mkl.ubits(stream, span<uint>(10));
                var u32Fmt = u32.Format();
                Trace(appMsg(u32Fmt));

                var u64 = mkl.ubits(stream, span<ulong>(10));
                var u64Fmt = u64.Format();
                Trace(appMsg(u64Fmt));

                var bernoulli = mkl.bernoulli(stream, .5, span<Bit>(10));
                Trace(appMsg(bernoulli.Format()));

                var geometric = mkl.geometric(stream, .5, span<int>(20));
                Trace(appMsg(geometric.Format()));


            }            
        }

    }


}
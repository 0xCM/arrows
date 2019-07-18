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

    public class VlSInitTest : UnitTest<VlSInitTest>
    {
        public void TestVlsInit()
        {
            var report = sbuild();
            bool silent = true;

            string append(string msg)
            {
                report.AppendLine(msg); 
                if(!silent)
                    Trace(msg);
                return msg;
            };

            //IntPtr stream = IntPtr.Zero;
            //VSL.vslNewStream(ref stream, BRNG.VSL_BRNG_MCG59, 28923892).ThrowOnError();            
            using(var stream = mkl.stream(BRNG.VSL_BRNG_NONDETERM, 1))
            {
                //VSL.viRngUniform(0, stream, buffer.Length, ref buffer[0], -200, 200).ThrowOnError();
                var i32 = mkl.uniform(stream, closed(-200, 200), span<int>(10));
                var i32Fmt = i32.Format();                
                append($"Discrete uniform i32 {appMsg(i32Fmt)}");

                var f32 = mkl.uniform(stream, closed(-250f, 250f), span<float>(10));
                append($"Continuous uniform f32 {appMsg(f32.Format())}");

                var f64 = mkl.uniform(stream, closed(-250d, 250d), span<double>(10));
                append($"Continuous uniform f64 {appMsg(f64.Format())}");

                var u32 = mkl.ubits(stream, span<uint>(10));
                var u32Fmt = u32.Format();
                append(u32Fmt);

                var u64 = mkl.ubits(stream, span<ulong>(10));
                var u64Fmt = u64.Format();
                append(u64Fmt);

                var bernoulli = mkl.bernoulli(stream, .5, span<Bit>(10));
                append($"Bernoulli  {bernoulli.Format()}");

                var geometric = mkl.geometric(stream, .5, span<int>(20));
                append(geometric.Format());
            }                    
        }
    }
}

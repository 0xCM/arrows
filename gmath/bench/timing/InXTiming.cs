//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zcore;



    public static class InXTiming
    {
        const long AnnounceRate = Pow2.T24;

        static string DCycleTitle<T>(int cycle, OpKind kind)
            where T : struct, IEquatable<T>
                => $"dinx/{kind.OpId<T>()} Cycle {cycle}";


        static string GCycleTitle<T>(int cycle, OpKind kind)
            where T : struct, IEquatable<T>
            => $"ginx/{kind.OpId<T>()} Cycle {cycle}";

        static bool tell(long opcount)
            => opcount % AnnounceRate == 0;

        public static TimedPair CompareAdd<T>(int cycles, T[] lhs, T[] rhs)
            where T : struct, IEquatable<T>
        {
            var dTotal = Duration.Zero;
            var gTotal = Duration.Zero;
            var opCount = 0L;
            var len = length(lhs,rhs);
            for(var cycle = 1; cycle <= cycles; cycle++, opCount += 2*len)
            {
                var announce = tell(opCount);                    
                var gTitle = GCycleTitle<T>(cycle,OpKind.Add);
                var dTitle = DCycleTitle<T>(cycle,OpKind.Add);

                GInXTiming.Add(gTitle, ref gTotal, cycle, announce, lhs, rhs);
                DInXTiming.Add(dTitle, ref dTotal, cycle, announce, lhs, rhs);
            }
            return TimedPair.Define(dTotal,gTotal);
        }

        public static TimedPair  CompareAdd<T>(int cycles, Vec128<T>[] lhs, Vec128<T>[] rhs)
            where T : struct, IEquatable<T>
        {
            var dTotal = Duration.Zero;
            var gTotal = Duration.Zero;
            var opCount = 0L;
            var len = length(lhs,rhs);
            for(var cycle = 1; cycle <= cycles; cycle++, opCount += 2*len)
            {
                var announce = tell(opCount);                    
                var gTitle = GCycleTitle<T>(cycle, OpKind.Add);
                var dTitle = DCycleTitle<T>(cycle, OpKind.Add);

                GInXTiming.Add(gTitle, ref gTotal, cycle, announce, lhs, rhs);
                DInXTiming.Add(dTitle, ref dTotal, cycle, announce, lhs, rhs);
            }
            return TimedPair.Define(dTotal,gTotal);

        }


    }

}
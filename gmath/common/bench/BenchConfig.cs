//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static zcore;

    public class BenchConfig
    {
        static readonly PrimalKind[] ActivePrimitives = new PrimalKind[]{
                PrimalKind.int16, PrimalKind.uint16,
                PrimalKind.int32, PrimalKind.uint32,
                PrimalKind.int64, PrimalKind.uint64,
                PrimalKind.float32, PrimalKind.float64,
        };


        public static readonly BenchConfig Default = new BenchConfig(1000, 1000,1000);

        public BenchConfig(int Cycles, int Reps, int SampleSize, int AnnounceRate = Pow2.T24, PrimalKind[] primitives = null)
        {
            this.Cycles = Cycles;
            this.Reps = Reps;
            this.SampleSize = SampleSize;
            this.AnnounceRate = AnnounceRate;
            this.Primitives = primitives != null ? primitives : ActivePrimitives;

        }

        public int Cycles {get;}

        public int Reps {get;}

        public int SampleSize {get;}
        public int AnnounceRate {get;}

        public int OpCount 
            => Cycles * Reps;

        public IReadOnlyList<PrimalKind> Primitives {get;}
 
        public override string ToString() 
            => $"Cycles = {Cycles} | Reps = {Reps} | Total OpCount = {OpCount}";
    }
}
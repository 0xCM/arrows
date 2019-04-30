//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
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

        public static BenchConfig Define(int Cycles, int Reps)
            => new BenchConfig(Cycles,Reps,Reps);


        public static readonly BenchConfig Default = new BenchConfig();

        public BenchConfig(int? Cycles = null, int? Reps = null, int? SampleSize = null, PrimalKind[] primitives = null)
        {
            this.Cycles = Cycles ?? Settings.Cycles();
            this.Reps = Reps ?? Settings.Reps();
            this.SampleSize = SampleSize ?? Settings.SampleSize();
            this.Primitives = primitives != null ? primitives : ActivePrimitives;

        }

        public int Cycles {get;}

        public int Reps {get;}

        public int SampleSize {get;}

        public IReadOnlyList<PrimalKind> Primitives {get;}
 
        public override string ToString() 
            => $"Cycles = {Cycles} | Reps = {Reps} | SampleSize = {SampleSize}";
    }


}
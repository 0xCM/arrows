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


    public class BenchConfig
    {
        public static readonly PrimalKind[] ActivePrimitives = new PrimalKind[]{
                PrimalKind.int8, PrimalKind.uint8,
                PrimalKind.int16, PrimalKind.uint16,
                PrimalKind.int32, PrimalKind.uint32,
                PrimalKind.int64, PrimalKind.uint64,
                PrimalKind.float32, PrimalKind.float64,
        };

        public static readonly OpKind[] ActiveOperators = new OpKind[] {
                OpKind.Add,
                OpKind.Sub,
                OpKind.Mul,
                OpKind.Div,
                OpKind.Mod
        };

        public static readonly BenchConfig Default = new BenchConfig(1000, 1000,1000);

        public BenchConfig(int Cycles, int Reps, int SampleSize, int? AnnounceRate = null, PrimalKind[] primitives = null, OpKind[] operators = null)
        {
            this.Cycles = Cycles;
            this.Reps = Reps;
            this.SampleSize = SampleSize;
            this.AnnounceRate = AnnounceRate ?? Pow2.T24;
            this.Primitives = (primitives != null && primitives.Length != 0) ? primitives : ActivePrimitives;
            this.Operators = (operators  != null && operators.Length != 0) ? operators : ActiveOperators;
        }

        public int Cycles {get;}

        public int Reps {get;}

        public int SampleSize {get;}

        public int AnnounceRate {get;}

        public PrimalKind[] Primitives {get;}

        public OpKind[] Operators {get;}

        public BenchConfig WithPrimitives(params PrimalKind[] primitives)
            => new BenchConfig(Cycles, Reps, SampleSize, AnnounceRate, primitives, Operators);

        public BenchConfig WithCycles(int Cycles)
            => new BenchConfig(Cycles, Reps, SampleSize, AnnounceRate, Primitives, Operators);

        public BenchConfig WithReps(int Reps)
            => new BenchConfig(Cycles, Reps, SampleSize, AnnounceRate, Primitives, Operators);

        public BenchConfig WithSampleSize(int SampleSize)
            => new BenchConfig(Cycles, Reps, SampleSize, AnnounceRate, Primitives, Operators);

        public BenchConfig WithAnnounceRate(int AnnounceRate)
            => new BenchConfig(Cycles, Reps, SampleSize, AnnounceRate, Primitives, Operators);

        public BenchConfig WithOperators(params OpKind[] Operators)
            => new BenchConfig(Cycles, Reps, SampleSize, AnnounceRate, Primitives.ToArray(), Operators);

        public BenchConfig WithActiveOperators()
            => new BenchConfig(Cycles, Reps, SampleSize, AnnounceRate, Primitives.ToArray(), ActiveOperators);


        public override string ToString() 
            => $"Cycles = {Cycles} | Reps = {Reps}";
    }
}
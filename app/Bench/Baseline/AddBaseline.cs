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
        public static readonly BenchConfig Default = new BenchConfig();

        public BenchConfig(int? Cycles = null, int? Reps = null, int? SampleSize = null)
        {
            this.Cycles = Cycles ?? Settings.Cycles();
            this.Reps = Reps ?? Settings.Reps();
            this.SampleSize = SampleSize ?? Settings.SampleSize();
        }

        public int Cycles {get;}

        public int Reps {get;}

        public int SampleSize {get;}
    }

    public interface IBenchRunner        
    {
        long Run<T>()
            where T : struct, IEquatable<T>
;
    }
    
    public class AddBaseline : IBenchRunner
    {
        BenchConfig Config {get;}
        Index<object> OpIndex {get;}

        private AddBaseline(BenchConfig config) 
        {
            this.Config = config;
            this.OpIndex = PrimKinds.index
                (@sbyte: new AddInt8(config),
                @byte: new AddUInt8(config),
                @short: new AddInt16(config),
                @ushort: new AddUInt16(config),
                @int: new AddInt32(config),
                @uint: new AddUInt32(config),
                @long: new AddInt64(config),
                @ulong: new AddUInt64(config),
                @float: new AddFloat32(config),
                @double: new AddFloat64(config)
                );

        }

        public static IBenchRunner Runner(BenchConfig config = null)
            => new AddBaseline(config ?? BenchConfig.Default);

        public long Run<T>()
            where T : struct, IEquatable<T>
        {
            return Run(AddOp<T>(OpIndex), Config);            
        }


        static BaselineOp<T> AddOp<T>(Index<object> opidx)
            where T : struct, IEquatable<T>
            => (BaselineOp<T>)opidx[PrimKinds.index<T>()];


        static long Run<T>(BaselineOp<T> op, BenchConfig config)
            where T : struct, IEquatable<T>
        {            
            var duration = 0L;
            hilite($"Executing {config.Cycles} cycles", SeverityLevel.HiliteCL);
            for(var i = 0; i < config.Cycles; i ++)
            {
                var statsMsg = $"Cycle {i} - | {config.SampleSize} pairs of numbers | {config.Reps} reps";
                hilite($"Beginning {statsMsg}", SeverityLevel.Perform);
                var swCycle = stopwatch();
                duration += op.Run();         
                hilite($"Finished {statsMsg} | {elapsed(swCycle)}ms", SeverityLevel.Perform);                        
            }
            
            hilite($"Executed {config.Cycles} cycles for a total duration of {duration}ms", SeverityLevel.HiliteCL);
            return duration;
        }


        class AddInt8 : BaselineOp<AddInt8,sbyte>
        {
            public AddInt8(BenchConfig config)
                : base(config)           
            {

            }
            protected override long Compute(sbyte[] dst)
            {
                var sw = stopwatch();
                for(var i = 0; i< SampleSize; i++)
                    dst[i] = (sbyte)(LeftSrc[i] + RightSrc[i]);
                return  elapsed(sw);
            }
        }

        class AddUInt8 : BaselineOp<AddUInt8, byte>
        {
            public AddUInt8(BenchConfig config)
                : base(config)           
            {
                
            }

            protected override long Compute(byte[] dst)
            {
                var sw = stopwatch();
                for(var i = 0; i< SampleSize; i++)
                    dst[i] = (byte)(LeftSrc[i] + RightSrc[i]);
                return  elapsed(sw);
            }
        }

        class AddInt16 : BaselineOp<AddInt16, short>
        {
            public AddInt16(BenchConfig config)
                : base(config)           
            {
                
            }

            protected override long Compute(short[] dst)
            {
                var sw = stopwatch();
                for(var i = 0; i< SampleSize; i++)
                    dst[i] = (short)(LeftSrc[i] + RightSrc[i]);
                return  elapsed(sw);
            }
        }


        class AddUInt16 : BaselineOp<AddUInt16, ushort>
        {
            public AddUInt16(BenchConfig config)
                : base(config)           
            {
                
            }

            protected override long Compute(ushort[] dst)
            {
                var sw = stopwatch();
                for(var i = 0; i< SampleSize; i++)
                    dst[i] = (ushort)(LeftSrc[i] + RightSrc[i]);
                return  elapsed(sw);
            }
        }


        class AddInt32 : BaselineOp<AddInt32, int>
        {
            public AddInt32(BenchConfig config)
                : base(config)           
            {
                
            }

            protected override long Compute(int[] dst)
            {
                var sw = stopwatch();
                for(var i = 0; i< SampleSize; i++)
                    dst[i] = LeftSrc[i] + RightSrc[i];
                return  elapsed(sw);
            }
        }

        class AddUInt32 : BaselineOp<AddUInt32, uint>
        {
            public AddUInt32(BenchConfig config)
                : base(config)           
            {
                
            }
            protected override long Compute(uint[] dst)
            {
                var sw = stopwatch();
                for(var i = 0; i< SampleSize; i++)
                    dst[i] = LeftSrc[i] + RightSrc[i];
                return  elapsed(sw);
            }
        }

        class AddInt64 : BaselineOp<AddInt64, long>
        {
            public AddInt64(BenchConfig config)
                : base(config)           
            {
                
            }
            protected override long Compute(long[] dst)
            {
                var sw = stopwatch();
                for(var i = 0; i< SampleSize; i++)
                    dst[i] = LeftSrc[i] + RightSrc[i];
                return  elapsed(sw);
            }
        }

        class AddUInt64 : BaselineOp<AddUInt64, ulong>
        {
            public AddUInt64(BenchConfig config)
                : base(config)           
            {
                
            }

            protected override long Compute(ulong[] dst)
            {
                var sw = stopwatch();
                for(var i = 0; i< SampleSize; i++)
                    dst[i] = LeftSrc[i] + RightSrc[i];
                return  elapsed(sw);
            }
        }

        class AddFloat32 : BaselineOp<AddFloat32,float>
        {
            public AddFloat32(BenchConfig config)
                : base(config)           
            {
                
            }

            protected override long Compute(float[] dst)
            {
                var sw = stopwatch();
                for(var i = 0; i< SampleSize; i++)
                    dst[i] = LeftSrc[i] + RightSrc[i];
                return  elapsed(sw);
            }
        }

        class AddFloat64 : BaselineOp<AddFloat64, double>
        {
            public AddFloat64(BenchConfig config)
                : base(config)           
            {
                
            }

            protected override long Compute(double[] dst)
            {
                var sw = stopwatch();
                for(var i = 0; i< SampleSize; i++)
                    dst[i] = LeftSrc[i] + RightSrc[i];
                return  elapsed(sw);
            }
        }

    }



}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    

    using static zfunc;
    using static mfunc;

    public abstract class Sampler<T>
        where T : Sampler<T>
    {

        protected Sampler(IRandomizer random)
        {
            this.Random = random;
        }

        private sbyte[] i8Samples;
        
        private byte[] u8Samples;
        
        private short[] i16Samples;
        
        private ushort[] u16Samples;

        private int[] i32Samples;

        private uint[] u32Samples;

        private long[] i64Samples;

        private ulong[] u64Samples;

        protected IRandomizer Random {get;}

        protected byte[] UInt8Samples 
        {
            get => u8Samples;
            set => u8Samples = value;
        }

        protected sbyte[] Int8Samples
        {
            get => i8Samples;
            set => i8Samples = value;
        }        

        protected short[] Int16Samples
        {
            get => i16Samples;
            set => i16Samples = value;
        }        

        protected ushort[] UInt16Samples
        {
            get => u16Samples;
            set => u16Samples = value;
        }        

        protected int[] Int32Samples
        {
            get => i32Samples;
            set => i32Samples = value;
        }        


        protected uint[] UInt32Samples
        {
            get => u32Samples;
            set => u32Samples = value;
        }
        
        protected long[] Int64Samples
        {
            get => i64Samples;
            set => i64Samples = value;
        }        

        protected ulong[] UInt64Samples
        {
            get => u64Samples;
            set => u64Samples = value;
        }        

        protected float[] Float32Samples {get; set;}

        protected double[] Float64Samples {get; set;}        
    }
}

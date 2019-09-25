//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public class tv_and : UnitTest<tv_and>
    {
        public void and_128x8i()
            => and_128_check<sbyte>();

        public void and_128x8u()
            => and_128_check<byte>();            

        public void and_128x16i()
            => and_128_check<short>();

        public void and_128x16u()
            => and_128_check<ushort>();

        public void and_128x32i()
            => and_128_check<int>();

        public void and_128x32u()
            => and_128_check<uint>();            

        public void and_128x64i()
            => and_128_check<long>();            

        public void and_128x64u()
            => and_128_check<ulong>();            

        public void and_128x32f()
            => and_128_check<float>();

        public void and_128x64f()
            => and_128_check<double>();

        public void and_256x8i()
            => and_256_check<sbyte>();

        public void and_256x8u()
            => and_256_check<byte>();            

        public void and_256x16i()
            => and_256_check<short>();

        public void and_256x16u()
            => and_256_check<ushort>();

        public void and_256x32i()
            => and_256_check<int>();

        public void and_256x32u()
            => and_256_check<uint>();            

        public void and_256x64i()
            => and_256_check<long>();            

        public void and_256x64u()
            => and_256_check<ulong>();            

        public void and_256x32f()
            => and_256_check<float>();

        public void and_256x64f()
            => and_256_check<double>();

        void and_128_check<T>(int blocks = DefaultSampleSize)
            where T : unmanaged
        {
            CpuOpVerify.VerifyBinOp(Random, blocks, new Vec128BinOp<T>(gbits.vand), gmath.and<T>);
        }

        void and_256_check<T>(int blocks = DefaultSampleSize)
            where T : unmanaged
        {
            CpuOpVerify.VerifyBinOp(Random, blocks, new Vec256BinOp<T>(gbits.vand<T>), gmath.and<T>);
        }
    }

}
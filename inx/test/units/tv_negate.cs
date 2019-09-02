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

    public class tv_negate : UnitTest<tv_negate>
    {
        public void negate128i8()
        {
            negate128_check<sbyte>();
        }

        public void negate128u8()
        {
            negate128_check<byte>();
        }

        public void negate128i16()
        {
            negate128_check<short>();
        }

        public void negate128u16()
        {
            negate128_check<ushort>();
        }

        public void negate128i32()
        {
            negate128_check<int>();
        }

        public void negate128u32()
        {
            negate128_check<uint>();
        }

        public void negate128i64()
        {
            negate128_check<long>();
        }

        public void negate128u64()
        {
            negate128_check<ulong>();
        }

        public void negate128f32()
        {
            negate128_check<float>();
        }

        public void negate128f64()
        {
            negate128_check<double>();
        }

        public void negate256i8()
        {
            negate256_check<sbyte>();
        }

        public void negate256u8()
        {
            negate256_check<byte>();
        }

        public void negate256i16()
        {
            negate256_check<short>();
        }

        public void negate256u16()
        {
            negate256_check<ushort>();
        }

        public void negate256i32()
        {
            negate256_check<int>();
        }

        public void negate256u32()
        {
            negate256_check<uint>();
        }

        public void negate256i64()
        {
            negate256_check<long>();
        }

        public void negate256u64()
        {
            negate256_check<ulong>();
        }

        public void negate256f32()
        {
            negate256_check<float>();
        }

        public void negate256f64()
        {
            negate256_check<double>();
        }


        void negate128_check<T>(int blocks = DefaultSampleSize)
            where T : struct
        {
            CpuOpVerify.VerifyUnaryOp(Polyrand, blocks, new Vec128UnaryOp<T>(ginx.negate), gmath.negate<T>);
        }

        void negate256_check<T>(int blocks = DefaultSampleSize)
            where T : struct
        {
            CpuOpVerify.VerifyUnaryOp(Polyrand, blocks, new Vec256UnaryOp<T>(ginx.negate), gmath.negate<T>);
        }


    }

}
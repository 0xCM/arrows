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

        public void and128i8()
        {
            and128<sbyte>();
        }

        public void and128u8()
        {
            and128<byte>();            
        }

        public void and128i16()
        {
            and128<short>();
        }

        public void and128u16()
        {
            and128<ushort>();
        }

        public void and128i32()
        {
            and128<int>();
        }

        public void and128u32()
        {
            and128<uint>();
            
        }

        public void and128i64()
        {
            and128<long>();            
        }

        public void and128u64()
        {
            and128<ulong>();
            
        }

        public void and128f32()
        {
            and128<float>();
        }

        public void and128f64()
        {
            and128<double>();
        }


        public void and256i8()
        {
            and256<sbyte>();
        }

        public void and256u8()
        {
            and256<byte>();            
        }

        public void and256i16()
        {
            and256<short>();
        }

        public void and256u16()
        {
            and256<ushort>();
        }

        public void and256i32()
        {
            and256<int>();
        }

        public void and256u32()
        {
            and256<uint>();
            
        }

        public void and256i64()
        {
            and256<long>();            
        }

        public void and256u64()
        {
            and256<ulong>();
            
        }

        public void and256f32()
        {
            and256<float>();
        }

        public void and256f64()
        {
            and256<double>();
        }



        void and128<T>(int blocks = DefaultSampleSize)
            where T : struct
        {
            CpuOpVerify.VerifyBinOp(Polyrand, blocks, new Vec128BinOp<T>(gbits.and), gmath.and<T>);
        }

        void and256<T>(int blocks = DefaultSampleSize)
            where T : struct
        {
            CpuOpVerify.VerifyBinOp(Polyrand, blocks, new Vec256BinOp<T>(gbits.and), gmath.and<T>);
        }
    }

}
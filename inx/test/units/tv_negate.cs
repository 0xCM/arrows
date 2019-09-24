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
        public void negate128_i8()
        {
            negate128_check<sbyte>();
        }

        public void negate128_u8()
        {
            negate128_check<byte>();
        }

        public void negate128_i16()
        {
            negate128_check<short>();
        }

        public void negate128_u16()
        {
            negate128_check<ushort>();
        }

        public void negate128_i32()
        {
            negate128_check<int>();
        }

        public void negate128_u32()
        {
            negate128_check<uint>();
        }

        public void negate128_i64()
        {
            negate128_check<long>();
        }

        public void negate128_u64()
        {
            negate128_check<ulong>();
        }

        public void negate128_f32()
        {
            negate128_check<float>();
        }

        public void negate128_f64()
        {
            negate128_check<double>();
        }

        public void negate256i8()
        {
            negate256_check<sbyte>();
        }

        public void negate256_u8()
        {
            negate256_check<byte>();
        }

        public void negate256_i16()
        {
            negate256_check<short>();
        }

        public void negate256_u16()
        {
            negate256_check<ushort>();
        }

        public void negate256_i32()
        {
            negate256_check<int>();
        }

        public void negate256_u32()
        {
            negate256_check<uint>();
        }

        public void negate256_i64()
        {
            negate256_check<long>();
        }

        public void negate256_u64()
        {
            negate256_check<ulong>();
        }

        public void negate256_f32()
        {
            negate256_check<float>();
        }

        public void negate256_f64()
        {
            negate256_check<double>();
        }


        void negate128_check<T>()
            where T : unmanaged
        {
        }

        void negate256_check<T>()
            where T : unmanaged
        {

        }

    }

}
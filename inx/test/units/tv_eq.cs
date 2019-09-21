//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    
    public class tv_eq : UnitTest<tv_eq>
    {        

        public void eq128_i8()
        {
            
            eq128_check<sbyte>();
        }

        public void eq128_u8()
        {
            
            eq128_check<byte>();
        }

        public void eq128_i16()
        {
            
            eq128_check<short>();
        }

        public void eq128_u16()
        {
            
            eq128_check<ushort>();
        }

        public void eq128_i32()
        {
            
            eq128_check<int>();
        }

        public void eq128_u32()
        {
            
            eq128_check<uint>();
        }

        public void eq128_i64()
        {
            
            eq128_check<long>();
        }

        public void eq128_u64()
        {
            
            eq128_check<ulong>();
        }

        public void eq128_f32()
        {
            
            eq128_check<float>();
        }

        public void eq128_f64()
        {
            
            eq128_check<double>();
        }

        public void eq256_i8()
        {
            
            eq256_check<sbyte>();
        }

        public void eq256_u8()
        {
            
            eq256_check<byte>();
        }


        public void eq256_i16()
        {
            
            eq256_check<short>();
        }

        public void eq256_u16()
        {
            
            eq256_check<ushort>();
        }

        public void eq256_i32()
        {
            
            eq256_check<int>();
        }

        public void eq256_u32()
        {
            
            eq256_check<uint>();
        }

        public void eq256_i64()
        {
            
            eq256_check<long>();
        }

        public void eq256_u64()
        {
            
            eq256_check<ulong>();
        }

        public void eq256_f32()
        {
            
            eq256_check<float>();
        }

        public void eq256_f64()
        {
            
            eq256_check<double>();
        }

        void eq128_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var v1 = Random.CpuVec128<T>();
                var v2 = Random.CpuVec128<T>();
                var eq = ginx.eq(in v1, in v2);
                Claim.nea(ginx.eq(in v1, in v2));
                Claim.yea(ginx.eq(in v1, in v1));
                Claim.yea(ginx.eq(in v2, in v2));    
            }

        }

        void eq256_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var v1 = Random.CpuVec256<T>();
                var v2 = Random.CpuVec256<T>();
                var eq = ginx.eq(in v1, in v2);
                Claim.nea(ginx.eq(in v1, in v2));
                Claim.yea(ginx.eq(in v1, in v1));
                Claim.yea(ginx.eq(in v2, in v2));    
            }

        }

    }

}
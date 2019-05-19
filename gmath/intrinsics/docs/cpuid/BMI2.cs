//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BitSpecs
{
    using System;
    
    public static partial class BMI2
    {
        /*
            tmp := a
            dst := 0
            m := 0
            k := 0
            DO WHILE m < 64
                IF mask[m] == 1
                    dst[m] := tmp[k]
                    k := k + 1
                FI
                m := m + 1        
         */
        public static __uint64 _pdep_u64(__uint64 a, __uint64 mask)
        {
            var tmp = a;
            var dst = default(__uint64);
            var m = 0;
            var k = 0;

            while(m < 64)
            {
                if(mask[m])
                {
                    dst[m] = tmp[k];
                    k = k + 1;
                }
                m = m + 1;
            }
            return dst;
        }

        public static __uint32 _pdep_u32(__uint32 a, __uint32 mask)
        {
            var tmp = a;
            var dst = default(__uint32);
            var m = 0;
            var k = 0;

            while(m < 32)
            {
                if(mask[m])
                {
                    dst[m] = tmp[k];
                    k = k + 1;
                }
                m = m + 1;
            }
            return dst;
        }

        /*
            tmp := a
            dst := 0
            m := 0
            k := 0
            DO WHILE m < 64
                IF mask[m] == 1
                    dst[k] := tmp[m]
                    k := k + 1
                FI
                m := m + 1
            OD        
         */
        public static __uint64 _pext_u64(__uint64 a, __uint64 mask)
        {
            var tmp = a;
            __uint64 dst = 0;
            var m = 0;
            var k = 0;

            while(m < 64)
            {
                if(mask[m] == 1)                    
                {
                    dst[k] = tmp[m];
                    k = k + 1;
                }
                m = m + 1;
            }
            return dst;

        }

        /*
            tmp := a
            dst := 0
            m := 0
            k := 0
            DO WHILE m < 64
                IF mask[m] == 1
                    dst[k] := tmp[m]
                    k := k + 1
                FI
                m := m + 1
            OD        
         */
        public static __uint32 _pext_u32(__uint32 a, __uint32 mask)
        {
            var tmp = a;
            __uint32 dst = 0;
            var m = 0;
            var k = 0;

            while(m < 32)
            {
                if(mask[m] == 1)                    
                {
                    dst[k] = tmp[m];
                    k = k + 1;
                }
                m = m + 1;
            }
            return dst;

        }


    }
}
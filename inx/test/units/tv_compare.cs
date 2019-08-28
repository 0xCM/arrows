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

    public class tv_compare : UnitTest<tv_compare>
    {
        public void gt128()
        {
            gt128<sbyte>();
            gt128<short>();
            gt128<int>();
            gt128<float>();
            gt128<double>();

        }

        public void gt256()
        {
            gt256<sbyte>();
            gt256<short>();
            gt256<int>();
            gt256<float>();
            gt256<double>();

        }

        public void eq128()
        {
            var blocks = Pow2.T08;

            eq128<byte>(blocks);
            eq128<sbyte>(blocks);
            eq128<short>(blocks);
            eq128<ushort>(blocks);
            eq128<int>(blocks);
            eq128<uint>(blocks);
            eq128<long>(blocks);
            eq128<ulong>(blocks);
            eq128<float>(blocks);
            eq128<double>(blocks);

        }

        public void eq256()
        {
            var blocks = Pow2.T08;
            eq256<byte>(blocks);
            eq256<sbyte>(blocks);
            eq256<short>(blocks);
            eq256<ushort>(blocks);
            eq256<int>(blocks);
            eq256<uint>(blocks);
            eq256<long>(blocks);
            eq256<ulong>(blocks);
        }

        Duration eq128<T>(int blocks)
            where T : struct
        {
            TypeCaseStart<T>();
            var src = Random.Span128<T>(blocks); 
            var sw = stopwatch();
            for(var block = 0; block< src.BlockCount; block++)
                Claim.yea(ginx.eq(src.LoadVec128(block) , src.LoadVec128(block)));
            TypeCaseEnd<T>();
            return snapshot(sw);
        }
        
        Duration eq256<T>(int blocks)
            where T : struct
        {
            TypeCaseStart<T>();
            var src = Random.Span256<T>(blocks); 
            var sw = stopwatch();
            for(var block = 0; block< src.BlockCount; block++)
                Claim.yea(ginx.eq(src.LoadVec256(block) , src.LoadVec256(block)));
            TypeCaseEnd<T>();
            return snapshot(sw);
        }

        void gt128<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            var v1 = Random.CpuVec128<T>();                
            var v2 = v1.Inc();
            var cmp =  ginx.gt(v2,v1);// v2.Gt(v1);
            Claim.yea(cmp);                    
            TypeCaseEnd<T>();
        }

        void gt256<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            var v1 = Random.CpuVec256<T>();                
            var v2 = v1.Inc();
            var cmp = ginx.gt(v2,v1);// v2.Gt(v1);
            Claim.yea(cmp);                    
            TypeCaseEnd<T>();
        }

    }

}
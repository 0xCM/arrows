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

    public class InXCompareTest : UnitTest<InXCompareTest>
    {
        Duration Eq128<T>(int blocks)
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
        
        Duration Eq256<T>(int blocks)
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

        public void Gt128<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            var v1 = Random.Vec128<T>();                
            var v2 = v1.Inc();
            var cmp = v2.Gt(v1);
            Claim.yea(cmp);                    
            TypeCaseEnd<T>();
        }

        public void Gt256<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            var v1 = Random.Vec256<T>();                
            var v2 = v1.Inc();
            var cmp = v2.Gt(v1);
            Claim.yea(cmp);                    
            TypeCaseEnd<T>();
        }

        public void Gt()
        {
            Gt128<sbyte>();
            Gt128<short>();
            Gt128<int>();
            Gt128<float>();
            Gt128<double>();

            Gt256<sbyte>();
            Gt256<short>();
            Gt256<int>();
            Gt256<float>();
            Gt256<double>();

        }

        public void Eq()
        {
            var blocks = Pow2.T08;
            Eq128<byte>(blocks);
            Eq128<sbyte>(blocks);
            Eq128<short>(blocks);
            Eq128<ushort>(blocks);
            Eq128<int>(blocks);
            Eq128<uint>(blocks);
            Eq128<long>(blocks);
            Eq128<ulong>(blocks);
            Eq128<float>(blocks);
            Eq128<double>(blocks);
            Eq256<byte>(blocks);
            Eq256<sbyte>(blocks);
            Eq256<short>(blocks);
            Eq256<ushort>(blocks);
            Eq256<int>(blocks);
            Eq256<uint>(blocks);
            Eq256<long>(blocks);
            Eq256<ulong>(blocks);
        }
    }

}
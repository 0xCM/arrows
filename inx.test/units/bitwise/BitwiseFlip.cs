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

    public class BitwiseFlip : UnitTest<BitwiseFlip>
    {
        void Flip128<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            for(var i=0; i<Pow2.T06; i++)                        
            {
                var src = Random.Vec128<T>();
                var srcData = src.Extract();
                var expect  = Vec128.load(ref gbits.flip(in srcData)[0]);
                var actual = ginx.flip(in src);
                Claim.yea(expect.Eq(actual));
            }
            TypeCaseEnd<T>();            
        }

        void Flip256<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            for(var i=0; i<Pow2.T06; i++)                        
            {
                var src = Random.Vec256<T>();
                var srcData = src.Extract();
                var expect  = Vec256.load(ref gbits.flip(in srcData)[0]);
                var actual = ginx.flip(in src);
                Claim.yea(expect.Eq(actual));
            }
            TypeCaseEnd<T>();            
        }
        
        public void Flip128()
        {
            
            Flip128<byte>();
            Flip128<sbyte>();
            Flip128<short>();
            Flip128<ushort>();
            Flip128<int>();
            Flip128<uint>();
        }
        
        public void Flip256()
        {
            
            Flip256<byte>();
            Flip256<sbyte>();
            Flip256<short>();
            Flip256<ushort>();
            Flip256<int>();
            Flip256<uint>();
            Flip256<long>();
            Flip256<ulong>();
        }

    }
}
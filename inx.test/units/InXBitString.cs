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


    public class InXBitStringTest : UnitTest<InXBitStringTest>
    {
        void TestBitString<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            
            var v1 = Randomizer.Vec128<T>();
            var bs = v1.ToBitString();
            Trace($"bitstring({v1}) = {bs}"); 
            
            var partlen = SizeOf<T>.BitSize;
            var parts = bs.Partition(partlen).Reverse().ToArray();
            parts.ForEach(part => Claim.eq(partlen,part.Length));
            for(var i = 0; i < parts.Length; i++)
            {
                var part = parts[i];
                var x = gbits.parse<T>(part);
                var y = v1[i];
                Claim.eq(x,y);
            }
                
            TypeCaseEnd<T>();                

        }
        public void TestBitString()
        {
            TestBitString<byte>();
            TestBitString<sbyte>();
            TestBitString<short>();
            TestBitString<ushort>();
            TestBitString<int>();
            TestBitString<uint>();
            TestBitString<long>();
            TestBitString<ulong>();
        }


    }

}
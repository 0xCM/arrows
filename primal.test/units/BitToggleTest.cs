//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class BitToggleTest : UnitTest<BitToggleTest>
    {
        void ToggleBits<T>(int count)
            where T : struct
        {
            TypeCaseStart<T>();
            var src = Random.Span<T>(count).ReadOnly();
            var tLen = SizeOf<T>.BitSize;
            var srcLen = src.Length;
            for(var i = 0; i< srcLen; i++)
            {
                var x = src[i];
                for(var j =0; j< tLen; j++)
                {
                    var before = gbits.test(in x, j);
                    gbits.toggle(ref x, j);
                    var after = gbits.test(in x, j);
                    Claim.neq(before, after);
                    gbits.toggle(ref x, j);
                    Claim.eq(x, src[i]);
                }
            }
            TypeCaseEnd<T>();

        }
        
        public void ToggleBits()
        {
            ToggleBits<sbyte>(Pow2.T11);
            ToggleBits<byte>(Pow2.T11);
            ToggleBits<short>(Pow2.T11);
            ToggleBits<ushort>(Pow2.T11);
            ToggleBits<int>(Pow2.T11);
            ToggleBits<uint>(Pow2.T11);
            ToggleBits<long>(Pow2.T11);
            ToggleBits<ulong>(Pow2.T11);
            ToggleBits<float>(Pow2.T11);
            ToggleBits<double>(Pow2.T11);        
        }

    }

}
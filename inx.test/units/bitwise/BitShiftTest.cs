//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class BitShiftTest : UnitTest<BitShiftTest>
    {

        void ShiftRight<T>()
            where T : struct
        {
            TypeCaseStart<T>();

            var signed = gmath.signed<T>();
            var bitsize = gmath.bitsize<T>();
            var bs10 = BitString.From("1" + repeat('0', bitsize - 1).Concat());
            var x10 = bs10.ToPrimalValue<T>();
            var bs11 = BitString.From("11" + repeat('0', bitsize - 2).Concat());
            var x11 = bs11.ToPrimalValue<T>();
            var bs01 = BitString.From("01" + repeat('0', bitsize - 2).Concat());
            var x01 = bs01.ToPrimalValue<T>();
            var y = gbits.shiftr(x10, 1);
            if(signed)
                Claim.eq(x11, y);
            else
                Claim.eq(x01, y);

            TypeCaseEnd<T>();
        }

        public void ShiftRight()
        {
            ShiftRight<sbyte>();
            ShiftRight<byte>();
            ShiftRight<short>();
            ShiftRight<ushort>();
            ShiftRight<int>();
            ShiftRight<uint>();
            ShiftRight<long>();
            ShiftRight<ulong>();
        }
    }

}
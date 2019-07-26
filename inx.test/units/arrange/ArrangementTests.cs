//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class ArrangementTests : UnitTest<ArrangementTests>
    {     

        void VerifyHi256<T>(int n = Pow2.T12)
            where T : struct
        {
            TypeCaseStart<T>();
            var lhsSrc = Random.Span256<T>(n);
            var rhsSrc = Random.Span256<T>(n);
            for(var i=0; i<n; i++)
            {
                var lhs = lhsSrc.ToVec256(i);
                var rhs = rhsSrc.ToVec256(i);
                var x = ginx.hi(lhs, rhs);
                
                var k = lhs.Length();
                var j = k/2;
                var y1 = lhs.ToSpan().Slice(j -1,  j);
                var y2 = rhs.ToSpan().Slice(j - 1, j);
                var y = Vec256.load(ref y1.Concat(y2)[0]);
                
                Claim.eq(x,y);                            

            }
            TypeCaseEnd<T>();
        }

        public void VerifyHi256u64()
        {
            //(x[1] -> z[0], y[1] -> z[1], x[3] -> z[2], y[3] -> z[3])
            var x = Vec256.define(1ul,2ul,3ul,4ul);
            var y = Vec256.define(5ul,6ul,7ul,8ul);
            var expect = Vec256.define(2ul,6ul,4ul,8ul);

            var actual = dinx.hi(x,y);
            Claim.eq(expect, actual);
        }

        public void VerifyHi256u32()
        {
            var x = Vec256.define(1u, 2u,  3u,4u,   5u,6u,   7u,8u);
            var y = Vec256.define(10u,12u, 13u,14u, 15u,16u, 17u,18u);

            var actual = dinx.hi(x,y);
            var expect = Vec256.define(3u,13u,4u,14u,7u,17u,8u,18u);
            Claim.eq(expect, actual);
        }

        static string FormatVec<T>(Vec256<T> src)
            where T : struct
                => src.FormatHex(false, AsciSym.Space);

        public static string Describe2x128Perm<T>(Vec256<T> x, Vec256<T> y, byte spec, Vec256<T> z)
            where T : struct
        {
            var xFmt = FormatVec(x);
            var yFmt = FormatVec(y);
            var zFmt = FormatVec(z);
            var specFmt = spec.ToBitString();
            var fmt = sbuild();
            var dataType = typeof(T).Name;
            fmt.AppendLine(new string(AsciSym.Minus, 80));
            fmt.AppendLine($"permute2x28 | (a:{dataType}, b:{dataType}) > {specFmt}");
            fmt.AppendLine(xFmt);
            fmt.AppendLine($"{yFmt}");
            fmt.AppendLine(zFmt);
            return fmt.ToString();
        }

        void VerifyPerm2x128u64()
        {
            var x = Vec256.define(1ul,2ul,3ul,4ul);
            var y = Vec256.define(5ul,6ul,7ul,8ul);
            for(var i=0; i<=255; i++)
            {
                var spec = (byte)i;
                var z = ginx.permute2x128(x,y,spec);
                Trace(Describe2x128Perm(x,y,spec,z));
            }

        }

        void VerifyPerm2x128u32()
        {
            var x = Vec256.define(0u,1u,2u,3u,4u,5u,6u,7u);
            var y = Vec256.define(8u,9u,10u,11u,12u,13u,14u,15u);
            for(var i=0; i<=255; i++)
            {
                var spec = (byte)i;
                var z = ginx.permute2x128(x,y,spec);
                Trace(Describe2x128Perm(x,y,spec,z));
            }

        }

        void VerifyPerm2x128u16()
        {
            var x = Vec256.define((ushort)0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15);
            var y = Vec256.define((ushort)16,17,18,19,20,21,22,23,24,25,26,27,29,29,30,31);
            for(var i=0; i<=255; i++)
            {
                var spec = (byte)i;
                var z = ginx.permute2x128(x,y,spec);
                Trace(Describe2x128Perm(x,y,spec,z));
            }

        }

        void VerifyPerm2x128u8()
        {
            var x = Vec256.define((byte)0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,29,29,30,31);
            var y = Vec256.define((byte)32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63);
            for(var i=0; i<=255; i++)
            {
                var spec = (byte)i;
                var z = ginx.permute2x128(x,y,spec);
                Trace(Describe2x128Perm(x,y,spec,z));
            }

        }

    }

}
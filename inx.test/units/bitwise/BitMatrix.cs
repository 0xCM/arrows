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
    #pragma warning disable 1718

    public class BitMatrixTest : UnitTest<BitMatrixTest>
    {

        public void VerifyIdentity()
        {
            var m8 = BitMatrix8.Identity;
            for(byte i=0; i < m8.RowDim; i++)
                Claim.eq(m8[i,i],Bit.On);
            Claim.yea(m8.Diagonal().AllOnes());

            var m16 = BitMatrix16.Identity;
            for(byte i=0; i < m16.RowDim; i++)
                Claim.eq(m16[i,i],Bit.On);
            Claim.yea(m16.Diagonal().AllOnes());

            var m32 = BitMatrix32.Identity;
            for(byte i=0; i < m32.RowDim; i++)
                Claim.eq(m32[i,i],Bit.On);
            Claim.yea(m32.Diagonal().AllOnes());

            var m64 = BitMatrix64.Identity;
            for(byte i=0; i < m64.RowDim; i++)
                Claim.eq(m64[i,i],Bit.On);
            Claim.yea(m64.Diagonal().AllOnes());

        }

        public void And64()
        {
            var lhs = BitMatrix64.Identity;
            var rhs = BitMatrix64.Identity;
            var result = lhs.And(rhs);
            for(var row=0; row<result.RowDim; row++)
            for(var col=0; col<result.ColDim; col++)    
                Claim.eq(result[row,col], rhs[row,col]);
            
            for(var i=0; i<Pow2.T08; i++)
            {
                var x = Random.BitMatrix64();
                var y = Random.BitMatrix64();

                var xBytes = x.Bytes().Replicate();
                var yBytes = y.Bytes().Replicate();
                var zBytes = xBytes.And(yBytes);
                var expect = BitMatrix64.Define(zBytes);

                var actual = x.And(y);
                Claim.yea(expect == actual);


                
            }
        }

        public void And8()
        {
            var lhs = BitMatrix8.Identity;
            var rhs = BitMatrix8.Identity;
            var result = lhs.And(rhs);
            for(var row=0; row< result.RowDim; row++)
            for(var col=0; col< result.ColDim; col++)    
                Claim.eq(result[row,col], rhs[row,col]);
        }

        public void AndNot8()
        {
            var lhs = Random.BitMatrix8();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }

        public void AndNot16()
        {
            var lhs = Random.BitMatrix16();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }

        public void AndNot32()
        {
            var lhs = Random.BitMatrix32();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }

        public void AndNot64()
        {
            var lhs = Random.BitMatrix64();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }

        public void IsZero()
        {
            Claim.yea(BitMatrix8.Zero.IsZero());
            Claim.nea(BitMatrix8.Identity.IsZero());
            Claim.nea(Random.BitMatrix8().IsZero());

            Claim.yea(BitMatrix16.Zero.IsZero());
            Claim.nea(BitMatrix16.Identity.IsZero());
            Claim.nea(Random.BitMatrix16().IsZero());

            Claim.yea(BitMatrix32.Zero.IsZero());
            Claim.nea(BitMatrix32.Identity.IsZero());
            Claim.nea(Random.BitMatrix32().IsZero());

            Claim.yea(BitMatrix64.Zero.IsZero());
            Claim.nea(BitMatrix64.Identity.IsZero());
            Claim.nea(Random.BitMatrix64().IsZero());
        }

        public void Eq32()
        {
            var x = Random.BitMatrix32();
            var y = Random.BitMatrix32();
            Claim.nea(x.Eq(y));
            Claim.yea(x.Eq(x));
            Claim.yea(y.Eq(y));
        }

        public void Eq64()
        {
            var x = Random.BitMatrix64();
            var y = Random.BitMatrix64();
            Claim.nea(x.Eq(y));
            Claim.nea(x == y);
            Claim.yea(x != y);

            Claim.yea(x.Eq(x));
            Claim.yea(x == x);

            Claim.yea(y.Eq(y));
            Claim.yea(y == y);

        }

    }


}
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

    public class BitMatrixIdentityTest : UnitTest<BitMatrixIdentityTest>
    {

        void VerifyIdentity<N,T>()
            where N : ITypeNat, new()
            where T : struct
        {
            TypeCaseStart<N>();
            var identity = BitMatrix.Identity<N,T>();
            for(var i=0; i< identity.RowCount; i++)
            for(var j=0; j< identity.ColCount; j++)
                Claim.eq(identity[i,j], i==j ? Bit.On : Bit.Off);            
            TypeCaseEnd<N>();
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

        public void VerifyGenericIdentities()
        {   
            VerifyIdentity<N8,byte>();
            VerifyIdentity<N8,short>();
            VerifyIdentity<N16,byte>();
            VerifyIdentity<N18,byte>();
            VerifyIdentity<N19,byte>();

            
            
        }

        public void VerifyPrimalIdentities()
        {
            var m8 = BitMatrix8.Identity;
            for(byte i=0; i < m8.RowCount; i++)
                Claim.eq(m8[i,i],Bit.On);
            Claim.yea(m8.Diagonal().AllOnes());
        
            var m16 = BitMatrix16.Identity;
            for(byte i=0; i < m16.RowCount; i++)
                Claim.eq(m16[i,i],Bit.On);
            Claim.yea(m16.Diagonal().AllOnes());

            var m32 = BitMatrix32.Identity;
            for(byte i=0; i < m32.RowCount; i++)
                Claim.eq(m32[i,i],Bit.On);
            Claim.yea(m32.Diagonal().AllOnes());

            var m64 = BitMatrix64.Identity;
            for(byte i=0; i < m64.RowCount; i++)
                Claim.eq(m64[i,i],Bit.On);
            Claim.yea(m64.Diagonal().AllOnes());

        }


    }

}
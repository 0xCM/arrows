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

    public class tbm_identity : UnitTest<tbm_identity>
    {
        public void identityng()
        {   
            identity_check<N8,byte>();
            identity_check<N8,short>();
            identity_check<N16,byte>();
            identity_check<N18,byte>();
            identity_check<N19,byte>();                    
            identity_check<N12,ushort>();
        }

        public void identity32x32()
        {        
            var m = BitMatrix32.Identity;
            for(byte i=0; i < m.RowCount; i++)
                Claim.eq(m[i,i],Bit.On);
            Claim.yea(m.Diagonal().AllOnes());
        }

        public void identity8x8()
        {
            var m = BitMatrix8.Identity;
            for(byte i=0; i < m.RowCount; i++)
                Claim.eq(m[i,i],Bit.On);
            Claim.yea(m.Diagonal().AllOnes());

        }
        public void identity16x16()
        {
            var m = BitMatrix16.Identity;
            for(byte i=0; i < m.RowCount; i++)
                Claim.eq(m[i,i],Bit.On);
            Claim.yea(m.Diagonal().AllOnes());
        }

        public void identity64x64()
        {
            var m = BitMatrix64.Identity;
            for(byte i=0; i < m.RowCount; i++)
                Claim.eq(m[i,i],Bit.On);
            Claim.yea(m.Diagonal().AllOnes());

        }

        void identity4x4()
        {
            var m = BitMatrix4.Identity;
            for(byte i=0; i < m.RowCount; i++)
                Claim.eq(m[i,i],Bit.On);
            Claim.yea(m.Diagonal().AllOnes());

        }

        public void IsZero()
        {
            Claim.yea(BitMatrix8.Zero.IsZero());
            Claim.nea(BitMatrix8.Identity.IsZero());
            Claim.nea(Polyrand.BitMatrix8().IsZero());

            Claim.yea(BitMatrix16.Zero.IsZero());
            Claim.nea(BitMatrix16.Identity.IsZero());
            Claim.nea(Polyrand.BitMatrix16().IsZero());

            Claim.yea(BitMatrix32.Zero.IsZero());
            Claim.nea(BitMatrix32.Identity.IsZero());
            Claim.nea(Polyrand.BitMatrix32().IsZero());

            Claim.yea(BitMatrix64.Zero.IsZero());
            Claim.nea(BitMatrix64.Identity.IsZero());
            Claim.nea(Polyrand.BitMatrix64().IsZero());
        }

        
        void identity_check<N,T>()
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

    }

}
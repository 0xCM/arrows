//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    using static t_genum.Choices;

    public sealed class t_genum : UnitTest<t_genum>
    {
        public enum Choices : byte
        {
            C0, C1, C2, C3, C4, C5
        }

        public void VerifyEnums()
        {
            var values = EnumValues.NamedValues<Choices>();
            var choices = EnumValues.Get<Choices>();
            var scalars = EnumValues.NamedScalars<Choices,byte>();

            Claim.eq(6,values.Count);
            Claim.eq(C0, values[C0.ToString()].Value);
            Claim.eq(C1, values[C1.ToString()].Value);
            Claim.eq(C2, values[C2.ToString()].Value);
            Claim.eq(C3, values[C3.ToString()].Value);  
            

            Claim.eq(C0, choices.Parse(C0.ToString()).Require());          
            Claim.eq(C1, choices.Parse(C1.ToString()).Require());          
            Claim.eq(C2, choices.Parse(C2.ToString()).Require());          
            Claim.eq(C3, choices.Parse(C3.ToString()).Require());          

            Claim.eq(C0, EnumValues.ToGeneric(C0).Value);
            Claim.eq(C0.ToString(), EnumValues.ToGeneric(C0).Label);

            Claim.eq(C1, EnumValues.ToGeneric(C1).Value);
            Claim.eq(C1.ToString(), EnumValues.ToGeneric(C1).Label);

            Claim.eq(C2, EnumValues.ToGeneric(C2).Value);
            Claim.eq(C2.ToString(), EnumValues.ToGeneric(C2).Label);

            Claim.eq((byte)0, scalars[0].Value);
            Claim.eq((byte)1, scalars[1].Value);
            Claim.eq((byte)2, scalars[2].Value);
            Claim.eq((byte)3, scalars[3].Value);

            Claim.eq(C0.ToString(), scalars[0].Name);
            Claim.eq(C1.ToString(), scalars[1].Name);
            Claim.eq(C2.ToString(), scalars[2].Name);
            Claim.eq(C3.ToString(), scalars[3].Name);



        }

    }
}
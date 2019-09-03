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
            var lv = GEnum.LabeledValues<Choices>();
            Claim.eq(6,lv.Length);
            Claim.eq(C0, lv[0].value);
            Claim.eq(C1, lv[1].value);
            Claim.eq(C2, lv[2].value);
            Claim.eq(C3, lv[3].value);  

            Claim.eq(C0, GEnum.Parse<Choices>(C0.ToString()).Require());          
            Claim.eq(C1, GEnum.Parse<Choices>(C1.ToString()).Require());          
            Claim.eq(C2, GEnum.Parse<Choices>(C2.ToString()).Require());          
            Claim.eq(C3, GEnum.Parse<Choices>(C3.ToString()).Require());          

            Claim.eq(C0, genum(C0).Value);
            Claim.eq(C0.ToString(), genum(C0).Label);

            Claim.eq(C1, genum(C1).Value);
            Claim.eq(C1.ToString(), genum(C1).Label);

            Claim.eq(C2, genum(C2).Value);
            Claim.eq(C2.ToString(), genum(C2).Label);

            var ls = GEnum.LabeledScalars<Choices,byte>();
            Claim.eq((byte)0, ls[0].scalar);
            Claim.eq((byte)1, ls[1].scalar);
            Claim.eq((byte)2, ls[2].scalar);
            Claim.eq((byte)3, ls[3].scalar);

            Claim.eq(C0.ToString(), ls[0].label);
            Claim.eq(C1.ToString(), ls[1].label);
            Claim.eq(C2.ToString(), ls[2].label);
            Claim.eq(C3.ToString(), ls[3].label);



        }

    }
}
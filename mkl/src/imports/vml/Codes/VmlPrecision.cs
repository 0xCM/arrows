//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{

    enum VmlPrecision
    {
        ///<summary>Selects the default/current precision mode</summary>
        DefaultRounding = 0x00000000,        
        
        ///<summary>Selects acccuracy/rounding mode constistent with 32-bit floating point</summary>
        F32Rounding = 0x00000010,
        
        ///<summary>Selects acccuracy/rounding mode constistent with 64-bit floating point</summary>
        F64Rounding = 0x00000020,
        
        ///<summary>Selects the prior precision mode</summary>
        RestoreRounding =0x00000030,

    }

}
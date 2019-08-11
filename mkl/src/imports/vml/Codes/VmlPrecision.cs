//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{


    enum VmlPrecision
    {
        ///<summary>Selects the default/current precision mode</summary>
        Default = 0x00000000,        
        
        ///<summary>Selects acccuracy/rounding mode constistent with 32-bit floating point</summary>
        F32 = 0x00000010,
        
        ///<summary>Selects acccuracy/rounding mode constistent with 64-bit floating point</summary>
        F64 = 0x00000020,
        
        ///<summary>Selects the prior precision mode</summary>
        Restore =0x00000030,

    }


}
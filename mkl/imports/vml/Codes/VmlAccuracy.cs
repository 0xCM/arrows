//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{

    /// <summary>
    /// Controls the accuracy of VML functions
    /// </summary>
    enum VmlAccuracy
    {
        ///<summary>Selects low accuracy VML functions</summary>
        Low = 0x00000001,
        
        ///<summary>Selects high accuracy VML functions</summary>
        High = 0x00000002,
        
        ///<summary>Selects enhanced performance, high accuracy VML functions</summary>
        HighP = 0x00000003

    }


}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    
    enum VmlMask
    {
        Accuracy = 0x0000000F,
        
        FpuMode = 0x000000F0,
        
        ErrorMode =  0x0000FF00,
        
        ErrorModeStdHandler = 0x00002F00,
        
        ErrorModeCallback = 0x00001000,
        
        OmpThreadCount = 0x00030000,
        
        FTZDAZ = 0x003C0000,
        
        TrapExceptions = 0x0F000000,

    }
}
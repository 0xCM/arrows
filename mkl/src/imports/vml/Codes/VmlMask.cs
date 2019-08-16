//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{

    /// <summary>
    /// Accuracy, floating-point and error handling control are packed in the VML mode variable. 
    /// </summary>
    enum VmlMask
    {
        /// <summary>
        /// Extract accuracy bits
        /// </summary>
        Accuracy = 0x0000000F,
        
        /// <summary>
        /// Extract floating-point control bits
        /// </summary>
        FpuMode = 0x000000F0,
        
        /// <summary>
        /// Extract error handling control bits, including error callback bits
        /// </summary>
        ErrorMode =  0x0000FF00,
        
        /// <summary>
        /// Extract error handling control bits, not including error callback bits
        /// </summary>
        ErrorModeStdHandler = 0x00002F00,
        
        /// <summary>
        /// Extract error callback bits
        /// </summary>
        ErrorModeCallback = 0x00001000,
        
        /// <summary>
        /// Extract OpenMP(R) number of threads mode bits
        /// </summary>
        OmpThreadCount = 0x00030000,
        
        /// <summary>
        /// Extract FTZ and DAZ bits
        /// </summary>
        FTZDAZ = 0x003C0000,
        
        /// <summary>
        /// Extract exception trap bits
        /// </summary>
        TrapExceptions = 0x0F000000,

    }
}
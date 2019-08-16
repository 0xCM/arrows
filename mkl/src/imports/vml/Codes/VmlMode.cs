//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    
    readonly struct VmlMode
    {
        public static VmlMode Define(VmlAccuracy accuracy, VmlErrorMode? errors = null)
            => new VmlMode(accuracy, errors);

        public static implicit operator VmlModeFlags(VmlMode src)
            => (VmlModeFlags)src.Accuracy | (VmlModeFlags)src.ErrorMode;
        
        public VmlMode(VmlAccuracy accuracy, VmlErrorMode? errors = null)
        {
            this.Accuracy = accuracy;
            this.ErrorMode = errors ?? VmlErrorMode.DefaultErrorMode;
        }

        public readonly VmlAccuracy Accuracy;

        public readonly VmlErrorMode ErrorMode;                        

        public VmlModeFlags Flags
            => (VmlModeFlags)Accuracy | (VmlModeFlags)ErrorMode;

    }

    [Flags]
    enum VmlModeFlags
    {
        ///<summary>Selects the default/current precision mode</summary>
        DefaultRounding = 0x00000000,        
        
        ///<summary>Selects acccuracy/rounding mode constistent with 32-bit floating point</summary>
        F32Rounding = 0x00000010,
        
        ///<summary>Selects acccuracy/rounding mode constistent with 64-bit floating point</summary>
        F64Rounding = 0x00000020,
        
        ///<summary>Selects the prior precision mode</summary>
        RestoreRounding =0x00000030,
        
        ///<summary>Selects low accuracy VML functions</summary>
        LowAccuracy = 0x00000001,
        
        ///<summary>Selects high accuracy VML functions</summary>
        HighAccuracy = 0x00000002,
        
        ///<summary>Selects enhanced performance, high accuracy VML functions</summary>
        HighAccuracyP = 0x00000003,

        ///<summary>Indicates errors are ignored</summary>
        IgnoreErrors =  0x00000100,

        ///<summary>Indicates errno variable is set whenever there is an error</summary>
        ErrorNumber = 0x00000200,

        ///<summary>Indicates error messages are written to standard error output</summary>
        StdErr = 0x00000400,

        ///<summary>Indicates an exception is raised when there is an error</summary>
        RaiseException = 0x00000800,

        ///<summary>Indicates a user-speccified error handler is invoked</summary>
        ErrorCallback = 0x00001000,

        ///<summary>Ignore errors and do not update error status</summary>
        PretendNoError = 0x00002000,


    }

}
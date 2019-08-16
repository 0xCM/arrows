//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{

    enum VmlErrorMode
    {
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

        DefaultErrorMode  = ErrorNumber | ErrorCallback | RaiseException        
    }


}
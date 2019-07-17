namespace Z0.Mkl
{

    /// <summary>
    /// Controls the accuracy of VML functions
    /// </summary>
    enum VmlAccuracy
    {
        ///<summary>Selects low accuracy VML functions</summary>
        VML_LA = 0x00000001,
        
        ///<summary>Selects high accuracy VML functions</summary>
        VML_HA = 0x00000002,
        
        ///<summary>Selects high performance VML functions</summary>
        VML_EP = 0x00000003

    }
    
    enum VmlPrecision
    {
        ///<summary>Selects the default/current precision mode</summary>
        VML_DEFAULT_PRECISION = 0x00000000,        
        
        ///<summary>Selects acccuracy/rounding mode constistent with 32-bit floating point</summary>
        VML_FLOAT_CONSISTENT = 0x00000010,
        
        ///<summary>Selects acccuracy/rounding mode constistent with 64-bit floating point</summary>
        VML_DOUBLE_CONSISTENT = 0x00000020,
        
        ///<summary>Selects the prior precision mode</summary>
        VML_RESTORE =0x00000030,

    }

    enum VmlErrorMode
    {
        ///<summary>Indicates errors are ignored</summary>
        VML_ERRMODE_IGNORE =  0x00000100,

        ///<summary>Indicates errno variable is set whenever there is an error</summary>
        VML_ERRMODE_ERRNO = 0x00000200,

        ///<summary>Indicates error messages are written to standard error output</summary>
        VML_ERRMODE_STDERR = 0x00000400,

        ///<summary>Indicates an exception is raised when there is an error</summary>
        VML_ERRMODE_EXCEPT = 0x00000800,

        ///<summary>Indicates a user-speccified error handler is invoked</summary>
        VML_ERRMODE_CALLBACK = 0x00001000,

        ///<summary>Ignore errors and do not update error status</summary>
        VML_ERRMODE_NOERR = 0x00002000,

        VML_ERRMODE_DEFAULT  = VML_ERRMODE_ERRNO | VML_ERRMODE_CALLBACK | VML_ERRMODE_EXCEPT        
    }

    enum VmlMask
    {
        VML_ACCURACY_MASK =           0x0000000F,
        VML_FPUMODE_MASK =            0x000000F0,
        VML_ERRMODE_MASK =           0x0000FF00,
        VML_ERRMODE_STDHANDLER_MASK = 0x00002F00,
        VML_ERRMODE_CALLBACK_MASK =   0x00001000,
        VML_NUM_THREADS_OMP_MASK =    0x00030000,
        VML_FTZDAZ_MASK =             0x003C0000,
        VML_TRAP_EXCEPTIONS_MASK =    0x0F000000,

    }
}
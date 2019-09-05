//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    /// <summary>
    ///  USER-DEFINED PARAMETERS FOR QUASI-RANDOM NUMBER BASIC GENERATORS
    ///  VSL_BRNG_SOBOL and VSL_BRNG_NIEDERR are Gray-code based quasi-random
    ///  number basic generators. Default parameters of the generators
    ///  support generation of quasi-random number vectors of dimensions
    ///  S<=40 for SOBOL and S<=318 for NIEDERRITER. The library provides
    ///  opportunity to register user-defined initial values for the
    ///  generators and generate quasi-random vectors of desirable dimension.
    ///  There is also opportunity to register user-defined parameters for
    ///  default dimensions and obtain another sequence of quasi-random vectors.
    ///  Service function vslNewStreamEx is used to pass the parameters to
    ///  the library. Data are packed into array params, parameter of the routine.
    ///  First element of the array is used for dimension S, second element
    ///  contains indicator, VSL_USER_QRNG_INITIAL_VALUES, of user-defined
    ///  parameters for quasi-random number generators.
    ///  Macros VSL_USER_PRIMITIVE_POLYMS and VSL_USER_INIT_DIRECTION_NUMBERS
    ///  are used to describe which data are passed to SOBOL QRNG and
    ///  VSL_USER_IRRED_POLYMS - which data are passed to NIEDERRITER QRNG.
    ///  For example, to demonstrate that both primitive polynomials and initial
    ///  direction numbers are passed in SOBOL one should set third element of the
    ///  array params to  VSL_USER_PRIMITIVE_POLYMS | VSL_USER_DIRECTION_NUMBERS.
    ///  Macro VSL_QRNG_OVERRIDE_1ST_DIM_INIT is used to override default
    ///  initialization for the first dimension. Macro VSL_USER_DIRECTION_NUMBERS
    ///  is used when direction numbers calculated on the user side are passed
    ///  into the generators. More detailed description of interface for
    ///  registration of user-defined QRNG initial parameters can be found
    ///  in VslNotes.pdf.
    /// </summary>
    /// <remarks>
    /// Taken from MKL headers
    /// </remarks>
    public enum Qrng : byte
    {
        VSL_USER_QRNG_INITIAL_VALUES  = 0x1,

        VSL_USER_PRIMITIVE_POLYMS  = 0x1,

        VSL_USER_INIT_DIRECTION_NUMBERS = 2,
        
        VSL_USER_IRRED_POLYMS  = 1,

        VSL_USER_DIRECTION_NUMBERS = 4,

        VSL_QRNG_OVERRIDE_1ST_DIM_INIT = 8

    }


}




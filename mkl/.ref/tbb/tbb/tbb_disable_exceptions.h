/*
    Copyright 2005-2019 Intel Corporation.

    This software and the related documents are Intel copyrighted materials, and your
    use of them is governed by the express license under which they were provided to
    you ("License"). Unless the License provides otherwise, you may not use, modify,
    copy, publish, distribute, disclose or transmit this software or the related
    documents without Intel's prior written permission.

    This software and the related documents are provided as is, with no express or
    implied warranties, other than those that are expressly stated in the License.



*/

//! To disable use of exceptions, include this header before any other header file from the library.

//! The macro that prevents use of exceptions in the library files
#undef  TBB_USE_EXCEPTIONS
#define TBB_USE_EXCEPTIONS 0

//! Prevent compilers from issuing exception related warnings.
/** Note that the warnings are suppressed for all the code after this header is included. */
#if _MSC_VER
#if __INTEL_COMPILER
    #pragma warning (disable: 583)
#else
    #pragma warning (disable: 4530 4577)
#endif
#endif

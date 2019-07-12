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

/*
Replacing the standard memory allocation routines in Microsoft* C/C++ RTL
(malloc/free, global new/delete, etc.) with the TBB memory allocator.

Include the following header to a source of any binary which is loaded during
application startup

#include "tbb/tbbmalloc_proxy.h"

or add following parameters to the linker options for the binary which is
loaded during application startup. It can be either exe-file or dll.

For win32
tbbmalloc_proxy.lib /INCLUDE:"___TBB_malloc_proxy"
win64
tbbmalloc_proxy.lib /INCLUDE:"__TBB_malloc_proxy"
*/

#ifndef __TBB_tbbmalloc_proxy_H
#define __TBB_tbbmalloc_proxy_H

#if _MSC_VER

#ifdef _DEBUG
    #pragma comment(lib, "tbbmalloc_proxy_debug.lib")
#else
    #pragma comment(lib, "tbbmalloc_proxy.lib")
#endif

#if defined(_WIN64)
    #pragma comment(linker, "/include:__TBB_malloc_proxy")
#else
    #pragma comment(linker, "/include:___TBB_malloc_proxy")
#endif

#else
/* Primarily to support MinGW */

extern "C" void __TBB_malloc_proxy();
struct __TBB_malloc_proxy_caller {
    __TBB_malloc_proxy_caller() { __TBB_malloc_proxy(); }
} volatile __TBB_malloc_proxy_helper_object;

#endif // _MSC_VER

/* Public Windows API */
extern "C" int TBB_malloc_replacement_log(char *** function_replacement_log_ptr);

#endif //__TBB_tbbmalloc_proxy_H

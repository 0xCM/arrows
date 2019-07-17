//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
	using System;
	using System.Linq;
	using System.Collections.Generic;
	using System.Runtime.CompilerServices;
	using System.Runtime.InteropServices;
    using System.Security;

	using static zfunc;
    
    [SuppressUnmanagedCodeSecurity]
    public static class MklImports
    {
        internal const string MklDll = "mkl_rt.dll";


        internal const CallingConvention Cdecl = CallingConvention.Cdecl;

    }

}

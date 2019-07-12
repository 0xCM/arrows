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
    using static MklImports;

    [SuppressUnmanagedCodeSecurity]
    public static class VML
    {

		[DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsAbs(int n, ref float src, ref float dst);
		

		[DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdAbs(int n, ref double src, ref double dst);
		
    }

}

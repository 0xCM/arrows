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
    public static class VSL
    {        

        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vslNewStreamEx(IntPtr stream, BRNG brng, int argLen, ref uint args);
       
        // Callback function: int iUpdateFunc( VSLStreamStatePtr stream, int* n, unsigned int ibuf[], int* nmin, int* nmax, int* idx );
        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vsliNewAbstractStream(IntPtr stream , int ibufLen, ref uint ibuf, IntPtr iUpdateFunc);

        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vslNewStream(ref IntPtr stream, BRNG brng, uint seed);

        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vslNewStreamEx(ref IntPtr stream, BRNG brng, ref uint parameters);    

        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vslDeleteStream(IntPtr stream);


        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vdRngCauchy(int method, IntPtr stream, int count, ref double values, double a, double b);

        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vsRngCauchy(int method, IntPtr stream, int count, ref float values, float a, float b);


        /// <summary>
        /// Generates random numbers uniformly distributed over the interval [a, b).
        /// </summary>
        /// <param name="method">Always 0</param>
        /// <param name="stream">An intialized brng stream</param>
        /// <param name="count">The number of values to generate</param>
        /// <param name="values">The buffer to receive the generated values</param>
        /// <param name="a">The inclusive lower bound of the generated values</param>
        /// <param name="b">The exclusive upper bound of the generated values</param>
        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus viRngUniform(int method, IntPtr stream, int count, ref int values, int a, int b);

        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vsRngUniform(int method, IntPtr stream, int count, ref float values, float a, float b);

        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vdRngUniform(int method, IntPtr stream, int count, ref double values, double a, double b);

        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus viRngUniformBits64(int method, IntPtr stream, int count, ref ulong values);

        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus viRngUniformBits32(int method, IntPtr stream, int count, ref uint values);

        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus viRngBernoulli(int method, IntPtr stream, int count, ref int values, double p);

        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus viRngGeometric(int method, IntPtr stream, int count, ref int values, double p);

    }

}
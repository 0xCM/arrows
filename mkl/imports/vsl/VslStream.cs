//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    
	using static zfunc;
    using static MklImports;


    public struct VslStream : IDisposable
    {
        public static implicit operator VslStream(IntPtr src)
            => new VslStream(src);

        public static implicit operator IntPtr(VslStream src)
            => src.Pointer;
    
        IntPtr Pointer;

        public VslStream(IntPtr Pointer)
            => this.Pointer = Pointer;

        public void Dispose()
        {
            if(Pointer != IntPtr.Zero)
                VSL.vslDeleteStream(ref Pointer);
        }

        public IntPtr Raw()
            => Pointer;
    }


    partial class VSL
    {        

       [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vslNewStream(ref IntPtr stream, BRNG brng, uint seed);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vslDeleteStream(ref IntPtr stream);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vslNewStreamEx(ref IntPtr stream, BRNG brng, ref uint parameters);    

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vslNewStreamEx(ref IntPtr stream, BRNG brng, int argLen, ref uint args);
       
        // Callback function: int iUpdateFunc(VSLStreamStatePtr stream, int* n, unsigned int ibuf[], int* nmin, int* nmax, int* idx );
        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vsliNewAbstractStream(ref IntPtr stream , int ibufLen, ref uint ibuf, IntPtr iUpdateFunc);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vslsNewAbstractStream(ref IntPtr stream , int bufferLen, ref float buffer, float min, float max, IntPtr callback);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern BRNG vslGetStreamStateBrng(IntPtr stream);

    }
}
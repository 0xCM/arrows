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
    using static MklCommon;

    partial class VSL
    {        
        /// <summary>
        /// Creates a new random number stream
        /// </summary>
        /// <param name="stream">A reference to the stream pointer that will be allocated</param>
        /// <param name="brng">The generator upon which the stream is predicated</param>
        /// <param name="seed">The initial state of the generator</param>
        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vslNewStream(ref IntPtr stream, BRNG brng, uint seed);

        /// <summary>
        /// Deallocates a stream created via vslNewStream
        /// </summary>
        /// <param name="stream">A reference to the stream pointer that will be deallocated</param>
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

        /// <summary>
        /// Selects a substream from the source stream
        /// </summary>
        /// <param name="stream">The stream to manipulate</param>
        /// <param name="index">A 0-based index that identifies the substream</param>
        /// <param name="count">The maximum number of substreams</param>
        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vslLeapfrogStream(IntPtr stream, int index, int count);

        /// <summary>
        /// Advances the stream by a specified number of elements
        /// </summary>
        /// <param name="stream">The stream to manipulate</param>
        /// <param name="steps">The number of elements to skip</param>
        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vslSkipAheadStream(IntPtr stream, long steps);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vslCopyStream(ref IntPtr dst, IntPtr src);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vslCopyStreamState(IntPtr dst, IntPtr src);


    }

    /*
    Leapfrog example:
    status = vslNewStream(&stream1, VSL_BRNG_MCG31, 174); 
    status = vslCopyStream(&stream2, stream1); 
    status = vslCopyStream(&stream3, stream1);    
    
    status = vslLeapfrogStream(stream1, 0, 3); 
    status = vslLeapfrogStream(stream2, 1, 3); 
    status = vslLeapfrogStream(stream3, 2, 3);

    
     */


}
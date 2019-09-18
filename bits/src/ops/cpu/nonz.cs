//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;    
    using static As;
    

    partial class Bits
    {
        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec128<byte> src)
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec128<sbyte> src)
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec128<short> src)
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec128<ushort> src)
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec128<int> src)
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonzero(in Vec128<uint> src)
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec128<long> src)
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec128<ulong> src) 
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec128<float> src) 
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec128<double> src) 
            => ! TestZ(src,src);        
 
        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec256<byte> src)
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec256<sbyte> src)
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec256<short> src)
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec256<ushort> src)
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec256<int> src)
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec256<uint> src)
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec256<long> src)
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec256<ulong> src) 
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec256<float> src) 
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec256<double> src) 
            => ! TestZ(src,src);          
    }
}

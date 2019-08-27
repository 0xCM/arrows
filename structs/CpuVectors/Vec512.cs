//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.InteropServices;
    
    using static zfunc;    

    /// <summary>
    /// Represents a 512-bit cpu vector for use with intrinsic operations
    /// </summary>
    /// <remarks>
    /// This type and any assciated method is wholly synthetic; .Net intrinsics
    /// does not (at the time of this writing) support AVX512
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Size = ByteCount)]
    public struct Vec512<T>
        where T : struct
    {                    
        public Vec256<T> lo;

        public Vec256<T> hi;

        public static readonly int Length = 2*Vec256<T>.Length;

        public static readonly int CellSize = Unsafe.SizeOf<T>();

        /// <summary>
        /// The number of bytes occupied by a vector - which is invariant with respect to the primal component type
        /// </summary>
        public const int ByteCount = 64;

        public static readonly Vec512<T> Zero = default;        

        [MethodImpl(Inline)]
        public Vec512(in Vec256<T> lo, in Vec256<T> hi) 
            : this()    
        {
            this.lo = lo;
            this.hi = hi;
        }

        [MethodImpl(Inline)]
        public Vec512(in Vector256<T> lo, in Vector256<T> hi)     
            : this()    
        {
            this.lo = lo;
            this.hi = hi;
        }

        [MethodImpl(Inline)]
        public Vec512<U> As<U>() 
            where U : struct
                => Unsafe.As<Vec512<T>, Vec512<U>>(ref Unsafe.AsRef(in this));         

        
        public override string ToString()
        {
            //Hi -> Lo
            return hi.ToString() + " | " + lo.ToString();
        }
    }     
}
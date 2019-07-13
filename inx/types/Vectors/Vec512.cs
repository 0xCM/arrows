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


    [StructLayout(LayoutKind.Sequential, Size = Pow2.T06)]
    public struct Vec512<T>
        where T : struct
    {        
    
        public static readonly int Length = 2*Vec256<T>.Length;

        public static readonly int CellSize = Unsafe.SizeOf<T>();

        public const int BitCount = 512;

        public const int ByteCount = Pow2.T06;

        public static readonly Vec512<T> Zero = default;
        
        internal Vec256<T> v0;

        internal Vec256<T> v1;

        [MethodImpl(Inline)]
        public Vec512(Vec256<T> v0, Vec256<T> v1)     
        {
            this.v0 = v0;
            this.v1 = v1;
        }

        [MethodImpl(Inline)]
        public Vec512(Vector256<T> v0, Vector256<T> v1)     
        {
            this.v0 = v0;
            this.v1 = v1;
        }

        [MethodImpl(Inline)]
        public Vec512<U> As<U>() 
            where U : struct
                => Unsafe.As<Vec512<T>, Vec512<U>>(ref Unsafe.AsRef(in this));         

        public override string ToString()
        {
            //Hi -> Lo
            return v1.ToString() + " | " + v0.ToString();
        }
    }     
}
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
    using System.Runtime.InteropServices;

    using static zfunc;    
    
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public readonly struct Vec256<T>
        where T : struct
    {

        public static readonly int Length = Vector256<T>.Count;

        public static readonly ByteSize CellSize = SizeOf<T>.Size;

        public static readonly int BitCount = SizeOf<T>.BitSize * CellSize;

        public static readonly Vec256<T> Zero = Vector256<T>.Zero;

        readonly Vector256<T> data;        
    
        [MethodImpl(Inline)]
        public static implicit operator Vec256<T>(in Vector256<T> src)
            => new Vec256<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Vector256<T>(in Vec256<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public Vec256(in Vector256<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        static T component(Vec256<T> src, int index)
        {
            ref T e0 = ref Unsafe.As<Vec256<T>, T>(ref src);
            return Unsafe.Add(ref e0, index);
        }

        /// <summary>
        /// Extracts a component via its 0-based index
        /// </summary>
        public T this[int idx]
        {
            [MethodImpl(Inline)]
            get => component(this,idx);
        }


        [MethodImpl(Inline)]
        public Vec256<U> As<U>() 
            where U : struct        
                => Unsafe.As<Vector256<T>, Vec256<U>>(ref Unsafe.AsRef(in data));        

        [MethodImpl(Inline)]
        public bool Eq(Vec256<T> rhs)
            => data.Equals(rhs.data);

        public override string ToString()
            => data.ToString();
    }     
}
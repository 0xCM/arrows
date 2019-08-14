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
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;    

    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public readonly struct Vec128<T>
        where T : struct
    {            
        public static readonly int Length = Vector128<T>.Count;

        public static readonly int CellSize = Unsafe.SizeOf<T>();

        public static readonly ulong  BitSize = 128ul;

        public static readonly Vec128<T> Zero = default;

        readonly Vector128<T> data;        
    
        public Vec128(in Vector128<T> src)
            => this.data = src;

        public static bool operator ==(in Vec128<T> lhs, in Vec128<T> rhs)
            => lhs.Equals(rhs);

        public static bool operator !=(in Vec128<T> lhs, in Vec128<T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static implicit operator Vec128<T>(Vector128<T> src)
            => new Vec128<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<T>(Vec128<T> src)
            => src.data;

        [MethodImpl(Inline)]
        static T Component(Vec128<T> src, int index)
        {
            ref T e0 = ref Unsafe.As<Vec128<T>, T>(ref src);
            return Unsafe.Add(ref e0, index);
        }

        /// <summary>
        /// Extracts a component via its 0-based index
        /// </summary>
        public T this[int idx]
        {
            [MethodImpl(Inline)]
            get => Component(this, idx);
        }

        [MethodImpl(Inline)]
        public static Vector128<T> Vector128(Vec128<T> src)
                => src;

        [MethodImpl(Inline)]
        public Num128<T> ToNum128()
            => Vector128(this);

        [MethodImpl(Inline)]
        public Vec128<U> As<U>() 
            where U : struct
                => Unsafe.As<Vector128<T>, Vec128<U>>(ref Unsafe.AsRef(in data));         

        [MethodImpl(Inline)]
        public bool Equals(Vec128<T> rhs)
             => data.Equals(rhs.data);

        public override string ToString()
            => data.ToString();

        public override int GetHashCode()
            => data.GetHashCode();

        public override bool Equals(object obj)
            => obj is Vec128<T> v ? Equals(v) : false;
        
    }     
}
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

    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public readonly struct Vec128<T>
        where T : struct
    {        
    
        public static readonly int Length = Vector128<T>.Count;

        public static readonly int CellSize = Unsafe.SizeOf<T>();

        public static readonly int BitCount = SizeOf<T>.BitSize * CellSize;

        public static readonly Vec128<T> Zero = Vector128<T>.Zero;
        
        readonly ulong x0;

        readonly ulong x1;
    
        [MethodImpl(Inline)]
        public static implicit operator Vec128<T>(Vector128<T> src)
            => Unsafe.As<Vector128<T>, Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<T>(Vec128<T> src)
            => Unsafe.As<Vec128<T>, Vector128<T>>(ref src);

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
                => Unsafe.As<Vec128<T>, Vec128<U>>(ref Unsafe.AsRef(in this));         

        [MethodImpl(Inline)]
        public bool Eq(Vec128<T> rhs)
            => Vector128(this).Equals(rhs);

        public override string ToString()
            => Vector128(this).ToString();
    }     
}
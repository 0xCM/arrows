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


    using static zcore;
    using static inxfunc;

    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public readonly struct Vec128<T> : IEquatable<Vec128<T>>
        where T : struct, IEquatable<T>
    {
        public static readonly int Length = Vector128<T>.Count;

        public static readonly int ComponentSize = Unsafe.SizeOf<T>();
        
        //readonly Vector128<T> data;        
    
        [MethodImpl(Inline)]
        public static implicit operator Vec128<T>(Vector128<T> src)
            => Unsafe.As<Vector128<T>, Vec128<T>>(ref src); //src.ToVec128();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<T>(Vec128<T> src)
            => Unsafe.As<Vec128<T>, Vector128<T>>(ref src);

        /// <summary>
        /// Extracts a component via its 0-based index
        /// </summary>
        public  T this[int idx]
        {
            [MethodImpl(Inline)]
            get => this.Component(idx);

        }

        [MethodImpl(Inline)]
        public Num128<T> ToNum128()
            => this.ToVector128();

        [MethodImpl(Inline)]
        public Vec128<U> As<U>() 
            where U : struct, IEquatable<U>
                => Unsafe.As<Vec128<T>, Vec128<U>>(ref Unsafe.AsRef(in this));         

        [MethodImpl(Inline)]
        public bool Equals(Vec128<T> rhs)
            => this.ToVector128().Equals(rhs);

        public override string ToString()
            => this.ToVector128().ToString();
 

    }     
}
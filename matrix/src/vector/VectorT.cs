//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
        
    using static zfunc;

    public ref struct Vector<T>
        where T : struct
    {
        Span256<T> data;

        [MethodImpl(Inline)]
        public Vector(in Span256<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        public Vector(in ReadOnlySpan256<T> src)
            => this.data = src.Replicate();

        [MethodImpl(Inline)]
        public static implicit operator Vector<T>(in Span256<T> src)
            =>  new Vector<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Vector<T>(in ReadOnlySpan256<T> src)
            =>  new Vector<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Span256<T>(in Vector<T> src)
            =>  src.data;

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(in Vector<T> src)
            =>  src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(in Vector<T> src)
            =>  src.data;

        [MethodImpl(Inline)]
        public static bool operator == (Vector<T> lhs, in Vector<T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (Vector<T> lhs, in Vector<T> rhs) 
            => !lhs.Equals(rhs);


        public ref T this[int i]
        {
            [MethodImpl(Inline)]
            get => ref data[i];            
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => data.Length;            
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        public Span<T> Unblocked
        {
            [MethodImpl(Inline)]
            get => data;
        }

        [MethodImpl(Inline)]
        public Vector<U> As<U>()
            where U : struct
                => data.As<U>();
                
        public string Format(char delimiter = ',')
            => data.Unblocked.FormatList(delimiter);    

        [MethodImpl(Inline)]
        public ref Vector<T> CopyTo(ref Vector<T> dst)
        {
            Unblocked.CopyTo(dst.Unblocked);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public Vector<U> Convert<U>()
            where U : struct
               => new Vector<U>(convert<T,U>(data));

        public Vector<T> Replicate(bool structureOnly = false)
            => new Vector<T>(data.Replicate(structureOnly));

        public bool Equals(Vector<T> rhs)
        {
            var lhsData = Unblocked;
            var rhsData = rhs.Unblocked;
            if(lhsData.Length != rhsData.Length)
                return false;
            for(var i = 0; i<lhsData.Length; i++)
                if(gmath.neq(lhsData[i], rhsData[i]))
                    return false;
            return true;
        }

        public override bool Equals(object rhs)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException(); 
    }
}
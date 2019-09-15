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

    public ref struct BlockVector<T>
        where T : struct
    {
        Span256<T> data;

        [MethodImpl(Inline)]
        public BlockVector(in Span256<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        public BlockVector(in ReadOnlySpan256<T> src)
            => this.data = src.Replicate();

        [MethodImpl(Inline)]
        public static implicit operator BlockVector<T>(in Span256<T> src)
            =>  new BlockVector<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator BlockVector<T>(in ReadOnlySpan256<T> src)
            =>  new BlockVector<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Span256<T>(in BlockVector<T> src)
            =>  src.data;

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(in BlockVector<T> src)
            =>  src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(in BlockVector<T> src)
            =>  src.data;

        [MethodImpl(Inline)]
        public static bool operator == (BlockVector<T> lhs, in BlockVector<T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (BlockVector<T> lhs, in BlockVector<T> rhs) 
            => !lhs.Equals(rhs);


        [MethodImpl(Inline)]
        public static T operator *(BlockVector<T> lhs, in BlockVector<T> rhs)
            => gmath.dot<T>(lhs.data, rhs.data);

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

        public Span256<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        [MethodImpl(Inline)]
        public BlockVector<U> As<U>()
            where U : struct
                => data.As<U>();
                
        [MethodImpl(Inline)]
        public string Format(char delimiter = ',')
            => data.Unblocked.FormatList(delimiter);    

        [MethodImpl(Inline)]
        public ref BlockVector<T> CopyTo(ref BlockVector<T> dst)
        {
            Unblocked.CopyTo(dst.Unblocked);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public BlockVector<U> Convert<U>()
            where U : struct
               => new BlockVector<U>(convert<T,U>(data));

        public BlockVector<T> Replicate(bool structureOnly = false)
            => new BlockVector<T>(data.Replicate(structureOnly));

        public bool Equals(BlockVector<T> rhs)
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

        public Span256<T> ToSpan256()
            => data;

        public ReadOnlySpan256<T> ToReadOnlySpan256()
            => data;
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static nfunc;
    using static zfunc;

    partial class Linear
    {

        [MethodImpl(Inline)]
        public static Span<N,bool> eq<N,T>(BlockVector<N,T> lhs, BlockVector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged    
                => mathspan.eq<T>(lhs.Unsized, rhs.Unsized).ToNatural<N,bool>();            

        [MethodImpl(Inline)]
        public static Span<bool> eq<T>(BlockVector<T> lhs, in BlockVector<T> rhs)
            where T : unmanaged
                => mathspan.eq<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        public static Span<bool> gt<T>(in BlockVector<T> lhs, in BlockVector<T> rhs)
            where T : unmanaged
            => mathspan.gt<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        public static Span<bool> gteq<T>(in BlockVector<T> lhs, in BlockVector<T> rhs)
            where T : unmanaged
            => mathspan.gteq<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        public static Span<bool> lt<T>(in BlockVector<T> lhs, in BlockVector<T> rhs)
            where T : unmanaged
                => mathspan.lt<T>(lhs.Unblocked, rhs.Unblocked);            

        [MethodImpl(Inline)]
        public static Span<bool> lteq<T>(in BlockVector<T> lhs, in BlockVector<T> rhs)
            where T : unmanaged
                => mathspan.lteq<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        public static Span<N,bool> neq<N,T>(in BlockVector<N,T> lhs, in BlockVector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged           
                => mathspan.neq<T>(lhs.Unsized, rhs.Unsized).ToNatural<N,bool>();                   

        [MethodImpl(Inline)]
        public static Span<N,bool> gt<N,T>(in BlockVector<N,T> lhs, in BlockVector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged            
                => mathspan.gt<T>(lhs.Unsized, rhs.Unsized).ToNatural<N,bool>();            
        
        [MethodImpl(Inline)]
        public static Span<N,bool> gteq<N,T>(in BlockVector<N,T> lhs, in BlockVector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged    
                => mathspan.gteq<T>(lhs.Unsized, rhs.Unsized).ToNatural<N,bool>();            

        [MethodImpl(Inline)]
        public static Span<N,bool> lt<N,T>(in BlockVector<N,T> lhs, in BlockVector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged    
                => mathspan.lt<T>(lhs.Unsized, rhs.Unsized).ToNatural<N,bool>();            

        [MethodImpl(Inline)]
        public static Span<N,bool> lteq<N,T>(in BlockVector<N,T> lhs, in BlockVector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged    
                => mathspan.lteq<T>(lhs.Unsized, rhs.Unsized).ToNatural<N,bool>();


    }

}
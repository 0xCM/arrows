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

    using static corefunc;
    using static Traits;


    /// <summary>
    /// Represents an integer predicated on (and constrained by) an underlying type
    /// </summary>
    public readonly struct mod<N, T> : ModN<N, mod<N, T>, T>
        where N : TypeNat, new()
    {

        static ModN<N,T> Ops = ModOps<N,T>.Inhabitant;
        
        static readonly intg<T> @base = natvalg<N,T>();

        [MethodImpl(Inline)]
        public static implicit operator mod<N,T>(T data)
            => new mod<N,T>(data);

        // [MethodImpl(Inline)]
        // public static implicit operator T(mod<N,T> mod)
        //     => mod.data;

        [MethodImpl(Inline)]
        public static bool operator == (mod<N,T> lhs, mod<N,T> rhs) 
            => Ops.eq(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static bool operator != (mod<N,T> lhs, mod<N,T> rhs) 
            => Ops.neq(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static mod<N,T> operator + (mod<N,T> lhs, mod<N,T> rhs) 
            => Ops.add(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static mod<N,T> operator * (mod<N,T> lhs, mod<N,T> rhs) 
            => Ops.mul(lhs.data, rhs.data);

        
        [MethodImpl(Inline)]
        public mod(T data)
            => this.data = Ops.reduce(data);

        public T data  {get;}

        public IEnumerable<T> members 
            => Ops.members;


        [MethodImpl(Inline)]
        public mod<N, T> add(mod<N, T> rhs)
            => this + rhs;

        [MethodImpl(Inline)]
        public mod<N, T> mul(mod<N, T> rhs)
            => this * rhs;


        [MethodImpl(Inline)]
        public bool eq(mod<N, T> rhs)
            => this == rhs;

        [MethodImpl(Inline)]
        public bool neq(mod<N, T> rhs)
            => this != rhs;

        [MethodImpl(Inline)]
        public mod<N, T> distributeL((mod<N, T> x, mod<N, T> y) rhs)
            => Ops.distribute(this.data,(rhs.x.data, rhs.y.data));

        [MethodImpl(Inline)]
        public mod<N, T> distributeR((mod<N, T> x, mod<N, T> y) lhs)
            => Ops.distribute((lhs.x.data, lhs.y.data), this.data);


        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => $"{data} (mod {@base})";

    }

}
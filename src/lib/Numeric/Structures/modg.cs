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

    using static zcore;
    using static Traits;


    /// <summary>
    /// Represents an integer predicated on (and constrained by) an underlying type
    /// </summary>
    public readonly struct modg<N, T> : ModN<N, modg<N, T>, T>
        where T : IConvertible
        where N : TypeNat, new()
    {

        static ModN<N,T> Ops = ModOps<N,T>.Inhabitant;
        
        static readonly intg<T> @base = Nat.natvalg<N,T>();

        [MethodImpl(Inline)]
        public static implicit operator modg<N,T>(T data)
            => new modg<N,T>(data);


        [MethodImpl(Inline)]
        public static bool operator == (modg<N,T> lhs, modg<N,T> rhs) 
            => Ops.eq(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static bool operator != (modg<N,T> lhs, modg<N,T> rhs) 
            => Ops.neq(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static modg<N,T> operator + (modg<N,T> lhs, modg<N,T> rhs) 
            => Ops.add(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static modg<N,T> operator * (modg<N,T> lhs, modg<N,T> rhs) 
            => Ops.mul(lhs.data, rhs.data);

        
        [MethodImpl(Inline)]
        public modg(T data)
            => this.data = Ops.reduce(data);

        public T data  {get;}

        IEnumerable<T> members 
            => Ops.members;

        public Addition<modg<N, T>> addition 
            => Addition.define(this);
            
        public Multiplication<modg<N, T>> multiplication 
            => Multiplication.define(this);

        modg<N, T> Unital<modg<N, T>>.one 
            => new modg<N,T>(Ops.one);

        IEnumerable<modg<N, T>> ModN<N, modg<N, T>>.members 
            => members.Select(x => new modg<N,T>(x));

        public modg<N, T> zero 
            => new modg<N,T>(Ops.zero);

        [MethodImpl(Inline)]
        public modg<N, T> add(modg<N, T> rhs)
            => this + rhs;

        [MethodImpl(Inline)]
        public modg<N, T> mul(modg<N, T> rhs)
            => this * rhs;


        [MethodImpl(Inline)]
        public bool eq(modg<N, T> rhs)
            => this == rhs;

        [MethodImpl(Inline)]
        public bool neq(modg<N, T> rhs)
            => this != rhs;

        [MethodImpl(Inline)]
        public modg<N, T> distributeL((modg<N, T> x, modg<N, T> y) rhs)
            => Ops.distribute(this.data,(rhs.x.data, rhs.y.data));

        [MethodImpl(Inline)]
        public modg<N, T> distributeR((modg<N, T> x, modg<N, T> y) lhs)
            => Ops.distribute((lhs.x.data, lhs.y.data), this.data);

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => $"{data} (mod {@base})";

        public bool Equals(modg<N, T> rhs)
            => eq(rhs);

        modg<N, T> ModN<N, modg<N, T>>.reduce(modg<N, T> src)
            => throw new NotImplementedException();

        modg<N, T> Negatable<modg<N, T>>.negate(modg<N, T> x)
            => throw new NotImplementedException();

        modg<N, T> Negatable<modg<N, T>>.sub(modg<N, T> lhs, modg<N, T> rhs)
            => throw new NotImplementedException();

        bool Equatable<modg<N, T>>.eq(modg<N, T> lhs, modg<N, T> rhs)
            => lhs.eq(rhs);

        bool Equatable<modg<N, T>>.neq(modg<N, T> lhs, modg<N, T> rhs)
            => lhs.neq(rhs);

        modg<N, T> LeftDistributive<modg<N, T>>.distribute(modg<N, T> lhs, (modg<N, T> x, modg<N, T> y) rhs)
            => rhs.x.mul(lhs).add(rhs.y.mul(lhs));

        modg<N, T> RightDistributive<modg<N, T>>.distribute((modg<N, T> x, modg<N, T> y) lhs, modg<N, T> rhs)
            => lhs.x.mul(rhs).add(lhs.y.mul(rhs));

        modg<N, T> Multiplicative<modg<N, T>>.mul(modg<N, T> lhs, modg<N, T> rhs)
            => lhs.mul(rhs);

        modg<N, T> Additive<modg<N, T>>.add(modg<N, T> lhs, modg<N, T> rhs)
            => lhs.add(rhs);

        bool IEquatable<modg<N, T>>.Equals(modg<N, T> rhs)
            => this.eq(rhs);
    }

}
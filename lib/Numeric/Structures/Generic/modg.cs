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
    public readonly struct modg<N, T> : IModN<N, modg<N, T>, T>
        where N : ITypeNat, new()
        where T : struct, IEquatable<T>
    {

        static IModNOps<N,T> Ops = ModOps<N,T>.Inhabitant;
        

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

        [MethodImpl(Inline)]
        public T unwrap()
            => data;

        public modg<N, T> zero 
            => new modg<N,T>(Ops.zero);

        public modg<N, T> one 
            => new modg<N,T>(Ops.one);

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

        [MethodImpl(Inline)]
        public bool Equals(modg<N, T> rhs)
            => eq(rhs);
 

        [MethodImpl(Inline)]
        public int hash()
            => data.GetHashCode();

 
        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => hash();

        public override string ToString()
            => $"{data} (mod {nfunc.natu<N>()})";

        public modg<N, T> negate()
        {
            throw new NotImplementedException();
        }

        public modg<N, T> sub(modg<N, T> rhs)
        {
            throw new NotImplementedException();
        }
    }
}
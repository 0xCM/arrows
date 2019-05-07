//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static nats;
    
    partial class Demands
    {
    }

    /// <summary>
    /// Requires k1:K1 & k2:K2 & k3:K3 => k1 % k2 = k3
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    /// <typeparam name="K3">The third nat type</typeparam>
    public interface IMod<K1,K2,K3> : IDemand<K1,K2,K3>
        where K1 : ITypeNat, new()
        where K2 : ITypeNat, new()
        where K3 : ITypeNat, new()
    {

    }

    /// <summary>
    /// Requires k:K => k % 2 == 0
    /// </summary>
    /// <typeparam name="K">An even natural type</typeparam>
    public interface IEven<K> : IDemand<K>
        where K : ITypeNat, new()
    {

    }

    /// <summary>
    /// Requires k:K => k % 2 != 0
    /// </summary>
    /// <typeparam name="K">An Odd natural type</typeparam>
    public interface IOdd<K> : IDemand<K>
        where K : ITypeNat, new()
    {

    }


    /// <summary>
    /// Captures evidence that k1:K1 & k2:K2 & k3:K3 => k1 % k2 = k3
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    /// <typeparam name="K3">The third nat type</typeparam>
    public readonly struct Mod<K1,K2,K3> : IMod<K1,K2,K3>
        where K1: ITypeNat, new()
        where K2: ITypeNat, new()
        where K3: ITypeNat, new()
    {
        static readonly K1 k1 = default;
        static readonly K2 k2 = default;
        static readonly K3 k3 = default;
        
        static readonly string description = $"{k1} % {k2} = {k3}";

        public Mod(K1 k1, K2 k2, K3 k3)
            => valid = demand(k1.value % k2.value == k3.value);
        
        public bool valid {get;}

        public string format()
            => valid ? description: $"INVALID({description})";    
        
        public override string ToString()
            => format();

    }

    /// <summary>
    /// Captures evidence that k:K => k % 2 == 0
    /// </summary>
    /// <typeparam name="K">An even natural type</typeparam>
    public readonly struct Even<K> : IEven<K>
        where K: ITypeNat, new()
    {
        static readonly K k = default;
        static readonly string description = $"{k} % {2} = {0}";
        
        public Even(K n)
            => valid = demand(n.value % 2 == 0);
        
        public bool valid {get;}

        public string format()
            => valid ? description: $"INVALID({description})";    
        
        public override string ToString()
            => format();
    }
    
    /// <summary>
    /// Captures evidence that k:K => k % 2 != 0
    /// </summary>
    /// <typeparam name="K">An odd natural type</typeparam>
    public readonly struct Odd<K> : IOdd<K>
        where K: ITypeNat, new()
    {
        static readonly K k = default;
        static readonly string description = $"{k} % {2} != {0}";
        public Odd(K n)
            => valid = demand(n.value % 2 != 0);
        
        public bool valid {get;}

        public string format()
            => valid ? description: $"INVALID({description})";    
        
        public override string ToString()
            => format();
    }

}

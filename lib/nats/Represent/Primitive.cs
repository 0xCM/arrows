//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using static zcore;
    using static Traits;

    /// <summary>
    /// Characterizes an atom of the type natural grammar
    /// </summary>
    /// <typeparam name="N">The reifying type</typeparam>
    public interface NatPrimitive<N> : TypeNat<N>
        where N : NatPrimitive<N>,new()
    {
        
    }

    /// <summary>
    /// The singleton type representative for 0
    /// </summary>
    public readonly struct N0 : TypeNat<N0>, NatSeq<N0>, NatPrimitive<N0>, IEven<N0>, Demands.Next<N0,N1>
    {
        public static readonly N0 Rep = default;        

        public static readonly byte[] Digits = {0};        

        public bool valid 
            => true;

        public ulong value 
            => 0;

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public byte[] digits() 
            => Digits;


        public string format()
            => value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// The singleton type representative for 1
    /// </summary>
    public readonly struct N1 : TypeNat<N1>, NatPrimitive<N1>, NatSeq<N1>, Demands.Nonzero<N1>, 
        IPow<N1,N1,N0>, IOdd<N1>, IPrior<N1,N0>, Demands.Next<N1,N2>
    {
        public static readonly N1 Rep = default;

        public static readonly byte[] Digits = {1};        

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;

        public byte[] digits() 
            => Digits;

        public ulong value 
            => 1;

        public string format()
            => value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// The type that represents 2
    /// </summary>
    public readonly struct N2 : TypeNat<N2>, NatSeq<N2>, NatPrimitive<N2>,
        IPrime<N2>, IPow<N2,N2,N1>, IEven<N2>, 
        Demands.Nonzero<N2>, IPrior<N2,N1>, Demands.Next<N2,N3>
    {
        public static readonly N2 Rep = default;        

        public static readonly byte[] Digits = {2};

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public ulong value 
            => 2;

        public bool valid 
            => true;
        
        public byte[] digits() 
            => Digits;


        public string format()
            => value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// The singleton type representative for 3
    /// </summary>
    public readonly struct N3 : TypeNat<N3>, NatSeq<N3>,
        IPrime<N3>, NatPrimitive<N3>, IOdd<N3>,
        Demands.Nonzero<N3>, IPrior<N3,N2>, Demands.Next<N3,N4>
    {
        public static readonly N3 Rep = default;        

        public static readonly byte[] Digits = {3};

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;
        
        public ulong value 
            => 3;

        public byte[] digits() 
            => Digits;

        public string format()
            => value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// The singleton type representative for 4
    /// </summary>
    public readonly struct N4 : TypeNat<N4>, NatSeq<N4>, 
        IPow<N4,N2,N2>, NatPrimitive<N4>, IEven<N4>,
        Demands.Nonzero<N4>, IPrior<N4,N3>, Demands.Next<N4,N5>
    {
        public static readonly N4 Rep = default;        

        public static readonly byte[] Digits = {4};        

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public ulong value 
            => 4;

        public bool valid 
            => true;

        public byte[] digits() 
            => Digits;

        public string format()
            => value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// The singleton type representative for 5
    /// </summary>
    public readonly struct N5 : TypeNat<N5>, NatSeq<N5>,
        IPrime<N5>, NatPrimitive<N5>, IOdd<N5>,
        Demands.Nonzero<N5>, IPrior<N5,N4>, Demands.Next<N5,N6>
    {
        public static readonly N5 Rep = default;

        public static readonly byte[] Digits = {5};

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;

        public ulong value 
            => 5;
                
        public byte[] digits() 
            => Digits;

        public string format()
            => value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// The singleton type representative for 6
    /// </summary>
    public readonly struct N6 : TypeNat<N6>, NatSeq<N6>, NatPrimitive<N6>, Demands.Nonzero<N6>, 
        IEven<N6>, IPrior<N6,N5>, Demands.Next<N6,N7>
    {
        public static readonly N6 Rep = default;

        public static readonly byte[] Digits = {6};

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;

        public ulong value 
            => 6;
        
        public byte[] digits() 
            => Digits;

        public string format()
            => value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// The singleton type representative for 7
    /// </summary>
    public readonly struct N7 : TypeNat<N7>, NatSeq<N7>,
        IPrime<N7>, NatPrimitive<N7>, IOdd<N7>, 
        Demands.Nonzero<N7>, IPrior<N7,N6>, Demands.Next<N7,N8>
    {
        public static readonly N7 Rep = default;

        public static readonly byte[] Digits = {7};

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;

        public ulong value 
            => 7;
            
        public byte[] digits() 
            => Digits;

        public string format()
            => value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// The singleton type representative for 8
    /// </summary>
    public readonly struct N8 : TypeNat<N8>, NatSeq<N8>,
        IPow<N8,N2,N3>, NatPrimitive<N8>, IEven<N8>,
        Demands.Nonzero<N8>, IPrior<N8,N7>, Demands.Next<N8,N9>
    {
        public static readonly N8 Rep = default;        

        public static readonly byte[] Digits = {8};        

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;

        public ulong value  
            => 8;

        public byte[] digits() 
            => Digits;

        public string format()
            => value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// The singleton type representative for 9
    /// </summary>
    public readonly struct N9 : TypeNat<N9>, NatSeq<N9>,
        NatPrimitive<N9>, IPow<N9,N3,N2>, IOdd<N9>,
        Demands.Nonzero<N9>, IPrior<N9,N8>
    {
        public static readonly N9 Rep = default;  
        
        public static readonly byte[] Digits = {9};

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;

        public ulong value 
            => 9;
         
        public byte[] digits() 
            => Digits;

        public string format()
            => value.ToString();

        public override string ToString() 
            => format();
    }
}
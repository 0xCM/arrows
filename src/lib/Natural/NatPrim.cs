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
    /// The singleton type representative for 0
    /// </summary>
    public readonly struct N0 : TypeNat<N0>, NatSeq<N0>, 
        NatPrim<N0>, Demands.Even<N0>
    {
        public static readonly N0 Rep = default;        

        public static readonly byte[] Digits = {0};        

        public bool valid 
            => true;

        public uint value 
            => 0;

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public byte[] digits() 
            => Digits;


        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 1
    /// </summary>
    public readonly struct N1 : TypeNat<N1>, NatSeq<N1>, 
        Pow<N1,N1,N0>, NatPrim<N1>, Demands.Odd<N1>,Demands.Nonzero<N1>
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

        public uint value 
            => 1;

        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The type that represents 2
    /// </summary>
    public readonly struct N2 : TypeNat<N2>, NatSeq<N2>, 
        Demands.Prime<N2>, Pow<N2,N2,N1>, NatPrim<N2>, Demands.Even<N2>, Demands.Nonzero<N2>
    {
        public static readonly N2 Rep = default;        

        public static readonly byte[] Digits = {2};

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public uint value 
            => 2;

        public bool valid 
            => true;
        
        public byte[] digits() 
            => Digits;


        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 3
    /// </summary>
    public readonly struct N3 : TypeNat<N3>, NatSeq<N3>,
        Demands.Prime<N3>, NatPrim<N3>, Demands.Odd<N3>,Demands.Nonzero<N3>
    {
        public static readonly N3 Rep = default;        

        public static readonly byte[] Digits = {3};

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;
        
        public uint value 
            => 3;

        public byte[] digits() 
            => Digits;

        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 4
    /// </summary>
    public readonly struct N4 : TypeNat<N4>, NatSeq<N4>, 
        Pow<N4,N2,N2>, NatPrim<N4>, Demands.Even<N4>,Demands.Nonzero<N4>
    {
        public static readonly N4 Rep = default;        

        public static readonly byte[] Digits = {4};        

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public uint value 
            => 4;

        public bool valid 
            => true;

        public byte[] digits() 
            => Digits;

        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 5
    /// </summary>
    public readonly struct N5 : TypeNat<N5>, NatSeq<N5>,
        Demands.Prime<N5>, NatPrim<N5>, Demands.Odd<N5>,Demands.Nonzero<N5>
    {
        public static readonly N5 Rep = default;

        public static readonly byte[] Digits = {5};

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;

        public uint value 
            => 5;
                
        public byte[] digits() 
            => Digits;

        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 6
    /// </summary>
    public readonly struct N6 : TypeNat<N6>, NatSeq<N6>,
        NatPrim<N6>, Demands.Even<N6>,Demands.Nonzero<N6>
    {
        public static readonly N6 Rep = default;

        public static readonly byte[] Digits = {6};

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;

        public uint value 
            => 6;
        
        public byte[] digits() 
            => Digits;

        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 7
    /// </summary>
    public readonly struct N7 : TypeNat<N7>, NatSeq<N7>,
        Demands.Prime<N7>, NatPrim<N7>, Demands.Odd<N7>, Demands.Nonzero<N7>
    {
        public static readonly N7 Rep = default;

        public static readonly byte[] Digits = {7};

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;

        public uint value 
            => 7;
            
        public byte[] digits() 
            => Digits;

        public override string ToString() 
            => value.ToString();
    }

    /// <summary>
    /// The singleton type representative for 8
    /// </summary>
    public readonly struct N8 : TypeNat<N8>, NatSeq<N8>,
        Pow<N8,N2,N3>, NatPrim<N8>, Demands.Even<N8>,Demands.Nonzero<N8>
    {
        public static readonly N8 Rep = default;        

        public static readonly byte[] Digits = {8};        

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;

        public uint value  
            => 8;

        public byte[] digits() 
            => Digits;

        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 9
    /// </summary>
    public readonly struct N9 : TypeNat<N9>, NatSeq<N9>,
        NatPrim<N9>, Pow<N9,N3,N2>, Demands.Odd<N9>,Demands.Nonzero<N9>
    {
        public static readonly N9 Rep = default;  
        
        public static readonly byte[] Digits = {9};

        public TypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;

        public uint value 
            => 9;
         
        public byte[] digits() 
            => Digits;

        public override string ToString() 
            => value.ToString();    
    }
}
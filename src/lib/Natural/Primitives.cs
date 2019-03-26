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
    public interface Primitive<N>
        where N : Primitive<N>,new()
    {
        
    }

    /// <summary>
    /// The singleton type representative for 0
    /// </summary>
    public readonly struct N0 : TypeNat<N0,N1>, Primitive<N0>
    {
        public static readonly N0 Rep = default;        
        public static readonly byte[] Digits = {0};        
        public uint value => 0;
        public TypeNat rep => N0.Rep;
        public byte[] digits() => Digits;
        public N1 nextrep => N1.Rep;
        public override string ToString() => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 1
    /// </summary>
    public readonly struct N1 : TypeNat<N1,N2>, Pow<N1,N1,N0>, Primitive<N1>
    {
        public static readonly N1 Rep = default;
        public static readonly byte[] Digits = {1};        
        public TypeNat rep => N1.Rep;
        public N2 nextrep => N2.Rep;
        public byte[] digits() => Digits;
        public uint value => 1;
        public override string ToString() => value.ToString();    
    }

    /// <summary>
    /// The type that represents 2
    /// </summary>
    public readonly struct N2 : TypeNat<N2,N3>, Demands.Prime<N2>, Pow<N2,N2,N1>, Primitive<N2>
    {
        public static readonly N2 Rep = default;        

        public static readonly byte[] Digits = {2};

        public uint value 
            => 2;

        public TypeNat rep 
            => N2.Rep;

        public N3 nextrep 
            => N3.Rep;

        public byte[] digits() 
            => Digits;


        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 3
    /// </summary>
    public readonly struct N3 : TypeNat<N3,N4>, Demands.Prime<N3>, Primitive<N3>
    {
        public static readonly N3 Rep = default;        

        public static readonly byte[] Digits = {3};

        public uint value 
            => 3;

        public TypeNat rep 
            => N3.Rep;
        
        public N4 nextrep 
            => N4.Rep;

        public byte[] digits() 
            => Digits;

        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 4
    /// </summary>
    public readonly struct N4 : TypeNat<N4,N5>, Pow<N4,N2,N2>, Primitive<N4>
    {
        public static readonly N4 Rep = default;        
        public static readonly byte[] Digits = {4};        
        public uint value 
            => 4;

        public TypeNat rep 
            => N4.Rep;

        public N5 nextrep 
            => N5.Rep;

        public byte[] digits() 
            => Digits;

        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 5
    /// </summary>
    public readonly struct N5 : TypeNat<N5,N6>, Demands.Prime<N5>, Primitive<N5>
    {
        public static readonly N5 Rep = default;
        public static readonly byte[] Digits = {5};
        public uint value 
            => 5;

        public TypeNat rep 
            => N5.Rep;

        public N6 nextrep 
            => N6.Rep;
                
        public byte[] digits() 
            => Digits;

        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 6
    /// </summary>
    public readonly struct N6 : TypeNat<N6,N7>, Primitive<N6>
    {
        public static readonly N6 Rep = default;
        public static readonly byte[] Digits = {6};
        public uint value 
            => 6;

        public TypeNat rep 
            => N6.Rep;
        
        public N7 nextrep 
            => N7.Rep;
        
        public byte[] digits() 
            => Digits;

        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 7
    /// </summary>
    public readonly struct N7 : TypeNat<N7,N8>, Demands.Prime<N7>, Primitive<N7>
    {
        public static readonly N7 Rep = default;
        public static readonly byte[] Digits = {7};
        public uint value 
            => 7;

        public TypeNat rep 
            => N7.Rep;

        public N8 nextrep 
            => N8.Rep;
            
        public byte[] digits() 
            => Digits;

        public override string ToString() 
            => value.ToString();
    }

    /// <summary>
    /// The singleton type representative for 8
    /// </summary>
    public readonly struct N8 : TypeNat<N8,N9>, Pow<N8,N2,N3>, Primitive<N8>
    {
        public static readonly N8 Rep = default;        
        public static readonly byte[] Digits = {8};        
        public uint value  => 8;
        public TypeNat rep => N8.Rep;
        public N9 nextrep => N9.Rep;        
        public byte[] digits()  => Digits;
        public override string ToString() => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 9
    /// </summary>
    public readonly struct N9 : TypeNat<N9>, Primitive<N9>, Pow<N9,N3,N2>
    {
        public static readonly N9 Rep = default;  
        public static readonly byte[] Digits = {9};
        
        public uint value 
            => 9;
         
        public byte[] digits() 
            => Digits;

        public TypeNat rep 
            => N9.Rep;

        public override string ToString() 
            => value.ToString();    
    }
}
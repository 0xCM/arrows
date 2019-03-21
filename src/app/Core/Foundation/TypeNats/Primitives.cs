//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using static corefunc;
    using static Nats;
    using static Class;

    /// <summary>
    /// The singleton type representative for 0
    /// </summary>
    public readonly struct N0 : TypeNat<N0,N1>
    {
        public static readonly N0 Inhabitant = new N0(0);

        public uint value {get;}

        public N0 current => N0.Inhabitant;

        public N1 next => N1.Inhabitant;

        N0(uint natval)
            => this.value = natval;        
    }

    /// <summary>
    /// The singleton type representative for 1
    /// </summary>
    public readonly struct N1 : TypeNat<N1,N2>
    {
        public static readonly N1 Inhabitant = new N1(1);        
        
        public uint value {get;}    
        
        public N1 current => N1.Inhabitant;

        public N2 next => N2.Inhabitant;
        

        N1(uint natval)
            => this.value = natval;        
        public override string ToString() => value.ToString();    
    }

    /// <summary>
    /// The type that represents 2
    /// </summary>
    public readonly struct N2 : TypeNat<N2,N3>
    {
        public static readonly N2 Inhabitant = new N2(2);        

        public uint value {get;}    

        public N2 current => N2.Inhabitant;

        public N3 next => N3.Inhabitant;

        N2(uint natval)
            => this.value = natval;        

        public override string ToString() => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 3
    /// </summary>
    public readonly struct N3 : TypeNat<N3,N4>
    {
        public static readonly N3 Inhabitant = new N3(3);        

        public uint value {get;}    

        public N3 current => N3.Inhabitant;
        
        public N4 next => N4.Inhabitant;

        N3(uint natval)
            => this.value = natval;        

        public override string ToString() => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 4
    /// </summary>
    public readonly struct N4 : TypeNat<N4,N5>
    {
        public static readonly N4 Inhabitant = new N4(4);        
        public uint value {get;}    

        public N4 current => N4.Inhabitant;

        public N5 next => N5.Inhabitant;


        N4(uint natval)
            => this.value = natval;        

        public override string ToString() => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 5
    /// </summary>
    public readonly struct N5 : TypeNat<N5,N6>
    {
        public static readonly N5 Inhabitant = new N5(5);        
        
        public uint value {get;}

        public N5 current => N5.Inhabitant;

        public N6 next => N6.Inhabitant;
        
        N5(uint natval)
            => this.value = natval;        
        
        public override string ToString() => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 6
    /// </summary>
    public readonly struct N6 : TypeNat<N6,N7>
    {
        public static readonly N6 Inhabitant = new N6(6);        
        
        public uint value {get;}    

        public N6 current => N6.Inhabitant;
        
        public N7 next => N7.Inhabitant;
        
        N6(uint natval)
            => this.value = natval;        

        public override string ToString() => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 7
    /// </summary>
    public readonly struct N7 : TypeNat<N7,N8>
    {
        public static readonly N7 Inhabitant = new N7(7);        

        public uint value {get;}    

        public N7 current => N7.Inhabitant;

        public N8 next => N8.Inhabitant;

        N7(uint natval)
            => this.value = natval;        
            
        public override string ToString() => value.ToString();
    }

    public readonly struct N8 : TypeNat<N8,N9>
    {
        public static readonly N8 Inhabitant = new N8(8);        
        public uint value {get;}    

        public N8 current => N8.Inhabitant;

        public N9 next => N9.Inhabitant;
        N8(uint natval)
            => this.value = natval;        

        public override string ToString() => value.ToString();    
    }

    public readonly struct N9 : TypeNat<N9>
    {
        public static readonly N9 Inhabitant = new N9(9);        
        public uint value {get;}    
        
        public N9 current => N9.Inhabitant;

        N9(uint natval)
            => this.value = natval;      

        public override string ToString() => value.ToString();    
    }


}
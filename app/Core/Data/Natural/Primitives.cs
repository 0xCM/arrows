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
    using C = Contracts;    
    using static corefunc;
    using static TypeNats;

    /// <summary>
    /// The singleton type representative for 0
    /// </summary>
    public readonly struct N0 : C.TypeNat<N0,N1>
    {
        public static readonly N0 Inhabitant = new N0(0);

        public int natval {get;}

        public N0 current => N0.Inhabitant;

        public N1 next => N1.Inhabitant;

        N0(int natval)
            => this.natval = natval;        
    }

    /// <summary>
    /// The singleton type representative for 1
    /// </summary>
    public readonly struct N1 : C.TypeNat<N1,N2>
    {
        public static readonly N1 Inhabitant = new N1(1);        
        
        public int natval {get;}    
        
        public N1 current => N1.Inhabitant;

        public N2 next => N2.Inhabitant;
        

        N1(int natval)
            => this.natval = natval;        
        public override string ToString() => natval.ToString();    
    }

    /// <summary>
    /// The type that represents 2
    /// </summary>
    public readonly struct N2 : C.TypeNat<N2,N3>
    {
        public static readonly N2 Inhabitant = new N2(2);        

        public int natval {get;}    

        public N2 current => N2.Inhabitant;

        public N3 next => N3.Inhabitant;

        N2(int natval)
            => this.natval = natval;        

        public override string ToString() => natval.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 3
    /// </summary>
    public readonly struct N3 : C.TypeNat<N3,N4>
    {
        public static readonly N3 Inhabitant = new N3(3);        

        public int natval {get;}    

        public N3 current => N3.Inhabitant;
        
        public N4 next => N4.Inhabitant;

        N3(int natval)
            => this.natval = natval;        

        public override string ToString() => natval.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 4
    /// </summary>
    public readonly struct N4 : C.TypeNat<N4,N5>
    {
        public static readonly N4 Inhabitant = new N4(4);        
        public int natval {get;}    

        public N4 current => N4.Inhabitant;

        public N5 next => N5.Inhabitant;


        N4(int natval)
            => this.natval = natval;        

        public override string ToString() => natval.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 5
    /// </summary>
    public readonly struct N5 : C.TypeNat<N5,N6>
    {
        public static readonly N5 Inhabitant = new N5(5);        
        
        public int natval {get;}

        public N5 current => N5.Inhabitant;

        public N6 next => N6.Inhabitant;
        
        N5(int natval)
            => this.natval = natval;        
        
        public override string ToString() => natval.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 6
    /// </summary>
    public readonly struct N6 : C.TypeNat<N6,N7>
    {
        public static readonly N6 Inhabitant = new N6(6);        
        
        public int natval {get;}    

        public N6 current => N6.Inhabitant;
        
        public N7 next => N7.Inhabitant;
        
        N6(int natval)
            => this.natval = natval;        

        public override string ToString() => natval.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 7
    /// </summary>
    public readonly struct N7 : C.TypeNat<N7,N8>
    {
        public static readonly N7 Inhabitant = new N7(7);        

        public int natval {get;}    

        public N7 current => N7.Inhabitant;

        public N8 next => N8.Inhabitant;

        N7(int natval)
            => this.natval = natval;        
            
        public override string ToString() => natval.ToString();
    }

    public readonly struct N8 : C.TypeNat<N8,N9>
    {
        public static readonly N8 Inhabitant = new N8(8);        
        public int natval {get;}    

        public N8 current => N8.Inhabitant;

        public N9 next => N9.Inhabitant;
        N8(int natval)
            => this.natval = natval;        

        public override string ToString() => natval.ToString();    
    }

    public readonly struct N9 : C.TypeNat<N9>
    {
        public static readonly N9 Inhabitant = new N9(9);        
        public int natval {get;}    
        
        public N9 current => N9.Inhabitant;

        N9(int natval)
            => this.natval = natval;      

        public override string ToString() => natval.ToString();    
    }


}
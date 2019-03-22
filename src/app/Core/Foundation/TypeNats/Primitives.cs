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
    using static Traits;

    /// <summary>
    /// The singleton type representative for 0
    /// </summary>
    public readonly struct N0 : TypeNat<N0,N1>
    {
        public static readonly N0 Rep = default;

        public uint value 
            => 0;

        public N0 rep 
            => N0.Rep;

        public N1 nextrep 
            => N1.Rep;

        public override string ToString() 
            => value.ToString();    

    }

    /// <summary>
    /// The singleton type representative for 1
    /// </summary>
    public readonly struct N1 : TypeNat<N1,N2>
    {
        public static readonly N1 Rep = default;
        
        public N1 rep 
            => N1.Rep;

        public N2 nextrep 
            => N2.Rep;
        
        public uint value 
            => 1;

        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The type that represents 2
    /// </summary>
    public readonly struct N2 : TypeNat<N2,N3>
    {
        public static readonly N2 Rep = default;        

        public uint value 
            => 2;

        public N2 rep 
            => N2.Rep;

        public N3 nextrep 
            => N3.Rep;


        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 3
    /// </summary>
    public readonly struct N3 : TypeNat<N3,N4>
    {
        public static readonly N3 Rep = default;        

        public uint value 
            => 3;

        public N3 rep 
            => N3.Rep;
        
        public N4 nextrep 
            => N4.Rep;

        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 4
    /// </summary>
    public readonly struct N4 : TypeNat<N4,N5>
    {
        public static readonly N4 Rep = default;        
        
        public uint value 
            => 4;

        public N4 rep 
            => N4.Rep;

        public N5 nextrep 
            => N5.Rep;


        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 5
    /// </summary>
    public readonly struct N5 : TypeNat<N5,N6>
    {
        public static readonly N5 Rep = default;
        
        public uint value 
            => 5;

        public N5 rep 
            => N5.Rep;

        public N6 nextrep 
            => N6.Rep;
                
        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 6
    /// </summary>
    public readonly struct N6 : TypeNat<N6,N7>
    {
        public static readonly N6 Rep = default;
        
        public uint value 
            => 6;

        public N6 rep 
            => N6.Rep;
        
        public N7 nextrep 
            => N7.Rep;
        

        public override string ToString() 
            => value.ToString();    
    }

    /// <summary>
    /// The singleton type representative for 7
    /// </summary>
    public readonly struct N7 : TypeNat<N7,N8>
    {
        public static readonly N7 Rep = default;

        public uint value 
            => 7;

        public N7 rep 
            => N7.Rep;

        public N8 nextrep 
            => N8.Rep;

            
        public override string ToString() => value.ToString();
    }

    public readonly struct N8 : TypeNat<N8,N9>
    {
        public static readonly N8 Rep = default;
        
        public uint value 
            => 8;

        public N8 rep 
            => N8.Rep;

        public N9 nextrep 
            => N9.Rep;
        

        public override string ToString() 
            => value.ToString();    
    }

    public readonly struct N9 : TypeNat<N9>
    {
        public static readonly N9 Rep = default;  
        
        public uint value 
            => 9;
        
        public N9 rep 
            => N9.Rep;

        public override string ToString() 
            => value.ToString();    
    }


}
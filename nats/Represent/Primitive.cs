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
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;

    /// <summary>
    /// Characterizes an atom of the type natural grammar
    /// </summary>
    /// <typeparam name="N">The reifying type</typeparam>
    public interface INatPrimitive<N> : ITypeNat<N>
        where N : INatPrimitive<N>,new()
    {
        
    }

    /// <summary>
    /// The singleton type representative for 0
    /// </summary>
    public readonly struct N0 : ITypeNat<N0>, INatSeq<N0>, INatPrimitive<N0>, INatEven<N0>, INatNext<N0,N1>
    {
       public override bool Equals(object obj)
            => obj is N0;

        public static readonly N0 Rep = default;        

        public static readonly byte[] Digits = {0};        

        public bool valid 
            => true;

        public ulong value 
            => 0;

        [MethodImpl(Inline)]
        public static bool operator ==(N0 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N0 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N0 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N0 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N0 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N0 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep 
            => this;

        public NatSeq seq
            => this;

        byte[] ITypeNat. Digits()
            => Digits;


        public string format()
            => value.ToString();

        public override string ToString() 
            => format();

        public override int GetHashCode()
            => value.GetHashCode();
    }

    /// <summary>
    /// The singleton type representative for 1
    /// </summary>
    public readonly struct N1 
      : ITypeNat<N1>, 
        INatPrimitive<N1>, 
        INatSeq<N1>, 
        INatNonZero<N1>, 
        INatPow<N1,N1,N0>, 
        INatOdd<N1>, 
        INatPrior<N1,N0>, 
        INatNext<N1,N2>,
        INatPow2<N0>
    {
        public static readonly N1 Rep = default;

        public override bool Equals(object obj)
            => obj is N1;

        public static readonly byte[] Digits = {1};        


        [MethodImpl(Inline)]
        public static bool operator ==(N1 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N1 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N1 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N1 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N1 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N1 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;

        ITypeNat INatPow2.Exponent 
            => N0.Rep;


        byte[] ITypeNat.Digits()
            => Digits;

        public ulong value 
            => 1;

        public string format()
            => value.ToString();

        public override string ToString() 
            => format();

        public override int GetHashCode()
            => value.GetHashCode();


    }

    /// <summary>
    /// The type that represents 2
    /// </summary>
    public readonly struct N2 : 
        ITypeNat<N2>, 
        INatSeq<N2>, 
        INatPrimitive<N2>,
        INatPrime<N2>, 
        INatPow<N2,N2,N1>, 
        INatEven<N2>, 
        INatNonZero<N2>, 
        INatPrior<N2,N1>, 
        INatNext<N2,N3>,
        INatPow2<N1>        
    {
        public static readonly N2 Rep = default;        

        public static readonly byte[] Digits = {2};
        
        public ulong value 
            => 2;
        
        public override bool Equals(object obj)
            => obj is N2;

        [MethodImpl(Inline)]
        public static bool operator ==(N2 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N2 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N2 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N2 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N2 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N2 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;
        
        byte[] ITypeNat. Digits()
            => Digits;

        ITypeNat INatPow2.Exponent 
            => N1.Rep;

        public string format()
            => value.ToString();

        public override string ToString() 
            => format();

        public override int GetHashCode()
            => value.GetHashCode();
    }

    /// <summary>
    /// The singleton type representative for 3
    /// </summary>
    public readonly struct N3 : ITypeNat<N3>, INatSeq<N3>,
        INatPrime<N3>, INatPrimitive<N3>, INatOdd<N3>,
        INatNonZero<N3>, INatPrior<N3,N2>, INatNext<N3,N4>
    {
        public static readonly N3 Rep = default;        

        public static readonly byte[] Digits = {3};

        public ulong value 
            => 3;

        public override bool Equals(object obj)
            => obj is N3;

        [MethodImpl(Inline)]
        public static bool operator ==(N3 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N3 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N3 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N3 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N3 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N3 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;
        
        byte[] ITypeNat. Digits()
            => Digits;

        public string format()
            => value.ToString();

        public override string ToString() 
            => format();

        public override int GetHashCode()
            => value.GetHashCode();
    }

    /// <summary>
    /// The singleton type representative for 4
    /// </summary>
    public readonly struct N4 : 
        ITypeNat<N4>, 
        INatSeq<N4>, 
        INatPow<N4,N2,N2>, 
        INatPrimitive<N4>, 
        INatEven<N4>,
        INatNonZero<N4>, 
        INatPrior<N4,N3>, 
        INatNext<N4,N5>,
        INatPow2<N2>        

    {
        public static readonly N4 Rep = default;

        public static readonly byte[] Digits = {4};        

        public ulong value 
            => 4;

        public override bool Equals(object obj)
            => obj is N4;

        [MethodImpl(Inline)]
        public static bool operator ==(N4 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N4 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N4 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N4 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N4 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N4 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;

        byte[] ITypeNat. Digits()
            => Digits;

        ITypeNat INatPow2.Exponent 
            => N2.Rep;

        public string format()
            => value.ToString();

        public override string ToString() 
            => format();

        public override int GetHashCode()
            => value.GetHashCode();
    }

    /// <summary>
    /// The singleton type representative for 5
    /// </summary>
    public readonly struct N5 : ITypeNat<N5>, INatSeq<N5>,
        INatPrime<N5>, INatPrimitive<N5>, INatOdd<N5>,
        INatNonZero<N5>, INatPrior<N5,N4>, INatNext<N5,N6>
    {
        public static readonly N5 Rep = default;

        public static readonly byte[] Digits = {5};

        public ulong value 
            => 5;

        public override bool Equals(object obj)
            => obj is N5;

        [MethodImpl(Inline)]
        public static bool operator ==(N5 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N5 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N5 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N5 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N5 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N5 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;
                
        byte[] ITypeNat. Digits()
            => Digits;

        public string format()
            => value.ToString();

        public override string ToString() 
            => format();

        public override int GetHashCode()
            => value.GetHashCode();
    }

    /// <summary>
    /// The singleton type representative for 6
    /// </summary>
    public readonly struct N6 : 
        ITypeNat<N6>, 
        INatSeq<N6>, 
        INatPrimitive<N6>, 
        INatNonZero<N6>, 
        INatEven<N6>, 
        INatPrior<N6,N5>, 
        INatNext<N6,N7>
    {
        public static readonly N6 Rep = default;

        public static readonly byte[] Digits = {6};

        public ulong value 
            => 6;

        public override bool Equals(object obj)
            => obj is N6;

        [MethodImpl(Inline)]
        public static bool operator ==(N6 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N6 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N6 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N6 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N6 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N6 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;

        byte[] ITypeNat. Digits()
            => Digits;

        public string format()
            => value.ToString();

        public override string ToString() 
            => format();
 
        public override int GetHashCode()
            => value.GetHashCode();
     }

    /// <summary>
    /// The singleton type representative for 7
    /// </summary>
    public readonly struct N7 : 
        ITypeNat<N7>, 
        INatSeq<N7>,
        INatPrime<N7>, 
        INatPrimitive<N7>, 
        INatOdd<N7>, 
        INatNonZero<N7>, 
        INatPrior<N7,N6>, 
        INatNext<N7,N8>
    {
        public static readonly N7 Rep = default;

        public ulong value 
            => 7;

        public static readonly byte[] Digits = {7};


        public override bool Equals(object obj)
            => obj is N7;

        [MethodImpl(Inline)]
        public static bool operator ==(N7 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N7 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N7 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N7 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N7 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N7 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;
            
        byte[] ITypeNat. Digits()
            => Digits;

        public string format()
            => value.ToString();

        public override string ToString() 
            => format();
 
 
        public override int GetHashCode()
            => value.GetHashCode();
    }

    /// <summary>
    /// The singleton type representative for 8
    /// </summary>
    public readonly struct N8 : 
        ITypeNat<N8>, 
        INatSeq<N8>,
        INatPow<N8,N2,N3>, 
        INatPrimitive<N8>, 
        INatEven<N8>,
        INatNonZero<N8>, 
        INatPrior<N8,N7>, 
        INatNext<N8,N9>,
        INatPow2<N3>        

    { 
        public static readonly N8 Rep = default;        

        public ulong value  
            => 8;

        public static readonly byte[] Digits = {8};        
     
        public override bool Equals(object obj)
            => obj is N8;

        [MethodImpl(Inline)]
        public static bool operator ==(N8 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N8 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N8 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N8 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N8 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N8 rhs)
            => (ulong)lhs >= rhs.value;

        public ITypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;

        ITypeNat INatPow2.Exponent 
            => N3.Rep;

        byte[] ITypeNat. Digits()
            => Digits;

        public string format()
            => value.ToString();

        public override string ToString() 
            => format();
         
        public override int GetHashCode()
            => value.GetHashCode();
    }

    /// <summary>
    /// The singleton type representative for 9
    /// </summary>
    public readonly struct N9 : 
        ITypeNat<N9>, 
        INatSeq<N9>,
        INatPrimitive<N9>, 
        INatOdd<N9>,
        INatNonZero<N9>, 
        INatPrior<N9,N8>
    {
        public static readonly N9 Rep = default;  
        
        public static readonly byte[] Digits = {9};

        public ulong value 
            => 9;
 
        public override bool Equals(object obj)
            => obj is N9;

        [MethodImpl(Inline)]
        public static bool operator ==(N9 lhs, int rhs)
            => lhs.value == (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(N9 lhs, int rhs)
            => lhs.value != (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(N9 lhs, int rhs)
            => lhs.value <= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(N9 lhs, int rhs)
            => lhs.value >= (ulong)rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(int lhs, N9 rhs)
            => (ulong)lhs <= rhs.value;

        [MethodImpl(Inline)]
        public static bool operator >=(int lhs, N9 rhs)
            => (ulong)lhs >= rhs.value;
  
        public ITypeNat rep 
            => this;

        public NatSeq seq
            => this;

        public bool valid 
            => true;


        byte[] ITypeNat. Digits()
            => Digits;

        public string format()
            => value.ToString();

        public override string ToString() 
            => format();
               
        public override int GetHashCode()
            => value.GetHashCode();
 
    }
}
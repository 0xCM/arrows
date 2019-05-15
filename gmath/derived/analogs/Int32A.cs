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

    using static zfunc;
    using static mfunc;

    /// <summary>
    /// Defines a 32-bit signed integer via primitive operations
    /// </summary>
    public ref struct Int32A
    {            

        [MethodImpl(Inline)]    
        public static Int32A define(int src)
            => new Int32A(src);

        [MethodImpl(Inline)]    
        public static int @bool(bool x)
            => x ? 1 : 0;

        [MethodImpl(Inline)]
        public static implicit operator Int32A(int src)
            => new Int32A(src);

        [MethodImpl(Inline)]
        public static implicit operator int(Int32A src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator byte(Int32A src)
            => (byte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator sbyte(Int32A src)
            => (sbyte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator short(Int32A src)
            => (short)src.data;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Int32A src)
            => (ushort)src.data;

        [MethodImpl(Inline)]
        public static explicit operator uint(Int32A src)
            => (uint)src.data;

        [MethodImpl(Inline)]
        public static explicit operator long(Int32A src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator ulong(Int32A src)
            => (ulong)src.data;

        [MethodImpl(Inline)]    
        public static bool operator true(Int32A x)
            => x.data != 0;

        [MethodImpl(Inline)]    
        public static bool operator false(Int32A x)
            => x.data == 0;

        [MethodImpl(Inline)]
        public static bool operator == (Int32A lhs, Int32A rhs) 
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (Int32A lhs, Int32A rhs) 
            => lhs.data != rhs.data;

        [MethodImpl(Inline)]
        public static Int32A operator + (Int32A lhs, Int32A rhs) 
            => lhs.data + rhs.data;

        [MethodImpl(Inline)]
        public static Int32A operator - (Int32A lhs, Int32A rhs) 
            => lhs.data - rhs.data;

        [MethodImpl(Inline)]
        public static Int32A operator -- (Int32A x) 
            =>  x.data - 1;

        [MethodImpl(Inline)]
        public static Int32A operator ++ (Int32A x) 
            =>  x.data + 1;

        [MethodImpl(Inline)]
        public static Int32A operator - (Int32A x) 
            => -x.data;

        [MethodImpl(Inline)]
        public static Int32A operator * (Int32A lhs, Int32A rhs) 
            => lhs.data * rhs.data;

        [MethodImpl(Inline)]
        public static Int32A operator / (Int32A lhs, Int32A rhs) 
            => lhs.data / rhs.data;

        [MethodImpl(Inline)]
        public static Int32A operator % (Int32A lhs, Int32A rhs)
            => lhs.data % rhs.data;

        [MethodImpl(Inline)]
        public static bool operator < (Int32A lhs, Int32A rhs) 
            => lhs.data < rhs.data;

        [MethodImpl(Inline)]
        public static bool operator <= (Int32A lhs, Int32A rhs) 
            => lhs.data <= rhs.data;

        [MethodImpl(Inline)]
        public static bool operator > (Int32A lhs, Int32A rhs) 
            => lhs.data > rhs.data;

        [MethodImpl(Inline)]
        public static bool operator >= (Int32A lhs, Int32A rhs) 
            => lhs.data >= rhs.data;

        [MethodImpl(Inline)]
        public static Int32A operator & (Int32A lhs, Int32A rhs) 
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static Int32A operator | (Int32A lhs, Int32A rhs) 
            => lhs.data | rhs.data;

        [MethodImpl(Inline)]
        public static Int32A operator ^ (Int32A lhs, Int32A rhs) 
            => lhs.data ^ rhs.data;

        [MethodImpl(Inline)]
        public static Int32A operator ~ (Int32A x) 
            => ~ x.data;

        [MethodImpl(Inline)]
        public static Int32A operator >> (Int32A lhs, int rhs) 
            => lhs.data >> rhs;

        [MethodImpl(Inline)]
        public static Int32A operator << (Int32A lhs, int rhs) 
            => lhs.data << rhs;

        int data;

        public Int32A(Int32A src)
            => data = src;

        [MethodImpl(Inline)]
        public bool Equals(Int32A rhs)
            => this == rhs;

        public override int GetHashCode()
            => data.GetHashCode();

        public override bool Equals(object rhs)
            => throw new NotSupportedException();
        
        public override string ToString()
            => throw new NotSupportedException();
    }
}
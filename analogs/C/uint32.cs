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

    using prim = System.UInt32;
    using analog = C.uint32;

    partial class C
    {
        public ref struct uint32 
        {
            prim data;

            [MethodImpl(Inline)]    
            public uint32(prim x)
                => data = x;

            public static analog zero 
            {
                [MethodImpl(Inline)]
                get{return 0;}
            }

            public static analog one 
            {
                [MethodImpl(Inline)]
                get{return 1;}
            }

            public static int bitsize
            {
                [MethodImpl(Inline)]
                get{return 32;}
            }

            [MethodImpl(Inline)]    
            public static analog @bool(bool x)
                => x ? one : zero;

            [MethodImpl(Inline)]    
            public static bool operator true(analog x)
                => x.data != 0;

            [MethodImpl(Inline)]    
            public static bool operator false(analog x)
                => x.data == 0;

            [MethodImpl(Inline)]
            public static implicit operator analog(prim src)
                => new analog(src);

            [MethodImpl(Inline)]
            public static implicit operator prim(analog src)
                => src.data;

            [MethodImpl(Inline)]
            public static explicit operator byte(analog src)
                => (byte)src.data;

            [MethodImpl(Inline)]
            public static explicit operator sbyte(analog src)
                => (sbyte)src.data;

            [MethodImpl(Inline)]
            public static explicit operator short(analog src)
                => (short)src.data;

            [MethodImpl(Inline)]
            public static explicit operator ushort(analog src)
                => (ushort)src.data;

            [MethodImpl(Inline)]
            public static explicit operator int(analog src)
                => (int)src.data;

            [MethodImpl(Inline)]
            public static implicit operator ulong(analog src)
                => src.data;

            [MethodImpl(Inline)]
            public static implicit operator float(analog src)
                => src.data;

            [MethodImpl(Inline)]
            public static implicit operator double(analog src)
                => src.data;

            [MethodImpl(Inline)]
            public static analog operator == (analog lhs, analog rhs) 
                => @bool(lhs.data == rhs.data);

            [MethodImpl(Inline)]
            public static analog operator != (analog lhs, analog rhs) 
                => @bool(lhs.data != rhs.data);

            [MethodImpl(Inline)]
            public static analog operator + (analog lhs, analog rhs) 
                => lhs.data + rhs.data;

            [MethodImpl(Inline)]
            public static analog operator - (analog lhs, analog rhs) 
                => lhs.data - rhs.data;

            [MethodImpl(Inline)]
            public static analog operator * (analog lhs, analog rhs) 
                => lhs.data * rhs.data;

            [MethodImpl(Inline)]
            public static analog operator / (analog lhs, analog rhs) 
                => lhs.data / rhs.data;

            [MethodImpl(Inline)]
            public static analog operator % (analog lhs, analog rhs)
                => lhs.data % rhs.data;

            [MethodImpl(Inline)]
            public static analog operator < (analog lhs, analog rhs) 
                => @bool(lhs.data < rhs.data);

            [MethodImpl(Inline)]
            public static analog operator <= (analog lhs, analog rhs) 
                => @bool(lhs.data <= rhs.data);

            [MethodImpl(Inline)]
            public static analog operator > (analog lhs, analog rhs) 
                => @bool(lhs.data > rhs.data);

            [MethodImpl(Inline)]
            public static analog operator >= (analog lhs, analog rhs) 
                => @bool(lhs.data >= rhs.data);

            [MethodImpl(Inline)]
            public static analog operator & (analog lhs, analog rhs) 
                => lhs.data & rhs.data;

            [MethodImpl(Inline)]
            public static analog operator | (analog lhs, analog rhs) 
                => lhs.data | rhs.data;

            [MethodImpl(Inline)]
            public static analog operator ^ (analog lhs, analog rhs) 
                => lhs.data ^ rhs.data;

            [MethodImpl(Inline)]
            public static analog operator ~ (analog x) 
                => ~ x.data;

            [MethodImpl(Inline)]
            public static analog operator >> (analog lhs, int rhs) 
                => lhs.data >> rhs;
            
            [MethodImpl(Inline)]
            public static analog operator << (analog lhs, int rhs) 
                => lhs.data << rhs;

            [MethodImpl(Inline)]
            public static analog operator -- (analog x) 
                =>  --x.data;

            [MethodImpl(Inline)]
            public static analog operator ++ (analog x) 
                =>  ++x.data;

            [MethodImpl(Inline)]
            public string Format()
                => data.ToString();

            [MethodImpl(Inline)]
            public bool Eq(analog rhs)
                => data == rhs.data;

            public override int GetHashCode()
                => throw new NotSupportedException();

            public override bool Equals(object rhs)
                => throw new NotSupportedException();
            
        }
    }
}
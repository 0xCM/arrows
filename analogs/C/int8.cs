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

    using prim = System.SByte;
    using analog = C.int8;

    partial class C
    {

        public ref struct int8
        {
            prim data;

            [MethodImpl(Inline)]    
            public int8(prim x)
                => data =x;

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

            public int bitsize
            {
                [MethodImpl(Inline)]
                get{return 8;}
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
            public static explicit operator short(analog src)
                => (short)src.data;

            [MethodImpl(Inline)]
            public static explicit operator ushort(analog src)
                => (byte)src.data;

            [MethodImpl(Inline)]
            public static explicit operator int(analog src)
                => (int)src.data;

            [MethodImpl(Inline)]
            public static explicit operator uint(analog src)
                => (uint)src.data;

            [MethodImpl(Inline)]
            public static explicit operator long(analog src)
                => (long)src.data;

            [MethodImpl(Inline)]
            public static explicit operator ulong(analog src)
                => (ulong)src.data;

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
                => (analog)(lhs.data + rhs.data);

            [MethodImpl(Inline)]
            public static analog operator - (analog lhs, analog rhs) 
                => (analog)(lhs.data - rhs.data);

            [MethodImpl(Inline)]
            public static analog operator * (analog lhs, analog rhs) 
                => (analog)(lhs.data * rhs.data);

            [MethodImpl(Inline)]
            public static analog operator / (analog lhs, analog rhs) 
                => (analog)(lhs.data / rhs.data);

            [MethodImpl(Inline)]
            public static analog operator % (analog lhs, analog rhs)
                => (analog)(lhs.data % rhs.data);

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
                => (analog)(lhs.data & rhs.data);

            [MethodImpl(Inline)]
            public static analog operator | (analog lhs, analog rhs) 
                => (analog)(lhs.data | rhs.data);

            [MethodImpl(Inline)]
            public static analog operator ^ (analog lhs, analog rhs) 
                => (analog)(lhs.data ^ rhs.data);

            [MethodImpl(Inline)]
            public static analog operator ~ (analog x) 
                => (analog)~ x.data;

            [MethodImpl(Inline)]
            public static analog operator >> (analog lhs, int rhs) 
                => (analog)(lhs.data >> rhs);

            
            [MethodImpl(Inline)]
            public static analog operator << (analog lhs, int rhs) 
                => (analog)(lhs.data << rhs);

            [MethodImpl(Inline)]
            public static analog operator -- (analog x) 
                =>  --x.data;

            [MethodImpl(Inline)]
            public static analog operator ++ (analog x) 
                =>  ++x.data;

            public analog positive
            {
                [MethodImpl(Inline)]
                get{return data > zero;}
            }

            [MethodImpl(Inline)]
            public string format()
                => data.ToString();

            [MethodImpl(Inline)]
            public bool Eq(analog rhs)
                => data == rhs.data;

            public override int GetHashCode()
                => throw new NotSupportedException();

            public override bool Equals(object rhs)
                => throw new NotSupportedException();
            
            public override string ToString()
                => format();
        }
    }
}
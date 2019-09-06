//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using static zfunc;

    using prim = System.Int16;
    using analog = int16_t;

    public struct int16_t
    {
        prim data;

        public static readonly analog zero = 0;

        public static readonly analog one = 1;


        [MethodImpl(Inline)]    
        public int16_t(prim x)
            => data =x;

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
        public static implicit operator int(analog src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator float(analog src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator double(analog src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator int32_t(analog src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator int64_t(analog src)
            => src.data;


        [MethodImpl(Inline)]
        public static explicit operator byte(analog src)
            => (byte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator sbyte(analog src)
            => (sbyte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator ushort(analog src)
            => (ushort)src.data;

        [MethodImpl(Inline)]
        public static explicit operator uint(analog src)
            => (uint)src.data;

        [MethodImpl(Inline)]
        public static explicit operator ulong(analog src)
            => (ulong)src.data;

        [MethodImpl(Inline)]
        public static explicit operator uint32_t(analog src)
            => (uint)src.data;


        [MethodImpl(Inline)]
        public static explicit operator uint64_t(analog src)
            => (ulong)src.data;

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
        public static analog operator >> (analog lhs, int rhs) 
            => (analog)(lhs.data >> rhs);
        
        [MethodImpl(Inline)]
        public static analog operator << (analog lhs, int rhs) 
            => (analog)(lhs.data << rhs);

        [MethodImpl(Inline)]
        public static analog operator ~ (analog src) 
            => (analog)~ src.data;

        [MethodImpl(Inline)]
        public static analog operator - (analog src) 
            => (analog)(-src.data);

        [MethodImpl(Inline)]
        public static analog operator -- (analog src) 
            =>  --src.data;

        [MethodImpl(Inline)]
        public static analog operator ++ (analog src) 
            =>  ++src.data;
        
        [MethodImpl(Inline)]
        public bool Eq(analog rhs)
            => data == rhs.data;
        
        public override int GetHashCode()
            => throw new NotSupportedException();

        public override bool Equals(object rhs)
            => throw new NotSupportedException();            
    }
}

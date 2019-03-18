//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Root;

    using static corefunc;

    using C = Core.Contracts;
    using systype = System.Byte;

    partial class MathOps
    {
        readonly struct UInt8Ops : C.BoundNatural<systype>
        {
        
            public static readonly UInt8Ops Inhabitant = default(UInt8Ops);

            public systype zero => 0;

            public systype one => 1;

            public systype maxval => systype.MaxValue;

            public systype minval => systype.MaxValue;

            [MethodImpl(Inline)]   
            public systype negate(systype src)
                => src;

            [MethodImpl(Inline)]   
            public systype add(systype a, systype b) 
                => (byte)(a + b);

            [MethodImpl(Inline)]   
            public systype and(systype a, systype b) 
                => (byte)(a & b);

            
            [MethodImpl(Inline)]   
            public systype div(systype lhs, systype rhs)
                => (byte)(lhs/rhs);

            [MethodImpl(Inline)]   
            public QR<byte> divrem(systype a, systype b)
                => new QR<byte>((byte)(a/b), (byte)( a%b));

            [MethodImpl(Inline)]   
            public bool eq(systype lhs, systype rhs) 
                => lhs == rhs;

            [MethodImpl(Inline)]   
            public bool neq(systype lhs, systype rhs) 
                => lhs != rhs;

            [MethodImpl(Inline)]   
            public bool gt(systype a, systype b) 
                => a > b;

            [MethodImpl(Inline)]   
            public bool lt(systype a, systype b) 
                => a < b;

            [MethodImpl(Inline)]   
            public systype mod(systype a, systype b) 
                => (byte)(a % b);

            [MethodImpl(Inline)]   
            public systype mul(systype a, systype b) 
                => (byte)(a * b);

            [MethodImpl(Inline)]   
            public systype neg(systype a) 
                => a;

            [MethodImpl(Inline)]   
            public systype or(systype a, systype b) 
                => (byte)(a | b);

            [MethodImpl(Inline)]   
            public systype xor(systype a, systype b) 
                => (byte)(a ^ b);

            [MethodImpl(Inline)]   
            public systype lshift(systype a, int shift) 
                => (byte)(a << shift);

            [MethodImpl(Inline)]   
            public systype flip(systype a) 
                => (byte)~ a;

            [MethodImpl(Inline)]   
            public systype rshift(systype a, int shift) 
                => (byte)(a >> shift);

            [MethodImpl(Inline)]   
            public systype pow(systype b, int exp) 
                => fold(repeat(b,(long)exp), mul);

            [MethodImpl(Inline)]   
            public systype sub(systype x, systype y) 
                => (byte)(x - y);

            [MethodImpl(Inline)]   
            public systype dec(systype x)
                => --x;

            [MethodImpl(Inline)]   
            public systype muladd(systype x, systype y,systype z) 
                => (byte)(x*y + z);

 
            [MethodImpl(Inline)]   
            public bool lteq(systype lhs, systype rhs)
                => lhs <= rhs;

            [MethodImpl(Inline)]   
            public bool gteq(systype lhs, systype rhs)
                => lhs >= rhs;
 
            [MethodImpl(Inline)]   
            public systype inc(systype x)
                => ++x;

            [MethodImpl(Inline)]   
            public systype abs(systype x)
                => x;
 
            [MethodImpl(Inline)]   
            public Sign sign(systype x)
                => x == 0 ? Sign.Neutral : Sign.Positive;
        }
    }
}
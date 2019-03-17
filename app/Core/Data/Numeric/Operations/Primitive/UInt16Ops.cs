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
    using systype = System.UInt16;

    partial class MathOps
    {
        readonly struct UInt16Ops : C.BoundUnsignedInt<systype>
        {
        
            public static readonly UInt16Ops Inhabitant = default(UInt16Ops);

            public systype zero => 0;

            public systype one => 1;

            public systype maxval => systype.MaxValue;
            
            public systype minval => systype.MaxValue;
            [MethodImpl(Inline)]   
            
            public systype negate(systype src)
                => src;

            [MethodImpl(Inline)]   
            public systype add(systype a, systype b) 
                => (ushort)(a + b);

            [MethodImpl(Inline)]   
            public systype and(systype a, systype b) 
                => (ushort)(a & b);

            [MethodImpl(Inline)]   
            public systype div(systype lhs, systype rhs)
                => (ushort)(lhs/rhs);
            
            [MethodImpl(Inline)]   
            public QR<ushort> divrem(systype a, systype b)
                => new QR<ushort>((ushort)(a/b), (ushort)( a%b));

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
                => (ushort)(a % b);

            [MethodImpl(Inline)]   
            public systype mul(systype a, systype b) 
                => (ushort)(a * b);

            [MethodImpl(Inline)]   
            public systype neg(systype a) 
                => a;

            [MethodImpl(Inline)]   
            public systype or(systype a, systype b) 
                => (ushort)(a | b);

            [MethodImpl(Inline)]   
            public systype xor(systype a, systype b) 
                => (ushort)(a ^ b);

            [MethodImpl(Inline)]   
            public systype lshift(systype a, int shift) 
                => (ushort)(a << shift);

            [MethodImpl(Inline)]   
            public systype flip(systype a) 
                => (ushort)~ a;

            [MethodImpl(Inline)]   
            public systype rshift(systype a, int shift) 
                => (ushort)(a >> shift);

            [MethodImpl(Inline)]   
            public systype pow(systype b, int exp) 
                => fold(repeat(b,(long)exp), mul);

            [MethodImpl(Inline)]   
            public systype sub(systype x, systype y) 
                => (ushort)(x - y);

            [MethodImpl(Inline)]   
            public systype dec(systype x)
                => --x;

            [MethodImpl(Inline)]   
            public systype muladd(systype x, systype y,systype z) 
                => (ushort)(x*y + z);

        
            [MethodImpl(Inline)]   
            public bool lteq(systype lhs, systype rhs)
                => lhs <= rhs;

            [MethodImpl(Inline)]   
            public bool gteq(systype lhs, systype rhs)
                => lhs >= rhs;

            [MethodImpl(Inline)]   
            public systype inc(systype x)
                => ++x;
       
        }

    }
}
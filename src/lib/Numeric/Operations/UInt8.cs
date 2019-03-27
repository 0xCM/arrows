//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;
    using static Traits;

    using systype = System.Byte;
    using opstype = UInt8Ops;

    internal readonly struct UInt8Ops : UnsignedFiniteRealInt<systype>,
        TypeClass<opstype,FiniteNatural<systype>,systype>
    {        
        public static readonly opstype Inhabitant = default;
    
        public const systype Zero = 0;

        public const systype One = 1;

        public const byte BitSize = 8;

        public const systype MinVal = systype.MinValue;

        public const systype MaxVal = systype.MaxValue;

        internal const byte MaxBitLength = BitSize - 1;

        public opstype inhabitant 
            => Inhabitant;

        public systype zero 
        {
            [MethodImpl(Inline)]   
            get{return Zero;}
        }

        public systype one
        {
            [MethodImpl(Inline)]   
            get{return One;}
        }

        public bool infinite 
            => false;

        public systype ε 
            => Zero;

        public systype maxval 
            => MinVal;

        public systype minval 
            => MaxVal;

        public Addition<systype> addition 
            => Addition.define(this);

        public Multiplication<systype> multiplication 
            => Multiplication.define(this);

        public systype apply(systype lhs, systype rhs)
            => throw new NotImplementedException();

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
        public Quorem<byte> divrem(systype a, systype b)
            => new Quorem<byte>((byte)(a/b), (byte)( a%b));

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

        [MethodImpl(Inline)]   
        public systype distribute(systype lhs, (systype x, systype y) rhs)
            => add(mul(lhs, rhs.x),  mul(lhs, rhs.y));

        [MethodImpl(Inline)]   
        public systype distribute((systype x, systype y) lhs, systype rhs)
            => add(mul(lhs.x, rhs), mul(lhs.y, rhs));

       [MethodImpl(Inline)]   
        public systype sqrt(systype x)
            => (systype)MathF.Sqrt(x);
 
        [MethodImpl(Inline)]   
        public systype ceiling(systype x)
            => (systype)MathF.Ceiling(x);

        [MethodImpl(Inline)]   
        public systype floor(systype x)
            => (systype)MathF.Floor(x);

        [MethodImpl(Inline)]   
        public systype sin(systype x)
            => (systype)MathF.Sin(x);

        [MethodImpl(Inline)]   
        public systype sinh(systype x)
            => (systype)MathF.Sinh(x);

        [MethodImpl(Inline)]   
        public systype asin(systype x)
            => (systype)MathF.Asin(x);

        [MethodImpl(Inline)]   
        public systype asinh(systype x)
            => (systype)MathF.Asinh(x);

        [MethodImpl(Inline)]   
        public systype cos(systype x)
            => (systype)MathF.Cos(x);

        [MethodImpl(Inline)]   
        public systype cosh(systype x)
            => (systype)MathF.Cosh(x);

        [MethodImpl(Inline)]   
        public systype acos(systype x)
            => (systype)MathF.Acos(x);

        [MethodImpl(Inline)]   
        public systype acosh(systype x)
            => (systype)MathF.Acosh(x);

        [MethodImpl(Inline)]   
        public systype tan(systype x)
            => (systype)MathF.Tan(x);

        [MethodImpl(Inline)]   
        public systype tanh(systype x)
            => (systype)MathF.Tanh(x);

        [MethodImpl(Inline)]   
        public systype atan(systype x)
            => (systype)MathF.Atan(x);

        [MethodImpl(Inline)]   
        public systype atanh(systype x)
                => (systype)MathF.Atanh(x);

        public systype gcd(systype lhs, systype rhs)
        {
            while (rhs != Zero)
            {
                var rem = mod(lhs,rhs);
                lhs = rhs;
                rhs = rem;
            }
            return lhs;
        }
        public string bitstring(systype src)
            => src.ToBitString();

    }

    partial class Operations
    {

    }
}
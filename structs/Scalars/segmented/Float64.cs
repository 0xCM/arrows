//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    /// <summary>
    /// Defines a 64-bit floating-point number
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct Float64
    {
        [FieldOffset(0)]
        public double data;

        [FieldOffset(0)]
        public byte x000;

        [FieldOffset(1)]
        public byte x001;

        [FieldOffset(2)]
        public byte x010;

        [FieldOffset(3)]
        public byte x011;

        [FieldOffset(4)]
        public byte x100;

        [FieldOffset(5)]
        public byte x101;

        [FieldOffset(6)]
        public byte x110;

        [FieldOffset(7)]
        public byte x111;

        [FieldOffset(0)]
        public ushort x00;

        [FieldOffset(2)]
        public ushort x01;

        [FieldOffset(4)]
        public ushort x10;

        [FieldOffset(6)]
        public ushort x11;

        [FieldOffset(0)]
        public uint x0;

        [FieldOffset(4)]
        public uint x1;

        [FieldOffset(0)]
        public ulong x;

        [MethodImpl(Inline)]
        public static Float64 From(double src)
            => new Float64(src);

        [MethodImpl(Inline)]
        public static implicit operator Float64(double src)
            => new Float64(src);
        
        [MethodImpl(Inline)]
        public static implicit operator double(Float64 src)
            => src.data;

        [MethodImpl(Inline)]
        public Float64(double src)
            : this()
        {
            this.data = src;
        }

        [MethodImpl(Inline)]
        public Float64 Abs()
        {
            x111 &= 0x7f;
            return this;
        }

        public override string ToString() 
            => data.ToString();

        public string ToString(string format) 
            => data.ToString(format);

        public string ToString(IFormatProvider format) 
            => data.ToString(format);

    }
}
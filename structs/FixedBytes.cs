namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;


    #pragma warning disable 649    
    
    [StructLayout(LayoutKind.Explicit)]
    readonly struct Byte20
    {
        [FieldOffset(0)]
        public readonly byte Byte00;
        
        [FieldOffset(1)]
        public readonly byte Byte01;
        
        [FieldOffset(2)]
        public readonly byte Byte02;
        
        [FieldOffset(3)]
        public readonly byte Byte03;
        
        [FieldOffset(4)]
        public readonly byte Byte04;
        
        [FieldOffset(5)]
        public readonly byte Byte05;

        [FieldOffset(6)]
        public readonly byte Byte06;
        
        [FieldOffset(7)]
        public readonly byte Byte07;
        
        [FieldOffset(8)]
        public readonly byte Byte08;
        
        [FieldOffset(9)]
        public readonly byte Byte09;
        
        [FieldOffset(10)]
        public readonly byte Byte10;
        
        [FieldOffset(11)]
        public readonly byte Byte11;

        [FieldOffset(12)]
        public readonly byte Byte12;

        [FieldOffset(13)]
        public readonly byte Byte13;
        
        [FieldOffset(14)]
        public readonly byte Byte14;
        
        [FieldOffset(15)]
        public readonly byte Byte15;
        
        [FieldOffset(16)]
        public readonly byte Byte16;
        
        [FieldOffset(17)]
        public readonly byte Byte17;
        
        [FieldOffset(18)]
        public readonly byte Byte18;

        [FieldOffset(19)]
        public readonly byte Byte19;

        public ReadOnlySpan<byte> Bytes
            => this.ToBytes(); 
        
        public static Byte20 From(ValueType src )
            => Unsafe.As<ValueType,Byte20>(ref src);
    }



}
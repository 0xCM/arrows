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


    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public ref struct U64 
    {
        public const int BitSize = 64;

        public U64(ulong value)
        {
            this.x000 = 0;
            this.x001 = 0;
            this.x010 = 0;
            this.x011 = 0;
            this.x100 = 0;
            this.x101 = 0;
            this.x110 = 0;
            this.x111 = 0;
            this.x00 = 0;
            this.x01 = 0;
            this.x10 = 0;
            this.x11 = 0;
            this.x0 = 0;
            this.x1 = 0;
            this.value = value;
        }

        [FieldOffset(0)]
        public ulong value;
        
        [FieldOffset(0)]
        public U32 x0;

        [FieldOffset(4)]
        public U32 x1;

        [FieldOffset(0)]
        public U16 x00;

        [FieldOffset(2)]
        public U16 x01;

        [FieldOffset(4)]
        public U16 x10;

        [FieldOffset(6)]
        public U16 x11;

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

    }


}
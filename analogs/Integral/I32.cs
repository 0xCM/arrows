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

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public ref struct I32 
    {
        public I32(int src)
        {
            this.x000 = 0;
            this.x001 = 0;
            this.x010 = 0;
            this.x011 = 0;
            this.x00 = 0;
            this.x01 = 0;
            this.src = src;
        }


        [FieldOffset(0)]
        public int src;

        [FieldOffset(0)]
        public U16 x00;

        [FieldOffset(2)]
        public U16 x01;
        
        [FieldOffset(0)]
        public byte x000;
        
        [FieldOffset(1)]
        public byte x001;
        
        [FieldOffset(2)]
        public byte x010;
        
        [FieldOffset(3)]
        public byte x011;
    }





}
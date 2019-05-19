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
    using static mfunc;

    public static class BitLayouts
    {

        public static U16 Define(ushort src)
            => new U16(src);

        public static I16 Define(short src)
            => new I16(src);

        public static I32 Define(int src)
            => new I32(src);

        public static U32 Define(uint src)
            => new U32(src);

        public static I64 Define(long src)
            => new I64(src);

        public static U64 Define(ulong src)
            => new U64(src);

        [StructLayout(LayoutKind.Explicit, Size = 1)]
        public ref struct I8
        {
            public I8(sbyte src)
            {
                this.x000 = 0;
                this.src =0;                
                this.src = src;
            }
                 
            [FieldOffset(0)]
            public sbyte src;
            
            
            [FieldOffset(0)]
            public byte x000;
            
        }


        [StructLayout(LayoutKind.Explicit, Size = 2)]
        public ref struct I16 
        {
            public I16(short src)
            {
                this.x000 = 0;
                this.x001  =0;                
                this.src = src;
            }
                 
            
            [FieldOffset(0)]
            public short src;
            
            [FieldOffset(0)]
            public byte x000;
                        
            [FieldOffset(1)]
            public byte x001;
        }



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


}
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


        [StructLayout(LayoutKind.Explicit, Size = 2)]
        public struct U16 
        {
            public static implicit operator U16(ushort src)
                => new U16(src);

            public static implicit operator ushort(U16 src)
                => src.src;

            public U16(ushort src)
            {
                this.x000 = 0;
                this.x001  =0;                
                this.src = src;
            }
                 
            
            [FieldOffset(0)]
            public ushort src;
            
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


        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public ref struct U32 
        {
            public const int MinIndex = 0;
            
            public const int MaxIndex = 3;
            
            public static implicit operator U32(uint src)
                => new U32(src);

            public static U32 operator &(U32 lhs, U32 rhs)
                => lhs.src & rhs.src;

            public static U32 operator |(U32 lhs, U32 rhs)
                => lhs.src | rhs.src;

            public static U32 operator ^(U32 lhs, U32 rhs)
                => lhs.src ^ rhs.src;

            public static U32 operator ~(U32 src)
                => ~ src;

            public static U32 operator <<(U32 lhs, int rhs)
                => lhs.src << rhs;

            public static U32 operator >>(U32 lhs, int rhs)
                => lhs.src >> rhs;
                
            public U32(uint x0)
            {
                this.x000 = 0;
                this.x001 = 0;
                this.x010 = 0;
                this.x011 = 0;
                this.x00 = 0;
                this.x01 = 0;
                this.src = x0;
            }

            [FieldOffset(0)]
            public uint src;

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

            public byte this[int offset]
            {
                get => offset switch {
                    0 => x000,
                    1 => x001,
                    2 => x010,
                    3 => x011,
                    _ => throw outOfRange(offset, MinIndex, MaxIndex)
                };
                set 
                {
                    switch(offset)
                    {
                        case 0 : x000 = value; break;
                        case 1 : x001 = value; break;
                        case 2 : x010 = value; break;
                        case 3 : x011 = value; break;
                        default:
                            throw outOfRange(offset, MinIndex, MaxIndex);
                    }
                } 
            }
        }

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public ref struct I64 
        {
            public I64(long src)
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
                this.src = src;
            }

            [FieldOffset(0)]
            public long src;
            
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


        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public ref struct U64 
        {
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
 
        [StructLayout(LayoutKind.Explicit, Size = 128)]
        public struct U128
        {
            [FieldOffset(0)]
            public ulong x0;

            [FieldOffset(8)]
            public ulong x1;

            [FieldOffset(0)]
            public uint x00;

            [FieldOffset(4)]
            public uint x01;

            [FieldOffset(8)]
            public uint x10;

            [FieldOffset(12)]
            public uint x11;

            [FieldOffset(0)]
            public ushort x000;

            [FieldOffset(2)]
            public ushort x001;

            [FieldOffset(4)]
            public ushort x010;

            [FieldOffset(6)]
            public ushort x011;

            [FieldOffset(8)]
            public ushort x100;

            [FieldOffset(10)]
            public ushort x101;

            [FieldOffset(12)]
            public ushort x110;

            [FieldOffset(12)]
            public ushort x111;

            [FieldOffset(0)]        
            public byte x0000;
            
            [FieldOffset(1)]
            public byte x0001;
            
            [FieldOffset(2)]
            public byte x0010;
            
            [FieldOffset(3)]
            public byte x0011;

            [FieldOffset(4)]
            public byte x0100;
            
            [FieldOffset(5)]
            public byte x0101;
            
            [FieldOffset(6)]
            public byte x0110;
            
            [FieldOffset(7)]
            public byte x0111;

            [FieldOffset(8)]        
            public byte x1000;
            
            [FieldOffset(9)]
            public byte x1001;
            
            [FieldOffset(10)]
            public byte x1010;
            
            [FieldOffset(11)]
            public byte x1011;

            [FieldOffset(12)]
            public byte x1100;
            
            [FieldOffset(13)]
            public byte x1101;
            
            [FieldOffset(14)]
            public byte x1110;
            
            [FieldOffset(15)]
            public byte x1111;

        }
 
         
    }


}
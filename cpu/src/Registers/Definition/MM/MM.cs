//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;


    partial class Registers
    {

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public struct MM : IMMReg, ICpuReg128
        {
            public static readonly BitSize BitWidth = 64;        

            public static readonly ByteSize ByteCount = 8;

            [MethodImpl(Inline)]
            public static int PartCount<T>()
                where T : struct => BitWidth/Unsafe.SizeOf<T>();

            [MethodImpl(Inline)]
            public ref T Part<T>(int index)
                where T : struct
                    => ref Unsafe.Add(ref head<T>(), index);



            public Bit this[Index r]
            {
                [MethodImpl(Inline)]
                get
                {
                    RegisterBank.quorem(r.Value, BitWidth, out Quorem<int> qr);
                    return Part<ulong>(qr.Quotient).TestBit((byte)qr.Remainder);                
                }
            }        

            [MethodImpl(Inline)]
            unsafe ref T head<T>()
                where T : struct
            {
                fixed(void* pSrc = &this)
                    return ref Unsafe.AsRef<T>(pSrc);
            }
        
            Bit IMMReg.this[Index r] 
                => this[r];                

            ref T IMMReg.Part<T>(int index)
                => ref Part<T>(index);



            [FieldOffset(0)]        
            public sbyte x0000s;
            
            [FieldOffset(1)]
            public sbyte x0001s;
            
            [FieldOffset(2)]
            public sbyte x0002s;
            
            [FieldOffset(3)]
            public sbyte x0003s;

            [FieldOffset(4)]
            public sbyte x0004s;
            
            [FieldOffset(5)]
            public sbyte x0005s;
            
            [FieldOffset(6)]
            public sbyte x0006s;
            
            [FieldOffset(7)]
            public sbyte x0007s;
            
            [FieldOffset(0)]        
            public byte x0000;
            
            [FieldOffset(1)]
            public byte x0001;
            
            [FieldOffset(2)]
            public byte x0002;
            
            [FieldOffset(3)]
            public byte x0003;

            [FieldOffset(4)]
            public byte x0004;
            
            [FieldOffset(5)]
            public byte x0005;
            
            [FieldOffset(6)]
            public byte x0006;
            
            [FieldOffset(7)]
            public byte x0007;
            
            [FieldOffset(0)]        
            public ushort x000;
            
            [FieldOffset(2)]
            public ushort x001;
            
            [FieldOffset(4)]
            public ushort x002;
            
            [FieldOffset(6)]
            public ushort x003;

            [FieldOffset(0)]        
            public short x000s;
            
            [FieldOffset(2)]
            public short x001s;
            
            [FieldOffset(4)]
            public short x002s;
            
            [FieldOffset(6)]
            public short x003s;


            [FieldOffset(0)]
            public int x00s;

            [FieldOffset(4)]
            public int x01s;

            
            [FieldOffset(0)]
            public uint x00;

            [FieldOffset(4)]
            public uint x01;


            [FieldOffset(0)]
            public long x0s;


            [FieldOffset(0)]
            public ulong x0;
        }
    }    
}
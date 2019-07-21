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

   [StructLayout(LayoutKind.Explicit, Size = ByteSize)]
    public ref struct __m512
    {
        public const int ByteSize = 64;

        public static int PartCount<T>()
            where T : struct => ByteSize/Unsafe.SizeOf<T>();

        #region F32

        [FieldOffset(0)]
        public float x00f;

        [FieldOffset(4)]
        public float x01f;

        [FieldOffset(8)]
        public float x02f;

        [FieldOffset(12)]
        public float x03f;

        [FieldOffset(16)]
        public float x04f;

        [FieldOffset(20)]
        public float x05f;

        [FieldOffset(24)]
        public float x06f;

        [FieldOffset(28)]
        public float x07f;

        [FieldOffset(32)]
        public float x08f;

        [FieldOffset(36)]
        public float x09f;

        [FieldOffset(40)]
        public float x0Af;

        [FieldOffset(44)]
        public float x0Bf;

        [FieldOffset(48)]
        public float x0Cf;

        [FieldOffset(52)]
        public float x0Df;

        [FieldOffset(56)]
        public float x0Ef;

        [FieldOffset(60)]
        public float x0Ff;
        
        #endregion

        #region F64

        
        #endregion  
 
        [MethodImpl(Inline)]
        unsafe ref T head<T>()
            where T : struct
        {
            fixed(void* pSrc = &this)
                return ref Unsafe.AsRef<T>(pSrc);
        }

        [MethodImpl(Inline)]
        public ref T part<T>(int pos)
            where T : struct
                => ref Unsafe.Add(ref head<T>(), pos);
            
        public Bit this[Index r]
        {
            [MethodImpl(Inline)]
            get
            {
                var pos = BitPos<ulong>.FromIndex((uint)r.Value);
                return part<ulong>(pos.SegIdx).TestBit(pos.BitOffset);                
            }
        }        
    }
}
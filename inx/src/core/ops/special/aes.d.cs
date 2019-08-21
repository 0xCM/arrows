//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Sse42;
    using static System.Runtime.Intrinsics.X86.Sse42.X64;
            

    using static zfunc;    

    public partial class dinx
    {

        public static uint crc(uint crc, byte data)
            => Crc32(crc,data);

        public static uint crc(uint crc, ushort data)
            => Crc32(crc,data);

        public static uint crc(uint crc, uint data)
            => Crc32(crc,data);

        public static ulong crc(uint crc, ulong data)
            => Crc32(crc,data);


        [MethodImpl(Inline)]
        public static Vec128<byte> encrypt(Vec128<byte> src,Vec128<byte> key)
            => Aes.Encrypt(src,key);


        [MethodImpl(Inline)]
        public static Vec128<byte> encryptLast(Vec128<byte> src,Vec128<byte> key)
            => Aes.EncryptLast(src,key);


        [MethodImpl(Inline)]
        public static Vec128<byte> decrypt(Vec128<byte> src,Vec128<byte> key)
            => Aes.Decrypt(src,key);

        [MethodImpl(Inline)]
        public static Vec128<byte> decryptLast(Vec128<byte> src,Vec128<byte> key)
            => Aes.DecryptLast(src,key);

        [MethodImpl(Inline)]
        public static Vec128<byte> keygen(Vec128<byte> src,byte control)
            => Aes.KeygenAssist(src,control);
    }

}
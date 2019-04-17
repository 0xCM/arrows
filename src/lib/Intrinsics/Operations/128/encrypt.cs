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
    
    using static zcore;
    using static inX;

    public partial class InX
    {
        [MethodImpl(Inline)]
        public static Vec128<byte> encrypt(Vec128<byte> src,Vec128<byte> key)
            => Aes.Encrypt(src,key);


        [MethodImpl(Inline)]
        public static Vec128<byte> encryptLast(Vec128<byte> src,Vec128<byte> key)
            => Aes.EncryptLast(src,key);

    }


}
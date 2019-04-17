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
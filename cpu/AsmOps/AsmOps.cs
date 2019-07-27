//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static class AsmOps
    {
        /// <summary>
        /// Invokes the asm code for int32 addition
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static int Add(int x, int y)
            => AsmCodeBank.Add32I.CreateBinOp<int>()(x,y);
 
        /// <summary>
        /// Invokes the asm code for int8 bitwise and
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static sbyte And(sbyte x, sbyte y)
            => AsmCodeBank.And8I.CreateBinOp<sbyte>()(x,y);

        /// <summary>
        /// Invokes the asm code for uint8 bitwise and
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static byte And(byte x, byte y)
            => AsmCodeBank.And8U.CreateBinOp<byte>()(x,y);

    }


}
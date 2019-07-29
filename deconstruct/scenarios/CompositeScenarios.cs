//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using static zfunc;


    [DisplayName("scenarios-composite")]
    class CompositScenarios
    {

        #region rot

        public static byte rotr8u(byte src, byte offset)
            => (byte) ((src >> (int)offset) | (src << (8 - offset)));

        public static ushort rotr16u(ushort src, ushort offset)
            => (ushort) ((src >> (int)offset) | (src << (16 - offset)));

        public static uint rotr32u(uint src, uint offset)
            => (src >> (int)offset) | (src << (32 - (int)offset));

        public static ulong rotr64u(ulong src, ulong offset)
            => (src >> (int)offset) | (src << (64 - (int)offset));

        public static byte rotl8u(byte x, byte offset)
            => (byte)((x << (int)offset) | (x >> (int)(8 - offset)));

        public static ushort rotl16u(ushort x, ushort offset)
            => (ushort)(((uint)x << (int)offset) | ((uint)x >> (16 - offset)));

        public static uint rotl32u(uint x, uint offset)
            => (x << (int)offset) | (x >> (int)(32 - offset));

        public static ulong rotl64u(ulong x, ulong offset)
            => (x << (int)offset) | (x >> (int)(64 - offset));


        #endregion


    }

}
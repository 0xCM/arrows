//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static Bits;

    partial class BitsX
    {

        [MethodImpl(Inline)]
        public static ref byte ToggleBit(this ref byte src, int pos)
        {
            toggle(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref sbyte ToggleBit(this ref sbyte src, int pos)
        {
            toggle(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short ToggleBit(this ref short src, int pos)
        {
            toggle(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort ToggleBit(this ref ushort src, int pos)
        {
            toggle(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref int ToggleBit(this ref int src, int pos)
        {
            toggle(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint ToggleBit(this ref uint src, int pos)
        {
            toggle(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long ToggleBit(this ref long src, int pos)
        {
            toggle(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong ToggleBit(this ref ulong src, int pos)
        {
            toggle(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref float ToggleBit(this ref float src, int pos)
        {
            toggle(ref src, pos);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref double ToggleBit(this ref double src, int pos)
        {
            toggle(ref src, pos);
            return ref src;
        }
    }
}
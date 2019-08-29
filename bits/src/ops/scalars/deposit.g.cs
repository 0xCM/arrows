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
    using static As;
    using static AsIn;

    public static partial class gbits
    {
        [MethodImpl(Inline)]
        public static T deposit<T>(in T src, T mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.deposit(in uint8(in src), uint8(mask)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.deposit(in uint16(in src), uint16(mask)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.deposit(in uint32(in src), uint32(mask)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.deposit(in uint64(in src), uint64(mask)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Deposits mask-identified bits from the source
        /// </summary>
        /// <param name="src">The source/target value</param>
        /// <param name="mask"></param>
        /// <typeparam name="T">The identifiying mask</typeparam>
        [MethodImpl(Inline)]
        public static ref T deposit<T>(ref T src, in T mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                Bits.deposit(ref uint8(ref src), in uint8(in mask));
            else if(typeof(T) == typeof(ushort))
                Bits.deposit(ref uint16(ref src), in uint16(in mask));
            else if(typeof(T) == typeof(uint))
                Bits.deposit(ref uint32(ref src), in uint32(in mask));
            else if(typeof(T) == typeof(ulong))
                Bits.deposit(ref uint64(ref src), in uint64(in mask));
            else            
                throw unsupported<T>();
            return ref src;
        }


    }
}
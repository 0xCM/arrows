//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;


    public static class Imm
    {
        /// <summary>
        /// Creates a generic immediate
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static Imm<T> Define<T>(T src)
            where T : struct
                => new Imm<T>(src);

        [MethodImpl(Inline)]
        public static IImm<Imm8,byte> Define(byte src)
            => Imm8.Define(src);

        [MethodImpl(Inline)]
        public static IImm<Imm16,ushort> Define(ushort src)
            => Imm16.Define(src);

        [MethodImpl(Inline)]
        public static IImm<Imm32,uint> Define(uint src)
            => Imm32.Define(src);

        [MethodImpl(Inline)]
        public static IImm<Imm64,ulong> Define(ulong src)
            => Imm64.Define(src);
        
        [MethodImpl(Inline)]
        public static void SignExtend<T>(byte src, out T dst)
            where T : struct, IImm<T>
        {
            if(typeof(T) == typeof(short))
            {
                var imm = Imm16i.Define(src);
                dst = Unsafe.As<Imm16i,T>(ref imm);
            }
            else if(typeof(T) == typeof(int))
            {
                var imm = Imm32i.Define(src);
                dst = Unsafe.As<Imm32i,T>(ref imm);
            }
            else if(typeof(T) == typeof(long))
            {
                var imm = Imm64i.Define(src);
                dst = Unsafe.As<Imm64i,T>(ref imm);
            }
            else 
                throw unsupported<T>();
        }
    }

}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class RegisterBank
    {
        public static RegisterBank<T> Define<T>(int count)
            where T : struct
                => new RegisterBank<T>(count);

        public static RegisterBank<T> Define<T>(params T[] registers)
            where T : struct
                => new RegisterBank<T>(registers);

        [MethodImpl(Inline)]
        internal static ref Quorem<int> quorem(in int lhs, in int rhs, out Quorem<int> dst)
        {
            var x = math.abs(lhs);
            var y = math.abs(rhs);
            var quo = x / y;
            var rem = x - quo*y;
            dst = Quorem.define(in quo, in rem);                   
            return ref dst;
        }

    }


    /// <summary>
    /// Defines a sequence of registers
    /// </summary>
    public struct RegisterBank<T>
        where T : struct
    {
        public RegisterBank(int count)
        {
            Registers = new T[count];
        }

        public RegisterBank(params T[] registers)
        {
            Registers = registers;
        }

        T[] Registers;

        [MethodImpl(Inline)]
        int check(int index)
            => index < Registers.Length ? index : throw Errors.OutOfRange(index, 0, index - 1);

        public ref T this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Register(index);
        }

        [MethodImpl(Inline)]
        public ref T Register(int index)
            => ref Registers[check(index)];    
        
        public void Reset()
        {
            for(var i=0; i<Registers.Length; i++)
                Registers[i] = default;
        }
    }


 

}
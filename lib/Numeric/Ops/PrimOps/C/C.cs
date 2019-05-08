//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using static zcore;
    using static zfunc;

    partial class C
    {
        

        public static readonly C Inhabitant = new C();

        static Dictionary<Type,object> prototypes = new Dictionary<Type, object>
        {
            [type<sbyte>()] = int8.Zero,
            [type<short>()] = int16.Zero,
            [type<int>()] = int32.Zero,
            [type<long>()] = int64.Zero,
            [type<byte>()] = uint8.Zero,
            [type<ushort>()] = uint16.Zero,
            [type<uint>()] = uint32.Zero,
            [type<ulong>()] = uint64.Zero,
        };
        
        static readonly object ops = Inhabitant;


        public static RealCalc<T> realcalc<T>()
            where T : RealNum<T>, new()
            => (RealCalc<T>)ops;

        public static S number<S,T>(T src)
            where S : ICNumber<S,T>, new()
            => ((S)prototypes[type<T>()]).revalue(src);
            
        public static IEnumerable<S> numbers<S,T>(IEnumerable<T> src)
            where S : ICNumber<S,T>, new()
            => ((S)prototypes[type<T>()]).wrap(src);


        [MethodImpl(Inline)]
        public static int8 z8(sbyte x)
            => x;


        [MethodImpl(Inline)]
        public static uint8 u8(byte x)
            => x;


        [MethodImpl(Inline)]
        public static int16 z16(short x)
            => x;

        [MethodImpl(Inline)]
        public static uint16 u16(ushort x)
            => x;


        [MethodImpl(Inline)]
        public static int32 z32(int x)
            => x;


        [MethodImpl(Inline)]
        public static uint32 u32(uint x)
            => x;


        [MethodImpl(Inline)]
        public static int64 z64(long x)
            => x;
   

        [MethodImpl(Inline)]
        public static uint64 u64(ulong x)
            => x; 
    }

}
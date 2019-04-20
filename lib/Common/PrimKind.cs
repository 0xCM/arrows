//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zcore;

    public enum PrimKind : byte
    {
        none = 0,
        
        int8 = 1,

        uint8 = 2,

        int16 = 3,

        uint16 = 4,        

        int32 = 5,
        
        uint32 = 6,

        int64 = 7,

        uint64 = 8,
                            
        float32 = 9,

        float64 = 10,  

        float128 = 11,

        last = float64      
    }

    public static class PrimKinds
    {
        static readonly Type[] Kinds = 
            new Type[]{
                typeof(void),       // 0 = none
                typeof(sbyte),      // 1 = int8
                typeof(byte),       // 2 = uint8
                typeof(short),      // 3 = int16
                typeof(ushort),     // 4 = uint16
                typeof(int),        // 5 = int32
                typeof(uint),       // 6 = uint32
                typeof(long),       // 7 = int64
                typeof(ulong),      // 8 = uint64
                typeof(float),      // 9 = float32
                typeof(double),     // 10 = float64
                };

        [MethodImpl(Inline)]
        public static Type type(PrimKind kind)
            => Kinds[(int)kind];

        [MethodImpl(Inline)]
        public static Type type(int kind)
            => Kinds[kind];            

        [MethodImpl(Inline)]
        public static PrimKind kind(Type t)
        {
            for(var i =1; i<= (int)PrimKind.last; i++)
            {
                if(Kinds[i] == t)
                    return (PrimKind)i;
            }
            return PrimKind.none;
        }

        [MethodImpl(Inline)]
        public static PrimKind kind<T>()
            => kind(typeof(T));

    }

    partial class xcore
    {
        [MethodImpl(Inline)]
        public static PrimKind PrimKind(this Type src)
            => PrimKinds.kind(src);

        [MethodImpl(Inline)]
        public static Type PrimType(this PrimKind src)
            => PrimKinds.type(src);
    }

    public readonly struct PrimAction<T>
        where T : struct, IEquatable<T>
    {

    }

    public static class PrimFunc
    {
        public static PrimFunc<P> define<P>(Func<P> f)
            where P : struct, IEquatable<P>
                => new PrimFunc<P>(f);

        public static PrimFunc<R,P> define<P>(Func<R,P> f)
            where P : struct, IEquatable<P>
                => new PrimFunc<R,P>(f);

        public static PrimFunc<R,P1,P2> define<R,P1,P2>(Func<R,P1,P2> f)
            where P1 : struct, IEquatable<P1>
            where P2 : struct, IEquatable<P2>
                => new PrimFunc<R,P1,P2>(f);

    }
 
    public readonly struct PrimFunc<P>
        where P : struct, IEquatable<P>
    {

        public PrimFunc(Func<P> src)
            => apply = src;

        public readonly Func<P> apply;

    }

    public readonly struct PrimFunc<R,P>
        where P : struct, IEquatable<P>
    {
        public PrimFunc(Func<R,P> src)
            => apply = src;

        public readonly Func<R,P> apply;

    }

    public readonly struct PrimFunc<R,P1,P2>
        where P1 : struct, IEquatable<P1>
        where P2 : struct, IEquatable<P2>
    {
        public PrimFunc(Func<R,P1,P2> src)
            => apply = src;

        public readonly Func<R,P1,P2> apply;

    }
}
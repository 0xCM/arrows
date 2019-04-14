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
    using static Operative;

    using Target = System.SByte;
    using TargetStream = System.Collections.Generic.IEnumerable<sbyte>;
    using TargetList = System.Collections.Generic.IReadOnlyList<sbyte>;
    
    partial class ClrConverters
    {        
        public readonly struct ToClrInt8 : 
            Conversion<sbyte, Target>, 
            Conversion<byte, Target>, 
            Conversion<short, Target>, 
            Conversion<ushort, Target>, 
            Conversion<int, Target>, 
            Conversion<uint, Target>, 
            Conversion<long, Target>, 
            Conversion<ulong, Target>,
            Conversion<float, Target>, 
            Conversion<double, Target>, 
            Conversion<decimal, Target>,
            Conversion<BigInteger, Target>
        {
            public static readonly ToClrInt8 Inhabitant = default;
            
            public static readonly Type TargetType = typeof(Target);

            [MethodImpl(Inline)]
            public Target convert(byte src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(byte src, out Target dst)
                => dst = (Target)src;

            [MethodImpl(Inline)]
            public Target convert(sbyte src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(sbyte src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(short src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(short src, out Target dst)
                => dst = (Target)src;

            [MethodImpl(Inline)]
            public Target convert(ushort src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(ushort src, out Target dst)
                => dst = (Target)src;

            [MethodImpl(Inline)]
            public Target convert(int src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(int src, out Target dst)
                => dst = (Target)src;

            [MethodImpl(Inline)]
            public Target convert(uint src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(uint src, out Target dst)
                => dst = (Target)src;

            [MethodImpl(Inline)]
            public Target convert(long src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(long src, out Target dst)
                => dst = (Target)src;

            [MethodImpl(Inline)]
            public Target convert(ulong src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(ulong src, out Target dst)
                => dst = (Target)src;

            [MethodImpl(Inline)]
            public Target convert(float src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(float src, out Target dst)
                => dst = (Target)src;

            [MethodImpl(Inline)]
            public Target convert(double src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(double src, out Target dst)
                => dst = (Target)src;

            [MethodImpl(Inline)]
            public Target convert(decimal src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(decimal src, out Target dst)
                => dst = (Target)src;

            [MethodImpl(Inline)]
            public Target convert(BigInteger src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(BigInteger src, out Target dst)
                => dst = (Target)src;
        }

    }
}
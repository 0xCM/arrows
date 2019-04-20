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
    using System.Text;


    using static zcore;
    using static Operative;
    
    using Target = System.Decimal;
    using TargetStream = System.Collections.Generic.IEnumerable<decimal>;
    using TargetList = System.Collections.Generic.IReadOnlyList<decimal>;

    
    partial class ClrConverters
    {        
        public readonly struct ToClrDecimal : 
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
            public static readonly ToClrDecimal Inhabitant = default;

            public static readonly Type TargetType = typeof(Target);

            [MethodImpl(Inline)]
            public Target convert(byte src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(byte src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(sbyte src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(sbyte src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(short src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(short src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(ushort src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(ushort src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(int src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(int src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(uint src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(uint src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(long src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(long src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(ulong src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(ulong src, out Target dst)
                => dst = src;

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
                => src;

            [MethodImpl(Inline)]
            public Target convert(decimal src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(BigInteger src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(BigInteger src, out Target dst)
                => dst = (Target)src;
        }

    }
}
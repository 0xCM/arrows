//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;

    partial class PrimOps { partial class Reify {

            public readonly struct Parser :
                Parser<byte>,
                Parser<sbyte>,
                Parser<short>,
                Parser<ushort>,
                Parser<int>,
                Parser<uint>,
                Parser<long>,
                Parser<ulong>,
                Parser<float>,
                Parser<double>,
                Parser<decimal>,
                Parser<BigInteger>
            {

                public static readonly Parser Inhabitant = default;
                
                [MethodImpl(Inline)]
                public static Parser<T> Operator<T>() 
                    => cast<Parser<T>>(Inhabitant);

                [MethodImpl(Inline)]
                byte Parser<byte>.parse(string src)
                    => byte.Parse(src);

                [MethodImpl(Inline)]
                sbyte Parser<sbyte>.parse(string src)
                    => sbyte.Parse(src);

                [MethodImpl(Inline)]
                ushort Parser<ushort>.parse(string src)
                    => ushort.Parse(src);

                [MethodImpl(Inline)]
                short Parser<short>.parse(string src)
                    => short.Parse(src);

                [MethodImpl(Inline)]
                int Parser<int>.parse(string src)
                    => int.Parse(src);

                [MethodImpl(Inline)]
                uint Parser<uint>.parse(string src)
                    => uint.Parse(src);

                [MethodImpl(Inline)]
                long Parser<long>.parse(string src)
                    => long.Parse(src);

                [MethodImpl(Inline)]
                ulong Parser<ulong>.parse(string src)
                    => ulong.Parse(src);

                [MethodImpl(Inline)]
                float Parser<float>.parse(string src)
                    => float.Parse(src);

                [MethodImpl(Inline)]
                double Parser<double>.parse(string src)
                    => double.Parse(src);

                decimal Parser<decimal>.parse(string src)
                    => decimal.Parse(src);

                [MethodImpl(Inline)]
                BigInteger Parser<BigInteger>.parse(string src)
                    => BigInteger.Parse(src);

                [MethodImpl(Inline)]
                Option<byte> Parser<byte>.tryParse(string src)
                     => Try( () => byte.Parse(src));

                [MethodImpl(Inline)]
                Option<sbyte> Parser<sbyte>.tryParse(string src)
                     => Try( () => sbyte.Parse(src));

                [MethodImpl(Inline)]
                Option<ushort> Parser<ushort>.tryParse(string src)
                     => Try( () => ushort.Parse(src));

                [MethodImpl(Inline)]
                Option<short> Parser<short>.tryParse(string src)
                     => Try( () => short.Parse(src));

                [MethodImpl(Inline)]
                Option<int> Parser<int>.tryParse(string src)
                     => Try( () => int.Parse(src));

                [MethodImpl(Inline)]
                Option<uint> Parser<uint>.tryParse(string src)
                     => Try( () => uint.Parse(src));

                [MethodImpl(Inline)]
                Option<long> Parser<long>.tryParse(string src)
                     => Try( () => long.Parse(src));

                [MethodImpl(Inline)]
                Option<ulong> Parser<ulong>.tryParse(string src)
                     => Try( () => ulong.Parse(src));

                [MethodImpl(Inline)]
                Option<float> Parser<float>.tryParse(string src)
                     => Try( () => float.Parse(src));

                [MethodImpl(Inline)]
                Option<double> Parser<double>.tryParse(string src)
                     => Try( () => double.Parse(src));

                [MethodImpl(Inline)]
                Option<decimal> Parser<decimal>.tryParse(string src)
                     => Try( () => decimal.Parse(src));

                [MethodImpl(Inline)]
                Option<BigInteger> Parser<BigInteger>.tryParse(string src)
                     => Try( () => BigInteger.Parse(src));
            }

        }
    }
}
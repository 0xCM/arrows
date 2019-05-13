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
    using static zfunc;


    using static Operative;

    partial class PrimOps { partial class Reify {

            public readonly struct Parser :
                IParser<byte>,
                IParser<sbyte>,
                IParser<short>,
                IParser<ushort>,
                IParser<int>,
                IParser<uint>,
                IParser<long>,
                IParser<ulong>,
                IParser<float>,
                IParser<double>,
                IParser<decimal>,
                IParser<BigInteger>
            {

                public static readonly Parser Inhabitant = default;
                
                [MethodImpl(Inline)]
                public static IParser<T> Operator<T>() 
                    => cast<IParser<T>>(Inhabitant);

                [MethodImpl(Inline)]
                byte IParser<byte>.parse(string src)
                    => byte.Parse(src);

                [MethodImpl(Inline)]
                sbyte IParser<sbyte>.parse(string src)
                    => sbyte.Parse(src);

                [MethodImpl(Inline)]
                ushort IParser<ushort>.parse(string src)
                    => ushort.Parse(src);

                [MethodImpl(Inline)]
                short IParser<short>.parse(string src)
                    => short.Parse(src);

                [MethodImpl(Inline)]
                int IParser<int>.parse(string src)
                    => int.Parse(src);

                [MethodImpl(Inline)]
                uint IParser<uint>.parse(string src)
                    => uint.Parse(src);

                [MethodImpl(Inline)]
                long IParser<long>.parse(string src)
                    => long.Parse(src);

                [MethodImpl(Inline)]
                ulong IParser<ulong>.parse(string src)
                    => ulong.Parse(src);

                [MethodImpl(Inline)]
                float IParser<float>.parse(string src)
                    => float.Parse(src);

                [MethodImpl(Inline)]
                double IParser<double>.parse(string src)
                    => double.Parse(src);

                decimal IParser<decimal>.parse(string src)
                    => decimal.Parse(src);

                [MethodImpl(Inline)]
                BigInteger IParser<BigInteger>.parse(string src)
                    => BigInteger.Parse(src);

                [MethodImpl(Inline)]
                Option<byte> IParser<byte>.tryParse(string src)
                     => Try( () => byte.Parse(src));

                [MethodImpl(Inline)]
                Option<sbyte> IParser<sbyte>.tryParse(string src)
                     => Try( () => sbyte.Parse(src));

                [MethodImpl(Inline)]
                Option<ushort> IParser<ushort>.tryParse(string src)
                     => Try( () => ushort.Parse(src));

                [MethodImpl(Inline)]
                Option<short> IParser<short>.tryParse(string src)
                     => Try( () => short.Parse(src));

                [MethodImpl(Inline)]
                Option<int> IParser<int>.tryParse(string src)
                     => Try( () => int.Parse(src));

                [MethodImpl(Inline)]
                Option<uint> IParser<uint>.tryParse(string src)
                     => Try( () => uint.Parse(src));

                [MethodImpl(Inline)]
                Option<long> IParser<long>.tryParse(string src)
                     => Try( () => long.Parse(src));

                [MethodImpl(Inline)]
                Option<ulong> IParser<ulong>.tryParse(string src)
                     => Try( () => ulong.Parse(src));

                [MethodImpl(Inline)]
                Option<float> IParser<float>.tryParse(string src)
                     => Try( () => float.Parse(src));

                [MethodImpl(Inline)]
                Option<double> IParser<double>.tryParse(string src)
                     => Try( () => double.Parse(src));

                [MethodImpl(Inline)]
                Option<decimal> IParser<decimal>.tryParse(string src)
                     => Try( () => decimal.Parse(src));

                [MethodImpl(Inline)]
                Option<BigInteger> IParser<BigInteger>.tryParse(string src)
                     => Try( () => BigInteger.Parse(src));
            }

        }
    }
}
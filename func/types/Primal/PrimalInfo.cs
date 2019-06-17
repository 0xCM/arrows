//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public interface IPrimalInfoProvider<T>
    {
        PrimalInfo<T> PrimalInfo {get;}
    }

    public readonly struct PrimalInfo : 
        IPrimalInfoProvider<byte>, 
        IPrimalInfoProvider<sbyte>, 
        IPrimalInfoProvider<short>,
        IPrimalInfoProvider<ushort>, 
        IPrimalInfoProvider<int>,
        IPrimalInfoProvider<uint>,
        IPrimalInfoProvider<long>,
        IPrimalInfoProvider<ulong>,            
        IPrimalInfoProvider<float>, 
        IPrimalInfoProvider<double>, 
        IPrimalInfoProvider<decimal>,
        IPrimalInfoProvider<BigInteger>                    
    {
        static readonly PrimalInfo Inhabitant = default;

        [MethodImpl(Inline)]
        public static PrimalInfo<T> Get<T>()
            => Provider<T>().PrimalInfo;            

        [MethodImpl(Inline)]
        public static T zero<T>()
            => Get<T>().Zero;

        [MethodImpl(Inline)]
        public static T one<T>()
            => Get<T>().One;

        [MethodImpl(Inline)]
        public static T minval<T>()
            => Get<T>().MinVal;

        [MethodImpl(Inline)]
        public static T maxval<T>()
            => Get<T>().MaxVal;

        [MethodImpl(Inline)]
        public static bool signed<T>()
            => Get<T>().Signed;

        [MethodImpl(Inline)]
        public static bool unsigned<T>()
            => !Get<T>().Signed;

        [MethodImpl(Inline)]
        public static BitSize bitsize<T>()
            => Get<T>().BitSize;

        [MethodImpl(Inline)]
        public static ByteSize bytesize<T>()
            => Get<T>().ByteSize;

        [MethodImpl(Inline)]
        static IPrimalInfoProvider<T> Provider<T>() 
            => cast<IPrimalInfoProvider<T>>(Inhabitant);

        PrimalInfo<sbyte> IPrimalInfoProvider<sbyte>.PrimalInfo 
            => Int8Info.Summary;

        PrimalInfo<byte> IPrimalInfoProvider<byte>.PrimalInfo 
            => UInt8Info.Summary;

        PrimalInfo<short> IPrimalInfoProvider<short>.PrimalInfo 
            => Int16Info.Summary;

        PrimalInfo<ushort> IPrimalInfoProvider<ushort>.PrimalInfo 
            => UInt16Info.Summary;

        PrimalInfo<int> IPrimalInfoProvider<int>.PrimalInfo 
            => Int32Info.Summary;

        PrimalInfo<uint> IPrimalInfoProvider<uint>.PrimalInfo 
            => UInt32Info.Summary;

        PrimalInfo<long> IPrimalInfoProvider<long>.PrimalInfo 
            => Int64Info.Summary;

        PrimalInfo<ulong> IPrimalInfoProvider<ulong>.PrimalInfo 
            => UInt64Info.Summary;

        PrimalInfo<float> IPrimalInfoProvider<float>.PrimalInfo 
            => Float32Info.Summary;

        PrimalInfo<double> IPrimalInfoProvider<double>.PrimalInfo 
            => Float64Info.Summary;

        PrimalInfo<decimal> IPrimalInfoProvider<decimal>.PrimalInfo 
            => DecimalInfo.Summary;

        PrimalInfo<BigInteger> IPrimalInfoProvider<BigInteger>.PrimalInfo 
            => BigIntegerInfo.Summary;

    }

    readonly struct Int8Info
    {
        public const sbyte Zero = 0;

        public const sbyte One = 1;

        public const uint BitSize = 8;

        public const sbyte MinVal = sbyte.MinValue;            

        public const sbyte MaxVal = sbyte.MaxValue;

        public const bool Signed = true;
        
        public static readonly PrimalInfo<sbyte> Summary 
            = new PrimalInfo<sbyte>((MinVal,MaxVal), Signed, Zero, One, BitSize);
    }            

    readonly struct UInt8Info
    {
        public const byte Zero = 0;

        public const byte One = 1;

        public const uint BitSize = 8;

        public const byte MinVal = byte.MinValue;            

        public const byte MaxVal = byte.MaxValue;

        public const bool Signed = false;
        
        public static readonly PrimalInfo<byte> Summary 
            = new PrimalInfo<byte>((MinVal,MaxVal), Signed, Zero, One, BitSize);
    }            

    readonly struct Int16Info
    {
        public const short Zero = 0;

        public const short One = 1;

        public const uint BitSize = 16;

        public const short MinVal = short.MinValue;            

        public const short MaxVal = short.MaxValue;

        public const bool Signed = true;
        
        public static readonly PrimalInfo<short> Summary 
            = new PrimalInfo<short>((MinVal,MaxVal), Signed, Zero, One, BitSize);
    }            

    readonly struct UInt16Info
    {
        public const ushort Zero = 0;

        public const ushort One = 1;

        public const uint BitSize = 16;

        public const ushort MinVal = ushort.MinValue;            

        public const ushort MaxVal = ushort.MaxValue;

        public const bool Signed = false;
        
        public static readonly PrimalInfo<ushort> Summary 
            = new PrimalInfo<ushort>((MinVal,MaxVal), Signed, Zero, One, BitSize);
    }            

    readonly struct Int32Info
    {
        public const int Zero = 0;

        public const int One = 1;

        public const uint BitSize = 32;

        public const int MinVal = int.MinValue;            

        public const int MaxVal = int.MaxValue;

        public const bool Signed = true;
        
        public static readonly PrimalInfo<int> Summary 
            = new PrimalInfo<int>((MinVal,MaxVal), Signed, Zero, One, BitSize);
    }            

    readonly struct UInt32Info
    {
        public const uint Zero = 0;

        public const uint One = 1;

        public const uint BitSize = 32;

        public const uint MinVal = uint.MinValue;            

        public const uint MaxVal = uint.MaxValue;

        public const bool Signed = false;
        
        public static readonly PrimalInfo<uint> Summary 
            = new PrimalInfo<uint>((MinVal,MaxVal), Signed, Zero, One, BitSize);
    }            

    readonly struct Int64Info
    {
        public const long Zero = 0;

        public const long One = 1;

        public const uint BitSize = 64;

        public const long MinVal = long.MinValue;            

        public const long MaxVal = long.MaxValue;

        public const bool Signed = true;
        
        public static readonly PrimalInfo<long> Summary 
            = new PrimalInfo<long>((MinVal,MaxVal), Signed, Zero, One, BitSize);
    }            

    readonly struct UInt64Info
    {
        public const ulong Zero = 0;

        public const ulong One = 1;

        public const uint BitSize = 64;

        public const ulong MinVal = ulong.MinValue;            

        public const ulong MaxVal = ulong.MaxValue;

        public const bool Signed = false;
        
        public static readonly PrimalInfo<ulong> Summary 
            = new PrimalInfo<ulong>((MinVal,MaxVal), Signed, Zero, One, BitSize);
    }            

    readonly struct Float32Info
    {
        public const float Zero = 0;

        public const float One = 1;

        public const uint BitSize = 32;

        public const float MinVal = float.MinValue;            

        public const float MaxVal = float.MaxValue;

        public const float Epsilon = float.Epsilon;

        public const bool Signed = true;
        
        public static readonly PrimalInfo<float> Summary 
            = new PrimalInfo<float>((MinVal,MaxVal), Signed, Zero, One, BitSize, Epsilon);
    }        

    readonly struct Float64Info
    {
        public const double Zero = 0;

        public const double One = 1;

        public const uint BitSize = 64;

        public const double MinVal = double.MinValue;            

        public const double MaxVal = double.MaxValue;

        public const double Epsilon = double.Epsilon;

        public const bool Signed = true;
        
        public static readonly PrimalInfo<double> Summary 
            = new PrimalInfo<double>((MinVal,MaxVal), Signed, Zero, One, BitSize,Epsilon);
    }            

    readonly struct DecimalInfo
    {
        public const decimal Zero = 0;

        public const decimal One = 1;

        public const uint BitSize = sizeof(decimal) * 8;

        public const decimal MinVal = decimal.MinValue;            

        public const decimal MaxVal = decimal.MaxValue;

        public const bool Signed = true;
        
        public static readonly PrimalInfo<decimal> Summary 
            = new PrimalInfo<decimal>((MinVal,MaxVal), Signed, Zero, One, BitSize);
    }                

    readonly struct BigIntegerInfo
    {
        public static readonly BigInteger Zero = BigInteger.Zero;

        public static readonly BigInteger One = BigInteger.One;

        public const uint BitSize = 0;

        public const bool Signed = true;
        
        public static readonly PrimalInfo<BigInteger> Summary 
            = new PrimalInfo<BigInteger>((0,0), Signed, Zero, One, BitSize,0,true);
    }                   

    public readonly struct PrimalInfo<T>
    {
        public PrimalInfo((T min, T max) range, bool signed, T zero, T one, uint bitsize, T epsilon = default, bool infinite = false)
        {
            this.MinVal = range.min;
            this.MaxVal = range.max;
            this.Signed = signed;
            this.One = one;
            this.Zero = zero;
            this.BitSize = bitsize;
            this.Infinite = infinite;
            this.Epsilon = epsilon != default ? some(epsilon) : none<T>();
            this.ByteSize = BitSize;
        }

        public T MinVal {get;}
        
        public T MaxVal {get;}
        
        public bool Signed {get;}

        public T One {get;}

        public T Zero {get;}

        public Option<T> Epsilon {get;}

        public BitSize BitSize {get;}

        public ByteSize ByteSize {get;}
        
        public bool Infinite {get;}
        
    }

}
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
        public readonly struct NumInfo : 
            NumInfoProvider<byte>, 
            NumInfoProvider<sbyte>, 
            NumInfoProvider<short>,
            NumInfoProvider<ushort>, 
            NumInfoProvider<int>,
            NumInfoProvider<uint>,
            NumInfoProvider<long>,
            NumInfoProvider<ulong>,            
            NumInfoProvider<float>, 
            NumInfoProvider<double>, 
            NumInfoProvider<decimal>,
            NumInfoProvider<BigInteger>                    
        {
            static readonly NumInfo Inhabitant = default;

            [MethodImpl(Inline)]
            public static NumInfoProvider<T> Operator<T>() 
                => cast<NumInfoProvider<T>>(Inhabitant);

            NumberInfo<sbyte> NumInfoProvider<sbyte>.numinfo 
                => Int8Info.Summary;

            NumberInfo<byte> NumInfoProvider<byte>.numinfo 
                => UInt8Info.Summary;

            NumberInfo<short> NumInfoProvider<short>.numinfo 
                => Int16Info.Summary;

            NumberInfo<ushort> NumInfoProvider<ushort>.numinfo 
                => UInt16Info.Summary;

            NumberInfo<int> NumInfoProvider<int>.numinfo 
                => Int32Info.Summary;

            NumberInfo<uint> NumInfoProvider<uint>.numinfo 
                => UInt32Info.Summary;

            NumberInfo<long> NumInfoProvider<long>.numinfo 
                => Int64Info.Summary;

            NumberInfo<ulong> NumInfoProvider<ulong>.numinfo 
                => UInt64Info.Summary;

            NumberInfo<float> NumInfoProvider<float>.numinfo 
                => Float32Info.Summary;

            NumberInfo<double> NumInfoProvider<double>.numinfo 
                => Float64Info.Summary;

            NumberInfo<decimal> NumInfoProvider<decimal>.numinfo 
                => DecimalInfo.Summary;

            NumberInfo<BigInteger> NumInfoProvider<BigInteger>.numinfo 
                => BigIntegerInfo.Summary;

        }
    }

    readonly struct Int8Info
    {
        public const sbyte Zero = 0;

        public const sbyte One = 1;

        public const uint BitSize = 8;

        public const sbyte MinVal = sbyte.MinValue;            

        public const sbyte MaxVal = sbyte.MaxValue;

        public const bool Signed = true;
        
        public static readonly NumberInfo<sbyte> Summary 
            = new NumberInfo<sbyte>((MinVal,MaxVal), Signed, Zero, One, BitSize);
    }            

    readonly struct UInt8Info
    {
        public const byte Zero = 0;

        public const byte One = 1;

        public const uint BitSize = 8;

        public const byte MinVal = byte.MinValue;            

        public const byte MaxVal = byte.MaxValue;

        public const bool Signed = false;
        
        public static readonly NumberInfo<byte> Summary 
            = new NumberInfo<byte>((MinVal,MaxVal), Signed, Zero, One, BitSize);
    }            

    readonly struct Int16Info
    {
        public const short Zero = 0;

        public const short One = 1;

        public const uint BitSize = 16;

        public const short MinVal = short.MinValue;            

        public const short MaxVal = short.MaxValue;

        public const bool Signed = true;
        
        public static readonly NumberInfo<short> Summary 
            = new NumberInfo<short>((MinVal,MaxVal), Signed, Zero, One, BitSize);
    }            

    readonly struct UInt16Info
    {
        public const ushort Zero = 0;

        public const ushort One = 1;

        public const uint BitSize = 16;

        public const ushort MinVal = ushort.MinValue;            

        public const ushort MaxVal = ushort.MaxValue;

        public const bool Signed = false;
        
        public static readonly NumberInfo<ushort> Summary 
            = new NumberInfo<ushort>((MinVal,MaxVal), Signed, Zero, One, BitSize);
    }            

    readonly struct Int32Info
    {
        public const int Zero = 0;

        public const int One = 1;

        public const uint BitSize = 32;

        public const int MinVal = int.MinValue;            

        public const int MaxVal = int.MaxValue;

        public const bool Signed = true;
        
        public static readonly NumberInfo<int> Summary 
            = new NumberInfo<int>((MinVal,MaxVal), Signed, Zero, One, BitSize);
    }            

    readonly struct UInt32Info
    {
        public const uint Zero = 0;

        public const uint One = 1;

        public const uint BitSize = 32;

        public const uint MinVal = uint.MinValue;            

        public const uint MaxVal = uint.MaxValue;

        public const bool Signed = false;
        
        public static readonly NumberInfo<uint> Summary 
            = new NumberInfo<uint>((MinVal,MaxVal), Signed, Zero, One, BitSize);
    }            

    readonly struct Int64Info
    {
        public const long Zero = 0;

        public const long One = 1;

        public const uint BitSize = 64;

        public const long MinVal = long.MinValue;            

        public const long MaxVal = long.MaxValue;

        public const bool Signed = true;
        
        public static readonly NumberInfo<long> Summary 
            = new NumberInfo<long>((MinVal,MaxVal), Signed, Zero, One, BitSize);
    }            

    readonly struct UInt64Info
    {
        public const ulong Zero = 0;

        public const ulong One = 1;

        public const uint BitSize = 64;

        public const ulong MinVal = ulong.MinValue;            

        public const ulong MaxVal = ulong.MaxValue;

        public const bool Signed = false;
        
        public static readonly NumberInfo<ulong> Summary 
            = new NumberInfo<ulong>((MinVal,MaxVal), Signed, Zero, One, BitSize);
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
        
        public static readonly NumberInfo<float> Summary 
            = new NumberInfo<float>((MinVal,MaxVal), Signed, Zero, One, BitSize, Epsilon);
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
        
        public static readonly NumberInfo<double> Summary 
            = new NumberInfo<double>((MinVal,MaxVal), Signed, Zero, One, BitSize,Epsilon);
    }            

    readonly struct DecimalInfo
    {
        public const decimal Zero = 0;

        public const decimal One = 1;

        public const uint BitSize = sizeof(decimal) * 8;

        public const decimal MinVal = decimal.MinValue;            

        public const decimal MaxVal = decimal.MaxValue;

        public const bool Signed = true;
        
        public static readonly NumberInfo<decimal> Summary 
            = new NumberInfo<decimal>((MinVal,MaxVal), Signed, Zero, One, BitSize);
    }                

    readonly struct BigIntegerInfo
    {
        public static readonly BigInteger Zero = BigInteger.Zero;

        public static readonly BigInteger One = BigInteger.One;

        public const uint BitSize = 0;

        public const bool Signed = true;
        
        public static readonly NumberInfo<BigInteger> Summary 
            = new NumberInfo<BigInteger>((0,0), Signed, Zero, One, BitSize,0,true);
    }                   
}}
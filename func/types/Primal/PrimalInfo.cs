//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;
    using System.Diagnostics.CodeAnalysis;

    class ScalarComparer<T> : Comparer<T>
        where T : struct
    {
        public ScalarComparer(Func<T,T,int> comparer)
        {
            this.comparer = comparer;
        }

        readonly Func<T,T,int> comparer;

        public override int Compare(T x, T y)
            => comparer(x,y);
    }

    public interface IPrimalInfo<T>
        where T : struct
    {
        T MinVal {get;}
        
        T MaxVal {get;}
        
        bool Signed {get;}

        T One {get;}

        T Zero {get;}

        Option<T> Epsilon {get;}

        Comparer<T> Comparer {get;}

        ulong BitSize {get;}

        int ByteSize {get;}
        
        bool Infinite {get;}

        PrimalKind Kind {get;}

    }

    public interface IPrimalDescriptor<T>
        where T : struct
    {
        IPrimalInfo<T> Description {get;}
    }

    public static class PrimalRep
    {
        public static PrimalRep<T> Get<T>(T exemplar = default)
            where T : struct
                => PrimalRep<T>.TheOnly;
    }

    public readonly struct PrimalRep<T> 
        where T : struct
    {

        internal static PrimalRep<T> TheOnly = default;
         
        readonly T exeplar;

        public PrimalRep(T exemplar = default)
        {
            this.exeplar = exemplar;
        }

        [MethodImpl(Inline)]
        public static implicit operator T(PrimalRep<T> src)
            => src.exeplar;
    }

    public readonly struct PrimalInfo : 
        IPrimalDescriptor<byte>, 
        IPrimalDescriptor<sbyte>, 
        IPrimalDescriptor<short>,
        IPrimalDescriptor<ushort>, 
        IPrimalDescriptor<int>,
        IPrimalDescriptor<uint>,
        IPrimalDescriptor<long>,
        IPrimalDescriptor<ulong>,            
        IPrimalDescriptor<float>, 
        IPrimalDescriptor<double>, 
        IPrimalDescriptor<decimal>,
        IPrimalDescriptor<BigInteger>                    
    {
        static readonly PrimalInfo Inhabitant = default;

        [MethodImpl(Inline)]
        public static IPrimalInfo<T> Get<T>()
            where T : struct
            => Provider<T>().Description;            

        [MethodImpl(Inline)]
        public static T zero<T>()
            where T : struct
                => Get<T>().Zero;

        [MethodImpl(Inline)]
        public static T one<T>()
            where T : struct
                => Get<T>().One;

        [MethodImpl(Inline)]
        public static T minval<T>()
            where T : struct
                => Get<T>().MinVal;

        [MethodImpl(Inline)]
        public static T maxval<T>()
            where T : struct
                => Get<T>().MaxVal;

        [MethodImpl(Inline)]
        public static bool signed<T>()
            where T : struct
                => Get<T>().Signed;

        [MethodImpl(Inline)]
        public static bool unsigned<T>()
            where T : struct
                => !Get<T>().Signed;

        [MethodImpl(Inline)]
        public static ulong bitsize<T>()
            where T : struct
                => Get<T>().BitSize;

        [MethodImpl(Inline)]
        public static int bytesize<T>()
            where T : struct
                => Get<T>().ByteSize;

        [MethodImpl(Inline)]
        public static Comparer<T> comparer<T>()
            where T : struct
                => Get<T>().Comparer;

        [MethodImpl(Inline)]
        static IPrimalDescriptor<T> Provider<T>() 
            where T : struct
                => cast<IPrimalDescriptor<T>>(Inhabitant);

        IPrimalInfo<sbyte> IPrimalDescriptor<sbyte>.Description 
            => Int8Info.Summary;

        IPrimalInfo<byte> IPrimalDescriptor<byte>.Description 
            => UInt8Info.Summary;

        IPrimalInfo<short> IPrimalDescriptor<short>.Description 
            => Int16Info.Summary;

        IPrimalInfo<ushort> IPrimalDescriptor<ushort>.Description 
            => UInt16Info.Summary;

        IPrimalInfo<int> IPrimalDescriptor<int>.Description 
            => Int32Info.Summary;

        IPrimalInfo<uint> IPrimalDescriptor<uint>.Description 
            => UInt32Info.Summary;

        IPrimalInfo<long> IPrimalDescriptor<long>.Description 
            => Int64Info.Summary;

        IPrimalInfo<ulong> IPrimalDescriptor<ulong>.Description 
            => UInt64Info.Summary;

        IPrimalInfo<float> IPrimalDescriptor<float>.Description 
            => Float32Info.Summary;

        IPrimalInfo<double> IPrimalDescriptor<double>.Description 
            => Float64Info.Summary;

        IPrimalInfo<decimal> IPrimalDescriptor<decimal>.Description 
            => DecimalInfo.Summary;

        IPrimalInfo<BigInteger> IPrimalDescriptor<BigInteger>.Description 
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
            = new PrimalInfo<sbyte>((MinVal,MaxVal), Signed, Zero, One, BitSize, Comparer);
        
        [MethodImpl(Inline)]
        static int Compare(sbyte x, sbyte y)
            => x.CompareTo(y);
        
        public static readonly Comparer<sbyte> Comparer 
            = new ScalarComparer<sbyte>(Compare);
            
        
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
            = new PrimalInfo<byte>((MinVal,MaxVal), Signed, Zero, One, BitSize, Comparer);

        [MethodImpl(Inline)]
        static int Compare(byte x, byte y)
            => x.CompareTo(y);
        
        public static readonly Comparer<byte> Comparer 
            = new ScalarComparer<byte>(Compare);

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
            = new PrimalInfo<short>((MinVal,MaxVal), Signed, Zero, One, BitSize, Comparer);

        [MethodImpl(Inline)]
        static int Compare(short x, short y)
            => x.CompareTo(y);
        
        public static readonly Comparer<short> Comparer 
            = new ScalarComparer<short>(Compare);
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
            = new PrimalInfo<ushort>((MinVal,MaxVal), Signed, Zero, One, BitSize, Comparer);

        [MethodImpl(Inline)]
        static int Compare(ushort x, ushort y)
            => x.CompareTo(y);
        
        public static readonly Comparer<ushort> Comparer 
            = new ScalarComparer<ushort>(Compare);
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
            = new PrimalInfo<int>((MinVal,MaxVal), Signed, Zero, One, BitSize, Comparer);

        [MethodImpl(Inline)]
        static int Compare(int x, int y)
            => x.CompareTo(y);
        
        public static readonly Comparer<int> Comparer 
            = new ScalarComparer<int>(Compare);
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
            = new PrimalInfo<uint>((MinVal,MaxVal), Signed, Zero, One, BitSize, Comparer);


        [MethodImpl(Inline)]
        static int Compare(uint x, uint y)
            => x.CompareTo(y);
        
        public static readonly Comparer<uint> Comparer 
            = new ScalarComparer<uint>(Compare);
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
            = new PrimalInfo<long>((MinVal,MaxVal), Signed, Zero, One, BitSize, Comparer);


        [MethodImpl(Inline)]
        static int Compare(long x, long y)
            => x.CompareTo(y);
        
        public static readonly Comparer<long> Comparer 
            = new ScalarComparer<long>(Compare);

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
            = new PrimalInfo<ulong>((MinVal,MaxVal), Signed, Zero, One, BitSize, Comparer);

        [MethodImpl(Inline)]
        static int Compare(ulong x, ulong y)
            => x.CompareTo(y);
        
        public static readonly Comparer<ulong> Comparer 
            = new ScalarComparer<ulong>(Compare);
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
            = new PrimalInfo<float>((MinVal,MaxVal), Signed, Zero, One, BitSize, Comparer, Epsilon);

        [MethodImpl(Inline)]
        static int Compare(float x, float y)
            => x.CompareTo(y);
        
        public static readonly Comparer<float> Comparer 
            = new ScalarComparer<float>(Compare);

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
            = new PrimalInfo<double>((MinVal,MaxVal), Signed, Zero, One, BitSize, Comparer, Epsilon);

        [MethodImpl(Inline)]
        static int Compare(double x, double y)
            => x.CompareTo(y);
        
        public static readonly Comparer<double> Comparer 
            = new ScalarComparer<double>(Compare);
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
            = new PrimalInfo<decimal>((MinVal,MaxVal), Signed, Zero, One, BitSize, Comparer);

        [MethodImpl(Inline)]
        static int Compare(decimal x, decimal y)
            => x.CompareTo(y);
        
        public static readonly Comparer<decimal> Comparer 
            = new ScalarComparer<decimal>(Compare);

    }                

    readonly struct BigIntegerInfo
    {
        public static readonly BigInteger Zero = BigInteger.Zero;

        public static readonly BigInteger One = BigInteger.One;

        public const uint BitSize = 0;

        public const bool Signed = true;
        
        public static readonly PrimalInfo<BigInteger> Summary 
            = new PrimalInfo<BigInteger>((0,0), Signed, Zero, One, BitSize, Comparer,0,true);

        [MethodImpl(Inline)]
        static int Compare(BigInteger x, BigInteger y)
            => x.CompareTo(y);
        
        public static readonly Comparer<BigInteger> Comparer 
            = new ScalarComparer<BigInteger>(Compare);

    }                   
    public readonly struct PrimalInfo<T> : IPrimalInfo<T>
        where T : struct
    {
        public PrimalInfo((T min, T max) range, bool signed, T zero, T one, ulong bitsize, Comparer<T> comparer, T epsilon = default, bool infinite = false)
        {
            this.MinVal = range.min;
            this.MaxVal = range.max;
            this.Signed = signed;
            this.One = one;
            this.Zero = zero;
            this.BitSize = bitsize;
            this.Comparer = comparer;
            this.Infinite = infinite;
            this.Epsilon = ! epsilon.Equals(default) ? some(epsilon) : none<T>();
            this.ByteSize = (int)(BitSize/8ul);
            this.Kind = PrimalKinds.kind<T>();
        }

        public T MinVal {get;}
        
        public T MaxVal {get;}
        
        public bool Signed {get;}

        public T One {get;}

        public T Zero {get;}

        public Comparer<T> Comparer {get;}

        public Option<T> Epsilon {get;}

        public ulong BitSize {get;}

        public int ByteSize {get;}
        
        public bool Infinite {get;}

        public PrimalKind Kind {get;}
            
    }

}
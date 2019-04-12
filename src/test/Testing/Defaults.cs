//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Testing
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zcore;

    public interface Default
    {
        uint SampleSize {get;}

        int Reps {get;}
    }
    public interface Default<T> : Default
    {
        Interval<T> Range {get;}
    }

    public interface IPolyProp<T>
    {
        T Value {get; set;}
        TypeCode ValueType {get;}
    }

    public interface IPolyProp :
        IPolyProp<sbyte>,
        IPolyProp<byte>,
        IPolyProp<short>,
        IPolyProp<ushort>,
        IPolyProp<int>,
        IPolyProp<uint>,
        IPolyProp<long>,
        IPolyProp<ulong>,
        IPolyProp<float>,
        IPolyProp<double>
        

    {
        T get<T>();
        void set<T>(T value);
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct PolyProp : IPolyProp
    {
        public static PolyProp define<T>(T value)
        {
            var prop = new PolyProp();
            prop.set(value);
            return prop;
        }
        
        [FieldOffset(0)]
        byte type;

        [FieldOffset(1)]
        sbyte _sbyte;

        [FieldOffset(1)]
        byte _byte;

        [FieldOffset(1)]
        short _short;

        [FieldOffset(1)]
        ushort _ushort;

        [FieldOffset(1)]
        int _int;

        [FieldOffset(1)]
        uint _uint;

        [FieldOffset(1)]
        long _long;

        [FieldOffset(1)]
        ulong _ulong;

        [FieldOffset(1)]
        double _double;

        [FieldOffset(1)]
        float _float;

        sbyte IPolyProp<sbyte>.Value 
        {
            [MethodImpl(Inline)]
            get => _sbyte; 

            [MethodImpl(Inline)]
            set {
                _sbyte = value;
                type = (byte)TypeCode.SByte;
            }
        }

        byte IPolyProp<byte>.Value 
        {
            [MethodImpl(Inline)]
            get => _byte; 

            [MethodImpl(Inline)]
            set {
                _byte = value;
                type = (byte)TypeCode.Byte;
            }
        }

        short IPolyProp<short>.Value 
        {
            [MethodImpl(Inline)]
            get => _short; 

            [MethodImpl(Inline)]
            set {
                _short = value;
                type = (byte)TypeCode.Int16;
            }
        }

        ushort IPolyProp<ushort>.Value 
        {
            [MethodImpl(Inline)]
            get => _ushort; 

            [MethodImpl(Inline)]
            set {
                _ushort = value;
                type = (byte)TypeCode.UInt16;
            }
        }

        int IPolyProp<int>.Value 
        {
            [MethodImpl(Inline)]
            get => _int; 

            [MethodImpl(Inline)]
            set {
                _int = value;
                type = (byte)TypeCode.Int32;
            }
        }

        uint IPolyProp<uint>.Value 
        {
            [MethodImpl(Inline)]
            get => _uint; 

            [MethodImpl(Inline)]
            set {
                _uint = value;
                type = (byte)TypeCode.UInt32;
            }
        }

        long IPolyProp<long>.Value 
        {
            [MethodImpl(Inline)]
            get => _long; 

            [MethodImpl(Inline)]
            set {
                _long = value;
                type = (byte)TypeCode.Int64;
            }
        }

        ulong IPolyProp<ulong>.Value 
        {
            [MethodImpl(Inline)]
            get => _ulong; 

            [MethodImpl(Inline)]
            set {
                _ulong = value;
                type = (byte)TypeCode.UInt64;
            }
        }

        float IPolyProp<float>.Value 
        {
            [MethodImpl(Inline)]
            get => _float; 

            [MethodImpl(Inline)]
            set {
                _float = value;
                type = (byte)TypeCode.Single;
            }
        }

        double IPolyProp<double>.Value 
        {
            [MethodImpl(Inline)]
            get => _double; 

            [MethodImpl(Inline)]
            set {
                _double = value;
                type = (byte)TypeCode.Double;
            }
        }

        public TypeCode ValueType 
            => (TypeCode)type;

        public T get<T>()
            => cast<IPolyProp<T>>(this).Value;

        public void set<T>(T value)
            => cast<IPolyProp<T>>(this).Value = value;
        
        public override string ToString() 
        {
            switch((TypeCode)type)
            {
                case TypeCode.SByte:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                    return _long.ToString();

                case TypeCode.Byte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    return _ulong.ToString();

                case TypeCode.Single:
                    return _float.ToString();

                case TypeCode.Double:
                    return _double.ToString();                    
            }
            return ($"type={type}; value={_long.ToString()}");
        }
    
    }



    public readonly struct Defaults : 
        Default<sbyte>,
        Default<byte>,
        Default<short>,
        Default<ushort>,
        Default<int>,
        Default<uint>,
        Default<long>,
        Default<ulong>,
        Default<float>,
        Default<double>,
        Default<BigInteger>

    {

        static readonly Defaults Inhabitant = default;

        public static Default<T> get<T>()
            => cast<Default<T>>(Inhabitant);

        public const int Reps = 1;

        public const uint SampleSize = Pow2.T20;

        public const uint BigVector = Pow2.T20;

        uint Default.SampleSize 
            => SampleSize;

        int Default.Reps 
            => Reps;

        // ! Int8
        public const sbyte Int8Min = SByte.MinValue;

        public const sbyte Int8Max = SByte.MaxValue;

        public static readonly Interval<sbyte> Int8Range = Interval.closed(Int8Max,Int8Min);

        Interval<sbyte> Default<sbyte>.Range 
            => Int8Range;

        // ! UInt8
        public const byte UInt8Min = Byte.MinValue;

        public const byte UInt8Max = Byte.MaxValue;

        public static readonly Interval<byte> UInt8Range = Interval.closed(UInt8Max,UInt8Min);

        Interval<byte> Default<byte>.Range 
            => UInt8Range;

        // ! Int16

        public const short Int16Min = -500;
        
        public const short Int16Max = 500;

        public static readonly Interval<short> Int16Range = Interval.closed(Int16Min,Int16Max);

        Interval<short> Default<short>.Range 
            => Int16Range;

        // ! Int16

        public const ushort UInt16Min = 0;
        
        public const ushort UInt16Max = 500;

        public static readonly Interval<ushort> UInt16Range = Interval.closed(UInt16Min,UInt16Max);

        Interval<ushort> Default<ushort>.Range 
            => UInt16Range;

        // ! Int32

        public const int Int32Min = -250000;
        
        public const int Int32Max = 250000;

        public static readonly Interval<int> Int32Range = Interval.closed(Int32Min,Int32Max);

        Interval<int> Default<int>.Range 
            => Int32Range;

        // ! UInt32

        public const uint UInt32Min = 0;
        
        public const uint UInt32Max = 500000;

        public static readonly Interval<uint> UInt32Range = Interval.closed(UInt32Min,UInt32Max);

        Interval<uint> Default<uint>.Range 
            => UInt32Range;
 
        // ! Int64

        public const long Int64Min = -250000;
        
        public const long Int64Max = 250000;

        public static readonly Interval<long> Int64Range = Interval.closed(Int64Min,Int64Max);

       Interval<long> Default<long>.Range 
            => Int64Range;

        // ! UInt64

        public const ulong UInt64Min = 0;
        
        public const ulong UInt64Max = 500000;

        public static readonly Interval<ulong> UInt64Range = Interval.closed(UInt64Min,UInt64Max);

        Interval<ulong> Default<ulong>.Range 
            => UInt64Range;

       // ! Float32

        public const float Float32Min = -250000.00f;
        
        public const float Float32Max = 250000.00f;

        public static readonly Interval<float> Float32Range = Interval.closed(Float32Min,Float32Max);

        Interval<float> Default<float>.Range 
            => Float32Range;

        // ! Float64

        public const double Float64Min = -250000.00;
        
        public const double Float64Max = 250000.00;

        public static readonly Interval<double> Float64Range = Interval.closed(Float64Min,Float64Max);

        Interval<double> Default<double>.Range 
            => Float64Range;

       // ! Float64

        public static readonly BigInteger BigIntMin = -250000;
        
        public static readonly BigInteger BigIntMax = 250000;

        public static readonly Interval<BigInteger> BigIntRange = Interval.closed(BigIntMin,BigIntMax);

        Interval<BigInteger> Default<BigInteger>.Range 
            => BigIntRange;

    }
}
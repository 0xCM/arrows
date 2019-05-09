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
    using static zfunc;

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
}
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
    using System.Runtime.InteropServices;    

    using static zcore;

    public interface PolyNum<T>
        where T : struct, IEquatable<T>
    {
        T abs(T src);
        T negate(T src);
        T flip(T src);
        T add(T lhs, T rhs);
        T sub(T lhs, T rhs);
        T mul(T lhs, T rhs);
        T div(T lhs, T rhs);
        T mod(T lhs, T rhs);
    }

    public interface PolyNum<S,T> : IEquatable<S>
        where S : struct, PolyNum<S,T>
        where T : struct, IEquatable<T>
    {
        T add(T rhs);
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct PolyNum64 
    {

        const int DataOffset0 = 0;
        const int DataOffset1 = DataOffset0 + 1;
        const int DataOffset2 = DataOffset1 + 1;
        const int DataOffset3 = DataOffset2 + 1;
        const int DataOffset4 = DataOffset3 + 1;
        const int DataOffset5 = DataOffset4 + 1;
        const int DataOffset6 = DataOffset5 + 1;
        const int DataOffset7 = DataOffset6 + 1;

        //! ui8
        //! -------------------------------------------------------------------

        public const int u8_count = 16;            

        public const int u8_bytesize = 1;

        public const int u8_bitsize = 8;

        public const byte u8_zero = 0;
        
        public const byte u8_one = 1;

        public const byte u8_min = byte.MinValue;

        public const byte u8_max = byte.MaxValue;

        public const bool u8_signed = false;


        [FieldOffset(DataOffset0)]
        byte u8_0;

        [FieldOffset(DataOffset1)]
        byte u8_1;
        
        [FieldOffset(DataOffset2)]
        byte u8_2;
        
        [FieldOffset(DataOffset3)]        
        byte u8_3;
        
        [FieldOffset(DataOffset4)]
        byte u8_4;
        
        [FieldOffset(DataOffset5)]
        byte u8_5;
        
        [FieldOffset(DataOffset6)]
        byte u8_6;
        
        [FieldOffset(DataOffset7)]
        byte u8_7;
        
        
        [MethodImpl(Inline)]
        public byte u8(int i)
            => i switch
                {
                    0 => u8_0,
                    1 => u8_1,
                    2 => u8_2,
                    3 => u8_3,
                    4 => u8_4,
                    5 => u8_5,
                    6 => u8_6,
                    7 => u8_7,
                    _ => throw new IndexOutOfRangeException()
                };

        [MethodImpl(Inline)]
        public void u8(int i, byte src)
        {
             switch(i)
             {
                
                    case 0:  u8_0 = src; break;
                    case 1:  u8_1 = src; break;
                    case 2:  u8_2 = src; break;
                    case 3:  u8_3 = src; break;
                    case 4:  u8_4 = src; break;
                    case 5:  u8_5 = src; break;
                    case 6:  u8_6 = src; break;
                    case 7:  u8_7 = src; break;
                    default: throw new IndexOutOfRangeException();                
            }
        }

        [MethodImpl(Inline)]
        public static PolyNum64 addu8(PolyNum64 lhs, PolyNum64 rhs)
        {
            var dst = default(PolyNum64);
            for(var i=0; i< u8_count; i++)
                dst.u8(i, (byte)(lhs.u8(i) + rhs.u8(i)));
            return dst;
        }

        [MethodImpl(Inline)]
        public IReadOnlyList<byte> u8values()
            => array(u8_0, u8_1, u8_2, u8_3, u8_4, u8_5, u8_6, u8_7);
                    

        //! int8
        //! -------------------------------------------------------------------

        public const int i8_count = 16;            

        public const int i8_bytesize = 1;

        public const int i8_bitsize = 8;

        public const sbyte i8_zero = 0;
        
        public const sbyte i8_one = 1;

        public const sbyte i8_min = sbyte.MinValue;

        public const sbyte i8_max = sbyte.MaxValue;

        [FieldOffset(DataOffset0)]
        sbyte i8_0;

        [FieldOffset(DataOffset1)]
        sbyte i8_1;

        [FieldOffset(DataOffset2)]
        sbyte i8_2;

        [FieldOffset(DataOffset3)]
        sbyte i8_3;

        [FieldOffset(DataOffset4)]
        sbyte i8_4;

        [FieldOffset(DataOffset5)]
        sbyte i8_5;

        [FieldOffset(DataOffset6)]
        sbyte i8_6;

        [FieldOffset(DataOffset7)]
        sbyte i8_7;



        [MethodImpl(Inline)]
        public sbyte i8(int i)
            => i switch
                {
                    0 => i8_0,
                    1 => i8_1,
                    2 => i8_2,
                    3 => i8_3,
                    4 => i8_4,
                    5 => i8_5,
                    6 => i8_6,
                    7 => i8_7,
                    _ => throw new IndexOutOfRangeException()
                };


        [MethodImpl(Inline)]
        public void i8(int i, sbyte src)
        {
             switch(i)
             {
                
                    case 0:  i8_0 = src; break;
                    case 1:  i8_1 = src; break;
                    case 2:  i8_2 = src; break;
                    case 3:  i8_3 = src; break;
                    case 4:  i8_4 = src; break;
                    case 5:  i8_5 = src; break;
                    case 6:  i8_6 = src; break;
                    case 7:  i8_7 = src; break;
                    default: throw new IndexOutOfRangeException();                
            }
        }

        [MethodImpl(Inline)]
        public static PolyNum64 addi8(PolyNum64 lhs, PolyNum64 rhs)
        {
            var dst = default(PolyNum64);
            for(var i=0; i< i8_count; i++)
                dst.i8(i, (sbyte)(lhs.i8(i) + rhs.i8(i)));
            return dst;
        }

        [MethodImpl(Inline)]
        public IReadOnlyList<sbyte> i8values()
            => array(i8_0, i8_1, i8_2, i8_3, i8_4, i8_5, i8_6, i8_7); 
                    
        //! int16
        //! -------------------------------------------------------------------

        public const int i16_count = 8;            

        public const int i16_bytesize = 2;

        public const int i16_bitsize = 16;

        [FieldOffset(DataOffset0)]
        short i16_0;

        [FieldOffset(DataOffset2)]
        short i16_1;

        [FieldOffset(DataOffset4)]
        short i16_2;

        [FieldOffset(DataOffset6)]
        short i16_3;

        
        [MethodImpl(Inline)]
        public short i16(int i)
            => i switch
                {
                    0 => i16_0,
                    1 => i16_1,
                    2 => i16_2,
                    3 => i16_3,
                    _ => throw new IndexOutOfRangeException()
                };

        [MethodImpl(Inline)]
        public void i16(int i, short src)
        {
             switch(i)
             {
                case 0:  i16_0 = src; break;
                case 1:  i16_1 = src; break;
                case 2:  i16_2 = src; break;
                case 3:  i16_3 = src; break;
                default: throw new IndexOutOfRangeException();                
            }
        }

        [MethodImpl(Inline)]
        public static PolyNum64 addi16(PolyNum64 lhs, PolyNum64 rhs)
        {
            var dst = default(PolyNum64);
            for(var i=0; i< i16_count; i++)
                dst.i16(i, (short)(lhs.i16(i) + rhs.i16(i)));
            return dst;
        }

        [MethodImpl(Inline)]
        public IReadOnlyList<short> i16values()
            => array(i16_0, i16_1, i16_2, i16_3);

        //! uint16        
        //! -------------------------------------------------------------------

        public const int u16_count = 8;            

        public const int u16_bytesize = 2;

        public const int u16_bitsize = 16;


        [FieldOffset(DataOffset0)]
        ushort u16_0;
        
        [FieldOffset(DataOffset2)]
        ushort u16_1;
        
        [FieldOffset(DataOffset4)]
        ushort u16_2;
        
        [FieldOffset(DataOffset6)]
        ushort u16_3;
        

        [MethodImpl(Inline)]
        public ushort u16(int i)
            => i switch
                {
                    0 => u16_0,
                    1 => u16_1,
                    2 => u16_2,
                    3 => u16_3,
                    _ => throw new IndexOutOfRangeException()
                };

        [MethodImpl(Inline)]
        public void u16(int i, ushort src)
        {
             switch(i)
             {
                
                case 0:  u16_0 = src; break;
                case 1:  u16_1 = src; break;
                case 2:  u16_2 = src; break;
                case 3:  u16_3 = src; break;
                default: throw new IndexOutOfRangeException();                
            }
        }

        [MethodImpl(Inline)]
        public static PolyNum64 addu16(PolyNum64 lhs, PolyNum64 rhs)
        {
            var dst = default(PolyNum64);
            for(var i=0; i< u16_count; i++)
                dst.u16(i, (ushort)(lhs.u16(i) + rhs.u16(i)));
            return dst;
        }

        [MethodImpl(Inline)]
        public IReadOnlyList<ushort> u16list()
            => array(u16_0, u16_1, u16_2, u16_3);


        //! int32
        //! -------------------------------------------------------------------

        public const int i32_count = 4;            

        public const int i32_bytesize = 4;

        public const int i32_bitsize = 32;

        public const int i32_zero = 0;
        
        public const int i32_one = 1;

        public const int i32_min = Int32.MinValue;

        public const int i32_max = Int32.MaxValue;


        [FieldOffset(DataOffset0)]
        int i32_0;
        
        [FieldOffset(DataOffset4)]
        int i32_1;
        
        [MethodImpl(Inline)]
        public static PolyNum64 define(int x0, int x1)
        {
            var dst = default(PolyNum64);
            dst.i32(0,x0);
            dst.i32(1,x1);
            return dst;
        }

        [MethodImpl(Inline)]
        public int i32(int i)
            => i switch
                {
                    0 => i32_0,
                    1 => i32_1,
                    _ => throw new IndexOutOfRangeException()
                };

        [MethodImpl(Inline)]
        public void i32(int i, int src)
        {
             switch(i)
             {
                
                case 0:  i32_0 = src; break;
                case 1:  i32_1 = src; break;
                default: throw new IndexOutOfRangeException();                
            }
        }

        [MethodImpl(Inline)]
        public IReadOnlyList<int> i32values()
            => array(i32_0, i32_1);

        [MethodImpl(Inline)]
        public static PolyNum64 absi32(PolyNum64 src)
        {
            var dst = default(PolyNum64);
            for(var i=0; i< i32_count; i++)
                dst.i32(i, Math.Abs(src.i32(i)));
            return dst;
        }


        [MethodImpl(Inline)]
        public static PolyNum64 negatei32(PolyNum64 src)
        {
            var dst = default(PolyNum64);
            for(var i=0; i< i32_count; i++)
                dst.i32(i, - src.i32(i));
            return dst;
        }

        [MethodImpl(Inline)]
        public static PolyNum64 flipi32(PolyNum64 src)
        {
            var dst = default(PolyNum64);
            for(var i=0; i< i32_count; i++)
                dst.i32(i, ~ src.i32(i));
            return dst;
        }

        [MethodImpl(Inline)]
        public static PolyNum64 addi32(PolyNum64 lhs, PolyNum64 rhs)
        {        
            var dst = default(PolyNum64);
            for(var i=0; i< i32_count; i++)
                dst.i32(i, (lhs.i32(i) + rhs.i32(i)));
            return dst;
        }

        [MethodImpl(Inline)]
        public static PolyNum64 subi32(PolyNum64 lhs, PolyNum64 rhs)
        {
            var dst = default(PolyNum64);
            for(var i=0; i< i32_count; i++)
                dst.i32(i, (lhs.i32(i) - rhs.i32(i)));
            return dst;
        }


        [MethodImpl(Inline)]
        public static PolyNum64 muli32(PolyNum64 lhs, PolyNum64 rhs)
        {
            var dst = default(PolyNum64);
            for(var i=0; i< i32_count; i++)
                dst.i32(i, (lhs.i32(i) * rhs.i32(i)));
            return dst;
        }

        [MethodImpl(Inline)]
        public static PolyNum64 divi32(PolyNum64 lhs, PolyNum64 rhs)
        {
            var dst = default(PolyNum64);
            for(var i=0; i< i32_count; i++)
                dst.i32(i, (lhs.i32(i) / rhs.i32(i)));
            return dst;
        }

        [MethodImpl(Inline)]
        public static PolyNum64 modi32(PolyNum64 lhs, PolyNum64 rhs)
        {
            var dst = default(PolyNum64);
            for(var i=0; i< i32_count; i++)
                dst.i32(i, (lhs.i32(i) % rhs.i32(i)));
            return dst;
        }


        [MethodImpl(Inline)]
        public static PolyNum64 andi32(PolyNum64 lhs, PolyNum64 rhs)
        {
            var dst = default(PolyNum64);
            for(var i=0; i< i32_count; i++)
                dst.i32(i, (lhs.i32(i) & rhs.i32(i)));
            return dst;
        }


        [MethodImpl(Inline)]
        public static PolyNum64 ori32(PolyNum64 lhs, PolyNum64 rhs)
        {
            var dst = default(PolyNum64);
            for(var i=0; i< i32_count; i++)
                dst.i32(i, (lhs.i32(i) | rhs.i32(i)));
            return dst;
        }


        [MethodImpl(Inline)]
        public static PolyNum64 xori32(PolyNum64 lhs, PolyNum64 rhs)
        {
            var dst = default(PolyNum64);
            for(var i=0; i< i32_count; i++)
                dst.i32(i, (lhs.i32(i) ^ rhs.i32(i)));
            return dst;
        }
        

        //! uint32
        //! -------------------------------------------------------------------

        public const int u32_count = 4;            

        public const int u32_bytesize = 4;

        public const int u32_bitsize = 32;

        public const uint u32_zero = 0;
        
        public const uint u32_one = 1;

        public const uint u32_min = UInt32.MinValue;

        public const uint u32_max = UInt32.MaxValue;

        public const bool u32_signed = false;


        [FieldOffset(DataOffset0)]
        uint u32_0;
        
        [FieldOffset(DataOffset4)]
        uint u32_1;
        

        [MethodImpl(Inline)]
        public uint u32(int i)
            => i switch
                {
                    0 => u32_0,
                    1 => u32_1,
                    _ => throw new IndexOutOfRangeException()
                };

        [MethodImpl(Inline)]
        public void u32(int i, uint src)
        {
             switch(i)
             {
                
                case 0:  u32_0 = src; break;
                case 1:  u32_1 = src; break;
                default: throw new IndexOutOfRangeException();                
            }
        }

        [MethodImpl(Inline)]
        public static PolyNum64 addu32(PolyNum64 lhs, PolyNum64 rhs)
        {
            var dst = default(PolyNum64);
            for(var i=0; i< u32_count; i++)
                dst.u32(i, lhs.u32(i) + rhs.u32(i));
            return dst;
        }

        [MethodImpl(Inline)]
        public IReadOnlyList<uint> u32values()
            => array(u32_0, u32_1);

        //! int64
        //! -------------------------------------------------------------------

        public const int i64_count = 2;            

        public const int i64_bytesize = 8;

        public const int i64_bitsize = 64;

        public const long i64_zero = 0;
        
        public const long i64_one = 1;

        public const long i64_min = Int64.MinValue;

        public const long i64_max = Int64.MaxValue;

        public const bool i64_signed = true;

        [FieldOffset(DataOffset0)]
        public long i64_0;
        

        [MethodImpl(Inline)]
        public long i64(int i)
            => i switch
                {
                    0 => i64_0,
                    _ => throw new IndexOutOfRangeException()
                };


        [MethodImpl(Inline)]
        public static PolyNum64 define(long x0)
        {
            var dst = default(PolyNum64);
            dst.i64(0,x0);
            return dst;
        }

        [MethodImpl(Inline)]
        public void i64(int i, long src)
        {
             switch(i)
             {
                
                case 0:  i64_0 = src; break;
                default: throw new IndexOutOfRangeException();                
            }
        }

        [MethodImpl(Inline)]
        public static PolyNum64 addi64(PolyNum64 lhs, PolyNum64 rhs)
        {
            var dst = default(PolyNum64);
            for(var i=0; i< i64_count; i++)
                dst.i64(i, lhs.i64(i) + rhs.i64(i));
            return dst;
        }

        [MethodImpl(Inline)]
        public IReadOnlyList<long> i64values()
            => array(i64_0);

        //! uint64
        //! -------------------------------------------------------------------

        public const int u64_count = 2;            

        public const int u64_bytesize = 8;

        public const int u64_bitsize = 64;

        public const ulong u64_zero = 0;
        
        public const ulong u64_one = 1;

        public const ulong u64_min = UInt64.MinValue;

        public const ulong u64_max = UInt64.MaxValue;

        public const bool u64_signed = false;

        [FieldOffset(DataOffset0)]        
        public ulong u64_0;
        
        [MethodImpl(Inline)]
        public static PolyNum64 define(ulong x0, ulong x1)
        {
            var dst = default(PolyNum64);
            dst.u64(0,x0);
            dst.u64(1,x1);
            return dst;
        }

        [MethodImpl(Inline)]
        public ulong u64(int i)
            => i switch
                {
                    0 => u64_0,
                    _ => throw new IndexOutOfRangeException()
                };


        [MethodImpl(Inline)]
        public void u64(int i, ulong src)
        {
             switch(i)
             {
                
                case 0:  u64_0 = src; break;
                default: throw new IndexOutOfRangeException();                
            }
        }

        [MethodImpl(Inline)]
        public static PolyNum64 addu64(PolyNum64 lhs, PolyNum64 rhs)
        {
            var dst = default(PolyNum64);
            for(var i=0; i< u64_count; i++)
                dst.u64(i, lhs.u64(i) + rhs.u64(i));
            return dst;
        }


        [MethodImpl(Inline)]
        public IReadOnlyList<ulong> ui64values()
            => array(u64_0);

        //! float32
        //! -------------------------------------------------------------------
        
        public const int f32_count = 4;            

        public const int f32_bytesize = 4;

        public const int f32_bitsize = 32;

        public const float f32_zero = 0;
        
        public const float f32_one = 1;

        public const float f32_min = float.MinValue;

        public const float f32_max = float.MaxValue;

        public const bool f32_signed = true;

        [FieldOffset(DataOffset0)]
        public float f32_0;

        [FieldOffset(DataOffset4)]
        public float f32_1;


        [MethodImpl(Inline)]
        public float f32(int i)
            => i switch
                {
                    0 => f32_0,
                    1 => f32_1,
                    _ => throw new IndexOutOfRangeException()
                };


        [MethodImpl(Inline)]
        public void f32(int i, float src)
        {
             switch(i)
             {
                
                case 0:  f32_0 = src; break;
                case 1:  f32_1 = src; break;
                default: throw new IndexOutOfRangeException();                
            }
        }

        [MethodImpl(Inline)]
        public static PolyNum64 addf32(PolyNum64 lhs, PolyNum64 rhs)
        {
            var dst = default(PolyNum64);
            for(var i=0; i< f32_count; i++)
                dst.f32(i, lhs.f32(i) + rhs.f32(i));
            return dst;
        }

        [MethodImpl(Inline)]
        public IReadOnlyList<float> f32values()
            => array(f32_0, f32_1);

        //! float64
        //! -------------------------------------------------------------------

        public const int f64_count = 2;            

        public const int f64_bytesize = 8;

        public const int f64_bitsize = 64;

        public const double f64_zero = 0;
        
        public const double f64_one = 1;

        public const double f64_min = double.MinValue;

        public const double f64_max = double.MaxValue;

        public const bool f64_signed = true;

        [FieldOffset(DataOffset0)]
        public double f64_0;


        [MethodImpl(Inline)]
        public double f64(int i)
            => i switch
                {
                    0 => f64_0,
                    _ => throw new IndexOutOfRangeException()
                };



        [MethodImpl(Inline)]
        public void f64(int i, double src)
        {
             switch(i)
             {
                
                case 0:  f64_0 = src; break;
                default: throw new IndexOutOfRangeException();                
            }
        }

        [MethodImpl(Inline)]
        public static PolyNum64 define(double src)
        {
            var dst = default(PolyNum64);
            dst.f64_0 = src;
            return dst;
        }

        [MethodImpl(Inline)]
        public static PolyNum64 addf64(PolyNum64 lhs, PolyNum64 rhs)
            => PolyNum64.define(lhs.f64_0 + rhs.f64_0);

        [MethodImpl(Inline)]
        public IReadOnlyList<double> f64values()
            => array(f64_0);

        [MethodImpl(Inline)]
        public bool Equals(PolyNum64 rhs)
            => this.u64_0 == rhs.u64_0;


    }
}
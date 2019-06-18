//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    /*
    typedef union  __declspec(intrin_type) __declspec(align(64)) __m512i {
        __int8              m512i_i8[64];
        __int16             m512i_i16[32];
        __int32             m512i_i32[16];
        __int64             m512i_i64[8];
        unsigned __int8     m512i_u8[64];
        unsigned __int16    m512i_u16[32];
        unsigned __int32    m512i_u32[16];
        unsigned __int64    m512i_u64[8];
    } __m512i;
    
     */
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public ref struct M512
    {
        public static readonly ByteSize Size = 64;

        public static int PartCount<T>()
            where T : struct => Size/Unsafe.SizeOf<T>();

        #region I8
        
        [FieldOffset(0)]        
        public sbyte x0000s;
        
        [FieldOffset(1)]
        public sbyte x0001s;
        
        [FieldOffset(2)]
        public sbyte x0002s;
        
        [FieldOffset(3)]
        public sbyte x0003s;

        [FieldOffset(4)]
        public sbyte x0004s;
        
        [FieldOffset(5)]
        public sbyte x0005s;
        
        [FieldOffset(6)]
        public sbyte x0006s;
        
        [FieldOffset(7)]
        public sbyte x0007s;

        [FieldOffset(8)]        
        public sbyte x0008s;
        
        [FieldOffset(9)]
        public sbyte x0009s;
        
        [FieldOffset(10)]
        public sbyte x000As;
        
        [FieldOffset(11)]
        public sbyte x000Bs;

        [FieldOffset(12)]
        public sbyte x000Cs;
        
        [FieldOffset(13)]
        public sbyte x000Ds;
        
        [FieldOffset(14)]
        public sbyte x000Es;
        
        [FieldOffset(15)]
        public sbyte x000Fs;

        [FieldOffset(16)]
        public sbyte x0010s;

        [FieldOffset(17)]
        public sbyte x0011s;

        [FieldOffset(18)]
        public sbyte x0012s;

        [FieldOffset(19)]
        public sbyte x0013s;

        [FieldOffset(20)]
        public sbyte x0014s;

        [FieldOffset(21)]
        public sbyte x0015s;

        [FieldOffset(22)]
        public sbyte x0016s;

        [FieldOffset(23)]
        public sbyte x0017s;

        [FieldOffset(24)]
        public sbyte x0018s;

        [FieldOffset(25)]
        public sbyte x0019s;

        [FieldOffset(26)]
        public sbyte x001As;

        [FieldOffset(27)]
        public sbyte x001Bs;

        [FieldOffset(28)]
        public sbyte x001Cs;

        [FieldOffset(29)]
        public sbyte x001Ds;

        [FieldOffset(30)]
        public sbyte x001Es;

        [FieldOffset(31)]
        public sbyte x001Fs;

        [FieldOffset(32)]        
        public sbyte x0020s;
        
        [FieldOffset(33)]
        public sbyte x0021s;
        
        [FieldOffset(34)]
        public sbyte x0022s;
        
        [FieldOffset(35)]
        public sbyte x0023s;

        [FieldOffset(36)]
        public sbyte x0024s;
        
        [FieldOffset(37)]
        public sbyte x0025s;
        
        [FieldOffset(38)]
        public sbyte x0026s;
        
        [FieldOffset(39)]
        public sbyte x0027s;

        [FieldOffset(40)]        
        public sbyte x0028s;
        
        [FieldOffset(41)]
        public sbyte x0029s;
        
        [FieldOffset(42)]
        public sbyte x002As;
        
        [FieldOffset(43)]
        public sbyte x002Bs;

        [FieldOffset(44)]
        public sbyte x002Cs;
        
        [FieldOffset(45)]
        public sbyte x002Ds;
        
        [FieldOffset(46)]
        public sbyte x002Es;
        
        [FieldOffset(47)]
        public sbyte x002Fs;

        [FieldOffset(48)]
        public sbyte x0030s;

        [FieldOffset(49)]
        public sbyte x0031s;

        [FieldOffset(50)]
        public sbyte x0032s;

        [FieldOffset(51)]
        public sbyte x0033s;

        [FieldOffset(52)]
        public sbyte x0034s;

        [FieldOffset(53)]
        public sbyte x0035s;

        [FieldOffset(54)]
        public sbyte x0036s;

        [FieldOffset(55)]
        public sbyte x0037s;

        [FieldOffset(56)]
        public sbyte x0038s;

        [FieldOffset(57)]
        public sbyte x0039s;

        [FieldOffset(58)]
        public sbyte x003As;

        [FieldOffset(59)]
        public sbyte x003Bs;

        [FieldOffset(60)]
        public sbyte x003Cs;

        [FieldOffset(61)]
        public sbyte x003Ds;

        [FieldOffset(62)]
        public sbyte x003Es;

        [FieldOffset(63)]
        public sbyte x003Fs;
        
        #endregion

        #region U8
        
        [FieldOffset(0)]        
        public byte x0000;
        
        [FieldOffset(1)]
        public byte x0001;
        
        [FieldOffset(2)]
        public byte x0002;
        
        [FieldOffset(3)]
        public byte x0003;

        [FieldOffset(4)]
        public byte x0004;
        
        [FieldOffset(5)]
        public byte x0005;
        
        [FieldOffset(6)]
        public byte x0006;
        
        [FieldOffset(7)]
        public byte x0007;

        [FieldOffset(8)]        
        public byte x0008;
        
        [FieldOffset(9)]
        public byte x0009;
        
        [FieldOffset(10)]
        public byte x000A;
        
        [FieldOffset(11)]
        public byte x000B;

        [FieldOffset(12)]
        public byte x000C;
        
        [FieldOffset(13)]
        public byte x000D;
        
        [FieldOffset(14)]
        public byte x000E;
        
        [FieldOffset(15)]
        public byte x000F;

        [FieldOffset(16)]
        public byte x0010;

        [FieldOffset(17)]
        public byte x0011;

        [FieldOffset(18)]
        public byte x0012;

        [FieldOffset(19)]
        public byte x0013;

        [FieldOffset(20)]
        public byte x0014;

        [FieldOffset(21)]
        public byte x0015;

        [FieldOffset(22)]
        public byte x0016;

        [FieldOffset(23)]
        public byte x0017;

        [FieldOffset(24)]
        public byte x0018;

        [FieldOffset(25)]
        public byte x0019;

        [FieldOffset(26)]
        public byte x001A;

        [FieldOffset(27)]
        public byte x001B;

        [FieldOffset(28)]
        public byte x001C;

        [FieldOffset(29)]
        public byte x001D;

        [FieldOffset(30)]
        public byte x001E;

        [FieldOffset(31)]
        public byte x001F;

        [FieldOffset(32)]        
        public byte x0020;
        
        [FieldOffset(33)]
        public byte x0021;
        
        [FieldOffset(34)]
        public byte x0022;
        
        [FieldOffset(35)]
        public byte x0023;

        [FieldOffset(36)]
        public byte x0024;
        
        [FieldOffset(37)]
        public byte x0025;
        
        [FieldOffset(38)]
        public byte x0026;
        
        [FieldOffset(39)]
        public byte x0027;

        [FieldOffset(40)]        
        public byte x0028;
        
        [FieldOffset(41)]
        public byte x0029;
        
        [FieldOffset(42)]
        public byte x002A;
        
        [FieldOffset(43)]
        public byte x002B;

        [FieldOffset(44)]
        public byte x002C;
        
        [FieldOffset(45)]
        public byte x002D;
        
        [FieldOffset(46)]
        public byte x002E;
        
        [FieldOffset(47)]
        public byte x002F;

        [FieldOffset(48)]
        public byte x0030;

        [FieldOffset(49)]
        public byte x0031;

        [FieldOffset(50)]
        public byte x0032;

        [FieldOffset(51)]
        public byte x0033;

        [FieldOffset(52)]
        public byte x0034;

        [FieldOffset(53)]
        public byte x0035;

        [FieldOffset(54)]
        public byte x0036;

        [FieldOffset(55)]
        public byte x0037;

        [FieldOffset(56)]
        public byte x0038;

        [FieldOffset(57)]
        public byte x0039;

        [FieldOffset(58)]
        public byte x003A;

        [FieldOffset(59)]
        public byte x003B;

        [FieldOffset(60)]
        public byte x003C;

        [FieldOffset(61)]
        public byte x003D;

        [FieldOffset(62)]
        public byte x003E;

        [FieldOffset(63)]
        public byte x003F;
        
        #endregion

        #region U16

        [FieldOffset(0)]        
        public ushort x000;
        
        [FieldOffset(2)]
        public ushort x001;
        
        [FieldOffset(4)]
        public ushort x002;
        
        [FieldOffset(6)]
        public ushort x003;

        [FieldOffset(8)]
        public ushort x004;
        
        [FieldOffset(10)]
        public ushort x005;
        
        [FieldOffset(12)]
        public ushort x006;
        
        [FieldOffset(14)]
        public ushort x007;

        [FieldOffset(16)]        
        public ushort x008;
        
        [FieldOffset(18)]
        public ushort x009;
        
        [FieldOffset(20)]
        public ushort x00A;
        
        [FieldOffset(22)]
        public ushort x00B;

        [FieldOffset(24)]
        public ushort x00C;
        
        [FieldOffset(26)]
        public ushort x00D;
        
        [FieldOffset(28)]
        public ushort x00E;
        
        [FieldOffset(30)]
        public ushort x00F;

        [FieldOffset(32)]
        public ushort x010;

        [FieldOffset(34)]
        public ushort x011;

        [FieldOffset(36)]
        public ushort x012;

        [FieldOffset(38)]
        public ushort x013;

        [FieldOffset(40)]
        public ushort x014;

        [FieldOffset(42)]
        public ushort x015;

        [FieldOffset(44)]
        public ushort x016;

        [FieldOffset(46)]
        public ushort x017;

        [FieldOffset(48)]
        public ushort x018;

        [FieldOffset(50)]
        public ushort x019;

        [FieldOffset(52)]
        public ushort x01A;

        [FieldOffset(54)]
        public ushort x01B;

        [FieldOffset(56)]
        public ushort x01C;

        [FieldOffset(58)]
        public ushort x01D;

        [FieldOffset(60)]
        public ushort x01E;

        [FieldOffset(62)]
        public ushort x01F;

        #endregion

        #region I16

        [FieldOffset(0)]        
        public short x000s;
        
        [FieldOffset(2)]
        public short x001s;
        
        [FieldOffset(4)]
        public short x002s;
        
        [FieldOffset(6)]
        public short x003s;

        [FieldOffset(8)]
        public short x004s;
        
        [FieldOffset(10)]
        public short x005s;
        
        [FieldOffset(12)]
        public short x006s;
        
        [FieldOffset(14)]
        public short x007s;

        [FieldOffset(16)]        
        public short x008s;
        
        [FieldOffset(18)]
        public short x009s;
        
        [FieldOffset(20)]
        public short x00As;
        
        [FieldOffset(22)]
        public short x00Bs;

        [FieldOffset(24)]
        public short x00Cs;
        
        [FieldOffset(26)]
        public short x00Ds;
        
        [FieldOffset(28)]
        public short x00Es;
        
        [FieldOffset(30)]
        public short x00Fs;

        [FieldOffset(32)]
        public short x010s;

        [FieldOffset(34)]
        public short x011s;

        [FieldOffset(36)]
        public short x012s;

        [FieldOffset(38)]
        public short x013s;

        [FieldOffset(40)]
        public short x014s;

        [FieldOffset(42)]
        public short x015s;

        [FieldOffset(44)]
        public short x016s;

        [FieldOffset(46)]
        public short x017s;

        [FieldOffset(48)]
        public short x018s;

        [FieldOffset(50)]
        public short x019s;

        [FieldOffset(52)]
        public short x01As;

        [FieldOffset(54)]
        public short x01Bs;

        [FieldOffset(56)]
        public short x01Cs;

        [FieldOffset(58)]
        public short x01Ds;

        [FieldOffset(60)]
        public short x01Es;

        [FieldOffset(62)]
        public short x01Fs;

        #endregion

        #region I32

        [FieldOffset(0)]
        public int x00s;

        [FieldOffset(4)]
        public int x01s;

        [FieldOffset(8)]
        public int x02s;

        [FieldOffset(12)]
        public int x03s;

        [FieldOffset(16)]
        public int x04s;

        [FieldOffset(20)]
        public int x05s;

        [FieldOffset(24)]
        public int x06s;

        [FieldOffset(28)]
        public int x07s;

        [FieldOffset(32)]
        public int x08s;

        [FieldOffset(36)]
        public int x09s;

        [FieldOffset(40)]
        public int x0As;

        [FieldOffset(44)]
        public int x0Bs;

        [FieldOffset(48)]
        public int x0Cs;

        [FieldOffset(52)]
        public int x0Ds;

        [FieldOffset(56)]
        public int x0Es;

        [FieldOffset(60)]
        public int x0Fs;
        
        #endregion

        #region U32

        [FieldOffset(0)]
        public uint x00;

        [FieldOffset(4)]
        public uint x01;

        [FieldOffset(8)]
        public uint x02;

        [FieldOffset(12)]
        public uint x03;

        [FieldOffset(16)]
        public uint x04;

        [FieldOffset(20)]
        public uint x05;

        [FieldOffset(24)]
        public uint x06;

        [FieldOffset(28)]
        public uint x07;

        [FieldOffset(32)]
        public uint x08;

        [FieldOffset(36)]
        public uint x09;

        [FieldOffset(40)]
        public uint x0A;

        [FieldOffset(44)]
        public uint x0B;

        [FieldOffset(48)]
        public uint x0C;

        [FieldOffset(52)]
        public uint x0D;

        [FieldOffset(56)]
        public uint x0E;

        [FieldOffset(60)]
        public uint x0F;
        
        #endregion

        #region I64

        [FieldOffset(0)]
        public long x0s;

        [FieldOffset(8)]
        public long x1s;

        [FieldOffset(16)]
        public long x2s;

        [FieldOffset(24)]
        public long x3s;

        [FieldOffset(32)]
        public long x4s;

        [FieldOffset(40)]
        public long x5s;

        [FieldOffset(48)]
        public long x6s;

        [FieldOffset(56)]
        public long x7s;
        
        #endregion 

        #region U64

        [FieldOffset(0)]
        public ulong x0;

        [FieldOffset(8)]
        public ulong x1;

        [FieldOffset(16)]
        public ulong x2;

        [FieldOffset(24)]
        public ulong x3;

        [FieldOffset(32)]
        public ulong x4;

        [FieldOffset(40)]
        public ulong x5;

        [FieldOffset(48)]
        public ulong x6;

        [FieldOffset(56)]
        public ulong x7;
        
        #endregion 

        #region F32

        [FieldOffset(0)]
        public float x00f;

        [FieldOffset(4)]
        public float x01f;

        [FieldOffset(8)]
        public float x02f;

        [FieldOffset(12)]
        public float x03f;

        [FieldOffset(16)]
        public float x04f;

        [FieldOffset(20)]
        public float x05f;

        [FieldOffset(24)]
        public float x06f;

        [FieldOffset(28)]
        public float x07f;

        [FieldOffset(32)]
        public float x08f;

        [FieldOffset(36)]
        public float x09f;

        [FieldOffset(40)]
        public float x0Af;

        [FieldOffset(44)]
        public float x0Bf;

        [FieldOffset(48)]
        public float x0Cf;

        [FieldOffset(52)]
        public float x0Df;

        [FieldOffset(56)]
        public float x0Ef;

        [FieldOffset(60)]
        public float x0Ff;
        
        #endregion

        #region F64

        [FieldOffset(0)]
        public double x0d;

        [FieldOffset(8)]
        public double x1d;

        [FieldOffset(16)]
        public double x2d;

        [FieldOffset(24)]
        public double x3d;

        [FieldOffset(32)]
        public double x4d;

        [FieldOffset(40)]
        public double x5d;

        [FieldOffset(48)]
        public double x6d;

        [FieldOffset(56)]
        public double x7d;
        
        #endregion  
 
        [MethodImpl(Inline)]
        unsafe ref T head<T>()
            where T : struct
        {
            fixed(void* pSrc = &this)
                return ref Unsafe.AsRef<T>(pSrc);
        }

        [MethodImpl(Inline)]
        public ref T part<T>(int pos)
            where T : struct
                => ref Unsafe.Add(ref head<T>(), pos);

        [MethodImpl(Inline)]
        public ref T part<T>(BitPos pos)
            where T : struct
                => ref part<T>(pos.current / SizeOf<T>.BitSize); 
                

        public Bit this[Index r]
        {
            [MethodImpl(Inline)]
            get
            {
                math.quorem(r.Value, 64, out Quorem<int> qr);
                return part<ulong>(qr.Quotient).Test(qr.Remainder);                
            }
        }

        public byte this[Range r]
        {
            get
            {
                if(r.End.Value - r.Start.Value > 8)
                    return 0;
                else
                {
                    var dst = default(byte);
                    var start = math.quorem(r.Start.Value, 8);
                    var b1 = part<byte>(start.Quotient);

                    var j = 0;
                    for(var i = start.Remainder; i< 8; i++, j++)
                        if(Bits.test(b1,i))
                            Bits.enable(ref dst, j);

                    var final = math.quorem(r.End.Value, 8);                    
                    var b2 = part<byte>(final.Quotient);

                    for(var i = 0; i< final.Remainder; i++, j++)
                        if(Bits.test(b2,i))
                            Bits.enable(ref dst, j);
                }

                return 0;
            }
        }
        
    }

}
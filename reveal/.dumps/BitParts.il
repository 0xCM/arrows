// 2019-09-25 16:30:32:133
void part32x16(uint src, Span<ushort> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4 65535
    IL_000E: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x16)
    IL_0013: ldc.i4 65535
    IL_0018: call System.UInt16 Z0.Bits::project<System.UInt16>(System.UInt32,Z0.BitParts/Part32x16)
    IL_001D: stind.i2
    IL_001E: ldarga.s dst
    IL_0020: ldc.i4.1
    IL_0021: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0026: ldarg.0
    IL_0027: ldc.i4 -65536
    IL_002C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x16)
    IL_0031: ldc.i4 65535
    IL_0036: call System.UInt16 Z0.Bits::project<System.UInt16>(System.UInt32,Z0.BitParts/Part32x16)
    IL_003B: stind.i2
    IL_003C: ret

}
ref ulong uint64(ref BitBlock8 src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64& System.Runtime.CompilerServices.Unsafe::As<Z0.BitBlock8,System.UInt64>(Z0.BitBlock8&)
    IL_0006: ret

}
ref ulong uint64c(in BitBlock8 src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitBlock8& System.Runtime.CompilerServices.Unsafe::AsRef<Z0.BitBlock8>(Z0.BitBlock8&)
    IL_0006: call System.UInt64& System.Runtime.CompilerServices.Unsafe::As<Z0.BitBlock8,System.UInt64>(Z0.BitBlock8&)
    IL_000B: ret

}
ref ulong uint64(ref BitBlock16 src, N0 lo)
{
    IL_0000: ldarg.0
    IL_0001: ldflda Z0.BitBlock8 Z0.BitBlock16::Block8x0
    IL_0006: call System.UInt64& System.Runtime.CompilerServices.Unsafe::As<Z0.BitBlock8,System.UInt64>(Z0.BitBlock8&)
    IL_000B: ret

}
ref ulong uint64(ref BitBlock16 src, N1 hi)
{
    IL_0000: ldarg.0
    IL_0001: ldflda Z0.BitBlock8 Z0.BitBlock16::Block8x1
    IL_0006: call System.UInt64& System.Runtime.CompilerServices.Unsafe::As<Z0.BitBlock8,System.UInt64>(Z0.BitBlock8&)
    IL_000B: ret

}
byte pack8x1(BitBlock8 src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt64& Z0.BitParts::uint64(Z0.BitBlock8&)
    IL_0007: ldind.i8
    IL_0008: ldc.i8 72340172838076673
    IL_0011: call System.UInt64 Z0.Bits::gather(System.UInt64,System.UInt64)
    IL_0016: conv.u1
    IL_0017: ret

}
ref ushort pack16x1(BitBlock16 src, ref ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.1
    IL_0002: ldind.u2
    IL_0003: ldarga.s src
    IL_0005: ldflda Z0.BitBlock8 Z0.BitBlock16::Block8x0
    IL_000A: call System.UInt64& Z0.BitParts::uint64(Z0.BitBlock8&)
    IL_000F: ldind.i8
    IL_0010: ldc.i8 72340172838076673
    IL_0019: call System.UInt64 Z0.Bits::gather(System.UInt64,System.UInt64)
    IL_001E: conv.u2
    IL_001F: or
    IL_0020: conv.u2
    IL_0021: stind.i2
    IL_0022: ldarg.1
    IL_0023: ldarg.1
    IL_0024: ldind.u2
    IL_0025: ldarga.s src
    IL_0027: ldflda Z0.BitBlock8 Z0.BitBlock16::Block8x1
    IL_002C: call System.UInt64& Z0.BitParts::uint64(Z0.BitBlock8&)
    IL_0031: ldind.i8
    IL_0032: ldc.i8 72340172838076673
    IL_003B: call System.UInt64 Z0.Bits::gather(System.UInt64,System.UInt64)
    IL_0040: ldc.i4.8
    IL_0041: shl
    IL_0042: conv.u2
    IL_0043: or
    IL_0044: conv.u2
    IL_0045: stind.i2
    IL_0046: ldarg.1
    IL_0047: ret

}
ref uint pack32x1(in BitBlock32 src, ref uint dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.1
    IL_0002: ldind.u4
    IL_0003: ldarg.0
    IL_0004: ldflda Z0.BitBlock8 Z0.BitBlock32::Block8x0
    IL_0009: call System.UInt64& Z0.BitParts::uint64c(Z0.BitBlock8&)
    IL_000E: ldind.i8
    IL_000F: ldc.i8 72340172838076673
    IL_0018: call System.UInt64 Z0.Bits::gather(System.UInt64,System.UInt64)
    IL_001D: conv.u4
    IL_001E: or
    IL_001F: stind.i4
    IL_0020: ldarg.1
    IL_0021: ldarg.1
    IL_0022: ldind.u4
    IL_0023: ldarg.0
    IL_0024: ldflda Z0.BitBlock8 Z0.BitBlock32::Block8x1
    IL_0029: call System.UInt64& Z0.BitParts::uint64c(Z0.BitBlock8&)
    IL_002E: ldind.i8
    IL_002F: ldc.i8 72340172838076673
    IL_0038: call System.UInt64 Z0.Bits::gather(System.UInt64,System.UInt64)
    IL_003D: ldc.i4.8
    IL_003E: shl
    IL_003F: conv.u4
    IL_0040: or
    IL_0041: stind.i4
    IL_0042: ldarg.1
    IL_0043: ldarg.1
    IL_0044: ldind.u4
    IL_0045: ldarg.0
    IL_0046: ldflda Z0.BitBlock8 Z0.BitBlock32::Block8x2
    IL_004B: call System.UInt64& Z0.BitParts::uint64c(Z0.BitBlock8&)
    IL_0050: ldind.i8
    IL_0051: ldc.i8 72340172838076673
    IL_005A: call System.UInt64 Z0.Bits::gather(System.UInt64,System.UInt64)
    IL_005F: ldc.i4.s 16
    IL_0061: shl
    IL_0062: conv.u4
    IL_0063: or
    IL_0064: stind.i4
    IL_0065: ldarg.1
    IL_0066: ldarg.1
    IL_0067: ldind.u4
    IL_0068: ldarg.0
    IL_0069: ldflda Z0.BitBlock8 Z0.BitBlock32::Block8x3
    IL_006E: call System.UInt64& Z0.BitParts::uint64c(Z0.BitBlock8&)
    IL_0073: ldind.i8
    IL_0074: ldc.i8 72340172838076673
    IL_007D: call System.UInt64 Z0.Bits::gather(System.UInt64,System.UInt64)
    IL_0082: ldc.i4.s 24
    IL_0084: shl
    IL_0085: conv.u4
    IL_0086: or
    IL_0087: stind.i4
    IL_0088: ldarg.1
    IL_0089: ret

}
ref BitBlock8 unpack8x1(byte src, ref BitBlock8 dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt64& Z0.BitParts::uint64(Z0.BitBlock8&)
    IL_0006: ldarg.0
    IL_0007: conv.u8
    IL_0008: ldc.i8 72340172838076673
    IL_0011: call System.UInt64 Z0.Bits::scatter(System.UInt64,System.UInt64)
    IL_0016: stind.i8
    IL_0017: ldarg.1
    IL_0018: ret

}
Span<byte> unpack8x1(byte src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: ldc.i8 72340172838076673
    IL_000B: call System.UInt64 Z0.Bits::scatter(System.UInt64,System.UInt64)
    IL_0010: call System.Byte[] System.BitConverter::GetBytes(System.UInt64)
    IL_0015: ldarg.1
    IL_0016: call System.Void System.MemoryExtensions::CopyTo<System.Byte>(System.Byte[],System.Span`1<System.Byte>)
    IL_001B: ldarg.1
    IL_001C: ret

}
Span<byte> unpack16x1(ushort src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_2
    IL_0003: initobj Z0.N2
    IL_0009: ldloc.2
    IL_000A: call System.ValueTuple`2<System.Byte,System.Byte> Z0.Bits::split(System.UInt16,Z0.N2)
    IL_000F: dup
    IL_0010: ldfld System.Byte System.ValueTuple`2<System.Byte,System.Byte>::Item1
    IL_0015: stloc.0
    IL_0016: ldfld System.Byte System.ValueTuple`2<System.Byte,System.Byte>::Item2
    IL_001B: stloc.1
    IL_001C: ldloc.0
    IL_001D: ldarg.1
    IL_001E: call System.Span`1<System.Byte> Z0.BitParts::unpack8x1(System.Byte,System.Span`1<System.Byte>)
    IL_0023: pop
    IL_0024: ldloc.1
    IL_0025: ldarga.s dst
    IL_0027: ldc.i4.7
    IL_0028: call System.Span`1<System.Byte> System.Span`1<System.Byte>::Slice(System.Int32)
    IL_002D: call System.Span`1<System.Byte> Z0.BitParts::unpack8x1(System.Byte,System.Span`1<System.Byte>)
    IL_0032: pop
    IL_0033: ldarg.1
    IL_0034: ret

}
Span<byte> unpack32x1(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_2
    IL_0003: initobj Z0.N2
    IL_0009: ldloc.2
    IL_000A: call System.ValueTuple`2<System.UInt16,System.UInt16> Z0.Bits::split(System.UInt32,Z0.N2)
    IL_000F: dup
    IL_0010: ldfld System.UInt16 System.ValueTuple`2<System.UInt16,System.UInt16>::Item1
    IL_0015: stloc.0
    IL_0016: ldfld System.UInt16 System.ValueTuple`2<System.UInt16,System.UInt16>::Item2
    IL_001B: stloc.1
    IL_001C: ldloc.0
    IL_001D: ldarg.1
    IL_001E: call System.Span`1<System.Byte> Z0.BitParts::unpack16x1(System.UInt16,System.Span`1<System.Byte>)
    IL_0023: pop
    IL_0024: ldloc.1
    IL_0025: ldarga.s dst
    IL_0027: ldc.i4.s 15
    IL_0029: call System.Span`1<System.Byte> System.Span`1<System.Byte>::Slice(System.Int32)
    IL_002E: call System.Span`1<System.Byte> Z0.BitParts::unpack16x1(System.UInt16,System.Span`1<System.Byte>)
    IL_0033: pop
    IL_0034: ldarg.1
    IL_0035: ret

}
Span<byte> unpack64x1(ulong src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_2
    IL_0003: initobj Z0.N2
    IL_0009: ldloc.2
    IL_000A: call System.ValueTuple`2<System.UInt32,System.UInt32> Z0.Bits::split(System.UInt64,Z0.N2)
    IL_000F: dup
    IL_0010: ldfld System.UInt32 System.ValueTuple`2<System.UInt32,System.UInt32>::Item1
    IL_0015: stloc.0
    IL_0016: ldfld System.UInt32 System.ValueTuple`2<System.UInt32,System.UInt32>::Item2
    IL_001B: stloc.1
    IL_001C: ldloc.0
    IL_001D: ldarg.1
    IL_001E: call System.Span`1<System.Byte> Z0.BitParts::unpack32x1(System.UInt32,System.Span`1<System.Byte>)
    IL_0023: pop
    IL_0024: ldloc.1
    IL_0025: ldarga.s dst
    IL_0027: ldc.i4.s 31
    IL_0029: call System.Span`1<System.Byte> System.Span`1<System.Byte>::Slice(System.Int32)
    IL_002E: call System.Span`1<System.Byte> Z0.BitParts::unpack32x1(System.UInt32,System.Span`1<System.Byte>)
    IL_0033: pop
    IL_0034: ldarg.1
    IL_0035: ret

}
void part6x1(byte src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.1
    IL_000A: call System.Byte Z0.Bits::select(System.UInt32,Z0.BitParts/Part6x1)
    IL_000F: ldc.i4.1
    IL_0010: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part6x1)
    IL_0015: stind.i1
    IL_0016: ldarga.s dst
    IL_0018: ldc.i4.1
    IL_0019: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldarg.0
    IL_001F: ldc.i4.2
    IL_0020: call System.Byte Z0.Bits::select(System.UInt32,Z0.BitParts/Part6x1)
    IL_0025: ldc.i4.1
    IL_0026: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part6x1)
    IL_002B: stind.i1
    IL_002C: ldarga.s dst
    IL_002E: ldc.i4.2
    IL_002F: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0034: ldarg.0
    IL_0035: ldc.i4.4
    IL_0036: call System.Byte Z0.Bits::select(System.UInt32,Z0.BitParts/Part6x1)
    IL_003B: ldc.i4.1
    IL_003C: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part6x1)
    IL_0041: stind.i1
    IL_0042: ldarga.s dst
    IL_0044: ldc.i4.3
    IL_0045: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_004A: ldarg.0
    IL_004B: ldc.i4.8
    IL_004C: call System.Byte Z0.Bits::select(System.UInt32,Z0.BitParts/Part6x1)
    IL_0051: ldc.i4.1
    IL_0052: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part6x1)
    IL_0057: stind.i1
    IL_0058: ldarga.s dst
    IL_005A: ldc.i4.4
    IL_005B: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0060: ldarg.0
    IL_0061: ldc.i4.s 16
    IL_0063: call System.Byte Z0.Bits::select(System.UInt32,Z0.BitParts/Part6x1)
    IL_0068: ldc.i4.1
    IL_0069: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part6x1)
    IL_006E: stind.i1
    IL_006F: ldarga.s dst
    IL_0071: ldc.i4.5
    IL_0072: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0077: ldarg.0
    IL_0078: ldc.i4.s 32
    IL_007A: call System.Byte Z0.Bits::select(System.UInt32,Z0.BitParts/Part6x1)
    IL_007F: ldc.i4.1
    IL_0080: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part6x1)
    IL_0085: stind.i1
    IL_0086: ret

}
ref BitBlock6 part6x1(byte src, ref BitBlock6 dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: call System.Byte Z0.Bits::select(System.UInt32,Z0.BitParts/Part6x1)
    IL_0008: ldc.i4.1
    IL_0009: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part6x1)
    IL_000E: stfld System.Byte Z0.BitBlock6::Bit0
    IL_0013: ldarg.1
    IL_0014: ldarg.0
    IL_0015: ldc.i4.2
    IL_0016: call System.Byte Z0.Bits::select(System.UInt32,Z0.BitParts/Part6x1)
    IL_001B: ldc.i4.1
    IL_001C: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part6x1)
    IL_0021: stfld System.Byte Z0.BitBlock6::Bit1
    IL_0026: ldarg.1
    IL_0027: ldarg.0
    IL_0028: ldc.i4.4
    IL_0029: call System.Byte Z0.Bits::select(System.UInt32,Z0.BitParts/Part6x1)
    IL_002E: ldc.i4.1
    IL_002F: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part6x1)
    IL_0034: stfld System.Byte Z0.BitBlock6::Bit2
    IL_0039: ldarg.1
    IL_003A: ldarg.0
    IL_003B: ldc.i4.8
    IL_003C: call System.Byte Z0.Bits::select(System.UInt32,Z0.BitParts/Part6x1)
    IL_0041: ldc.i4.1
    IL_0042: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part6x1)
    IL_0047: stfld System.Byte Z0.BitBlock6::Bit3
    IL_004C: ldarg.1
    IL_004D: ldarg.0
    IL_004E: ldc.i4.s 16
    IL_0050: call System.Byte Z0.Bits::select(System.UInt32,Z0.BitParts/Part6x1)
    IL_0055: ldc.i4.1
    IL_0056: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part6x1)
    IL_005B: stfld System.Byte Z0.BitBlock6::Bit4
    IL_0060: ldarg.1
    IL_0061: ldarg.0
    IL_0062: ldc.i4.s 32
    IL_0064: call System.Byte Z0.Bits::select(System.UInt32,Z0.BitParts/Part6x1)
    IL_0069: ldc.i4.1
    IL_006A: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part6x1)
    IL_006F: stfld System.Byte Z0.BitBlock6::Bit5
    IL_0074: ldarg.1
    IL_0075: ret

}
void part7x1(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.1
    IL_000A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part7x1)
    IL_000F: ldc.i4.1
    IL_0010: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part7x1)
    IL_0015: stind.i1
    IL_0016: ldarga.s dst
    IL_0018: ldc.i4.1
    IL_0019: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldarg.0
    IL_001F: ldc.i4.2
    IL_0020: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part7x1)
    IL_0025: ldc.i4.1
    IL_0026: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part7x1)
    IL_002B: stind.i1
    IL_002C: ldarga.s dst
    IL_002E: ldc.i4.2
    IL_002F: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0034: ldarg.0
    IL_0035: ldc.i4.4
    IL_0036: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part7x1)
    IL_003B: ldc.i4.1
    IL_003C: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part7x1)
    IL_0041: stind.i1
    IL_0042: ldarga.s dst
    IL_0044: ldc.i4.3
    IL_0045: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_004A: ldarg.0
    IL_004B: ldc.i4.8
    IL_004C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part7x1)
    IL_0051: ldc.i4.1
    IL_0052: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part7x1)
    IL_0057: stind.i1
    IL_0058: ldarga.s dst
    IL_005A: ldc.i4.4
    IL_005B: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0060: ldarg.0
    IL_0061: ldc.i4.s 16
    IL_0063: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part7x1)
    IL_0068: ldc.i4.1
    IL_0069: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part7x1)
    IL_006E: stind.i1
    IL_006F: ldarga.s dst
    IL_0071: ldc.i4.5
    IL_0072: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0077: ldarg.0
    IL_0078: ldc.i4.s 32
    IL_007A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part7x1)
    IL_007F: ldc.i4.1
    IL_0080: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part7x1)
    IL_0085: stind.i1
    IL_0086: ldarga.s dst
    IL_0088: ldc.i4.6
    IL_0089: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_008E: ldarg.0
    IL_008F: ldc.i4.s 64
    IL_0091: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part7x1)
    IL_0096: ldc.i4.1
    IL_0097: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part7x1)
    IL_009C: stind.i1
    IL_009D: ret

}
void part8x1(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.1
    IL_000A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x1)
    IL_000F: ldc.i4.1
    IL_0010: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x1)
    IL_0015: stind.i1
    IL_0016: ldarga.s dst
    IL_0018: ldc.i4.1
    IL_0019: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldarg.0
    IL_001F: ldc.i4.2
    IL_0020: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x1)
    IL_0025: ldc.i4.1
    IL_0026: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x1)
    IL_002B: stind.i1
    IL_002C: ldarga.s dst
    IL_002E: ldc.i4.2
    IL_002F: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0034: ldarg.0
    IL_0035: ldc.i4.4
    IL_0036: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x1)
    IL_003B: ldc.i4.1
    IL_003C: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x1)
    IL_0041: stind.i1
    IL_0042: ldarga.s dst
    IL_0044: ldc.i4.3
    IL_0045: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_004A: ldarg.0
    IL_004B: ldc.i4.8
    IL_004C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x1)
    IL_0051: ldc.i4.1
    IL_0052: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x1)
    IL_0057: stind.i1
    IL_0058: ldarga.s dst
    IL_005A: ldc.i4.4
    IL_005B: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0060: ldarg.0
    IL_0061: ldc.i4.s 16
    IL_0063: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x1)
    IL_0068: ldc.i4.1
    IL_0069: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x1)
    IL_006E: stind.i1
    IL_006F: ldarga.s dst
    IL_0071: ldc.i4.5
    IL_0072: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0077: ldarg.0
    IL_0078: ldc.i4.s 32
    IL_007A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x1)
    IL_007F: ldc.i4.1
    IL_0080: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x1)
    IL_0085: stind.i1
    IL_0086: ldarga.s dst
    IL_0088: ldc.i4.6
    IL_0089: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_008E: ldarg.0
    IL_008F: ldc.i4.s 64
    IL_0091: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x1)
    IL_0096: ldc.i4.1
    IL_0097: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x1)
    IL_009C: stind.i1
    IL_009D: ldarga.s dst
    IL_009F: ldc.i4.7
    IL_00A0: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00A5: ldarg.0
    IL_00A6: ldc.i4 128
    IL_00AB: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x1)
    IL_00B0: ldc.i4.1
    IL_00B1: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x1)
    IL_00B6: stind.i1
    IL_00B7: ret

}
ref BitBlock8 part8x1(uint src, ref BitBlock8 dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x1)
    IL_0008: ldc.i4.1
    IL_0009: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x1)
    IL_000E: stfld System.Byte Z0.BitBlock8::Bit1
    IL_0013: ldarg.1
    IL_0014: ldarg.0
    IL_0015: ldc.i4.2
    IL_0016: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x1)
    IL_001B: ldc.i4.1
    IL_001C: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x1)
    IL_0021: stfld System.Byte Z0.BitBlock8::Bit2
    IL_0026: ldarg.1
    IL_0027: ldarg.0
    IL_0028: ldc.i4.4
    IL_0029: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x1)
    IL_002E: ldc.i4.1
    IL_002F: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x1)
    IL_0034: stfld System.Byte Z0.BitBlock8::Bit3
    IL_0039: ldarg.1
    IL_003A: ldarg.0
    IL_003B: ldc.i4.8
    IL_003C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x1)
    IL_0041: ldc.i4.1
    IL_0042: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x1)
    IL_0047: stfld System.Byte Z0.BitBlock8::Bit4
    IL_004C: ldarg.1
    IL_004D: ldarg.0
    IL_004E: ldc.i4.s 16
    IL_0050: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x1)
    IL_0055: ldc.i4.1
    IL_0056: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x1)
    IL_005B: stfld System.Byte Z0.BitBlock8::Bit5
    IL_0060: ldarg.1
    IL_0061: ldarg.0
    IL_0062: ldc.i4.s 32
    IL_0064: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x1)
    IL_0069: ldc.i4.1
    IL_006A: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x1)
    IL_006F: stfld System.Byte Z0.BitBlock8::Bit6
    IL_0074: ldarg.1
    IL_0075: ldarg.0
    IL_0076: ldc.i4.s 64
    IL_0078: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x1)
    IL_007D: ldc.i4.1
    IL_007E: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x1)
    IL_0083: stfld System.Byte Z0.BitBlock8::Bit7
    IL_0088: ldarg.1
    IL_0089: ret

}
void part9x1(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.1
    IL_000A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x1)
    IL_000F: ldc.i4.1
    IL_0010: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x1)
    IL_0015: stind.i1
    IL_0016: ldarga.s dst
    IL_0018: ldc.i4.1
    IL_0019: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldarg.0
    IL_001F: ldc.i4.2
    IL_0020: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x1)
    IL_0025: ldc.i4.1
    IL_0026: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x1)
    IL_002B: stind.i1
    IL_002C: ldarga.s dst
    IL_002E: ldc.i4.2
    IL_002F: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0034: ldarg.0
    IL_0035: ldc.i4.4
    IL_0036: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x1)
    IL_003B: ldc.i4.1
    IL_003C: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x1)
    IL_0041: stind.i1
    IL_0042: ldarga.s dst
    IL_0044: ldc.i4.3
    IL_0045: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_004A: ldarg.0
    IL_004B: ldc.i4.8
    IL_004C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x1)
    IL_0051: ldc.i4.1
    IL_0052: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x1)
    IL_0057: stind.i1
    IL_0058: ldarga.s dst
    IL_005A: ldc.i4.4
    IL_005B: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0060: ldarg.0
    IL_0061: ldc.i4.s 16
    IL_0063: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x1)
    IL_0068: ldc.i4.1
    IL_0069: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x1)
    IL_006E: stind.i1
    IL_006F: ldarga.s dst
    IL_0071: ldc.i4.5
    IL_0072: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0077: ldarg.0
    IL_0078: ldc.i4.s 32
    IL_007A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x1)
    IL_007F: ldc.i4.1
    IL_0080: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x1)
    IL_0085: stind.i1
    IL_0086: ldarga.s dst
    IL_0088: ldc.i4.6
    IL_0089: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_008E: ldarg.0
    IL_008F: ldc.i4.s 64
    IL_0091: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x1)
    IL_0096: ldc.i4.1
    IL_0097: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x1)
    IL_009C: stind.i1
    IL_009D: ldarga.s dst
    IL_009F: ldc.i4.7
    IL_00A0: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00A5: ldarg.0
    IL_00A6: ldc.i4 128
    IL_00AB: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x1)
    IL_00B0: ldc.i4.1
    IL_00B1: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x1)
    IL_00B6: stind.i1
    IL_00B7: ldarga.s dst
    IL_00B9: ldc.i4.8
    IL_00BA: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00BF: ldarg.0
    IL_00C0: ldc.i4 256
    IL_00C5: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x1)
    IL_00CA: ldc.i4.1
    IL_00CB: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x1)
    IL_00D0: stind.i1
    IL_00D1: ret

}
ref BitBlock9 part9x1(ushort src, ref BitBlock9 dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x1)
    IL_0008: ldc.i4.1
    IL_0009: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x1)
    IL_000E: stfld System.Byte Z0.BitBlock9::Bit0
    IL_0013: ldarg.1
    IL_0014: ldarg.0
    IL_0015: ldc.i4.2
    IL_0016: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x1)
    IL_001B: ldc.i4.1
    IL_001C: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x1)
    IL_0021: stfld System.Byte Z0.BitBlock9::Bit1
    IL_0026: ldarg.1
    IL_0027: ldarg.0
    IL_0028: ldc.i4.4
    IL_0029: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x1)
    IL_002E: ldc.i4.1
    IL_002F: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x1)
    IL_0034: stfld System.Byte Z0.BitBlock9::Bit2
    IL_0039: ldarg.1
    IL_003A: ldarg.0
    IL_003B: ldc.i4.8
    IL_003C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x1)
    IL_0041: ldc.i4.1
    IL_0042: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x1)
    IL_0047: stfld System.Byte Z0.BitBlock9::Bit3
    IL_004C: ldarg.1
    IL_004D: ldarg.0
    IL_004E: ldc.i4.s 16
    IL_0050: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x1)
    IL_0055: ldc.i4.1
    IL_0056: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x1)
    IL_005B: stfld System.Byte Z0.BitBlock9::Bit4
    IL_0060: ldarg.1
    IL_0061: ldarg.0
    IL_0062: ldc.i4.s 32
    IL_0064: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x1)
    IL_0069: ldc.i4.1
    IL_006A: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x1)
    IL_006F: stfld System.Byte Z0.BitBlock9::Bit5
    IL_0074: ldarg.1
    IL_0075: ldarg.0
    IL_0076: ldc.i4.s 64
    IL_0078: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x1)
    IL_007D: ldc.i4.1
    IL_007E: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x1)
    IL_0083: stfld System.Byte Z0.BitBlock9::Bit6
    IL_0088: ldarg.1
    IL_0089: ldarg.0
    IL_008A: ldc.i4 128
    IL_008F: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x1)
    IL_0094: ldc.i4.1
    IL_0095: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x1)
    IL_009A: stfld System.Byte Z0.BitBlock9::Bit7
    IL_009F: ldarg.1
    IL_00A0: ldarg.0
    IL_00A1: ldc.i4 256
    IL_00A6: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x1)
    IL_00AB: ldc.i4.1
    IL_00AC: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x1)
    IL_00B1: stfld System.Byte Z0.BitBlock9::Bit8
    IL_00B6: ldarg.1
    IL_00B7: ret

}
void part10x1(ushort src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.1
    IL_000A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_000F: ldc.i4.1
    IL_0010: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_0015: stind.i1
    IL_0016: ldarga.s dst
    IL_0018: ldc.i4.1
    IL_0019: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldarg.0
    IL_001F: ldc.i4.2
    IL_0020: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_0025: ldc.i4.1
    IL_0026: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_002B: stind.i1
    IL_002C: ldarga.s dst
    IL_002E: ldc.i4.2
    IL_002F: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0034: ldarg.0
    IL_0035: ldc.i4.4
    IL_0036: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_003B: ldc.i4.1
    IL_003C: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_0041: stind.i1
    IL_0042: ldarga.s dst
    IL_0044: ldc.i4.3
    IL_0045: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_004A: ldarg.0
    IL_004B: ldc.i4.8
    IL_004C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_0051: ldc.i4.1
    IL_0052: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_0057: stind.i1
    IL_0058: ldarga.s dst
    IL_005A: ldc.i4.4
    IL_005B: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0060: ldarg.0
    IL_0061: ldc.i4.s 16
    IL_0063: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_0068: ldc.i4.1
    IL_0069: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_006E: stind.i1
    IL_006F: ldarga.s dst
    IL_0071: ldc.i4.5
    IL_0072: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0077: ldarg.0
    IL_0078: ldc.i4.s 32
    IL_007A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_007F: ldc.i4.1
    IL_0080: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_0085: stind.i1
    IL_0086: ldarga.s dst
    IL_0088: ldc.i4.6
    IL_0089: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_008E: ldarg.0
    IL_008F: ldc.i4.s 64
    IL_0091: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_0096: ldc.i4.1
    IL_0097: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_009C: stind.i1
    IL_009D: ldarga.s dst
    IL_009F: ldc.i4.7
    IL_00A0: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00A5: ldarg.0
    IL_00A6: ldc.i4 128
    IL_00AB: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_00B0: ldc.i4.1
    IL_00B1: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_00B6: stind.i1
    IL_00B7: ldarga.s dst
    IL_00B9: ldc.i4.8
    IL_00BA: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00BF: ldarg.0
    IL_00C0: ldc.i4 256
    IL_00C5: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_00CA: ldc.i4.1
    IL_00CB: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_00D0: stind.i1
    IL_00D1: ldarga.s dst
    IL_00D3: ldc.i4.s 9
    IL_00D5: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00DA: ldarg.0
    IL_00DB: ldc.i4 512
    IL_00E0: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_00E5: ldc.i4.1
    IL_00E6: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_00EB: stind.i1
    IL_00EC: ret

}
ref BitBlock10 part10x1(uint src, ref BitBlock10 dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_0008: ldc.i4.1
    IL_0009: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_000E: stfld System.Byte Z0.BitBlock10::Bit0
    IL_0013: ldarg.1
    IL_0014: ldarg.0
    IL_0015: ldc.i4.2
    IL_0016: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_001B: ldc.i4.1
    IL_001C: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_0021: stfld System.Byte Z0.BitBlock10::Bit1
    IL_0026: ldarg.1
    IL_0027: ldarg.0
    IL_0028: ldc.i4.4
    IL_0029: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_002E: ldc.i4.1
    IL_002F: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_0034: stfld System.Byte Z0.BitBlock10::Bit2
    IL_0039: ldarg.1
    IL_003A: ldarg.0
    IL_003B: ldc.i4.8
    IL_003C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_0041: ldc.i4.1
    IL_0042: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_0047: stfld System.Byte Z0.BitBlock10::Bit3
    IL_004C: ldarg.1
    IL_004D: ldarg.0
    IL_004E: ldc.i4.s 16
    IL_0050: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_0055: ldc.i4.1
    IL_0056: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_005B: stfld System.Byte Z0.BitBlock10::Bit4
    IL_0060: ldarg.1
    IL_0061: ldarg.0
    IL_0062: ldc.i4.s 32
    IL_0064: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_0069: ldc.i4.1
    IL_006A: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_006F: stfld System.Byte Z0.BitBlock10::Bit5
    IL_0074: ldarg.1
    IL_0075: ldarg.0
    IL_0076: ldc.i4.s 64
    IL_0078: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_007D: ldc.i4.1
    IL_007E: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_0083: stfld System.Byte Z0.BitBlock10::Bit6
    IL_0088: ldarg.1
    IL_0089: ldarg.0
    IL_008A: ldc.i4 128
    IL_008F: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_0094: ldc.i4.1
    IL_0095: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_009A: stfld System.Byte Z0.BitBlock10::Bit7
    IL_009F: ldarg.1
    IL_00A0: ldarg.0
    IL_00A1: ldc.i4 256
    IL_00A6: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_00AB: ldc.i4.1
    IL_00AC: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_00B1: stfld System.Byte Z0.BitBlock10::Bit8
    IL_00B6: ldarg.1
    IL_00B7: ldarg.0
    IL_00B8: ldc.i4 512
    IL_00BD: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part10x1)
    IL_00C2: ldc.i4.1
    IL_00C3: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part10x1)
    IL_00C8: stfld System.Byte Z0.BitBlock10::Bit9
    IL_00CD: ldarg.1
    IL_00CE: ret

}
ref BitBlock16 part16x1(ushort src, ref BitBlock16 dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0008: ldc.i4.1
    IL_0009: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_000E: stfld System.Byte Z0.BitBlock16::Bit0
    IL_0013: ldarg.1
    IL_0014: ldarg.0
    IL_0015: ldc.i4.2
    IL_0016: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_001B: ldc.i4.1
    IL_001C: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0021: stfld System.Byte Z0.BitBlock16::Bit1
    IL_0026: ldarg.1
    IL_0027: ldarg.0
    IL_0028: ldc.i4.4
    IL_0029: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_002E: ldc.i4.1
    IL_002F: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0034: stfld System.Byte Z0.BitBlock16::Bit2
    IL_0039: ldarg.1
    IL_003A: ldarg.0
    IL_003B: ldc.i4.8
    IL_003C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0041: ldc.i4.1
    IL_0042: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0047: stfld System.Byte Z0.BitBlock16::Bit3
    IL_004C: ldarg.1
    IL_004D: ldarg.0
    IL_004E: ldc.i4.s 16
    IL_0050: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0055: ldc.i4.1
    IL_0056: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_005B: stfld System.Byte Z0.BitBlock16::Bit4
    IL_0060: ldarg.1
    IL_0061: ldarg.0
    IL_0062: ldc.i4.s 32
    IL_0064: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0069: ldc.i4.1
    IL_006A: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_006F: stfld System.Byte Z0.BitBlock16::Bit5
    IL_0074: ldarg.1
    IL_0075: ldarg.0
    IL_0076: ldc.i4.s 64
    IL_0078: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_007D: ldc.i4.1
    IL_007E: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0083: stfld System.Byte Z0.BitBlock16::Bit6
    IL_0088: ldarg.1
    IL_0089: ldarg.0
    IL_008A: ldc.i4 128
    IL_008F: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0094: ldc.i4.1
    IL_0095: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_009A: stfld System.Byte Z0.BitBlock16::Bit7
    IL_009F: ldarg.1
    IL_00A0: ldarg.0
    IL_00A1: ldc.i4 256
    IL_00A6: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_00AB: ldc.i4.1
    IL_00AC: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_00B1: stfld System.Byte Z0.BitBlock16::Bit8
    IL_00B6: ldarg.1
    IL_00B7: ldarg.0
    IL_00B8: ldc.i4 512
    IL_00BD: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_00C2: ldc.i4.1
    IL_00C3: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_00C8: stfld System.Byte Z0.BitBlock16::Bit9
    IL_00CD: ldarg.1
    IL_00CE: ldarg.0
    IL_00CF: ldc.i4 1024
    IL_00D4: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_00D9: ldc.i4.1
    IL_00DA: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_00DF: stfld System.Byte Z0.BitBlock16::Bit10
    IL_00E4: ldarg.1
    IL_00E5: ldarg.0
    IL_00E6: ldc.i4 2048
    IL_00EB: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_00F0: ldc.i4.1
    IL_00F1: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_00F6: stfld System.Byte Z0.BitBlock16::Bit11
    IL_00FB: ldarg.1
    IL_00FC: ldarg.0
    IL_00FD: ldc.i4 4096
    IL_0102: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0107: ldc.i4.1
    IL_0108: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_010D: stfld System.Byte Z0.BitBlock16::Bit12
    IL_0112: ldarg.1
    IL_0113: ldarg.0
    IL_0114: ldc.i4 8192
    IL_0119: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_011E: ldc.i4.1
    IL_011F: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0124: stfld System.Byte Z0.BitBlock16::Bit13
    IL_0129: ldarg.1
    IL_012A: ldarg.0
    IL_012B: ldc.i4 16384
    IL_0130: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0135: ldc.i4.1
    IL_0136: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_013B: stfld System.Byte Z0.BitBlock16::Bit14
    IL_0140: ldarg.1
    IL_0141: ldarg.0
    IL_0142: ldc.i4 32768
    IL_0147: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_014C: ldc.i4.1
    IL_014D: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0152: stfld System.Byte Z0.BitBlock16::Bit15
    IL_0157: ldarg.1
    IL_0158: ret

}
ref BitBlock32 part32x1(uint src, ref BitBlock32 dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0008: ldc.i4.1
    IL_0009: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_000E: stfld System.Byte Z0.BitBlock32::Bit0
    IL_0013: ldarg.1
    IL_0014: ldarg.0
    IL_0015: ldc.i4.2
    IL_0016: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_001B: ldc.i4.1
    IL_001C: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0021: stfld System.Byte Z0.BitBlock32::Bit1
    IL_0026: ldarg.1
    IL_0027: ldarg.0
    IL_0028: ldc.i4.4
    IL_0029: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_002E: ldc.i4.1
    IL_002F: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0034: stfld System.Byte Z0.BitBlock32::Bit2
    IL_0039: ldarg.1
    IL_003A: ldarg.0
    IL_003B: ldc.i4.8
    IL_003C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0041: ldc.i4.1
    IL_0042: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0047: stfld System.Byte Z0.BitBlock32::Bit3
    IL_004C: ldarg.1
    IL_004D: ldarg.0
    IL_004E: ldc.i4.s 16
    IL_0050: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0055: ldc.i4.1
    IL_0056: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_005B: stfld System.Byte Z0.BitBlock32::Bit4
    IL_0060: ldarg.1
    IL_0061: ldarg.0
    IL_0062: ldc.i4.s 32
    IL_0064: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0069: ldc.i4.1
    IL_006A: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_006F: stfld System.Byte Z0.BitBlock32::Bit5
    IL_0074: ldarg.1
    IL_0075: ldarg.0
    IL_0076: ldc.i4.s 64
    IL_0078: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_007D: ldc.i4.1
    IL_007E: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0083: stfld System.Byte Z0.BitBlock32::Bit6
    IL_0088: ldarg.1
    IL_0089: ldarg.0
    IL_008A: ldc.i4 128
    IL_008F: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0094: ldc.i4.1
    IL_0095: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_009A: stfld System.Byte Z0.BitBlock32::Bit7
    IL_009F: ldarg.1
    IL_00A0: ldarg.0
    IL_00A1: ldc.i4 256
    IL_00A6: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_00AB: ldc.i4.1
    IL_00AC: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_00B1: stfld System.Byte Z0.BitBlock32::Bit8
    IL_00B6: ldarg.1
    IL_00B7: ldarg.0
    IL_00B8: ldc.i4 512
    IL_00BD: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_00C2: ldc.i4.1
    IL_00C3: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_00C8: stfld System.Byte Z0.BitBlock32::Bit9
    IL_00CD: ldarg.1
    IL_00CE: ldarg.0
    IL_00CF: ldc.i4 1024
    IL_00D4: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_00D9: ldc.i4.1
    IL_00DA: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_00DF: stfld System.Byte Z0.BitBlock32::Bit10
    IL_00E4: ldarg.1
    IL_00E5: ldarg.0
    IL_00E6: ldc.i4 2048
    IL_00EB: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_00F0: ldc.i4.1
    IL_00F1: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_00F6: stfld System.Byte Z0.BitBlock32::Bit11
    IL_00FB: ldarg.1
    IL_00FC: ldarg.0
    IL_00FD: ldc.i4 4096
    IL_0102: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0107: ldc.i4.1
    IL_0108: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_010D: stfld System.Byte Z0.BitBlock32::Bit12
    IL_0112: ldarg.1
    IL_0113: ldarg.0
    IL_0114: ldc.i4 8192
    IL_0119: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_011E: ldc.i4.1
    IL_011F: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0124: stfld System.Byte Z0.BitBlock32::Bit13
    IL_0129: ldarg.1
    IL_012A: ldarg.0
    IL_012B: ldc.i4 16384
    IL_0130: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0135: ldc.i4.1
    IL_0136: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_013B: stfld System.Byte Z0.BitBlock32::Bit14
    IL_0140: ldarg.1
    IL_0141: ldarg.0
    IL_0142: ldc.i4 32768
    IL_0147: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_014C: ldc.i4.1
    IL_014D: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0152: stfld System.Byte Z0.BitBlock32::Bit15
    IL_0157: ldarg.1
    IL_0158: ldarg.0
    IL_0159: ldc.i4 65536
    IL_015E: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0163: ldc.i4.1
    IL_0164: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0169: stfld System.Byte Z0.BitBlock32::Bit16
    IL_016E: ldarg.1
    IL_016F: ldarg.0
    IL_0170: ldc.i4 131072
    IL_0175: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_017A: ldc.i4.1
    IL_017B: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0180: stfld System.Byte Z0.BitBlock32::Bit17
    IL_0185: ldarg.1
    IL_0186: ldarg.0
    IL_0187: ldc.i4 262144
    IL_018C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0191: ldc.i4.1
    IL_0192: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0197: stfld System.Byte Z0.BitBlock32::Bit18
    IL_019C: ldarg.1
    IL_019D: ldarg.0
    IL_019E: ldc.i4 524288
    IL_01A3: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_01A8: ldc.i4.1
    IL_01A9: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_01AE: stfld System.Byte Z0.BitBlock32::Bit19
    IL_01B3: ldarg.1
    IL_01B4: ldarg.0
    IL_01B5: ldc.i4 1048576
    IL_01BA: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_01BF: ldc.i4.1
    IL_01C0: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_01C5: stfld System.Byte Z0.BitBlock32::Bit20
    IL_01CA: ldarg.1
    IL_01CB: ldarg.0
    IL_01CC: ldc.i4 2097152
    IL_01D1: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_01D6: ldc.i4.1
    IL_01D7: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_01DC: stfld System.Byte Z0.BitBlock32::Bit21
    IL_01E1: ldarg.1
    IL_01E2: ldarg.0
    IL_01E3: ldc.i4 4194304
    IL_01E8: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_01ED: ldc.i4.1
    IL_01EE: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_01F3: stfld System.Byte Z0.BitBlock32::Bit22
    IL_01F8: ldarg.1
    IL_01F9: ldarg.0
    IL_01FA: ldc.i4 8388608
    IL_01FF: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0204: ldc.i4.1
    IL_0205: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_020A: stfld System.Byte Z0.BitBlock32::Bit23
    IL_020F: ldarg.1
    IL_0210: ldarg.0
    IL_0211: ldc.i4 16777216
    IL_0216: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_021B: ldc.i4.1
    IL_021C: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0221: stfld System.Byte Z0.BitBlock32::Bit24
    IL_0226: ldarg.1
    IL_0227: ldarg.0
    IL_0228: ldc.i4 33554432
    IL_022D: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0232: ldc.i4.1
    IL_0233: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0238: stfld System.Byte Z0.BitBlock32::Bit25
    IL_023D: ldarg.1
    IL_023E: ldarg.0
    IL_023F: ldc.i4 67108864
    IL_0244: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0249: ldc.i4.1
    IL_024A: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_024F: stfld System.Byte Z0.BitBlock32::Bit26
    IL_0254: ldarg.1
    IL_0255: ldarg.0
    IL_0256: ldc.i4 134217728
    IL_025B: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0260: ldc.i4.1
    IL_0261: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0266: stfld System.Byte Z0.BitBlock32::Bit27
    IL_026B: ldarg.1
    IL_026C: ldarg.0
    IL_026D: ldc.i4 268435456
    IL_0272: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0277: ldc.i4.1
    IL_0278: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_027D: stfld System.Byte Z0.BitBlock32::Bit28
    IL_0282: ldarg.1
    IL_0283: ldarg.0
    IL_0284: ldc.i4 536870912
    IL_0289: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_028E: ldc.i4.1
    IL_028F: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0294: stfld System.Byte Z0.BitBlock32::Bit29
    IL_0299: ldarg.1
    IL_029A: ldarg.0
    IL_029B: ldc.i4 1073741824
    IL_02A0: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_02A5: ldc.i4.1
    IL_02A6: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_02AB: stfld System.Byte Z0.BitBlock32::Bit30
    IL_02B0: ldarg.1
    IL_02B1: ldarg.0
    IL_02B2: ldc.i4 -2147483648
    IL_02B7: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_02BC: ldc.i4.1
    IL_02BD: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_02C2: stfld System.Byte Z0.BitBlock32::Bit31
    IL_02C7: ldarg.1
    IL_02C8: ret

}
void part32x1(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.1
    IL_000A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_000F: ldc.i4.1
    IL_0010: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0015: stind.i1
    IL_0016: ldarga.s dst
    IL_0018: ldc.i4.1
    IL_0019: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldarg.0
    IL_001F: ldc.i4.2
    IL_0020: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0025: ldc.i4.1
    IL_0026: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_002B: stind.i1
    IL_002C: ldarga.s dst
    IL_002E: ldc.i4.2
    IL_002F: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0034: ldarg.0
    IL_0035: ldc.i4.4
    IL_0036: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_003B: ldc.i4.1
    IL_003C: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0041: stind.i1
    IL_0042: ldarga.s dst
    IL_0044: ldc.i4.3
    IL_0045: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_004A: ldarg.0
    IL_004B: ldc.i4.8
    IL_004C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0051: ldc.i4.1
    IL_0052: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0057: stind.i1
    IL_0058: ldarga.s dst
    IL_005A: ldc.i4.4
    IL_005B: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0060: ldarg.0
    IL_0061: ldc.i4.s 16
    IL_0063: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0068: ldc.i4.1
    IL_0069: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_006E: stind.i1
    IL_006F: ldarga.s dst
    IL_0071: ldc.i4.5
    IL_0072: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0077: ldarg.0
    IL_0078: ldc.i4.s 32
    IL_007A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_007F: ldc.i4.1
    IL_0080: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0085: stind.i1
    IL_0086: ldarga.s dst
    IL_0088: ldc.i4.6
    IL_0089: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_008E: ldarg.0
    IL_008F: ldc.i4.s 64
    IL_0091: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0096: ldc.i4.1
    IL_0097: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_009C: stind.i1
    IL_009D: ldarga.s dst
    IL_009F: ldc.i4.7
    IL_00A0: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00A5: ldarg.0
    IL_00A6: ldc.i4 128
    IL_00AB: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_00B0: ldc.i4.1
    IL_00B1: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_00B6: stind.i1
    IL_00B7: ldarga.s dst
    IL_00B9: ldc.i4.8
    IL_00BA: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00BF: ldarg.0
    IL_00C0: ldc.i4 256
    IL_00C5: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_00CA: ldc.i4.1
    IL_00CB: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_00D0: stind.i1
    IL_00D1: ldarga.s dst
    IL_00D3: ldc.i4.s 9
    IL_00D5: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00DA: ldarg.0
    IL_00DB: ldc.i4 512
    IL_00E0: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_00E5: ldc.i4.1
    IL_00E6: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_00EB: stind.i1
    IL_00EC: ldarga.s dst
    IL_00EE: ldc.i4.s 10
    IL_00F0: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00F5: ldarg.0
    IL_00F6: ldc.i4 1024
    IL_00FB: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0100: ldc.i4.1
    IL_0101: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0106: stind.i1
    IL_0107: ldarga.s dst
    IL_0109: ldc.i4.s 11
    IL_010B: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0110: ldarg.0
    IL_0111: ldc.i4 2048
    IL_0116: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_011B: ldc.i4.1
    IL_011C: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0121: stind.i1
    IL_0122: ldarga.s dst
    IL_0124: ldc.i4.s 12
    IL_0126: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_012B: ldarg.0
    IL_012C: ldc.i4 4096
    IL_0131: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0136: ldc.i4.1
    IL_0137: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_013C: stind.i1
    IL_013D: ldarga.s dst
    IL_013F: ldc.i4.s 13
    IL_0141: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0146: ldarg.0
    IL_0147: ldc.i4 8192
    IL_014C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0151: ldc.i4.1
    IL_0152: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0157: stind.i1
    IL_0158: ldarga.s dst
    IL_015A: ldc.i4.s 14
    IL_015C: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0161: ldarg.0
    IL_0162: ldc.i4 16384
    IL_0167: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_016C: ldc.i4.1
    IL_016D: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0172: stind.i1
    IL_0173: ldarga.s dst
    IL_0175: ldc.i4.s 15
    IL_0177: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_017C: ldarg.0
    IL_017D: ldc.i4 32768
    IL_0182: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0187: ldc.i4.1
    IL_0188: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_018D: stind.i1
    IL_018E: ldarga.s dst
    IL_0190: ldc.i4.s 16
    IL_0192: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0197: ldarg.0
    IL_0198: ldc.i4 65536
    IL_019D: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_01A2: ldc.i4.1
    IL_01A3: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_01A8: stind.i1
    IL_01A9: ldarga.s dst
    IL_01AB: ldc.i4.s 17
    IL_01AD: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_01B2: ldarg.0
    IL_01B3: ldc.i4 131072
    IL_01B8: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_01BD: ldc.i4.1
    IL_01BE: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_01C3: stind.i1
    IL_01C4: ldarga.s dst
    IL_01C6: ldc.i4.s 18
    IL_01C8: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_01CD: ldarg.0
    IL_01CE: ldc.i4 262144
    IL_01D3: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_01D8: ldc.i4.1
    IL_01D9: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_01DE: stind.i1
    IL_01DF: ldarga.s dst
    IL_01E1: ldc.i4.s 19
    IL_01E3: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_01E8: ldarg.0
    IL_01E9: ldc.i4 524288
    IL_01EE: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_01F3: ldc.i4.1
    IL_01F4: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_01F9: stind.i1
    IL_01FA: ldarga.s dst
    IL_01FC: ldc.i4.s 20
    IL_01FE: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0203: ldarg.0
    IL_0204: ldc.i4 1048576
    IL_0209: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_020E: ldc.i4.1
    IL_020F: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0214: stind.i1
    IL_0215: ldarga.s dst
    IL_0217: ldc.i4.s 21
    IL_0219: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_021E: ldarg.0
    IL_021F: ldc.i4 2097152
    IL_0224: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0229: ldc.i4.1
    IL_022A: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_022F: stind.i1
    IL_0230: ldarga.s dst
    IL_0232: ldc.i4.s 22
    IL_0234: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0239: ldarg.0
    IL_023A: ldc.i4 4194304
    IL_023F: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0244: ldc.i4.1
    IL_0245: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_024A: stind.i1
    IL_024B: ldarga.s dst
    IL_024D: ldc.i4.s 23
    IL_024F: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0254: ldarg.0
    IL_0255: ldc.i4 8388608
    IL_025A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_025F: ldc.i4.1
    IL_0260: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0265: stind.i1
    IL_0266: ldarga.s dst
    IL_0268: ldc.i4.s 24
    IL_026A: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_026F: ldarg.0
    IL_0270: ldc.i4 16777216
    IL_0275: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_027A: ldc.i4.1
    IL_027B: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0280: stind.i1
    IL_0281: ldarga.s dst
    IL_0283: ldc.i4.s 25
    IL_0285: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_028A: ldarg.0
    IL_028B: ldc.i4 33554432
    IL_0290: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0295: ldc.i4.1
    IL_0296: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_029B: stind.i1
    IL_029C: ldarga.s dst
    IL_029E: ldc.i4.s 26
    IL_02A0: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_02A5: ldarg.0
    IL_02A6: ldc.i4 67108864
    IL_02AB: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_02B0: ldc.i4.1
    IL_02B1: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_02B6: stind.i1
    IL_02B7: ldarga.s dst
    IL_02B9: ldc.i4.s 27
    IL_02BB: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_02C0: ldarg.0
    IL_02C1: ldc.i4 134217728
    IL_02C6: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_02CB: ldc.i4.1
    IL_02CC: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_02D1: stind.i1
    IL_02D2: ldarga.s dst
    IL_02D4: ldc.i4.s 28
    IL_02D6: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_02DB: ldarg.0
    IL_02DC: ldc.i4 268435456
    IL_02E1: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_02E6: ldc.i4.1
    IL_02E7: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_02EC: stind.i1
    IL_02ED: ldarga.s dst
    IL_02EF: ldc.i4.s 29
    IL_02F1: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_02F6: ldarg.0
    IL_02F7: ldc.i4 536870912
    IL_02FC: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0301: ldc.i4.1
    IL_0302: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0307: stind.i1
    IL_0308: ldarga.s dst
    IL_030A: ldc.i4.s 30
    IL_030C: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0311: ldarg.0
    IL_0312: ldc.i4 1073741824
    IL_0317: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_031C: ldc.i4.1
    IL_031D: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_0322: stind.i1
    IL_0323: ldarga.s dst
    IL_0325: ldc.i4.s 31
    IL_0327: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_032C: ldarg.0
    IL_032D: ldc.i4 -2147483648
    IL_0332: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x1)
    IL_0337: ldc.i4.1
    IL_0338: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x1)
    IL_033D: stind.i1
    IL_033E: ret

}
Span<byte> part32x1(uint src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.BitBlock32
    IL_0008: ldarg.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.BitBlock32& Z0.BitParts::part32x1(System.UInt32,Z0.BitBlock32&)
    IL_0010: call System.Span`1<System.Byte> Z0.BitBlock::AsSpan<Z0.BitBlock32>(Z0.BitBlock32&)
    IL_0015: ret

}
void part8x2(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.3
    IL_000A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x2)
    IL_000F: ldc.i4.3
    IL_0010: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x2)
    IL_0015: stind.i1
    IL_0016: ldarga.s dst
    IL_0018: ldc.i4.1
    IL_0019: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldarg.0
    IL_001F: ldc.i4.s 12
    IL_0021: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x2)
    IL_0026: ldc.i4.3
    IL_0027: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x2)
    IL_002C: stind.i1
    IL_002D: ldarga.s dst
    IL_002F: ldc.i4.2
    IL_0030: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0035: ldarg.0
    IL_0036: ldc.i4.s 48
    IL_0038: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x2)
    IL_003D: ldc.i4.3
    IL_003E: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x2)
    IL_0043: stind.i1
    IL_0044: ldarga.s dst
    IL_0046: ldc.i4.3
    IL_0047: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_004C: ldarg.0
    IL_004D: ldc.i4 192
    IL_0052: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x2)
    IL_0057: ldc.i4.3
    IL_0058: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x2)
    IL_005D: stind.i1
    IL_005E: ret

}
void part16x2(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.3
    IL_000A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part16x2)
    IL_000F: ldc.i4.3
    IL_0010: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part16x2)
    IL_0015: stind.i1
    IL_0016: ldarga.s dst
    IL_0018: ldc.i4.1
    IL_0019: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldarg.0
    IL_001F: ldc.i4.s 12
    IL_0021: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part16x2)
    IL_0026: ldc.i4.3
    IL_0027: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part16x2)
    IL_002C: stind.i1
    IL_002D: ldarga.s dst
    IL_002F: ldc.i4.2
    IL_0030: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0035: ldarg.0
    IL_0036: ldc.i4.s 48
    IL_0038: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part16x2)
    IL_003D: ldc.i4.3
    IL_003E: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part16x2)
    IL_0043: stind.i1
    IL_0044: ldarga.s dst
    IL_0046: ldc.i4.3
    IL_0047: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_004C: ldarg.0
    IL_004D: ldc.i4 192
    IL_0052: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part16x2)
    IL_0057: ldc.i4.3
    IL_0058: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part16x2)
    IL_005D: stind.i1
    IL_005E: ldarga.s dst
    IL_0060: ldc.i4.4
    IL_0061: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0066: ldarg.0
    IL_0067: ldc.i4 768
    IL_006C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part16x2)
    IL_0071: ldc.i4.3
    IL_0072: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part16x2)
    IL_0077: stind.i1
    IL_0078: ldarga.s dst
    IL_007A: ldc.i4.5
    IL_007B: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0080: ldarg.0
    IL_0081: ldc.i4 3072
    IL_0086: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part16x2)
    IL_008B: ldc.i4.3
    IL_008C: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part16x2)
    IL_0091: stind.i1
    IL_0092: ldarga.s dst
    IL_0094: ldc.i4.6
    IL_0095: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_009A: ldarg.0
    IL_009B: ldc.i4 12288
    IL_00A0: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part16x2)
    IL_00A5: ldc.i4.3
    IL_00A6: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part16x2)
    IL_00AB: stind.i1
    IL_00AC: ldarga.s dst
    IL_00AE: ldc.i4.7
    IL_00AF: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00B4: ldarg.0
    IL_00B5: ldc.i4 49152
    IL_00BA: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part16x2)
    IL_00BF: ldc.i4.3
    IL_00C0: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part16x2)
    IL_00C5: stind.i1
    IL_00C6: ret

}
void part32x2(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.3
    IL_000A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x2)
    IL_000F: ldc.i4.3
    IL_0010: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x2)
    IL_0015: stind.i1
    IL_0016: ldarga.s dst
    IL_0018: ldc.i4.1
    IL_0019: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldarg.0
    IL_001F: ldc.i4.s 12
    IL_0021: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x2)
    IL_0026: ldc.i4.3
    IL_0027: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x2)
    IL_002C: stind.i1
    IL_002D: ldarga.s dst
    IL_002F: ldc.i4.2
    IL_0030: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0035: ldarg.0
    IL_0036: ldc.i4.s 48
    IL_0038: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x2)
    IL_003D: ldc.i4.3
    IL_003E: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x2)
    IL_0043: stind.i1
    IL_0044: ldarga.s dst
    IL_0046: ldc.i4.3
    IL_0047: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_004C: ldarg.0
    IL_004D: ldc.i4 192
    IL_0052: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x2)
    IL_0057: ldc.i4.3
    IL_0058: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x2)
    IL_005D: stind.i1
    IL_005E: ldarga.s dst
    IL_0060: ldc.i4.4
    IL_0061: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0066: ldarg.0
    IL_0067: ldc.i4 768
    IL_006C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x2)
    IL_0071: ldc.i4.3
    IL_0072: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x2)
    IL_0077: stind.i1
    IL_0078: ldarga.s dst
    IL_007A: ldc.i4.5
    IL_007B: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0080: ldarg.0
    IL_0081: ldc.i4 3072
    IL_0086: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x2)
    IL_008B: ldc.i4.3
    IL_008C: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x2)
    IL_0091: stind.i1
    IL_0092: ldarga.s dst
    IL_0094: ldc.i4.6
    IL_0095: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_009A: ldarg.0
    IL_009B: ldc.i4 12288
    IL_00A0: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x2)
    IL_00A5: ldc.i4.3
    IL_00A6: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x2)
    IL_00AB: stind.i1
    IL_00AC: ldarga.s dst
    IL_00AE: ldc.i4.7
    IL_00AF: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00B4: ldarg.0
    IL_00B5: ldc.i4 49152
    IL_00BA: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x2)
    IL_00BF: ldc.i4.3
    IL_00C0: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x2)
    IL_00C5: stind.i1
    IL_00C6: ldarga.s dst
    IL_00C8: ldc.i4.8
    IL_00C9: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00CE: ldarg.0
    IL_00CF: ldc.i4 196608
    IL_00D4: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x2)
    IL_00D9: ldc.i4.3
    IL_00DA: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x2)
    IL_00DF: stind.i1
    IL_00E0: ldarga.s dst
    IL_00E2: ldc.i4.s 9
    IL_00E4: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00E9: ldarg.0
    IL_00EA: ldc.i4 786432
    IL_00EF: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x2)
    IL_00F4: ldc.i4.3
    IL_00F5: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x2)
    IL_00FA: stind.i1
    IL_00FB: ldarga.s dst
    IL_00FD: ldc.i4.s 10
    IL_00FF: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0104: ldarg.0
    IL_0105: ldc.i4 3145728
    IL_010A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x2)
    IL_010F: ldc.i4.3
    IL_0110: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x2)
    IL_0115: stind.i1
    IL_0116: ldarga.s dst
    IL_0118: ldc.i4.s 11
    IL_011A: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_011F: ldarg.0
    IL_0120: ldc.i4 12582912
    IL_0125: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x2)
    IL_012A: ldc.i4.3
    IL_012B: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x2)
    IL_0130: stind.i1
    IL_0131: ldarga.s dst
    IL_0133: ldc.i4.s 12
    IL_0135: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_013A: ldarg.0
    IL_013B: ldc.i4 50331648
    IL_0140: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x2)
    IL_0145: ldc.i4.3
    IL_0146: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x2)
    IL_014B: stind.i1
    IL_014C: ldarga.s dst
    IL_014E: ldc.i4.s 13
    IL_0150: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0155: ldarg.0
    IL_0156: ldc.i4 201326592
    IL_015B: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x2)
    IL_0160: ldc.i4.3
    IL_0161: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x2)
    IL_0166: stind.i1
    IL_0167: ldarga.s dst
    IL_0169: ldc.i4.s 14
    IL_016B: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0170: ldarg.0
    IL_0171: ldc.i4 805306368
    IL_0176: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x2)
    IL_017B: ldc.i4.3
    IL_017C: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x2)
    IL_0181: stind.i1
    IL_0182: ldarga.s dst
    IL_0184: ldc.i4.s 15
    IL_0186: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_018B: ldarg.0
    IL_018C: ldc.i4 -1073741824
    IL_0191: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x2)
    IL_0196: ldc.i4.3
    IL_0197: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x2)
    IL_019C: stind.i1
    IL_019D: ret

}
void part6x3(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.7
    IL_000A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part6x3)
    IL_000F: ldc.i4.7
    IL_0010: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part6x3)
    IL_0015: stind.i1
    IL_0016: ldarga.s dst
    IL_0018: ldc.i4.1
    IL_0019: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldarg.0
    IL_001F: ldc.i4.s 56
    IL_0021: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part6x3)
    IL_0026: ldc.i4.7
    IL_0027: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part6x3)
    IL_002C: stind.i1
    IL_002D: ret

}
void part9x3(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.7
    IL_000A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x3)
    IL_000F: ldc.i4.7
    IL_0010: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x3)
    IL_0015: stind.i1
    IL_0016: ldarga.s dst
    IL_0018: ldc.i4.1
    IL_0019: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldarg.0
    IL_001F: ldc.i4.s 56
    IL_0021: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x3)
    IL_0026: ldc.i4.7
    IL_0027: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x3)
    IL_002C: stind.i1
    IL_002D: ldarga.s dst
    IL_002F: ldc.i4.2
    IL_0030: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0035: ldarg.0
    IL_0036: ldc.i4 448
    IL_003B: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part9x3)
    IL_0040: ldc.i4.7
    IL_0041: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part9x3)
    IL_0046: stind.i1
    IL_0047: ret

}
void part12x3(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.7
    IL_000A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part12x3)
    IL_000F: ldc.i4.7
    IL_0010: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part12x3)
    IL_0015: stind.i1
    IL_0016: ldarga.s dst
    IL_0018: ldc.i4.1
    IL_0019: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldarg.0
    IL_001F: ldc.i4.s 56
    IL_0021: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part12x3)
    IL_0026: ldc.i4.7
    IL_0027: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part12x3)
    IL_002C: stind.i1
    IL_002D: ldarga.s dst
    IL_002F: ldc.i4.2
    IL_0030: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0035: ldarg.0
    IL_0036: ldc.i4 448
    IL_003B: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part12x3)
    IL_0040: ldc.i4.7
    IL_0041: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part12x3)
    IL_0046: stind.i1
    IL_0047: ldarga.s dst
    IL_0049: ldc.i4.3
    IL_004A: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_004F: ldarg.0
    IL_0050: ldc.i4 3584
    IL_0055: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part12x3)
    IL_005A: ldc.i4.7
    IL_005B: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part12x3)
    IL_0060: stind.i1
    IL_0061: ret

}
void part15x3(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.7
    IL_000A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part15x3)
    IL_000F: ldc.i4.7
    IL_0010: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part15x3)
    IL_0015: stind.i1
    IL_0016: ldarga.s dst
    IL_0018: ldc.i4.1
    IL_0019: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldarg.0
    IL_001F: ldc.i4.s 56
    IL_0021: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part15x3)
    IL_0026: ldc.i4.7
    IL_0027: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part15x3)
    IL_002C: stind.i1
    IL_002D: ldarga.s dst
    IL_002F: ldc.i4.2
    IL_0030: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0035: ldarg.0
    IL_0036: ldc.i4 448
    IL_003B: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part15x3)
    IL_0040: ldc.i4.7
    IL_0041: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part15x3)
    IL_0046: stind.i1
    IL_0047: ldarga.s dst
    IL_0049: ldc.i4.3
    IL_004A: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_004F: ldarg.0
    IL_0050: ldc.i4 3584
    IL_0055: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part15x3)
    IL_005A: ldc.i4.7
    IL_005B: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part15x3)
    IL_0060: stind.i1
    IL_0061: ldarga.s dst
    IL_0063: ldc.i4.4
    IL_0064: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0069: ldarg.0
    IL_006A: ldc.i4 28672
    IL_006F: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part15x3)
    IL_0074: ldc.i4.7
    IL_0075: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part15x3)
    IL_007A: stind.i1
    IL_007B: ret

}
void part18x3(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.7
    IL_000A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part18x3)
    IL_000F: ldc.i4.7
    IL_0010: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part18x3)
    IL_0015: stind.i1
    IL_0016: ldarga.s dst
    IL_0018: ldc.i4.1
    IL_0019: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldarg.0
    IL_001F: ldc.i4.s 56
    IL_0021: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part18x3)
    IL_0026: ldc.i4.7
    IL_0027: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part18x3)
    IL_002C: stind.i1
    IL_002D: ldarga.s dst
    IL_002F: ldc.i4.2
    IL_0030: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0035: ldarg.0
    IL_0036: ldc.i4 448
    IL_003B: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part18x3)
    IL_0040: ldc.i4.7
    IL_0041: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part18x3)
    IL_0046: stind.i1
    IL_0047: ldarga.s dst
    IL_0049: ldc.i4.3
    IL_004A: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_004F: ldarg.0
    IL_0050: ldc.i4 3584
    IL_0055: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part18x3)
    IL_005A: ldc.i4.7
    IL_005B: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part18x3)
    IL_0060: stind.i1
    IL_0061: ldarga.s dst
    IL_0063: ldc.i4.4
    IL_0064: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0069: ldarg.0
    IL_006A: ldc.i4 28672
    IL_006F: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part18x3)
    IL_0074: ldc.i4.7
    IL_0075: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part18x3)
    IL_007A: stind.i1
    IL_007B: ldarga.s dst
    IL_007D: ldc.i4.5
    IL_007E: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0083: ldarg.0
    IL_0084: ldc.i4 229376
    IL_0089: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part18x3)
    IL_008E: ldc.i4.7
    IL_008F: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part18x3)
    IL_0094: stind.i1
    IL_0095: ret

}
void part21x3(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.7
    IL_000A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part21x3)
    IL_000F: ldc.i4.7
    IL_0010: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part21x3)
    IL_0015: stind.i1
    IL_0016: ldarga.s dst
    IL_0018: ldc.i4.1
    IL_0019: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldarg.0
    IL_001F: ldc.i4.s 56
    IL_0021: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part21x3)
    IL_0026: ldc.i4.7
    IL_0027: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part21x3)
    IL_002C: stind.i1
    IL_002D: ldarga.s dst
    IL_002F: ldc.i4.2
    IL_0030: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0035: ldarg.0
    IL_0036: ldc.i4 448
    IL_003B: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part21x3)
    IL_0040: ldc.i4.7
    IL_0041: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part21x3)
    IL_0046: stind.i1
    IL_0047: ldarga.s dst
    IL_0049: ldc.i4.3
    IL_004A: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_004F: ldarg.0
    IL_0050: ldc.i4 3584
    IL_0055: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part21x3)
    IL_005A: ldc.i4.7
    IL_005B: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part21x3)
    IL_0060: stind.i1
    IL_0061: ldarga.s dst
    IL_0063: ldc.i4.4
    IL_0064: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0069: ldarg.0
    IL_006A: ldc.i4 28672
    IL_006F: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part21x3)
    IL_0074: ldc.i4.7
    IL_0075: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part21x3)
    IL_007A: stind.i1
    IL_007B: ldarga.s dst
    IL_007D: ldc.i4.5
    IL_007E: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0083: ldarg.0
    IL_0084: ldc.i4 229376
    IL_0089: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part21x3)
    IL_008E: ldc.i4.7
    IL_008F: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part21x3)
    IL_0094: stind.i1
    IL_0095: ldarga.s dst
    IL_0097: ldc.i4.6
    IL_0098: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_009D: ldarg.0
    IL_009E: ldc.i4 1835008
    IL_00A3: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part21x3)
    IL_00A8: ldc.i4.7
    IL_00A9: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part21x3)
    IL_00AE: stind.i1
    IL_00AF: ret

}
void part24x3(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.7
    IL_000A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part24x3)
    IL_000F: ldc.i4.7
    IL_0010: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part24x3)
    IL_0015: stind.i1
    IL_0016: ldarga.s dst
    IL_0018: ldc.i4.1
    IL_0019: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldarg.0
    IL_001F: ldc.i4.s 56
    IL_0021: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part24x3)
    IL_0026: ldc.i4.7
    IL_0027: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part24x3)
    IL_002C: stind.i1
    IL_002D: ldarga.s dst
    IL_002F: ldc.i4.2
    IL_0030: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0035: ldarg.0
    IL_0036: ldc.i4 448
    IL_003B: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part24x3)
    IL_0040: ldc.i4.7
    IL_0041: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part24x3)
    IL_0046: stind.i1
    IL_0047: ldarga.s dst
    IL_0049: ldc.i4.3
    IL_004A: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_004F: ldarg.0
    IL_0050: ldc.i4 3584
    IL_0055: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part24x3)
    IL_005A: ldc.i4.7
    IL_005B: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part24x3)
    IL_0060: stind.i1
    IL_0061: ldarga.s dst
    IL_0063: ldc.i4.4
    IL_0064: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0069: ldarg.0
    IL_006A: ldc.i4 28672
    IL_006F: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part24x3)
    IL_0074: ldc.i4.7
    IL_0075: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part24x3)
    IL_007A: stind.i1
    IL_007B: ldarga.s dst
    IL_007D: ldc.i4.5
    IL_007E: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0083: ldarg.0
    IL_0084: ldc.i4 229376
    IL_0089: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part24x3)
    IL_008E: ldc.i4.7
    IL_008F: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part24x3)
    IL_0094: stind.i1
    IL_0095: ldarga.s dst
    IL_0097: ldc.i4.6
    IL_0098: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_009D: ldarg.0
    IL_009E: ldc.i4 1835008
    IL_00A3: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part24x3)
    IL_00A8: ldc.i4.7
    IL_00A9: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part24x3)
    IL_00AE: stind.i1
    IL_00AF: ldarga.s dst
    IL_00B1: ldc.i4.7
    IL_00B2: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00B7: ldarg.0
    IL_00B8: ldc.i4 14680064
    IL_00BD: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part24x3)
    IL_00C2: ldc.i4.7
    IL_00C3: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part24x3)
    IL_00C8: stind.i1
    IL_00C9: ret

}
void part27x3(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.7
    IL_000A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part27x3)
    IL_000F: ldc.i4.7
    IL_0010: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part27x3)
    IL_0015: stind.i1
    IL_0016: ldarga.s dst
    IL_0018: ldc.i4.1
    IL_0019: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldarg.0
    IL_001F: ldc.i4.s 56
    IL_0021: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part27x3)
    IL_0026: ldc.i4.7
    IL_0027: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part27x3)
    IL_002C: stind.i1
    IL_002D: ldarga.s dst
    IL_002F: ldc.i4.2
    IL_0030: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0035: ldarg.0
    IL_0036: ldc.i4 448
    IL_003B: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part27x3)
    IL_0040: ldc.i4.7
    IL_0041: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part27x3)
    IL_0046: stind.i1
    IL_0047: ldarga.s dst
    IL_0049: ldc.i4.3
    IL_004A: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_004F: ldarg.0
    IL_0050: ldc.i4 3584
    IL_0055: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part27x3)
    IL_005A: ldc.i4.7
    IL_005B: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part27x3)
    IL_0060: stind.i1
    IL_0061: ldarga.s dst
    IL_0063: ldc.i4.4
    IL_0064: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0069: ldarg.0
    IL_006A: ldc.i4 28672
    IL_006F: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part27x3)
    IL_0074: ldc.i4.7
    IL_0075: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part27x3)
    IL_007A: stind.i1
    IL_007B: ldarga.s dst
    IL_007D: ldc.i4.5
    IL_007E: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0083: ldarg.0
    IL_0084: ldc.i4 229376
    IL_0089: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part27x3)
    IL_008E: ldc.i4.7
    IL_008F: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part27x3)
    IL_0094: stind.i1
    IL_0095: ldarga.s dst
    IL_0097: ldc.i4.6
    IL_0098: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_009D: ldarg.0
    IL_009E: ldc.i4 1835008
    IL_00A3: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part27x3)
    IL_00A8: ldc.i4.7
    IL_00A9: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part27x3)
    IL_00AE: stind.i1
    IL_00AF: ldarga.s dst
    IL_00B1: ldc.i4.7
    IL_00B2: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00B7: ldarg.0
    IL_00B8: ldc.i4 14680064
    IL_00BD: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part27x3)
    IL_00C2: ldc.i4.7
    IL_00C3: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part27x3)
    IL_00C8: stind.i1
    IL_00C9: ldarga.s dst
    IL_00CB: ldc.i4.8
    IL_00CC: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00D1: ldarg.0
    IL_00D2: ldc.i4 117440512
    IL_00D7: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part27x3)
    IL_00DC: ldc.i4.7
    IL_00DD: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part27x3)
    IL_00E2: stind.i1
    IL_00E3: ret

}
void part30x3(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.7
    IL_000A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part30x3)
    IL_000F: ldc.i4.7
    IL_0010: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part30x3)
    IL_0015: stind.i1
    IL_0016: ldarga.s dst
    IL_0018: ldc.i4.1
    IL_0019: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldarg.0
    IL_001F: ldc.i4.s 56
    IL_0021: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part30x3)
    IL_0026: ldc.i4.7
    IL_0027: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part30x3)
    IL_002C: stind.i1
    IL_002D: ldarga.s dst
    IL_002F: ldc.i4.2
    IL_0030: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0035: ldarg.0
    IL_0036: ldc.i4 448
    IL_003B: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part30x3)
    IL_0040: ldc.i4.7
    IL_0041: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part30x3)
    IL_0046: stind.i1
    IL_0047: ldarga.s dst
    IL_0049: ldc.i4.3
    IL_004A: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_004F: ldarg.0
    IL_0050: ldc.i4 3584
    IL_0055: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part30x3)
    IL_005A: ldc.i4.7
    IL_005B: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part30x3)
    IL_0060: stind.i1
    IL_0061: ldarga.s dst
    IL_0063: ldc.i4.4
    IL_0064: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0069: ldarg.0
    IL_006A: ldc.i4 28672
    IL_006F: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part30x3)
    IL_0074: ldc.i4.7
    IL_0075: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part30x3)
    IL_007A: stind.i1
    IL_007B: ldarga.s dst
    IL_007D: ldc.i4.5
    IL_007E: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0083: ldarg.0
    IL_0084: ldc.i4 229376
    IL_0089: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part30x3)
    IL_008E: ldc.i4.7
    IL_008F: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part30x3)
    IL_0094: stind.i1
    IL_0095: ldarga.s dst
    IL_0097: ldc.i4.6
    IL_0098: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_009D: ldarg.0
    IL_009E: ldc.i4 1835008
    IL_00A3: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part30x3)
    IL_00A8: ldc.i4.7
    IL_00A9: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part30x3)
    IL_00AE: stind.i1
    IL_00AF: ldarga.s dst
    IL_00B1: ldc.i4.7
    IL_00B2: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00B7: ldarg.0
    IL_00B8: ldc.i4 14680064
    IL_00BD: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part30x3)
    IL_00C2: ldc.i4.7
    IL_00C3: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part30x3)
    IL_00C8: stind.i1
    IL_00C9: ldarga.s dst
    IL_00CB: ldc.i4.8
    IL_00CC: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00D1: ldarg.0
    IL_00D2: ldc.i4 117440512
    IL_00D7: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part30x3)
    IL_00DC: ldc.i4.7
    IL_00DD: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part30x3)
    IL_00E2: stind.i1
    IL_00E3: ldarga.s dst
    IL_00E5: ldc.i4.s 9
    IL_00E7: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00EC: ldarg.0
    IL_00ED: ldc.i4 939524096
    IL_00F2: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part30x3)
    IL_00F7: ldc.i4.7
    IL_00F8: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part30x3)
    IL_00FD: stind.i1
    IL_00FE: ret

}
void part8x4(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 15
    IL_000B: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x4)
    IL_0010: ldc.i4.s 15
    IL_0012: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x4)
    IL_0017: stind.i1
    IL_0018: ldarga.s dst
    IL_001A: ldc.i4.1
    IL_001B: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0020: ldarg.0
    IL_0021: ldc.i4 240
    IL_0026: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part8x4)
    IL_002B: ldc.i4.s 15
    IL_002D: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part8x4)
    IL_0032: stind.i1
    IL_0033: ret

}
void part12x4(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 15
    IL_000B: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part12x4)
    IL_0010: ldc.i4.s 15
    IL_0012: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part12x4)
    IL_0017: stind.i1
    IL_0018: ldarga.s dst
    IL_001A: ldc.i4.1
    IL_001B: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0020: ldarg.0
    IL_0021: ldc.i4 240
    IL_0026: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part12x4)
    IL_002B: ldc.i4.s 15
    IL_002D: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part12x4)
    IL_0032: stind.i1
    IL_0033: ldarga.s dst
    IL_0035: ldc.i4.2
    IL_0036: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_003B: ldarg.0
    IL_003C: ldc.i4 3840
    IL_0041: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part12x4)
    IL_0046: ldc.i4.s 15
    IL_0048: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part12x4)
    IL_004D: stind.i1
    IL_004E: ret

}
void part16x4(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 15
    IL_000B: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part16x4)
    IL_0010: ldc.i4.s 15
    IL_0012: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part16x4)
    IL_0017: stind.i1
    IL_0018: ldarga.s dst
    IL_001A: ldc.i4.1
    IL_001B: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0020: ldarg.0
    IL_0021: ldc.i4 240
    IL_0026: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part16x4)
    IL_002B: ldc.i4.s 15
    IL_002D: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part16x4)
    IL_0032: stind.i1
    IL_0033: ldarga.s dst
    IL_0035: ldc.i4.2
    IL_0036: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_003B: ldarg.0
    IL_003C: ldc.i4 3840
    IL_0041: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part16x4)
    IL_0046: ldc.i4.s 15
    IL_0048: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part16x4)
    IL_004D: stind.i1
    IL_004E: ldarga.s dst
    IL_0050: ldc.i4.3
    IL_0051: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0056: ldarg.0
    IL_0057: ldc.i4 61440
    IL_005C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part16x4)
    IL_0061: ldc.i4.s 15
    IL_0063: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part16x4)
    IL_0068: stind.i1
    IL_0069: ret

}
void part32x4(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 15
    IL_000B: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x4)
    IL_0010: ldc.i4.s 15
    IL_0012: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x4)
    IL_0017: stind.i1
    IL_0018: ldarga.s dst
    IL_001A: ldc.i4.1
    IL_001B: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0020: ldarg.0
    IL_0021: ldc.i4 240
    IL_0026: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x4)
    IL_002B: ldc.i4.s 15
    IL_002D: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x4)
    IL_0032: stind.i1
    IL_0033: ldarga.s dst
    IL_0035: ldc.i4.2
    IL_0036: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_003B: ldarg.0
    IL_003C: ldc.i4 3840
    IL_0041: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x4)
    IL_0046: ldc.i4.s 15
    IL_0048: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x4)
    IL_004D: stind.i1
    IL_004E: ldarga.s dst
    IL_0050: ldc.i4.3
    IL_0051: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0056: ldarg.0
    IL_0057: ldc.i4 61440
    IL_005C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x4)
    IL_0061: ldc.i4.s 15
    IL_0063: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x4)
    IL_0068: stind.i1
    IL_0069: ldarga.s dst
    IL_006B: ldc.i4.4
    IL_006C: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0071: ldarg.0
    IL_0072: ldc.i4 983040
    IL_0077: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x4)
    IL_007C: ldc.i4.s 15
    IL_007E: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x4)
    IL_0083: stind.i1
    IL_0084: ldarga.s dst
    IL_0086: ldc.i4.5
    IL_0087: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_008C: ldarg.0
    IL_008D: ldc.i4 15728640
    IL_0092: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x4)
    IL_0097: ldc.i4.s 15
    IL_0099: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x4)
    IL_009E: stind.i1
    IL_009F: ldarga.s dst
    IL_00A1: ldc.i4.6
    IL_00A2: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00A7: ldarg.0
    IL_00A8: ldc.i4 251658240
    IL_00AD: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x4)
    IL_00B2: ldc.i4.s 15
    IL_00B4: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x4)
    IL_00B9: stind.i1
    IL_00BA: ldarga.s dst
    IL_00BC: ldc.i4.7
    IL_00BD: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00C2: ldarg.0
    IL_00C3: ldc.i4 -268435456
    IL_00C8: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x4)
    IL_00CD: ldc.i4.s 15
    IL_00CF: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x4)
    IL_00D4: stind.i1
    IL_00D5: ret

}
void part16x8(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4 255
    IL_000E: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part16x8)
    IL_0013: ldc.i4 255
    IL_0018: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part16x8)
    IL_001D: stind.i1
    IL_001E: ldarga.s dst
    IL_0020: ldc.i4.1
    IL_0021: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0026: ldarg.0
    IL_0027: ldc.i4 65280
    IL_002C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part16x8)
    IL_0031: ldc.i4 255
    IL_0036: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part16x8)
    IL_003B: stind.i1
    IL_003C: ret

}
void part32x8(uint src, Span<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: ldc.i4 255
    IL_000E: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x8)
    IL_0013: ldc.i4 255
    IL_0018: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x8)
    IL_001D: stind.i1
    IL_001E: ldarga.s dst
    IL_0020: ldc.i4.1
    IL_0021: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0026: ldarg.0
    IL_0027: ldc.i4 65280
    IL_002C: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x8)
    IL_0031: ldc.i4 255
    IL_0036: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x8)
    IL_003B: stind.i1
    IL_003C: ldarga.s dst
    IL_003E: ldc.i4.2
    IL_003F: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0044: ldarg.0
    IL_0045: ldc.i4 16711680
    IL_004A: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x8)
    IL_004F: ldc.i4 255
    IL_0054: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x8)
    IL_0059: stind.i1
    IL_005A: ldarga.s dst
    IL_005C: ldc.i4.3
    IL_005D: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0062: ldarg.0
    IL_0063: ldc.i4 -16777216
    IL_0068: call System.UInt32 Z0.Bits::select(System.UInt32,Z0.BitParts/Part32x8)
    IL_006D: ldc.i4 255
    IL_0072: call System.Byte Z0.Bits::project<System.Byte>(System.UInt32,Z0.BitParts/Part32x8)
    IL_0077: stind.i1
    IL_0078: ret

}

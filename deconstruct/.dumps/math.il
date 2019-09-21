// 2019-09-20 23:12:22:977
Span<long> xor(Span<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\xor.cs"
    IL_000C: ldc.i4 305
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int64>(System.Span`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i8
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0032: ldind.i8
    IL_0033: xor
    IL_0034: stind.i8
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<ulong> xor(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\xor.cs"
    IL_000C: ldc.i4 313
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt64>(System.Span`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i8
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0032: ldind.i8
    IL_0033: xor
    IL_0034: stind.i8
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<sbyte> xor(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\xor.cs"
    IL_000C: ldc.i4 322
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0030: ldind.i1
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0039: ldind.i1
    IL_003A: call System.SByte Z0.math::xor(System.SByte,System.SByte)
    IL_003F: stind.i1
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<byte> xor(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\xor.cs"
    IL_000C: ldc.i4 330
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0030: ldind.u1
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0039: ldind.u1
    IL_003A: call System.Byte Z0.math::xor(System.Byte,System.Byte)
    IL_003F: stind.i1
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<short> xor(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\xor.cs"
    IL_000C: ldc.i4 338
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0030: ldind.i2
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0039: ldind.i2
    IL_003A: call System.Int16 Z0.math::xor(System.Int16,System.Int16)
    IL_003F: stind.i2
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<ushort> xor(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\xor.cs"
    IL_000C: ldc.i4 346
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0030: ldind.u2
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0039: ldind.u2
    IL_003A: call System.UInt16 Z0.math::xor(System.UInt16,System.UInt16)
    IL_003F: stind.i2
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<int> xor(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\xor.cs"
    IL_000C: ldc.i4 354
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0030: ldind.i4
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0039: ldind.i4
    IL_003A: call System.Int32 Z0.math::xor(System.Int32,System.Int32)
    IL_003F: stind.i4
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<uint> xor(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\xor.cs"
    IL_000C: ldc.i4 362
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0030: ldind.u4
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0039: ldind.u4
    IL_003A: call System.UInt32 Z0.math::xor(System.UInt32,System.UInt32)
    IL_003F: stind.i4
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<long> xor(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\xor.cs"
    IL_000C: ldc.i4 370
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0039: ldind.i8
    IL_003A: call System.Int64 Z0.math::xor(System.Int64,System.Int64)
    IL_003F: stind.i8
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<ulong> xor(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\xor.cs"
    IL_000C: ldc.i4 378
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0039: ldind.i8
    IL_003A: call System.UInt64 Z0.math::xor(System.UInt64,System.UInt64)
    IL_003F: stind.i8
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
ref long square(ref long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.0
    IL_0004: ldind.i8
    IL_0005: mul
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ulong square(ref ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.0
    IL_0004: ldind.i8
    IL_0005: mul
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
ref float square(ref float src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: ldarg.0
    IL_0004: ldind.r4
    IL_0005: mul
    IL_0006: stind.r4
    IL_0007: ldarg.0
    IL_0008: ret

}
ref double square(ref double src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldarg.0
    IL_0004: ldind.r8
    IL_0005: mul
    IL_0006: stind.r8
    IL_0007: ldarg.0
    IL_0008: ret

}
ref sbyte square(sbyte src, out sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.SByte& Z0.math::square(System.SByte&)
    IL_0008: ldind.i1
    IL_0009: stind.i1
    IL_000A: ldarg.1
    IL_000B: ret

}
ref byte square(byte src, out byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.Byte& Z0.math::square(System.Byte&)
    IL_0008: ldind.u1
    IL_0009: stind.i1
    IL_000A: ldarg.1
    IL_000B: ret

}
ref short square(short src, out short dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.Int16& Z0.math::square(System.Int16&)
    IL_0008: ldind.i2
    IL_0009: stind.i2
    IL_000A: ldarg.1
    IL_000B: ret

}
ref ushort square(ushort src, out ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.UInt16& Z0.math::square(System.UInt16&)
    IL_0008: ldind.u2
    IL_0009: stind.i2
    IL_000A: ldarg.1
    IL_000B: ret

}
ref int square(int src, out int dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.Int32& Z0.math::square(System.Int32&)
    IL_0008: ldind.i4
    IL_0009: stind.i4
    IL_000A: ldarg.1
    IL_000B: ret

}
ref uint square(uint src, out uint dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.UInt32& Z0.math::square(System.UInt32&)
    IL_0008: ldind.u4
    IL_0009: stind.i4
    IL_000A: ldarg.1
    IL_000B: ret

}
ref long square(long src, out long dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.Int64& Z0.math::square(System.Int64&)
    IL_0008: ldind.i8
    IL_0009: stind.i8
    IL_000A: ldarg.1
    IL_000B: ret

}
ref ulong square(ulong src, out ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.UInt64& Z0.math::square(System.UInt64&)
    IL_0008: ldind.i8
    IL_0009: stind.i8
    IL_000A: ldarg.1
    IL_000B: ret

}
ref float square(float src, out float dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.Single& Z0.math::square(System.Single&)
    IL_0008: ldind.r4
    IL_0009: stind.r4
    IL_000A: ldarg.1
    IL_000B: ret

}
ref double square(double src, out double dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.Double& Z0.math::square(System.Double&)
    IL_0008: ldind.r8
    IL_0009: stind.r8
    IL_000A: ldarg.1
    IL_000B: ret

}
sbyte sub(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: conv.i1
    IL_0004: ret

}
byte sub(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: conv.u1
    IL_0004: ret

}
short sub(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: conv.i2
    IL_0004: ret

}
ushort sub(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: conv.u2
    IL_0004: ret

}
int sub(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ret

}
uint sub(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ret

}
long sub(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ret

}
ulong sub(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ret

}
float sub(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ret

}
double sub(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ret

}
ref sbyte sub(ref sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: sub
    IL_0005: conv.i1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref byte sub(ref byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: sub
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref short sub(ref short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: sub
    IL_0005: conv.i2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ushort sub(ref ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: sub
    IL_0005: conv.u2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref int sub(ref int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: sub
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref uint sub(ref uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: sub
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref long sub(ref long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: sub
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref ulong sub(ref ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: sub
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref float sub(ref float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: ldarg.1
    IL_0004: sub
    IL_0005: stind.r4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref double sub(ref double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldarg.1
    IL_0004: sub
    IL_0005: stind.r8
    IL_0006: ldarg.0
    IL_0007: ret

}
Span<sbyte> sub(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 132
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0030: ldind.i1
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0039: ldind.i1
    IL_003A: call System.SByte Z0.math::sub(System.SByte,System.SByte)
    IL_003F: stind.i1
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<byte> sub(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 140
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0030: ldind.u1
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0039: ldind.u1
    IL_003A: call System.Byte Z0.math::sub(System.Byte,System.Byte)
    IL_003F: stind.i1
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<short> sub(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 148
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0030: ldind.i2
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0039: ldind.i2
    IL_003A: call System.Int16 Z0.math::sub(System.Int16,System.Int16)
    IL_003F: stind.i2
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<ushort> sub(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 156
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0030: ldind.u2
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0039: ldind.u2
    IL_003A: call System.UInt16 Z0.math::sub(System.UInt16,System.UInt16)
    IL_003F: stind.i2
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<int> sub(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 164
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0030: ldind.i4
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0039: ldind.i4
    IL_003A: call System.Int32 Z0.math::sub(System.Int32,System.Int32)
    IL_003F: stind.i4
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<uint> sub(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 172
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0030: ldind.u4
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0039: ldind.u4
    IL_003A: call System.UInt32 Z0.math::sub(System.UInt32,System.UInt32)
    IL_003F: stind.i4
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<long> sub(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 180
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0039: ldind.i8
    IL_003A: call System.Int64 Z0.math::sub(System.Int64,System.Int64)
    IL_003F: stind.i8
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<ulong> sub(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 188
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0039: ldind.i8
    IL_003A: call System.UInt64 Z0.math::sub(System.UInt64,System.UInt64)
    IL_003F: stind.i8
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<float> sub(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 196
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Single,System.Single>(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0030: ldind.r4
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0039: ldind.r4
    IL_003A: call System.Single Z0.math::sub(System.Single,System.Single)
    IL_003F: stind.r4
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<double> sub(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 204
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Double,System.Double>(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0030: ldind.r8
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0039: ldind.r8
    IL_003A: call System.Double Z0.math::sub(System.Double,System.Double)
    IL_003F: stind.r8
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<sbyte> sub(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 212
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.SByte>(System.Span`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i1
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0032: ldind.i1
    IL_0033: sub
    IL_0034: conv.i1
    IL_0035: stind.i1
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<byte> sub(Span<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 220
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Byte>(System.Span`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u1
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0032: ldind.u1
    IL_0033: sub
    IL_0034: conv.u1
    IL_0035: stind.i1
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<short> sub(Span<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 228
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int16>(System.Span`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i2
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0032: ldind.i2
    IL_0033: sub
    IL_0034: conv.i2
    IL_0035: stind.i2
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<ushort> sub(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 236
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt16>(System.Span`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u2
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0032: ldind.u2
    IL_0033: sub
    IL_0034: conv.u2
    IL_0035: stind.i2
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<int> sub(Span<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 244
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int32>(System.Span`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i4
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0032: ldind.i4
    IL_0033: sub
    IL_0034: stind.i4
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<uint> sub(Span<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 252
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt32>(System.Span`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u4
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0032: ldind.u4
    IL_0033: sub
    IL_0034: stind.i4
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<long> sub(Span<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 260
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int64>(System.Span`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i8
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0032: ldind.i8
    IL_0033: sub
    IL_0034: stind.i8
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<ulong> sub(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 268
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt64>(System.Span`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i8
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0032: ldind.i8
    IL_0033: sub
    IL_0034: stind.i8
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<float> sub(Span<float> lhs, ReadOnlySpan<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 276
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Single>(System.Span`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.r4
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0032: ldind.r4
    IL_0033: sub
    IL_0034: stind.r4
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<double> sub(Span<double> lhs, ReadOnlySpan<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\sub.cs"
    IL_000C: ldc.i4 284
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Double>(System.Span`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.r8
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0032: ldind.r8
    IL_0033: sub
    IL_0034: stind.r8
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
sbyte sum(ReadOnlySpan<sbyte> src)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0004: br.s IL_0017
    IL_0006: ldloc.0
    IL_0007: ldarga.s src
    IL_0009: ldloc.1
    IL_000A: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_000F: ldind.i1
    IL_0010: add.ovf
    IL_0011: conv.ovf.i1
    IL_0012: stloc.0
    IL_0013: ldloc.1
    IL_0014: ldc.i4.1
    IL_0015: add.ovf
    IL_0016: stloc.1
    IL_0017: ldloc.1
    IL_0018: ldarga.s src
    IL_001A: call System.Int32 System.ReadOnlySpan`1<System.SByte>::get_Length()
    IL_001F: blt.s IL_0006
    IL_0021: ldloc.0
    IL_0022: ret

}
byte sum(ReadOnlySpan<byte> src)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0004: br.s IL_0017
    IL_0006: ldloc.0
    IL_0007: ldarga.s src
    IL_0009: ldloc.1
    IL_000A: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_000F: ldind.u1
    IL_0010: add.ovf
    IL_0011: conv.ovf.u1
    IL_0012: stloc.0
    IL_0013: ldloc.1
    IL_0014: ldc.i4.1
    IL_0015: add.ovf
    IL_0016: stloc.1
    IL_0017: ldloc.1
    IL_0018: ldarga.s src
    IL_001A: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_001F: blt.s IL_0006
    IL_0021: ldloc.0
    IL_0022: ret

}
short sum(ReadOnlySpan<short> src)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0004: br.s IL_0017
    IL_0006: ldloc.0
    IL_0007: ldarga.s src
    IL_0009: ldloc.1
    IL_000A: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_000F: ldind.i2
    IL_0010: add.ovf
    IL_0011: conv.ovf.i2
    IL_0012: stloc.0
    IL_0013: ldloc.1
    IL_0014: ldc.i4.1
    IL_0015: add.ovf
    IL_0016: stloc.1
    IL_0017: ldloc.1
    IL_0018: ldarga.s src
    IL_001A: call System.Int32 System.ReadOnlySpan`1<System.Int16>::get_Length()
    IL_001F: blt.s IL_0006
    IL_0021: ldloc.0
    IL_0022: ret

}
ushort sum(ReadOnlySpan<ushort> src)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0004: br.s IL_0017
    IL_0006: ldloc.0
    IL_0007: ldarga.s src
    IL_0009: ldloc.1
    IL_000A: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_000F: ldind.u2
    IL_0010: add.ovf
    IL_0011: conv.ovf.u2
    IL_0012: stloc.0
    IL_0013: ldloc.1
    IL_0014: ldc.i4.1
    IL_0015: add.ovf
    IL_0016: stloc.1
    IL_0017: ldloc.1
    IL_0018: ldarga.s src
    IL_001A: call System.Int32 System.ReadOnlySpan`1<System.UInt16>::get_Length()
    IL_001F: blt.s IL_0006
    IL_0021: ldloc.0
    IL_0022: ret

}
int sum(ReadOnlySpan<int> src)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0004: br.s IL_0016
    IL_0006: ldloc.0
    IL_0007: ldarga.s src
    IL_0009: ldloc.1
    IL_000A: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_000F: ldind.i4
    IL_0010: add.ovf
    IL_0011: stloc.0
    IL_0012: ldloc.1
    IL_0013: ldc.i4.1
    IL_0014: add.ovf
    IL_0015: stloc.1
    IL_0016: ldloc.1
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.ReadOnlySpan`1<System.Int32>::get_Length()
    IL_001E: blt.s IL_0006
    IL_0020: ldloc.0
    IL_0021: ret

}
uint sum(ReadOnlySpan<uint> src)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0004: br.s IL_0016
    IL_0006: ldloc.0
    IL_0007: ldarga.s src
    IL_0009: ldloc.1
    IL_000A: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_000F: ldind.u4
    IL_0010: add.ovf.un
    IL_0011: stloc.0
    IL_0012: ldloc.1
    IL_0013: ldc.i4.1
    IL_0014: add.ovf
    IL_0015: stloc.1
    IL_0016: ldloc.1
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.ReadOnlySpan`1<System.UInt32>::get_Length()
    IL_001E: blt.s IL_0006
    IL_0020: ldloc.0
    IL_0021: ret

}
long sum(ReadOnlySpan<long> src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldc.i4.0
    IL_0004: stloc.1
    IL_0005: br.s IL_0017
    IL_0007: ldloc.0
    IL_0008: ldarga.s src
    IL_000A: ldloc.1
    IL_000B: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0010: ldind.i8
    IL_0011: add.ovf
    IL_0012: stloc.0
    IL_0013: ldloc.1
    IL_0014: ldc.i4.1
    IL_0015: add.ovf
    IL_0016: stloc.1
    IL_0017: ldloc.1
    IL_0018: ldarga.s src
    IL_001A: call System.Int32 System.ReadOnlySpan`1<System.Int64>::get_Length()
    IL_001F: blt.s IL_0007
    IL_0021: ldloc.0
    IL_0022: ret

}
ulong sum(ReadOnlySpan<ulong> src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldc.i4.0
    IL_0004: stloc.1
    IL_0005: br.s IL_0017
    IL_0007: ldloc.0
    IL_0008: ldarga.s src
    IL_000A: ldloc.1
    IL_000B: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0010: ldind.i8
    IL_0011: add.ovf.un
    IL_0012: stloc.0
    IL_0013: ldloc.1
    IL_0014: ldc.i4.1
    IL_0015: add.ovf
    IL_0016: stloc.1
    IL_0017: ldloc.1
    IL_0018: ldarga.s src
    IL_001A: call System.Int32 System.ReadOnlySpan`1<System.UInt64>::get_Length()
    IL_001F: blt.s IL_0007
    IL_0021: ldloc.0
    IL_0022: ret

}
float sum(ReadOnlySpan<float> src)
{
    IL_0000: ldc.r4 0
    IL_0005: stloc.0
    IL_0006: ldc.i4.0
    IL_0007: stloc.1
    IL_0008: br.s IL_001A
    IL_000A: ldloc.0
    IL_000B: ldarga.s src
    IL_000D: ldloc.1
    IL_000E: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0013: ldind.r4
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.1
    IL_0017: ldc.i4.1
    IL_0018: add.ovf
    IL_0019: stloc.1
    IL_001A: ldloc.1
    IL_001B: ldarga.s src
    IL_001D: call System.Int32 System.ReadOnlySpan`1<System.Single>::get_Length()
    IL_0022: blt.s IL_000A
    IL_0024: ldloc.0
    IL_0025: ret

}
double sum(ReadOnlySpan<double> src)
{
    IL_0000: ldc.r8 0
    IL_0009: stloc.0
    IL_000A: ldc.i4.0
    IL_000B: stloc.1
    IL_000C: br.s IL_001E
    IL_000E: ldloc.0
    IL_000F: ldarga.s src
    IL_0011: ldloc.1
    IL_0012: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0017: ldind.r8
    IL_0018: add
    IL_0019: stloc.0
    IL_001A: ldloc.1
    IL_001B: ldc.i4.1
    IL_001C: add.ovf
    IL_001D: stloc.1
    IL_001E: ldloc.1
    IL_001F: ldarga.s src
    IL_0021: call System.Int32 System.ReadOnlySpan`1<System.Double>::get_Length()
    IL_0026: blt.s IL_000E
    IL_0028: ldloc.0
    IL_0029: ret

}
bool within(byte lhs, byte rhs, byte epsilon)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_000E
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ldarg.2
    IL_0008: cgt
    IL_000A: ldc.i4.0
    IL_000B: ceq
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: sub
    IL_0011: ldarg.2
    IL_0012: cgt
    IL_0014: ldc.i4.0
    IL_0015: ceq
    IL_0017: ret

}
bool within(sbyte lhs, sbyte rhs, sbyte epsilon)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_000E
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ldarg.2
    IL_0008: cgt
    IL_000A: ldc.i4.0
    IL_000B: ceq
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: sub
    IL_0011: ldarg.2
    IL_0012: cgt
    IL_0014: ldc.i4.0
    IL_0015: ceq
    IL_0017: ret

}
bool within(short lhs, short rhs, short epsilon)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_000E
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ldarg.2
    IL_0008: cgt
    IL_000A: ldc.i4.0
    IL_000B: ceq
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: sub
    IL_0011: ldarg.2
    IL_0012: cgt
    IL_0014: ldc.i4.0
    IL_0015: ceq
    IL_0017: ret

}
bool within(ushort lhs, ushort rhs, ushort epsilon)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_000E
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ldarg.2
    IL_0008: cgt
    IL_000A: ldc.i4.0
    IL_000B: ceq
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: sub
    IL_0011: ldarg.2
    IL_0012: cgt
    IL_0014: ldc.i4.0
    IL_0015: ceq
    IL_0017: ret

}
bool within(int lhs, int rhs, int epsilon)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_000E
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ldarg.2
    IL_0008: cgt
    IL_000A: ldc.i4.0
    IL_000B: ceq
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: sub
    IL_0011: ldarg.2
    IL_0012: cgt
    IL_0014: ldc.i4.0
    IL_0015: ceq
    IL_0017: ret

}
bool within(uint lhs, uint rhs, uint epsilon)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.un.s IL_000E
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ldarg.2
    IL_0008: cgt.un
    IL_000A: ldc.i4.0
    IL_000B: ceq
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: sub
    IL_0011: ldarg.2
    IL_0012: cgt.un
    IL_0014: ldc.i4.0
    IL_0015: ceq
    IL_0017: ret

}
bool within(long lhs, long rhs, long epsilon)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_000E
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ldarg.2
    IL_0008: cgt
    IL_000A: ldc.i4.0
    IL_000B: ceq
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: sub
    IL_0011: ldarg.2
    IL_0012: cgt
    IL_0014: ldc.i4.0
    IL_0015: ceq
    IL_0017: ret

}
bool within(ulong lhs, ulong rhs, ulong epsilon)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.un.s IL_000E
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ldarg.2
    IL_0008: cgt.un
    IL_000A: ldc.i4.0
    IL_000B: ceq
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: sub
    IL_0011: ldarg.2
    IL_0012: cgt.un
    IL_0014: ldc.i4.0
    IL_0015: ceq
    IL_0017: ret

}
bool within(float lhs, float rhs, float epsilon)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_000E
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ldarg.2
    IL_0008: cgt.un
    IL_000A: ldc.i4.0
    IL_000B: ceq
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: sub
    IL_0011: ldarg.2
    IL_0012: cgt.un
    IL_0014: ldc.i4.0
    IL_0015: ceq
    IL_0017: ret

}
bool within(double lhs, double rhs, double epsilon)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_000E
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ldarg.2
    IL_0008: cgt.un
    IL_000A: ldc.i4.0
    IL_000B: ceq
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: sub
    IL_0011: ldarg.2
    IL_0012: cgt.un
    IL_0014: ldc.i4.0
    IL_0015: ceq
    IL_0017: ret

}
byte width(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_0009
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: br.s IL_000C
    IL_0009: ldarg.0
    IL_000A: ldarg.1
    IL_000B: sub
    IL_000C: conv.u1
    IL_000D: ret

}
ushort width(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_0009
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: br.s IL_000C
    IL_0009: ldarg.0
    IL_000A: ldarg.1
    IL_000B: sub
    IL_000C: conv.u2
    IL_000D: ret

}
uint width(short lhs, short rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: sub
    IL_0003: call System.Int32 Z0.math::abs(System.Int32)
    IL_0008: ret

}
ulong width(int lhs, int rhs)
{
    IL_0000: ldarg.1
    IL_0001: conv.i8
    IL_0002: ldarg.0
    IL_0003: conv.i8
    IL_0004: sub
    IL_0005: call System.Int64 Z0.math::abs(System.Int64)
    IL_000A: ret

}
ulong width(long lhs, long rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: sub
    IL_0003: call System.Int64 Z0.math::abs(System.Int64)
    IL_0008: ret

}
ushort width(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_0009
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: br.s IL_000C
    IL_0009: ldarg.0
    IL_000A: ldarg.1
    IL_000B: sub
    IL_000C: conv.u2
    IL_000D: ret

}
uint width(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.un.s IL_0008
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ret
    IL_0008: ldarg.0
    IL_0009: ldarg.1
    IL_000A: sub
    IL_000B: ret

}
ulong width(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.un.s IL_0008
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ret
    IL_0008: ldarg.0
    IL_0009: ldarg.1
    IL_000A: sub
    IL_000B: ret

}
double width(float lhs, float rhs)
{
    IL_0000: ldarg.1
    IL_0001: conv.r8
    IL_0002: ldarg.0
    IL_0003: conv.r8
    IL_0004: sub
    IL_0005: call System.Double Z0.math::abs(System.Double)
    IL_000A: ret

}
double width(double lhs, double rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: sub
    IL_0003: call System.Double Z0.math::abs(System.Double)
    IL_0008: ret

}
sbyte xor(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: conv.i1
    IL_0004: ret

}
byte xor(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: conv.u1
    IL_0004: ret

}
short xor(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: conv.i2
    IL_0004: ret

}
ushort xor(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: conv.u2
    IL_0004: ret

}
int xor(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret

}
uint xor(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret

}
long xor(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret

}
ulong xor(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret

}
float xor(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0006: ldarg.1
    IL_0007: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_000C: xor
    IL_000D: call System.Single System.BitConverter::Int32BitsToSingle(System.Int32)
    IL_0012: ret

}
double xor(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0006: ldarg.1
    IL_0007: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_000C: xor
    IL_000D: call System.Double System.BitConverter::Int64BitsToDouble(System.Int64)
    IL_0012: ret

}
ref sbyte xor(ref sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: xor
    IL_0005: conv.i1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref byte xor(ref byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: xor
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref short xor(ref short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: xor
    IL_0005: conv.i2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ushort xor(ref ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: xor
    IL_0005: conv.u2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref int xor(ref int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: xor
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref uint xor(ref uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: xor
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref long xor(ref long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: xor
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref ulong xor(ref ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: xor
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref float xor(ref float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: ldarg.1
    IL_0004: call System.Single Z0.math::xor(System.Single,System.Single)
    IL_0009: stind.r4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref double xor(ref double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldarg.1
    IL_0004: call System.Double Z0.math::xor(System.Double,System.Double)
    IL_0009: stind.r8
    IL_000A: ldarg.0
    IL_000B: ret

}
ref sbyte xor(in sbyte lhs, in sbyte rhs, ref sbyte dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: ldind.i1
    IL_0005: xor
    IL_0006: conv.i1
    IL_0007: stind.i1
    IL_0008: ldarg.2
    IL_0009: ret

}
ref byte xor(in byte lhs, in byte rhs, ref byte dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldind.u1
    IL_0005: xor
    IL_0006: conv.u1
    IL_0007: stind.i1
    IL_0008: ldarg.2
    IL_0009: ret

}
ref short xor(in short lhs, in short rhs, ref short dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: ldind.i2
    IL_0005: xor
    IL_0006: conv.i2
    IL_0007: stind.i2
    IL_0008: ldarg.2
    IL_0009: ret

}
ref ushort xor(in ushort lhs, in ushort rhs, ref ushort dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldind.u2
    IL_0005: xor
    IL_0006: conv.u2
    IL_0007: stind.i2
    IL_0008: ldarg.2
    IL_0009: ret

}
ref int xor(in int lhs, in int rhs, ref int dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: ldind.i4
    IL_0005: xor
    IL_0006: stind.i4
    IL_0007: ldarg.2
    IL_0008: ret

}
ref uint xor(in uint lhs, in uint rhs, ref uint dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldind.u4
    IL_0005: xor
    IL_0006: stind.i4
    IL_0007: ldarg.2
    IL_0008: ret

}
ref long xor(in long lhs, in long rhs, ref long dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: xor
    IL_0006: stind.i8
    IL_0007: ldarg.2
    IL_0008: ret

}
ref ulong xor(in ulong lhs, in ulong rhs, ref ulong dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: xor
    IL_0006: stind.i8
    IL_0007: ldarg.2
    IL_0008: ret

}
ref float xor(in float lhs, in float rhs, ref float dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0008: ldarg.1
    IL_0009: ldind.r4
    IL_000A: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_000F: xor
    IL_0010: call System.Single System.BitConverter::Int32BitsToSingle(System.Int32)
    IL_0015: stind.r4
    IL_0016: ldarg.2
    IL_0017: ret

}
ref double xor(in double lhs, in double rhs, ref double dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0008: ldarg.1
    IL_0009: ldind.r8
    IL_000A: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_000F: xor
    IL_0010: call System.Double System.BitConverter::Int64BitsToDouble(System.Int64)
    IL_0015: stind.r8
    IL_0016: ldarg.2
    IL_0017: ret

}
Span<sbyte> xor(Span<sbyte> lhs, sbyte rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i1
    IL_000E: ldarg.1
    IL_000F: xor
    IL_0010: conv.i1
    IL_0011: stind.i1
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s lhs
    IL_0019: call System.Int32 System.Span`1<System.SByte>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<byte> xor(Span<byte> lhs, byte rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.u1
    IL_000E: ldarg.1
    IL_000F: xor
    IL_0010: conv.u1
    IL_0011: stind.i1
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s lhs
    IL_0019: call System.Int32 System.Span`1<System.Byte>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<short> xor(Span<short> lhs, short rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i2
    IL_000E: ldarg.1
    IL_000F: xor
    IL_0010: conv.i2
    IL_0011: stind.i2
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s lhs
    IL_0019: call System.Int32 System.Span`1<System.Int16>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<ushort> xor(Span<ushort> lhs, ushort rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.u2
    IL_000E: ldarg.1
    IL_000F: xor
    IL_0010: conv.u2
    IL_0011: stind.i2
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s lhs
    IL_0019: call System.Int32 System.Span`1<System.UInt16>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<int> xor(Span<int> lhs, int rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i4
    IL_000E: ldarg.1
    IL_000F: xor
    IL_0010: stind.i4
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.Int32>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
Span<uint> xor(Span<uint> lhs, uint rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.u4
    IL_000E: ldarg.1
    IL_000F: xor
    IL_0010: stind.i4
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.UInt32>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
Span<long> xor(Span<long> lhs, long rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i8
    IL_000E: ldarg.1
    IL_000F: xor
    IL_0010: stind.i8
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.Int64>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
Span<ulong> xor(Span<ulong> lhs, ulong rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i8
    IL_000E: ldarg.1
    IL_000F: xor
    IL_0010: stind.i8
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.UInt64>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
Span<sbyte> xor(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\xor.cs"
    IL_000C: ldc.i4 257
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.SByte>(System.Span`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i1
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0032: ldind.i1
    IL_0033: xor
    IL_0034: conv.i1
    IL_0035: stind.i1
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<byte> xor(Span<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\xor.cs"
    IL_000C: ldc.i4 265
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Byte>(System.Span`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u1
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0032: ldind.u1
    IL_0033: xor
    IL_0034: conv.u1
    IL_0035: stind.i1
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<short> xor(Span<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\xor.cs"
    IL_000C: ldc.i4 273
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int16>(System.Span`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i2
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0032: ldind.i2
    IL_0033: xor
    IL_0034: conv.i2
    IL_0035: stind.i2
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<ushort> xor(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\xor.cs"
    IL_000C: ldc.i4 281
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt16>(System.Span`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u2
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0032: ldind.u2
    IL_0033: xor
    IL_0034: conv.u2
    IL_0035: stind.i2
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<int> xor(Span<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\xor.cs"
    IL_000C: ldc.i4 289
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int32>(System.Span`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i4
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0032: ldind.i4
    IL_0033: xor
    IL_0034: stind.i4
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<uint> xor(Span<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\xor.cs"
    IL_000C: ldc.i4 297
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt32>(System.Span`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u4
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0032: ldind.u4
    IL_0033: xor
    IL_0034: stind.i4
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
bool neq(in short lhs, in short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i2
    IL_0002: ldarg.1
    IL_0003: ldind.i2
    IL_0004: ceq
    IL_0006: ldc.i4.0
    IL_0007: ceq
    IL_0009: ret

}
bool neq(in ushort lhs, in ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u2
    IL_0002: ldarg.1
    IL_0003: ldind.u2
    IL_0004: ceq
    IL_0006: ldc.i4.0
    IL_0007: ceq
    IL_0009: ret

}
bool neq(in int lhs, in int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i4
    IL_0002: ldarg.1
    IL_0003: ldind.i4
    IL_0004: ceq
    IL_0006: ldc.i4.0
    IL_0007: ceq
    IL_0009: ret

}
bool neq(in uint lhs, in uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u4
    IL_0002: ldarg.1
    IL_0003: ldind.u4
    IL_0004: ceq
    IL_0006: ldc.i4.0
    IL_0007: ceq
    IL_0009: ret

}
bool neq(in long lhs, in long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: ldarg.1
    IL_0003: ldind.i8
    IL_0004: ceq
    IL_0006: ldc.i4.0
    IL_0007: ceq
    IL_0009: ret

}
bool neq(in ulong lhs, in ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: ldarg.1
    IL_0003: ldind.i8
    IL_0004: ceq
    IL_0006: ldc.i4.0
    IL_0007: ceq
    IL_0009: ret

}
bool neq(in float lhs, in float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.r4
    IL_0002: ldarg.1
    IL_0003: ldind.r4
    IL_0004: ceq
    IL_0006: ldc.i4.0
    IL_0007: ceq
    IL_0009: ret

}
bool neq(in double lhs, in double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.r8
    IL_0002: ldarg.1
    IL_0003: ldind.r8
    IL_0004: ceq
    IL_0006: ldc.i4.0
    IL_0007: ceq
    IL_0009: ret

}
Span<bool> neq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0014: ldind.i1
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_001D: ldind.i1
    IL_001E: call System.Boolean Z0.math::neq(System.SByte,System.SByte)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.SByte>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> neq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0014: ldind.u1
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_001D: ldind.u1
    IL_001E: call System.Boolean Z0.math::neq(System.Byte,System.Byte)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> neq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0014: ldind.i2
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_001D: ldind.i2
    IL_001E: call System.Boolean Z0.math::neq(System.Int16,System.Int16)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Int16>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> neq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0014: ldind.u2
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_001D: ldind.u2
    IL_001E: call System.Boolean Z0.math::neq(System.UInt16,System.UInt16)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.UInt16>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> neq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0014: ldind.i4
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_001D: ldind.i4
    IL_001E: call System.Boolean Z0.math::neq(System.Int32,System.Int32)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Int32>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> neq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0014: ldind.u4
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_001D: ldind.u4
    IL_001E: call System.Boolean Z0.math::neq(System.UInt32,System.UInt32)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.UInt32>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> neq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_001D: ldind.i8
    IL_001E: call System.Boolean Z0.math::neq(System.Int64,System.Int64)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Int64>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> neq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_001D: ldind.i8
    IL_001E: call System.Boolean Z0.math::neq(System.UInt64,System.UInt64)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.UInt64>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> neq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0014: ldind.r4
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_001D: ldind.r4
    IL_001E: call System.Boolean Z0.math::neq(System.Single,System.Single)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Single>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> neq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0014: ldind.r8
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_001D: ldind.r8
    IL_001E: call System.Boolean Z0.math::neq(System.Double,System.Double)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Double>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> neq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "neq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\neq.cs"
    IL_000E: ldc.i4 171
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::neq(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> neq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "neq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\neq.cs"
    IL_000E: ldc.i4 175
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::neq(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> neq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "neq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\neq.cs"
    IL_000E: ldc.i4 179
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::neq(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> neq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "neq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\neq.cs"
    IL_000E: ldc.i4 183
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::neq(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> neq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "neq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\neq.cs"
    IL_000E: ldc.i4 187
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::neq(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> neq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "neq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\neq.cs"
    IL_000E: ldc.i4 191
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::neq(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> neq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "neq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\neq.cs"
    IL_000E: ldc.i4 195
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::neq(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> neq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "neq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\neq.cs"
    IL_000E: ldc.i4 199
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::neq(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> neq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "neq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\neq.cs"
    IL_000E: ldc.i4 203
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Single,System.Single>(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::neq(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> neq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "neq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\neq.cs"
    IL_000E: ldc.i4 207
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Double,System.Double>(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::neq(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
bool nonneg(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: clt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool nonneg(short src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: clt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool nonneg(int src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: clt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool nonneg(long src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: conv.i8
    IL_0003: clt
    IL_0005: ldc.i4.0
    IL_0006: ceq
    IL_0008: ret

}
bool nonneg(float src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r4 0
    IL_0006: clt.un
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret

}
bool nonneg(double src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r8 0
    IL_000A: clt.un
    IL_000C: ldc.i4.0
    IL_000D: ceq
    IL_000F: ret

}
bool nonzero(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: cgt.un
    IL_0004: ret

}
bool nonzero(byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: cgt.un
    IL_0004: ret

}
bool nonzero(short src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: cgt.un
    IL_0004: ret

}
bool nonzero(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: cgt.un
    IL_0004: ret

}
bool nonzero(int src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: cgt.un
    IL_0004: ret

}
bool nonzero(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: cgt.un
    IL_0004: ret

}
bool nonzero(long src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: conv.i8
    IL_0003: cgt.un
    IL_0005: ret

}
bool nonzero(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: conv.i8
    IL_0003: cgt.un
    IL_0005: ret

}
bool nonzero(float src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r4 0
    IL_0006: ceq
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret

}
bool nonzero(double src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r8 0
    IL_000A: ceq
    IL_000C: ldc.i4.0
    IL_000D: ceq
    IL_000F: ret

}
sbyte or(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: conv.i1
    IL_0004: ret

}
byte or(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: conv.u1
    IL_0004: ret

}
short or(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: conv.i2
    IL_0004: ret

}
ushort or(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: conv.u2
    IL_0004: ret

}
int or(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
uint or(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
long or(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
ulong or(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
float or(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0006: ldarg.1
    IL_0007: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_000C: or
    IL_000D: call System.Single System.BitConverter::Int32BitsToSingle(System.Int32)
    IL_0012: ret

}
double or(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0006: ldarg.1
    IL_0007: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_000C: or
    IL_000D: call System.Double System.BitConverter::Int64BitsToDouble(System.Int64)
    IL_0012: ret

}
ref sbyte or(ref sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: or
    IL_0005: conv.i1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref byte or(ref byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: or
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref short or(ref short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: or
    IL_0005: conv.i2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ushort or(ref ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: or
    IL_0005: conv.u2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref int or(ref int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: or
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref uint or(ref uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: or
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref long or(ref long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: or
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref ulong or(ref ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: or
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref float or(ref float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: ldarg.1
    IL_0004: call System.Single Z0.math::or(System.Single,System.Single)
    IL_0009: stind.r4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref double or(ref double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldarg.1
    IL_0004: call System.Double Z0.math::or(System.Double,System.Double)
    IL_0009: stind.r8
    IL_000A: ldarg.0
    IL_000B: ret

}
ref sbyte or(in sbyte lhs, in sbyte rhs, ref sbyte dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: ldind.i1
    IL_0005: or
    IL_0006: conv.i1
    IL_0007: stind.i1
    IL_0008: ldarg.2
    IL_0009: ret

}
ref byte or(in byte lhs, in byte rhs, ref byte dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldind.u1
    IL_0005: or
    IL_0006: conv.u1
    IL_0007: stind.i1
    IL_0008: ldarg.2
    IL_0009: ret

}
ref short or(in short lhs, in short rhs, ref short dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: ldind.i2
    IL_0005: or
    IL_0006: conv.i2
    IL_0007: stind.i2
    IL_0008: ldarg.2
    IL_0009: ret

}
ref ushort or(in ushort lhs, in ushort rhs, ref ushort dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldind.u2
    IL_0005: or
    IL_0006: conv.u2
    IL_0007: stind.i2
    IL_0008: ldarg.2
    IL_0009: ret

}
ref int or(in int lhs, in int rhs, ref int dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: ldind.i4
    IL_0005: or
    IL_0006: stind.i4
    IL_0007: ldarg.2
    IL_0008: ret

}
ref uint or(in uint lhs, in uint rhs, ref uint dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldind.u4
    IL_0005: or
    IL_0006: stind.i4
    IL_0007: ldarg.2
    IL_0008: ret

}
ref long or(in long lhs, in long rhs, ref long dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: or
    IL_0006: stind.i8
    IL_0007: ldarg.2
    IL_0008: ret

}
ref ulong or(in ulong lhs, in ulong rhs, ref ulong dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: or
    IL_0006: stind.i8
    IL_0007: ldarg.2
    IL_0008: ret

}
ref float or(in float lhs, in float rhs, ref float dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0008: ldarg.1
    IL_0009: ldind.r4
    IL_000A: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_000F: or
    IL_0010: call System.Single System.BitConverter::Int32BitsToSingle(System.Int32)
    IL_0015: stind.r4
    IL_0016: ldarg.2
    IL_0017: ret

}
ref double or(in double lhs, in double rhs, ref double dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0008: ldarg.1
    IL_0009: ldind.r8
    IL_000A: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_000F: or
    IL_0010: call System.Double System.BitConverter::Int64BitsToDouble(System.Int64)
    IL_0015: stind.r8
    IL_0016: ldarg.2
    IL_0017: ret

}
sbyte parse(string src, out sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.SByte System.SByte::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.i1
    IL_000A: ldloc.0
    IL_000B: ret

}
byte parse(string src, out byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Byte System.Byte::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.i1
    IL_000A: ldloc.0
    IL_000B: ret

}
short parse(string src, out short dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int16 System.Int16::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.i2
    IL_000A: ldloc.0
    IL_000B: ret

}
ushort parse(string src, out ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt16 System.UInt16::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.i2
    IL_000A: ldloc.0
    IL_000B: ret

}
int parse(string src, out int dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int32 System.Int32::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.i4
    IL_000A: ldloc.0
    IL_000B: ret

}
uint parse(string src, out uint dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt32 System.UInt32::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.i4
    IL_000A: ldloc.0
    IL_000B: ret

}
long parse(string src, out long dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int64 System.Int64::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.i8
    IL_000A: ldloc.0
    IL_000B: ret

}
ulong parse(string src, out ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt64 System.UInt64::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.i8
    IL_000A: ldloc.0
    IL_000B: ret

}
float parse(string src, out float dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Single System.Single::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.r4
    IL_000A: ldloc.0
    IL_000B: ret

}
double parse(string src, out double dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Double System.Double::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.r8
    IL_000A: ldloc.0
    IL_000B: ret

}
Decimal parse(string src, out Decimal dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Decimal System.Decimal::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stobj System.Decimal
    IL_000E: ldloc.0
    IL_000F: ret

}
BigInteger parse(string src, out BigInteger dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Numerics.BigInteger System.Numerics.BigInteger::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stobj System.Numerics.BigInteger
    IL_000E: ldloc.0
    IL_000F: ret

}
ref sbyte sal(ref sbyte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shl
    IL_0008: conv.i1
    IL_0009: stind.i1
    IL_000A: ldarg.0
    IL_000B: ret

}
ref byte sal(ref byte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shl
    IL_0008: conv.u1
    IL_0009: stind.i1
    IL_000A: ldarg.0
    IL_000B: ret

}
ref short sal(ref short src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shl
    IL_0008: conv.i2
    IL_0009: stind.i2
    IL_000A: ldarg.0
    IL_000B: ret

}
ref ushort sal(ref ushort src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shl
    IL_0008: conv.u2
    IL_0009: stind.i2
    IL_000A: ldarg.0
    IL_000B: ret

}
ref int sal(ref int src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shl
    IL_0008: stind.i4
    IL_0009: ldarg.0
    IL_000A: ret

}
ref uint sal(ref uint src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shl
    IL_0008: stind.i4
    IL_0009: ldarg.0
    IL_000A: ret

}
ref long sal(ref long src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 63
    IL_0006: and
    IL_0007: shl
    IL_0008: stind.i8
    IL_0009: ldarg.0
    IL_000A: ret

}
ref ulong sal(ref ulong src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 63
    IL_0006: and
    IL_0007: shl
    IL_0008: stind.i8
    IL_0009: ldarg.0
    IL_000A: ret

}
ref sbyte sar(ref sbyte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shr
    IL_0008: conv.i1
    IL_0009: stind.i1
    IL_000A: ldarg.0
    IL_000B: ret

}
ref byte sar(ref byte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shr
    IL_0008: conv.u1
    IL_0009: stind.i1
    IL_000A: ldarg.0
    IL_000B: ret

}
ref short sar(ref short src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shr
    IL_0008: conv.i2
    IL_0009: stind.i2
    IL_000A: ldarg.0
    IL_000B: ret

}
ref ushort sar(ref ushort src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shr
    IL_0008: conv.u2
    IL_0009: stind.i2
    IL_000A: ldarg.0
    IL_000B: ret

}
ref int sar(ref int src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shr
    IL_0008: stind.i4
    IL_0009: ldarg.0
    IL_000A: ret

}
ref uint sar(ref uint src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shr.un
    IL_0008: stind.i4
    IL_0009: ldarg.0
    IL_000A: ret

}
ref long sar(ref long src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 63
    IL_0006: and
    IL_0007: shr
    IL_0008: stind.i8
    IL_0009: ldarg.0
    IL_000A: ret

}
ref ulong sar(ref ulong src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 63
    IL_0006: and
    IL_0007: shr.un
    IL_0008: stind.i8
    IL_0009: ldarg.0
    IL_000A: ret

}
Span<sbyte> scale(ReadOnlySpan<sbyte> src, sbyte factor, Span<sbyte> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_000C: ldarga.s src
    IL_000E: ldloc.0
    IL_000F: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0014: ldind.i1
    IL_0015: ldarg.1
    IL_0016: call System.SByte Z0.math::mul(System.SByte,System.SByte)
    IL_001B: stind.i1
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s dst
    IL_0023: call System.Int32 System.Span`1<System.SByte>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.2
    IL_002B: ret

}
Span<byte> scale(ReadOnlySpan<byte> src, byte factor, Span<byte> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_000C: ldarga.s src
    IL_000E: ldloc.0
    IL_000F: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0014: ldind.u1
    IL_0015: ldarg.1
    IL_0016: call System.Byte Z0.math::mul(System.Byte,System.Byte)
    IL_001B: stind.i1
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s dst
    IL_0023: call System.Int32 System.Span`1<System.Byte>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.2
    IL_002B: ret

}
Span<short> scale(ReadOnlySpan<short> src, short factor, Span<short> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_000C: ldarga.s src
    IL_000E: ldloc.0
    IL_000F: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0014: ldind.i2
    IL_0015: ldarg.1
    IL_0016: call System.Int16 Z0.math::mul(System.Int16,System.Int16)
    IL_001B: stind.i2
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s dst
    IL_0023: call System.Int32 System.Span`1<System.Int16>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.2
    IL_002B: ret

}
Span<ushort> scale(ReadOnlySpan<ushort> src, ushort factor, Span<ushort> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_000C: ldarga.s src
    IL_000E: ldloc.0
    IL_000F: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0014: ldind.u2
    IL_0015: ldarg.1
    IL_0016: call System.UInt16 Z0.math::mul(System.UInt16,System.UInt16)
    IL_001B: stind.i2
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s dst
    IL_0023: call System.Int32 System.Span`1<System.UInt16>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.2
    IL_002B: ret

}
Span<int> scale(ReadOnlySpan<int> src, int factor, Span<int> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_000C: ldarga.s src
    IL_000E: ldloc.0
    IL_000F: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0014: ldind.i4
    IL_0015: ldarg.1
    IL_0016: call System.Int32 Z0.math::mul(System.Int32,System.Int32)
    IL_001B: stind.i4
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s dst
    IL_0023: call System.Int32 System.Span`1<System.Int32>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.2
    IL_002B: ret

}
Span<uint> scale(ReadOnlySpan<uint> src, uint factor, Span<uint> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_000C: ldarga.s src
    IL_000E: ldloc.0
    IL_000F: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0014: ldind.u4
    IL_0015: ldarg.1
    IL_0016: call System.UInt32 Z0.math::mul(System.UInt32,System.UInt32)
    IL_001B: stind.i4
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s dst
    IL_0023: call System.Int32 System.Span`1<System.UInt32>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.2
    IL_002B: ret

}
Span<long> scale(ReadOnlySpan<long> src, long factor, Span<long> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_000C: ldarga.s src
    IL_000E: ldloc.0
    IL_000F: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: ldarg.1
    IL_0016: call System.Int64 Z0.math::mul(System.Int64,System.Int64)
    IL_001B: stind.i8
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s dst
    IL_0023: call System.Int32 System.Span`1<System.Int64>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.2
    IL_002B: ret

}
Span<ulong> scale(ReadOnlySpan<ulong> src, ulong factor, Span<ulong> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_000C: ldarga.s src
    IL_000E: ldloc.0
    IL_000F: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: ldarg.1
    IL_0016: call System.UInt64 Z0.math::mul(System.UInt64,System.UInt64)
    IL_001B: stind.i8
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s dst
    IL_0023: call System.Int32 System.Span`1<System.UInt64>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.2
    IL_002B: ret

}
Span<float> scale(ReadOnlySpan<float> src, float factor, Span<float> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_000C: ldarga.s src
    IL_000E: ldloc.0
    IL_000F: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0014: ldind.r4
    IL_0015: ldarg.1
    IL_0016: call System.Single Z0.math::mul(System.Single,System.Single)
    IL_001B: stind.r4
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s dst
    IL_0023: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.2
    IL_002B: ret

}
Span<double> scale(ReadOnlySpan<double> src, double factor, Span<double> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_000C: ldarga.s src
    IL_000E: ldloc.0
    IL_000F: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0014: ldind.r8
    IL_0015: ldarg.1
    IL_0016: call System.Double Z0.math::mul(System.Double,System.Double)
    IL_001B: stind.r8
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s dst
    IL_0023: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.2
    IL_002B: ret

}
sbyte square(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.SByte Z0.math::mul(System.SByte,System.SByte)
    IL_0007: ret

}
byte square(byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.Byte Z0.math::mul(System.Byte,System.Byte)
    IL_0007: ret

}
short square(short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.Int16 Z0.math::mul(System.Int16,System.Int16)
    IL_0007: ret

}
ushort square(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.UInt16 Z0.math::mul(System.UInt16,System.UInt16)
    IL_0007: ret

}
int square(int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.Int32 Z0.math::mul(System.Int32,System.Int32)
    IL_0007: ret

}
uint square(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.UInt32 Z0.math::mul(System.UInt32,System.UInt32)
    IL_0007: ret

}
long square(long src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: call System.Double System.Math::Sqrt(System.Double)
    IL_0007: conv.i8
    IL_0008: ret

}
ulong square(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.UInt64 Z0.math::mul(System.UInt64,System.UInt64)
    IL_0007: ret

}
float square(float src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.Single Z0.math::mul(System.Single,System.Single)
    IL_0007: ret

}
double square(double src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.Double Z0.math::mul(System.Double,System.Double)
    IL_0007: ret

}
ref sbyte square(ref sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.0
    IL_0004: ldind.i1
    IL_0005: mul
    IL_0006: conv.i1
    IL_0007: stind.i1
    IL_0008: ldarg.0
    IL_0009: ret

}
ref byte square(ref byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.0
    IL_0004: ldind.u1
    IL_0005: mul
    IL_0006: conv.u1
    IL_0007: stind.i1
    IL_0008: ldarg.0
    IL_0009: ret

}
ref short square(ref short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.0
    IL_0004: ldind.i2
    IL_0005: mul
    IL_0006: conv.i2
    IL_0007: stind.i2
    IL_0008: ldarg.0
    IL_0009: ret

}
ref ushort square(ref ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.0
    IL_0004: ldind.u2
    IL_0005: mul
    IL_0006: conv.u2
    IL_0007: stind.i2
    IL_0008: ldarg.0
    IL_0009: ret

}
ref int square(ref int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.0
    IL_0004: ldind.i4
    IL_0005: mul
    IL_0006: stind.i4
    IL_0007: ldarg.0
    IL_0008: ret

}
ref uint square(ref uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.0
    IL_0004: ldind.u4
    IL_0005: mul
    IL_0006: stind.i4
    IL_0007: ldarg.0
    IL_0008: ret

}
int min(ReadOnlySpan<int> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.Int32>::get_IsEmpty()
    IL_0007: brfalse.s IL_000B
    IL_0009: ldc.i4.0
    IL_000A: ret
    IL_000B: ldarga.s src
    IL_000D: ldc.i4.0
    IL_000E: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0013: ldind.i4
    IL_0014: stloc.0
    IL_0015: ldc.i4.1
    IL_0016: stloc.1
    IL_0017: br.s IL_0033
    IL_0019: ldarga.s src
    IL_001B: ldloc.1
    IL_001C: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0021: ldind.i4
    IL_0022: ldloc.0
    IL_0023: bge.s IL_002F
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_002D: ldind.i4
    IL_002E: stloc.0
    IL_002F: ldloc.1
    IL_0030: ldc.i4.1
    IL_0031: add
    IL_0032: stloc.1
    IL_0033: ldloc.1
    IL_0034: ldarga.s src
    IL_0036: call System.Int32 System.ReadOnlySpan`1<System.Int32>::get_Length()
    IL_003B: blt.s IL_0019
    IL_003D: ldloc.0
    IL_003E: ret

}
uint min(ReadOnlySpan<uint> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.UInt32>::get_IsEmpty()
    IL_0007: brfalse.s IL_000B
    IL_0009: ldc.i4.0
    IL_000A: ret
    IL_000B: ldarga.s src
    IL_000D: ldc.i4.0
    IL_000E: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0013: ldind.u4
    IL_0014: stloc.0
    IL_0015: ldc.i4.1
    IL_0016: stloc.1
    IL_0017: br.s IL_0033
    IL_0019: ldarga.s src
    IL_001B: ldloc.1
    IL_001C: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0021: ldind.u4
    IL_0022: ldloc.0
    IL_0023: bge.un.s IL_002F
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_002D: ldind.u4
    IL_002E: stloc.0
    IL_002F: ldloc.1
    IL_0030: ldc.i4.1
    IL_0031: add
    IL_0032: stloc.1
    IL_0033: ldloc.1
    IL_0034: ldarga.s src
    IL_0036: call System.Int32 System.ReadOnlySpan`1<System.UInt32>::get_Length()
    IL_003B: blt.s IL_0019
    IL_003D: ldloc.0
    IL_003E: ret

}
long min(ReadOnlySpan<long> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.Int64>::get_IsEmpty()
    IL_0007: brfalse.s IL_000C
    IL_0009: ldc.i4.0
    IL_000A: conv.i8
    IL_000B: ret
    IL_000C: ldarga.s src
    IL_000E: ldc.i4.0
    IL_000F: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: stloc.0
    IL_0016: ldc.i4.1
    IL_0017: stloc.1
    IL_0018: br.s IL_0034
    IL_001A: ldarga.s src
    IL_001C: ldloc.1
    IL_001D: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0022: ldind.i8
    IL_0023: ldloc.0
    IL_0024: bge.s IL_0030
    IL_0026: ldarga.s src
    IL_0028: ldloc.1
    IL_0029: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_002E: ldind.i8
    IL_002F: stloc.0
    IL_0030: ldloc.1
    IL_0031: ldc.i4.1
    IL_0032: add
    IL_0033: stloc.1
    IL_0034: ldloc.1
    IL_0035: ldarga.s src
    IL_0037: call System.Int32 System.ReadOnlySpan`1<System.Int64>::get_Length()
    IL_003C: blt.s IL_001A
    IL_003E: ldloc.0
    IL_003F: ret

}
ulong min(ReadOnlySpan<ulong> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.UInt64>::get_IsEmpty()
    IL_0007: brfalse.s IL_000C
    IL_0009: ldc.i4.0
    IL_000A: conv.i8
    IL_000B: ret
    IL_000C: ldarga.s src
    IL_000E: ldc.i4.0
    IL_000F: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: stloc.0
    IL_0016: ldc.i4.1
    IL_0017: stloc.1
    IL_0018: br.s IL_0034
    IL_001A: ldarga.s src
    IL_001C: ldloc.1
    IL_001D: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0022: ldind.i8
    IL_0023: ldloc.0
    IL_0024: bge.un.s IL_0030
    IL_0026: ldarga.s src
    IL_0028: ldloc.1
    IL_0029: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_002E: ldind.i8
    IL_002F: stloc.0
    IL_0030: ldloc.1
    IL_0031: ldc.i4.1
    IL_0032: add
    IL_0033: stloc.1
    IL_0034: ldloc.1
    IL_0035: ldarga.s src
    IL_0037: call System.Int32 System.ReadOnlySpan`1<System.UInt64>::get_Length()
    IL_003C: blt.s IL_001A
    IL_003E: ldloc.0
    IL_003F: ret

}
float min(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
double min(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
float min(ReadOnlySpan<float> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.Single>::get_IsEmpty()
    IL_0007: brfalse.s IL_000F
    IL_0009: ldc.r4 0
    IL_000E: ret
    IL_000F: ldarga.s src
    IL_0011: ldc.i4.0
    IL_0012: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0017: ldind.r4
    IL_0018: stloc.0
    IL_0019: ldc.i4.1
    IL_001A: stloc.1
    IL_001B: br.s IL_0037
    IL_001D: ldarga.s src
    IL_001F: ldloc.1
    IL_0020: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0025: ldind.r4
    IL_0026: ldloc.0
    IL_0027: bge.un.s IL_0033
    IL_0029: ldarga.s src
    IL_002B: ldloc.1
    IL_002C: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0031: ldind.r4
    IL_0032: stloc.0
    IL_0033: ldloc.1
    IL_0034: ldc.i4.1
    IL_0035: add
    IL_0036: stloc.1
    IL_0037: ldloc.1
    IL_0038: ldarga.s src
    IL_003A: call System.Int32 System.ReadOnlySpan`1<System.Single>::get_Length()
    IL_003F: blt.s IL_001D
    IL_0041: ldloc.0
    IL_0042: ret

}
double min(ReadOnlySpan<double> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.Double>::get_IsEmpty()
    IL_0007: brfalse.s IL_0013
    IL_0009: ldc.r8 0
    IL_0012: ret
    IL_0013: ldarga.s src
    IL_0015: ldc.i4.0
    IL_0016: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_001B: ldind.r8
    IL_001C: stloc.0
    IL_001D: ldc.i4.1
    IL_001E: stloc.1
    IL_001F: br.s IL_003B
    IL_0021: ldarga.s src
    IL_0023: ldloc.1
    IL_0024: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0029: ldind.r8
    IL_002A: ldloc.0
    IL_002B: bge.un.s IL_0037
    IL_002D: ldarga.s src
    IL_002F: ldloc.1
    IL_0030: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0035: ldind.r8
    IL_0036: stloc.0
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldarga.s src
    IL_003E: call System.Int32 System.ReadOnlySpan`1<System.Double>::get_Length()
    IL_0043: blt.s IL_0021
    IL_0045: ldloc.0
    IL_0046: ret

}
sbyte mod(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: conv.i1
    IL_0004: ret

}
byte mod(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: conv.u1
    IL_0004: ret

}
short mod(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: conv.i2
    IL_0004: ret

}
ushort mod(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: conv.u2
    IL_0004: ret

}
int mod(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: ret

}
uint mod(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem.un
    IL_0003: ret

}
long mod(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: ret

}
ulong mod(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem.un
    IL_0003: ret

}
ref sbyte mod(ref sbyte lhs, in sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: ldind.i1
    IL_0005: rem
    IL_0006: conv.i1
    IL_0007: stind.i1
    IL_0008: ldarg.0
    IL_0009: ret

}
ref byte mod(ref byte lhs, in byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldind.u1
    IL_0005: rem
    IL_0006: conv.u1
    IL_0007: stind.i1
    IL_0008: ldarg.0
    IL_0009: ret

}
ref short mod(ref short lhs, in short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: ldind.i2
    IL_0005: rem
    IL_0006: conv.i2
    IL_0007: stind.i2
    IL_0008: ldarg.0
    IL_0009: ret

}
ref ushort mod(ref ushort lhs, in ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldind.u2
    IL_0005: rem
    IL_0006: conv.u2
    IL_0007: stind.i2
    IL_0008: ldarg.0
    IL_0009: ret

}
ref int mod(ref int lhs, in int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: ldind.i4
    IL_0005: rem
    IL_0006: stind.i4
    IL_0007: ldarg.0
    IL_0008: ret

}
ref uint mod(ref uint lhs, in uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldind.u4
    IL_0005: rem.un
    IL_0006: stind.i4
    IL_0007: ldarg.0
    IL_0008: ret

}
ref long mod(ref long lhs, in long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: rem
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ulong mod(ref ulong lhs, in ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: rem.un
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
Span<sbyte> mod(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mod.cs"
    IL_000C: ldc.i4.s 106
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0025: ldarga.s lhs
    IL_0027: ldloc.1
    IL_0028: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_002D: ldind.i1
    IL_002E: ldarga.s rhs
    IL_0030: ldloc.1
    IL_0031: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0036: ldind.i1
    IL_0037: call System.SByte Z0.math::mod(System.SByte,System.SByte)
    IL_003C: stind.i1
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.2
    IL_0046: ret

}
Span<byte> mod(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mod.cs"
    IL_000C: ldc.i4.s 114
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0025: ldarga.s lhs
    IL_0027: ldloc.1
    IL_0028: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_002D: ldind.u1
    IL_002E: ldarga.s rhs
    IL_0030: ldloc.1
    IL_0031: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0036: ldind.u1
    IL_0037: call System.Byte Z0.math::mod(System.Byte,System.Byte)
    IL_003C: stind.i1
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.2
    IL_0046: ret

}
void mod(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mod.cs"
    IL_000C: ldc.i4.s 122
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0025: ldarga.s lhs
    IL_0027: ldloc.1
    IL_0028: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_002D: ldind.i2
    IL_002E: ldarga.s rhs
    IL_0030: ldloc.1
    IL_0031: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0036: ldind.i2
    IL_0037: call System.Int16 Z0.math::mod(System.Int16,System.Int16)
    IL_003C: stind.i2
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ret

}
void mod(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mod.cs"
    IL_000C: ldc.i4 129
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0030: ldind.u2
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0039: ldind.u2
    IL_003A: call System.UInt16 Z0.math::mod(System.UInt16,System.UInt16)
    IL_003F: stind.i2
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ret

}
void mod(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mod.cs"
    IL_000C: ldc.i4 136
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0030: ldind.i4
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0039: ldind.i4
    IL_003A: call System.Int32 Z0.math::mod(System.Int32,System.Int32)
    IL_003F: stind.i4
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ret

}
void mod(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mod.cs"
    IL_000C: ldc.i4 143
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0030: ldind.u4
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0039: ldind.u4
    IL_003A: call System.UInt32 Z0.math::mod(System.UInt32,System.UInt32)
    IL_003F: stind.i4
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ret

}
void mod(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mod.cs"
    IL_000C: ldc.i4 150
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0039: ldind.i8
    IL_003A: call System.Int64 Z0.math::mod(System.Int64,System.Int64)
    IL_003F: stind.i8
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ret

}
void mod(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mod.cs"
    IL_000C: ldc.i4 157
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0039: ldind.i8
    IL_003A: call System.UInt64 Z0.math::mod(System.UInt64,System.UInt64)
    IL_003F: stind.i8
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ret

}
Span<sbyte> mod(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mod.cs"
    IL_000C: ldc.i4 164
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.SByte>(System.Span`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i1
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0032: ldind.i1
    IL_0033: rem
    IL_0034: conv.i1
    IL_0035: stind.i1
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<byte> mod(Span<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mod.cs"
    IL_000C: ldc.i4 172
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Byte>(System.Span`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u1
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0032: ldind.u1
    IL_0033: rem
    IL_0034: conv.u1
    IL_0035: stind.i1
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<short> mod(Span<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mod.cs"
    IL_000C: ldc.i4 180
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int16>(System.Span`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i2
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0032: ldind.i2
    IL_0033: rem
    IL_0034: conv.i2
    IL_0035: stind.i2
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<ushort> mod(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mod.cs"
    IL_000C: ldc.i4 188
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt16>(System.Span`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u2
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0032: ldind.u2
    IL_0033: rem
    IL_0034: conv.u2
    IL_0035: stind.i2
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<int> mod(Span<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mod.cs"
    IL_000C: ldc.i4 196
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int32>(System.Span`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i4
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0032: ldind.i4
    IL_0033: rem
    IL_0034: stind.i4
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<uint> mod(Span<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mod.cs"
    IL_000C: ldc.i4 204
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt32>(System.Span`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u4
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0032: ldind.u4
    IL_0033: rem.un
    IL_0034: stind.i4
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<long> mod(Span<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mod.cs"
    IL_000C: ldc.i4 212
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int64>(System.Span`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i8
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0032: ldind.i8
    IL_0033: rem
    IL_0034: stind.i8
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<ulong> mod(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mod.cs"
    IL_000C: ldc.i4 220
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt64>(System.Span`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i8
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0032: ldind.i8
    IL_0033: rem.un
    IL_0034: stind.i8
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<sbyte> mod(Span<sbyte> lhs, sbyte rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i1
    IL_000E: ldarg.1
    IL_000F: rem
    IL_0010: conv.i1
    IL_0011: stind.i1
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s lhs
    IL_0019: call System.Int32 System.Span`1<System.SByte>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<byte> mod(Span<byte> lhs, byte rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.u1
    IL_000E: ldarg.1
    IL_000F: rem
    IL_0010: conv.u1
    IL_0011: stind.i1
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s lhs
    IL_0019: call System.Int32 System.Span`1<System.Byte>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<short> mod(Span<short> lhs, short rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i2
    IL_000E: ldarg.1
    IL_000F: rem
    IL_0010: conv.i2
    IL_0011: stind.i2
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s lhs
    IL_0019: call System.Int32 System.Span`1<System.Int16>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<ushort> mod(Span<ushort> lhs, ushort rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.u2
    IL_000E: ldarg.1
    IL_000F: rem
    IL_0010: conv.u2
    IL_0011: stind.i2
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s lhs
    IL_0019: call System.Int32 System.Span`1<System.UInt16>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<int> mod(Span<int> lhs, int rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i4
    IL_000E: ldarg.1
    IL_000F: rem
    IL_0010: stind.i4
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.Int32>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
Span<uint> mod(Span<uint> lhs, uint rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.u4
    IL_000E: ldarg.1
    IL_000F: rem.un
    IL_0010: stind.i4
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.UInt32>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
Span<long> mod(Span<long> lhs, long rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i8
    IL_000E: ldarg.1
    IL_000F: rem
    IL_0010: stind.i8
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.Int64>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
Span<ulong> mod(Span<ulong> lhs, ulong rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i8
    IL_000E: ldarg.1
    IL_000F: rem.un
    IL_0010: stind.i8
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.UInt64>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
Span<sbyte> mod(ReadOnlySpan<sbyte> lhs, sbyte rhs, Span<sbyte> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0014: ldind.i1
    IL_0015: ldarg.1
    IL_0016: call System.SByte Z0.math::mod(System.SByte,System.SByte)
    IL_001B: stind.i1
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s lhs
    IL_0023: call System.Int32 System.ReadOnlySpan`1<System.SByte>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.2
    IL_002B: ret

}
Span<byte> mod(ReadOnlySpan<byte> lhs, byte rhs, Span<byte> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0014: ldind.u1
    IL_0015: ldarg.1
    IL_0016: call System.Byte Z0.math::mod(System.Byte,System.Byte)
    IL_001B: stind.i1
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s lhs
    IL_0023: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.2
    IL_002B: ret

}
Span<short> mod(ReadOnlySpan<short> lhs, short rhs, Span<short> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0014: ldind.i2
    IL_0015: ldarg.1
    IL_0016: call System.Int16 Z0.math::mod(System.Int16,System.Int16)
    IL_001B: stind.i2
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s lhs
    IL_0023: call System.Int32 System.ReadOnlySpan`1<System.Int16>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.2
    IL_002B: ret

}
Span<ushort> mod(ReadOnlySpan<ushort> lhs, ushort rhs, Span<ushort> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0014: ldind.u2
    IL_0015: ldarg.1
    IL_0016: call System.UInt16 Z0.math::mod(System.UInt16,System.UInt16)
    IL_001B: stind.i2
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s lhs
    IL_0023: call System.Int32 System.ReadOnlySpan`1<System.UInt16>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.2
    IL_002B: ret

}
Span<int> mod(ReadOnlySpan<int> lhs, int rhs, Span<int> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0014: ldind.i4
    IL_0015: ldarg.1
    IL_0016: call System.Int32 Z0.math::mod(System.Int32,System.Int32)
    IL_001B: stind.i4
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s lhs
    IL_0023: call System.Int32 System.ReadOnlySpan`1<System.Int32>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.2
    IL_002B: ret

}
Span<uint> mod(ReadOnlySpan<uint> lhs, uint rhs, Span<uint> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0014: ldind.u4
    IL_0015: ldarg.1
    IL_0016: call System.UInt32 Z0.math::mod(System.UInt32,System.UInt32)
    IL_001B: stind.i4
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s lhs
    IL_0023: call System.Int32 System.ReadOnlySpan`1<System.UInt32>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.2
    IL_002B: ret

}
Span<long> mod(ReadOnlySpan<long> lhs, long rhs, Span<long> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: ldarg.1
    IL_0016: call System.Int64 Z0.math::mod(System.Int64,System.Int64)
    IL_001B: stind.i8
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s lhs
    IL_0023: call System.Int32 System.ReadOnlySpan`1<System.Int64>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.2
    IL_002B: ret

}
Span<ulong> mod(ReadOnlySpan<ulong> lhs, ulong rhs, Span<ulong> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: ldarg.1
    IL_0016: call System.UInt64 Z0.math::mod(System.UInt64,System.UInt64)
    IL_001B: stind.i8
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s lhs
    IL_0023: call System.Int32 System.ReadOnlySpan`1<System.UInt64>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.2
    IL_002B: ret

}
sbyte mul(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: conv.i1
    IL_0004: ret

}
byte mul(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: conv.u1
    IL_0004: ret

}
short mul(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: conv.i2
    IL_0004: ret

}
ushort mul(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: conv.u2
    IL_0004: ret

}
int mul(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
uint mul(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
long mul(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
ulong mul(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
float mul(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
double mul(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
ref sbyte mul(ref sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: mul
    IL_0005: conv.i1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref byte mul(ref byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: mul
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref short mul(ref short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: mul
    IL_0005: conv.i2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ushort mul(ref ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: mul
    IL_0005: conv.u2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref int mul(ref int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: mul
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref uint mul(ref uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: mul
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref long mul(ref long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: mul
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref ulong mul(ref ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: mul
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref float mul(ref float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: ldarg.1
    IL_0004: mul
    IL_0005: stind.r4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref double mul(ref double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldarg.1
    IL_0004: mul
    IL_0005: stind.r8
    IL_0006: ldarg.0
    IL_0007: ret

}
Span<sbyte> Mul(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4.s 20
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0025: ldarga.s lhs
    IL_0027: ldloc.1
    IL_0028: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_002D: ldind.i1
    IL_002E: ldarga.s rhs
    IL_0030: ldloc.1
    IL_0031: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0036: ldind.i1
    IL_0037: call System.SByte Z0.math::mul(System.SByte,System.SByte)
    IL_003C: stind.i1
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.2
    IL_0046: ret

}
Span<byte> Mul(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4.s 28
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0025: ldarga.s lhs
    IL_0027: ldloc.1
    IL_0028: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_002D: ldind.u1
    IL_002E: ldarga.s rhs
    IL_0030: ldloc.1
    IL_0031: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0036: ldind.u1
    IL_0037: call System.Byte Z0.math::mul(System.Byte,System.Byte)
    IL_003C: stind.i1
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.2
    IL_0046: ret

}
Span<short> Mul(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4.s 36
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0025: ldarga.s lhs
    IL_0027: ldloc.1
    IL_0028: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_002D: ldind.i2
    IL_002E: ldarga.s rhs
    IL_0030: ldloc.1
    IL_0031: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0036: ldind.i2
    IL_0037: call System.Int16 Z0.math::mul(System.Int16,System.Int16)
    IL_003C: stind.i2
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.2
    IL_0046: ret

}
Span<ushort> Mul(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4.s 44
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0025: ldarga.s lhs
    IL_0027: ldloc.1
    IL_0028: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_002D: ldind.u2
    IL_002E: ldarga.s rhs
    IL_0030: ldloc.1
    IL_0031: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0036: ldind.u2
    IL_0037: call System.UInt16 Z0.math::mul(System.UInt16,System.UInt16)
    IL_003C: stind.i2
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.2
    IL_0046: ret

}
Span<int> Mul(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4.s 51
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0025: ldarga.s lhs
    IL_0027: ldloc.1
    IL_0028: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_002D: ldind.i4
    IL_002E: ldarga.s rhs
    IL_0030: ldloc.1
    IL_0031: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0036: ldind.i4
    IL_0037: call System.Int32 Z0.math::mul(System.Int32,System.Int32)
    IL_003C: stind.i4
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.2
    IL_0046: ret

}
Span<uint> Mul(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4.s 60
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0025: ldarga.s lhs
    IL_0027: ldloc.1
    IL_0028: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_002D: ldind.u4
    IL_002E: ldarga.s rhs
    IL_0030: ldloc.1
    IL_0031: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0036: ldind.u4
    IL_0037: call System.UInt32 Z0.math::mul(System.UInt32,System.UInt32)
    IL_003C: stind.i4
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.2
    IL_0046: ret

}
Span<long> Mul(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4.s 68
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0025: ldarga.s lhs
    IL_0027: ldloc.1
    IL_0028: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_002D: ldind.i8
    IL_002E: ldarga.s rhs
    IL_0030: ldloc.1
    IL_0031: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0036: ldind.i8
    IL_0037: call System.Int64 Z0.math::mul(System.Int64,System.Int64)
    IL_003C: stind.i8
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.2
    IL_0046: ret

}
Span<ulong> Mul(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4.s 76
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0025: ldarga.s lhs
    IL_0027: ldloc.1
    IL_0028: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_002D: ldind.i8
    IL_002E: ldarga.s rhs
    IL_0030: ldloc.1
    IL_0031: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0036: ldind.i8
    IL_0037: call System.UInt64 Z0.math::mul(System.UInt64,System.UInt64)
    IL_003C: stind.i8
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.2
    IL_0046: ret

}
Span<float> Mul(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4.s 84
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Single,System.Single>(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0025: ldarga.s lhs
    IL_0027: ldloc.1
    IL_0028: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_002D: ldind.r4
    IL_002E: ldarga.s rhs
    IL_0030: ldloc.1
    IL_0031: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0036: ldind.r4
    IL_0037: call System.Single Z0.math::mul(System.Single,System.Single)
    IL_003C: stind.r4
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.2
    IL_0046: ret

}
Span<double> Mul(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4.s 92
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Double,System.Double>(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0025: ldarga.s lhs
    IL_0027: ldloc.1
    IL_0028: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_002D: ldind.r8
    IL_002E: ldarga.s rhs
    IL_0030: ldloc.1
    IL_0031: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0036: ldind.r8
    IL_0037: call System.Double Z0.math::mul(System.Double,System.Double)
    IL_003C: stind.r8
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.2
    IL_0046: ret

}
Span<sbyte> Mul(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4.s 100
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.SByte>(System.Span`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0037
    IL_001D: ldarga.s lhs
    IL_001F: ldloc.1
    IL_0020: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0025: dup
    IL_0026: ldind.i1
    IL_0027: ldarga.s rhs
    IL_0029: ldloc.1
    IL_002A: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_002F: ldind.i1
    IL_0030: mul
    IL_0031: conv.i1
    IL_0032: stind.i1
    IL_0033: ldloc.1
    IL_0034: ldc.i4.1
    IL_0035: add
    IL_0036: stloc.1
    IL_0037: ldloc.1
    IL_0038: ldloc.0
    IL_0039: blt.s IL_001D
    IL_003B: ldarg.0
    IL_003C: ret

}
Span<byte> Mul(Span<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4.s 108
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Byte>(System.Span`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0037
    IL_001D: ldarga.s lhs
    IL_001F: ldloc.1
    IL_0020: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0025: dup
    IL_0026: ldind.u1
    IL_0027: ldarga.s rhs
    IL_0029: ldloc.1
    IL_002A: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_002F: ldind.u1
    IL_0030: mul
    IL_0031: conv.u1
    IL_0032: stind.i1
    IL_0033: ldloc.1
    IL_0034: ldc.i4.1
    IL_0035: add
    IL_0036: stloc.1
    IL_0037: ldloc.1
    IL_0038: ldloc.0
    IL_0039: blt.s IL_001D
    IL_003B: ldarg.0
    IL_003C: ret

}
Span<short> Mul(Span<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4.s 116
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int16>(System.Span`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0037
    IL_001D: ldarga.s lhs
    IL_001F: ldloc.1
    IL_0020: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0025: dup
    IL_0026: ldind.i2
    IL_0027: ldarga.s rhs
    IL_0029: ldloc.1
    IL_002A: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_002F: ldind.i2
    IL_0030: mul
    IL_0031: conv.i2
    IL_0032: stind.i2
    IL_0033: ldloc.1
    IL_0034: ldc.i4.1
    IL_0035: add
    IL_0036: stloc.1
    IL_0037: ldloc.1
    IL_0038: ldloc.0
    IL_0039: blt.s IL_001D
    IL_003B: ldarg.0
    IL_003C: ret

}
Span<ushort> Mul(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4.s 124
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt16>(System.Span`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0037
    IL_001D: ldarga.s lhs
    IL_001F: ldloc.1
    IL_0020: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0025: dup
    IL_0026: ldind.u2
    IL_0027: ldarga.s rhs
    IL_0029: ldloc.1
    IL_002A: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_002F: ldind.u2
    IL_0030: mul
    IL_0031: conv.u2
    IL_0032: stind.i2
    IL_0033: ldloc.1
    IL_0034: ldc.i4.1
    IL_0035: add
    IL_0036: stloc.1
    IL_0037: ldloc.1
    IL_0038: ldloc.0
    IL_0039: blt.s IL_001D
    IL_003B: ldarg.0
    IL_003C: ret

}
Span<int> Mul(Span<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4 132
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int32>(System.Span`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i4
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0032: ldind.i4
    IL_0033: mul
    IL_0034: stind.i4
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<uint> Mul(Span<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4 140
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt32>(System.Span`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u4
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0032: ldind.u4
    IL_0033: mul
    IL_0034: stind.i4
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<long> Mul(Span<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4 148
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int64>(System.Span`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i8
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0032: ldind.i8
    IL_0033: mul
    IL_0034: stind.i8
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<ulong> Mul(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4 156
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt64>(System.Span`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i8
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0032: ldind.i8
    IL_0033: mul
    IL_0034: stind.i8
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<float> Mul(Span<float> lhs, ReadOnlySpan<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4 164
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Single>(System.Span`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.r4
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0032: ldind.r4
    IL_0033: mul
    IL_0034: stind.r4
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<double> Mul(Span<double> lhs, ReadOnlySpan<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\mul.x.cs"
    IL_000C: ldc.i4 172
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Double>(System.Span`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.r8
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0032: ldind.r8
    IL_0033: mul
    IL_0034: stind.r8
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
sbyte negate(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: neg
    IL_0002: conv.i1
    IL_0003: ret

}
byte negate(byte src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: conv.u1
    IL_0005: ret

}
short negate(short src)
{
    IL_0000: ldarg.0
    IL_0001: neg
    IL_0002: conv.i2
    IL_0003: ret

}
ushort negate(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: conv.u2
    IL_0005: ret

}
int negate(int src)
{
    IL_0000: ldarg.0
    IL_0001: neg
    IL_0002: ret

}
uint negate(uint src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: ret

}
long negate(long src)
{
    IL_0000: ldarg.0
    IL_0001: neg
    IL_0002: ret

}
ulong negate(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ldc.i4.1
    IL_0003: conv.i8
    IL_0004: add
    IL_0005: ret

}
float negate(float src)
{
    IL_0000: ldarg.0
    IL_0001: neg
    IL_0002: ret

}
double negate(double src)
{
    IL_0000: ldarg.0
    IL_0001: neg
    IL_0002: ret

}
ref sbyte negate(ref sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: neg
    IL_0004: conv.i1
    IL_0005: stind.i1
    IL_0006: ldarg.0
    IL_0007: ret

}
ref byte negate(ref byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: call System.Byte Z0.math::negate(System.Byte)
    IL_0008: stind.i1
    IL_0009: ldarg.0
    IL_000A: ret

}
ref short negate(ref short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: neg
    IL_0004: conv.i2
    IL_0005: stind.i2
    IL_0006: ldarg.0
    IL_0007: ret

}
ref ushort negate(ref ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: call System.UInt16 Z0.math::negate(System.UInt16)
    IL_0008: stind.i2
    IL_0009: ldarg.0
    IL_000A: ret

}
ref int negate(ref int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: neg
    IL_0004: stind.i4
    IL_0005: ldarg.0
    IL_0006: ret

}
ref uint negate(ref uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: call System.UInt32 Z0.math::negate(System.UInt32)
    IL_0008: stind.i4
    IL_0009: ldarg.0
    IL_000A: ret

}
ref long negate(ref long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: neg
    IL_0004: stind.i8
    IL_0005: ldarg.0
    IL_0006: ret

}
ref ulong negate(ref ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: call System.UInt64 Z0.math::negate(System.UInt64)
    IL_0008: stind.i8
    IL_0009: ldarg.0
    IL_000A: ret

}
ref float negate(ref float src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: neg
    IL_0004: stind.r4
    IL_0005: ldarg.0
    IL_0006: ret

}
ref double negate(ref double src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: neg
    IL_0004: stind.r8
    IL_0005: ldarg.0
    IL_0006: ret

}
bool neq(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool neq(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool neq(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool neq(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool neq(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool neq(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool neq(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool neq(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool neq(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool neq(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool neq(in sbyte lhs, in sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i1
    IL_0002: ldarg.1
    IL_0003: ldind.i1
    IL_0004: ceq
    IL_0006: ldc.i4.0
    IL_0007: ceq
    IL_0009: ret

}
bool neq(in byte lhs, in byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u1
    IL_0002: ldarg.1
    IL_0003: ldind.u1
    IL_0004: ceq
    IL_0006: ldc.i4.0
    IL_0007: ceq
    IL_0009: ret

}
int ipow(int b, uint exp)
{
    IL_0000: ldarg.1
    IL_0001: brtrue.s IL_0005
    IL_0003: ldc.i4.1
    IL_0004: ret
    IL_0005: ldc.i4.1
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: ldc.i4.1
    IL_0009: and
    IL_000A: brfalse.s IL_0010
    IL_000C: ldloc.0
    IL_000D: ldarg.0
    IL_000E: mul
    IL_000F: stloc.0
    IL_0010: ldarg.1
    IL_0011: ldc.i4.1
    IL_0012: shr.un
    IL_0013: starg.s exp
    IL_0015: ldarg.1
    IL_0016: brfalse.s IL_001F
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001A: mul
    IL_001B: starg.s b
    IL_001D: br.s IL_0007
    IL_001F: ldloc.0
    IL_0020: ret

}
uint ipow(uint b, uint exp)
{
    IL_0000: ldarg.1
    IL_0001: brtrue.s IL_0005
    IL_0003: ldc.i4.1
    IL_0004: ret
    IL_0005: ldc.i4.1
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: ldc.i4.1
    IL_0009: and
    IL_000A: brfalse.s IL_0010
    IL_000C: ldloc.0
    IL_000D: ldarg.0
    IL_000E: mul
    IL_000F: stloc.0
    IL_0010: ldarg.1
    IL_0011: ldc.i4.1
    IL_0012: shr.un
    IL_0013: starg.s exp
    IL_0015: ldarg.1
    IL_0016: brfalse.s IL_001F
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001A: mul
    IL_001B: starg.s b
    IL_001D: br.s IL_0007
    IL_001F: ldloc.0
    IL_0020: ret

}
long ipow(long b, uint exp)
{
    IL_0000: ldarg.1
    IL_0001: brtrue.s IL_0006
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: ret
    IL_0006: ldc.i4.1
    IL_0007: conv.i8
    IL_0008: stloc.0
    IL_0009: ldarg.1
    IL_000A: ldc.i4.1
    IL_000B: and
    IL_000C: brfalse.s IL_0012
    IL_000E: ldloc.0
    IL_000F: ldarg.0
    IL_0010: mul
    IL_0011: stloc.0
    IL_0012: ldarg.1
    IL_0013: ldc.i4.1
    IL_0014: shr.un
    IL_0015: starg.s exp
    IL_0017: ldarg.1
    IL_0018: brfalse.s IL_0021
    IL_001A: ldarg.0
    IL_001B: ldarg.0
    IL_001C: mul
    IL_001D: starg.s b
    IL_001F: br.s IL_0009
    IL_0021: ldloc.0
    IL_0022: ret

}
ulong ipow(ulong b, uint exp)
{
    IL_0000: ldarg.1
    IL_0001: brtrue.s IL_0006
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: ret
    IL_0006: ldc.i4.1
    IL_0007: conv.i8
    IL_0008: stloc.0
    IL_0009: ldarg.1
    IL_000A: ldc.i4.1
    IL_000B: and
    IL_000C: brfalse.s IL_0012
    IL_000E: ldloc.0
    IL_000F: ldarg.0
    IL_0010: mul
    IL_0011: stloc.0
    IL_0012: ldarg.1
    IL_0013: ldc.i4.1
    IL_0014: shr.un
    IL_0015: starg.s exp
    IL_0017: ldarg.1
    IL_0018: brfalse.s IL_0021
    IL_001A: ldarg.0
    IL_001B: ldarg.0
    IL_001C: mul
    IL_001D: starg.s b
    IL_001F: br.s IL_0009
    IL_0021: ldloc.0
    IL_0022: ret

}
ref sbyte ipow(ref sbyte src, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: call System.SByte Z0.math::ipow(System.SByte,System.UInt32)
    IL_0009: stind.i1
    IL_000A: ldarg.0
    IL_000B: ret

}
ref byte ipow(ref byte src, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: call System.Byte Z0.math::ipow(System.Byte,System.UInt32)
    IL_0009: stind.i1
    IL_000A: ldarg.0
    IL_000B: ret

}
ref short ipow(ref short src, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: call System.Int16 Z0.math::ipow(System.Int16,System.UInt32)
    IL_0009: stind.i2
    IL_000A: ldarg.0
    IL_000B: ret

}
ref ushort ipow(ref ushort src, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: call System.UInt16 Z0.math::ipow(System.UInt16,System.UInt32)
    IL_0009: stind.i2
    IL_000A: ldarg.0
    IL_000B: ret

}
ref int ipow(ref int src, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: call System.Int32 Z0.math::ipow(System.Int32,System.UInt32)
    IL_0009: stind.i4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref uint ipow(ref uint src, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: call System.UInt32 Z0.math::ipow(System.UInt32,System.UInt32)
    IL_0009: stind.i4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref long ipow(ref long src, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: call System.Int64 Z0.math::ipow(System.Int64,System.UInt32)
    IL_0009: stind.i8
    IL_000A: ldarg.0
    IL_000B: ret

}
ref ulong ipow(ref ulong src, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: call System.UInt64 Z0.math::ipow(System.UInt64,System.UInt32)
    IL_0009: stind.i8
    IL_000A: ldarg.0
    IL_000B: ret

}
Span<sbyte> ipow(Span<sbyte> b, ReadOnlySpan<uint> exp)
{
    IL_0000: ldarga.s b
    IL_0002: call System.Int32 System.Span`1<System.SByte>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarga.s b
    IL_000E: ldloc.1
    IL_000F: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0014: ldarga.s b
    IL_0016: ldloc.1
    IL_0017: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_001C: ldind.i1
    IL_001D: ldarga.s exp
    IL_001F: ldloc.1
    IL_0020: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0025: ldind.u4
    IL_0026: call System.SByte Z0.math::ipow(System.SByte,System.UInt32)
    IL_002B: stind.i1
    IL_002C: ldloc.1
    IL_002D: ldc.i4.1
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldloc.0
    IL_0032: blt.s IL_000C
    IL_0034: ldarg.0
    IL_0035: ret

}
Span<byte> ipow(Span<byte> b, ReadOnlySpan<uint> exp)
{
    IL_0000: ldarga.s b
    IL_0002: call System.Int32 System.Span`1<System.Byte>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarga.s b
    IL_000E: ldloc.1
    IL_000F: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0014: ldarga.s b
    IL_0016: ldloc.1
    IL_0017: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001C: ldind.u1
    IL_001D: ldarga.s exp
    IL_001F: ldloc.1
    IL_0020: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0025: ldind.u4
    IL_0026: call System.Byte Z0.math::ipow(System.Byte,System.UInt32)
    IL_002B: stind.i1
    IL_002C: ldloc.1
    IL_002D: ldc.i4.1
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldloc.0
    IL_0032: blt.s IL_000C
    IL_0034: ldarg.0
    IL_0035: ret

}
Span<short> ipow(Span<short> b, ReadOnlySpan<uint> exp)
{
    IL_0000: ldarga.s b
    IL_0002: call System.Int32 System.Span`1<System.Int16>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarga.s b
    IL_000E: ldloc.1
    IL_000F: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0014: ldarga.s b
    IL_0016: ldloc.1
    IL_0017: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_001C: ldind.i2
    IL_001D: ldarga.s exp
    IL_001F: ldloc.1
    IL_0020: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0025: ldind.u4
    IL_0026: call System.Int16 Z0.math::ipow(System.Int16,System.UInt32)
    IL_002B: stind.i2
    IL_002C: ldloc.1
    IL_002D: ldc.i4.1
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldloc.0
    IL_0032: blt.s IL_000C
    IL_0034: ldarg.0
    IL_0035: ret

}
Span<ushort> ipow(Span<ushort> b, ReadOnlySpan<uint> exp)
{
    IL_0000: ldarga.s b
    IL_0002: call System.Int32 System.Span`1<System.UInt16>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarga.s b
    IL_000E: ldloc.1
    IL_000F: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0014: ldarga.s b
    IL_0016: ldloc.1
    IL_0017: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_001C: ldind.u2
    IL_001D: ldarga.s exp
    IL_001F: ldloc.1
    IL_0020: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0025: ldind.u4
    IL_0026: call System.UInt16 Z0.math::ipow(System.UInt16,System.UInt32)
    IL_002B: stind.i2
    IL_002C: ldloc.1
    IL_002D: ldc.i4.1
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldloc.0
    IL_0032: blt.s IL_000C
    IL_0034: ldarg.0
    IL_0035: ret

}
Span<int> ipow(Span<int> b, ReadOnlySpan<uint> exp)
{
    IL_0000: ldarga.s b
    IL_0002: call System.Int32 System.Span`1<System.Int32>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarga.s b
    IL_000E: ldloc.1
    IL_000F: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0014: ldarga.s b
    IL_0016: ldloc.1
    IL_0017: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_001C: ldind.i4
    IL_001D: ldarga.s exp
    IL_001F: ldloc.1
    IL_0020: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0025: ldind.u4
    IL_0026: call System.Int32 Z0.math::ipow(System.Int32,System.UInt32)
    IL_002B: stind.i4
    IL_002C: ldloc.1
    IL_002D: ldc.i4.1
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldloc.0
    IL_0032: blt.s IL_000C
    IL_0034: ldarg.0
    IL_0035: ret

}
Span<uint> ipow(Span<uint> b, ReadOnlySpan<uint> exp)
{
    IL_0000: ldarga.s b
    IL_0002: call System.Int32 System.Span`1<System.UInt32>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarga.s b
    IL_000E: ldloc.1
    IL_000F: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0014: ldarga.s b
    IL_0016: ldloc.1
    IL_0017: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_001C: ldind.u4
    IL_001D: ldarga.s exp
    IL_001F: ldloc.1
    IL_0020: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0025: ldind.u4
    IL_0026: call System.UInt32 Z0.math::ipow(System.UInt32,System.UInt32)
    IL_002B: stind.i4
    IL_002C: ldloc.1
    IL_002D: ldc.i4.1
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldloc.0
    IL_0032: blt.s IL_000C
    IL_0034: ldarg.0
    IL_0035: ret

}
Span<long> ipow(Span<long> b, ReadOnlySpan<uint> exp)
{
    IL_0000: ldarga.s b
    IL_0002: call System.Int32 System.Span`1<System.Int64>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarga.s b
    IL_000E: ldloc.1
    IL_000F: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0014: ldarga.s b
    IL_0016: ldloc.1
    IL_0017: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_001C: ldind.i8
    IL_001D: ldarga.s exp
    IL_001F: ldloc.1
    IL_0020: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0025: ldind.u4
    IL_0026: call System.Int64 Z0.math::ipow(System.Int64,System.UInt32)
    IL_002B: stind.i8
    IL_002C: ldloc.1
    IL_002D: ldc.i4.1
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldloc.0
    IL_0032: blt.s IL_000C
    IL_0034: ldarg.0
    IL_0035: ret

}
Span<ulong> ipow(Span<ulong> b, ReadOnlySpan<uint> exp)
{
    IL_0000: ldarga.s b
    IL_0002: call System.Int32 System.Span`1<System.UInt64>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarga.s b
    IL_000E: ldloc.1
    IL_000F: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0014: ldarga.s b
    IL_0016: ldloc.1
    IL_0017: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_001C: ldind.i8
    IL_001D: ldarga.s exp
    IL_001F: ldloc.1
    IL_0020: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0025: ldind.u4
    IL_0026: call System.UInt64 Z0.math::ipow(System.UInt64,System.UInt32)
    IL_002B: stind.i8
    IL_002C: ldloc.1
    IL_002D: ldc.i4.1
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldloc.0
    IL_0032: blt.s IL_000C
    IL_0034: ldarg.0
    IL_0035: ret

}
Span<sbyte> ipow(Span<sbyte> b, uint exp)
{
    IL_0000: ldarga.s b
    IL_0002: call System.Int32 System.Span`1<System.SByte>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0028
    IL_000C: ldarga.s b
    IL_000E: ldloc.1
    IL_000F: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0014: ldarga.s b
    IL_0016: ldloc.1
    IL_0017: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_001C: ldind.i1
    IL_001D: ldarg.1
    IL_001E: call System.SByte Z0.math::ipow(System.SByte,System.UInt32)
    IL_0023: stind.i1
    IL_0024: ldloc.1
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.1
    IL_0028: ldloc.1
    IL_0029: ldloc.0
    IL_002A: blt.s IL_000C
    IL_002C: ldarg.0
    IL_002D: ret

}
Span<byte> ipow(Span<byte> b, uint exp)
{
    IL_0000: ldarga.s b
    IL_0002: call System.Int32 System.Span`1<System.Byte>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0028
    IL_000C: ldarga.s b
    IL_000E: ldloc.1
    IL_000F: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0014: ldarga.s b
    IL_0016: ldloc.1
    IL_0017: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_001C: ldind.u1
    IL_001D: ldarg.1
    IL_001E: call System.Byte Z0.math::ipow(System.Byte,System.UInt32)
    IL_0023: stind.i1
    IL_0024: ldloc.1
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.1
    IL_0028: ldloc.1
    IL_0029: ldarga.s b
    IL_002B: call System.Int32 System.Span`1<System.Byte>::get_Length()
    IL_0030: blt.s IL_000C
    IL_0032: ldarg.0
    IL_0033: ret

}
Span<short> ipow(Span<short> b, uint exp)
{
    IL_0000: ldarga.s b
    IL_0002: call System.Int32 System.Span`1<System.Int16>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0028
    IL_000C: ldarga.s b
    IL_000E: ldloc.1
    IL_000F: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0014: ldarga.s b
    IL_0016: ldloc.1
    IL_0017: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_001C: ldind.i2
    IL_001D: ldarg.1
    IL_001E: call System.Int16 Z0.math::ipow(System.Int16,System.UInt32)
    IL_0023: stind.i2
    IL_0024: ldloc.1
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.1
    IL_0028: ldloc.1
    IL_0029: ldarga.s b
    IL_002B: call System.Int32 System.Span`1<System.Int16>::get_Length()
    IL_0030: blt.s IL_000C
    IL_0032: ldarg.0
    IL_0033: ret

}
Span<ushort> ipow(Span<ushort> b, uint exp)
{
    IL_0000: ldarga.s b
    IL_0002: call System.Int32 System.Span`1<System.UInt16>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0028
    IL_000C: ldarga.s b
    IL_000E: ldloc.1
    IL_000F: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0014: ldarga.s b
    IL_0016: ldloc.1
    IL_0017: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_001C: ldind.u2
    IL_001D: ldarg.1
    IL_001E: call System.UInt16 Z0.math::ipow(System.UInt16,System.UInt32)
    IL_0023: stind.i2
    IL_0024: ldloc.1
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.1
    IL_0028: ldloc.1
    IL_0029: ldloc.0
    IL_002A: blt.s IL_000C
    IL_002C: ldarg.0
    IL_002D: ret

}
Span<int> ipow(Span<int> b, uint exp)
{
    IL_0000: ldarga.s b
    IL_0002: call System.Int32 System.Span`1<System.Int32>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0028
    IL_000C: ldarga.s b
    IL_000E: ldloc.1
    IL_000F: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0014: ldarga.s b
    IL_0016: ldloc.1
    IL_0017: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_001C: ldind.i4
    IL_001D: ldarg.1
    IL_001E: call System.Int32 Z0.math::ipow(System.Int32,System.UInt32)
    IL_0023: stind.i4
    IL_0024: ldloc.1
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.1
    IL_0028: ldloc.1
    IL_0029: ldloc.0
    IL_002A: blt.s IL_000C
    IL_002C: ldarg.0
    IL_002D: ret

}
Span<uint> ipow(Span<uint> b, uint exp)
{
    IL_0000: ldarga.s b
    IL_0002: call System.Int32 System.Span`1<System.UInt32>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0028
    IL_000C: ldarga.s b
    IL_000E: ldloc.1
    IL_000F: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0014: ldarga.s b
    IL_0016: ldloc.1
    IL_0017: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_001C: ldind.u4
    IL_001D: ldarg.1
    IL_001E: call System.UInt32 Z0.math::ipow(System.UInt32,System.UInt32)
    IL_0023: stind.i4
    IL_0024: ldloc.1
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.1
    IL_0028: ldloc.1
    IL_0029: ldloc.0
    IL_002A: blt.s IL_000C
    IL_002C: ldarg.0
    IL_002D: ret

}
Span<long> ipow(Span<long> b, uint exp)
{
    IL_0000: ldarga.s b
    IL_0002: call System.Int32 System.Span`1<System.Int64>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0028
    IL_000C: ldarga.s b
    IL_000E: ldloc.1
    IL_000F: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0014: ldarga.s b
    IL_0016: ldloc.1
    IL_0017: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_001C: ldind.i8
    IL_001D: ldarg.1
    IL_001E: call System.Int64 Z0.math::ipow(System.Int64,System.UInt32)
    IL_0023: stind.i8
    IL_0024: ldloc.1
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.1
    IL_0028: ldloc.1
    IL_0029: ldloc.0
    IL_002A: blt.s IL_000C
    IL_002C: ldarg.0
    IL_002D: ret

}
Span<ulong> ipow(Span<ulong> b, uint exp)
{
    IL_0000: ldarga.s b
    IL_0002: call System.Int32 System.Span`1<System.UInt64>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0028
    IL_000C: ldarga.s b
    IL_000E: ldloc.1
    IL_000F: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0014: ldarga.s b
    IL_0016: ldloc.1
    IL_0017: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_001C: ldind.i8
    IL_001D: ldarg.1
    IL_001E: call System.UInt64 Z0.math::ipow(System.UInt64,System.UInt32)
    IL_0023: stind.i8
    IL_0024: ldloc.1
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.1
    IL_0028: ldloc.1
    IL_0029: ldloc.0
    IL_002A: blt.s IL_000C
    IL_002C: ldarg.0
    IL_002D: ret

}
bool isPow2(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: and
    IL_0005: ldc.i4.0
    IL_0006: ceq
    IL_0008: ret

}
bool isPow2(byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: and
    IL_0005: ldc.i4.0
    IL_0006: ceq
    IL_0008: ret

}
bool isPow2(short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: and
    IL_0005: ldc.i4.0
    IL_0006: ceq
    IL_0008: ret

}
bool isPow2(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: and
    IL_0005: ldc.i4.0
    IL_0006: ceq
    IL_0008: ret

}
bool isPow2(int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: and
    IL_0005: ldc.i4.0
    IL_0006: ceq
    IL_0008: ret

}
bool isPow2(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: and
    IL_0005: ldc.i4.0
    IL_0006: ceq
    IL_0008: ret

}
bool isPow2(long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: conv.i8
    IL_0004: sub
    IL_0005: and
    IL_0006: ldc.i4.0
    IL_0007: conv.i8
    IL_0008: ceq
    IL_000A: ret

}
bool isPow2(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: conv.i8
    IL_0004: sub
    IL_0005: and
    IL_0006: ldc.i4.0
    IL_0007: conv.i8
    IL_0008: ceq
    IL_000A: ret

}
bool lt(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ret

}
bool lt(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ret

}
bool lt(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ret

}
bool lt(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ret

}
bool lt(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ret

}
bool lt(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt.un
    IL_0004: ret

}
bool lt(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ret

}
bool lt(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt.un
    IL_0004: ret

}
bool lt(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ret

}
bool lt(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ret

}
Span<bool> lt(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0014: ldind.i1
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_001D: ldind.i1
    IL_001E: call System.Boolean Z0.math::lt(System.SByte,System.SByte)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.SByte>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lt(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0014: ldind.u1
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_001D: ldind.u1
    IL_001E: call System.Boolean Z0.math::lt(System.Byte,System.Byte)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lt(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0014: ldind.i2
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_001D: ldind.i2
    IL_001E: call System.Boolean Z0.math::lt(System.Int16,System.Int16)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Int16>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lt(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0014: ldind.u2
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_001D: ldind.u2
    IL_001E: call System.Boolean Z0.math::lt(System.UInt16,System.UInt16)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.UInt16>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lt(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0014: ldind.i4
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_001D: ldind.i4
    IL_001E: call System.Boolean Z0.math::lt(System.Int32,System.Int32)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Int32>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lt(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0014: ldind.u4
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_001D: ldind.u4
    IL_001E: call System.Boolean Z0.math::lt(System.UInt32,System.UInt32)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.UInt32>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lt(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_001D: ldind.i8
    IL_001E: call System.Boolean Z0.math::lt(System.Int64,System.Int64)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Int64>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lt(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_001D: ldind.i8
    IL_001E: call System.Boolean Z0.math::lt(System.UInt64,System.UInt64)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.UInt64>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lt(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0014: ldind.r4
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_001D: ldind.r4
    IL_001E: call System.Boolean Z0.math::lt(System.Single,System.Single)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Single>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lt(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0014: ldind.r8
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_001D: ldind.r8
    IL_001E: call System.Boolean Z0.math::lt(System.Double,System.Double)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Double>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lt(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lt.cs"
    IL_000E: ldc.i4 131
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> lt(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lt.cs"
    IL_000E: ldc.i4 135
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> lt(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lt.cs"
    IL_000E: ldc.i4 139
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> lt(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lt.cs"
    IL_000E: ldc.i4 143
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> lt(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lt.cs"
    IL_000E: ldc.i4 147
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> lt(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lt.cs"
    IL_000E: ldc.i4 151
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> lt(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lt.cs"
    IL_000E: ldc.i4 155
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> lt(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lt.cs"
    IL_000E: ldc.i4 159
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> lt(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lt.cs"
    IL_000E: ldc.i4 163
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Single,System.Single>(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> lt(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lt.cs"
    IL_000E: ldc.i4 167
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Double,System.Double>(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
bool lteq(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool lteq(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool lteq(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool lteq(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool lteq(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool lteq(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt.un
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool lteq(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool lteq(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt.un
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool lteq(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt.un
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool lteq(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt.un
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
Span<bool> lteq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0014: ldind.i1
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_001D: ldind.i1
    IL_001E: call System.Boolean Z0.math::lteq(System.SByte,System.SByte)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.SByte>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lteq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0014: ldind.u1
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_001D: ldind.u1
    IL_001E: call System.Boolean Z0.math::lteq(System.Byte,System.Byte)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lteq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0014: ldind.i2
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_001D: ldind.i2
    IL_001E: call System.Boolean Z0.math::lteq(System.Int16,System.Int16)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Int16>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lteq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0014: ldind.u2
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_001D: ldind.u2
    IL_001E: call System.Boolean Z0.math::lteq(System.UInt16,System.UInt16)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.UInt16>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lteq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0014: ldind.i4
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_001D: ldind.i4
    IL_001E: call System.Boolean Z0.math::lteq(System.Int32,System.Int32)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Int32>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lteq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0014: ldind.u4
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_001D: ldind.u4
    IL_001E: call System.Boolean Z0.math::lteq(System.UInt32,System.UInt32)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.UInt32>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lteq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_001D: ldind.i8
    IL_001E: call System.Boolean Z0.math::lteq(System.Int64,System.Int64)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Int64>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lteq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_001D: ldind.i8
    IL_001E: call System.Boolean Z0.math::lteq(System.UInt64,System.UInt64)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.UInt64>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lteq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0014: ldind.r4
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_001D: ldind.r4
    IL_001E: call System.Boolean Z0.math::lteq(System.Single,System.Single)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Single>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lteq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0014: ldind.r8
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_001D: ldind.r8
    IL_001E: call System.Boolean Z0.math::lteq(System.Double,System.Double)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Double>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> lteq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lteq.cs"
    IL_000E: ldc.i4 130
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lteq(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> lteq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lteq.cs"
    IL_000E: ldc.i4 134
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lteq(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> lteq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lteq.cs"
    IL_000E: ldc.i4 138
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lteq(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> lteq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lteq.cs"
    IL_000E: ldc.i4 142
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lteq(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> lteq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lteq.cs"
    IL_000E: ldc.i4 146
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lteq(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> lteq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lteq.cs"
    IL_000E: ldc.i4 150
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lteq(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> lteq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lteq.cs"
    IL_000E: ldc.i4 154
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lteq(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> lteq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lteq.cs"
    IL_000E: ldc.i4 158
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lteq(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> lteq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lteq.cs"
    IL_000E: ldc.i4 162
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Single,System.Single>(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lteq(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> lteq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\lteq.cs"
    IL_000E: ldc.i4 166
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Double,System.Double>(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lteq(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
sbyte max(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
byte max(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
short max(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
ushort max(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
int max(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
uint max(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.un.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
long max(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
ulong max(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.un.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
float max(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
double max(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
sbyte max(ReadOnlySpan<sbyte> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.SByte>::get_IsEmpty()
    IL_0007: brfalse.s IL_000B
    IL_0009: ldc.i4.0
    IL_000A: ret
    IL_000B: ldarga.s src
    IL_000D: ldc.i4.0
    IL_000E: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0013: ldind.i1
    IL_0014: stloc.0
    IL_0015: ldc.i4.1
    IL_0016: stloc.1
    IL_0017: br.s IL_0033
    IL_0019: ldarga.s src
    IL_001B: ldloc.1
    IL_001C: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0021: ldind.i1
    IL_0022: ldloc.0
    IL_0023: ble.s IL_002F
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_002D: ldind.i1
    IL_002E: stloc.0
    IL_002F: ldloc.1
    IL_0030: ldc.i4.1
    IL_0031: add
    IL_0032: stloc.1
    IL_0033: ldloc.1
    IL_0034: ldarga.s src
    IL_0036: call System.Int32 System.ReadOnlySpan`1<System.SByte>::get_Length()
    IL_003B: blt.s IL_0019
    IL_003D: ldloc.0
    IL_003E: ret

}
byte max(ReadOnlySpan<byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.Byte>::get_IsEmpty()
    IL_0007: brfalse.s IL_000B
    IL_0009: ldc.i4.0
    IL_000A: ret
    IL_000B: ldarga.s src
    IL_000D: ldc.i4.0
    IL_000E: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0013: ldind.u1
    IL_0014: stloc.0
    IL_0015: ldc.i4.1
    IL_0016: stloc.1
    IL_0017: br.s IL_0033
    IL_0019: ldarga.s src
    IL_001B: ldloc.1
    IL_001C: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0021: ldind.u1
    IL_0022: ldloc.0
    IL_0023: ble.s IL_002F
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_002D: ldind.u1
    IL_002E: stloc.0
    IL_002F: ldloc.1
    IL_0030: ldc.i4.1
    IL_0031: add
    IL_0032: stloc.1
    IL_0033: ldloc.1
    IL_0034: ldarga.s src
    IL_0036: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_003B: blt.s IL_0019
    IL_003D: ldloc.0
    IL_003E: ret

}
short max(ReadOnlySpan<short> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.Int16>::get_IsEmpty()
    IL_0007: brfalse.s IL_000B
    IL_0009: ldc.i4.0
    IL_000A: ret
    IL_000B: ldarga.s src
    IL_000D: ldc.i4.0
    IL_000E: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0013: ldind.i2
    IL_0014: stloc.0
    IL_0015: ldc.i4.1
    IL_0016: stloc.1
    IL_0017: br.s IL_0033
    IL_0019: ldarga.s src
    IL_001B: ldloc.1
    IL_001C: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0021: ldind.i2
    IL_0022: ldloc.0
    IL_0023: ble.s IL_002F
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_002D: ldind.i2
    IL_002E: stloc.0
    IL_002F: ldloc.1
    IL_0030: ldc.i4.1
    IL_0031: add
    IL_0032: stloc.1
    IL_0033: ldloc.1
    IL_0034: ldarga.s src
    IL_0036: call System.Int32 System.ReadOnlySpan`1<System.Int16>::get_Length()
    IL_003B: blt.s IL_0019
    IL_003D: ldloc.0
    IL_003E: ret

}
ushort max(ReadOnlySpan<ushort> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.UInt16>::get_IsEmpty()
    IL_0007: brfalse.s IL_000B
    IL_0009: ldc.i4.0
    IL_000A: ret
    IL_000B: ldarga.s src
    IL_000D: ldc.i4.0
    IL_000E: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0013: ldind.u2
    IL_0014: stloc.0
    IL_0015: ldc.i4.1
    IL_0016: stloc.1
    IL_0017: br.s IL_0033
    IL_0019: ldarga.s src
    IL_001B: ldloc.1
    IL_001C: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0021: ldind.u2
    IL_0022: ldloc.0
    IL_0023: ble.s IL_002F
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_002D: ldind.u2
    IL_002E: stloc.0
    IL_002F: ldloc.1
    IL_0030: ldc.i4.1
    IL_0031: add
    IL_0032: stloc.1
    IL_0033: ldloc.1
    IL_0034: ldarga.s src
    IL_0036: call System.Int32 System.ReadOnlySpan`1<System.UInt16>::get_Length()
    IL_003B: blt.s IL_0019
    IL_003D: ldloc.0
    IL_003E: ret

}
int max(ReadOnlySpan<int> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.Int32>::get_IsEmpty()
    IL_0007: brfalse.s IL_000B
    IL_0009: ldc.i4.0
    IL_000A: ret
    IL_000B: ldarga.s src
    IL_000D: ldc.i4.0
    IL_000E: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0013: ldind.i4
    IL_0014: stloc.0
    IL_0015: ldc.i4.1
    IL_0016: stloc.1
    IL_0017: br.s IL_0033
    IL_0019: ldarga.s src
    IL_001B: ldloc.1
    IL_001C: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0021: ldind.i4
    IL_0022: ldloc.0
    IL_0023: ble.s IL_002F
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_002D: ldind.i4
    IL_002E: stloc.0
    IL_002F: ldloc.1
    IL_0030: ldc.i4.1
    IL_0031: add
    IL_0032: stloc.1
    IL_0033: ldloc.1
    IL_0034: ldarga.s src
    IL_0036: call System.Int32 System.ReadOnlySpan`1<System.Int32>::get_Length()
    IL_003B: blt.s IL_0019
    IL_003D: ldloc.0
    IL_003E: ret

}
uint max(ReadOnlySpan<uint> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.UInt32>::get_IsEmpty()
    IL_0007: brfalse.s IL_000B
    IL_0009: ldc.i4.0
    IL_000A: ret
    IL_000B: ldarga.s src
    IL_000D: ldc.i4.0
    IL_000E: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0013: ldind.u4
    IL_0014: stloc.0
    IL_0015: ldc.i4.1
    IL_0016: stloc.1
    IL_0017: br.s IL_0033
    IL_0019: ldarga.s src
    IL_001B: ldloc.1
    IL_001C: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0021: ldind.u4
    IL_0022: ldloc.0
    IL_0023: ble.un.s IL_002F
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_002D: ldind.u4
    IL_002E: stloc.0
    IL_002F: ldloc.1
    IL_0030: ldc.i4.1
    IL_0031: add
    IL_0032: stloc.1
    IL_0033: ldloc.1
    IL_0034: ldarga.s src
    IL_0036: call System.Int32 System.ReadOnlySpan`1<System.UInt32>::get_Length()
    IL_003B: blt.s IL_0019
    IL_003D: ldloc.0
    IL_003E: ret

}
long max(ReadOnlySpan<long> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.Int64>::get_IsEmpty()
    IL_0007: brfalse.s IL_000C
    IL_0009: ldc.i4.0
    IL_000A: conv.i8
    IL_000B: ret
    IL_000C: ldarga.s src
    IL_000E: ldc.i4.0
    IL_000F: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: stloc.0
    IL_0016: ldc.i4.1
    IL_0017: stloc.1
    IL_0018: br.s IL_0034
    IL_001A: ldarga.s src
    IL_001C: ldloc.1
    IL_001D: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0022: ldind.i8
    IL_0023: ldloc.0
    IL_0024: ble.s IL_0030
    IL_0026: ldarga.s src
    IL_0028: ldloc.1
    IL_0029: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_002E: ldind.i8
    IL_002F: stloc.0
    IL_0030: ldloc.1
    IL_0031: ldc.i4.1
    IL_0032: add
    IL_0033: stloc.1
    IL_0034: ldloc.1
    IL_0035: ldarga.s src
    IL_0037: call System.Int32 System.ReadOnlySpan`1<System.Int64>::get_Length()
    IL_003C: blt.s IL_001A
    IL_003E: ldloc.0
    IL_003F: ret

}
ulong max(ReadOnlySpan<ulong> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.UInt64>::get_IsEmpty()
    IL_0007: brfalse.s IL_000C
    IL_0009: ldc.i4.0
    IL_000A: conv.i8
    IL_000B: ret
    IL_000C: ldarga.s src
    IL_000E: ldc.i4.0
    IL_000F: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: stloc.0
    IL_0016: ldc.i4.1
    IL_0017: stloc.1
    IL_0018: br.s IL_0034
    IL_001A: ldarga.s src
    IL_001C: ldloc.1
    IL_001D: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0022: ldind.i8
    IL_0023: ldloc.0
    IL_0024: ble.un.s IL_0030
    IL_0026: ldarga.s src
    IL_0028: ldloc.1
    IL_0029: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_002E: ldind.i8
    IL_002F: stloc.0
    IL_0030: ldloc.1
    IL_0031: ldc.i4.1
    IL_0032: add
    IL_0033: stloc.1
    IL_0034: ldloc.1
    IL_0035: ldarga.s src
    IL_0037: call System.Int32 System.ReadOnlySpan`1<System.UInt64>::get_Length()
    IL_003C: blt.s IL_001A
    IL_003E: ldloc.0
    IL_003F: ret

}
float max(ReadOnlySpan<float> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.Single>::get_IsEmpty()
    IL_0007: brfalse.s IL_000F
    IL_0009: ldc.r4 0
    IL_000E: ret
    IL_000F: ldarga.s src
    IL_0011: ldc.i4.0
    IL_0012: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0017: ldind.r4
    IL_0018: stloc.0
    IL_0019: ldc.i4.1
    IL_001A: stloc.1
    IL_001B: br.s IL_0037
    IL_001D: ldarga.s src
    IL_001F: ldloc.1
    IL_0020: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0025: ldind.r4
    IL_0026: ldloc.0
    IL_0027: ble.un.s IL_0033
    IL_0029: ldarga.s src
    IL_002B: ldloc.1
    IL_002C: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0031: ldind.r4
    IL_0032: stloc.0
    IL_0033: ldloc.1
    IL_0034: ldc.i4.1
    IL_0035: add
    IL_0036: stloc.1
    IL_0037: ldloc.1
    IL_0038: ldarga.s src
    IL_003A: call System.Int32 System.ReadOnlySpan`1<System.Single>::get_Length()
    IL_003F: blt.s IL_001D
    IL_0041: ldloc.0
    IL_0042: ret

}
double max(ReadOnlySpan<double> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.Double>::get_IsEmpty()
    IL_0007: brfalse.s IL_0013
    IL_0009: ldc.r8 0
    IL_0012: ret
    IL_0013: ldarga.s src
    IL_0015: ldc.i4.0
    IL_0016: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_001B: ldind.r8
    IL_001C: stloc.0
    IL_001D: ldc.i4.1
    IL_001E: stloc.1
    IL_001F: br.s IL_003B
    IL_0021: ldarga.s src
    IL_0023: ldloc.1
    IL_0024: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0029: ldind.r8
    IL_002A: ldloc.0
    IL_002B: ble.un.s IL_0037
    IL_002D: ldarga.s src
    IL_002F: ldloc.1
    IL_0030: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0035: ldind.r8
    IL_0036: stloc.0
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldarga.s src
    IL_003E: call System.Int32 System.ReadOnlySpan`1<System.Double>::get_Length()
    IL_0043: blt.s IL_0021
    IL_0045: ldloc.0
    IL_0046: ret

}
sbyte min(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
byte min(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
short min(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
ushort min(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
int min(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
uint min(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.un.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
long min(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
ulong min(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.un.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
sbyte min(ReadOnlySpan<sbyte> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.SByte>::get_IsEmpty()
    IL_0007: brfalse.s IL_000B
    IL_0009: ldc.i4.0
    IL_000A: ret
    IL_000B: ldarga.s src
    IL_000D: ldc.i4.0
    IL_000E: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0013: ldind.i1
    IL_0014: stloc.0
    IL_0015: ldc.i4.1
    IL_0016: stloc.1
    IL_0017: br.s IL_0033
    IL_0019: ldarga.s src
    IL_001B: ldloc.1
    IL_001C: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0021: ldind.i1
    IL_0022: ldloc.0
    IL_0023: bge.s IL_002F
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_002D: ldind.i1
    IL_002E: stloc.0
    IL_002F: ldloc.1
    IL_0030: ldc.i4.1
    IL_0031: add
    IL_0032: stloc.1
    IL_0033: ldloc.1
    IL_0034: ldarga.s src
    IL_0036: call System.Int32 System.ReadOnlySpan`1<System.SByte>::get_Length()
    IL_003B: blt.s IL_0019
    IL_003D: ldloc.0
    IL_003E: ret

}
byte min(ReadOnlySpan<byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.Byte>::get_IsEmpty()
    IL_0007: brfalse.s IL_000B
    IL_0009: ldc.i4.0
    IL_000A: ret
    IL_000B: ldarga.s src
    IL_000D: ldc.i4.0
    IL_000E: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0013: ldind.u1
    IL_0014: stloc.0
    IL_0015: ldc.i4.1
    IL_0016: stloc.1
    IL_0017: br.s IL_0033
    IL_0019: ldarga.s src
    IL_001B: ldloc.1
    IL_001C: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0021: ldind.u1
    IL_0022: ldloc.0
    IL_0023: bge.s IL_002F
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_002D: ldind.u1
    IL_002E: stloc.0
    IL_002F: ldloc.1
    IL_0030: ldc.i4.1
    IL_0031: add
    IL_0032: stloc.1
    IL_0033: ldloc.1
    IL_0034: ldarga.s src
    IL_0036: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_003B: blt.s IL_0019
    IL_003D: ldloc.0
    IL_003E: ret

}
short min(ReadOnlySpan<short> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.Int16>::get_IsEmpty()
    IL_0007: brfalse.s IL_000B
    IL_0009: ldc.i4.0
    IL_000A: ret
    IL_000B: ldarga.s src
    IL_000D: ldc.i4.0
    IL_000E: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0013: ldind.i2
    IL_0014: stloc.0
    IL_0015: ldc.i4.1
    IL_0016: stloc.1
    IL_0017: br.s IL_0033
    IL_0019: ldarga.s src
    IL_001B: ldloc.1
    IL_001C: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0021: ldind.i2
    IL_0022: ldloc.0
    IL_0023: bge.s IL_002F
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_002D: ldind.i2
    IL_002E: stloc.0
    IL_002F: ldloc.1
    IL_0030: ldc.i4.1
    IL_0031: add
    IL_0032: stloc.1
    IL_0033: ldloc.1
    IL_0034: ldarga.s src
    IL_0036: call System.Int32 System.ReadOnlySpan`1<System.Int16>::get_Length()
    IL_003B: blt.s IL_0019
    IL_003D: ldloc.0
    IL_003E: ret

}
ushort min(ReadOnlySpan<ushort> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.UInt16>::get_IsEmpty()
    IL_0007: brfalse.s IL_000B
    IL_0009: ldc.i4.0
    IL_000A: ret
    IL_000B: ldarga.s src
    IL_000D: ldc.i4.0
    IL_000E: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0013: ldind.u2
    IL_0014: stloc.0
    IL_0015: ldc.i4.1
    IL_0016: stloc.1
    IL_0017: br.s IL_0033
    IL_0019: ldarga.s src
    IL_001B: ldloc.1
    IL_001C: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0021: ldind.u2
    IL_0022: ldloc.0
    IL_0023: bge.s IL_002F
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_002D: ldind.u2
    IL_002E: stloc.0
    IL_002F: ldloc.1
    IL_0030: ldc.i4.1
    IL_0031: add
    IL_0032: stloc.1
    IL_0033: ldloc.1
    IL_0034: ldarga.s src
    IL_0036: call System.Int32 System.ReadOnlySpan`1<System.UInt16>::get_Length()
    IL_003B: blt.s IL_0019
    IL_003D: ldloc.0
    IL_003E: ret

}
sbyte gcd(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.math::abs(System.SByte)
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: call System.SByte Z0.math::abs(System.SByte)
    IL_000D: stloc.1
    IL_000E: br.s IL_0019
    IL_0010: ldloc.0
    IL_0011: ldloc.1
    IL_0012: rem
    IL_0013: conv.i1
    IL_0014: stloc.2
    IL_0015: ldloc.1
    IL_0016: stloc.0
    IL_0017: ldloc.2
    IL_0018: stloc.1
    IL_0019: ldloc.1
    IL_001A: brtrue.s IL_0010
    IL_001C: ldloc.0
    IL_001D: ret

}
byte gcd(byte lhs, byte rhs)
{
    IL_0000: br.s IL_0010
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: call System.Byte Z0.math::mod(System.Byte,System.Byte)
    IL_0009: stloc.0
    IL_000A: ldarg.1
    IL_000B: starg.s lhs
    IL_000D: ldloc.0
    IL_000E: starg.s rhs
    IL_0010: ldarg.1
    IL_0011: brtrue.s IL_0002
    IL_0013: ldarg.0
    IL_0014: ret

}
short gcd(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.math::abs(System.Int16)
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: call System.Int16 Z0.math::abs(System.Int16)
    IL_000D: stloc.1
    IL_000E: br.s IL_0019
    IL_0010: ldloc.0
    IL_0011: ldloc.1
    IL_0012: rem
    IL_0013: conv.i2
    IL_0014: stloc.2
    IL_0015: ldloc.1
    IL_0016: stloc.0
    IL_0017: ldloc.2
    IL_0018: stloc.1
    IL_0019: ldloc.1
    IL_001A: brtrue.s IL_0010
    IL_001C: ldloc.0
    IL_001D: ret

}
ushort gcd(ushort lhs, ushort rhs)
{
    IL_0000: br.s IL_0010
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: call System.UInt16 Z0.math::mod(System.UInt16,System.UInt16)
    IL_0009: stloc.0
    IL_000A: ldarg.1
    IL_000B: starg.s lhs
    IL_000D: ldloc.0
    IL_000E: starg.s rhs
    IL_0010: ldarg.1
    IL_0011: brtrue.s IL_0002
    IL_0013: ldarg.0
    IL_0014: ret

}
int gcd(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.math::abs(System.Int32)
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: call System.Int32 Z0.math::abs(System.Int32)
    IL_000D: stloc.1
    IL_000E: br.s IL_0018
    IL_0010: ldloc.0
    IL_0011: ldloc.1
    IL_0012: rem
    IL_0013: stloc.2
    IL_0014: ldloc.1
    IL_0015: stloc.0
    IL_0016: ldloc.2
    IL_0017: stloc.1
    IL_0018: ldloc.1
    IL_0019: brtrue.s IL_0010
    IL_001B: ldloc.0
    IL_001C: ret

}
uint gcd(uint lhs, uint rhs)
{
    IL_0000: br.s IL_000C
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: rem.un
    IL_0005: stloc.0
    IL_0006: ldarg.1
    IL_0007: starg.s lhs
    IL_0009: ldloc.0
    IL_000A: starg.s rhs
    IL_000C: ldarg.1
    IL_000D: brtrue.s IL_0002
    IL_000F: ldarg.0
    IL_0010: ret

}
long gcd(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.math::abs(System.Int64)
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: call System.Int64 Z0.math::abs(System.Int64)
    IL_000D: stloc.1
    IL_000E: br.s IL_0018
    IL_0010: ldloc.0
    IL_0011: ldloc.1
    IL_0012: rem
    IL_0013: stloc.2
    IL_0014: ldloc.1
    IL_0015: stloc.0
    IL_0016: ldloc.2
    IL_0017: stloc.1
    IL_0018: ldloc.1
    IL_0019: brtrue.s IL_0010
    IL_001B: ldloc.0
    IL_001C: ret

}
ulong gcd(ulong lhs, ulong rhs)
{
    IL_0000: br.s IL_000C
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: rem.un
    IL_0005: stloc.0
    IL_0006: ldarg.1
    IL_0007: starg.s lhs
    IL_0009: ldloc.0
    IL_000A: starg.s rhs
    IL_000C: ldarg.1
    IL_000D: brtrue.s IL_0002
    IL_000F: ldarg.0
    IL_0010: ret

}
bool gt(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ret

}
bool gt(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ret

}
bool gt(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ret

}
bool gt(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ret

}
bool gt(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ret

}
bool gt(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt.un
    IL_0004: ret

}
bool gt(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ret

}
bool gt(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt.un
    IL_0004: ret

}
Span<bool> gt(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0014: ldind.i1
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_001D: ldind.i1
    IL_001E: call System.Boolean Z0.math::gt(System.SByte,System.SByte)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.SByte>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> gt(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0014: ldind.u1
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_001D: ldind.u1
    IL_001E: call System.Boolean Z0.math::gt(System.Byte,System.Byte)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> gt(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0014: ldind.i2
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_001D: ldind.i2
    IL_001E: call System.Boolean Z0.math::gt(System.Int16,System.Int16)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Int16>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> gt(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0014: ldind.u2
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_001D: ldind.u2
    IL_001E: call System.Boolean Z0.math::gt(System.UInt16,System.UInt16)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.UInt16>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> gt(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0014: ldind.i4
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_001D: ldind.i4
    IL_001E: call System.Boolean Z0.math::gt(System.Int32,System.Int32)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Int32>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> gt(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0014: ldind.u4
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_001D: ldind.u4
    IL_001E: call System.Boolean Z0.math::gt(System.UInt32,System.UInt32)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.UInt32>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> gt(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_001D: ldind.i8
    IL_001E: call System.Boolean Z0.math::gt(System.Int64,System.Int64)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Int64>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> gt(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_001D: ldind.i8
    IL_001E: call System.Boolean Z0.math::gt(System.UInt64,System.UInt64)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.UInt64>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> gt(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\gt.cs"
    IL_000E: ldc.i4.s 110
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::gt(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> gt(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\gt.cs"
    IL_000E: ldc.i4.s 114
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::gt(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> gt(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\gt.cs"
    IL_000E: ldc.i4.s 118
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::gt(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> gt(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\gt.cs"
    IL_000E: ldc.i4.s 122
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::gt(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> gt(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\gt.cs"
    IL_000E: ldc.i4.s 126
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::gt(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> gt(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\gt.cs"
    IL_000E: ldc.i4 130
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::gt(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> gt(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\gt.cs"
    IL_000E: ldc.i4 134
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::gt(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> gt(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\gt.cs"
    IL_000E: ldc.i4 138
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::gt(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
bool gteq(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool gteq(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool gteq(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool gteq(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool gteq(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool gteq(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt.un
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool gteq(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool gteq(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt.un
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
Span<bool> gteq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0014: ldind.i1
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_001D: ldind.i1
    IL_001E: call System.Boolean Z0.math::gteq(System.SByte,System.SByte)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.SByte>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> gteq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0014: ldind.u1
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_001D: ldind.u1
    IL_001E: call System.Boolean Z0.math::gteq(System.Byte,System.Byte)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> gteq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0014: ldind.i2
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_001D: ldind.i2
    IL_001E: call System.Boolean Z0.math::gteq(System.Int16,System.Int16)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Int16>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> gteq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0014: ldind.u2
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_001D: ldind.u2
    IL_001E: call System.Boolean Z0.math::gteq(System.UInt16,System.UInt16)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.UInt16>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> gteq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0014: ldind.i4
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_001D: ldind.i4
    IL_001E: call System.Boolean Z0.math::gteq(System.Int32,System.Int32)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Int32>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> gteq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0014: ldind.u4
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_001D: ldind.u4
    IL_001E: call System.Boolean Z0.math::gteq(System.UInt32,System.UInt32)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.UInt32>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> gteq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_001D: ldind.i8
    IL_001E: call System.Boolean Z0.math::gteq(System.Int64,System.Int64)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Int64>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> gteq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0028
    IL_0004: ldarga.s dst
    IL_0006: ldloc.0
    IL_0007: call System.Boolean& System.Span`1<System.Boolean>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: ldarga.s rhs
    IL_0017: ldloc.0
    IL_0018: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_001D: ldind.i8
    IL_001E: call System.Boolean Z0.math::gteq(System.UInt64,System.UInt64)
    IL_0023: stind.i1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarga.s lhs
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.UInt64>::get_Length()
    IL_0030: blt.s IL_0004
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<bool> gteq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\gteq.cs"
    IL_000E: ldc.i4.s 109
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::gteq(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> gteq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\gteq.cs"
    IL_000E: ldc.i4.s 113
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::gteq(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> gteq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\gteq.cs"
    IL_000E: ldc.i4.s 117
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::gteq(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> gteq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\gteq.cs"
    IL_000E: ldc.i4.s 121
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::gteq(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> gteq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\gteq.cs"
    IL_000E: ldc.i4.s 125
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::gteq(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> gteq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\gteq.cs"
    IL_000E: ldc.i4 129
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::gteq(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> gteq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\gteq.cs"
    IL_000E: ldc.i4 133
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::gteq(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> gteq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\gteq.cs"
    IL_000E: ldc.i4 137
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::gteq(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
sbyte idiv(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: conv.i1
    IL_0004: ret

}
byte idiv(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: conv.u1
    IL_0004: ret

}
short idiv(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: conv.i2
    IL_0004: ret

}
ushort idiv(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: conv.u2
    IL_0004: ret

}
int idiv(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: ret

}
uint idiv(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div.un
    IL_0003: ret

}
long idiv(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: ret

}
ulong idiv(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div.un
    IL_0003: ret

}
ref sbyte idiv(ref sbyte lhs, in sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: ldind.i1
    IL_0005: div
    IL_0006: conv.i1
    IL_0007: stind.i1
    IL_0008: ldarg.0
    IL_0009: ret

}
ref byte idiv(ref byte lhs, in byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldind.u1
    IL_0005: div
    IL_0006: conv.u1
    IL_0007: stind.i1
    IL_0008: ldarg.0
    IL_0009: ret

}
ref short idiv(ref short lhs, in short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: ldind.i2
    IL_0005: div
    IL_0006: conv.i2
    IL_0007: stind.i2
    IL_0008: ldarg.0
    IL_0009: ret

}
ref ushort idiv(ref ushort lhs, in ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldind.u2
    IL_0005: div
    IL_0006: conv.u2
    IL_0007: stind.i2
    IL_0008: ldarg.0
    IL_0009: ret

}
ref int idiv(ref int lhs, in int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: ldind.i4
    IL_0005: div
    IL_0006: stind.i4
    IL_0007: ldarg.0
    IL_0008: ret

}
ref uint idiv(ref uint lhs, in uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldind.u4
    IL_0005: div.un
    IL_0006: stind.i4
    IL_0007: ldarg.0
    IL_0008: ret

}
ref long idiv(ref long lhs, in long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: div
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ulong idiv(ref ulong lhs, in ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: div.un
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
Span<sbyte> idiv(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "idiv"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\idiv.cs"
    IL_000C: ldc.i4.s 111
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0025: ldarga.s lhs
    IL_0027: ldloc.1
    IL_0028: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_002D: ldind.i1
    IL_002E: ldarga.s rhs
    IL_0030: ldloc.1
    IL_0031: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0036: ldind.i1
    IL_0037: call System.SByte Z0.math::idiv(System.SByte,System.SByte)
    IL_003C: stind.i1
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.2
    IL_0046: ret

}
Span<byte> idiv(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "idiv"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\idiv.cs"
    IL_000C: ldc.i4.s 119
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0025: ldarga.s lhs
    IL_0027: ldloc.1
    IL_0028: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_002D: ldind.u1
    IL_002E: ldarga.s rhs
    IL_0030: ldloc.1
    IL_0031: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0036: ldind.u1
    IL_0037: call System.Byte Z0.math::idiv(System.Byte,System.Byte)
    IL_003C: stind.i1
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.2
    IL_0046: ret

}
Span<short> idiv(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "idiv"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\idiv.cs"
    IL_000C: ldc.i4.s 127
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0025: ldarga.s lhs
    IL_0027: ldloc.1
    IL_0028: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_002D: ldind.i2
    IL_002E: ldarga.s rhs
    IL_0030: ldloc.1
    IL_0031: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0036: ldind.i2
    IL_0037: call System.Int16 Z0.math::idiv(System.Int16,System.Int16)
    IL_003C: stind.i2
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.2
    IL_0046: ret

}
Span<ushort> idiv(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "idiv"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\idiv.cs"
    IL_000C: ldc.i4 135
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0030: ldind.u2
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0039: ldind.u2
    IL_003A: call System.UInt16 Z0.math::idiv(System.UInt16,System.UInt16)
    IL_003F: stind.i2
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<int> idiv(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "idiv"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\idiv.cs"
    IL_000C: ldc.i4 143
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0030: ldind.i4
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0039: ldind.i4
    IL_003A: call System.Int32 Z0.math::idiv(System.Int32,System.Int32)
    IL_003F: stind.i4
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<uint> idiv(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "idiv"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\idiv.cs"
    IL_000C: ldc.i4 151
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0030: ldind.u4
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0039: ldind.u4
    IL_003A: call System.UInt32 Z0.math::idiv(System.UInt32,System.UInt32)
    IL_003F: stind.i4
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<long> idiv(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "idiv"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\idiv.cs"
    IL_000C: ldc.i4 159
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0039: ldind.i8
    IL_003A: call System.Int64 Z0.math::idiv(System.Int64,System.Int64)
    IL_003F: stind.i8
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<ulong> idiv(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "idiv"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\idiv.cs"
    IL_000C: ldc.i4 167
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0039: ldind.i8
    IL_003A: call System.UInt64 Z0.math::idiv(System.UInt64,System.UInt64)
    IL_003F: stind.i8
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<sbyte> idiv(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "idiv"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\idiv.cs"
    IL_000C: ldc.i4 175
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.SByte>(System.Span`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i1
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0032: ldind.i1
    IL_0033: div
    IL_0034: conv.i1
    IL_0035: stind.i1
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<byte> idiv(Span<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "idiv"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\idiv.cs"
    IL_000C: ldc.i4 183
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Byte>(System.Span`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u1
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0032: ldind.u1
    IL_0033: div
    IL_0034: conv.u1
    IL_0035: stind.i1
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<short> idiv(Span<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "idiv"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\idiv.cs"
    IL_000C: ldc.i4 191
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int16>(System.Span`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i2
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0032: ldind.i2
    IL_0033: div
    IL_0034: conv.i2
    IL_0035: stind.i2
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<ushort> idiv(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "idiv"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\idiv.cs"
    IL_000C: ldc.i4 199
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt16>(System.Span`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u2
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0032: ldind.u2
    IL_0033: div
    IL_0034: conv.u2
    IL_0035: stind.i2
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<int> idiv(Span<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "idiv"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\idiv.cs"
    IL_000C: ldc.i4 207
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int32>(System.Span`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i4
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0032: ldind.i4
    IL_0033: div
    IL_0034: stind.i4
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<uint> idiv(Span<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "idiv"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\idiv.cs"
    IL_000C: ldc.i4 215
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt32>(System.Span`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u4
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0032: ldind.u4
    IL_0033: div.un
    IL_0034: stind.i4
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<long> idiv(Span<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "idiv"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\idiv.cs"
    IL_000C: ldc.i4 223
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int64>(System.Span`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i8
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0032: ldind.i8
    IL_0033: div
    IL_0034: stind.i8
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<ulong> idiv(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "idiv"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\idiv.cs"
    IL_000C: ldc.i4 231
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt64>(System.Span`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i8
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0032: ldind.i8
    IL_0033: div.un
    IL_0034: stind.i8
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
ref ulong ilog2(ref ulong dst, ref ulong x, ulong power)
{
    IL_0000: ldarg.1
    IL_0001: ldind.i8
    IL_0002: ldc.i4.1
    IL_0003: conv.i8
    IL_0004: ldarg.2
    IL_0005: conv.i4
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: blt.un.s IL_001C
    IL_000C: ldarg.1
    IL_000D: ldarg.1
    IL_000E: ldind.i8
    IL_000F: ldarg.2
    IL_0010: conv.i4
    IL_0011: ldc.i4.s 63
    IL_0013: and
    IL_0014: shr.un
    IL_0015: stind.i8
    IL_0016: ldarg.0
    IL_0017: ldarg.0
    IL_0018: ldind.i8
    IL_0019: ldarg.2
    IL_001A: or
    IL_001B: stind.i8
    IL_001C: ldarg.0
    IL_001D: ret

}
ulong ilog2(ulong src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldarg.0
    IL_0004: stloc.1
    IL_0005: ldloca.s V_0
    IL_0007: ldloca.s V_1
    IL_0009: ldc.i4.s 32
    IL_000B: conv.i8
    IL_000C: call System.UInt64& Z0.math::ilog2(System.UInt64&,System.UInt64&,System.UInt64)
    IL_0011: pop
    IL_0012: ldloca.s V_0
    IL_0014: ldloca.s V_1
    IL_0016: ldc.i4.s 16
    IL_0018: conv.i8
    IL_0019: call System.UInt64& Z0.math::ilog2(System.UInt64&,System.UInt64&,System.UInt64)
    IL_001E: pop
    IL_001F: ldloca.s V_0
    IL_0021: ldloca.s V_1
    IL_0023: ldc.i4.8
    IL_0024: conv.i8
    IL_0025: call System.UInt64& Z0.math::ilog2(System.UInt64&,System.UInt64&,System.UInt64)
    IL_002A: pop
    IL_002B: ldloca.s V_0
    IL_002D: ldloca.s V_1
    IL_002F: ldc.i4.4
    IL_0030: conv.i8
    IL_0031: call System.UInt64& Z0.math::ilog2(System.UInt64&,System.UInt64&,System.UInt64)
    IL_0036: pop
    IL_0037: ldloca.s V_0
    IL_0039: ldloca.s V_1
    IL_003B: ldc.i4.2
    IL_003C: conv.i8
    IL_003D: call System.UInt64& Z0.math::ilog2(System.UInt64&,System.UInt64&,System.UInt64)
    IL_0042: pop
    IL_0043: ldloc.1
    IL_0044: ldc.i4.2
    IL_0045: conv.i8
    IL_0046: blt.un.s IL_004D
    IL_0048: ldloc.0
    IL_0049: ldc.i4.1
    IL_004A: conv.i8
    IL_004B: or
    IL_004C: stloc.0
    IL_004D: ldloc.0
    IL_004E: ret

}
ulong ilog2(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i8
    IL_0002: call System.UInt64 Z0.math::ilog2(System.UInt64)
    IL_0007: ret

}
ulong ilog2(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: call System.UInt64 Z0.math::ilog2(System.UInt64)
    IL_0007: ret

}
sbyte inc(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: add
    IL_0003: conv.i1
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
byte inc(byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: add
    IL_0003: conv.u1
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
short inc(short src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: add
    IL_0003: conv.i2
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
ushort inc(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: add
    IL_0003: conv.u2
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
int inc(int src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: add
    IL_0003: dup
    IL_0004: starg.s src
    IL_0006: ret

}
uint inc(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: add
    IL_0003: dup
    IL_0004: starg.s src
    IL_0006: ret

}
long inc(long src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: conv.i8
    IL_0003: add
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
ulong inc(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: conv.i8
    IL_0003: add
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
ref sbyte inc(ref sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldc.i4.1
    IL_0004: add
    IL_0005: conv.i1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref byte inc(ref byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldc.i4.1
    IL_0004: add
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref short inc(ref short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldc.i4.1
    IL_0004: add
    IL_0005: conv.i2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ushort inc(ref ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldc.i4.1
    IL_0004: add
    IL_0005: conv.u2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref int inc(ref int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldc.i4.1
    IL_0004: add
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref uint inc(ref uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldc.i4.1
    IL_0004: add
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref long inc(ref long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: add
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ulong inc(ref ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: add
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
Span<sbyte> inc(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "inc"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\inc.cs"
    IL_000C: ldc.i4 174
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.Span`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003B
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0028: ldarga.s src
    IL_002A: ldloc.1
    IL_002B: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0030: ldind.i1
    IL_0031: call System.SByte Z0.math::inc(System.SByte)
    IL_0036: stind.i1
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldloc.0
    IL_003D: blt.s IL_0020
    IL_003F: ldarg.1
    IL_0040: ret

}
Span<byte> inc(ReadOnlySpan<byte> src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "inc"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\inc.cs"
    IL_000C: ldc.i4 182
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003B
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0028: ldarga.s src
    IL_002A: ldloc.1
    IL_002B: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0030: ldind.u1
    IL_0031: call System.Byte Z0.math::inc(System.Byte)
    IL_0036: stind.i1
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldloc.0
    IL_003D: blt.s IL_0020
    IL_003F: ldarg.1
    IL_0040: ret

}
Span<short> inc(ReadOnlySpan<short> src, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "inc"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\inc.cs"
    IL_000C: ldc.i4 190
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.Span`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003B
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0028: ldarga.s src
    IL_002A: ldloc.1
    IL_002B: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0030: ldind.i2
    IL_0031: call System.Int16 Z0.math::inc(System.Int16)
    IL_0036: stind.i2
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldloc.0
    IL_003D: blt.s IL_0020
    IL_003F: ldarg.1
    IL_0040: ret

}
Span<ushort> inc(ReadOnlySpan<ushort> src, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "inc"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\inc.cs"
    IL_000C: ldc.i4 198
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.Span`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003B
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0028: ldarga.s src
    IL_002A: ldloc.1
    IL_002B: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0030: ldind.u2
    IL_0031: call System.UInt16 Z0.math::inc(System.UInt16)
    IL_0036: stind.i2
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldloc.0
    IL_003D: blt.s IL_0020
    IL_003F: ldarg.1
    IL_0040: ret

}
Span<int> inc(ReadOnlySpan<int> src, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "inc"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\inc.cs"
    IL_000C: ldc.i4 206
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.Span`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003B
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0028: ldarga.s src
    IL_002A: ldloc.1
    IL_002B: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0030: ldind.i4
    IL_0031: call System.Int32 Z0.math::inc(System.Int32)
    IL_0036: stind.i4
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldloc.0
    IL_003D: blt.s IL_0020
    IL_003F: ldarg.1
    IL_0040: ret

}
Span<uint> inc(ReadOnlySpan<uint> src, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "inc"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\inc.cs"
    IL_000C: ldc.i4 214
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003B
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0028: ldarga.s src
    IL_002A: ldloc.1
    IL_002B: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0030: ldind.u4
    IL_0031: call System.UInt32 Z0.math::inc(System.UInt32)
    IL_0036: stind.i4
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldloc.0
    IL_003D: blt.s IL_0020
    IL_003F: ldarg.1
    IL_0040: ret

}
Span<long> inc(ReadOnlySpan<long> src, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "inc"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\inc.cs"
    IL_000C: ldc.i4 222
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.Span`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003B
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0028: ldarga.s src
    IL_002A: ldloc.1
    IL_002B: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: call System.Int64 Z0.math::inc(System.Int64)
    IL_0036: stind.i8
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldloc.0
    IL_003D: blt.s IL_0020
    IL_003F: ldarg.1
    IL_0040: ret

}
Span<ulong> inc(ReadOnlySpan<ulong> src, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "inc"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\inc.cs"
    IL_000C: ldc.i4 230
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003B
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0028: ldarga.s src
    IL_002A: ldloc.1
    IL_002B: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: call System.UInt64 Z0.math::inc(System.UInt64)
    IL_0036: stind.i8
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldloc.0
    IL_003D: blt.s IL_0020
    IL_003F: ldarg.1
    IL_0040: ret

}
Span<sbyte> inc(Span<sbyte> src)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_000C: call System.SByte& Z0.math::inc(System.SByte&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.Span`1<System.SByte>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<byte> inc(Span<byte> src)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_000C: call System.Byte& Z0.math::inc(System.Byte&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.Span`1<System.Byte>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<short> inc(Span<short> src)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_000C: call System.Int16& Z0.math::inc(System.Int16&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.Span`1<System.Int16>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<ushort> inc(Span<ushort> src)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_000C: call System.UInt16& Z0.math::inc(System.UInt16&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.Span`1<System.UInt16>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<int> inc(Span<int> src)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_000C: call System.Int32& Z0.math::inc(System.Int32&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.Span`1<System.Int32>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<uint> inc(Span<uint> src)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_000C: call System.UInt32& Z0.math::inc(System.UInt32&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.Span`1<System.UInt32>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<long> inc(Span<long> src)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_000C: call System.Int64& Z0.math::inc(System.Int64&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.Span`1<System.Int64>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<ulong> inc(Span<ulong> src)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_000C: call System.UInt64& Z0.math::inc(System.UInt64&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.Span`1<System.UInt64>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
sbyte ipow(sbyte b, uint exp)
{
    IL_0000: ldarg.1
    IL_0001: brtrue.s IL_0005
    IL_0003: ldc.i4.1
    IL_0004: ret
    IL_0005: ldc.i4.1
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: ldc.i4.1
    IL_0009: and
    IL_000A: brfalse.s IL_0011
    IL_000C: ldloc.0
    IL_000D: ldarg.0
    IL_000E: mul
    IL_000F: conv.i1
    IL_0010: stloc.0
    IL_0011: ldarg.1
    IL_0012: ldc.i4.1
    IL_0013: shr.un
    IL_0014: starg.s exp
    IL_0016: ldarg.1
    IL_0017: brfalse.s IL_0021
    IL_0019: ldarg.0
    IL_001A: ldarg.0
    IL_001B: mul
    IL_001C: conv.i1
    IL_001D: starg.s b
    IL_001F: br.s IL_0007
    IL_0021: ldloc.0
    IL_0022: ret

}
byte ipow(byte b, uint exp)
{
    IL_0000: ldarg.1
    IL_0001: brtrue.s IL_0005
    IL_0003: ldc.i4.1
    IL_0004: ret
    IL_0005: ldc.i4.1
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: ldc.i4.1
    IL_0009: and
    IL_000A: brfalse.s IL_0011
    IL_000C: ldloc.0
    IL_000D: ldarg.0
    IL_000E: mul
    IL_000F: conv.u1
    IL_0010: stloc.0
    IL_0011: ldarg.1
    IL_0012: ldc.i4.1
    IL_0013: shr.un
    IL_0014: starg.s exp
    IL_0016: ldarg.1
    IL_0017: brfalse.s IL_0021
    IL_0019: ldarg.0
    IL_001A: ldarg.0
    IL_001B: mul
    IL_001C: conv.u1
    IL_001D: starg.s b
    IL_001F: br.s IL_0007
    IL_0021: ldloc.0
    IL_0022: ret

}
short ipow(short b, uint exp)
{
    IL_0000: ldarg.1
    IL_0001: brtrue.s IL_0005
    IL_0003: ldc.i4.1
    IL_0004: ret
    IL_0005: ldc.i4.1
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: ldc.i4.1
    IL_0009: and
    IL_000A: brfalse.s IL_0011
    IL_000C: ldloc.0
    IL_000D: ldarg.0
    IL_000E: mul
    IL_000F: conv.i2
    IL_0010: stloc.0
    IL_0011: ldarg.1
    IL_0012: ldc.i4.1
    IL_0013: shr.un
    IL_0014: starg.s exp
    IL_0016: ldarg.1
    IL_0017: brfalse.s IL_0021
    IL_0019: ldarg.0
    IL_001A: ldarg.0
    IL_001B: mul
    IL_001C: conv.i2
    IL_001D: starg.s b
    IL_001F: br.s IL_0007
    IL_0021: ldloc.0
    IL_0022: ret

}
ushort ipow(ushort b, uint exp)
{
    IL_0000: ldarg.1
    IL_0001: brtrue.s IL_0005
    IL_0003: ldc.i4.1
    IL_0004: ret
    IL_0005: ldc.i4.1
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: ldc.i4.1
    IL_0009: and
    IL_000A: brfalse.s IL_0011
    IL_000C: ldloc.0
    IL_000D: ldarg.0
    IL_000E: mul
    IL_000F: conv.u2
    IL_0010: stloc.0
    IL_0011: ldarg.1
    IL_0012: ldc.i4.1
    IL_0013: shr.un
    IL_0014: starg.s exp
    IL_0016: ldarg.1
    IL_0017: brfalse.s IL_0021
    IL_0019: ldarg.0
    IL_001A: ldarg.0
    IL_001B: mul
    IL_001C: conv.u2
    IL_001D: starg.s b
    IL_001F: br.s IL_0007
    IL_0021: ldloc.0
    IL_0022: ret

}
uint avgz(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ldarg.1
    IL_0005: xor
    IL_0006: ldc.i4.1
    IL_0007: shr.un
    IL_0008: add
    IL_0009: ret

}
ulong avgz(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ldarg.1
    IL_0005: xor
    IL_0006: ldc.i4.1
    IL_0007: shr.un
    IL_0008: add
    IL_0009: ret

}
ref byte avgz(ref byte lhs, in byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldind.u1
    IL_0005: call System.Byte Z0.math::avgz(System.Byte,System.Byte)
    IL_000A: stind.i1
    IL_000B: ldarg.0
    IL_000C: ret

}
ref ushort avgz(ref ushort lhs, in ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldind.u2
    IL_0005: call System.UInt16 Z0.math::avgz(System.UInt16,System.UInt16)
    IL_000A: stind.i2
    IL_000B: ldarg.0
    IL_000C: ret

}
ref uint avgz(ref uint lhs, in uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldind.u4
    IL_0005: call System.UInt32 Z0.math::avgz(System.UInt32,System.UInt32)
    IL_000A: stind.i4
    IL_000B: ldarg.0
    IL_000C: ret

}
ref ulong avgz(ref ulong lhs, in ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: call System.UInt64 Z0.math::avgz(System.UInt64,System.UInt64)
    IL_000A: stind.i8
    IL_000B: ldarg.0
    IL_000C: ret

}
Span<byte> avgz(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "avgz"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\avg.cs"
    IL_000C: ldc.i4.s 112
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: newarr System.Byte
    IL_001D: call System.Span`1<System.Byte> System.Span`1<System.Byte>::op_Implicit(System.Byte[])
    IL_0022: stloc.0
    IL_0023: ldc.i4.0
    IL_0024: stloc.1
    IL_0025: br.s IL_004B
    IL_0027: ldloca.s V_0
    IL_0029: ldloc.1
    IL_002A: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_002F: ldarga.s lhs
    IL_0031: ldloc.1
    IL_0032: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0037: ldind.u1
    IL_0038: ldarga.s rhs
    IL_003A: ldloc.1
    IL_003B: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0040: ldind.u1
    IL_0041: call System.Byte Z0.math::avgz(System.Byte,System.Byte)
    IL_0046: stind.i1
    IL_0047: ldloc.1
    IL_0048: ldc.i4.1
    IL_0049: add
    IL_004A: stloc.1
    IL_004B: ldloc.1
    IL_004C: ldloca.s V_0
    IL_004E: call System.Int32 System.Span`1<System.Byte>::get_Length()
    IL_0053: blt.s IL_0027
    IL_0055: ldloc.0
    IL_0056: ret

}
Span<byte> avgi(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "avgi"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\avg.cs"
    IL_000C: ldc.i4.s 120
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: newarr System.Byte
    IL_001D: call System.Span`1<System.Byte> System.Span`1<System.Byte>::op_Implicit(System.Byte[])
    IL_0022: stloc.0
    IL_0023: ldc.i4.0
    IL_0024: stloc.1
    IL_0025: br.s IL_004B
    IL_0027: ldloca.s V_0
    IL_0029: ldloc.1
    IL_002A: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_002F: ldarga.s lhs
    IL_0031: ldloc.1
    IL_0032: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0037: ldind.u1
    IL_0038: ldarga.s rhs
    IL_003A: ldloc.1
    IL_003B: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0040: ldind.u1
    IL_0041: call System.Byte Z0.math::avgi(System.Byte,System.Byte)
    IL_0046: stind.i1
    IL_0047: ldloc.1
    IL_0048: ldc.i4.1
    IL_0049: add
    IL_004A: stloc.1
    IL_004B: ldloc.1
    IL_004C: ldloca.s V_0
    IL_004E: call System.Int32 System.Span`1<System.Byte>::get_Length()
    IL_0053: blt.s IL_0027
    IL_0055: ldloc.0
    IL_0056: ret

}
Span<ushort> avgi(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "avgi"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\avg.cs"
    IL_000C: ldc.i4 128
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: newarr System.UInt16
    IL_0020: call System.Span`1<System.UInt16> System.Span`1<System.UInt16>::op_Implicit(System.UInt16[])
    IL_0025: stloc.0
    IL_0026: ldc.i4.0
    IL_0027: stloc.1
    IL_0028: br.s IL_004E
    IL_002A: ldloca.s V_0
    IL_002C: ldloc.1
    IL_002D: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0032: ldarga.s lhs
    IL_0034: ldloc.1
    IL_0035: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_003A: ldind.u2
    IL_003B: ldarga.s rhs
    IL_003D: ldloc.1
    IL_003E: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0043: ldind.u2
    IL_0044: call System.UInt16 Z0.math::avgi(System.UInt16,System.UInt16)
    IL_0049: stind.i2
    IL_004A: ldloc.1
    IL_004B: ldc.i4.1
    IL_004C: add
    IL_004D: stloc.1
    IL_004E: ldloc.1
    IL_004F: ldloca.s V_0
    IL_0051: call System.Int32 System.Span`1<System.UInt16>::get_Length()
    IL_0056: blt.s IL_002A
    IL_0058: ldloc.0
    IL_0059: ret

}
ulong avgz(ReadOnlySpan<ulong> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Boolean System.ReadOnlySpan`1<System.UInt64>::get_IsEmpty()
    IL_0007: brfalse.s IL_000C
    IL_0009: ldc.i4.0
    IL_000A: conv.i8
    IL_000B: ret
    IL_000C: ldarga.s src
    IL_000E: ldc.i4.0
    IL_000F: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: stloc.0
    IL_0016: ldc.i4.1
    IL_0017: stloc.1
    IL_0018: br.s IL_002E
    IL_001A: ldloca.s V_0
    IL_001C: ldarga.s src
    IL_001E: ldloc.1
    IL_001F: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0024: call System.UInt64& Z0.math::avgz(System.UInt64&,System.UInt64&)
    IL_0029: pop
    IL_002A: ldloc.1
    IL_002B: ldc.i4.1
    IL_002C: add
    IL_002D: stloc.1
    IL_002E: ldloc.1
    IL_002F: ldarga.s src
    IL_0031: call System.Int32 System.ReadOnlySpan`1<System.UInt64>::get_Length()
    IL_0036: blt.s IL_001A
    IL_0038: ldloc.0
    IL_0039: ret

}
byte avgi(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ldarg.0
    IL_0004: ldarg.1
    IL_0005: xor
    IL_0006: ldc.i4.1
    IL_0007: shr
    IL_0008: sub
    IL_0009: conv.u1
    IL_000A: ret

}
ushort avgi(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ldarg.0
    IL_0004: ldarg.1
    IL_0005: xor
    IL_0006: ldc.i4.1
    IL_0007: shr
    IL_0008: sub
    IL_0009: conv.u2
    IL_000A: ret

}
uint avgi(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ldarg.0
    IL_0004: ldarg.1
    IL_0005: xor
    IL_0006: ldc.i4.1
    IL_0007: shr.un
    IL_0008: sub
    IL_0009: ret

}
ulong avgi(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ldarg.0
    IL_0004: ldarg.1
    IL_0005: xor
    IL_0006: ldc.i4.1
    IL_0007: shr.un
    IL_0008: sub
    IL_0009: ret

}
sbyte avg(ReadOnlySpan<sbyte> src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldc.i4.0
    IL_0004: stloc.1
    IL_0005: br.s IL_0018
    IL_0007: ldloc.0
    IL_0008: ldarga.s src
    IL_000A: ldloc.1
    IL_000B: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0010: ldind.i1
    IL_0011: conv.i8
    IL_0012: add.ovf
    IL_0013: stloc.0
    IL_0014: ldloc.1
    IL_0015: ldc.i4.1
    IL_0016: add.ovf
    IL_0017: stloc.1
    IL_0018: ldloc.1
    IL_0019: ldarga.s src
    IL_001B: call System.Int32 System.ReadOnlySpan`1<System.SByte>::get_Length()
    IL_0020: blt.s IL_0007
    IL_0022: ldloc.0
    IL_0023: ldarga.s src
    IL_0025: call System.Int32 System.ReadOnlySpan`1<System.SByte>::get_Length()
    IL_002A: conv.i8
    IL_002B: div
    IL_002C: conv.ovf.i1
    IL_002D: ret

}
byte avg(ReadOnlySpan<byte> src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldc.i4.0
    IL_0004: stloc.1
    IL_0005: br.s IL_0018
    IL_0007: ldloc.0
    IL_0008: ldarga.s src
    IL_000A: ldloc.1
    IL_000B: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0010: ldind.u1
    IL_0011: conv.u8
    IL_0012: add.ovf.un
    IL_0013: stloc.0
    IL_0014: ldloc.1
    IL_0015: ldc.i4.1
    IL_0016: add.ovf
    IL_0017: stloc.1
    IL_0018: ldloc.1
    IL_0019: ldarga.s src
    IL_001B: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_0020: blt.s IL_0007
    IL_0022: ldloc.0
    IL_0023: ldarga.s src
    IL_0025: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_002A: conv.ovf.u8
    IL_002B: div.un
    IL_002C: conv.ovf.u1.un
    IL_002D: ret

}
short avg(ReadOnlySpan<short> src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldc.i4.0
    IL_0004: stloc.1
    IL_0005: br.s IL_0018
    IL_0007: ldloc.0
    IL_0008: ldarga.s src
    IL_000A: ldloc.1
    IL_000B: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0010: ldind.i2
    IL_0011: conv.i8
    IL_0012: add.ovf
    IL_0013: stloc.0
    IL_0014: ldloc.1
    IL_0015: ldc.i4.1
    IL_0016: add.ovf
    IL_0017: stloc.1
    IL_0018: ldloc.1
    IL_0019: ldarga.s src
    IL_001B: call System.Int32 System.ReadOnlySpan`1<System.Int16>::get_Length()
    IL_0020: blt.s IL_0007
    IL_0022: ldloc.0
    IL_0023: ldarga.s src
    IL_0025: call System.Int32 System.ReadOnlySpan`1<System.Int16>::get_Length()
    IL_002A: conv.i8
    IL_002B: div
    IL_002C: conv.ovf.i2
    IL_002D: ret

}
ushort avg(ReadOnlySpan<ushort> src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldc.i4.0
    IL_0004: stloc.1
    IL_0005: br.s IL_0018
    IL_0007: ldloc.0
    IL_0008: ldarga.s src
    IL_000A: ldloc.1
    IL_000B: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0010: ldind.u2
    IL_0011: conv.u8
    IL_0012: add.ovf.un
    IL_0013: stloc.0
    IL_0014: ldloc.1
    IL_0015: ldc.i4.1
    IL_0016: add.ovf
    IL_0017: stloc.1
    IL_0018: ldloc.1
    IL_0019: ldarga.s src
    IL_001B: call System.Int32 System.ReadOnlySpan`1<System.UInt16>::get_Length()
    IL_0020: blt.s IL_0007
    IL_0022: ldloc.0
    IL_0023: ldarga.s src
    IL_0025: call System.Int32 System.ReadOnlySpan`1<System.UInt16>::get_Length()
    IL_002A: conv.ovf.u8
    IL_002B: div.un
    IL_002C: conv.ovf.u2.un
    IL_002D: ret

}
int avg(ReadOnlySpan<int> src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldc.i4.0
    IL_0004: stloc.1
    IL_0005: br.s IL_0018
    IL_0007: ldloc.0
    IL_0008: ldarga.s src
    IL_000A: ldloc.1
    IL_000B: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0010: ldind.i4
    IL_0011: conv.i8
    IL_0012: add.ovf
    IL_0013: stloc.0
    IL_0014: ldloc.1
    IL_0015: ldc.i4.1
    IL_0016: add.ovf
    IL_0017: stloc.1
    IL_0018: ldloc.1
    IL_0019: ldarga.s src
    IL_001B: call System.Int32 System.ReadOnlySpan`1<System.Int32>::get_Length()
    IL_0020: blt.s IL_0007
    IL_0022: ldloc.0
    IL_0023: ldarga.s src
    IL_0025: call System.Int32 System.ReadOnlySpan`1<System.Int32>::get_Length()
    IL_002A: conv.i8
    IL_002B: div
    IL_002C: conv.ovf.i4
    IL_002D: ret

}
uint avg(ReadOnlySpan<uint> src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldc.i4.0
    IL_0004: stloc.1
    IL_0005: br.s IL_0018
    IL_0007: ldloc.0
    IL_0008: ldarga.s src
    IL_000A: ldloc.1
    IL_000B: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0010: ldind.u4
    IL_0011: conv.u8
    IL_0012: add.ovf.un
    IL_0013: stloc.0
    IL_0014: ldloc.1
    IL_0015: ldc.i4.1
    IL_0016: add.ovf
    IL_0017: stloc.1
    IL_0018: ldloc.1
    IL_0019: ldarga.s src
    IL_001B: call System.Int32 System.ReadOnlySpan`1<System.UInt32>::get_Length()
    IL_0020: blt.s IL_0007
    IL_0022: ldloc.0
    IL_0023: ldarga.s src
    IL_0025: call System.Int32 System.ReadOnlySpan`1<System.UInt32>::get_Length()
    IL_002A: conv.ovf.u8
    IL_002B: div.un
    IL_002C: conv.ovf.u4.un
    IL_002D: ret

}
long avg(ReadOnlySpan<long> src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldc.i4.0
    IL_0004: stloc.1
    IL_0005: br.s IL_0017
    IL_0007: ldloc.0
    IL_0008: ldarga.s src
    IL_000A: ldloc.1
    IL_000B: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0010: ldind.i8
    IL_0011: add.ovf
    IL_0012: stloc.0
    IL_0013: ldloc.1
    IL_0014: ldc.i4.1
    IL_0015: add.ovf
    IL_0016: stloc.1
    IL_0017: ldloc.1
    IL_0018: ldarga.s src
    IL_001A: call System.Int32 System.ReadOnlySpan`1<System.Int64>::get_Length()
    IL_001F: blt.s IL_0007
    IL_0021: ldloc.0
    IL_0022: ldarga.s src
    IL_0024: call System.Int32 System.ReadOnlySpan`1<System.Int64>::get_Length()
    IL_0029: conv.i8
    IL_002A: div
    IL_002B: ret

}
ulong avg(ReadOnlySpan<ulong> src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldc.i4.0
    IL_0004: stloc.1
    IL_0005: br.s IL_0017
    IL_0007: ldloc.0
    IL_0008: ldarga.s src
    IL_000A: ldloc.1
    IL_000B: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0010: ldind.i8
    IL_0011: add.ovf.un
    IL_0012: stloc.0
    IL_0013: ldloc.1
    IL_0014: ldc.i4.1
    IL_0015: add.ovf
    IL_0016: stloc.1
    IL_0017: ldloc.1
    IL_0018: ldarga.s src
    IL_001A: call System.Int32 System.ReadOnlySpan`1<System.UInt64>::get_Length()
    IL_001F: blt.s IL_0007
    IL_0021: ldloc.0
    IL_0022: ldarga.s src
    IL_0024: call System.Int32 System.ReadOnlySpan`1<System.UInt64>::get_Length()
    IL_0029: conv.ovf.u8
    IL_002A: div.un
    IL_002B: ret

}
float avg(ReadOnlySpan<float> src)
{
    IL_0000: ldc.r8 0
    IL_0009: stloc.0
    IL_000A: ldc.i4.0
    IL_000B: stloc.1
    IL_000C: br.s IL_001F
    IL_000E: ldloc.0
    IL_000F: ldarga.s src
    IL_0011: ldloc.1
    IL_0012: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0017: ldind.r4
    IL_0018: conv.r8
    IL_0019: add
    IL_001A: stloc.0
    IL_001B: ldloc.1
    IL_001C: ldc.i4.1
    IL_001D: add.ovf
    IL_001E: stloc.1
    IL_001F: ldloc.1
    IL_0020: ldarga.s src
    IL_0022: call System.Int32 System.ReadOnlySpan`1<System.Single>::get_Length()
    IL_0027: blt.s IL_000E
    IL_0029: ldloc.0
    IL_002A: ldarga.s src
    IL_002C: call System.Int32 System.ReadOnlySpan`1<System.Single>::get_Length()
    IL_0031: conv.r4
    IL_0032: conv.r8
    IL_0033: div
    IL_0034: conv.r4
    IL_0035: ret

}
double avg(ReadOnlySpan<double> src)
{
    IL_0000: ldc.r8 0
    IL_0009: stloc.0
    IL_000A: ldc.i4.0
    IL_000B: stloc.1
    IL_000C: br.s IL_001E
    IL_000E: ldloc.0
    IL_000F: ldarga.s src
    IL_0011: ldloc.1
    IL_0012: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0017: ldind.r8
    IL_0018: add
    IL_0019: stloc.0
    IL_001A: ldloc.1
    IL_001B: ldc.i4.1
    IL_001C: add.ovf
    IL_001D: stloc.1
    IL_001E: ldloc.1
    IL_001F: ldarga.s src
    IL_0021: call System.Int32 System.ReadOnlySpan`1<System.Double>::get_Length()
    IL_0026: blt.s IL_000E
    IL_0028: ldloc.0
    IL_0029: ldarga.s src
    IL_002B: call System.Int32 System.ReadOnlySpan`1<System.Double>::get_Length()
    IL_0030: conv.r8
    IL_0031: div
    IL_0032: ret

}
bool between(byte x, byte a, byte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_000C
    IL_0004: ldarg.0
    IL_0005: ldarg.2
    IL_0006: cgt
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret
    IL_000C: ldc.i4.0
    IL_000D: ret

}
bool between(sbyte x, sbyte a, sbyte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_000C
    IL_0004: ldarg.0
    IL_0005: ldarg.2
    IL_0006: cgt
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret
    IL_000C: ldc.i4.0
    IL_000D: ret

}
bool between(short x, short a, short b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_000C
    IL_0004: ldarg.0
    IL_0005: ldarg.2
    IL_0006: cgt
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret
    IL_000C: ldc.i4.0
    IL_000D: ret

}
bool between(ushort x, ushort a, ushort b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_000C
    IL_0004: ldarg.0
    IL_0005: ldarg.2
    IL_0006: cgt
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret
    IL_000C: ldc.i4.0
    IL_000D: ret

}
bool between(int x, int a, int b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_000C
    IL_0004: ldarg.0
    IL_0005: ldarg.2
    IL_0006: cgt
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret
    IL_000C: ldc.i4.0
    IL_000D: ret

}
bool between(uint x, uint a, uint b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.un.s IL_000C
    IL_0004: ldarg.0
    IL_0005: ldarg.2
    IL_0006: cgt.un
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret
    IL_000C: ldc.i4.0
    IL_000D: ret

}
bool between(long x, long a, long b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_000C
    IL_0004: ldarg.0
    IL_0005: ldarg.2
    IL_0006: cgt
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret
    IL_000C: ldc.i4.0
    IL_000D: ret

}
bool between(ulong x, ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.un.s IL_000C
    IL_0004: ldarg.0
    IL_0005: ldarg.2
    IL_0006: cgt.un
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret
    IL_000C: ldc.i4.0
    IL_000D: ret

}
sbyte dec(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: conv.i1
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
byte dec(byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: conv.u1
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
short dec(short src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: conv.i2
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
ushort dec(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: conv.u2
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
int dec(int src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: dup
    IL_0004: starg.s src
    IL_0006: ret

}
uint dec(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: dup
    IL_0004: starg.s src
    IL_0006: ret

}
long dec(long src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: conv.i8
    IL_0003: sub
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
ulong dec(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: conv.i8
    IL_0003: sub
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
ref sbyte dec(ref sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldc.i4.1
    IL_0004: sub
    IL_0005: conv.i1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref byte dec(ref byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldc.i4.1
    IL_0004: sub
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref short dec(ref short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldc.i4.1
    IL_0004: sub
    IL_0005: conv.i2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ushort dec(ref ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldc.i4.1
    IL_0004: sub
    IL_0005: conv.u2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref int dec(ref int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldc.i4.1
    IL_0004: sub
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref uint dec(ref uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldc.i4.1
    IL_0004: sub
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref long dec(ref long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: sub
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ulong dec(ref ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: sub
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
Span<sbyte> dec(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dec"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\dec.cs"
    IL_000C: ldc.i4 174
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.Span`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003B
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0028: ldarga.s src
    IL_002A: ldloc.1
    IL_002B: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0030: ldind.i1
    IL_0031: call System.SByte Z0.math::dec(System.SByte)
    IL_0036: stind.i1
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldloc.0
    IL_003D: blt.s IL_0020
    IL_003F: ldarg.1
    IL_0040: ret

}
Span<byte> dec(ReadOnlySpan<byte> src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dec"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\dec.cs"
    IL_000C: ldc.i4 182
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003B
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0028: ldarga.s src
    IL_002A: ldloc.1
    IL_002B: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0030: ldind.u1
    IL_0031: call System.Byte Z0.math::dec(System.Byte)
    IL_0036: stind.i1
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldloc.0
    IL_003D: blt.s IL_0020
    IL_003F: ldarg.1
    IL_0040: ret

}
Span<short> dec(ReadOnlySpan<short> src, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dec"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\dec.cs"
    IL_000C: ldc.i4 190
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.Span`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003B
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0028: ldarga.s src
    IL_002A: ldloc.1
    IL_002B: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0030: ldind.i2
    IL_0031: call System.Int16 Z0.math::dec(System.Int16)
    IL_0036: stind.i2
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldloc.0
    IL_003D: blt.s IL_0020
    IL_003F: ldarg.1
    IL_0040: ret

}
Span<ushort> dec(ReadOnlySpan<ushort> src, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dec"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\dec.cs"
    IL_000C: ldc.i4 198
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.Span`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003B
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0028: ldarga.s src
    IL_002A: ldloc.1
    IL_002B: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0030: ldind.u2
    IL_0031: call System.UInt16 Z0.math::dec(System.UInt16)
    IL_0036: stind.i2
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldloc.0
    IL_003D: blt.s IL_0020
    IL_003F: ldarg.1
    IL_0040: ret

}
Span<int> dec(ReadOnlySpan<int> src, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dec"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\dec.cs"
    IL_000C: ldc.i4 206
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.Span`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003B
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0028: ldarga.s src
    IL_002A: ldloc.1
    IL_002B: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0030: ldind.i4
    IL_0031: call System.Int32 Z0.math::dec(System.Int32)
    IL_0036: stind.i4
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldloc.0
    IL_003D: blt.s IL_0020
    IL_003F: ldarg.1
    IL_0040: ret

}
Span<uint> dec(ReadOnlySpan<uint> src, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dec"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\dec.cs"
    IL_000C: ldc.i4 214
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003B
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0028: ldarga.s src
    IL_002A: ldloc.1
    IL_002B: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0030: ldind.u4
    IL_0031: call System.UInt32 Z0.math::dec(System.UInt32)
    IL_0036: stind.i4
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldloc.0
    IL_003D: blt.s IL_0020
    IL_003F: ldarg.1
    IL_0040: ret

}
Span<long> dec(ReadOnlySpan<long> src, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dec"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\dec.cs"
    IL_000C: ldc.i4 222
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.Span`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003B
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0028: ldarga.s src
    IL_002A: ldloc.1
    IL_002B: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: call System.Int64 Z0.math::dec(System.Int64)
    IL_0036: stind.i8
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldloc.0
    IL_003D: blt.s IL_0020
    IL_003F: ldarg.1
    IL_0040: ret

}
Span<ulong> dec(ReadOnlySpan<ulong> src, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dec"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\dec.cs"
    IL_000C: ldc.i4 230
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003B
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0028: ldarga.s src
    IL_002A: ldloc.1
    IL_002B: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: call System.UInt64 Z0.math::dec(System.UInt64)
    IL_0036: stind.i8
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldloc.0
    IL_003D: blt.s IL_0020
    IL_003F: ldarg.1
    IL_0040: ret

}
Span<sbyte> dec(Span<sbyte> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_000C: call System.SByte& Z0.math::dec(System.SByte&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s io
    IL_0019: call System.Int32 System.Span`1<System.SByte>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<byte> dec(Span<byte> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_000C: call System.Byte& Z0.math::dec(System.Byte&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s io
    IL_0019: call System.Int32 System.Span`1<System.Byte>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<short> dec(Span<short> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_000C: call System.Int16& Z0.math::dec(System.Int16&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s io
    IL_0019: call System.Int32 System.Span`1<System.Int16>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<ushort> dec(Span<ushort> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_000C: call System.UInt16& Z0.math::dec(System.UInt16&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s io
    IL_0019: call System.Int32 System.Span`1<System.UInt16>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<int> dec(Span<int> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_000C: call System.Int32& Z0.math::dec(System.Int32&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s io
    IL_0019: call System.Int32 System.Span`1<System.Int32>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<uint> dec(Span<uint> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_000C: call System.UInt32& Z0.math::dec(System.UInt32&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s io
    IL_0019: call System.Int32 System.Span`1<System.UInt32>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<long> dec(Span<long> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_000C: call System.Int64& Z0.math::dec(System.Int64&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s io
    IL_0019: call System.Int32 System.Span`1<System.Int64>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<ulong> dec(Span<ulong> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_000C: call System.UInt64& Z0.math::dec(System.UInt64&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s io
    IL_0019: call System.Int32 System.Span`1<System.UInt64>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
bool divides(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: rem
    IL_0003: ldc.i4.0
    IL_0004: ceq
    IL_0006: ret

}
bool divides(byte lhs, byte rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: rem
    IL_0003: ldc.i4.0
    IL_0004: ceq
    IL_0006: ret

}
bool divides(short lhs, short rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: rem
    IL_0003: ldc.i4.0
    IL_0004: ceq
    IL_0006: ret

}
bool divides(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: rem
    IL_0003: ldc.i4.0
    IL_0004: ceq
    IL_0006: ret

}
bool divides(int lhs, int rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: rem
    IL_0003: ldc.i4.0
    IL_0004: ceq
    IL_0006: ret

}
bool divides(uint lhs, uint rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: rem.un
    IL_0003: ldc.i4.0
    IL_0004: ceq
    IL_0006: ret

}
bool divides(long lhs, long rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: rem
    IL_0003: ldc.i4.0
    IL_0004: conv.i8
    IL_0005: ceq
    IL_0007: ret

}
bool divides(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: rem.un
    IL_0003: ldc.i4.0
    IL_0004: conv.i8
    IL_0005: ceq
    IL_0007: ret

}
sbyte dot(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dot"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\dot.cs"
    IL_000C: ldc.i4.s 28
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: ldc.i4.0
    IL_001C: stloc.2
    IL_001D: br.s IL_003C
    IL_001F: ldarga.s lhs
    IL_0021: ldloc.2
    IL_0022: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0027: ldind.i1
    IL_0028: ldarga.s rhs
    IL_002A: ldloc.2
    IL_002B: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0030: ldind.i1
    IL_0031: ldloc.1
    IL_0032: call System.SByte Z0.math::fma(System.SByte,System.SByte,System.SByte)
    IL_0037: stloc.1
    IL_0038: ldloc.2
    IL_0039: ldc.i4.1
    IL_003A: add
    IL_003B: stloc.2
    IL_003C: ldloc.2
    IL_003D: ldloc.0
    IL_003E: blt.s IL_001F
    IL_0040: ldloc.1
    IL_0041: ret

}
byte dot(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dot"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\dot.cs"
    IL_000C: ldc.i4.s 42
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: ldc.i4.0
    IL_001C: stloc.2
    IL_001D: br.s IL_003C
    IL_001F: ldarga.s lhs
    IL_0021: ldloc.2
    IL_0022: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0027: ldind.u1
    IL_0028: ldarga.s rhs
    IL_002A: ldloc.2
    IL_002B: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0030: ldind.u1
    IL_0031: ldloc.1
    IL_0032: call System.Byte Z0.math::fma(System.Byte,System.Byte,System.Byte)
    IL_0037: stloc.1
    IL_0038: ldloc.2
    IL_0039: ldc.i4.1
    IL_003A: add
    IL_003B: stloc.2
    IL_003C: ldloc.2
    IL_003D: ldloc.0
    IL_003E: blt.s IL_001F
    IL_0040: ldloc.1
    IL_0041: ret

}
short dot(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dot"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\dot.cs"
    IL_000C: ldc.i4.s 56
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: ldc.i4.0
    IL_001C: stloc.2
    IL_001D: br.s IL_003C
    IL_001F: ldarga.s lhs
    IL_0021: ldloc.2
    IL_0022: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0027: ldind.i2
    IL_0028: ldarga.s rhs
    IL_002A: ldloc.2
    IL_002B: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0030: ldind.i2
    IL_0031: ldloc.1
    IL_0032: call System.Int16 Z0.math::fma(System.Int16,System.Int16,System.Int16)
    IL_0037: stloc.1
    IL_0038: ldloc.2
    IL_0039: ldc.i4.1
    IL_003A: add
    IL_003B: stloc.2
    IL_003C: ldloc.2
    IL_003D: ldloc.0
    IL_003E: blt.s IL_001F
    IL_0040: ldloc.1
    IL_0041: ret

}
ushort dot(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dot"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\dot.cs"
    IL_000C: ldc.i4.s 70
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: ldc.i4.0
    IL_001C: stloc.2
    IL_001D: br.s IL_003C
    IL_001F: ldarga.s lhs
    IL_0021: ldloc.2
    IL_0022: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0027: ldind.u2
    IL_0028: ldarga.s rhs
    IL_002A: ldloc.2
    IL_002B: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0030: ldind.u2
    IL_0031: ldloc.1
    IL_0032: call System.UInt16 Z0.math::fma(System.UInt16,System.UInt16,System.UInt16)
    IL_0037: stloc.1
    IL_0038: ldloc.2
    IL_0039: ldc.i4.1
    IL_003A: add
    IL_003B: stloc.2
    IL_003C: ldloc.2
    IL_003D: ldloc.0
    IL_003E: blt.s IL_001F
    IL_0040: ldloc.1
    IL_0041: ret

}
int dot(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dot"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\dot.cs"
    IL_000C: ldc.i4.s 84
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: ldc.i4.0
    IL_001C: stloc.2
    IL_001D: br.s IL_003C
    IL_001F: ldarga.s lhs
    IL_0021: ldloc.2
    IL_0022: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0027: ldind.i4
    IL_0028: ldarga.s rhs
    IL_002A: ldloc.2
    IL_002B: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0030: ldind.i4
    IL_0031: ldloc.1
    IL_0032: call System.Int32 Z0.math::fma(System.Int32,System.Int32,System.Int32)
    IL_0037: stloc.1
    IL_0038: ldloc.2
    IL_0039: ldc.i4.1
    IL_003A: add
    IL_003B: stloc.2
    IL_003C: ldloc.2
    IL_003D: ldloc.0
    IL_003E: blt.s IL_001F
    IL_0040: ldloc.1
    IL_0041: ret

}
uint dot(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dot"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\dot.cs"
    IL_000C: ldc.i4.s 98
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: ldc.i4.0
    IL_001C: stloc.2
    IL_001D: br.s IL_003C
    IL_001F: ldarga.s lhs
    IL_0021: ldloc.2
    IL_0022: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0027: ldind.u4
    IL_0028: ldarga.s rhs
    IL_002A: ldloc.2
    IL_002B: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0030: ldind.u4
    IL_0031: ldloc.1
    IL_0032: call System.UInt32 Z0.math::fma(System.UInt32,System.UInt32,System.UInt32)
    IL_0037: stloc.1
    IL_0038: ldloc.2
    IL_0039: ldc.i4.1
    IL_003A: add
    IL_003B: stloc.2
    IL_003C: ldloc.2
    IL_003D: ldloc.0
    IL_003E: blt.s IL_001F
    IL_0040: ldloc.1
    IL_0041: ret

}
long dot(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dot"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\dot.cs"
    IL_000C: ldc.i4.s 112
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: conv.i8
    IL_001B: stloc.1
    IL_001C: ldc.i4.0
    IL_001D: stloc.2
    IL_001E: br.s IL_003D
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.2
    IL_0023: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0028: ldind.i8
    IL_0029: ldarga.s rhs
    IL_002B: ldloc.2
    IL_002C: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0031: ldind.i8
    IL_0032: ldloc.1
    IL_0033: call System.Int64 Z0.math::fma(System.Int64,System.Int64,System.Int64)
    IL_0038: stloc.1
    IL_0039: ldloc.2
    IL_003A: ldc.i4.1
    IL_003B: add
    IL_003C: stloc.2
    IL_003D: ldloc.2
    IL_003E: ldloc.0
    IL_003F: blt.s IL_0020
    IL_0041: ldloc.1
    IL_0042: ret

}
ulong dot(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dot"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\dot.cs"
    IL_000C: ldc.i4.s 126
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: conv.i8
    IL_001B: stloc.1
    IL_001C: ldc.i4.0
    IL_001D: stloc.2
    IL_001E: br.s IL_003D
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.2
    IL_0023: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0028: ldind.i8
    IL_0029: ldarga.s rhs
    IL_002B: ldloc.2
    IL_002C: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0031: ldind.i8
    IL_0032: ldloc.1
    IL_0033: call System.UInt64 Z0.math::fma(System.UInt64,System.UInt64,System.UInt64)
    IL_0038: stloc.1
    IL_0039: ldloc.2
    IL_003A: ldc.i4.1
    IL_003B: add
    IL_003C: stloc.2
    IL_003D: ldloc.2
    IL_003E: ldloc.0
    IL_003F: blt.s IL_0020
    IL_0041: ldloc.1
    IL_0042: ret

}
bool eq(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool eq(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool eq(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool eq(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool eq(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool eq(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool eq(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool eq(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool eq(ReadOnlySpan<sbyte> src, sbyte target)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_000C: ldind.i1
    IL_000D: ldarg.1
    IL_000E: beq.s IL_0012
    IL_0010: ldc.i4.0
    IL_0011: ret
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.ReadOnlySpan`1<System.SByte>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldc.i4.1
    IL_0021: ret

}
bool eq(ReadOnlySpan<byte> src, byte target)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_000C: ldind.u1
    IL_000D: ldarg.1
    IL_000E: beq.s IL_0012
    IL_0010: ldc.i4.0
    IL_0011: ret
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldc.i4.1
    IL_0021: ret

}
bool eq(ReadOnlySpan<short> src, short target)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_000C: ldind.i2
    IL_000D: ldarg.1
    IL_000E: beq.s IL_0012
    IL_0010: ldc.i4.0
    IL_0011: ret
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.ReadOnlySpan`1<System.Int16>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldc.i4.1
    IL_0021: ret

}
bool eq(ReadOnlySpan<ushort> src, ushort target)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_000C: ldind.u2
    IL_000D: ldarg.1
    IL_000E: beq.s IL_0012
    IL_0010: ldc.i4.0
    IL_0011: ret
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.ReadOnlySpan`1<System.UInt16>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldc.i4.1
    IL_0021: ret

}
bool eq(ReadOnlySpan<int> src, int target)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_000C: ldind.i4
    IL_000D: ldarg.1
    IL_000E: beq.s IL_0012
    IL_0010: ldc.i4.0
    IL_0011: ret
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.ReadOnlySpan`1<System.Int32>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldc.i4.1
    IL_0021: ret

}
bool eq(ReadOnlySpan<uint> src, uint target)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_000C: ldind.u4
    IL_000D: ldarg.1
    IL_000E: beq.s IL_0012
    IL_0010: ldc.i4.0
    IL_0011: ret
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.ReadOnlySpan`1<System.UInt32>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldc.i4.1
    IL_0021: ret

}
bool eq(ReadOnlySpan<long> src, long target)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_000C: ldind.i8
    IL_000D: ldarg.1
    IL_000E: beq.s IL_0012
    IL_0010: ldc.i4.0
    IL_0011: ret
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.ReadOnlySpan`1<System.Int64>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldc.i4.1
    IL_0021: ret

}
bool eq(ReadOnlySpan<ulong> src, ulong target)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_000C: ldind.i8
    IL_000D: ldarg.1
    IL_000E: beq.s IL_0012
    IL_0010: ldc.i4.0
    IL_0011: ret
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.ReadOnlySpan`1<System.UInt64>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldc.i4.1
    IL_0021: ret

}
sbyte flip(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: conv.i1
    IL_0003: ret

}
byte flip(byte src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: conv.u1
    IL_0003: ret

}
short flip(short src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: conv.i2
    IL_0003: ret

}
ushort flip(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: conv.u2
    IL_0003: ret

}
int flip(int src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ret

}
uint flip(uint src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ret

}
long flip(long src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ret

}
ulong flip(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ret

}
ref sbyte flip(ref sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: not
    IL_0004: conv.i1
    IL_0005: stind.i1
    IL_0006: ldarg.0
    IL_0007: ret

}
ref byte flip(ref byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: not
    IL_0004: conv.u1
    IL_0005: stind.i1
    IL_0006: ldarg.0
    IL_0007: ret

}
ref short flip(ref short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: not
    IL_0004: conv.i2
    IL_0005: stind.i2
    IL_0006: ldarg.0
    IL_0007: ret

}
ref ushort flip(ref ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: not
    IL_0004: conv.u2
    IL_0005: stind.i2
    IL_0006: ldarg.0
    IL_0007: ret

}
ref int flip(ref int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: not
    IL_0004: stind.i4
    IL_0005: ldarg.0
    IL_0006: ret

}
ref uint flip(ref uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: not
    IL_0004: stind.i4
    IL_0005: ldarg.0
    IL_0006: ret

}
ref long flip(ref long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: not
    IL_0004: stind.i8
    IL_0005: ldarg.0
    IL_0006: ret

}
ref ulong flip(ref ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: not
    IL_0004: stind.i8
    IL_0005: ldarg.0
    IL_0006: ret

}
ref sbyte flip(in sbyte src, ref sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: not
    IL_0004: conv.i1
    IL_0005: stind.i1
    IL_0006: ldarg.1
    IL_0007: ret

}
ref byte flip(in byte src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: not
    IL_0004: conv.u1
    IL_0005: stind.i1
    IL_0006: ldarg.1
    IL_0007: ret

}
ref short flip(in short src, ref short dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: not
    IL_0004: conv.i2
    IL_0005: stind.i2
    IL_0006: ldarg.1
    IL_0007: ret

}
ref ushort flip(in ushort src, ref ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: not
    IL_0004: conv.u2
    IL_0005: stind.i2
    IL_0006: ldarg.1
    IL_0007: ret

}
ref int flip(in int src, ref int dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: not
    IL_0004: stind.i4
    IL_0005: ldarg.1
    IL_0006: ret

}
ref uint flip(in uint src, ref uint dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: not
    IL_0004: stind.i4
    IL_0005: ldarg.1
    IL_0006: ret

}
ref long flip(in long src, ref long dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: not
    IL_0004: stind.i8
    IL_0005: ldarg.1
    IL_0006: ret

}
ref ulong flip(in ulong src, ref ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: not
    IL_0004: stind.i8
    IL_0005: ldarg.1
    IL_0006: ret

}
sbyte fma(sbyte x, sbyte y, sbyte z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: conv.i1
    IL_0006: ret

}
byte fma(byte x, byte y, byte z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: conv.u1
    IL_0006: ret

}
short fma(short x, short y, short z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: conv.i2
    IL_0006: ret

}
ushort fma(ushort x, ushort y, ushort z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: conv.u2
    IL_0006: ret

}
int fma(int x, int y, int z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: ret

}
uint fma(uint x, uint y, uint z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: ret

}
long fma(long x, long y, long z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: ret

}
ulong fma(ulong x, ulong y, ulong z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: ret

}
sbyte abs(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.7
    IL_0003: shr
    IL_0004: add
    IL_0005: ldarg.0
    IL_0006: ldc.i4.7
    IL_0007: shr
    IL_0008: xor
    IL_0009: conv.i1
    IL_000A: ret

}
short abs(short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.s 15
    IL_0004: shr
    IL_0005: add
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 15
    IL_0009: shr
    IL_000A: xor
    IL_000B: conv.i2
    IL_000C: ret

}
int abs(int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.s 31
    IL_0004: shr
    IL_0005: add
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 31
    IL_0009: shr
    IL_000A: xor
    IL_000B: ret

}
long abs(long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.s 63
    IL_0004: shr
    IL_0005: add
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 63
    IL_0009: shr
    IL_000A: xor
    IL_000B: ret

}
float abs(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Abs(System.Single)
    IL_0006: ret

}
double abs(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Abs(System.Double)
    IL_0006: ret

}
ref sbyte abs(ref sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: call System.SByte Z0.math::abs(System.SByte)
    IL_0008: stind.i1
    IL_0009: ldarg.0
    IL_000A: ret

}
ref short abs(ref short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: call System.Int16 Z0.math::abs(System.Int16)
    IL_0008: stind.i2
    IL_0009: ldarg.0
    IL_000A: ret

}
ref int abs(ref int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: call System.Int32 Z0.math::abs(System.Int32)
    IL_0008: stind.i4
    IL_0009: ldarg.0
    IL_000A: ret

}
ref long abs(ref long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: call System.Int64 Z0.math::abs(System.Int64)
    IL_0008: stind.i8
    IL_0009: ldarg.0
    IL_000A: ret

}
Span<sbyte> abs(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "abs"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\abs.cs"
    IL_000C: ldc.i4.s 109
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.Span`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_002D: ldind.i1
    IL_002E: call System.SByte Z0.math::abs(System.SByte)
    IL_0033: stind.i1
    IL_0034: ldloc.1
    IL_0035: ldc.i4.1
    IL_0036: add
    IL_0037: stloc.1
    IL_0038: ldloc.1
    IL_0039: ldloc.0
    IL_003A: blt.s IL_001D
    IL_003C: ldarg.1
    IL_003D: ret

}
Span<short> abs(ReadOnlySpan<short> src, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "abs"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\abs.cs"
    IL_000C: ldc.i4.s 117
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.Span`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_002D: ldind.i2
    IL_002E: call System.Int16 Z0.math::abs(System.Int16)
    IL_0033: stind.i2
    IL_0034: ldloc.1
    IL_0035: ldc.i4.1
    IL_0036: add
    IL_0037: stloc.1
    IL_0038: ldloc.1
    IL_0039: ldloc.0
    IL_003A: blt.s IL_001D
    IL_003C: ldarg.1
    IL_003D: ret

}
Span<int> abs(ReadOnlySpan<int> src, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "abs"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\abs.cs"
    IL_000C: ldc.i4.s 125
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.Span`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_002D: ldind.i4
    IL_002E: call System.Int32 Z0.math::abs(System.Int32)
    IL_0033: stind.i4
    IL_0034: ldloc.1
    IL_0035: ldc.i4.1
    IL_0036: add
    IL_0037: stloc.1
    IL_0038: ldloc.1
    IL_0039: ldloc.0
    IL_003A: blt.s IL_001D
    IL_003C: ldarg.1
    IL_003D: ret

}
Span<long> abs(ReadOnlySpan<long> src, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "abs"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\abs.cs"
    IL_000C: ldc.i4 133
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.Span`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003B
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0028: ldarga.s src
    IL_002A: ldloc.1
    IL_002B: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: call System.Int64 Z0.math::abs(System.Int64)
    IL_0036: stind.i8
    IL_0037: ldloc.1
    IL_0038: ldc.i4.1
    IL_0039: add
    IL_003A: stloc.1
    IL_003B: ldloc.1
    IL_003C: ldloc.0
    IL_003D: blt.s IL_0020
    IL_003F: ldarg.1
    IL_0040: ret

}
Span<sbyte> abs(Span<sbyte> src)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_000C: call System.SByte& Z0.math::abs(System.SByte&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.Span`1<System.SByte>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<short> abs(Span<short> src)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_000C: call System.Int16& Z0.math::abs(System.Int16&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.Span`1<System.Int16>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<int> abs(Span<int> src)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_000C: call System.Int32& Z0.math::abs(System.Int32&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.Span`1<System.Int32>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<long> abs(Span<long> src)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_000C: call System.Int64& Z0.math::abs(System.Int64&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s src
    IL_0019: call System.Int32 System.Span`1<System.Int64>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
sbyte add(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: conv.i1
    IL_0004: ret

}
byte add(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: conv.u1
    IL_0004: ret

}
short add(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: conv.i2
    IL_0004: ret

}
ushort add(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: conv.u2
    IL_0004: ret

}
int add(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
uint add(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
long add(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
ulong add(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
ref sbyte add(ref sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: add
    IL_0005: conv.i1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref byte add(ref byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: add
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref short add(ref short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: add
    IL_0005: conv.i2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ushort add(ref ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: add
    IL_0005: conv.u2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref int add(ref int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: add
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref uint add(ref uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: add
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref long add(ref long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: add
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref ulong add(ref ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: add
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
sbyte add(sbyte lhs, sbyte rhs, out sbyte dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: add
    IL_0004: conv.i1
    IL_0005: dup
    IL_0006: stloc.0
    IL_0007: stind.i1
    IL_0008: ldloc.0
    IL_0009: ret

}
byte add(byte lhs, byte rhs, out byte dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: add
    IL_0004: conv.u1
    IL_0005: dup
    IL_0006: stloc.0
    IL_0007: stind.i1
    IL_0008: ldloc.0
    IL_0009: ret

}
short add(short lhs, short rhs, out short dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: add
    IL_0004: conv.i2
    IL_0005: dup
    IL_0006: stloc.0
    IL_0007: stind.i2
    IL_0008: ldloc.0
    IL_0009: ret

}
ushort add(ushort lhs, ushort rhs, out ushort dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: add
    IL_0004: conv.u2
    IL_0005: dup
    IL_0006: stloc.0
    IL_0007: stind.i2
    IL_0008: ldloc.0
    IL_0009: ret

}
int add(int lhs, int rhs, out int dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: add
    IL_0004: dup
    IL_0005: stloc.0
    IL_0006: stind.i4
    IL_0007: ldloc.0
    IL_0008: ret

}
uint add(uint lhs, uint rhs, out uint dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: add
    IL_0004: dup
    IL_0005: stloc.0
    IL_0006: stind.i4
    IL_0007: ldloc.0
    IL_0008: ret

}
long add(long lhs, long rhs, out long dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: add
    IL_0004: dup
    IL_0005: stloc.0
    IL_0006: stind.i8
    IL_0007: ldloc.0
    IL_0008: ret

}
ulong add(ulong lhs, ulong rhs, out ulong dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: add
    IL_0004: dup
    IL_0005: stloc.0
    IL_0006: stind.i8
    IL_0007: ldloc.0
    IL_0008: ret

}
Span<sbyte> add(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\add.cs"
    IL_000C: ldc.i4 141
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0030: ldind.i1
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0039: ldind.i1
    IL_003A: call System.SByte Z0.math::add(System.SByte,System.SByte)
    IL_003F: stind.i1
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<byte> add(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\add.cs"
    IL_000C: ldc.i4 149
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0041
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0030: ldind.u1
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0039: ldind.u1
    IL_003A: add
    IL_003B: conv.u1
    IL_003C: stind.i1
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_0020
    IL_0045: ldarg.2
    IL_0046: ret

}
Span<short> add(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\add.cs"
    IL_000C: ldc.i4 157
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0030: ldind.i2
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0039: ldind.i2
    IL_003A: call System.Int16 Z0.math::add(System.Int16,System.Int16)
    IL_003F: stind.i2
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<ushort> add(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\add.cs"
    IL_000C: ldc.i4 165
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0030: ldind.u2
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0039: ldind.u2
    IL_003A: call System.UInt16 Z0.math::add(System.UInt16,System.UInt16)
    IL_003F: stind.i2
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<int> add(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\add.cs"
    IL_000C: ldc.i4 173
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0030: ldind.i4
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0039: ldind.i4
    IL_003A: call System.Int32 Z0.math::add(System.Int32,System.Int32)
    IL_003F: stind.i4
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<uint> add(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\add.cs"
    IL_000C: ldc.i4 181
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0030: ldind.u4
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0039: ldind.u4
    IL_003A: call System.UInt32 Z0.math::add(System.UInt32,System.UInt32)
    IL_003F: stind.i4
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<long> add(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\add.cs"
    IL_000C: ldc.i4 189
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0039: ldind.i8
    IL_003A: call System.Int64 Z0.math::add(System.Int64,System.Int64)
    IL_003F: stind.i8
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<ulong> add(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\add.cs"
    IL_000C: ldc.i4 197
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0039: ldind.i8
    IL_003A: call System.UInt64 Z0.math::add(System.UInt64,System.UInt64)
    IL_003F: stind.i8
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<sbyte> add(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\add.cs"
    IL_000C: ldc.i4 205
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.SByte>(System.Span`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i1
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0032: ldind.i1
    IL_0033: add
    IL_0034: conv.i1
    IL_0035: stind.i1
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<byte> add(Span<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\add.cs"
    IL_000C: ldc.i4 213
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Byte>(System.Span`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u1
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0032: ldind.u1
    IL_0033: add
    IL_0034: conv.u1
    IL_0035: stind.i1
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<short> add(Span<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\add.cs"
    IL_000C: ldc.i4 221
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int16>(System.Span`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i2
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0032: ldind.i2
    IL_0033: add
    IL_0034: conv.i2
    IL_0035: stind.i2
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<ushort> add(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\add.cs"
    IL_000C: ldc.i4 229
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt16>(System.Span`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u2
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0032: ldind.u2
    IL_0033: add
    IL_0034: conv.u2
    IL_0035: stind.i2
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<int> add(Span<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\add.cs"
    IL_000C: ldc.i4 237
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int32>(System.Span`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i4
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0032: ldind.i4
    IL_0033: add
    IL_0034: stind.i4
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<uint> add(Span<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\add.cs"
    IL_000C: ldc.i4 245
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt32>(System.Span`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u4
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0032: ldind.u4
    IL_0033: add
    IL_0034: stind.i4
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<long> add(Span<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\add.cs"
    IL_000C: ldc.i4 253
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int64>(System.Span`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i8
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0032: ldind.i8
    IL_0033: add
    IL_0034: stind.i8
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<ulong> add(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\add.cs"
    IL_000C: ldc.i4 261
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt64>(System.Span`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i8
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0032: ldind.i8
    IL_0033: add
    IL_0034: stind.i8
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<sbyte> add(Span<sbyte> lhs, sbyte rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i1
    IL_000E: ldarg.1
    IL_000F: add
    IL_0010: conv.i1
    IL_0011: stind.i1
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s lhs
    IL_0019: call System.Int32 System.Span`1<System.SByte>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<byte> add(Span<byte> lhs, byte rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.u1
    IL_000E: ldarg.1
    IL_000F: add
    IL_0010: conv.u1
    IL_0011: stind.i1
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s lhs
    IL_0019: call System.Int32 System.Span`1<System.Byte>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<short> add(Span<short> lhs, short rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i2
    IL_000E: ldarg.1
    IL_000F: add
    IL_0010: conv.i2
    IL_0011: stind.i2
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s lhs
    IL_0019: call System.Int32 System.Span`1<System.Int16>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<ushort> add(Span<ushort> lhs, ushort rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.u2
    IL_000E: ldarg.1
    IL_000F: add
    IL_0010: conv.u2
    IL_0011: stind.i2
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s lhs
    IL_0019: call System.Int32 System.Span`1<System.UInt16>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<int> add(Span<int> lhs, int rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i4
    IL_000E: ldarg.1
    IL_000F: add
    IL_0010: stind.i4
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.Int32>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
Span<uint> add(Span<uint> lhs, uint rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.u4
    IL_000E: ldarg.1
    IL_000F: add
    IL_0010: stind.i4
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.UInt32>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
Span<long> add(Span<long> lhs, long rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i8
    IL_000E: ldarg.1
    IL_000F: add
    IL_0010: stind.i8
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.Int64>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
Span<ulong> add(Span<ulong> lhs, ulong rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i8
    IL_000E: ldarg.1
    IL_000F: add
    IL_0010: stind.i8
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.UInt64>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
sbyte and(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: conv.i1
    IL_0004: ret

}
byte and(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: conv.u1
    IL_0004: ret

}
short and(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: conv.i2
    IL_0004: ret

}
ushort and(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: conv.u2
    IL_0004: ret

}
int and(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
uint and(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
long and(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
ulong and(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
float and(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0006: ldarg.1
    IL_0007: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_000C: and
    IL_000D: call System.Single System.BitConverter::Int32BitsToSingle(System.Int32)
    IL_0012: ret

}
double and(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0006: ldarg.1
    IL_0007: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_000C: and
    IL_000D: call System.Double System.BitConverter::Int64BitsToDouble(System.Int64)
    IL_0012: ret

}
ref sbyte and(in sbyte lhs, in sbyte rhs, ref sbyte dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: ldind.i1
    IL_0005: and
    IL_0006: conv.i1
    IL_0007: stind.i1
    IL_0008: ldarg.2
    IL_0009: ret

}
ref byte and(in byte lhs, in byte rhs, ref byte dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldind.u1
    IL_0005: and
    IL_0006: conv.u1
    IL_0007: stind.i1
    IL_0008: ldarg.2
    IL_0009: ret

}
ref short and(in short lhs, in short rhs, ref short dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: ldind.i2
    IL_0005: and
    IL_0006: conv.i2
    IL_0007: stind.i2
    IL_0008: ldarg.2
    IL_0009: ret

}
ref ushort and(in ushort lhs, in ushort rhs, ref ushort dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldind.u2
    IL_0005: and
    IL_0006: conv.u2
    IL_0007: stind.i2
    IL_0008: ldarg.2
    IL_0009: ret

}
ref int and(in int lhs, in int rhs, ref int dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: ldind.i4
    IL_0005: and
    IL_0006: stind.i4
    IL_0007: ldarg.2
    IL_0008: ret

}
ref uint and(in uint lhs, in uint rhs, ref uint dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldind.u4
    IL_0005: and
    IL_0006: stind.i4
    IL_0007: ldarg.2
    IL_0008: ret

}
ref long and(in long lhs, in long rhs, ref long dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: and
    IL_0006: stind.i8
    IL_0007: ldarg.2
    IL_0008: ret

}
ref ulong and(in ulong lhs, in ulong rhs, ref ulong dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: and
    IL_0006: stind.i8
    IL_0007: ldarg.2
    IL_0008: ret

}
ref float and(in float lhs, in float rhs, ref float dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0008: ldarg.1
    IL_0009: ldind.r4
    IL_000A: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_000F: and
    IL_0010: call System.Single System.BitConverter::Int32BitsToSingle(System.Int32)
    IL_0015: stind.r4
    IL_0016: ldarg.2
    IL_0017: ret

}
ref double and(in double lhs, in double rhs, ref double dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0008: ldarg.1
    IL_0009: ldind.r8
    IL_000A: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_000F: and
    IL_0010: call System.Double System.BitConverter::Int64BitsToDouble(System.Int64)
    IL_0015: stind.r8
    IL_0016: ldarg.2
    IL_0017: ret

}
ref sbyte and(ref sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: and
    IL_0005: conv.i1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref byte and(ref byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: and
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref short and(ref short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: and
    IL_0005: conv.i2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ushort and(ref ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: and
    IL_0005: conv.u2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref int and(ref int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: and
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref uint and(ref uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: and
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref long and(ref long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: and
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref ulong and(ref ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: and
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref float and(ref float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: ldarg.1
    IL_0004: call System.Single Z0.math::and(System.Single,System.Single)
    IL_0009: stind.r4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref double and(ref double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldarg.1
    IL_0004: call System.Double Z0.math::and(System.Double,System.Double)
    IL_0009: stind.r8
    IL_000A: ldarg.0
    IL_000B: ret

}
Span<sbyte> and(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 201
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0030: ldind.i1
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0039: ldind.i1
    IL_003A: call System.SByte Z0.math::and(System.SByte,System.SByte)
    IL_003F: stind.i1
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<byte> and(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 209
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0030: ldind.u1
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0039: ldind.u1
    IL_003A: call System.Byte Z0.math::and(System.Byte,System.Byte)
    IL_003F: stind.i1
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<short> and(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 217
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0030: ldind.i2
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0039: ldind.i2
    IL_003A: call System.Int16 Z0.math::and(System.Int16,System.Int16)
    IL_003F: stind.i2
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<ushort> and(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 225
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0030: ldind.u2
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0039: ldind.u2
    IL_003A: call System.UInt16 Z0.math::and(System.UInt16,System.UInt16)
    IL_003F: stind.i2
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<int> and(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 233
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0030: ldind.i4
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0039: ldind.i4
    IL_003A: call System.Int32 Z0.math::and(System.Int32,System.Int32)
    IL_003F: stind.i4
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<uint> and(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 241
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0030: ldind.u4
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0039: ldind.u4
    IL_003A: call System.UInt32 Z0.math::and(System.UInt32,System.UInt32)
    IL_003F: stind.i4
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<long> and(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 249
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0039: ldind.i8
    IL_003A: call System.Int64 Z0.math::and(System.Int64,System.Int64)
    IL_003F: stind.i8
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<ulong> and(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 257
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0039: ldind.i8
    IL_003A: call System.UInt64 Z0.math::and(System.UInt64,System.UInt64)
    IL_003F: stind.i8
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<float> and(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 265
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Single,System.Single>(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0030: ldind.r4
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0039: ldind.r4
    IL_003A: call System.Single Z0.math::and(System.Single,System.Single)
    IL_003F: stind.r4
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<double> and(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 273
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Double,System.Double>(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0030: ldind.r8
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0039: ldind.r8
    IL_003A: call System.Double Z0.math::and(System.Double,System.Double)
    IL_003F: stind.r8
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.2
    IL_0049: ret

}
Span<sbyte> and(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 281
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.SByte>(System.Span`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i1
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0032: ldind.i1
    IL_0033: and
    IL_0034: conv.i1
    IL_0035: stind.i1
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<byte> and(Span<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 289
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Byte>(System.Span`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u1
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0032: ldind.u1
    IL_0033: and
    IL_0034: conv.u1
    IL_0035: stind.i1
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<short> and(Span<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 297
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int16>(System.Span`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i2
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0032: ldind.i2
    IL_0033: and
    IL_0034: conv.i2
    IL_0035: stind.i2
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<ushort> and(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 305
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt16>(System.Span`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003A
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u2
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0032: ldind.u2
    IL_0033: and
    IL_0034: conv.u2
    IL_0035: stind.i2
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_0020
    IL_003E: ldarg.0
    IL_003F: ret

}
Span<int> and(Span<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 313
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int32>(System.Span`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i4
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0032: ldind.i4
    IL_0033: and
    IL_0034: stind.i4
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<uint> and(Span<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 321
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt32>(System.Span`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.u4
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0032: ldind.u4
    IL_0033: and
    IL_0034: stind.i4
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<long> and(Span<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 329
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int64>(System.Span`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i8
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0032: ldind.i8
    IL_0033: and
    IL_0034: stind.i8
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<ulong> and(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 337
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt64>(System.Span`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0039
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0028: dup
    IL_0029: ldind.i8
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.1
    IL_002D: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0032: ldind.i8
    IL_0033: and
    IL_0034: stind.i8
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_0020
    IL_003D: ldarg.0
    IL_003E: ret

}
Span<float> and(Span<float> lhs, ReadOnlySpan<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 345
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Single>(System.Span`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0030: ldind.r4
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0039: ldind.r4
    IL_003A: call System.Single Z0.math::and(System.Single,System.Single)
    IL_003F: stind.r4
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.0
    IL_0049: ret

}
Span<double> and(Span<double> lhs, ReadOnlySpan<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\operators\\and.cs"
    IL_000C: ldc.i4 353
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Double>(System.Span`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s lhs
    IL_0022: ldloc.1
    IL_0023: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0030: ldind.r8
    IL_0031: ldarga.s rhs
    IL_0033: ldloc.1
    IL_0034: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0039: ldind.r8
    IL_003A: call System.Double Z0.math::and(System.Double,System.Double)
    IL_003F: stind.r8
    IL_0040: ldloc.1
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.1
    IL_0044: ldloc.1
    IL_0045: ldloc.0
    IL_0046: blt.s IL_0020
    IL_0048: ldarg.0
    IL_0049: ret

}
Span<sbyte> and(Span<sbyte> lhs, sbyte rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i1
    IL_000E: ldarg.1
    IL_000F: and
    IL_0010: conv.i1
    IL_0011: stind.i1
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s lhs
    IL_0019: call System.Int32 System.Span`1<System.SByte>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<byte> and(Span<byte> lhs, byte rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.u1
    IL_000E: ldarg.1
    IL_000F: and
    IL_0010: conv.u1
    IL_0011: stind.i1
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s lhs
    IL_0019: call System.Int32 System.Span`1<System.Byte>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<short> and(Span<short> lhs, short rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i2
    IL_000E: ldarg.1
    IL_000F: and
    IL_0010: conv.i2
    IL_0011: stind.i2
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s lhs
    IL_0019: call System.Int32 System.Span`1<System.Int16>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<ushort> and(Span<ushort> lhs, ushort rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.u2
    IL_000E: ldarg.1
    IL_000F: and
    IL_0010: conv.u2
    IL_0011: stind.i2
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s lhs
    IL_0019: call System.Int32 System.Span`1<System.UInt16>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<int> and(Span<int> lhs, int rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i4
    IL_000E: ldarg.1
    IL_000F: and
    IL_0010: stind.i4
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.Int32>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
Span<uint> and(Span<uint> lhs, uint rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.u4
    IL_000E: ldarg.1
    IL_000F: and
    IL_0010: stind.i4
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.UInt32>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
Span<long> and(Span<long> lhs, long rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i8
    IL_000E: ldarg.1
    IL_000F: and
    IL_0010: stind.i8
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.Int64>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
Span<ulong> and(Span<ulong> lhs, ulong rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.i8
    IL_000E: ldarg.1
    IL_000F: and
    IL_0010: stind.i8
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.UInt64>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
Span<float> and(Span<float> lhs, float rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0014: ldind.r4
    IL_0015: ldarg.1
    IL_0016: call System.Single Z0.math::and(System.Single,System.Single)
    IL_001B: stind.r4
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s lhs
    IL_0023: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.0
    IL_002B: ret

}
Span<double> and(Span<double> lhs, double rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_000C: ldarga.s lhs
    IL_000E: ldloc.0
    IL_000F: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0014: ldind.r8
    IL_0015: ldarg.1
    IL_0016: call System.Double Z0.math::and(System.Double,System.Double)
    IL_001B: stind.r8
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s lhs
    IL_0023: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.0
    IL_002B: ret

}
byte avgz(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ldarg.1
    IL_0005: xor
    IL_0006: ldc.i4.1
    IL_0007: shr
    IL_0008: add
    IL_0009: conv.u1
    IL_000A: ret

}
ushort avgz(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ldarg.1
    IL_0005: xor
    IL_0006: ldc.i4.1
    IL_0007: shr
    IL_0008: add
    IL_0009: conv.u2
    IL_000A: ret

}

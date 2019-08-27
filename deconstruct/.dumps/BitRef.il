// 2019-08-26 19:39:48:526
Span<sbyte> and(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000C: ldc.i4 135
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000C: ldc.i4 143
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000C: ldc.i4 151
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000C: ldc.i4 159
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000C: ldc.i4 167
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000C: ldc.i4 175
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000C: ldc.i4 183
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000C: ldc.i4 191
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000C: ldc.i4 199
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000C: ldc.i4 207
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000C: ldc.i4 215
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000C: ldc.i4 223
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000C: ldc.i4 231
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000C: ldc.i4 239
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000C: ldc.i4 247
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000C: ldc.i4 255
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000C: ldc.i4 263
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000C: ldc.i4 271
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
Span<byte> And(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "And"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000E: ldc.i4 335
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Byte> zfunc::span<System.Byte>(System.Int32)
    IL_0022: call System.Span`1<System.Byte> Z0.BitRef::and(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Byte>)
    IL_0027: ret

}
Span<sbyte> And(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "And"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000E: ldc.i4 339
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.SByte> zfunc::span<System.SByte>(System.Int32)
    IL_0022: call System.Span`1<System.SByte> Z0.BitRef::and(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.Span`1<System.SByte>)
    IL_0027: ret

}
Span<short> And(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "And"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000E: ldc.i4 343
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Int16> zfunc::span<System.Int16>(System.Int32)
    IL_0022: call System.Span`1<System.Int16> Z0.BitRef::and(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.Span`1<System.Int16>)
    IL_0027: ret

}
Span<ushort> And(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "And"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000E: ldc.i4 347
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.UInt16> zfunc::span<System.UInt16>(System.Int32)
    IL_0022: call System.Span`1<System.UInt16> Z0.BitRef::and(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.Span`1<System.UInt16>)
    IL_0027: ret

}
Span<int> And(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "And"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000E: ldc.i4 351
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Int32> zfunc::span<System.Int32>(System.Int32)
    IL_0022: call System.Span`1<System.Int32> Z0.BitRef::and(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.Span`1<System.Int32>)
    IL_0027: ret

}
Span<uint> And(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "And"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000E: ldc.i4 355
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.UInt32> zfunc::span<System.UInt32>(System.Int32)
    IL_0022: call System.Span`1<System.UInt32> Z0.BitRef::and(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>)
    IL_0027: ret

}
Span<long> And(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "And"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000E: ldc.i4 359
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Int64> zfunc::span<System.Int64>(System.Int32)
    IL_0022: call System.Span`1<System.Int64> Z0.BitRef::and(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.Span`1<System.Int64>)
    IL_0027: ret

}
Span<ulong> And(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "And"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\And.cs"
    IL_000E: ldc.i4 363
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.UInt64> zfunc::span<System.UInt64>(System.Int32)
    IL_0022: call System.Span`1<System.UInt64> Z0.BitRef::and(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.UInt64>)
    IL_0027: ret

}
Span<byte> And(Span<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Span`1<System.Byte> Z0.BitRef::and(System.Span`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>)
    IL_0007: ret

}
Span<sbyte> And(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Span`1<System.SByte> Z0.BitRef::and(System.Span`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>)
    IL_0007: ret

}
Span<short> And(Span<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Span`1<System.Int16> Z0.BitRef::and(System.Span`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>)
    IL_0007: ret

}
Span<ushort> And(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Span`1<System.UInt16> Z0.BitRef::and(System.Span`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>)
    IL_0007: ret

}
Span<int> And(Span<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Span`1<System.Int32> Z0.BitRef::and(System.Span`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>)
    IL_0007: ret

}
Span<uint> And(Span<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Span`1<System.UInt32> Z0.BitRef::and(System.Span`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>)
    IL_0007: ret

}
Span<long> And(Span<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Span`1<System.Int64> Z0.BitRef::and(System.Span`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>)
    IL_0007: ret

}
Span<ulong> And(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Span`1<System.UInt64> Z0.BitRef::and(System.Span`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>)
    IL_0007: ret

}
BitMatrix8 MatMul(BitMatrix8 lhs, BitMatrix8 rhs)
{
    IL_0000: ldloca.s V_1
    IL_0002: initobj System.Nullable`1<Z0.Bit>
    IL_0008: ldloc.1
    IL_0009: call Z0.BitMatrix8 Z0.BitMatrix8::Alloc(System.Nullable`1<Z0.Bit>)
    IL_000E: stloc.0
    IL_000F: ldarga.s rhs
    IL_0011: call Z0.BitMatrix8 Z0.BitMatrix8::Transpose()
    IL_0016: starg.s rhs
    IL_0018: ldc.i4.0
    IL_0019: stloc.2
    IL_001A: br.s IL_0061
    IL_001C: ldarga.s lhs
    IL_001E: ldloc.2
    IL_001F: call Z0.BitVector8 Z0.BitMatrix8::RowVector(System.Int32)
    IL_0024: stloc.3
    IL_0025: ldc.i4.0
    IL_0026: stloc.s V_4
    IL_0028: br.s IL_0052
    IL_002A: ldarga.s rhs
    IL_002C: ldloc.s V_4
    IL_002E: call Z0.BitVector8 Z0.BitMatrix8::RowVector(System.Int32)
    IL_0033: stloc.s V_5
    IL_0035: ldloca.s V_0
    IL_0037: ldloc.2
    IL_0038: ldloc.s V_4
    IL_003A: ldloc.3
    IL_003B: ldloc.s V_5
    IL_003D: call System.Int32 Z0.BitRef::ModProd(Z0.BitVector8,Z0.BitVector8)
    IL_0042: call Z0.Bit Z0.Bit::op_Implicit(System.Int32)
    IL_0047: call System.Void Z0.BitMatrix8::set_Item(System.Int32,System.Int32,Z0.Bit)
    IL_004C: ldloc.s V_4
    IL_004E: ldc.i4.1
    IL_004F: add
    IL_0050: stloc.s V_4
    IL_0052: ldloc.s V_4
    IL_0054: ldarga.s rhs
    IL_0056: call System.Int32 Z0.BitMatrix8::get_ColCount()
    IL_005B: blt.s IL_002A
    IL_005D: ldloc.2
    IL_005E: ldc.i4.1
    IL_005F: add
    IL_0060: stloc.2
    IL_0061: ldloc.2
    IL_0062: ldarga.s lhs
    IL_0064: call System.Int32 Z0.BitMatrix8::get_RowCount()
    IL_0069: blt.s IL_001C
    IL_006B: ldloc.0
    IL_006C: ret

}
BitMatrix16 MatMul(BitMatrix16 lhs, BitMatrix16 rhs)
{
    IL_0000: call Z0.BitMatrix16 Z0.BitMatrix16::Alloc()
    IL_0005: stloc.0
    IL_0006: ldarga.s rhs
    IL_0008: call Z0.BitMatrix16 Z0.BitMatrix16::Transpose()
    IL_000D: starg.s rhs
    IL_000F: ldc.i4.0
    IL_0010: stloc.1
    IL_0011: br.s IL_0052
    IL_0013: ldarga.s lhs
    IL_0015: ldloc.1
    IL_0016: call Z0.BitVector16 Z0.BitMatrix16::RowVector(System.Int32)
    IL_001B: stloc.2
    IL_001C: ldc.i4.0
    IL_001D: stloc.3
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s rhs
    IL_0022: ldloc.3
    IL_0023: call Z0.BitVector16 Z0.BitMatrix16::RowVector(System.Int32)
    IL_0028: stloc.s V_4
    IL_002A: ldloca.s V_0
    IL_002C: ldloc.1
    IL_002D: ldloc.3
    IL_002E: ldloc.2
    IL_002F: ldloc.s V_4
    IL_0031: call System.Int32 Z0.BitRef::ModProd(Z0.BitVector16,Z0.BitVector16)
    IL_0036: call Z0.Bit Z0.Bit::op_Implicit(System.Int32)
    IL_003B: call System.Void Z0.BitMatrix16::set_Item(System.Int32,System.Int32,Z0.Bit)
    IL_0040: ldloc.3
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.3
    IL_0044: ldloc.3
    IL_0045: ldarga.s rhs
    IL_0047: call System.Int32 Z0.BitMatrix16::get_ColCount()
    IL_004C: blt.s IL_0020
    IL_004E: ldloc.1
    IL_004F: ldc.i4.1
    IL_0050: add
    IL_0051: stloc.1
    IL_0052: ldloc.1
    IL_0053: ldarga.s lhs
    IL_0055: call System.Int32 Z0.BitMatrix16::get_RowCount()
    IL_005A: blt.s IL_0013
    IL_005C: ldloc.0
    IL_005D: ret

}
BitMatrix32 MatMul(BitMatrix32 lhs, BitMatrix32 rhs)
{
    IL_0000: call Z0.BitMatrix32 Z0.BitMatrix32::Alloc()
    IL_0005: stloc.0
    IL_0006: ldarga.s rhs
    IL_0008: call Z0.BitMatrix32 Z0.BitMatrix32::Transpose()
    IL_000D: starg.s rhs
    IL_000F: ldc.i4.0
    IL_0010: stloc.1
    IL_0011: br.s IL_0052
    IL_0013: ldarga.s lhs
    IL_0015: ldloc.1
    IL_0016: call Z0.BitVector32 Z0.BitMatrix32::RowVec(System.Int32)
    IL_001B: stloc.2
    IL_001C: ldc.i4.0
    IL_001D: stloc.3
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s rhs
    IL_0022: ldloc.3
    IL_0023: call Z0.BitVector32 Z0.BitMatrix32::RowVec(System.Int32)
    IL_0028: stloc.s V_4
    IL_002A: ldloca.s V_0
    IL_002C: ldloc.1
    IL_002D: ldloc.3
    IL_002E: ldloc.2
    IL_002F: ldloc.s V_4
    IL_0031: call System.Int32 Z0.BitRef::ModProd(Z0.BitVector32,Z0.BitVector32)
    IL_0036: call Z0.Bit Z0.Bit::op_Implicit(System.Int32)
    IL_003B: call System.Void Z0.BitMatrix32::set_Item(System.Int32,System.Int32,Z0.Bit)
    IL_0040: ldloc.3
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.3
    IL_0044: ldloc.3
    IL_0045: ldarga.s rhs
    IL_0047: call System.Int32 Z0.BitMatrix32::get_ColCount()
    IL_004C: blt.s IL_0020
    IL_004E: ldloc.1
    IL_004F: ldc.i4.1
    IL_0050: add
    IL_0051: stloc.1
    IL_0052: ldloc.1
    IL_0053: ldarga.s lhs
    IL_0055: call System.Int32 Z0.BitMatrix32::get_RowCount()
    IL_005A: blt.s IL_0013
    IL_005C: ldloc.0
    IL_005D: ret

}
BitMatrix64 MatMul(BitMatrix64 lhs, BitMatrix64 rhs)
{
    IL_0000: call Z0.BitMatrix64 Z0.BitMatrix64::Alloc()
    IL_0005: stloc.0
    IL_0006: ldarga.s rhs
    IL_0008: call Z0.BitMatrix64 Z0.BitMatrix64::Transpose()
    IL_000D: starg.s rhs
    IL_000F: ldc.i4.0
    IL_0010: stloc.1
    IL_0011: br.s IL_0052
    IL_0013: ldarga.s lhs
    IL_0015: ldloc.1
    IL_0016: call Z0.BitVector64 Z0.BitMatrix64::RowVector(System.Int32)
    IL_001B: stloc.2
    IL_001C: ldc.i4.0
    IL_001D: stloc.3
    IL_001E: br.s IL_0044
    IL_0020: ldarga.s rhs
    IL_0022: ldloc.3
    IL_0023: call Z0.BitVector64 Z0.BitMatrix64::RowVector(System.Int32)
    IL_0028: stloc.s V_4
    IL_002A: ldloca.s V_0
    IL_002C: ldloc.1
    IL_002D: ldloc.3
    IL_002E: ldloc.2
    IL_002F: ldloc.s V_4
    IL_0031: call System.Int32 Z0.BitRef::ModProd(Z0.BitVector64,Z0.BitVector64)
    IL_0036: call Z0.Bit Z0.Bit::op_Implicit(System.Int32)
    IL_003B: call System.Void Z0.BitMatrix64::set_Item(System.Int32,System.Int32,Z0.Bit)
    IL_0040: ldloc.3
    IL_0041: ldc.i4.1
    IL_0042: add
    IL_0043: stloc.3
    IL_0044: ldloc.3
    IL_0045: ldarga.s rhs
    IL_0047: call System.Int32 Z0.BitMatrix64::get_ColCount()
    IL_004C: blt.s IL_0020
    IL_004E: ldloc.1
    IL_004F: ldc.i4.1
    IL_0050: add
    IL_0051: stloc.1
    IL_0052: ldloc.1
    IL_0053: ldarga.s lhs
    IL_0055: call System.Int32 Z0.BitMatrix64::get_RowCount()
    IL_005A: blt.s IL_0013
    IL_005C: ldloc.0
    IL_005D: ret

}
int ModProd(BitVector4 lhs, BitVector4 rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0004: br.s IL_0042
    IL_0006: ldarga.s lhs
    IL_0008: ldloc.1
    IL_0009: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_000E: call Z0.Bit Z0.BitVector4::get_Item(Z0.BitPos)
    IL_0013: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0018: brtrue.s IL_001D
    IL_001A: ldc.i4.0
    IL_001B: br.s IL_001E
    IL_001D: ldc.i4.1
    IL_001E: stloc.2
    IL_001F: ldarga.s rhs
    IL_0021: ldloc.1
    IL_0022: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_0027: call Z0.Bit Z0.BitVector4::get_Item(Z0.BitPos)
    IL_002C: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0031: brtrue.s IL_0036
    IL_0033: ldc.i4.0
    IL_0034: br.s IL_0037
    IL_0036: ldc.i4.1
    IL_0037: stloc.3
    IL_0038: ldloc.0
    IL_0039: ldloc.2
    IL_003A: ldloc.3
    IL_003B: mul
    IL_003C: add
    IL_003D: stloc.0
    IL_003E: ldloc.1
    IL_003F: ldc.i4.1
    IL_0040: add
    IL_0041: stloc.1
    IL_0042: ldloc.1
    IL_0043: ldarga.s lhs
    IL_0045: call Z0.BitSize Z0.BitVector4::get_Length()
    IL_004A: call System.Int32 Z0.BitSize::op_Implicit(Z0.BitSize)
    IL_004F: blt.s IL_0006
    IL_0051: ldloc.0
    IL_0052: ldc.i4.2
    IL_0053: rem
    IL_0054: ret

}
int ModProd(BitVector8 lhs, BitVector8 rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0004: br.s IL_0042
    IL_0006: ldarga.s lhs
    IL_0008: ldloc.1
    IL_0009: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_000E: call Z0.Bit Z0.BitVector8::get_Item(Z0.BitPos)
    IL_0013: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0018: brtrue.s IL_001D
    IL_001A: ldc.i4.0
    IL_001B: br.s IL_001E
    IL_001D: ldc.i4.1
    IL_001E: stloc.2
    IL_001F: ldarga.s rhs
    IL_0021: ldloc.1
    IL_0022: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_0027: call Z0.Bit Z0.BitVector8::get_Item(Z0.BitPos)
    IL_002C: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0031: brtrue.s IL_0036
    IL_0033: ldc.i4.0
    IL_0034: br.s IL_0037
    IL_0036: ldc.i4.1
    IL_0037: stloc.3
    IL_0038: ldloc.0
    IL_0039: ldloc.2
    IL_003A: ldloc.3
    IL_003B: mul
    IL_003C: add
    IL_003D: stloc.0
    IL_003E: ldloc.1
    IL_003F: ldc.i4.1
    IL_0040: add
    IL_0041: stloc.1
    IL_0042: ldloc.1
    IL_0043: ldarga.s lhs
    IL_0045: call Z0.BitSize Z0.BitVector8::get_Length()
    IL_004A: call System.Int32 Z0.BitSize::op_Implicit(Z0.BitSize)
    IL_004F: blt.s IL_0006
    IL_0051: ldloc.0
    IL_0052: ldc.i4.2
    IL_0053: rem
    IL_0054: ret

}
int ModProd(BitVector16 lhs, BitVector16 rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0004: br.s IL_0042
    IL_0006: ldarga.s lhs
    IL_0008: ldloc.1
    IL_0009: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_000E: call Z0.Bit Z0.BitVector16::get_Item(Z0.BitPos)
    IL_0013: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0018: brtrue.s IL_001D
    IL_001A: ldc.i4.0
    IL_001B: br.s IL_001E
    IL_001D: ldc.i4.1
    IL_001E: stloc.2
    IL_001F: ldarga.s rhs
    IL_0021: ldloc.1
    IL_0022: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_0027: call Z0.Bit Z0.BitVector16::get_Item(Z0.BitPos)
    IL_002C: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0031: brtrue.s IL_0036
    IL_0033: ldc.i4.0
    IL_0034: br.s IL_0037
    IL_0036: ldc.i4.1
    IL_0037: stloc.3
    IL_0038: ldloc.0
    IL_0039: ldloc.2
    IL_003A: ldloc.3
    IL_003B: mul
    IL_003C: add
    IL_003D: stloc.0
    IL_003E: ldloc.1
    IL_003F: ldc.i4.1
    IL_0040: add
    IL_0041: stloc.1
    IL_0042: ldloc.1
    IL_0043: ldarga.s lhs
    IL_0045: call Z0.BitSize Z0.BitVector16::get_Length()
    IL_004A: call System.Int32 Z0.BitSize::op_Implicit(Z0.BitSize)
    IL_004F: blt.s IL_0006
    IL_0051: ldloc.0
    IL_0052: ldc.i4.2
    IL_0053: rem
    IL_0054: ret

}
int ModProd(BitVector32 lhs, BitVector32 rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0004: br.s IL_0042
    IL_0006: ldarga.s lhs
    IL_0008: ldloc.1
    IL_0009: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_000E: call Z0.Bit Z0.BitVector32::get_Item(Z0.BitPos)
    IL_0013: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0018: brtrue.s IL_001D
    IL_001A: ldc.i4.0
    IL_001B: br.s IL_001E
    IL_001D: ldc.i4.1
    IL_001E: stloc.2
    IL_001F: ldarga.s rhs
    IL_0021: ldloc.1
    IL_0022: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_0027: call Z0.Bit Z0.BitVector32::get_Item(Z0.BitPos)
    IL_002C: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0031: brtrue.s IL_0036
    IL_0033: ldc.i4.0
    IL_0034: br.s IL_0037
    IL_0036: ldc.i4.1
    IL_0037: stloc.3
    IL_0038: ldloc.0
    IL_0039: ldloc.2
    IL_003A: ldloc.3
    IL_003B: mul
    IL_003C: add
    IL_003D: stloc.0
    IL_003E: ldloc.1
    IL_003F: ldc.i4.1
    IL_0040: add
    IL_0041: stloc.1
    IL_0042: ldloc.1
    IL_0043: ldarga.s lhs
    IL_0045: call Z0.BitSize Z0.BitVector32::get_Length()
    IL_004A: call System.Int32 Z0.BitSize::op_Implicit(Z0.BitSize)
    IL_004F: blt.s IL_0006
    IL_0051: ldloc.0
    IL_0052: ldc.i4.2
    IL_0053: rem
    IL_0054: ret

}
int ModProd(BitVector64 lhs, BitVector64 rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0004: br.s IL_0042
    IL_0006: ldarga.s lhs
    IL_0008: ldloc.1
    IL_0009: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_000E: call Z0.Bit Z0.BitVector64::get_Item(Z0.BitPos)
    IL_0013: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0018: brtrue.s IL_001D
    IL_001A: ldc.i4.0
    IL_001B: br.s IL_001E
    IL_001D: ldc.i4.1
    IL_001E: stloc.2
    IL_001F: ldarga.s rhs
    IL_0021: ldloc.1
    IL_0022: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_0027: call Z0.Bit Z0.BitVector64::get_Item(Z0.BitPos)
    IL_002C: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0031: brtrue.s IL_0036
    IL_0033: ldc.i4.0
    IL_0034: br.s IL_0037
    IL_0036: ldc.i4.1
    IL_0037: stloc.3
    IL_0038: ldloc.0
    IL_0039: ldloc.2
    IL_003A: ldloc.3
    IL_003B: mul
    IL_003C: add
    IL_003D: stloc.0
    IL_003E: ldloc.1
    IL_003F: ldc.i4.1
    IL_0040: add
    IL_0041: stloc.1
    IL_0042: ldloc.1
    IL_0043: ldarga.s lhs
    IL_0045: call Z0.BitSize Z0.BitVector64::get_Length()
    IL_004A: call System.Int32 Z0.BitSize::op_Implicit(Z0.BitSize)
    IL_004F: blt.s IL_0006
    IL_0051: ldloc.0
    IL_0052: ldc.i4.2
    IL_0053: rem
    IL_0054: ret

}
Span<sbyte> ShiftL(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<int> rhs, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "ShiftL"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\ShiftL.cs"
    IL_000C: ldc.i4 138
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.SByte,System.Int32>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
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
    IL_0034: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0039: ldind.i4
    IL_003A: call System.SByte Z0.BitRef::shiftl(System.SByte,System.Int32)
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
Span<byte> ShiftL(ReadOnlySpan<byte> lhs, ReadOnlySpan<int> rhs, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "ShiftL"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\ShiftL.cs"
    IL_000C: ldc.i4 146
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Byte,System.Int32>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
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
    IL_0034: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0039: ldind.i4
    IL_003A: call System.Byte Z0.BitRef::shiftl(System.Byte,System.Int32)
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
Span<short> ShiftL(ReadOnlySpan<short> lhs, ReadOnlySpan<int> rhs, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "ShiftL"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\ShiftL.cs"
    IL_000C: ldc.i4 154
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int16,System.Int32>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
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
    IL_0034: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0039: ldind.i4
    IL_003A: call System.Int16 Z0.BitRef::shiftl(System.Int16,System.Int32)
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
Span<ushort> ShiftL(ReadOnlySpan<ushort> lhs, ReadOnlySpan<int> rhs, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "ShiftL"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\ShiftL.cs"
    IL_000C: ldc.i4 162
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt16,System.Int32>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
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
    IL_0034: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0039: ldind.i4
    IL_003A: call System.UInt16 Z0.BitRef::shiftl(System.UInt16,System.Int32)
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
Span<int> ShiftL(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "ShiftL"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\ShiftL.cs"
    IL_000C: ldc.i4 170
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
    IL_003A: call System.Int32 Z0.BitRef::shiftl(System.Int32,System.Int32)
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
Span<uint> ShiftL(ReadOnlySpan<uint> lhs, ReadOnlySpan<int> rhs, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "ShiftL"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\ShiftL.cs"
    IL_000C: ldc.i4 178
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt32,System.Int32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
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
    IL_0034: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0039: ldind.i4
    IL_003A: call System.UInt32 Z0.BitRef::shiftl(System.UInt32,System.Int32)
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
Span<long> ShiftL(ReadOnlySpan<long> lhs, ReadOnlySpan<int> rhs, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "ShiftL"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\ShiftL.cs"
    IL_000C: ldc.i4 186
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int64,System.Int32>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
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
    IL_0034: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0039: ldind.i4
    IL_003A: call System.Int64 Z0.BitRef::shiftl(System.Int64,System.Int32)
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
Span<ulong> ShiftL(ReadOnlySpan<ulong> lhs, ReadOnlySpan<int> rhs, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "ShiftL"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\ShiftL.cs"
    IL_000C: ldc.i4 194
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt64,System.Int32>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
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
    IL_0034: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0039: ldind.i4
    IL_003A: call System.UInt64 Z0.BitRef::shiftl(System.UInt64,System.Int32)
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
Span<sbyte> ShiftL(ReadOnlySpan<sbyte> lhs, int rhs, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: ldstr "ShiftL"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\ShiftL.cs"
    IL_000C: ldc.i4 202
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.Span`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003C
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0030: ldind.i1
    IL_0031: ldarg.1
    IL_0032: call System.SByte Z0.BitRef::shiftl(System.SByte,System.Int32)
    IL_0037: stind.i1
    IL_0038: ldloc.1
    IL_0039: ldc.i4.1
    IL_003A: add
    IL_003B: stloc.1
    IL_003C: ldloc.1
    IL_003D: ldloc.0
    IL_003E: blt.s IL_0020
    IL_0040: ldarg.2
    IL_0041: ret

}
Span<byte> ShiftL(ReadOnlySpan<byte> lhs, int rhs, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: ldstr "ShiftL"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\ShiftL.cs"
    IL_000C: ldc.i4 210
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003C
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0030: ldind.u1
    IL_0031: ldarg.1
    IL_0032: call System.Byte Z0.BitRef::shiftl(System.Byte,System.Int32)
    IL_0037: stind.i1
    IL_0038: ldloc.1
    IL_0039: ldc.i4.1
    IL_003A: add
    IL_003B: stloc.1
    IL_003C: ldloc.1
    IL_003D: ldloc.0
    IL_003E: blt.s IL_0020
    IL_0040: ldarg.2
    IL_0041: ret

}
Span<short> ShiftL(ReadOnlySpan<short> lhs, int rhs, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: ldstr "ShiftL"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\ShiftL.cs"
    IL_000C: ldc.i4 218
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.Span`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003C
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0030: ldind.i2
    IL_0031: ldarg.1
    IL_0032: call System.Int16 Z0.BitRef::shiftl(System.Int16,System.Int32)
    IL_0037: stind.i2
    IL_0038: ldloc.1
    IL_0039: ldc.i4.1
    IL_003A: add
    IL_003B: stloc.1
    IL_003C: ldloc.1
    IL_003D: ldloc.0
    IL_003E: blt.s IL_0020
    IL_0040: ldarg.2
    IL_0041: ret

}
Span<ushort> ShiftL(ReadOnlySpan<ushort> lhs, int rhs, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: ldstr "ShiftL"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\ShiftL.cs"
    IL_000C: ldc.i4 226
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.Span`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003C
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0030: ldind.u2
    IL_0031: ldarg.1
    IL_0032: call System.UInt16 Z0.BitRef::shiftl(System.UInt16,System.Int32)
    IL_0037: stind.i2
    IL_0038: ldloc.1
    IL_0039: ldc.i4.1
    IL_003A: add
    IL_003B: stloc.1
    IL_003C: ldloc.1
    IL_003D: ldloc.0
    IL_003E: blt.s IL_0020
    IL_0040: ldarg.2
    IL_0041: ret

}
Span<int> ShiftL(ReadOnlySpan<int> lhs, int rhs, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: ldstr "ShiftL"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\ShiftL.cs"
    IL_000C: ldc.i4 234
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.Span`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003C
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0030: ldind.i4
    IL_0031: ldarg.1
    IL_0032: call System.Int32 Z0.BitRef::shiftl(System.Int32,System.Int32)
    IL_0037: stind.i4
    IL_0038: ldloc.1
    IL_0039: ldc.i4.1
    IL_003A: add
    IL_003B: stloc.1
    IL_003C: ldloc.1
    IL_003D: ldloc.0
    IL_003E: blt.s IL_0020
    IL_0040: ldarg.2
    IL_0041: ret

}
Span<uint> ShiftL(ReadOnlySpan<uint> lhs, int rhs, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: ldstr "ShiftL"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\ShiftL.cs"
    IL_000C: ldc.i4 242
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003C
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0030: ldind.u4
    IL_0031: ldarg.1
    IL_0032: call System.UInt32 Z0.BitRef::shiftl(System.UInt32,System.Int32)
    IL_0037: stind.i4
    IL_0038: ldloc.1
    IL_0039: ldc.i4.1
    IL_003A: add
    IL_003B: stloc.1
    IL_003C: ldloc.1
    IL_003D: ldloc.0
    IL_003E: blt.s IL_0020
    IL_0040: ldarg.2
    IL_0041: ret

}
Span<long> ShiftL(ReadOnlySpan<long> lhs, int rhs, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: ldstr "ShiftL"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\ShiftL.cs"
    IL_000C: ldc.i4 250
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.Span`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003C
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: ldarg.1
    IL_0032: call System.Int64 Z0.BitRef::shiftl(System.Int64,System.Int32)
    IL_0037: stind.i8
    IL_0038: ldloc.1
    IL_0039: ldc.i4.1
    IL_003A: add
    IL_003B: stloc.1
    IL_003C: ldloc.1
    IL_003D: ldloc.0
    IL_003E: blt.s IL_0020
    IL_0040: ldarg.2
    IL_0041: ret

}
Span<ulong> ShiftL(ReadOnlySpan<ulong> lhs, int rhs, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: ldstr "ShiftL"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops.ref\\ShiftL.cs"
    IL_000C: ldc.i4 258
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: stloc.0
    IL_001C: ldc.i4.0
    IL_001D: stloc.1
    IL_001E: br.s IL_003C
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0028: ldarga.s lhs
    IL_002A: ldloc.1
    IL_002B: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0030: ldind.i8
    IL_0031: ldarg.1
    IL_0032: call System.UInt64 Z0.BitRef::shiftl(System.UInt64,System.Int32)
    IL_0037: stind.i8
    IL_0038: ldloc.1
    IL_0039: ldc.i4.1
    IL_003A: add
    IL_003B: stloc.1
    IL_003C: ldloc.1
    IL_003D: ldloc.0
    IL_003E: blt.s IL_0020
    IL_0040: ldarg.2
    IL_0041: ret

}
sbyte shiftl(sbyte lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: conv.i1
    IL_0007: ret

}
byte shiftl(byte lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: conv.u1
    IL_0007: ret

}
short shiftl(short lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: conv.i2
    IL_0007: ret

}
ushort shiftl(ushort lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: conv.u2
    IL_0007: ret

}
int shiftl(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: ret

}
uint shiftl(uint lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: ret

}
long shiftl(long lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 63
    IL_0004: and
    IL_0005: shl
    IL_0006: ret

}
ulong shiftl(ulong lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 63
    IL_0004: and
    IL_0005: shl
    IL_0006: ret

}

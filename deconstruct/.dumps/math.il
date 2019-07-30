// 2019-07-29 18:32:31:264
Span<sbyte> xor(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\XOr.cs"
    IL_000C: ldc.i4.s 21
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
    IL_0037: call System.SByte Z0.math::xor(System.SByte,System.SByte)
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
Span<byte> xor(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\XOr.cs"
    IL_000C: ldc.i4.s 29
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
    IL_0037: call System.Byte Z0.math::xor(System.Byte,System.Byte)
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
Span<short> xor(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\XOr.cs"
    IL_000C: ldc.i4.s 37
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
    IL_0037: call System.Int16 Z0.math::xor(System.Int16,System.Int16)
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
Span<ushort> xor(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\XOr.cs"
    IL_000C: ldc.i4.s 45
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
    IL_0037: call System.UInt16 Z0.math::xor(System.UInt16,System.UInt16)
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
Span<int> xor(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\XOr.cs"
    IL_000C: ldc.i4.s 53
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
    IL_0037: call System.Int32 Z0.math::xor(System.Int32,System.Int32)
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
Span<uint> xor(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\XOr.cs"
    IL_000C: ldc.i4.s 61
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
    IL_0037: call System.UInt32 Z0.math::xor(System.UInt32,System.UInt32)
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
Span<long> xor(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\XOr.cs"
    IL_000C: ldc.i4.s 69
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
    IL_0037: call System.Int64 Z0.math::xor(System.Int64,System.Int64)
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
Span<ulong> xor(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\XOr.cs"
    IL_000C: ldc.i4.s 77
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
    IL_0037: call System.UInt64 Z0.math::xor(System.UInt64,System.UInt64)
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
Span<sbyte> xor(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\XOr.cs"
    IL_000C: ldc.i4.s 85
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
    IL_0030: xor
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
Span<byte> xor(Span<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\XOr.cs"
    IL_000C: ldc.i4.s 93
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
    IL_0030: xor
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
Span<short> xor(Span<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\XOr.cs"
    IL_000C: ldc.i4.s 101
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
    IL_0030: xor
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
Span<ushort> xor(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\XOr.cs"
    IL_000C: ldc.i4.s 109
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
    IL_0030: xor
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
Span<int> xor(Span<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\XOr.cs"
    IL_000C: ldc.i4.s 117
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int32>(System.Span`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0036
    IL_001D: ldarga.s lhs
    IL_001F: ldloc.1
    IL_0020: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0025: dup
    IL_0026: ldind.i4
    IL_0027: ldarga.s rhs
    IL_0029: ldloc.1
    IL_002A: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_002F: ldind.i4
    IL_0030: xor
    IL_0031: stind.i4
    IL_0032: ldloc.1
    IL_0033: ldc.i4.1
    IL_0034: add
    IL_0035: stloc.1
    IL_0036: ldloc.1
    IL_0037: ldloc.0
    IL_0038: blt.s IL_001D
    IL_003A: ldarg.0
    IL_003B: ret

}
Span<uint> xor(Span<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\XOr.cs"
    IL_000C: ldc.i4.s 125
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt32>(System.Span`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0036
    IL_001D: ldarga.s lhs
    IL_001F: ldloc.1
    IL_0020: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0025: dup
    IL_0026: ldind.u4
    IL_0027: ldarga.s rhs
    IL_0029: ldloc.1
    IL_002A: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_002F: ldind.u4
    IL_0030: xor
    IL_0031: stind.i4
    IL_0032: ldloc.1
    IL_0033: ldc.i4.1
    IL_0034: add
    IL_0035: stloc.1
    IL_0036: ldloc.1
    IL_0037: ldloc.0
    IL_0038: blt.s IL_001D
    IL_003A: ldarg.0
    IL_003B: ret

}
Span<long> xor(Span<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "xor"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\XOr.cs"
    IL_000C: ldc.i4 133
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\XOr.cs"
    IL_000C: ldc.i4 141
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
Span<float> mod(Span<float> lhs, float rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.r4
    IL_000E: ldarg.1
    IL_000F: rem
    IL_0010: stind.r4
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
Span<double> mod(Span<double> lhs, double rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.r8
    IL_000E: ldarg.1
    IL_000F: rem
    IL_0010: stind.r8
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
void negate(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "negate"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Negate.cs"
    IL_000C: ldc.i4.s 20
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
    IL_002E: call System.SByte Z0.math::negate(System.SByte)
    IL_0033: stind.i1
    IL_0034: ldloc.1
    IL_0035: ldc.i4.1
    IL_0036: add
    IL_0037: stloc.1
    IL_0038: ldloc.1
    IL_0039: ldloc.0
    IL_003A: blt.s IL_001D
    IL_003C: ret

}
void negate(ReadOnlySpan<byte> src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "negate"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Negate.cs"
    IL_000C: ldc.i4.s 27
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_002D: ldind.u1
    IL_002E: call System.Byte Z0.math::negate(System.Byte)
    IL_0033: stind.i1
    IL_0034: ldloc.1
    IL_0035: ldc.i4.1
    IL_0036: add
    IL_0037: stloc.1
    IL_0038: ldloc.1
    IL_0039: ldloc.0
    IL_003A: blt.s IL_001D
    IL_003C: ret

}
void negate(ReadOnlySpan<short> src, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "negate"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Negate.cs"
    IL_000C: ldc.i4.s 34
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
    IL_002E: call System.Int16 Z0.math::negate(System.Int16)
    IL_0033: stind.i2
    IL_0034: ldloc.1
    IL_0035: ldc.i4.1
    IL_0036: add
    IL_0037: stloc.1
    IL_0038: ldloc.1
    IL_0039: ldloc.0
    IL_003A: blt.s IL_001D
    IL_003C: ret

}
void negate(ReadOnlySpan<ushort> src, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "negate"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Negate.cs"
    IL_000C: ldc.i4.s 41
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.Span`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_002D: ldind.u2
    IL_002E: call System.UInt16 Z0.math::negate(System.UInt16)
    IL_0033: stind.i2
    IL_0034: ldloc.1
    IL_0035: ldc.i4.1
    IL_0036: add
    IL_0037: stloc.1
    IL_0038: ldloc.1
    IL_0039: ldloc.0
    IL_003A: blt.s IL_001D
    IL_003C: ret

}
void negate(ReadOnlySpan<int> src, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "negate"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Negate.cs"
    IL_000C: ldc.i4.s 48
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
    IL_002E: call System.Int32 Z0.math::negate(System.Int32)
    IL_0033: stind.i4
    IL_0034: ldloc.1
    IL_0035: ldc.i4.1
    IL_0036: add
    IL_0037: stloc.1
    IL_0038: ldloc.1
    IL_0039: ldloc.0
    IL_003A: blt.s IL_001D
    IL_003C: ret

}
void negate(ReadOnlySpan<uint> src, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "negate"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Negate.cs"
    IL_000C: ldc.i4.s 55
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_002D: ldind.u4
    IL_002E: call System.UInt32 Z0.math::negate(System.UInt32)
    IL_0033: stind.i4
    IL_0034: ldloc.1
    IL_0035: ldc.i4.1
    IL_0036: add
    IL_0037: stloc.1
    IL_0038: ldloc.1
    IL_0039: ldloc.0
    IL_003A: blt.s IL_001D
    IL_003C: ret

}
void negate(ReadOnlySpan<long> src, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "negate"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Negate.cs"
    IL_000C: ldc.i4.s 62
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.Span`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_002D: ldind.i8
    IL_002E: call System.Int64 Z0.math::negate(System.Int64)
    IL_0033: stind.i8
    IL_0034: ldloc.1
    IL_0035: ldc.i4.1
    IL_0036: add
    IL_0037: stloc.1
    IL_0038: ldloc.1
    IL_0039: ldloc.0
    IL_003A: blt.s IL_001D
    IL_003C: ret

}
void negate(ReadOnlySpan<ulong> src, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "negate"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Negate.cs"
    IL_000C: ldc.i4.s 69
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_002D: ldind.i8
    IL_002E: call System.UInt64 Z0.math::negate(System.UInt64)
    IL_0033: stind.i8
    IL_0034: ldloc.1
    IL_0035: ldc.i4.1
    IL_0036: add
    IL_0037: stloc.1
    IL_0038: ldloc.1
    IL_0039: ldloc.0
    IL_003A: blt.s IL_001D
    IL_003C: ret

}
void negate(ReadOnlySpan<float> src, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "negate"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Negate.cs"
    IL_000C: ldc.i4.s 76
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Single,System.Single>(System.ReadOnlySpan`1<System.Single>,System.Span`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_002D: ldind.r4
    IL_002E: call System.Single Z0.math::negate(System.Single)
    IL_0033: stind.r4
    IL_0034: ldloc.1
    IL_0035: ldc.i4.1
    IL_0036: add
    IL_0037: stloc.1
    IL_0038: ldloc.1
    IL_0039: ldloc.0
    IL_003A: blt.s IL_001D
    IL_003C: ret

}
void negate(ReadOnlySpan<double> src, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "negate"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Negate.cs"
    IL_000C: ldc.i4.s 83
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Double,System.Double>(System.ReadOnlySpan`1<System.Double>,System.Span`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_002D: ldind.r8
    IL_002E: call System.Double Z0.math::negate(System.Double)
    IL_0033: stind.r8
    IL_0034: ldloc.1
    IL_0035: ldc.i4.1
    IL_0036: add
    IL_0037: stloc.1
    IL_0038: ldloc.1
    IL_0039: ldloc.0
    IL_003A: blt.s IL_001D
    IL_003C: ret

}
Span<sbyte> negate(Span<sbyte> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_000C: call System.SByte& Z0.math::negate(System.SByte&)
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
Span<byte> negate(Span<byte> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_000C: call System.Byte& Z0.math::negate(System.Byte&)
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
Span<short> negate(Span<short> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_000C: call System.Int16& Z0.math::negate(System.Int16&)
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
Span<ushort> negate(Span<ushort> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_000C: call System.UInt16& Z0.math::negate(System.UInt16&)
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
Span<int> negate(Span<int> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_000C: call System.Int32& Z0.math::negate(System.Int32&)
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
Span<uint> negate(Span<uint> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_000C: call System.UInt32& Z0.math::negate(System.UInt32&)
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
Span<long> negate(Span<long> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_000C: call System.Int64& Z0.math::negate(System.Int64&)
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
Span<ulong> negate(Span<ulong> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_000C: call System.UInt64& Z0.math::negate(System.UInt64&)
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
Span<float> negate(Span<float> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_000C: call System.Single& Z0.math::negate(System.Single&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s io
    IL_0019: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<double> negate(Span<double> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_000C: call System.Double& Z0.math::negate(System.Double&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s io
    IL_0019: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\NEq.cs"
    IL_000E: ldc.i4.s 100
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::neq(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> neq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "neq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\NEq.cs"
    IL_000E: ldc.i4.s 104
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::neq(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> neq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "neq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\NEq.cs"
    IL_000E: ldc.i4.s 108
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::neq(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> neq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "neq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\NEq.cs"
    IL_000E: ldc.i4.s 112
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::neq(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> neq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "neq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\NEq.cs"
    IL_000E: ldc.i4.s 116
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::neq(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> neq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "neq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\NEq.cs"
    IL_000E: ldc.i4.s 120
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::neq(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> neq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "neq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\NEq.cs"
    IL_000E: ldc.i4.s 124
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::neq(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> neq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "neq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\NEq.cs"
    IL_000E: ldc.i4 128
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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\NEq.cs"
    IL_000E: ldc.i4 132
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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\NEq.cs"
    IL_000E: ldc.i4 136
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Double,System.Double>(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::neq(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<sbyte> or(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "or"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Or.cs"
    IL_000C: ldc.i4.s 22
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
    IL_0037: call System.SByte Z0.math::or(System.SByte,System.SByte)
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
Span<byte> or(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "or"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Or.cs"
    IL_000C: ldc.i4.s 30
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
    IL_0037: call System.Byte Z0.math::or(System.Byte,System.Byte)
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
Span<short> or(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "or"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Or.cs"
    IL_000C: ldc.i4.s 38
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
    IL_0037: call System.Int16 Z0.math::or(System.Int16,System.Int16)
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
Span<ushort> or(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "or"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Or.cs"
    IL_000C: ldc.i4.s 46
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
    IL_0037: call System.UInt16 Z0.math::or(System.UInt16,System.UInt16)
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
Span<int> or(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "or"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Or.cs"
    IL_000C: ldc.i4.s 54
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
    IL_0037: call System.Int32 Z0.math::or(System.Int32,System.Int32)
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
Span<uint> or(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "or"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Or.cs"
    IL_000C: ldc.i4.s 62
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
    IL_0037: call System.UInt32 Z0.math::or(System.UInt32,System.UInt32)
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
Span<long> or(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "or"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Or.cs"
    IL_000C: ldc.i4.s 70
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
    IL_0037: call System.Int64 Z0.math::or(System.Int64,System.Int64)
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
Span<ulong> or(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "or"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Or.cs"
    IL_000C: ldc.i4.s 78
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
    IL_0037: call System.UInt64 Z0.math::or(System.UInt64,System.UInt64)
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
Span<sbyte> or(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "or"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Or.cs"
    IL_000C: ldc.i4.s 86
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
    IL_0030: or
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
Span<byte> or(Span<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "or"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Or.cs"
    IL_000C: ldc.i4.s 94
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
    IL_0030: or
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
Span<short> or(Span<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "or"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Or.cs"
    IL_000C: ldc.i4.s 102
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
    IL_0030: or
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
Span<ushort> or(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "or"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Or.cs"
    IL_000C: ldc.i4.s 110
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
    IL_0030: or
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
Span<int> or(Span<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "or"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Or.cs"
    IL_000C: ldc.i4.s 118
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int32>(System.Span`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0036
    IL_001D: ldarga.s lhs
    IL_001F: ldloc.1
    IL_0020: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0025: dup
    IL_0026: ldind.i4
    IL_0027: ldarga.s rhs
    IL_0029: ldloc.1
    IL_002A: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_002F: ldind.i4
    IL_0030: or
    IL_0031: stind.i4
    IL_0032: ldloc.1
    IL_0033: ldc.i4.1
    IL_0034: add
    IL_0035: stloc.1
    IL_0036: ldloc.1
    IL_0037: ldloc.0
    IL_0038: blt.s IL_001D
    IL_003A: ldarg.0
    IL_003B: ret

}
Span<uint> or(Span<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "or"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Or.cs"
    IL_000C: ldc.i4.s 126
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt32>(System.Span`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0036
    IL_001D: ldarga.s lhs
    IL_001F: ldloc.1
    IL_0020: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0025: dup
    IL_0026: ldind.u4
    IL_0027: ldarga.s rhs
    IL_0029: ldloc.1
    IL_002A: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_002F: ldind.u4
    IL_0030: or
    IL_0031: stind.i4
    IL_0032: ldloc.1
    IL_0033: ldc.i4.1
    IL_0034: add
    IL_0035: stloc.1
    IL_0036: ldloc.1
    IL_0037: ldloc.0
    IL_0038: blt.s IL_001D
    IL_003A: ldarg.0
    IL_003B: ret

}
Span<long> or(Span<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "or"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Or.cs"
    IL_000C: ldc.i4 134
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
    IL_0033: or
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
Span<ulong> or(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "or"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Or.cs"
    IL_000C: ldc.i4 142
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
    IL_0033: or
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
Span<sbyte> or(Span<sbyte> lhs, sbyte rhs)
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
    IL_000F: or
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
Span<byte> or(Span<byte> lhs, byte rhs)
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
    IL_000F: or
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
Span<short> or(Span<short> lhs, short rhs)
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
    IL_000F: or
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
Span<ushort> or(Span<ushort> lhs, ushort rhs)
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
    IL_000F: or
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
Span<int> or(Span<int> lhs, int rhs)
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
    IL_000F: or
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
Span<uint> or(Span<uint> lhs, uint rhs)
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
    IL_000F: or
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
Span<long> or(Span<long> lhs, long rhs)
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
    IL_000F: or
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
Span<ulong> or(Span<ulong> lhs, ulong rhs)
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
    IL_000F: or
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
Span<sbyte> pow(Span<sbyte> b, ReadOnlySpan<sbyte> exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "pow"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Pow.cs"
    IL_000C: ldc.i4.s 21
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.SByte>(System.Span`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s b
    IL_001F: ldloc.1
    IL_0020: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0025: ldarga.s b
    IL_0027: ldloc.1
    IL_0028: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_002D: ldind.i1
    IL_002E: ldarga.s exp
    IL_0030: ldloc.1
    IL_0031: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0036: ldind.i1
    IL_0037: call System.SByte Z0.math::pow(System.SByte,System.SByte)
    IL_003C: stind.i1
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.0
    IL_0046: ret

}
Span<byte> pow(Span<byte> b, ReadOnlySpan<byte> exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "pow"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Pow.cs"
    IL_000C: ldc.i4.s 29
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Byte>(System.Span`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s b
    IL_001F: ldloc.1
    IL_0020: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0025: ldarga.s b
    IL_0027: ldloc.1
    IL_0028: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_002D: ldind.u1
    IL_002E: ldarga.s exp
    IL_0030: ldloc.1
    IL_0031: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0036: ldind.u1
    IL_0037: call System.Byte Z0.math::pow(System.Byte,System.Byte)
    IL_003C: stind.i1
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.0
    IL_0046: ret

}
Span<short> pow(Span<short> b, ReadOnlySpan<short> exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "pow"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Pow.cs"
    IL_000C: ldc.i4.s 37
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int16>(System.Span`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s b
    IL_001F: ldloc.1
    IL_0020: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0025: ldarga.s b
    IL_0027: ldloc.1
    IL_0028: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_002D: ldind.i2
    IL_002E: ldarga.s exp
    IL_0030: ldloc.1
    IL_0031: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0036: ldind.i2
    IL_0037: call System.Int16 Z0.math::pow(System.Int16,System.Int16)
    IL_003C: stind.i2
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.0
    IL_0046: ret

}
Span<ushort> pow(Span<ushort> b, ReadOnlySpan<ushort> exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "pow"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Pow.cs"
    IL_000C: ldc.i4.s 45
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt16>(System.Span`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s b
    IL_001F: ldloc.1
    IL_0020: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0025: ldarga.s b
    IL_0027: ldloc.1
    IL_0028: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_002D: ldind.u2
    IL_002E: ldarga.s exp
    IL_0030: ldloc.1
    IL_0031: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0036: ldind.u2
    IL_0037: call System.UInt16 Z0.math::pow(System.UInt16,System.UInt16)
    IL_003C: stind.i2
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.0
    IL_0046: ret

}
Span<int> pow(Span<int> b, ReadOnlySpan<int> exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "pow"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Pow.cs"
    IL_000C: ldc.i4.s 53
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int32>(System.Span`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s b
    IL_001F: ldloc.1
    IL_0020: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0025: ldarga.s b
    IL_0027: ldloc.1
    IL_0028: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_002D: ldind.i4
    IL_002E: ldarga.s exp
    IL_0030: ldloc.1
    IL_0031: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0036: ldind.i4
    IL_0037: call System.Int32 Z0.math::pow(System.Int32,System.Int32)
    IL_003C: stind.i4
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.0
    IL_0046: ret

}
Span<uint> pow(Span<uint> b, ReadOnlySpan<uint> exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "pow"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Pow.cs"
    IL_000C: ldc.i4.s 61
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt32>(System.Span`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s b
    IL_001F: ldloc.1
    IL_0020: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0025: ldarga.s b
    IL_0027: ldloc.1
    IL_0028: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_002D: ldind.u4
    IL_002E: ldarga.s exp
    IL_0030: ldloc.1
    IL_0031: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0036: ldind.u4
    IL_0037: call System.UInt32 Z0.math::pow(System.UInt32,System.UInt32)
    IL_003C: stind.i4
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.0
    IL_0046: ret

}
Span<long> pow(Span<long> b, ReadOnlySpan<long> exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "pow"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Pow.cs"
    IL_000C: ldc.i4.s 69
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int64>(System.Span`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s b
    IL_001F: ldloc.1
    IL_0020: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0025: ldarga.s b
    IL_0027: ldloc.1
    IL_0028: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_002D: ldind.i8
    IL_002E: ldarga.s exp
    IL_0030: ldloc.1
    IL_0031: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0036: ldind.i8
    IL_0037: call System.Int64 Z0.math::pow(System.Int64,System.Int64)
    IL_003C: stind.i8
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.0
    IL_0046: ret

}
Span<ulong> pow(Span<ulong> b, ReadOnlySpan<ulong> exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "pow"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Pow.cs"
    IL_000C: ldc.i4.s 77
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt64>(System.Span`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s b
    IL_001F: ldloc.1
    IL_0020: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0025: ldarga.s b
    IL_0027: ldloc.1
    IL_0028: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_002D: ldind.i8
    IL_002E: ldarga.s exp
    IL_0030: ldloc.1
    IL_0031: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0036: ldind.i8
    IL_0037: call System.UInt64 Z0.math::pow(System.UInt64,System.UInt64)
    IL_003C: stind.i8
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.0
    IL_0046: ret

}
Span<float> pow(Span<float> b, ReadOnlySpan<float> exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "pow"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Pow.cs"
    IL_000C: ldc.i4.s 85
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Single>(System.Span`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s b
    IL_001F: ldloc.1
    IL_0020: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0025: ldarga.s b
    IL_0027: ldloc.1
    IL_0028: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_002D: ldind.r4
    IL_002E: ldarga.s exp
    IL_0030: ldloc.1
    IL_0031: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0036: ldind.r4
    IL_0037: call System.Single Z0.math::pow(System.Single,System.Single)
    IL_003C: stind.r4
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.0
    IL_0046: ret

}
Span<double> pow(Span<double> b, ReadOnlySpan<double> exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "pow"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Pow.cs"
    IL_000C: ldc.i4.s 93
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Double>(System.Span`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0041
    IL_001D: ldarga.s b
    IL_001F: ldloc.1
    IL_0020: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0025: ldarga.s b
    IL_0027: ldloc.1
    IL_0028: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_002D: ldind.r8
    IL_002E: ldarga.s exp
    IL_0030: ldloc.1
    IL_0031: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0036: ldind.r8
    IL_0037: call System.Double Z0.math::pow(System.Double,System.Double)
    IL_003C: stind.r8
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ldarg.0
    IL_0046: ret

}
Span<sbyte> pow(Span<sbyte> b, sbyte exp)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s b
    IL_0006: ldloc.0
    IL_0007: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_000C: ldarga.s b
    IL_000E: ldloc.0
    IL_000F: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_0014: ldind.i1
    IL_0015: ldarg.1
    IL_0016: call System.SByte Z0.math::pow(System.SByte,System.SByte)
    IL_001B: stind.i1
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s b
    IL_0023: call System.Int32 System.Span`1<System.SByte>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.0
    IL_002B: ret

}
Span<byte> pow(Span<byte> b, byte exp)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s b
    IL_0006: ldloc.0
    IL_0007: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_000C: ldarga.s b
    IL_000E: ldloc.0
    IL_000F: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0014: ldind.u1
    IL_0015: ldarg.1
    IL_0016: call System.Byte Z0.math::pow(System.Byte,System.Byte)
    IL_001B: stind.i1
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s b
    IL_0023: call System.Int32 System.Span`1<System.Byte>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.0
    IL_002B: ret

}
Span<short> pow(Span<short> b, short exp)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s b
    IL_0006: ldloc.0
    IL_0007: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_000C: ldarga.s b
    IL_000E: ldloc.0
    IL_000F: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0014: ldind.i2
    IL_0015: ldarg.1
    IL_0016: call System.Int16 Z0.math::pow(System.Int16,System.Int16)
    IL_001B: stind.i2
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s b
    IL_0023: call System.Int32 System.Span`1<System.Int16>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.0
    IL_002B: ret

}
Span<ushort> pow(Span<ushort> b, ushort exp)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s b
    IL_0006: ldloc.0
    IL_0007: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_000C: ldarga.s b
    IL_000E: ldloc.0
    IL_000F: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0014: ldind.u2
    IL_0015: ldarg.1
    IL_0016: call System.UInt16 Z0.math::pow(System.UInt16,System.UInt16)
    IL_001B: stind.i2
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s b
    IL_0023: call System.Int32 System.Span`1<System.UInt16>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.0
    IL_002B: ret

}
Span<int> pow(Span<int> b, int exp)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s b
    IL_0006: ldloc.0
    IL_0007: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_000C: ldarga.s b
    IL_000E: ldloc.0
    IL_000F: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0014: ldind.i4
    IL_0015: ldarg.1
    IL_0016: call System.Int32 Z0.math::pow(System.Int32,System.Int32)
    IL_001B: stind.i4
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s b
    IL_0023: call System.Int32 System.Span`1<System.Int32>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.0
    IL_002B: ret

}
Span<uint> pow(Span<uint> b, uint exp)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s b
    IL_0006: ldloc.0
    IL_0007: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_000C: ldarga.s b
    IL_000E: ldloc.0
    IL_000F: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0014: ldind.u4
    IL_0015: ldarg.1
    IL_0016: call System.UInt32 Z0.math::pow(System.UInt32,System.UInt32)
    IL_001B: stind.i4
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s b
    IL_0023: call System.Int32 System.Span`1<System.UInt32>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.0
    IL_002B: ret

}
Span<long> pow(Span<long> b, long exp)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s b
    IL_0006: ldloc.0
    IL_0007: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_000C: ldarga.s b
    IL_000E: ldloc.0
    IL_000F: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: ldarg.1
    IL_0016: call System.Int64 Z0.math::pow(System.Int64,System.Int64)
    IL_001B: stind.i8
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s b
    IL_0023: call System.Int32 System.Span`1<System.Int64>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.0
    IL_002B: ret

}
Span<ulong> pow(Span<ulong> b, ulong exp)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s b
    IL_0006: ldloc.0
    IL_0007: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_000C: ldarga.s b
    IL_000E: ldloc.0
    IL_000F: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0014: ldind.i8
    IL_0015: ldarg.1
    IL_0016: call System.UInt64 Z0.math::pow(System.UInt64,System.UInt64)
    IL_001B: stind.i8
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s b
    IL_0023: call System.Int32 System.Span`1<System.UInt64>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.0
    IL_002B: ret

}
Span<float> pow(Span<float> b, float exp)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s b
    IL_0006: ldloc.0
    IL_0007: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_000C: ldarga.s b
    IL_000E: ldloc.0
    IL_000F: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0014: ldind.r4
    IL_0015: ldarg.1
    IL_0016: call System.Single Z0.math::pow(System.Single,System.Single)
    IL_001B: stind.r4
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s b
    IL_0023: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.0
    IL_002B: ret

}
Span<double> pow(Span<double> b, double exp)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0020
    IL_0004: ldarga.s b
    IL_0006: ldloc.0
    IL_0007: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_000C: ldarga.s b
    IL_000E: ldloc.0
    IL_000F: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0014: ldind.r8
    IL_0015: ldarg.1
    IL_0016: call System.Double Z0.math::pow(System.Double,System.Double)
    IL_001B: stind.r8
    IL_001C: ldloc.0
    IL_001D: ldc.i4.1
    IL_001E: add
    IL_001F: stloc.0
    IL_0020: ldloc.0
    IL_0021: ldarga.s b
    IL_0023: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_0028: blt.s IL_0004
    IL_002A: ldarg.0
    IL_002B: ret

}
Span<float> round(ReadOnlySpan<float> src, int scale, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: ldstr "round"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Round.cs"
    IL_000C: ldc.i4.s 21
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Single,System.Single>(System.ReadOnlySpan`1<System.Single>,System.Span`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0039
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_002D: ldind.r4
    IL_002E: ldarg.1
    IL_002F: call System.Single Z0.math::round(System.Single,System.Int32)
    IL_0034: stind.r4
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_001D
    IL_003D: ldarg.2
    IL_003E: ret

}
Span<double> round(ReadOnlySpan<double> src, int scale, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: ldstr "round"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Round.cs"
    IL_000C: ldc.i4.s 29
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Double,System.Double>(System.ReadOnlySpan`1<System.Double>,System.Span`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0039
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_002D: ldind.r8
    IL_002E: ldarg.1
    IL_002F: call System.Double Z0.math::round(System.Double,System.Int32)
    IL_0034: stind.r8
    IL_0035: ldloc.1
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.1
    IL_0039: ldloc.1
    IL_003A: ldloc.0
    IL_003B: blt.s IL_001D
    IL_003D: ldarg.2
    IL_003E: ret

}
Span<float> round(Span<float> io, int scale)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0017
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_000C: ldarg.1
    IL_000D: call System.Single& Z0.math::round(System.Single&,System.Int32)
    IL_0012: pop
    IL_0013: ldloc.0
    IL_0014: ldc.i4.1
    IL_0015: add
    IL_0016: stloc.0
    IL_0017: ldloc.0
    IL_0018: ldarga.s io
    IL_001A: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_001F: blt.s IL_0004
    IL_0021: ldarg.0
    IL_0022: ret

}
Span<double> round(Span<double> io, int scale)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0017
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_000C: ldarg.1
    IL_000D: call System.Double& Z0.math::round(System.Double&,System.Int32)
    IL_0012: pop
    IL_0013: ldloc.0
    IL_0014: ldc.i4.1
    IL_0015: add
    IL_0016: stloc.0
    IL_0017: ldloc.0
    IL_0018: ldarga.s io
    IL_001A: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_001F: blt.s IL_0004
    IL_0021: ldarg.0
    IL_0022: ret

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
Span<sbyte> sub(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4.s 21
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
    IL_0037: call System.SByte Z0.math::sub(System.SByte,System.SByte)
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
Span<byte> sub(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4.s 29
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
    IL_0037: call System.Byte Z0.math::sub(System.Byte,System.Byte)
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
Span<short> sub(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4.s 37
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
    IL_0037: call System.Int16 Z0.math::sub(System.Int16,System.Int16)
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
Span<ushort> sub(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4.s 45
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
    IL_0037: call System.UInt16 Z0.math::sub(System.UInt16,System.UInt16)
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
Span<int> sub(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4.s 53
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
    IL_0037: call System.Int32 Z0.math::sub(System.Int32,System.Int32)
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
Span<uint> sub(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4.s 61
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
    IL_0037: call System.UInt32 Z0.math::sub(System.UInt32,System.UInt32)
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
Span<long> sub(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4.s 69
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
    IL_0037: call System.Int64 Z0.math::sub(System.Int64,System.Int64)
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
Span<ulong> sub(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4.s 77
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
    IL_0037: call System.UInt64 Z0.math::sub(System.UInt64,System.UInt64)
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
Span<float> sub(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4.s 85
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
    IL_0037: call System.Single Z0.math::sub(System.Single,System.Single)
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
Span<double> sub(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4.s 93
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
    IL_0037: call System.Double Z0.math::sub(System.Double,System.Double)
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
Span<sbyte> sub(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4.s 101
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
    IL_0030: sub
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
Span<byte> sub(Span<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4.s 109
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
    IL_0030: sub
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
Span<short> sub(Span<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4.s 117
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
    IL_0030: sub
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
Span<ushort> sub(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4.s 125
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
    IL_0030: sub
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
Span<int> sub(Span<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4 133
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4 141
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4 149
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4 157
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4 165
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Sub.cs"
    IL_000C: ldc.i4 173
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
Span<bool> gt(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4.s 112
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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4.s 116
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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4.s 120
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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4.s 124
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::gt(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> gt(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4 128
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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4 132
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::gt(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> gt(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4 136
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Single,System.Single>(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::gt(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> gt(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4 140
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Double,System.Double>(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::gt(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.Span`1<System.Boolean>)
    IL_0027: ret

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
Span<bool> gteq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
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
    IL_001E: call System.Boolean Z0.math::gteq(System.Single,System.Single)
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
Span<bool> gteq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
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
    IL_001E: call System.Boolean Z0.math::gteq(System.Double,System.Double)
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
Span<bool> gteq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4 224
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::gteq(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> gteq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4 228
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::gteq(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> gteq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4 232
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::gteq(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> gteq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4 236
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::gteq(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> gteq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4 240
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::gteq(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> gteq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4 244
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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4 248
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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4 252
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::gteq(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> gteq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4 256
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Single,System.Single>(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::gteq(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> gteq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gteq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4 260
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Double,System.Double>(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::gteq(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<sbyte> inc(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "inc"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Inc.cs"
    IL_000C: ldc.i4.s 23
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
    IL_002E: call System.SByte Z0.math::inc(System.SByte)
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
Span<byte> inc(ReadOnlySpan<byte> src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "inc"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Inc.cs"
    IL_000C: ldc.i4.s 32
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_002D: ldind.u1
    IL_002E: call System.Byte Z0.math::inc(System.Byte)
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
Span<short> inc(ReadOnlySpan<short> src, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "inc"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Inc.cs"
    IL_000C: ldc.i4.s 41
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
    IL_002E: call System.Int16 Z0.math::inc(System.Int16)
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
Span<ushort> inc(ReadOnlySpan<ushort> src, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "inc"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Inc.cs"
    IL_000C: ldc.i4.s 50
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.Span`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_002D: ldind.u2
    IL_002E: call System.UInt16 Z0.math::inc(System.UInt16)
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
Span<int> inc(ReadOnlySpan<int> src, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "inc"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Inc.cs"
    IL_000C: ldc.i4.s 59
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
    IL_002E: call System.Int32 Z0.math::inc(System.Int32)
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
Span<uint> inc(ReadOnlySpan<uint> src, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "inc"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Inc.cs"
    IL_000C: ldc.i4.s 68
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_002D: ldind.u4
    IL_002E: call System.UInt32 Z0.math::inc(System.UInt32)
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
Span<long> inc(ReadOnlySpan<long> src, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "inc"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Inc.cs"
    IL_000C: ldc.i4.s 78
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.Span`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_002D: ldind.i8
    IL_002E: call System.Int64 Z0.math::inc(System.Int64)
    IL_0033: stind.i8
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
Span<ulong> inc(ReadOnlySpan<ulong> src, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "inc"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Inc.cs"
    IL_000C: ldc.i4.s 87
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_002D: ldind.i8
    IL_002E: call System.UInt64 Z0.math::inc(System.UInt64)
    IL_0033: stind.i8
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
Span<float> inc(ReadOnlySpan<float> src, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "inc"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Inc.cs"
    IL_000C: ldc.i4.s 96
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Single,System.Single>(System.ReadOnlySpan`1<System.Single>,System.Span`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_002D: ldind.r4
    IL_002E: call System.Single Z0.math::inc(System.Single)
    IL_0033: stind.r4
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
Span<double> inc(ReadOnlySpan<double> src, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "inc"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Inc.cs"
    IL_000C: ldc.i4.s 105
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Double,System.Double>(System.ReadOnlySpan`1<System.Double>,System.Span`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_002D: ldind.r8
    IL_002E: call System.Double Z0.math::inc(System.Double)
    IL_0033: stind.r8
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
Span<sbyte> inc(Span<sbyte> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_000C: call System.SByte& Z0.math::inc(System.SByte&)
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
Span<byte> inc(Span<byte> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_000C: call System.Byte& Z0.math::inc(System.Byte&)
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
Span<short> inc(Span<short> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_000C: call System.Int16& Z0.math::inc(System.Int16&)
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
Span<ushort> inc(Span<ushort> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_000C: call System.UInt16& Z0.math::inc(System.UInt16&)
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
Span<int> inc(Span<int> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_000C: call System.Int32& Z0.math::inc(System.Int32&)
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
Span<uint> inc(Span<uint> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_000C: call System.UInt32& Z0.math::inc(System.UInt32&)
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
Span<long> inc(Span<long> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_000C: call System.Int64& Z0.math::inc(System.Int64&)
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
Span<ulong> inc(Span<ulong> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_000C: call System.UInt64& Z0.math::inc(System.UInt64&)
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
Span<float> inc(Span<float> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_000C: call System.Single& Z0.math::inc(System.Single&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s io
    IL_0019: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<double> inc(Span<double> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_000C: call System.Double& Z0.math::inc(System.Double&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s io
    IL_0019: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4.s 91
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> lt(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4.s 95
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> lt(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4.s 99
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> lt(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4.s 103
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> lt(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4.s 107
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> lt(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4.s 111
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> lt(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4.s 115
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> lt(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4.s 119
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> lt(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4.s 123
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Single,System.Single>(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> lt(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "lt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4.s 127
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Double,System.Double>(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::lt(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.Span`1<System.Boolean>)
    IL_0024: ret

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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4 201
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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4 205
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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4 209
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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4 213
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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4 217
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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4 221
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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4 225
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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4 229
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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4 233
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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Lt.cs"
    IL_000E: ldc.i4 237
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Double,System.Double>(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::lteq(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.Span`1<System.Boolean>)
    IL_0027: ret

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
Span<sbyte> mod(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
    IL_000C: ldc.i4.s 21
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
    IL_000C: ldc.i4.s 29
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
    IL_000C: ldc.i4.s 37
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
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
    IL_0037: call System.UInt16 Z0.math::mod(System.UInt16,System.UInt16)
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
void mod(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
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
    IL_0037: call System.Int32 Z0.math::mod(System.Int32,System.Int32)
    IL_003C: stind.i4
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ret

}
void mod(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
    IL_000C: ldc.i4.s 58
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
    IL_0037: call System.UInt32 Z0.math::mod(System.UInt32,System.UInt32)
    IL_003C: stind.i4
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ret

}
void mod(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
    IL_000C: ldc.i4.s 65
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
    IL_0037: call System.Int64 Z0.math::mod(System.Int64,System.Int64)
    IL_003C: stind.i8
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ret

}
void mod(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
    IL_000C: ldc.i4.s 72
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
    IL_0037: call System.UInt64 Z0.math::mod(System.UInt64,System.UInt64)
    IL_003C: stind.i8
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ret

}
void mod(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
    IL_000C: ldc.i4.s 79
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
    IL_0037: call System.Single Z0.math::mod(System.Single,System.Single)
    IL_003C: stind.r4
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ret

}
void mod(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
    IL_000C: ldc.i4.s 86
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
    IL_0037: call System.Double Z0.math::mod(System.Double,System.Double)
    IL_003C: stind.r8
    IL_003D: ldloc.1
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.1
    IL_0042: ldloc.0
    IL_0043: blt.s IL_001D
    IL_0045: ret

}
Span<sbyte> mod(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
    IL_000C: ldc.i4.s 93
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
    IL_0030: rem
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
Span<byte> mod(Span<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
    IL_000C: ldc.i4.s 101
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
    IL_0030: rem
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
Span<short> mod(Span<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
    IL_000C: ldc.i4.s 109
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
    IL_0030: rem
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
Span<ushort> mod(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
    IL_000C: ldc.i4.s 117
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
    IL_0030: rem
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
Span<int> mod(Span<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
    IL_000C: ldc.i4.s 125
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int32>(System.Span`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0036
    IL_001D: ldarga.s lhs
    IL_001F: ldloc.1
    IL_0020: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0025: dup
    IL_0026: ldind.i4
    IL_0027: ldarga.s rhs
    IL_0029: ldloc.1
    IL_002A: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_002F: ldind.i4
    IL_0030: rem
    IL_0031: stind.i4
    IL_0032: ldloc.1
    IL_0033: ldc.i4.1
    IL_0034: add
    IL_0035: stloc.1
    IL_0036: ldloc.1
    IL_0037: ldloc.0
    IL_0038: blt.s IL_001D
    IL_003A: ldarg.0
    IL_003B: ret

}
Span<uint> mod(Span<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
    IL_000C: ldc.i4 133
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
    IL_000C: ldc.i4 141
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
    IL_000C: ldc.i4 149
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
Span<float> mod(Span<float> lhs, ReadOnlySpan<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
    IL_000C: ldc.i4 157
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
    IL_0033: rem
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
Span<double> mod(Span<double> lhs, ReadOnlySpan<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Mod.cs"
    IL_000C: ldc.i4 165
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
    IL_0033: rem
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
Span<short> and(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\And.cs"
    IL_000C: ldc.i4.s 37
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
    IL_0037: call System.Int16 Z0.math::and(System.Int16,System.Int16)
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
Span<ushort> and(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\And.cs"
    IL_000C: ldc.i4.s 45
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
    IL_0037: call System.UInt16 Z0.math::and(System.UInt16,System.UInt16)
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
Span<int> and(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\And.cs"
    IL_000C: ldc.i4.s 53
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
    IL_0037: call System.Int32 Z0.math::and(System.Int32,System.Int32)
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
Span<uint> and(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\And.cs"
    IL_000C: ldc.i4.s 61
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
    IL_0037: call System.UInt32 Z0.math::and(System.UInt32,System.UInt32)
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
Span<long> and(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\And.cs"
    IL_000C: ldc.i4.s 69
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
    IL_0037: call System.Int64 Z0.math::and(System.Int64,System.Int64)
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
Span<ulong> and(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\And.cs"
    IL_000C: ldc.i4.s 77
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
    IL_0037: call System.UInt64 Z0.math::and(System.UInt64,System.UInt64)
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
Span<sbyte> and(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\And.cs"
    IL_000C: ldc.i4.s 85
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
    IL_0030: and
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
Span<byte> and(Span<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\And.cs"
    IL_000C: ldc.i4.s 93
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
    IL_0030: and
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
Span<short> and(Span<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\And.cs"
    IL_000C: ldc.i4.s 101
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
    IL_0030: and
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
Span<ushort> and(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\And.cs"
    IL_000C: ldc.i4.s 109
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
    IL_0030: and
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
Span<int> and(Span<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\And.cs"
    IL_000C: ldc.i4.s 117
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int32>(System.Span`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0036
    IL_001D: ldarga.s lhs
    IL_001F: ldloc.1
    IL_0020: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0025: dup
    IL_0026: ldind.i4
    IL_0027: ldarga.s rhs
    IL_0029: ldloc.1
    IL_002A: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_002F: ldind.i4
    IL_0030: and
    IL_0031: stind.i4
    IL_0032: ldloc.1
    IL_0033: ldc.i4.1
    IL_0034: add
    IL_0035: stloc.1
    IL_0036: ldloc.1
    IL_0037: ldloc.0
    IL_0038: blt.s IL_001D
    IL_003A: ldarg.0
    IL_003B: ret

}
Span<uint> and(Span<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\And.cs"
    IL_000C: ldc.i4.s 125
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt32>(System.Span`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0036
    IL_001D: ldarga.s lhs
    IL_001F: ldloc.1
    IL_0020: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0025: dup
    IL_0026: ldind.u4
    IL_0027: ldarga.s rhs
    IL_0029: ldloc.1
    IL_002A: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_002F: ldind.u4
    IL_0030: and
    IL_0031: stind.i4
    IL_0032: ldloc.1
    IL_0033: ldc.i4.1
    IL_0034: add
    IL_0035: stloc.1
    IL_0036: ldloc.1
    IL_0037: ldloc.0
    IL_0038: blt.s IL_001D
    IL_003A: ldarg.0
    IL_003B: ret

}
Span<long> and(Span<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\And.cs"
    IL_000C: ldc.i4 133
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\And.cs"
    IL_000C: ldc.i4 141
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
Span<sbyte> dec(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dec"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dec.cs"
    IL_000C: ldc.i4.s 23
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
    IL_002E: call System.SByte Z0.math::dec(System.SByte)
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
Span<byte> dec(ReadOnlySpan<byte> src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dec"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dec.cs"
    IL_000C: ldc.i4.s 32
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_002D: ldind.u1
    IL_002E: call System.Byte Z0.math::dec(System.Byte)
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
Span<short> dec(ReadOnlySpan<short> src, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dec"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dec.cs"
    IL_000C: ldc.i4.s 41
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
    IL_002E: call System.Int16 Z0.math::dec(System.Int16)
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
Span<ushort> dec(ReadOnlySpan<ushort> src, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dec"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dec.cs"
    IL_000C: ldc.i4.s 50
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.Span`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_002D: ldind.u2
    IL_002E: call System.UInt16 Z0.math::dec(System.UInt16)
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
Span<int> dec(ReadOnlySpan<int> src, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dec"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dec.cs"
    IL_000C: ldc.i4.s 59
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
    IL_002E: call System.Int32 Z0.math::dec(System.Int32)
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
Span<uint> dec(ReadOnlySpan<uint> src, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dec"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dec.cs"
    IL_000C: ldc.i4.s 68
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_002D: ldind.u4
    IL_002E: call System.UInt32 Z0.math::dec(System.UInt32)
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
Span<long> dec(ReadOnlySpan<long> src, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dec"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dec.cs"
    IL_000C: ldc.i4.s 78
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.Span`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_002D: ldind.i8
    IL_002E: call System.Int64 Z0.math::dec(System.Int64)
    IL_0033: stind.i8
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
Span<ulong> dec(ReadOnlySpan<ulong> src, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dec"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dec.cs"
    IL_000C: ldc.i4.s 87
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_002D: ldind.i8
    IL_002E: call System.UInt64 Z0.math::dec(System.UInt64)
    IL_0033: stind.i8
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
Span<float> dec(ReadOnlySpan<float> src, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dec"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dec.cs"
    IL_000C: ldc.i4.s 96
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Single,System.Single>(System.ReadOnlySpan`1<System.Single>,System.Span`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_002D: ldind.r4
    IL_002E: call System.Single Z0.math::dec(System.Single)
    IL_0033: stind.r4
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
Span<double> dec(ReadOnlySpan<double> src, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dec"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dec.cs"
    IL_000C: ldc.i4.s 105
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Double,System.Double>(System.ReadOnlySpan`1<System.Double>,System.Span`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_002D: ldind.r8
    IL_002E: call System.Double Z0.math::dec(System.Double)
    IL_0033: stind.r8
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
Span<float> dec(Span<float> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_000C: call System.Single& Z0.math::dec(System.Single&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s io
    IL_0019: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<double> dec(Span<double> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0016
    IL_0004: ldarga.s io
    IL_0006: ldloc.0
    IL_0007: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_000C: call System.Double& Z0.math::dec(System.Double&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldarga.s io
    IL_0019: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_001E: blt.s IL_0004
    IL_0020: ldarg.0
    IL_0021: ret

}
Span<sbyte> div(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4.s 21
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
    IL_0037: call System.SByte Z0.math::div(System.SByte,System.SByte)
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
Span<byte> div(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4.s 29
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
    IL_0037: call System.Byte Z0.math::div(System.Byte,System.Byte)
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
Span<short> div(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4.s 37
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
    IL_0037: call System.Int16 Z0.math::div(System.Int16,System.Int16)
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
Span<ushort> div(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4.s 45
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
    IL_0037: call System.UInt16 Z0.math::div(System.UInt16,System.UInt16)
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
Span<int> div(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4.s 53
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
    IL_0037: call System.Int32 Z0.math::div(System.Int32,System.Int32)
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
Span<uint> div(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4.s 61
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
    IL_0037: call System.UInt32 Z0.math::div(System.UInt32,System.UInt32)
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
Span<long> div(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4.s 69
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
    IL_0037: call System.Int64 Z0.math::div(System.Int64,System.Int64)
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
Span<ulong> div(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4.s 77
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
    IL_0037: call System.UInt64 Z0.math::div(System.UInt64,System.UInt64)
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
Span<float> div(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4.s 85
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
    IL_0037: call System.Single Z0.math::div(System.Single,System.Single)
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
Span<double> div(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4.s 93
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
    IL_0037: call System.Double Z0.math::div(System.Double,System.Double)
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
Span<sbyte> div(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4.s 101
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
    IL_0030: div
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
Span<byte> div(Span<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4.s 109
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
    IL_0030: div
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
Span<short> div(Span<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4.s 117
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
    IL_0030: div
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
Span<ushort> div(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4.s 125
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
    IL_0030: div
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
Span<int> div(Span<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4 133
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
Span<uint> div(Span<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4 141
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
Span<long> div(Span<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4 149
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
Span<ulong> div(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4 157
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
Span<float> div(Span<float> lhs, ReadOnlySpan<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4 165
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
    IL_0033: div
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
Span<double> div(Span<double> lhs, ReadOnlySpan<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Div.cs"
    IL_000C: ldc.i4 173
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
    IL_0033: div
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
sbyte dot(in ReadOnlySpan<sbyte> lhs, in ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.ReadOnlySpan`1<System.SByte>
    IL_0006: ldarg.1
    IL_0007: ldobj System.ReadOnlySpan`1<System.SByte>
    IL_000C: ldstr "dot"
    IL_0011: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dot.cs"
    IL_0016: ldc.i4.s 21
    IL_0018: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_001D: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0022: stloc.0
    IL_0023: ldc.i4.0
    IL_0024: stloc.1
    IL_0025: ldc.i4.0
    IL_0026: stloc.2
    IL_0027: br.s IL_0043
    IL_0029: ldloc.1
    IL_002A: ldarg.0
    IL_002B: ldloc.2
    IL_002C: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0031: ldind.i1
    IL_0032: ldarg.1
    IL_0033: ldloc.2
    IL_0034: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.SByte>::get_Item(System.Int32)
    IL_0039: ldind.i1
    IL_003A: mul
    IL_003B: conv.i1
    IL_003C: add
    IL_003D: conv.i1
    IL_003E: stloc.1
    IL_003F: ldloc.2
    IL_0040: ldc.i4.1
    IL_0041: add
    IL_0042: stloc.2
    IL_0043: ldloc.2
    IL_0044: ldloc.0
    IL_0045: blt.s IL_0029
    IL_0047: ldloc.1
    IL_0048: ret

}
byte dot(in ReadOnlySpan<byte> lhs, in ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.ReadOnlySpan`1<System.Byte>
    IL_0006: ldarg.1
    IL_0007: ldobj System.ReadOnlySpan`1<System.Byte>
    IL_000C: ldstr "dot"
    IL_0011: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dot.cs"
    IL_0016: ldc.i4.s 30
    IL_0018: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_001D: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0022: stloc.0
    IL_0023: ldc.i4.0
    IL_0024: stloc.1
    IL_0025: ldc.i4.0
    IL_0026: stloc.2
    IL_0027: br.s IL_0043
    IL_0029: ldloc.1
    IL_002A: ldarg.0
    IL_002B: ldloc.2
    IL_002C: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0031: ldind.u1
    IL_0032: ldarg.1
    IL_0033: ldloc.2
    IL_0034: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0039: ldind.u1
    IL_003A: mul
    IL_003B: conv.u1
    IL_003C: add
    IL_003D: conv.u1
    IL_003E: stloc.1
    IL_003F: ldloc.2
    IL_0040: ldc.i4.1
    IL_0041: add
    IL_0042: stloc.2
    IL_0043: ldloc.2
    IL_0044: ldloc.0
    IL_0045: blt.s IL_0029
    IL_0047: ldloc.1
    IL_0048: ret

}
short dot(in ReadOnlySpan<short> lhs, in ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.ReadOnlySpan`1<System.Int16>
    IL_0006: ldarg.1
    IL_0007: ldobj System.ReadOnlySpan`1<System.Int16>
    IL_000C: ldstr "dot"
    IL_0011: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dot.cs"
    IL_0016: ldc.i4.s 39
    IL_0018: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_001D: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0022: stloc.0
    IL_0023: ldc.i4.0
    IL_0024: stloc.1
    IL_0025: ldc.i4.0
    IL_0026: stloc.2
    IL_0027: br.s IL_0043
    IL_0029: ldloc.1
    IL_002A: ldarg.0
    IL_002B: ldloc.2
    IL_002C: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0031: ldind.i2
    IL_0032: ldarg.1
    IL_0033: ldloc.2
    IL_0034: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int16>::get_Item(System.Int32)
    IL_0039: ldind.i2
    IL_003A: mul
    IL_003B: conv.i2
    IL_003C: add
    IL_003D: conv.i2
    IL_003E: stloc.1
    IL_003F: ldloc.2
    IL_0040: ldc.i4.1
    IL_0041: add
    IL_0042: stloc.2
    IL_0043: ldloc.2
    IL_0044: ldloc.0
    IL_0045: blt.s IL_0029
    IL_0047: ldloc.1
    IL_0048: ret

}
ushort dot(in ReadOnlySpan<ushort> lhs, in ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.ReadOnlySpan`1<System.UInt16>
    IL_0006: ldarg.1
    IL_0007: ldobj System.ReadOnlySpan`1<System.UInt16>
    IL_000C: ldstr "dot"
    IL_0011: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dot.cs"
    IL_0016: ldc.i4.s 48
    IL_0018: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_001D: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0022: stloc.0
    IL_0023: ldc.i4.0
    IL_0024: stloc.1
    IL_0025: ldc.i4.0
    IL_0026: stloc.2
    IL_0027: br.s IL_0043
    IL_0029: ldloc.1
    IL_002A: ldarg.0
    IL_002B: ldloc.2
    IL_002C: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0031: ldind.u2
    IL_0032: ldarg.1
    IL_0033: ldloc.2
    IL_0034: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_0039: ldind.u2
    IL_003A: mul
    IL_003B: conv.u2
    IL_003C: add
    IL_003D: conv.u2
    IL_003E: stloc.1
    IL_003F: ldloc.2
    IL_0040: ldc.i4.1
    IL_0041: add
    IL_0042: stloc.2
    IL_0043: ldloc.2
    IL_0044: ldloc.0
    IL_0045: blt.s IL_0029
    IL_0047: ldloc.1
    IL_0048: ret

}
int dot(in ReadOnlySpan<int> lhs, in ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.ReadOnlySpan`1<System.Int32>
    IL_0006: ldarg.1
    IL_0007: ldobj System.ReadOnlySpan`1<System.Int32>
    IL_000C: ldstr "dot"
    IL_0011: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dot.cs"
    IL_0016: ldc.i4.s 57
    IL_0018: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_001D: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0022: stloc.0
    IL_0023: ldc.i4.0
    IL_0024: stloc.1
    IL_0025: ldc.i4.0
    IL_0026: stloc.2
    IL_0027: br.s IL_0041
    IL_0029: ldloc.1
    IL_002A: ldarg.0
    IL_002B: ldloc.2
    IL_002C: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0031: ldind.i4
    IL_0032: ldarg.1
    IL_0033: ldloc.2
    IL_0034: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int32>::get_Item(System.Int32)
    IL_0039: ldind.i4
    IL_003A: mul
    IL_003B: add
    IL_003C: stloc.1
    IL_003D: ldloc.2
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.2
    IL_0041: ldloc.2
    IL_0042: ldloc.0
    IL_0043: blt.s IL_0029
    IL_0045: ldloc.1
    IL_0046: ret

}
uint dot(in ReadOnlySpan<uint> lhs, in ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.ReadOnlySpan`1<System.UInt32>
    IL_0006: ldarg.1
    IL_0007: ldobj System.ReadOnlySpan`1<System.UInt32>
    IL_000C: ldstr "dot"
    IL_0011: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dot.cs"
    IL_0016: ldc.i4.s 66
    IL_0018: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_001D: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0022: stloc.0
    IL_0023: ldc.i4.0
    IL_0024: stloc.1
    IL_0025: ldc.i4.0
    IL_0026: stloc.2
    IL_0027: br.s IL_0041
    IL_0029: ldloc.1
    IL_002A: ldarg.0
    IL_002B: ldloc.2
    IL_002C: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0031: ldind.u4
    IL_0032: ldarg.1
    IL_0033: ldloc.2
    IL_0034: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_0039: ldind.u4
    IL_003A: mul
    IL_003B: add
    IL_003C: stloc.1
    IL_003D: ldloc.2
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.2
    IL_0041: ldloc.2
    IL_0042: ldloc.0
    IL_0043: blt.s IL_0029
    IL_0045: ldloc.1
    IL_0046: ret

}
long dot(in ReadOnlySpan<long> lhs, in ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.ReadOnlySpan`1<System.Int64>
    IL_0006: ldarg.1
    IL_0007: ldobj System.ReadOnlySpan`1<System.Int64>
    IL_000C: ldstr "dot"
    IL_0011: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dot.cs"
    IL_0016: ldc.i4.s 75
    IL_0018: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_001D: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0022: stloc.0
    IL_0023: ldc.i4.0
    IL_0024: conv.i8
    IL_0025: stloc.1
    IL_0026: ldc.i4.0
    IL_0027: stloc.2
    IL_0028: br.s IL_0042
    IL_002A: ldloc.1
    IL_002B: ldarg.0
    IL_002C: ldloc.2
    IL_002D: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_0032: ldind.i8
    IL_0033: ldarg.1
    IL_0034: ldloc.2
    IL_0035: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_003A: ldind.i8
    IL_003B: mul
    IL_003C: add
    IL_003D: stloc.1
    IL_003E: ldloc.2
    IL_003F: ldc.i4.1
    IL_0040: add
    IL_0041: stloc.2
    IL_0042: ldloc.2
    IL_0043: ldloc.0
    IL_0044: blt.s IL_002A
    IL_0046: ldloc.1
    IL_0047: ret

}
ulong dot(in ReadOnlySpan<ulong> lhs, in ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.ReadOnlySpan`1<System.UInt64>
    IL_0006: ldarg.1
    IL_0007: ldobj System.ReadOnlySpan`1<System.UInt64>
    IL_000C: ldstr "dot"
    IL_0011: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dot.cs"
    IL_0016: ldc.i4.s 84
    IL_0018: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_001D: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0022: stloc.0
    IL_0023: ldc.i4.0
    IL_0024: conv.i8
    IL_0025: stloc.1
    IL_0026: ldc.i4.0
    IL_0027: stloc.2
    IL_0028: br.s IL_0042
    IL_002A: ldloc.1
    IL_002B: ldarg.0
    IL_002C: ldloc.2
    IL_002D: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_0032: ldind.i8
    IL_0033: ldarg.1
    IL_0034: ldloc.2
    IL_0035: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_003A: ldind.i8
    IL_003B: mul
    IL_003C: add
    IL_003D: stloc.1
    IL_003E: ldloc.2
    IL_003F: ldc.i4.1
    IL_0040: add
    IL_0041: stloc.2
    IL_0042: ldloc.2
    IL_0043: ldloc.0
    IL_0044: blt.s IL_002A
    IL_0046: ldloc.1
    IL_0047: ret

}
float dot(in ReadOnlySpan<float> lhs, in ReadOnlySpan<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.ReadOnlySpan`1<System.Single>
    IL_0006: ldarg.1
    IL_0007: ldobj System.ReadOnlySpan`1<System.Single>
    IL_000C: ldstr "dot"
    IL_0011: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dot.cs"
    IL_0016: ldc.i4.s 93
    IL_0018: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_001D: call System.Int32 zfunc::length<System.Single,System.Single>(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0022: stloc.0
    IL_0023: ldc.r4 0
    IL_0028: stloc.1
    IL_0029: ldc.i4.0
    IL_002A: stloc.2
    IL_002B: br.s IL_0045
    IL_002D: ldloc.1
    IL_002E: ldarg.0
    IL_002F: ldloc.2
    IL_0030: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_0035: ldind.r4
    IL_0036: ldarg.1
    IL_0037: ldloc.2
    IL_0038: call System.Single& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Single>::get_Item(System.Int32)
    IL_003D: ldind.r4
    IL_003E: mul
    IL_003F: add
    IL_0040: stloc.1
    IL_0041: ldloc.2
    IL_0042: ldc.i4.1
    IL_0043: add
    IL_0044: stloc.2
    IL_0045: ldloc.2
    IL_0046: ldloc.0
    IL_0047: blt.s IL_002D
    IL_0049: ldloc.1
    IL_004A: ret

}
double dot(in ReadOnlySpan<double> lhs, in ReadOnlySpan<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.ReadOnlySpan`1<System.Double>
    IL_0006: ldarg.1
    IL_0007: ldobj System.ReadOnlySpan`1<System.Double>
    IL_000C: ldstr "dot"
    IL_0011: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Dot.cs"
    IL_0016: ldc.i4.s 102
    IL_0018: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_001D: call System.Int32 zfunc::length<System.Double,System.Double>(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0022: stloc.0
    IL_0023: ldc.r8 0
    IL_002C: stloc.1
    IL_002D: ldc.i4.0
    IL_002E: stloc.2
    IL_002F: br.s IL_0049
    IL_0031: ldloc.1
    IL_0032: ldarg.0
    IL_0033: ldloc.2
    IL_0034: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0039: ldind.r8
    IL_003A: ldarg.1
    IL_003B: ldloc.2
    IL_003C: call System.Double& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Double>::get_Item(System.Int32)
    IL_0041: ldind.r8
    IL_0042: mul
    IL_0043: add
    IL_0044: stloc.1
    IL_0045: ldloc.2
    IL_0046: ldc.i4.1
    IL_0047: add
    IL_0048: stloc.2
    IL_0049: ldloc.2
    IL_004A: ldloc.0
    IL_004B: blt.s IL_0031
    IL_004D: ldloc.1
    IL_004E: ret

}
Span<bool> eq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
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
    IL_001E: call System.Boolean Z0.math::eq(System.SByte,System.SByte)
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
Span<bool> eq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
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
    IL_001E: call System.Boolean Z0.math::eq(System.Byte,System.Byte)
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
Span<bool> eq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
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
    IL_001E: call System.Boolean Z0.math::eq(System.Int16,System.Int16)
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
Span<bool> eq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
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
    IL_001E: call System.Boolean Z0.math::eq(System.UInt16,System.UInt16)
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
Span<bool> eq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
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
    IL_001E: call System.Boolean Z0.math::eq(System.Int32,System.Int32)
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
Span<bool> eq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
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
    IL_001E: call System.Boolean Z0.math::eq(System.UInt32,System.UInt32)
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
Span<bool> eq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
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
    IL_001E: call System.Boolean Z0.math::eq(System.Int64,System.Int64)
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
Span<bool> eq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
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
    IL_001E: call System.Boolean Z0.math::eq(System.UInt64,System.UInt64)
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
Span<bool> eq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
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
    IL_001E: call System.Boolean Z0.math::eq(System.Single,System.Single)
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
Span<bool> eq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
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
    IL_001E: call System.Boolean Z0.math::eq(System.Double,System.Double)
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
Span<bool> eq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "eq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Eq.cs"
    IL_000E: ldc.i4.s 101
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::eq(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> eq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "eq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Eq.cs"
    IL_000E: ldc.i4.s 105
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::eq(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> eq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "eq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Eq.cs"
    IL_000E: ldc.i4.s 109
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::eq(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> eq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "eq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Eq.cs"
    IL_000E: ldc.i4.s 113
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::eq(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> eq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "eq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Eq.cs"
    IL_000E: ldc.i4.s 117
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::eq(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> eq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "eq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Eq.cs"
    IL_000E: ldc.i4.s 121
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::eq(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> eq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "eq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Eq.cs"
    IL_000E: ldc.i4.s 125
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::eq(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.Span`1<System.Boolean>)
    IL_0024: ret

}
Span<bool> eq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "eq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Eq.cs"
    IL_000E: ldc.i4 129
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::eq(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> eq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "eq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Eq.cs"
    IL_000E: ldc.i4 133
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Single,System.Single>(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::eq(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<bool> eq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "eq"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Eq.cs"
    IL_000E: ldc.i4 137
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Double,System.Double>(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_0022: call System.Span`1<System.Boolean> Z0.math::eq(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.Span`1<System.Boolean>)
    IL_0027: ret

}
Span<sbyte> flip(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "flip"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Flip.cs"
    IL_000C: ldc.i4.s 20
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
    IL_002E: call System.SByte Z0.math::flip(System.SByte)
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
Span<byte> flip(ReadOnlySpan<byte> src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "flip"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Flip.cs"
    IL_000C: ldc.i4.s 28
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_002D: ldind.u1
    IL_002E: call System.Byte Z0.math::flip(System.Byte)
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
Span<short> flip(ReadOnlySpan<short> src, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "flip"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Flip.cs"
    IL_000C: ldc.i4.s 36
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
    IL_002E: call System.Int16 Z0.math::flip(System.Int16)
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
Span<ushort> flip(ReadOnlySpan<ushort> src, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "flip"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Flip.cs"
    IL_000C: ldc.i4.s 44
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.Span`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.UInt16& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt16>::get_Item(System.Int32)
    IL_002D: ldind.u2
    IL_002E: call System.UInt16 Z0.math::flip(System.UInt16)
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
Span<int> flip(ReadOnlySpan<int> src, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "flip"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Flip.cs"
    IL_000C: ldc.i4.s 52
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
    IL_002E: call System.Int32 Z0.math::flip(System.Int32)
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
Span<uint> flip(ReadOnlySpan<uint> src, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "flip"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Flip.cs"
    IL_000C: ldc.i4.s 60
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt32>::get_Item(System.Int32)
    IL_002D: ldind.u4
    IL_002E: call System.UInt32 Z0.math::flip(System.UInt32)
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
Span<long> flip(ReadOnlySpan<long> src, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "flip"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Flip.cs"
    IL_000C: ldc.i4.s 68
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.Span`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.Int64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Int64>::get_Item(System.Int32)
    IL_002D: ldind.i8
    IL_002E: call System.Int64 Z0.math::flip(System.Int64)
    IL_0033: stind.i8
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
Span<ulong> flip(ReadOnlySpan<ulong> src, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "flip"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Flip.cs"
    IL_000C: ldc.i4.s 76
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_0038
    IL_001D: ldarga.s dst
    IL_001F: ldloc.1
    IL_0020: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0025: ldarga.s src
    IL_0027: ldloc.1
    IL_0028: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.UInt64>::get_Item(System.Int32)
    IL_002D: ldind.i8
    IL_002E: call System.UInt64 Z0.math::flip(System.UInt64)
    IL_0033: stind.i8
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
ref Span<sbyte> flip(ref Span<sbyte> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarg.0
    IL_0005: ldloc.0
    IL_0006: call System.SByte& System.Span`1<System.SByte>::get_Item(System.Int32)
    IL_000B: call System.SByte& Z0.math::flip(System.SByte&)
    IL_0010: pop
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarg.0
    IL_0017: call System.Int32 System.Span`1<System.SByte>::get_Length()
    IL_001C: blt.s IL_0004
    IL_001E: ldarg.0
    IL_001F: ret

}
ref Span<byte> flip(ref Span<byte> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarg.0
    IL_0005: ldloc.0
    IL_0006: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_000B: call System.Byte& Z0.math::flip(System.Byte&)
    IL_0010: pop
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarg.0
    IL_0017: call System.Int32 System.Span`1<System.Byte>::get_Length()
    IL_001C: blt.s IL_0004
    IL_001E: ldarg.0
    IL_001F: ret

}
ref Span<short> flip(ref Span<short> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarg.0
    IL_0005: ldloc.0
    IL_0006: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_000B: call System.Int16& Z0.math::flip(System.Int16&)
    IL_0010: pop
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarg.0
    IL_0017: call System.Int32 System.Span`1<System.Int16>::get_Length()
    IL_001C: blt.s IL_0004
    IL_001E: ldarg.0
    IL_001F: ret

}
ref Span<ushort> flip(ref Span<ushort> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarg.0
    IL_0005: ldloc.0
    IL_0006: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_000B: call System.UInt16& Z0.math::flip(System.UInt16&)
    IL_0010: pop
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarg.0
    IL_0017: call System.Int32 System.Span`1<System.UInt16>::get_Length()
    IL_001C: blt.s IL_0004
    IL_001E: ldarg.0
    IL_001F: ret

}
ref Span<int> flip(ref Span<int> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarg.0
    IL_0005: ldloc.0
    IL_0006: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_000B: call System.Int32& Z0.math::flip(System.Int32&)
    IL_0010: pop
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarg.0
    IL_0017: call System.Int32 System.Span`1<System.Int32>::get_Length()
    IL_001C: blt.s IL_0004
    IL_001E: ldarg.0
    IL_001F: ret

}
ref Span<uint> flip(ref Span<uint> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarg.0
    IL_0005: ldloc.0
    IL_0006: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_000B: call System.UInt32& Z0.math::flip(System.UInt32&)
    IL_0010: pop
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarg.0
    IL_0017: call System.Int32 System.Span`1<System.UInt32>::get_Length()
    IL_001C: blt.s IL_0004
    IL_001E: ldarg.0
    IL_001F: ret

}
ref Span<long> flip(ref Span<long> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarg.0
    IL_0005: ldloc.0
    IL_0006: call System.Int64& System.Span`1<System.Int64>::get_Item(System.Int32)
    IL_000B: call System.Int64& Z0.math::flip(System.Int64&)
    IL_0010: pop
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarg.0
    IL_0017: call System.Int32 System.Span`1<System.Int64>::get_Length()
    IL_001C: blt.s IL_0004
    IL_001E: ldarg.0
    IL_001F: ret

}
ref Span<ulong> flip(ref Span<ulong> io)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarg.0
    IL_0005: ldloc.0
    IL_0006: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_000B: call System.UInt64& Z0.math::flip(System.UInt64&)
    IL_0010: pop
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarg.0
    IL_0017: call System.Int32 System.Span`1<System.UInt64>::get_Length()
    IL_001C: blt.s IL_0004
    IL_001E: ldarg.0
    IL_001F: ret

}
Span<sbyte> flip(ReadOnlySpan<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Span`1<System.SByte> Z0.xfunc::Replicate<System.SByte>(System.ReadOnlySpan`1<System.SByte>)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call System.Span`1<System.SByte>& Z0.math::flip(System.Span`1<System.SByte>&)
    IL_000E: ldobj System.Span`1<System.SByte>
    IL_0013: ret

}
Span<byte> flip(ReadOnlySpan<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Span`1<System.Byte> Z0.xfunc::Replicate<System.Byte>(System.ReadOnlySpan`1<System.Byte>)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call System.Span`1<System.Byte>& Z0.math::flip(System.Span`1<System.Byte>&)
    IL_000E: ldobj System.Span`1<System.Byte>
    IL_0013: ret

}
Span<short> flip(ReadOnlySpan<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Span`1<System.Int16> Z0.xfunc::Replicate<System.Int16>(System.ReadOnlySpan`1<System.Int16>)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call System.Span`1<System.Int16>& Z0.math::flip(System.Span`1<System.Int16>&)
    IL_000E: ldobj System.Span`1<System.Int16>
    IL_0013: ret

}
Span<ushort> flip(ReadOnlySpan<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Span`1<System.UInt16> Z0.xfunc::Replicate<System.UInt16>(System.ReadOnlySpan`1<System.UInt16>)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call System.Span`1<System.UInt16>& Z0.math::flip(System.Span`1<System.UInt16>&)
    IL_000E: ldobj System.Span`1<System.UInt16>
    IL_0013: ret

}
Span<int> flip(ReadOnlySpan<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Span`1<System.Int32> Z0.xfunc::Replicate<System.Int32>(System.ReadOnlySpan`1<System.Int32>)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call System.Span`1<System.Int32>& Z0.math::flip(System.Span`1<System.Int32>&)
    IL_000E: ldobj System.Span`1<System.Int32>
    IL_0013: ret

}
Span<uint> flip(ReadOnlySpan<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Span`1<System.UInt32> Z0.xfunc::Replicate<System.UInt32>(System.ReadOnlySpan`1<System.UInt32>)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call System.Span`1<System.UInt32>& Z0.math::flip(System.Span`1<System.UInt32>&)
    IL_000E: ldobj System.Span`1<System.UInt32>
    IL_0013: ret

}
Span<long> flip(ReadOnlySpan<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Span`1<System.Int64> Z0.xfunc::Replicate<System.Int64>(System.ReadOnlySpan`1<System.Int64>)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call System.Span`1<System.Int64>& Z0.math::flip(System.Span`1<System.Int64>&)
    IL_000E: ldobj System.Span`1<System.Int64>
    IL_0013: ret

}
Span<ulong> flip(ReadOnlySpan<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Span`1<System.UInt64> Z0.xfunc::Replicate<System.UInt64>(System.ReadOnlySpan`1<System.UInt64>)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call System.Span`1<System.UInt64>& Z0.math::flip(System.Span`1<System.UInt64>&)
    IL_000E: ldobj System.Span`1<System.UInt64>
    IL_0013: ret

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
Span<bool> gt(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
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
    IL_001E: call System.Boolean Z0.math::gt(System.Single,System.Single)
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
Span<bool> gt(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
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
    IL_001E: call System.Boolean Z0.math::gt(System.Double,System.Double)
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
Span<bool> gt(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "gt"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4.s 104
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
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Gt.cs"
    IL_000E: ldc.i4.s 108
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Boolean> zfunc::span<System.Boolean>(System.Int32)
    IL_001F: call System.Span`1<System.Boolean> Z0.math::gt(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Boolean>)
    IL_0024: ret

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
float acos(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Acos(System.Single)
    IL_0006: ret

}
double acos(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Acos(System.Double)
    IL_0006: ret

}
float acosh(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Acosh(System.Single)
    IL_0006: ret

}
double acosh(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Acosh(System.Double)
    IL_0006: ret

}
float asin(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Asin(System.Single)
    IL_0006: ret

}
double asin(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Asin(System.Double)
    IL_0006: ret

}
float asinh(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Asinh(System.Single)
    IL_0006: ret

}
double asinh(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Asinh(System.Double)
    IL_0006: ret

}
float atan(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Atan(System.Single)
    IL_0006: ret

}
double atan(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Atan(System.Double)
    IL_0006: ret

}
float atanh(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Atanh(System.Single)
    IL_0006: ret

}
double atanh(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Atanh(System.Double)
    IL_0006: ret

}
float cos(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Cos(System.Single)
    IL_0006: ret

}
double cos(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Cos(System.Double)
    IL_0006: ret

}
float cosh(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Cosh(System.Single)
    IL_0006: ret

}
double cosh(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Cosh(System.Double)
    IL_0006: ret

}
float sin(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Sin(System.Single)
    IL_0006: ret

}
double sin(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Sin(System.Double)
    IL_0006: ret

}
float sinh(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Sinh(System.Single)
    IL_0006: ret

}
double sinh(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Sinh(System.Double)
    IL_0006: ret

}
float tan(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Tan(System.Single)
    IL_0006: ret

}
double tan(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Tan(System.Double)
    IL_0006: ret

}
float tanh(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Tanh(System.Single)
    IL_0006: ret

}
double tanh(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Tanh(System.Double)
    IL_0006: ret

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
Span<sbyte> Mul(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "Mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4.s 23
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4.s 31
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4.s 39
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4.s 47
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4.s 54
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4.s 63
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4.s 71
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4.s 79
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4.s 87
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4.s 95
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4.s 103
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4.s 111
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4.s 119
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4.s 127
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4 135
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4 143
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4 151
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4 159
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4 167
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\extensions\\Mul.cs"
    IL_000C: ldc.i4 175
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
Span<sbyte> add(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4.s 23
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
    IL_0037: call System.SByte Z0.math::add(System.SByte,System.SByte)
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
Span<byte> add(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4.s 31
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldc.i4.0
    IL_001A: stloc.1
    IL_001B: br.s IL_003E
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
    IL_0037: add
    IL_0038: conv.u1
    IL_0039: stind.i1
    IL_003A: ldloc.1
    IL_003B: ldc.i4.1
    IL_003C: add
    IL_003D: stloc.1
    IL_003E: ldloc.1
    IL_003F: ldloc.0
    IL_0040: blt.s IL_001D
    IL_0042: ldarg.2
    IL_0043: ret

}
Span<short> add(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4.s 39
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
    IL_0037: call System.Int16 Z0.math::add(System.Int16,System.Int16)
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
Span<ushort> add(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4.s 47
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
    IL_0037: call System.UInt16 Z0.math::add(System.UInt16,System.UInt16)
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
Span<int> add(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4.s 55
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
    IL_0037: call System.Int32 Z0.math::add(System.Int32,System.Int32)
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
Span<uint> add(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4.s 63
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
    IL_0037: call System.UInt32 Z0.math::add(System.UInt32,System.UInt32)
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
Span<long> add(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4.s 71
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
    IL_0037: call System.Int64 Z0.math::add(System.Int64,System.Int64)
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
Span<ulong> add(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4.s 79
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
    IL_0037: call System.UInt64 Z0.math::add(System.UInt64,System.UInt64)
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
Span<float> add(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4.s 87
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
    IL_0037: call System.Single Z0.math::add(System.Single,System.Single)
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
Span<double> add(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4.s 95
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
    IL_0037: call System.Double Z0.math::add(System.Double,System.Double)
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
Span<sbyte> add(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "add"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000E: ldc.i4.s 103
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.SByte,System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.SByte> zfunc::span<System.SByte>(System.Int32)
    IL_001F: call System.Span`1<System.SByte> Z0.math::add(System.ReadOnlySpan`1<System.SByte>,System.ReadOnlySpan`1<System.SByte>,System.Span`1<System.SByte>)
    IL_0024: ret

}
Span<byte> add(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "add"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000E: ldc.i4.s 107
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Byte,System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Byte> zfunc::span<System.Byte>(System.Int32)
    IL_001F: call System.Span`1<System.Byte> Z0.math::add(System.ReadOnlySpan`1<System.Byte>,System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Byte>)
    IL_0024: ret

}
Span<short> add(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "add"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000E: ldc.i4.s 111
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Int16,System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Int16> zfunc::span<System.Int16>(System.Int32)
    IL_001F: call System.Span`1<System.Int16> Z0.math::add(System.ReadOnlySpan`1<System.Int16>,System.ReadOnlySpan`1<System.Int16>,System.Span`1<System.Int16>)
    IL_0024: ret

}
Span<ushort> add(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "add"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000E: ldc.i4.s 115
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.UInt16,System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.UInt16> zfunc::span<System.UInt16>(System.Int32)
    IL_001F: call System.Span`1<System.UInt16> Z0.math::add(System.ReadOnlySpan`1<System.UInt16>,System.ReadOnlySpan`1<System.UInt16>,System.Span`1<System.UInt16>)
    IL_0024: ret

}
Span<int> add(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "add"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000E: ldc.i4.s 119
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Int32,System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Int32> zfunc::span<System.Int32>(System.Int32)
    IL_001F: call System.Span`1<System.Int32> Z0.math::add(System.ReadOnlySpan`1<System.Int32>,System.ReadOnlySpan`1<System.Int32>,System.Span`1<System.Int32>)
    IL_0024: ret

}
Span<uint> add(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "add"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000E: ldc.i4.s 123
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.UInt32> zfunc::span<System.UInt32>(System.Int32)
    IL_001F: call System.Span`1<System.UInt32> Z0.math::add(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>)
    IL_0024: ret

}
Span<long> add(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "add"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000E: ldc.i4.s 127
    IL_0010: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0015: call System.Int32 zfunc::length<System.Int64,System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001A: call System.Span`1<System.Int64> zfunc::span<System.Int64>(System.Int32)
    IL_001F: call System.Span`1<System.Int64> Z0.math::add(System.ReadOnlySpan`1<System.Int64>,System.ReadOnlySpan`1<System.Int64>,System.Span`1<System.Int64>)
    IL_0024: ret

}
Span<ulong> add(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "add"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000E: ldc.i4 131
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.UInt64> zfunc::span<System.UInt64>(System.Int32)
    IL_0022: call System.Span`1<System.UInt64> Z0.math::add(System.ReadOnlySpan`1<System.UInt64>,System.ReadOnlySpan`1<System.UInt64>,System.Span`1<System.UInt64>)
    IL_0027: ret

}
Span<float> add(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "add"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000E: ldc.i4 135
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Single,System.Single>(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Single> zfunc::span<System.Single>(System.Int32)
    IL_0022: call System.Span`1<System.Single> Z0.math::add(System.ReadOnlySpan`1<System.Single>,System.ReadOnlySpan`1<System.Single>,System.Span`1<System.Single>)
    IL_0027: ret

}
Span<double> add(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldstr "add"
    IL_0009: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000E: ldc.i4 139
    IL_0013: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0018: call System.Int32 zfunc::length<System.Double,System.Double>(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001D: call System.Span`1<System.Double> zfunc::span<System.Double>(System.Int32)
    IL_0022: call System.Span`1<System.Double> Z0.math::add(System.ReadOnlySpan`1<System.Double>,System.ReadOnlySpan`1<System.Double>,System.Span`1<System.Double>)
    IL_0027: ret

}
Span<sbyte> add(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4 143
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4 151
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4 159
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4 167
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4 175
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4 183
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4 191
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
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4 199
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
Span<float> add(Span<float> lhs, ReadOnlySpan<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4 207
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
    IL_0033: add
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
Span<double> add(Span<double> lhs, ReadOnlySpan<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\Add.cs"
    IL_000C: ldc.i4 215
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
    IL_0033: add
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
Span<float> add(Span<float> lhs, float rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.r4
    IL_000E: ldarg.1
    IL_000F: add
    IL_0010: stind.r4
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
Span<double> add(Span<double> lhs, double rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarga.s lhs
    IL_0006: ldloc.0
    IL_0007: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_000C: dup
    IL_000D: ldind.r8
    IL_000E: ldarg.1
    IL_000F: add
    IL_0010: stind.r8
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarga.s lhs
    IL_0018: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_001D: blt.s IL_0004
    IL_001F: ldarg.0
    IL_0020: ret

}
Span<sbyte> and(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\And.cs"
    IL_000C: ldc.i4.s 21
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
    IL_0037: call System.SByte Z0.math::and(System.SByte,System.SByte)
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
Span<byte> and(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "and"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\fused\\And.cs"
    IL_000C: ldc.i4.s 29
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
    IL_0037: call System.Byte Z0.math::and(System.Byte,System.Byte)
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
Quorem<long> quorem(in long lhs, in long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: ldarg.1
    IL_0003: ldind.i8
    IL_0004: ldloca.s V_0
    IL_0006: call System.Int64 System.Math::DivRem(System.Int64,System.Int64,System.Int64&)
    IL_000B: ldloc.0
    IL_000C: newobj System.Void System.ValueTuple`2<System.Int64,System.Int64>::.ctor(System.Int64,System.Int64)
    IL_0011: call Z0.Quorem`1<System.Int64> Z0.Quorem`1<System.Int64>::op_Implicit(System.ValueTuple`2<System.Int64,System.Int64>)
    IL_0016: ret

}
Quorem<ulong> quorem(in ulong lhs, in ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: ldarg.1
    IL_0003: ldind.i8
    IL_0004: call System.UInt64 Z0.math::div(System.UInt64,System.UInt64)
    IL_0009: stloc.0
    IL_000A: ldarg.0
    IL_000B: ldind.i8
    IL_000C: ldloc.0
    IL_000D: ldarg.1
    IL_000E: ldind.i8
    IL_000F: mul
    IL_0010: sub
    IL_0011: stloc.1
    IL_0012: ldloca.s V_0
    IL_0014: ldloca.s V_1
    IL_0016: call Z0.Quorem`1<System.UInt64> Z0.Quorem::define<System.UInt64>(System.UInt64&,System.UInt64&)
    IL_001B: ret

}
Quorem<float> quorem(in float lhs, in float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.r4
    IL_0002: ldarg.1
    IL_0003: ldind.r4
    IL_0004: call System.Single Z0.math::div(System.Single,System.Single)
    IL_0009: call System.Single Z0.math::floor(System.Single)
    IL_000E: stloc.0
    IL_000F: ldarg.0
    IL_0010: ldind.r4
    IL_0011: ldloc.0
    IL_0012: ldarg.1
    IL_0013: ldind.r4
    IL_0014: mul
    IL_0015: sub
    IL_0016: stloc.1
    IL_0017: ldloca.s V_0
    IL_0019: ldloca.s V_1
    IL_001B: call Z0.Quorem`1<System.Single> Z0.Quorem::define<System.Single>(System.Single&,System.Single&)
    IL_0020: ret

}
Quorem<double> quorem(in double lhs, in double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.r8
    IL_0002: ldarg.1
    IL_0003: ldind.r8
    IL_0004: call System.Double Z0.math::div(System.Double,System.Double)
    IL_0009: call System.Double Z0.math::floor(System.Double)
    IL_000E: stloc.0
    IL_000F: ldarg.0
    IL_0010: ldind.r8
    IL_0011: ldloc.0
    IL_0012: ldarg.1
    IL_0013: ldind.r8
    IL_0014: mul
    IL_0015: sub
    IL_0016: stloc.1
    IL_0017: ldloca.s V_0
    IL_0019: ldloca.s V_1
    IL_001B: call Z0.Quorem`1<System.Double> Z0.Quorem::define<System.Double>(System.Double&,System.Double&)
    IL_0020: ret

}
Quorem<Decimal> quorem(in Decimal lhs, in Decimal rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Decimal
    IL_0006: ldarg.1
    IL_0007: ldobj System.Decimal
    IL_000C: call System.Decimal Z0.math::div(System.Decimal,System.Decimal)
    IL_0011: stloc.0
    IL_0012: ldarg.0
    IL_0013: ldobj System.Decimal
    IL_0018: ldloc.0
    IL_0019: ldarg.1
    IL_001A: ldobj System.Decimal
    IL_001F: call System.Decimal System.Decimal::op_Multiply(System.Decimal,System.Decimal)
    IL_0024: call System.Decimal System.Decimal::op_Subtraction(System.Decimal,System.Decimal)
    IL_0029: stloc.1
    IL_002A: ldloca.s V_0
    IL_002C: ldloca.s V_1
    IL_002E: call Z0.Quorem`1<System.Decimal> Z0.Quorem::define<System.Decimal>(System.Decimal&,System.Decimal&)
    IL_0033: ret

}
Quorem<BigInteger> quorem(in BigInteger lhs, in BigInteger rhs)
{
    IL_0000: call System.Numerics.BigInteger System.Numerics.BigInteger::get_Zero()
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_0007: ldobj System.Numerics.BigInteger
    IL_000C: ldarg.1
    IL_000D: ldobj System.Numerics.BigInteger
    IL_0012: ldloca.s V_0
    IL_0014: call System.Numerics.BigInteger System.Numerics.BigInteger::DivRem(System.Numerics.BigInteger,System.Numerics.BigInteger,System.Numerics.BigInteger&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldloca.s V_0
    IL_001E: call Z0.Quorem`1<System.Numerics.BigInteger> Z0.Quorem::define<System.Numerics.BigInteger>(System.Numerics.BigInteger&,System.Numerics.BigInteger&)
    IL_0023: ret

}
ref Quorem<sbyte> quorem(in sbyte lhs, in sbyte rhs, out Quorem<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: call System.SByte& Z0.math::abs(System.SByte&,System.SByte&)
    IL_0008: pop
    IL_0009: ldarg.1
    IL_000A: ldloca.s V_1
    IL_000C: call System.SByte& Z0.math::abs(System.SByte&,System.SByte&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldloc.1
    IL_0014: div
    IL_0015: conv.i1
    IL_0016: stloc.2
    IL_0017: ldloc.0
    IL_0018: ldloc.2
    IL_0019: ldloc.1
    IL_001A: mul
    IL_001B: sub
    IL_001C: conv.i1
    IL_001D: stloc.3
    IL_001E: ldarg.2
    IL_001F: ldloca.s V_2
    IL_0021: ldloca.s V_3
    IL_0023: call Z0.Quorem`1<System.SByte> Z0.Quorem::define<System.SByte>(System.SByte&,System.SByte&)
    IL_0028: stobj Z0.Quorem`1<System.SByte>
    IL_002D: ldarg.2
    IL_002E: ret

}
ref Quorem<byte> quorem(in byte lhs, in byte rhs, out Quorem<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u1
    IL_0002: ldarg.1
    IL_0003: ldind.u1
    IL_0004: div
    IL_0005: conv.u1
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldind.u1
    IL_0009: ldloc.0
    IL_000A: ldarg.1
    IL_000B: ldind.u1
    IL_000C: mul
    IL_000D: sub
    IL_000E: conv.u1
    IL_000F: stloc.1
    IL_0010: ldarg.2
    IL_0011: ldloca.s V_0
    IL_0013: ldloca.s V_1
    IL_0015: call Z0.Quorem`1<System.Byte> Z0.Quorem::define<System.Byte>(System.Byte&,System.Byte&)
    IL_001A: stobj Z0.Quorem`1<System.Byte>
    IL_001F: ldarg.2
    IL_0020: ret

}
ref Quorem<short> quorem(in short lhs, in short rhs, out Quorem<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: call System.Int16& Z0.math::abs(System.Int16&,System.Int16&)
    IL_0008: pop
    IL_0009: ldarg.1
    IL_000A: ldloca.s V_1
    IL_000C: call System.Int16& Z0.math::abs(System.Int16&,System.Int16&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldloc.1
    IL_0014: div
    IL_0015: conv.i2
    IL_0016: stloc.2
    IL_0017: ldloc.0
    IL_0018: ldloc.2
    IL_0019: ldloc.1
    IL_001A: mul
    IL_001B: sub
    IL_001C: conv.i2
    IL_001D: stloc.3
    IL_001E: ldarg.2
    IL_001F: ldloca.s V_2
    IL_0021: ldloca.s V_3
    IL_0023: call Z0.Quorem`1<System.Int16> Z0.Quorem::define<System.Int16>(System.Int16&,System.Int16&)
    IL_0028: stobj Z0.Quorem`1<System.Int16>
    IL_002D: ldarg.2
    IL_002E: ret

}
ref Quorem<ushort> quorem(in ushort lhs, in ushort rhs, out Quorem<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u2
    IL_0002: ldarg.1
    IL_0003: ldind.u2
    IL_0004: div
    IL_0005: conv.u2
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: ldind.u2
    IL_0009: ldloc.0
    IL_000A: ldarg.1
    IL_000B: ldind.u2
    IL_000C: mul
    IL_000D: sub
    IL_000E: conv.u2
    IL_000F: stloc.1
    IL_0010: ldarg.2
    IL_0011: ldloca.s V_0
    IL_0013: ldloca.s V_1
    IL_0015: call Z0.Quorem`1<System.UInt16> Z0.Quorem::define<System.UInt16>(System.UInt16&,System.UInt16&)
    IL_001A: stobj Z0.Quorem`1<System.UInt16>
    IL_001F: ldarg.2
    IL_0020: ret

}
ref Quorem<int> quorem(in int lhs, in int rhs, out Quorem<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: call System.Int32& Z0.math::abs(System.Int32&,System.Int32&)
    IL_0008: pop
    IL_0009: ldarg.1
    IL_000A: ldloca.s V_1
    IL_000C: call System.Int32& Z0.math::abs(System.Int32&,System.Int32&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldloc.1
    IL_0014: div
    IL_0015: stloc.2
    IL_0016: ldloc.0
    IL_0017: ldloc.2
    IL_0018: ldloc.1
    IL_0019: mul
    IL_001A: sub
    IL_001B: stloc.3
    IL_001C: ldarg.2
    IL_001D: ldloca.s V_2
    IL_001F: ldloca.s V_3
    IL_0021: call Z0.Quorem`1<System.Int32> Z0.Quorem::define<System.Int32>(System.Int32&,System.Int32&)
    IL_0026: stobj Z0.Quorem`1<System.Int32>
    IL_002B: ldarg.2
    IL_002C: ret

}
ref Quorem<uint> quorem(in uint lhs, in uint rhs, out Quorem<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u4
    IL_0002: ldarg.1
    IL_0003: ldind.u4
    IL_0004: div.un
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_0007: ldind.u4
    IL_0008: ldloc.0
    IL_0009: ldarg.1
    IL_000A: ldind.u4
    IL_000B: mul
    IL_000C: sub
    IL_000D: stloc.1
    IL_000E: ldarg.2
    IL_000F: ldloca.s V_0
    IL_0011: ldloca.s V_1
    IL_0013: call Z0.Quorem`1<System.UInt32> Z0.Quorem::define<System.UInt32>(System.UInt32&,System.UInt32&)
    IL_0018: stobj Z0.Quorem`1<System.UInt32>
    IL_001D: ldarg.2
    IL_001E: ret

}
ref Quorem<long> quorem(in long lhs, in long rhs, out Quorem<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: call System.Int64& Z0.math::abs(System.Int64&,System.Int64&)
    IL_0008: pop
    IL_0009: ldarg.1
    IL_000A: ldloca.s V_1
    IL_000C: call System.Int64& Z0.math::abs(System.Int64&,System.Int64&)
    IL_0011: pop
    IL_0012: ldloc.0
    IL_0013: ldloc.1
    IL_0014: div
    IL_0015: stloc.2
    IL_0016: ldloc.0
    IL_0017: ldloc.2
    IL_0018: ldloc.1
    IL_0019: mul
    IL_001A: sub
    IL_001B: stloc.3
    IL_001C: ldarg.2
    IL_001D: ldloca.s V_2
    IL_001F: ldloca.s V_3
    IL_0021: call Z0.Quorem`1<System.Int64> Z0.Quorem::define<System.Int64>(System.Int64&,System.Int64&)
    IL_0026: stobj Z0.Quorem`1<System.Int64>
    IL_002B: ldarg.2
    IL_002C: ret

}
ref Quorem<ulong> quorem(in ulong lhs, in ulong rhs, out Quorem<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: ldarg.1
    IL_0003: ldind.i8
    IL_0004: div.un
    IL_0005: stloc.0
    IL_0006: ldarg.0
    IL_0007: ldind.i8
    IL_0008: ldloc.0
    IL_0009: ldarg.1
    IL_000A: ldind.i8
    IL_000B: mul
    IL_000C: sub
    IL_000D: stloc.1
    IL_000E: ldarg.2
    IL_000F: ldloca.s V_0
    IL_0011: ldloca.s V_1
    IL_0013: call Z0.Quorem`1<System.UInt64> Z0.Quorem::define<System.UInt64>(System.UInt64&,System.UInt64&)
    IL_0018: stobj Z0.Quorem`1<System.UInt64>
    IL_001D: ldarg.2
    IL_001E: ret

}
float relerr(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ldarg.0
    IL_0004: div
    IL_0005: call System.Single Z0.math::abs(System.Single)
    IL_000A: ret

}
double relerr(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ldarg.0
    IL_0004: div
    IL_0005: call System.Double Z0.math::abs(System.Double)
    IL_000A: ret

}
float relerr(ComplexF32 lhs, ComplexF32 rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Single Z0.ComplexF32::re
    IL_0006: ldarg.1
    IL_0007: ldfld System.Single Z0.ComplexF32::re
    IL_000C: call System.Single Z0.math::relerr(System.Single,System.Single)
    IL_0011: stloc.0
    IL_0012: ldarg.0
    IL_0013: ldfld System.Single Z0.ComplexF32::im
    IL_0018: ldarg.1
    IL_0019: ldfld System.Single Z0.ComplexF32::im
    IL_001E: call System.Single Z0.math::relerr(System.Single,System.Single)
    IL_0023: stloc.1
    IL_0024: ldloc.0
    IL_0025: ldloc.1
    IL_0026: bgt.s IL_002A
    IL_0028: ldloc.1
    IL_0029: ret
    IL_002A: ldloc.0
    IL_002B: ret

}
double relerr(ComplexF64 lhs, ComplexF64 rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Double Z0.ComplexF64::re
    IL_0006: ldarg.1
    IL_0007: ldfld System.Double Z0.ComplexF64::re
    IL_000C: call System.Double Z0.math::relerr(System.Double,System.Double)
    IL_0011: stloc.0
    IL_0012: ldarg.0
    IL_0013: ldfld System.Double Z0.ComplexF64::im
    IL_0018: ldarg.1
    IL_0019: ldfld System.Double Z0.ComplexF64::im
    IL_001E: call System.Double Z0.math::relerr(System.Double,System.Double)
    IL_0023: stloc.1
    IL_0024: ldloc.0
    IL_0025: ldloc.1
    IL_0026: bgt.s IL_002A
    IL_0028: ldloc.1
    IL_0029: ret
    IL_002A: ldloc.0
    IL_002B: ret

}
float round(float src, int scale)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single System.MathF::Round(System.Single,System.Int32)
    IL_0007: ret

}
double round(double src, int scale)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double System.Math::Round(System.Double,System.Int32)
    IL_0007: ret

}
ref float round(ref float src, int scale)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: ldarg.1
    IL_0004: call System.Single System.MathF::Round(System.Single,System.Int32)
    IL_0009: stind.r4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref double round(ref double src, int scale)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldarg.1
    IL_0004: call System.Double System.Math::Round(System.Double,System.Int32)
    IL_0009: stind.r8
    IL_000A: ldarg.0
    IL_000B: ret

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
ref sbyte shiftl(ref sbyte lhs, int rhs)
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
ref byte shiftl(ref byte lhs, int rhs)
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
ref short shiftl(ref short lhs, int rhs)
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
ref ushort shiftl(ref ushort lhs, int rhs)
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
ref int shiftl(ref int lhs, int rhs)
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
ref uint shiftl(ref uint lhs, int rhs)
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
ref long shiftl(ref long lhs, int rhs)
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
ref ulong shiftl(ref ulong lhs, int rhs)
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
sbyte shiftr(sbyte lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr
    IL_0006: conv.i1
    IL_0007: ret

}
byte shiftr(byte lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr
    IL_0006: conv.u1
    IL_0007: ret

}
short shiftr(short lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr
    IL_0006: conv.i2
    IL_0007: ret

}
ushort shiftr(ushort lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr
    IL_0006: conv.u2
    IL_0007: ret

}
int shiftr(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr
    IL_0006: ret

}
uint shiftr(uint lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr.un
    IL_0006: ret

}
long shiftr(long lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 63
    IL_0004: and
    IL_0005: shr
    IL_0006: ret

}
ulong shiftr(ulong lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 63
    IL_0004: and
    IL_0005: shr.un
    IL_0006: ret

}
ref sbyte shiftr(ref sbyte lhs, int rhs)
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
ref byte shiftr(ref byte lhs, int rhs)
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
ref short shiftr(ref short lhs, int rhs)
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
ref ushort shiftr(ref ushort lhs, int rhs)
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
ref int shiftr(ref int lhs, int rhs)
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
ref uint shiftr(ref uint lhs, int rhs)
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
ref long shiftr(ref long lhs, int rhs)
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
ref ulong shiftr(ref ulong lhs, int rhs)
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
sbyte sqrt(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r4
    IL_0002: call System.Single System.MathF::Sqrt(System.Single)
    IL_0007: conv.i1
    IL_0008: ret

}
byte sqrt(byte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r4
    IL_0002: call System.Single System.MathF::Sqrt(System.Single)
    IL_0007: conv.u1
    IL_0008: ret

}
short sqrt(short src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r4
    IL_0002: call System.Single System.MathF::Sqrt(System.Single)
    IL_0007: conv.i2
    IL_0008: ret

}
ushort sqrt(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r4
    IL_0002: call System.Single System.MathF::Sqrt(System.Single)
    IL_0007: conv.u2
    IL_0008: ret

}
int sqrt(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r4
    IL_0002: call System.Single System.MathF::Sqrt(System.Single)
    IL_0007: conv.i4
    IL_0008: ret

}
uint sqrt(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r.un
    IL_0002: conv.r4
    IL_0003: call System.Single System.MathF::Sqrt(System.Single)
    IL_0008: conv.u4
    IL_0009: ret

}
long sqrt(long src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: call System.Double System.Math::Sqrt(System.Double)
    IL_0007: conv.i8
    IL_0008: ret

}
ulong sqrt(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r.un
    IL_0002: conv.r8
    IL_0003: call System.Double System.Math::Sqrt(System.Double)
    IL_0008: conv.u8
    IL_0009: ret

}
float sqrt(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Sqrt(System.Single)
    IL_0006: ret

}
double sqrt(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Sqrt(System.Double)
    IL_0006: ret

}
ref sbyte sqrt(ref sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: conv.r4
    IL_0004: call System.Single System.MathF::Sqrt(System.Single)
    IL_0009: conv.i1
    IL_000A: stind.i1
    IL_000B: ldarg.0
    IL_000C: ret

}
ref byte sqrt(ref byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: conv.r4
    IL_0004: call System.Single System.MathF::Sqrt(System.Single)
    IL_0009: conv.u1
    IL_000A: stind.i1
    IL_000B: ldarg.0
    IL_000C: ret

}
ref short sqrt(ref short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: conv.r4
    IL_0004: call System.Single System.MathF::Sqrt(System.Single)
    IL_0009: conv.i2
    IL_000A: stind.i2
    IL_000B: ldarg.0
    IL_000C: ret

}
ref ushort sqrt(ref ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: conv.r4
    IL_0004: call System.Single System.MathF::Sqrt(System.Single)
    IL_0009: conv.u2
    IL_000A: stind.i2
    IL_000B: ldarg.0
    IL_000C: ret

}
ref int sqrt(ref int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: conv.r4
    IL_0004: call System.Single System.MathF::Sqrt(System.Single)
    IL_0009: conv.i4
    IL_000A: stind.i4
    IL_000B: ldarg.0
    IL_000C: ret

}
ref uint sqrt(ref uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: conv.r.un
    IL_0004: conv.r4
    IL_0005: call System.Single System.MathF::Sqrt(System.Single)
    IL_000A: conv.u4
    IL_000B: stind.i4
    IL_000C: ldarg.0
    IL_000D: ret

}
ref long sqrt(ref long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: conv.r8
    IL_0004: call System.Double System.Math::Sqrt(System.Double)
    IL_0009: conv.i8
    IL_000A: stind.i8
    IL_000B: ldarg.0
    IL_000C: ret

}
ref ulong sqrt(ref ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: conv.r.un
    IL_0004: conv.r8
    IL_0005: call System.Double System.Math::Sqrt(System.Double)
    IL_000A: conv.u8
    IL_000B: stind.i8
    IL_000C: ldarg.0
    IL_000D: ret

}
ref float sqrt(ref float src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: call System.Single System.MathF::Sqrt(System.Single)
    IL_0008: stind.r4
    IL_0009: ldarg.0
    IL_000A: ret

}
ref double sqrt(ref double src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: call System.Double System.Math::Sqrt(System.Double)
    IL_0008: stind.r8
    IL_0009: ldarg.0
    IL_000A: ret

}
ref sbyte sqrt(sbyte src, out sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.SByte& Z0.math::sqrt(System.SByte&)
    IL_0008: ldind.i1
    IL_0009: stind.i1
    IL_000A: ldarg.1
    IL_000B: ret

}
ref byte sqrt(byte src, out byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.Byte& Z0.math::sqrt(System.Byte&)
    IL_0008: ldind.u1
    IL_0009: stind.i1
    IL_000A: ldarg.1
    IL_000B: ret

}
ref short sqrt(short src, out short dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.Int16& Z0.math::sqrt(System.Int16&)
    IL_0008: ldind.i2
    IL_0009: stind.i2
    IL_000A: ldarg.1
    IL_000B: ret

}
ref ushort sqrt(ushort src, out ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.UInt16& Z0.math::sqrt(System.UInt16&)
    IL_0008: ldind.u2
    IL_0009: stind.i2
    IL_000A: ldarg.1
    IL_000B: ret

}
ref int sqrt(int src, out int dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.Int32& Z0.math::sqrt(System.Int32&)
    IL_0008: ldind.i4
    IL_0009: stind.i4
    IL_000A: ldarg.1
    IL_000B: ret

}
ref uint sqrt(uint src, out uint dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.UInt32& Z0.math::sqrt(System.UInt32&)
    IL_0008: ldind.u4
    IL_0009: stind.i4
    IL_000A: ldarg.1
    IL_000B: ret

}
ref long sqrt(long src, out long dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.Int64& Z0.math::sqrt(System.Int64&)
    IL_0008: ldind.i8
    IL_0009: stind.i8
    IL_000A: ldarg.1
    IL_000B: ret

}
ref ulong sqrt(ulong src, out ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.UInt64& Z0.math::sqrt(System.UInt64&)
    IL_0008: ldind.i8
    IL_0009: stind.i8
    IL_000A: ldarg.1
    IL_000B: ret

}
ref float sqrt(float src, out float dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.Single& Z0.math::sqrt(System.Single&)
    IL_0008: ldind.r4
    IL_0009: stind.r4
    IL_000A: ldarg.1
    IL_000B: ret

}
ref double sqrt(double src, out double dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.Double& Z0.math::sqrt(System.Double&)
    IL_0008: ldind.r8
    IL_0009: stind.r8
    IL_000A: ldarg.1
    IL_000B: ret

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
ref float mod(ref float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: ldarg.1
    IL_0004: rem
    IL_0005: stind.r4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref double mod(ref double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldarg.1
    IL_0004: rem
    IL_0005: stind.r8
    IL_0006: ldarg.0
    IL_0007: ret

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
sbyte or(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: conv.i1
    IL_0004: ret

}
sbyte or(sbyte x1, sbyte x2, SByte[] more)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.SByte Z0.math::or(System.SByte,System.SByte)
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0017
    IL_000C: ldloc.0
    IL_000D: ldarg.2
    IL_000E: ldloc.1
    IL_000F: ldelem.i1
    IL_0010: or
    IL_0011: conv.i1
    IL_0012: stloc.0
    IL_0013: ldloc.1
    IL_0014: ldc.i4.1
    IL_0015: add
    IL_0016: stloc.1
    IL_0017: ldloc.1
    IL_0018: ldarg.2
    IL_0019: ldlen
    IL_001A: conv.i4
    IL_001B: blt.s IL_000C
    IL_001D: ldloc.0
    IL_001E: ret

}
byte or(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: conv.u1
    IL_0004: ret

}
byte or(byte x1, byte x2, Byte[] more)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.math::or(System.Byte,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0017
    IL_000C: ldloc.0
    IL_000D: ldarg.2
    IL_000E: ldloc.1
    IL_000F: ldelem.u1
    IL_0010: or
    IL_0011: conv.u1
    IL_0012: stloc.0
    IL_0013: ldloc.1
    IL_0014: ldc.i4.1
    IL_0015: add
    IL_0016: stloc.1
    IL_0017: ldloc.1
    IL_0018: ldarg.2
    IL_0019: ldlen
    IL_001A: conv.i4
    IL_001B: blt.s IL_000C
    IL_001D: ldloc.0
    IL_001E: ret

}
short or(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: conv.i2
    IL_0004: ret

}
short or(short x1, short x2, Int16[] more)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int16 Z0.math::or(System.Int16,System.Int16)
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0017
    IL_000C: ldloc.0
    IL_000D: ldarg.2
    IL_000E: ldloc.1
    IL_000F: ldelem.i2
    IL_0010: or
    IL_0011: conv.i2
    IL_0012: stloc.0
    IL_0013: ldloc.1
    IL_0014: ldc.i4.1
    IL_0015: add
    IL_0016: stloc.1
    IL_0017: ldloc.1
    IL_0018: ldarg.2
    IL_0019: ldlen
    IL_001A: conv.i4
    IL_001B: blt.s IL_000C
    IL_001D: ldloc.0
    IL_001E: ret

}
ushort or(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: conv.u2
    IL_0004: ret

}
ushort or(ushort x1, ushort x2, UInt16[] more)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16 Z0.math::or(System.UInt16,System.UInt16)
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0017
    IL_000C: ldloc.0
    IL_000D: ldarg.2
    IL_000E: ldloc.1
    IL_000F: ldelem.u2
    IL_0010: or
    IL_0011: conv.u2
    IL_0012: stloc.0
    IL_0013: ldloc.1
    IL_0014: ldc.i4.1
    IL_0015: add
    IL_0016: stloc.1
    IL_0017: ldloc.1
    IL_0018: ldarg.2
    IL_0019: ldlen
    IL_001A: conv.i4
    IL_001B: blt.s IL_000C
    IL_001D: ldloc.0
    IL_001E: ret

}
int or(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
int or(int x1, int x2, Int32[] more)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int32 Z0.math::or(System.Int32,System.Int32)
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0016
    IL_000C: ldloc.0
    IL_000D: ldarg.2
    IL_000E: ldloc.1
    IL_000F: ldelem.i4
    IL_0010: or
    IL_0011: stloc.0
    IL_0012: ldloc.1
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.1
    IL_0016: ldloc.1
    IL_0017: ldarg.2
    IL_0018: ldlen
    IL_0019: conv.i4
    IL_001A: blt.s IL_000C
    IL_001C: ldloc.0
    IL_001D: ret

}
uint or(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
uint or(uint x1, uint x2, UInt32[] more)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.math::or(System.UInt32,System.UInt32)
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0016
    IL_000C: ldloc.0
    IL_000D: ldarg.2
    IL_000E: ldloc.1
    IL_000F: ldelem.u4
    IL_0010: or
    IL_0011: stloc.0
    IL_0012: ldloc.1
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.1
    IL_0016: ldloc.1
    IL_0017: ldarg.2
    IL_0018: ldlen
    IL_0019: conv.i4
    IL_001A: blt.s IL_000C
    IL_001C: ldloc.0
    IL_001D: ret

}
long or(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
long or(long x1, long x2, Int64[] more)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int64 Z0.math::or(System.Int64,System.Int64)
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0016
    IL_000C: ldloc.0
    IL_000D: ldarg.2
    IL_000E: ldloc.1
    IL_000F: ldelem.i8
    IL_0010: or
    IL_0011: stloc.0
    IL_0012: ldloc.1
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.1
    IL_0016: ldloc.1
    IL_0017: ldarg.2
    IL_0018: ldlen
    IL_0019: conv.i4
    IL_001A: blt.s IL_000C
    IL_001C: ldloc.0
    IL_001D: ret

}
ulong or(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
ulong or(ulong x1, ulong x2, UInt64[] more)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::or(System.UInt64,System.UInt64)
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0016
    IL_000C: ldloc.0
    IL_000D: ldarg.2
    IL_000E: ldloc.1
    IL_000F: ldelem.i8
    IL_0010: or
    IL_0011: stloc.0
    IL_0012: ldloc.1
    IL_0013: ldc.i4.1
    IL_0014: add
    IL_0015: stloc.1
    IL_0016: ldloc.1
    IL_0017: ldarg.2
    IL_0018: ldlen
    IL_0019: conv.i4
    IL_001A: blt.s IL_000C
    IL_001C: ldloc.0
    IL_001D: ret

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
sbyte pow(sbyte b, sbyte exp)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: bge.s IL_0006
    IL_0004: ldc.i4.0
    IL_0005: ret
    IL_0006: ldc.i4.1
    IL_0007: stloc.0
    IL_0008: ldarg.1
    IL_0009: ldc.i4.1
    IL_000A: and
    IL_000B: brfalse.s IL_0012
    IL_000D: ldloc.0
    IL_000E: ldarg.0
    IL_000F: mul
    IL_0010: conv.i1
    IL_0011: stloc.0
    IL_0012: ldarg.1
    IL_0013: ldc.i4.1
    IL_0014: shr
    IL_0015: conv.i1
    IL_0016: starg.s exp
    IL_0018: ldarg.1
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.0
    IL_001D: mul
    IL_001E: conv.i1
    IL_001F: starg.s b
    IL_0021: br.s IL_0008
    IL_0023: ldloc.0
    IL_0024: ret

}
byte pow(byte b, byte exp)
{
    IL_0000: ldc.i4.1
    IL_0001: stloc.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.1
    IL_0004: and
    IL_0005: brfalse.s IL_000C
    IL_0007: ldloc.0
    IL_0008: ldarg.0
    IL_0009: mul
    IL_000A: conv.u1
    IL_000B: stloc.0
    IL_000C: ldarg.1
    IL_000D: ldc.i4.1
    IL_000E: shr
    IL_000F: conv.u1
    IL_0010: starg.s exp
    IL_0012: ldarg.1
    IL_0013: brfalse.s IL_001D
    IL_0015: ldarg.0
    IL_0016: ldarg.0
    IL_0017: mul
    IL_0018: conv.u1
    IL_0019: starg.s b
    IL_001B: br.s IL_0002
    IL_001D: ldloc.0
    IL_001E: ret

}
short pow(short b, short exp)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: bge.s IL_0006
    IL_0004: ldc.i4.0
    IL_0005: ret
    IL_0006: ldc.i4.1
    IL_0007: stloc.0
    IL_0008: ldarg.1
    IL_0009: ldc.i4.1
    IL_000A: and
    IL_000B: brfalse.s IL_0012
    IL_000D: ldloc.0
    IL_000E: ldarg.0
    IL_000F: mul
    IL_0010: conv.i2
    IL_0011: stloc.0
    IL_0012: ldarg.1
    IL_0013: ldc.i4.1
    IL_0014: shr
    IL_0015: conv.i2
    IL_0016: starg.s exp
    IL_0018: ldarg.1
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.0
    IL_001D: mul
    IL_001E: conv.i2
    IL_001F: starg.s b
    IL_0021: br.s IL_0008
    IL_0023: ldloc.0
    IL_0024: ret

}
ushort pow(ushort b, ushort exp)
{
    IL_0000: ldc.i4.1
    IL_0001: stloc.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.1
    IL_0004: and
    IL_0005: brfalse.s IL_000C
    IL_0007: ldloc.0
    IL_0008: ldarg.0
    IL_0009: mul
    IL_000A: conv.u2
    IL_000B: stloc.0
    IL_000C: ldarg.1
    IL_000D: ldc.i4.1
    IL_000E: shr
    IL_000F: conv.u2
    IL_0010: starg.s exp
    IL_0012: ldarg.1
    IL_0013: brfalse.s IL_001D
    IL_0015: ldarg.0
    IL_0016: ldarg.0
    IL_0017: mul
    IL_0018: conv.u2
    IL_0019: starg.s b
    IL_001B: br.s IL_0002
    IL_001D: ldloc.0
    IL_001E: ret

}
int pow(int b, int exp)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: bge.s IL_0006
    IL_0004: ldc.i4.0
    IL_0005: ret
    IL_0006: ldc.i4.1
    IL_0007: stloc.0
    IL_0008: ldarg.1
    IL_0009: ldc.i4.1
    IL_000A: and
    IL_000B: brfalse.s IL_0011
    IL_000D: ldloc.0
    IL_000E: ldarg.0
    IL_000F: mul
    IL_0010: stloc.0
    IL_0011: ldarg.1
    IL_0012: ldc.i4.1
    IL_0013: shr
    IL_0014: starg.s exp
    IL_0016: ldarg.1
    IL_0017: brfalse.s IL_0020
    IL_0019: ldarg.0
    IL_001A: ldarg.0
    IL_001B: mul
    IL_001C: starg.s b
    IL_001E: br.s IL_0008
    IL_0020: ldloc.0
    IL_0021: ret

}
uint pow(uint b, uint exp)
{
    IL_0000: ldc.i4.1
    IL_0001: stloc.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.1
    IL_0004: and
    IL_0005: brfalse.s IL_000B
    IL_0007: ldloc.0
    IL_0008: ldarg.0
    IL_0009: mul
    IL_000A: stloc.0
    IL_000B: ldarg.1
    IL_000C: ldc.i4.1
    IL_000D: shr.un
    IL_000E: starg.s exp
    IL_0010: ldarg.1
    IL_0011: brfalse.s IL_001A
    IL_0013: ldarg.0
    IL_0014: ldarg.0
    IL_0015: mul
    IL_0016: starg.s b
    IL_0018: br.s IL_0002
    IL_001A: ldloc.0
    IL_001B: ret

}
long pow(long b, long exp)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: conv.i8
    IL_0003: bge.s IL_0008
    IL_0005: ldc.i4.0
    IL_0006: conv.i8
    IL_0007: ret
    IL_0008: ldc.i4.1
    IL_0009: conv.i8
    IL_000A: stloc.0
    IL_000B: ldarg.1
    IL_000C: ldc.i4.1
    IL_000D: conv.i8
    IL_000E: and
    IL_000F: brfalse.s IL_0015
    IL_0011: ldloc.0
    IL_0012: ldarg.0
    IL_0013: mul
    IL_0014: stloc.0
    IL_0015: ldarg.1
    IL_0016: ldc.i4.1
    IL_0017: shr
    IL_0018: starg.s exp
    IL_001A: ldarg.1
    IL_001B: brfalse.s IL_0024
    IL_001D: ldarg.0
    IL_001E: ldarg.0
    IL_001F: mul
    IL_0020: starg.s b
    IL_0022: br.s IL_000B
    IL_0024: ldloc.0
    IL_0025: ret

}
ulong pow(ulong b, ulong exp)
{
    IL_0000: ldc.i4.1
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldarg.1
    IL_0004: ldc.i4.1
    IL_0005: conv.i8
    IL_0006: and
    IL_0007: brfalse.s IL_000D
    IL_0009: ldloc.0
    IL_000A: ldarg.0
    IL_000B: mul
    IL_000C: stloc.0
    IL_000D: ldarg.1
    IL_000E: ldc.i4.1
    IL_000F: shr.un
    IL_0010: starg.s exp
    IL_0012: ldarg.1
    IL_0013: brfalse.s IL_001C
    IL_0015: ldarg.0
    IL_0016: ldarg.0
    IL_0017: mul
    IL_0018: starg.s b
    IL_001A: br.s IL_0003
    IL_001C: ldloc.0
    IL_001D: ret

}
float pow(float src, float exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single System.MathF::Pow(System.Single,System.Single)
    IL_0007: ret

}
double pow(double src, double exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double System.Math::Pow(System.Double,System.Double)
    IL_0007: ret

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
Quorem<sbyte> quorem(in sbyte lhs, in sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i1
    IL_0002: call System.SByte Z0.math::abs(System.SByte)
    IL_0007: stloc.0
    IL_0008: ldarg.1
    IL_0009: ldind.i1
    IL_000A: call System.SByte Z0.math::abs(System.SByte)
    IL_000F: stloc.1
    IL_0010: ldloc.0
    IL_0011: ldloc.1
    IL_0012: call System.SByte Z0.math::div(System.SByte,System.SByte)
    IL_0017: stloc.2
    IL_0018: ldloc.0
    IL_0019: ldloc.2
    IL_001A: ldloc.1
    IL_001B: mul
    IL_001C: sub
    IL_001D: conv.i1
    IL_001E: stloc.3
    IL_001F: ldloca.s V_2
    IL_0021: ldloca.s V_3
    IL_0023: call Z0.Quorem`1<System.SByte> Z0.Quorem::define<System.SByte>(System.SByte&,System.SByte&)
    IL_0028: ret

}
Quorem<byte> quorem(in byte lhs, in byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u1
    IL_0002: ldarg.1
    IL_0003: ldind.u1
    IL_0004: call System.Byte Z0.math::div(System.Byte,System.Byte)
    IL_0009: stloc.0
    IL_000A: ldarg.0
    IL_000B: ldind.u1
    IL_000C: ldloc.0
    IL_000D: ldarg.1
    IL_000E: ldind.u1
    IL_000F: mul
    IL_0010: sub
    IL_0011: conv.u1
    IL_0012: stloc.1
    IL_0013: ldloca.s V_0
    IL_0015: ldloca.s V_1
    IL_0017: call Z0.Quorem`1<System.Byte> Z0.Quorem::define<System.Byte>(System.Byte&,System.Byte&)
    IL_001C: ret

}
Quorem<short> quorem(in short lhs, in short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i2
    IL_0002: call System.Int16 Z0.math::abs(System.Int16)
    IL_0007: stloc.0
    IL_0008: ldarg.1
    IL_0009: ldind.i2
    IL_000A: call System.Int16 Z0.math::abs(System.Int16)
    IL_000F: stloc.1
    IL_0010: ldloc.0
    IL_0011: ldloc.1
    IL_0012: call System.Int16 Z0.math::div(System.Int16,System.Int16)
    IL_0017: stloc.2
    IL_0018: ldloc.0
    IL_0019: ldloc.2
    IL_001A: ldloc.1
    IL_001B: mul
    IL_001C: sub
    IL_001D: conv.i2
    IL_001E: stloc.3
    IL_001F: ldloca.s V_2
    IL_0021: ldloca.s V_3
    IL_0023: call Z0.Quorem`1<System.Int16> Z0.Quorem::define<System.Int16>(System.Int16&,System.Int16&)
    IL_0028: ret

}
Quorem<ushort> quorem(in ushort lhs, in ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u2
    IL_0002: ldarg.1
    IL_0003: ldind.u2
    IL_0004: call System.UInt16 Z0.math::div(System.UInt16,System.UInt16)
    IL_0009: stloc.0
    IL_000A: ldarg.0
    IL_000B: ldind.u2
    IL_000C: ldloc.0
    IL_000D: ldarg.1
    IL_000E: ldind.u2
    IL_000F: mul
    IL_0010: sub
    IL_0011: conv.u2
    IL_0012: stloc.1
    IL_0013: ldloca.s V_0
    IL_0015: ldloca.s V_1
    IL_0017: call Z0.Quorem`1<System.UInt16> Z0.Quorem::define<System.UInt16>(System.UInt16&,System.UInt16&)
    IL_001C: ret

}
Quorem<int> quorem(in int lhs, in int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i4
    IL_0002: ldarg.1
    IL_0003: ldind.i4
    IL_0004: ldloca.s V_0
    IL_0006: call System.Int32 System.Math::DivRem(System.Int32,System.Int32,System.Int32&)
    IL_000B: ldloc.0
    IL_000C: newobj System.Void System.ValueTuple`2<System.Int32,System.Int32>::.ctor(System.Int32,System.Int32)
    IL_0011: call Z0.Quorem`1<System.Int32> Z0.Quorem`1<System.Int32>::op_Implicit(System.ValueTuple`2<System.Int32,System.Int32>)
    IL_0016: ret

}
Quorem<uint> quorem(in uint lhs, in uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u4
    IL_0002: ldarg.1
    IL_0003: ldind.u4
    IL_0004: call System.UInt32 Z0.math::div(System.UInt32,System.UInt32)
    IL_0009: stloc.0
    IL_000A: ldarg.0
    IL_000B: ldind.u4
    IL_000C: ldloc.0
    IL_000D: ldarg.1
    IL_000E: ldind.u4
    IL_000F: mul
    IL_0010: sub
    IL_0011: stloc.1
    IL_0012: ldloca.s V_0
    IL_0014: ldloca.s V_1
    IL_0016: call Z0.Quorem`1<System.UInt32> Z0.Quorem::define<System.UInt32>(System.UInt32&,System.UInt32&)
    IL_001B: ret

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
bool gteq(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt.un
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool gteq(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt.un
    IL_0004: ldc.i4.0
    IL_0005: ceq
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
float inc(float src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r4 1
    IL_0006: add
    IL_0007: dup
    IL_0008: starg.s src
    IL_000A: ret

}
double inc(double src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r8 1
    IL_000A: add
    IL_000B: dup
    IL_000C: starg.s src
    IL_000E: ret

}
ref sbyte inc(sbyte src, out sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: conv.i1
    IL_0005: dup
    IL_0006: starg.s src
    IL_0008: stind.i1
    IL_0009: ldarg.1
    IL_000A: ret

}
ref byte inc(byte src, out byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: conv.u1
    IL_0005: dup
    IL_0006: starg.s src
    IL_0008: stind.i1
    IL_0009: ldarg.1
    IL_000A: ret

}
ref short inc(short src, out short dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: conv.i2
    IL_0005: dup
    IL_0006: starg.s src
    IL_0008: stind.i2
    IL_0009: ldarg.1
    IL_000A: ret

}
ref ushort inc(ushort src, out ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: conv.u2
    IL_0005: dup
    IL_0006: starg.s src
    IL_0008: stind.i2
    IL_0009: ldarg.1
    IL_000A: ret

}
ref int inc(int src, out int dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: stind.i4
    IL_0008: ldarg.1
    IL_0009: ret

}
ref uint inc(uint src, out uint dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: stind.i4
    IL_0008: ldarg.1
    IL_0009: ret

}
ref long inc(long src, out long dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: conv.i8
    IL_0004: add
    IL_0005: dup
    IL_0006: starg.s src
    IL_0008: stind.i8
    IL_0009: ldarg.1
    IL_000A: ret

}
ref ulong inc(ulong src, out ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: conv.i8
    IL_0004: add
    IL_0005: dup
    IL_0006: starg.s src
    IL_0008: stind.i8
    IL_0009: ldarg.1
    IL_000A: ret

}
ref float inc(float src, out float dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.r4 1
    IL_0007: add
    IL_0008: dup
    IL_0009: starg.s src
    IL_000B: stind.r4
    IL_000C: ldarg.1
    IL_000D: ret

}
ref double inc(double src, out double dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.r8 1
    IL_000B: add
    IL_000C: dup
    IL_000D: starg.s src
    IL_000F: stind.r8
    IL_0010: ldarg.1
    IL_0011: ret

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
ref float inc(ref float src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: ldc.r4 1
    IL_0008: add
    IL_0009: stind.r4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref double inc(ref double src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldc.r8 1
    IL_000C: add
    IL_000D: stind.r8
    IL_000E: ldarg.0
    IL_000F: ret

}
float ldexp(float x, int i)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r4 2
    IL_0006: ldarg.1
    IL_0007: conv.r4
    IL_0008: call System.Single System.MathF::Pow(System.Single,System.Single)
    IL_000D: mul
    IL_000E: ret

}
double ldexp(double x, int i)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r8 2
    IL_000A: ldarg.1
    IL_000B: conv.r8
    IL_000C: call System.Double System.Math::Pow(System.Double,System.Double)
    IL_0011: mul
    IL_0012: ret

}
sbyte log2(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: call System.Int32 System.Math::ILogB(System.Double)
    IL_0007: conv.i1
    IL_0008: ret

}
byte log2(byte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: call System.Int32 System.Math::ILogB(System.Double)
    IL_0007: conv.u1
    IL_0008: ret

}
short log2(short src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: call System.Int32 System.Math::ILogB(System.Double)
    IL_0007: conv.i2
    IL_0008: ret

}
ushort log2(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: call System.Int32 System.Math::ILogB(System.Double)
    IL_0007: conv.u2
    IL_0008: ret

}
int log2(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: call System.Int32 System.Math::ILogB(System.Double)
    IL_0007: ret

}
uint log2(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r.un
    IL_0002: conv.r8
    IL_0003: call System.Int32 System.Math::ILogB(System.Double)
    IL_0008: ret

}
long log2(long src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: call System.Int32 System.Math::ILogB(System.Double)
    IL_0007: conv.i8
    IL_0008: ret

}
ulong log2(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r.un
    IL_0002: conv.r8
    IL_0003: call System.Int32 System.Math::ILogB(System.Double)
    IL_0008: conv.i8
    IL_0009: ret

}
float log2(float src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: call System.Int32 System.Math::ILogB(System.Double)
    IL_0007: conv.r4
    IL_0008: ret

}
double log2(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 System.Math::ILogB(System.Double)
    IL_0006: conv.r8
    IL_0007: ret

}
sbyte ln(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: call System.Double System.Math::Log(System.Double)
    IL_0007: conv.i1
    IL_0008: ret

}
byte ln(byte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: call System.Double System.Math::Log(System.Double)
    IL_0007: conv.u1
    IL_0008: ret

}
short ln(short src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: call System.Double System.Math::Log(System.Double)
    IL_0007: conv.i2
    IL_0008: ret

}
ushort ln(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: call System.Double System.Math::Log(System.Double)
    IL_0007: conv.u2
    IL_0008: ret

}
int ln(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: call System.Double System.Math::Log(System.Double)
    IL_0007: conv.i4
    IL_0008: ret

}
uint ln(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r.un
    IL_0002: conv.r8
    IL_0003: call System.Double System.Math::Log(System.Double)
    IL_0008: conv.u4
    IL_0009: ret

}
long ln(long src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: call System.Double System.Math::Log(System.Double)
    IL_0007: conv.i8
    IL_0008: ret

}
ulong ln(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r.un
    IL_0002: conv.r8
    IL_0003: call System.Double System.Math::Log(System.Double)
    IL_0008: conv.u8
    IL_0009: ret

}
float ln(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Log(System.Single)
    IL_0006: ret

}
double ln(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Log(System.Double)
    IL_0006: ret

}
sbyte log(sbyte src, sbyte base)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: ldarg.1
    IL_0003: stloc.0
    IL_0004: ldloca.s V_0
    IL_0006: call System.Boolean System.Nullable`1<System.SByte>::get_HasValue()
    IL_000B: brtrue.s IL_0011
    IL_000D: ldc.i4.s 10
    IL_000F: br.s IL_0018
    IL_0011: ldloca.s V_0
    IL_0013: call System.SByte System.Nullable`1<System.SByte>::GetValueOrDefault()
    IL_0018: conv.r8
    IL_0019: call System.Double System.Math::Log(System.Double,System.Double)
    IL_001E: conv.i1
    IL_001F: ret

}
byte log(byte src, byte base)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: ldarg.1
    IL_0003: stloc.0
    IL_0004: ldloca.s V_0
    IL_0006: call System.Boolean System.Nullable`1<System.Byte>::get_HasValue()
    IL_000B: brtrue.s IL_0011
    IL_000D: ldc.i4.s 10
    IL_000F: br.s IL_0018
    IL_0011: ldloca.s V_0
    IL_0013: call System.Byte System.Nullable`1<System.Byte>::GetValueOrDefault()
    IL_0018: conv.r8
    IL_0019: call System.Double System.Math::Log(System.Double,System.Double)
    IL_001E: conv.u1
    IL_001F: ret

}
short log(short src, short base)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: ldarg.1
    IL_0003: stloc.0
    IL_0004: ldloca.s V_0
    IL_0006: call System.Boolean System.Nullable`1<System.Int16>::get_HasValue()
    IL_000B: brtrue.s IL_0011
    IL_000D: ldc.i4.s 10
    IL_000F: br.s IL_0018
    IL_0011: ldloca.s V_0
    IL_0013: call System.Int16 System.Nullable`1<System.Int16>::GetValueOrDefault()
    IL_0018: conv.r8
    IL_0019: call System.Double System.Math::Log(System.Double,System.Double)
    IL_001E: conv.i2
    IL_001F: ret

}
ushort log(ushort src, ushort base)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: ldarg.1
    IL_0003: stloc.0
    IL_0004: ldloca.s V_0
    IL_0006: call System.Boolean System.Nullable`1<System.UInt16>::get_HasValue()
    IL_000B: brtrue.s IL_0011
    IL_000D: ldc.i4.s 10
    IL_000F: br.s IL_0018
    IL_0011: ldloca.s V_0
    IL_0013: call System.UInt16 System.Nullable`1<System.UInt16>::GetValueOrDefault()
    IL_0018: conv.r8
    IL_0019: call System.Double System.Math::Log(System.Double,System.Double)
    IL_001E: conv.u2
    IL_001F: ret

}
int log(int src, int base)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: ldarg.1
    IL_0003: stloc.0
    IL_0004: ldloca.s V_0
    IL_0006: call System.Boolean System.Nullable`1<System.Int32>::get_HasValue()
    IL_000B: brtrue.s IL_0011
    IL_000D: ldc.i4.s 10
    IL_000F: br.s IL_0018
    IL_0011: ldloca.s V_0
    IL_0013: call System.Int32 System.Nullable`1<System.Int32>::GetValueOrDefault()
    IL_0018: conv.r8
    IL_0019: call System.Double System.Math::Log(System.Double,System.Double)
    IL_001E: conv.i4
    IL_001F: ret

}
uint log(uint src, uint base)
{
    IL_0000: ldarg.0
    IL_0001: conv.r.un
    IL_0002: conv.r8
    IL_0003: ldarg.1
    IL_0004: stloc.0
    IL_0005: ldloca.s V_0
    IL_0007: call System.Boolean System.Nullable`1<System.UInt32>::get_HasValue()
    IL_000C: brtrue.s IL_0012
    IL_000E: ldc.i4.s 10
    IL_0010: br.s IL_0019
    IL_0012: ldloca.s V_0
    IL_0014: call System.UInt32 System.Nullable`1<System.UInt32>::GetValueOrDefault()
    IL_0019: conv.r.un
    IL_001A: conv.r8
    IL_001B: call System.Double System.Math::Log(System.Double,System.Double)
    IL_0020: conv.u4
    IL_0021: ret

}
long log(long src, long base)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: ldarg.1
    IL_0003: stloc.0
    IL_0004: ldloca.s V_0
    IL_0006: call System.Boolean System.Nullable`1<System.Int64>::get_HasValue()
    IL_000B: brtrue.s IL_0012
    IL_000D: ldc.i4.s 10
    IL_000F: conv.i8
    IL_0010: br.s IL_0019
    IL_0012: ldloca.s V_0
    IL_0014: call System.Int64 System.Nullable`1<System.Int64>::GetValueOrDefault()
    IL_0019: conv.r8
    IL_001A: call System.Double System.Math::Log(System.Double,System.Double)
    IL_001F: conv.i8
    IL_0020: ret

}
ulong log(ulong src, ulong base)
{
    IL_0000: ldarg.0
    IL_0001: conv.r.un
    IL_0002: conv.r8
    IL_0003: ldarg.1
    IL_0004: stloc.0
    IL_0005: ldloca.s V_0
    IL_0007: call System.Boolean System.Nullable`1<System.UInt64>::get_HasValue()
    IL_000C: brtrue.s IL_0013
    IL_000E: ldc.i4.s 10
    IL_0010: conv.i8
    IL_0011: br.s IL_001A
    IL_0013: ldloca.s V_0
    IL_0015: call System.UInt64 System.Nullable`1<System.UInt64>::GetValueOrDefault()
    IL_001A: conv.r.un
    IL_001B: conv.r8
    IL_001C: call System.Double System.Math::Log(System.Double,System.Double)
    IL_0021: conv.u8
    IL_0022: ret

}
float log(float src, float base)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: stloc.0
    IL_0003: ldloca.s V_0
    IL_0005: call System.Boolean System.Nullable`1<System.Single>::get_HasValue()
    IL_000A: brtrue.s IL_0013
    IL_000C: ldc.r4 10
    IL_0011: br.s IL_001A
    IL_0013: ldloca.s V_0
    IL_0015: call System.Single System.Nullable`1<System.Single>::GetValueOrDefault()
    IL_001A: call System.Single System.MathF::Log(System.Single,System.Single)
    IL_001F: ret

}
double log(double src, double base)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: stloc.0
    IL_0003: ldloca.s V_0
    IL_0005: call System.Boolean System.Nullable`1<System.Double>::get_HasValue()
    IL_000A: brtrue.s IL_0017
    IL_000C: ldc.r8 10
    IL_0015: br.s IL_001E
    IL_0017: ldloca.s V_0
    IL_0019: call System.Double System.Nullable`1<System.Double>::GetValueOrDefault()
    IL_001E: call System.Double System.Math::Log(System.Double,System.Double)
    IL_0023: ret

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
float mod(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: ret

}
double mod(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: ret

}
ref sbyte mod(ref sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: rem
    IL_0005: conv.i1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref byte mod(ref byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: rem
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref short mod(ref short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: rem
    IL_0005: conv.i2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ushort mod(ref ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: rem
    IL_0005: conv.u2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref int mod(ref int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: rem
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref uint mod(ref uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: rem.un
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref long mod(ref long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: rem
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref ulong mod(ref ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: rem.un
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref float dec(float src, out float dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.r4 1
    IL_0007: sub
    IL_0008: dup
    IL_0009: starg.s src
    IL_000B: stind.r4
    IL_000C: ldarg.1
    IL_000D: ret

}
ref double dec(double src, out double dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.r8 1
    IL_000B: sub
    IL_000C: dup
    IL_000D: starg.s src
    IL_000F: stind.r8
    IL_0010: ldarg.1
    IL_0011: ret

}
sbyte div(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: conv.i1
    IL_0004: ret

}
byte div(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: conv.u1
    IL_0004: ret

}
short div(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: conv.i2
    IL_0004: ret

}
ushort div(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: conv.u2
    IL_0004: ret

}
int div(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: ret

}
uint div(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div.un
    IL_0003: ret

}
long div(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: ret

}
ulong div(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div.un
    IL_0003: ret

}
float div(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: ret

}
double div(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: ret

}
Decimal div(Decimal lhs, Decimal rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Decimal System.Decimal::op_Division(System.Decimal,System.Decimal)
    IL_0007: ret

}
BigInteger div(BigInteger lhs, BigInteger rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Numerics.BigInteger System.Numerics.BigInteger::op_Division(System.Numerics.BigInteger,System.Numerics.BigInteger)
    IL_0007: ret

}
ref sbyte div(ref sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: div
    IL_0005: conv.i1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref byte div(ref byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: div
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref short div(ref short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: div
    IL_0005: conv.i2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ushort div(ref ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: div
    IL_0005: conv.u2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref int div(ref int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: div
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref uint div(ref uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: div.un
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref long div(ref long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: div
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref ulong div(ref ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: div.un
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref float div(ref float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: ldarg.1
    IL_0004: div
    IL_0005: stind.r4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref double div(ref double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldarg.1
    IL_0004: div
    IL_0005: stind.r8
    IL_0006: ldarg.0
    IL_0007: ret

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
bool divides(float lhs, float rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: rem
    IL_0003: ldc.r4 0
    IL_0008: ceq
    IL_000A: ret

}
bool divides(double lhs, double rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: rem
    IL_0003: ldc.r8 0
    IL_000C: ceq
    IL_000E: ret

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
bool eq(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool eq(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
sbyte exp(sbyte pow)
{
    IL_0000: ldarg.0
    IL_0001: conv.r4
    IL_0002: call System.Single System.MathF::Exp(System.Single)
    IL_0007: conv.i1
    IL_0008: ret

}
byte exp(byte pow)
{
    IL_0000: ldarg.0
    IL_0001: conv.r4
    IL_0002: call System.Single System.MathF::Exp(System.Single)
    IL_0007: conv.u1
    IL_0008: ret

}
short exp(short pow)
{
    IL_0000: ldarg.0
    IL_0001: conv.r4
    IL_0002: call System.Single System.MathF::Exp(System.Single)
    IL_0007: conv.i2
    IL_0008: ret

}
ushort exp(ushort pow)
{
    IL_0000: ldarg.0
    IL_0001: conv.r4
    IL_0002: call System.Single System.MathF::Exp(System.Single)
    IL_0007: conv.u2
    IL_0008: ret

}
int exp(int pow)
{
    IL_0000: ldarg.0
    IL_0001: conv.r4
    IL_0002: call System.Single System.MathF::Exp(System.Single)
    IL_0007: conv.i4
    IL_0008: ret

}
uint exp(uint pow)
{
    IL_0000: ldarg.0
    IL_0001: conv.r.un
    IL_0002: conv.r4
    IL_0003: call System.Single System.MathF::Exp(System.Single)
    IL_0008: conv.u4
    IL_0009: ret

}
long exp(long pow)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: call System.Double System.Math::Exp(System.Double)
    IL_0007: conv.i8
    IL_0008: ret

}
ulong exp(ulong pow)
{
    IL_0000: ldarg.0
    IL_0001: conv.r.un
    IL_0002: conv.r8
    IL_0003: call System.Double System.Math::Exp(System.Double)
    IL_0008: conv.u8
    IL_0009: ret

}
float exp(float pow)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Exp(System.Single)
    IL_0006: ret

}
double exp(double pow)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Exp(System.Double)
    IL_0006: ret

}
bool fcmp(double x, double y, byte mode)
{
    IL_0000: ldarg.2
    IL_0001: switch(IL_0087,IL_00ED,IL_010F,IL_0171,IL_00C9,IL_0167,IL_0156,IL_0171,IL_009B,IL_0134,IL_0145,IL_0171,IL_00AF,IL_0123,IL_00FE,IL_0171,IL_0091,IL_00E3,IL_0105,IL_0171,IL_00D6,IL_015D,IL_014F,IL_0171,IL_00A5,IL_012D,IL_013B,IL_0171,IL_00BC,IL_0119,IL_00F7)
    IL_0082: br IL_0171
    IL_0087: ldarg.0
    IL_0088: ldarg.1
    IL_0089: ceq
    IL_008B: stloc.1
    IL_008C: br IL_0177
    IL_0091: ldarg.0
    IL_0092: ldarg.1
    IL_0093: ceq
    IL_0095: stloc.1
    IL_0096: br IL_0177
    IL_009B: ldarg.0
    IL_009C: ldarg.1
    IL_009D: ceq
    IL_009F: stloc.1
    IL_00A0: br IL_0177
    IL_00A5: ldarg.0
    IL_00A6: ldarg.1
    IL_00A7: ceq
    IL_00A9: stloc.1
    IL_00AA: br IL_0177
    IL_00AF: ldarg.0
    IL_00B0: ldarg.1
    IL_00B1: ceq
    IL_00B3: ldc.i4.0
    IL_00B4: ceq
    IL_00B6: stloc.1
    IL_00B7: br IL_0177
    IL_00BC: ldarg.0
    IL_00BD: ldarg.1
    IL_00BE: ceq
    IL_00C0: ldc.i4.0
    IL_00C1: ceq
    IL_00C3: stloc.1
    IL_00C4: br IL_0177
    IL_00C9: ldarg.0
    IL_00CA: ldarg.1
    IL_00CB: ceq
    IL_00CD: ldc.i4.0
    IL_00CE: ceq
    IL_00D0: stloc.1
    IL_00D1: br IL_0177
    IL_00D6: ldarg.0
    IL_00D7: ldarg.1
    IL_00D8: ceq
    IL_00DA: ldc.i4.0
    IL_00DB: ceq
    IL_00DD: stloc.1
    IL_00DE: br IL_0177
    IL_00E3: ldarg.0
    IL_00E4: ldarg.1
    IL_00E5: clt
    IL_00E7: stloc.1
    IL_00E8: br IL_0177
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: clt
    IL_00F1: stloc.1
    IL_00F2: br IL_0177
    IL_00F7: ldarg.0
    IL_00F8: ldarg.1
    IL_00F9: cgt
    IL_00FB: stloc.1
    IL_00FC: br.s IL_0177
    IL_00FE: ldarg.0
    IL_00FF: ldarg.1
    IL_0100: cgt
    IL_0102: stloc.1
    IL_0103: br.s IL_0177
    IL_0105: ldarg.0
    IL_0106: ldarg.1
    IL_0107: cgt.un
    IL_0109: ldc.i4.0
    IL_010A: ceq
    IL_010C: stloc.1
    IL_010D: br.s IL_0177
    IL_010F: ldarg.0
    IL_0110: ldarg.1
    IL_0111: cgt.un
    IL_0113: ldc.i4.0
    IL_0114: ceq
    IL_0116: stloc.1
    IL_0117: br.s IL_0177
    IL_0119: ldarg.0
    IL_011A: ldarg.1
    IL_011B: clt.un
    IL_011D: ldc.i4.0
    IL_011E: ceq
    IL_0120: stloc.1
    IL_0121: br.s IL_0177
    IL_0123: ldarg.0
    IL_0124: ldarg.1
    IL_0125: clt.un
    IL_0127: ldc.i4.0
    IL_0128: ceq
    IL_012A: stloc.1
    IL_012B: br.s IL_0177
    IL_012D: ldarg.0
    IL_012E: ldarg.1
    IL_012F: clt.un
    IL_0131: stloc.1
    IL_0132: br.s IL_0177
    IL_0134: ldarg.0
    IL_0135: ldarg.1
    IL_0136: clt.un
    IL_0138: stloc.1
    IL_0139: br.s IL_0177
    IL_013B: ldarg.0
    IL_013C: ldarg.1
    IL_013D: cgt
    IL_013F: ldc.i4.0
    IL_0140: ceq
    IL_0142: stloc.1
    IL_0143: br.s IL_0177
    IL_0145: ldarg.0
    IL_0146: ldarg.1
    IL_0147: cgt
    IL_0149: ldc.i4.0
    IL_014A: ceq
    IL_014C: stloc.1
    IL_014D: br.s IL_0177
    IL_014F: ldarg.0
    IL_0150: ldarg.1
    IL_0151: cgt.un
    IL_0153: stloc.1
    IL_0154: br.s IL_0177
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: cgt.un
    IL_015A: stloc.1
    IL_015B: br.s IL_0177
    IL_015D: ldarg.0
    IL_015E: ldarg.1
    IL_015F: clt
    IL_0161: ldc.i4.0
    IL_0162: ceq
    IL_0164: stloc.1
    IL_0165: br.s IL_0177
    IL_0167: ldarg.0
    IL_0168: ldarg.1
    IL_0169: clt
    IL_016B: ldc.i4.0
    IL_016C: ceq
    IL_016E: stloc.1
    IL_016F: br.s IL_0177
    IL_0171: newobj System.Void System.NotSupportedException::.ctor()
    IL_0176: throw
    IL_0177: ldloc.1
    IL_0178: stloc.2
    IL_0179: ldloc.2
    IL_017A: stloc.0
    IL_017B: ldloc.0
    IL_017C: ret

}
Boolean[] fcmp(Span<double> lhs, Span<double> rhs, byte kind)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "fcmp"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\primal\\direct\\atomic\\FCmp.cs"
    IL_000C: ldc.i4.s 67
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Double,System.Double>(System.Span`1<System.Double>,System.Span`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: stloc.0
    IL_0019: ldloc.0
    IL_001A: call System.Boolean[] zfunc::alloc<System.Boolean>(System.Int32)
    IL_001F: stloc.1
    IL_0020: ldc.i4.0
    IL_0021: stloc.2
    IL_0022: br.s IL_0043
    IL_0024: ldloc.1
    IL_0025: ldloc.2
    IL_0026: ldarga.s lhs
    IL_0028: ldloc.2
    IL_0029: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_002E: ldind.r8
    IL_002F: ldarga.s rhs
    IL_0031: ldloc.2
    IL_0032: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0037: ldind.r8
    IL_0038: ldarg.2
    IL_0039: call System.Boolean Z0.math::fcmp(System.Double,System.Double,System.Runtime.Intrinsics.X86.FloatComparisonMode)
    IL_003E: stelem.i1
    IL_003F: ldloc.2
    IL_0040: ldc.i4.1
    IL_0041: add
    IL_0042: stloc.2
    IL_0043: ldloc.2
    IL_0044: ldloc.0
    IL_0045: blt.s IL_0024
    IL_0047: ldloc.1
    IL_0048: ret

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
ref sbyte flip(sbyte src, out sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: not
    IL_0003: conv.i1
    IL_0004: stind.i1
    IL_0005: ldarg.1
    IL_0006: ret

}
ref byte flip(byte src, out byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: not
    IL_0003: conv.u1
    IL_0004: stind.i1
    IL_0005: ldarg.1
    IL_0006: ret

}
ref short flip(short src, out short dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: not
    IL_0003: conv.i2
    IL_0004: stind.i2
    IL_0005: ldarg.1
    IL_0006: ret

}
ref ushort flip(ushort src, out ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: not
    IL_0003: conv.u2
    IL_0004: stind.i2
    IL_0005: ldarg.1
    IL_0006: ret

}
ref int flip(int src, out int dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: not
    IL_0003: stind.i4
    IL_0004: ldarg.1
    IL_0005: ret

}
ref uint flip(uint src, out uint dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: not
    IL_0003: stind.i4
    IL_0004: ldarg.1
    IL_0005: ret

}
ref long flip(long src, out long dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: not
    IL_0003: stind.i8
    IL_0004: ldarg.1
    IL_0005: ret

}
ref ulong flip(ulong src, out ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: not
    IL_0003: stind.i8
    IL_0004: ldarg.1
    IL_0005: ret

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
float floor(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Floor(System.Single)
    IL_0006: ret

}
double floor(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Floor(System.Double)
    IL_0006: ret

}
float ceil(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Ceiling(System.Single)
    IL_0006: ret

}
double ceil(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Ceiling(System.Double)
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
float fma(float x, float y, float z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Single System.MathF::FusedMultiplyAdd(System.Single,System.Single,System.Single)
    IL_0008: ret

}
double fma(double x, double y, double z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Double System.Math::FusedMultiplyAdd(System.Double,System.Double,System.Double)
    IL_0008: ret

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
    IL_0000: br.s IL_0010
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: call System.UInt32 Z0.math::mod(System.UInt32,System.UInt32)
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
    IL_0000: br.s IL_0010
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: call System.UInt64 Z0.math::mod(System.UInt64,System.UInt64)
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
float gcd(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.math::abs(System.Single)
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: call System.Single Z0.math::abs(System.Single)
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
    IL_0019: ldc.r4 0
    IL_001E: bne.un.s IL_0010
    IL_0020: ldloc.0
    IL_0021: ret

}
double gcd(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.math::abs(System.Double)
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: call System.Double Z0.math::abs(System.Double)
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
    IL_0019: ldc.r8 0
    IL_0022: bne.un.s IL_0010
    IL_0024: ldloc.0
    IL_0025: ret

}
Decimal gcd(Decimal lhs, Decimal rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Decimal Z0.math::abs(System.Decimal)
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: call System.Decimal Z0.math::abs(System.Decimal)
    IL_000D: stloc.1
    IL_000E: br.s IL_001C
    IL_0010: ldloc.0
    IL_0011: ldloc.1
    IL_0012: call System.Decimal System.Decimal::op_Modulus(System.Decimal,System.Decimal)
    IL_0017: stloc.2
    IL_0018: ldloc.1
    IL_0019: stloc.0
    IL_001A: ldloc.2
    IL_001B: stloc.1
    IL_001C: ldloc.1
    IL_001D: ldsfld System.Decimal System.Decimal::Zero
    IL_0022: call System.Boolean System.Decimal::op_Inequality(System.Decimal,System.Decimal)
    IL_0027: brtrue.s IL_0010
    IL_0029: ldloc.0
    IL_002A: ret

}
BigInteger gcd(BigInteger lhs, BigInteger rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Numerics.BigInteger System.Numerics.BigInteger::GreatestCommonDivisor(System.Numerics.BigInteger,System.Numerics.BigInteger)
    IL_0007: ret

}
ref sbyte gcd(ref sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: call System.SByte Z0.math::gcd(System.SByte,System.SByte)
    IL_0009: stind.i1
    IL_000A: ldarg.0
    IL_000B: ret

}
ref byte gcd(ref byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: call System.Byte Z0.math::gcd(System.Byte,System.Byte)
    IL_0009: stind.i1
    IL_000A: ldarg.0
    IL_000B: ret

}
ref short gcd(ref short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: call System.Int16 Z0.math::gcd(System.Int16,System.Int16)
    IL_0009: stind.i2
    IL_000A: ldarg.0
    IL_000B: ret

}
ref ushort gcd(ref ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: call System.UInt16 Z0.math::gcd(System.UInt16,System.UInt16)
    IL_0009: stind.i2
    IL_000A: ldarg.0
    IL_000B: ret

}
ref int gcd(ref int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: call System.Int32 Z0.math::gcd(System.Int32,System.Int32)
    IL_0009: stind.i4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref uint gcd(ref uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: call System.UInt32 Z0.math::gcd(System.UInt32,System.UInt32)
    IL_0009: stind.i4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref long gcd(ref long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: call System.Int64 Z0.math::gcd(System.Int64,System.Int64)
    IL_0009: stind.i8
    IL_000A: ldarg.0
    IL_000B: ret

}
ref ulong gcd(ref ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: call System.UInt64 Z0.math::gcd(System.UInt64,System.UInt64)
    IL_0009: stind.i8
    IL_000A: ldarg.0
    IL_000B: ret

}
ref float gcd(ref float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: ldarg.1
    IL_0004: call System.Single Z0.math::gcd(System.Single,System.Single)
    IL_0009: stind.r4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref double gcd(ref double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldarg.1
    IL_0004: call System.Double Z0.math::gcd(System.Double,System.Double)
    IL_0009: stind.r8
    IL_000A: ldarg.0
    IL_000B: ret

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
bool gt(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ret

}
bool gt(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ret

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
ref sbyte abs(ref sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: call System.SByte System.Math::Abs(System.SByte)
    IL_0008: stind.i1
    IL_0009: ldarg.0
    IL_000A: ret

}
ref short abs(ref short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: call System.Int16 System.Math::Abs(System.Int16)
    IL_0008: stind.i2
    IL_0009: ldarg.0
    IL_000A: ret

}
ref int abs(ref int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: call System.Int32 System.Math::Abs(System.Int32)
    IL_0008: stind.i4
    IL_0009: ldarg.0
    IL_000A: ret

}
ref long abs(ref long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: call System.Int64 System.Math::Abs(System.Int64)
    IL_0008: stind.i8
    IL_0009: ldarg.0
    IL_000A: ret

}
ref float abs(ref float src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: call System.Single System.MathF::Abs(System.Single)
    IL_0008: stind.r4
    IL_0009: ldarg.0
    IL_000A: ret

}
ref double abs(ref double src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: call System.Double System.Math::Abs(System.Double)
    IL_0008: stind.r8
    IL_0009: ldarg.0
    IL_000A: ret

}
ref sbyte abs(in sbyte src, out sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: call System.SByte System.Math::Abs(System.SByte)
    IL_0008: stind.i1
    IL_0009: ldarg.1
    IL_000A: ret

}
ref short abs(in short src, out short dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: call System.Int16 System.Math::Abs(System.Int16)
    IL_0008: stind.i2
    IL_0009: ldarg.1
    IL_000A: ret

}
ref int abs(in int src, out int dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: call System.Int32 System.Math::Abs(System.Int32)
    IL_0008: stind.i4
    IL_0009: ldarg.1
    IL_000A: ret

}
ref long abs(in long src, out long dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: call System.Int64 System.Math::Abs(System.Int64)
    IL_0008: stind.i8
    IL_0009: ldarg.1
    IL_000A: ret

}
ref float abs(in float src, out float dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: call System.Single System.Math::Abs(System.Single)
    IL_0008: stind.r4
    IL_0009: ldarg.1
    IL_000A: ret

}
ref double abs(in double src, out double dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: call System.Double System.Math::Abs(System.Double)
    IL_0008: stind.r8
    IL_0009: ldarg.1
    IL_000A: ret

}
sbyte abs(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte System.Math::Abs(System.SByte)
    IL_0006: ret

}
short abs(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 System.Math::Abs(System.Int16)
    IL_0006: ret

}
int abs(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 System.Math::Abs(System.Int32)
    IL_0006: ret

}
uint abs(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
long abs(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 System.Math::Abs(System.Int64)
    IL_0006: ret

}
ulong abs(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ret

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
Decimal abs(Decimal src)
{
    IL_0000: ldarg.0
    IL_0001: ldsfld System.Decimal System.Decimal::Zero
    IL_0006: call System.Boolean System.Decimal::op_GreaterThanOrEqual(System.Decimal,System.Decimal)
    IL_000B: brtrue.s IL_0014
    IL_000D: ldarg.0
    IL_000E: call System.Decimal System.Decimal::op_UnaryNegation(System.Decimal)
    IL_0013: ret
    IL_0014: ldarg.0
    IL_0015: ret

}
BigInteger abs(BigInteger src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Numerics.BigInteger System.Numerics.BigInteger::Abs(System.Numerics.BigInteger)
    IL_0006: ret

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
float add(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
double add(double lhs, double rhs)
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
ref float add(ref float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: ldarg.1
    IL_0004: add
    IL_0005: stind.r4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref double add(ref double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldarg.1
    IL_0004: add
    IL_0005: stind.r8
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
float add(float lhs, float rhs, out float dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: add
    IL_0004: dup
    IL_0005: stloc.0
    IL_0006: stind.r4
    IL_0007: ldloc.0
    IL_0008: ret

}
double add(double lhs, double rhs, out double dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: add
    IL_0004: dup
    IL_0005: stloc.0
    IL_0006: stind.r8
    IL_0007: ldloc.0
    IL_0008: ret

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
bool between(float x, float a, float b)
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
bool between(double x, double a, double b)
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
int bits(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 System.BitConverter::SingleToInt32Bits(System.Single)
    IL_0006: ret

}
long bits(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 System.BitConverter::DoubleToInt64Bits(System.Double)
    IL_0006: ret

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
float dec(float src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r4 1
    IL_0006: sub
    IL_0007: dup
    IL_0008: starg.s src
    IL_000A: ret

}
double dec(double src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r8 1
    IL_000A: sub
    IL_000B: dup
    IL_000C: starg.s src
    IL_000E: ret

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
ref float dec(ref float src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: ldc.r4 1
    IL_0008: sub
    IL_0009: stind.r4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref double dec(ref double src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldc.r8 1
    IL_000C: sub
    IL_000D: stind.r8
    IL_000E: ldarg.0
    IL_000F: ret

}
ref sbyte dec(sbyte src, out sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: conv.i1
    IL_0005: dup
    IL_0006: starg.s src
    IL_0008: stind.i1
    IL_0009: ldarg.1
    IL_000A: ret

}
ref byte dec(byte src, out byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: conv.u1
    IL_0005: dup
    IL_0006: starg.s src
    IL_0008: stind.i1
    IL_0009: ldarg.1
    IL_000A: ret

}
ref short dec(short src, out short dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: conv.i2
    IL_0005: dup
    IL_0006: starg.s src
    IL_0008: stind.i2
    IL_0009: ldarg.1
    IL_000A: ret

}
ref ushort dec(ushort src, out ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: conv.u2
    IL_0005: dup
    IL_0006: starg.s src
    IL_0008: stind.i2
    IL_0009: ldarg.1
    IL_000A: ret

}
ref int dec(int src, out int dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: stind.i4
    IL_0008: ldarg.1
    IL_0009: ret

}
ref uint dec(uint src, out uint dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: stind.i4
    IL_0008: ldarg.1
    IL_0009: ret

}
ref long dec(long src, out long dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: conv.i8
    IL_0004: sub
    IL_0005: dup
    IL_0006: starg.s src
    IL_0008: stind.i8
    IL_0009: ldarg.1
    IL_000A: ret

}
ref ulong dec(ulong src, out ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: conv.i8
    IL_0004: sub
    IL_0005: dup
    IL_0006: starg.s src
    IL_0008: stind.i8
    IL_0009: ldarg.1
    IL_000A: ret

}

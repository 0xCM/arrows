// 2019-09-20 23:09:46:546
Vec256<long> cmplt(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0020: ret

}
Vec128Cmp<sbyte> eq(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: call Z0.Vec128Cmp`1<System.SByte> Z0.Vec128Cmp::Define<System.SByte>(Z0.Vec128`1<System.SByte>&)
    IL_0028: ret

}
Vec128Cmp<byte> eq(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: call Z0.Vec128Cmp`1<System.Byte> Z0.Vec128Cmp::Define<System.Byte>(Z0.Vec128`1<System.Byte>&)
    IL_0028: ret

}
Vec128Cmp<short> eq(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: call Z0.Vec128Cmp`1<System.Int16> Z0.Vec128Cmp::Define<System.Int16>(Z0.Vec128`1<System.Int16>&)
    IL_0028: ret

}
Vec128Cmp<ushort> eq(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: call Z0.Vec128Cmp`1<System.UInt16> Z0.Vec128Cmp::Define<System.UInt16>(Z0.Vec128`1<System.UInt16>&)
    IL_0028: ret

}
Vec128Cmp<int> eq(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: call Z0.Vec128Cmp`1<System.Int32> Z0.Vec128Cmp::Define<System.Int32>(Z0.Vec128`1<System.Int32>&)
    IL_0028: ret

}
Vec128Cmp<uint> eq(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: call Z0.Vec128Cmp`1<System.UInt32> Z0.Vec128Cmp::Define<System.UInt32>(Z0.Vec128`1<System.UInt32>&)
    IL_0028: ret

}
Vec128Cmp<long> eq(in Vec128<long> lhs, in Vec128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: call Z0.Vec128Cmp`1<System.Int64> Z0.Vec128Cmp::Define<System.Int64>(Z0.Vec128`1<System.Int64>&)
    IL_0028: ret

}
Vec128Cmp<ulong> eq(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse41::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: call Z0.Vec128Cmp`1<System.UInt64> Z0.Vec128Cmp::Define<System.UInt64>(Z0.Vec128`1<System.UInt64>&)
    IL_0028: ret

}
Vec256Cmp<sbyte> eq(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: call Z0.Vec256Cmp`1<System.SByte> Z0.Vec256Cmp::Define<System.SByte>(Z0.Vec256`1<System.SByte>&)
    IL_0028: ret

}
Vec256Cmp<byte> eq(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: call Z0.Vec256Cmp`1<System.Byte> Z0.Vec256Cmp::Define<System.Byte>(Z0.Vec256`1<System.Byte>&)
    IL_0028: ret

}
Vec256Cmp<short> eq(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: call Z0.Vec256Cmp`1<System.Int16> Z0.Vec256Cmp::Define<System.Int16>(Z0.Vec256`1<System.Int16>&)
    IL_0028: ret

}
Vec256Cmp<ushort> eq(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: call Z0.Vec256Cmp`1<System.UInt16> Z0.Vec256Cmp::Define<System.UInt16>(Z0.Vec256`1<System.UInt16>&)
    IL_0028: ret

}
Vec256Cmp<int> eq(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: call Z0.Vec256Cmp`1<System.Int32> Z0.Vec256Cmp::Define<System.Int32>(Z0.Vec256`1<System.Int32>&)
    IL_0028: ret

}
Vec256Cmp<uint> eq(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: call Z0.Vec256Cmp`1<System.UInt32> Z0.Vec256Cmp::Define<System.UInt32>(Z0.Vec256`1<System.UInt32>&)
    IL_0028: ret

}
Vec256Cmp<long> eq(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: call Z0.Vec256Cmp`1<System.Int64> Z0.Vec256Cmp::Define<System.Int64>(Z0.Vec256`1<System.Int64>&)
    IL_0028: ret

}
Vec256Cmp<ulong> eq(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: call Z0.Vec256Cmp`1<System.UInt64> Z0.Vec256Cmp::Define<System.UInt64>(Z0.Vec256`1<System.UInt64>&)
    IL_0028: ret

}
bool testc(in Vec128<sbyte> src, in Vec128<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: ret

}
bool testc(in Vec128<byte> src, in Vec128<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: ret

}
bool testc(in Vec128<short> src, in Vec128<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: ret

}
bool testc(in Vec128<ushort> src, in Vec128<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: ret

}
bool testc(in Vec128<int> src, in Vec128<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: ret

}
bool testc(in Vec128<uint> src, in Vec128<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: ret

}
bool testc(in Vec128<long> src, in Vec128<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: ret

}
bool testc(in Vec128<ulong> src, in Vec128<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: ret

}
bool testc(in Vec256<sbyte> src, in Vec256<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: ret

}
bool testc(in Vec256<byte> src, in Vec256<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: ret

}
bool testc(in Vec256<short> src, in Vec256<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: ret

}
bool testc(in Vec256<ushort> src, in Vec256<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: ret

}
bool testc(in Vec256<int> src, in Vec256<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: ret

}
bool testc(in Vec256<uint> src, in Vec256<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: ret

}
bool testc(in Vec256<long> src, in Vec256<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: ret

}
bool testc(in Vec256<ulong> src, in Vec256<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: ret

}
bool testz(in Vec128<byte> src, in Vec128<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: ret

}
bool testz(in Vec128<sbyte> src, in Vec128<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: ret

}
bool testz(in Vec128<short> src, in Vec128<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: ret

}
bool testz(in Vec128<ushort> src, in Vec128<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: ret

}
bool testz(in Vec128<int> src, in Vec128<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: ret

}
bool testz(in Vec128<uint> src, in Vec128<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: ret

}
bool testz(in Vec128<long> src, in Vec128<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: ret

}
bool testz(in Vec128<ulong> src, in Vec128<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: ret

}
bool testz(in Vec256<sbyte> src, in Vec256<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: ret

}
bool testz(in Vec256<byte> src, in Vec256<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: ret

}
bool testz(in Vec256<short> src, in Vec256<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: ret

}
bool testz(in Vec256<ushort> src, in Vec256<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: ret

}
bool testz(in Vec256<int> src, in Vec256<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: ret

}
bool testz(in Vec256<uint> src, in Vec256<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: ret

}
bool testz(in Vec256<long> src, in Vec256<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: ret

}
bool testz(in Vec256<ulong> src, in Vec256<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: ret

}
bool testznc(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: ret

}
bool testznc(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: ret

}
bool testznc(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: ret

}
bool testznc(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: ret

}
bool testznc(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: ret

}
bool testznc(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: ret

}
bool testznc(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: ret

}
bool testznc(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: ret

}
bool testznc(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: ret

}
bool testznc(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: ret

}
bool testznc(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: ret

}
bool testznc(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: ret

}
Vec128<float> dot(Vec128<float> lhs, Vec128<float> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000C: ldarg.2
    IL_000D: stloc.0
    IL_000E: ldloca.s V_0
    IL_0010: call System.Boolean System.Nullable`1<System.Byte>::get_HasValue()
    IL_0015: brtrue.s IL_001E
    IL_0017: ldc.i4 255
    IL_001C: br.s IL_0025
    IL_001E: ldloca.s V_0
    IL_0020: call System.Byte System.Nullable`1<System.Byte>::GetValueOrDefault()
    IL_0025: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse41::DotProduct(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Byte)
    IL_002A: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_002F: ret

}
Vec128<double> dot(Vec128<double> lhs, Vec128<double> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000C: ldarg.2
    IL_000D: stloc.0
    IL_000E: ldloca.s V_0
    IL_0010: call System.Boolean System.Nullable`1<System.Byte>::get_HasValue()
    IL_0015: brtrue.s IL_001E
    IL_0017: ldc.i4 255
    IL_001C: br.s IL_0025
    IL_001E: ldloca.s V_0
    IL_0020: call System.Byte System.Nullable`1<System.Byte>::GetValueOrDefault()
    IL_0025: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse41::DotProduct(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Byte)
    IL_002A: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_002F: ret

}
Vec256<float> dot(Vec256<float> lhs, Vec256<float> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>)
    IL_000C: ldarg.2
    IL_000D: stloc.0
    IL_000E: ldloca.s V_0
    IL_0010: call System.Boolean System.Nullable`1<System.Byte>::get_HasValue()
    IL_0015: brtrue.s IL_001E
    IL_0017: ldc.i4 255
    IL_001C: br.s IL_0025
    IL_001E: ldloca.s V_0
    IL_0020: call System.Byte System.Nullable`1<System.Byte>::GetValueOrDefault()
    IL_0025: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::DotProduct(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Byte)
    IL_002A: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_002F: ret

}
bool ngt(in Scalar128<float> lhs, in Scalar128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Scalar128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Scalar128`1<System.Single>::op_Implicit(Z0.Scalar128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Scalar128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Scalar128`1<System.Single>::op_Implicit(Z0.Scalar128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::CompareScalarNotGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: ldc.i4.0
    IL_001C: call System.Boolean Z0.dinx::IsNaN(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Int32)
    IL_0021: ret

}
bool ngt(in Scalar128<double> lhs, in Scalar128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Scalar128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Scalar128`1<System.Double>::op_Implicit(Z0.Scalar128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Scalar128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Scalar128`1<System.Double>::op_Implicit(Z0.Scalar128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::CompareScalarNotGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: ldc.i4.0
    IL_001C: call System.Boolean Z0.dinx::IsNaN(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Int32)
    IL_0021: ret

}
bool nlt(in Scalar128<float> lhs, in Scalar128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Scalar128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Scalar128`1<System.Single>::op_Implicit(Z0.Scalar128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Scalar128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Scalar128`1<System.Single>::op_Implicit(Z0.Scalar128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::CompareScalarNotLessThan(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: ldc.i4.0
    IL_001C: call System.Boolean Z0.dinx::IsNaN(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Int32)
    IL_0021: ret

}
bool nlt(in Scalar128<double> lhs, in Scalar128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Scalar128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Scalar128`1<System.Double>::op_Implicit(Z0.Scalar128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Scalar128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Scalar128`1<System.Double>::op_Implicit(Z0.Scalar128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::CompareScalarNotLessThan(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: ldc.i4.0
    IL_001C: call System.Boolean Z0.dinx::IsNaN(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Int32)
    IL_0021: ret

}
bool IsNaN(Vector128<float> src, int index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single System.Runtime.Intrinsics.Vector128::GetElement<System.Single>(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Int32)
    IL_0007: call System.Boolean Z0.xfunc::IsNaN(System.Single)
    IL_000C: ret

}
bool IsNaN(Vector128<double> src, int index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double System.Runtime.Intrinsics.Vector128::GetElement<System.Double>(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Int32)
    IL_0007: call System.Boolean Z0.xfunc::IsNaN(System.Double)
    IL_000C: ret

}
Vec256<ulong> unpackhi(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0020: ret

}
Vec128<sbyte> unpacklo(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<byte> unpacklo(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<short> unpacklo(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<ushort> unpacklo(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec128<int> unpacklo(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec128<uint> unpacklo(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: ret

}
Vec128<long> unpacklo(in Vec128<long> lhs, in Vec128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: ret

}
Vec128<ulong> unpacklo(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: ret

}
Vec256<byte> unpacklo(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<sbyte> unpacklo(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<short> unpacklo(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<ushort> unpacklo(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
Vec256<int> unpacklo(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec256<uint> unpacklo(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0020: ret

}
Vec256<long> unpacklo(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0020: ret

}
Vec256<ulong> unpacklo(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0020: ret

}
UInt128 and(in UInt128 lhs, in UInt128 rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.UInt128
    IL_0006: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: ldarg.1
    IL_000F: ldobj Z0.UInt128
    IL_0014: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: call Z0.Vec128`1<System.UInt64> Z0.dinx::and(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0021: stloc.2
    IL_0022: ldloca.s V_2
    IL_0024: call Z0.UInt128 Z0.UInt128X::ToUInt128(Z0.Vec128`1<System.UInt64>&)
    IL_0029: ret

}
ref UInt128 and(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.UInt128
    IL_0007: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: ldarg.1
    IL_0010: ldobj Z0.UInt128
    IL_0015: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128)
    IL_001A: stloc.1
    IL_001B: ldloca.s V_1
    IL_001D: call Z0.Vec128`1<System.UInt64> Z0.dinx::and(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0022: stloc.2
    IL_0023: ldloca.s V_2
    IL_0025: call Z0.UInt128 Z0.UInt128X::ToUInt128(Z0.Vec128`1<System.UInt64>&)
    IL_002A: stobj Z0.UInt128
    IL_002F: ldarg.2
    IL_0030: ret

}
Vec128<byte> and(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<short> and(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<sbyte> and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<ushort> and(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec128<int> and(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec128<uint> and(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: ret

}
Vec128<long> and(in Vec128<long> lhs, in Vec128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: ret

}
Vec128<ulong> and(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: ret

}
Vec128<float> and(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::And(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> and(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

}
Vec256<byte> and(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<short> and(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<sbyte> and(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<ushort> and(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
Vec256<int> and(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec256<uint> and(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0020: ret

}
Vec256<long> and(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0020: ret

}
Vec256<ulong> and(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0020: ret

}
Vec256<float> and(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::And(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_001B: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0020: ret

}
Vec256<double> and(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::And(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_001B: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0020: ret

}
Vec128<byte> or(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<short> or(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<sbyte> or(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<ushort> or(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec128<int> or(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec128<uint> or(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: ret

}
Vec128<long> or(in Vec128<long> lhs, in Vec128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: ret

}
Vec128<ulong> or(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: ret

}
Vec128<float> or(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Or(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> or(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

}
Vec256<byte> or(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<short> or(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<sbyte> or(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<ushort> or(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
Vec256<int> or(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec256<uint> or(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0020: ret

}
Vec256<long> or(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0020: ret

}
Vec256<ulong> or(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0020: ret

}
Vec256<float> or(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Or(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_001B: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0020: ret

}
Vec256<double> or(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Or(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_001B: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0020: ret

}
Vec128<short> sll(in Vec128<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> sll(in Vec128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> sll(in Vec128<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> sll(in Vec128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> sll(in Vec128<long> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> sll(in Vec128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<short> sll(in Vec256<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> sll(in Vec256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> sll(in Vec256<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> sll(in Vec256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> slli(in Vec256<long> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> sll(in Vec256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec128<short> srl(in Vec128<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> srl(in Vec128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> srl(in Vec128<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> srl(in Vec128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> srl(in Vec128<long> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> srl(in Vec128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<short> srl(in Vec256<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> srl(in Vec256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> srl(in Vec256<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> srl(in Vec256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> srl(in Vec256<long> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> srl(in Vec256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec128<byte> xor(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<short> xor(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<sbyte> xor(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<ushort> xor(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec128<int> xor(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec128<uint> xor(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: ret

}
Vec128<long> xor(in Vec128<long> lhs, in Vec128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: ret

}
Vec128<ulong> xor(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: ret

}
Vec256<byte> xor(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<short> xor(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<sbyte> xor(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<ushort> xor(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
Vec256<int> xor(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec256<uint> xor(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0020: ret

}
Vec256<long> xor(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0020: ret

}
Vec256<ulong> xor(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0020: ret

}
Vec128<sbyte> cmpeq(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<byte> cmpeq(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<short> cmpeq(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<ushort> cmpeq(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec128<int> cmpeq(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec128<uint> cmpeq(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: ret

}
Vec128<long> cmpeq(in Vec128<long> lhs, in Vec128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: ret

}
Vec128<ulong> cmpeq(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse41::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: ret

}
Vec256<sbyte> cmpeq(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<byte> cmpeq(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<short> cmpeq(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<ushort> cmpeq(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
Vec256<int> cmpeq(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec256<uint> cmpeq(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0020: ret

}
Vec256<long> cmpeq(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0020: ret

}
Vec256<ulong> cmpeq(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0020: ret

}
Vec128<sbyte> cmpgt(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<short> cmpgt(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<int> cmpgt(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec256<sbyte> cmpgt(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<short> cmpgt(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<int> cmpgt(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec256<long> cmpgt(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0020: ret

}
Vec128<sbyte> cmplt(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareLessThan(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<short> cmplt(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareLessThan(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<int> cmplt(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareLessThan(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec256<sbyte> cmplt(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<short> cmplt(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<int> cmplt(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec128<uint> insert(uint src, in Vec128<uint> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.0
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse41::Insert(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.UInt32,System.Byte)
    IL_0012: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0017: ret

}
Vec128<long> insert(long src, in Vec128<long> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.0
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41/X64::Insert(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Int64,System.Byte)
    IL_0012: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0017: ret

}
Vec128<ulong> insert(ulong src, in Vec128<ulong> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.0
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse41/X64::Insert(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.UInt64,System.Byte)
    IL_0012: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0017: ret

}
Vec256<sbyte> insert(in Vec128<sbyte> src, in Vec256<sbyte> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0021: ret

}
ref Vec256<sbyte> insert(in Vec128<sbyte> lo, in Vec128<sbyte> hi, ref Vec256<sbyte> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.2
    IL_0002: ldobj Z0.Vec256`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000C: ldarg.0
    IL_000D: ldobj Z0.Vec128`1<System.SByte>
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0017: ldc.i4.0
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Byte)
    IL_001D: ldarg.1
    IL_001E: ldobj Z0.Vec128`1<System.SByte>
    IL_0023: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0028: ldc.i4.1
    IL_0029: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Byte)
    IL_002E: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0033: stobj Z0.Vec256`1<System.SByte>
    IL_0038: ldarg.2
    IL_0039: ret

}
Vec256<byte> insert(in Vec128<byte> src, in Vec256<byte> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
ref Vec256<byte> insert(in Vec128<byte> lo, in Vec128<byte> hi, ref Vec256<byte> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.2
    IL_0002: ldobj Z0.Vec256`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000C: ldarg.0
    IL_000D: ldobj Z0.Vec128`1<System.Byte>
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0017: ldc.i4.0
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001D: ldarg.1
    IL_001E: ldobj Z0.Vec128`1<System.Byte>
    IL_0023: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0028: ldc.i4.1
    IL_0029: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_002E: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0033: stobj Z0.Vec256`1<System.Byte>
    IL_0038: ldarg.2
    IL_0039: ret

}
Vec256<short> insert(in Vec128<short> src, in Vec256<short> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0021: ret

}
ref Vec256<short> insert(in Vec128<short> lo, in Vec128<short> hi, ref Vec256<short> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.2
    IL_0002: ldobj Z0.Vec256`1<System.Int16>
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000C: ldarg.0
    IL_000D: ldobj Z0.Vec128`1<System.Int16>
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0017: ldc.i4.0
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_001D: ldarg.1
    IL_001E: ldobj Z0.Vec128`1<System.Int16>
    IL_0023: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0028: ldc.i4.1
    IL_0029: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_002E: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0033: stobj Z0.Vec256`1<System.Int16>
    IL_0038: ldarg.2
    IL_0039: ret

}
Vec256<ushort> insert(in Vec128<ushort> src, in Vec256<ushort> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0021: ret

}
Vec256<int> insert(in Vec128<int> src, in Vec256<int> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0021: ret

}
Vec256<uint> insert(in Vec128<uint> src, in Vec256<uint> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0021: ret

}
Vec256<long> insert(in Vec128<long> src, in Vec256<long> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0021: ret

}
Vec256<ulong> insert(in Vec128<ulong> src, in Vec256<ulong> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0021: ret

}
ref Vec128<sbyte> lddqu(in sbyte src, out Vec128<sbyte> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.SByte* Z0.As::constptr(System.SByte&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.SByte*)
    IL_000C: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: stobj Z0.Vec128`1<System.SByte>
    IL_0016: ldarg.1
    IL_0017: ret

}
ref Vec128<byte> lddqu(in byte src, out Vec128<byte> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Byte* Z0.As::constptr(System.Byte&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.Byte*)
    IL_000C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: stobj Z0.Vec128`1<System.Byte>
    IL_0016: ldarg.1
    IL_0017: ret

}
ref Vec128<short> lddqu(in short src, out Vec128<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int16* Z0.As::constptr(System.Int16&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.Int16*)
    IL_000C: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: stobj Z0.Vec128`1<System.Int16>
    IL_0016: ldarg.1
    IL_0017: ret

}
ref Vec128<ushort> lddqu(in ushort src, out Vec128<ushort> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt16* Z0.As::constptr(System.UInt16&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.UInt16*)
    IL_000C: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: stobj Z0.Vec128`1<System.UInt16>
    IL_0016: ldarg.1
    IL_0017: ret

}
ref Vec128<int> lddqu(in int src, out Vec128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int32* Z0.As::constptr(System.Int32&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.Int32*)
    IL_000C: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: stobj Z0.Vec128`1<System.Int32>
    IL_0016: ldarg.1
    IL_0017: ret

}
ref Vec128<uint> lddqu(in uint src, out Vec128<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.UInt32*)
    IL_000C: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: stobj Z0.Vec128`1<System.UInt32>
    IL_0016: ldarg.1
    IL_0017: ret

}
ref Vec128<long> lddqu(in long src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int64* Z0.As::constptr(System.Int64&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.Int64*)
    IL_000C: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: stobj Z0.Vec128`1<System.Int64>
    IL_0016: ldarg.1
    IL_0017: ret

}
ref Vec128<ulong> lddqu(in ulong src, out Vec128<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.UInt64*)
    IL_000C: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: stobj Z0.Vec128`1<System.UInt64>
    IL_0016: ldarg.1
    IL_0017: ret

}
ref Vec256<sbyte> lddqu(in sbyte src, out Vec256<sbyte> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.SByte* Z0.As::constptr(System.SByte&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.SByte*)
    IL_000C: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stobj Z0.Vec256`1<System.SByte>
    IL_0016: ldarg.1
    IL_0017: ret

}
ref Vec256<byte> lddqu(in byte src, out Vec256<byte> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Byte* Z0.As::constptr(System.Byte&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Byte*)
    IL_000C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: stobj Z0.Vec256`1<System.Byte>
    IL_0016: ldarg.1
    IL_0017: ret

}
ref Vec256<short> lddqu(in short src, out Vec256<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int16* Z0.As::constptr(System.Int16&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Int16*)
    IL_000C: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stobj Z0.Vec256`1<System.Int16>
    IL_0016: ldarg.1
    IL_0017: ret

}
ref Vec256<ushort> lddqu(in ushort src, out Vec256<ushort> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt16* Z0.As::constptr(System.UInt16&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.UInt16*)
    IL_000C: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stobj Z0.Vec256`1<System.UInt16>
    IL_0016: ldarg.1
    IL_0017: ret

}
ref Vec256<int> lddqu(in int src, out Vec256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int32* Z0.As::constptr(System.Int32&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Int32*)
    IL_000C: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stobj Z0.Vec256`1<System.Int32>
    IL_0016: ldarg.1
    IL_0017: ret

}
ref Vec256<uint> lddqu(in uint src, out Vec256<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.UInt32*)
    IL_000C: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stobj Z0.Vec256`1<System.UInt32>
    IL_0016: ldarg.1
    IL_0017: ret

}
ref Vec256<long> lddqu(in long src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int64* Z0.As::constptr(System.Int64&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Int64*)
    IL_000C: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stobj Z0.Vec256`1<System.Int64>
    IL_0016: ldarg.1
    IL_0017: ret

}
ref Vec256<ulong> lddqu(in ulong src, out Vec256<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.UInt64*)
    IL_000C: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stobj Z0.Vec256`1<System.UInt64>
    IL_0016: ldarg.1
    IL_0017: ret

}
Vec128<int> maskload(ref int src, Vec128<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::MaskLoad(System.Int32*,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec256<int> maskload(ref int src, Vec256<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::MaskLoad(System.Int32*,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> maskload(ref uint src, Vec256<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::MaskLoad(System.UInt32*,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> maskload(ref long src, Vec256<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::MaskLoad(System.Int64*,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> maskload(ref ulong src, Vec256<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::MaskLoad(System.UInt64*,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
void maskmove(in Vec128<sbyte> src, in Vec128<sbyte> mask, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: ldarg.2
    IL_0017: call System.SByte* Z0.As::refptr(System.SByte&)
    IL_001C: call System.Void System.Runtime.Intrinsics.X86.Sse2::MaskMove(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.SByte*)
    IL_0021: ret

}
void maskmove(in Vec128<byte> src, in Vec128<byte> mask, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldarg.2
    IL_0017: call System.Byte* Z0.As::refptr(System.Byte&)
    IL_001C: call System.Void System.Runtime.Intrinsics.X86.Sse2::MaskMove(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte*)
    IL_0021: ret

}
void maskstore(Vec128<int> src, Vec128<int> mask, ref int dst)
{
    IL_0000: ldarg.2
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000C: ldarg.1
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0012: call System.Void System.Runtime.Intrinsics.X86.Avx2::MaskStore(System.Int32*,System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0017: ret

}
void maskstore(Vec256<int> src, Vec256<int> mask, ref int dst)
{
    IL_0000: ldarg.2
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000C: ldarg.1
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0012: call System.Void System.Runtime.Intrinsics.X86.Avx2::MaskStore(System.Int32*,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0017: ret

}
void maskstore(Vec256<uint> src, Vec256<uint> mask, ref uint dst)
{
    IL_0000: ldarg.2
    IL_0001: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000C: ldarg.1
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0012: call System.Void System.Runtime.Intrinsics.X86.Avx2::MaskStore(System.UInt32*,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0017: ret

}
void maskstore(Vec256<long> src, Vec256<long> mask, ref long dst)
{
    IL_0000: ldarg.2
    IL_0001: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000C: ldarg.1
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0012: call System.Void System.Runtime.Intrinsics.X86.Avx2::MaskStore(System.Int64*,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0017: ret

}
void maskstore(Vec256<ulong> src, Vec256<ulong> mask, ref ulong dst)
{
    IL_0000: ldarg.2
    IL_0001: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000C: ldarg.1
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0012: call System.Void System.Runtime.Intrinsics.X86.Avx2::MaskStore(System.UInt64*,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0017: ret

}
void movdqa(in Vec128<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.SByte* Z0.As::refptr(System.SByte&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.SByte>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.SByte*,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
void movdqa(in Vec128<byte> src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Byte* Z0.As::refptr(System.Byte&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Byte>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.Byte*,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
void movdqa(in Vec128<short> src, ref short dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int16* Z0.As::refptr(System.Int16&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Int16>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.Int16*,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
void movdqa(in Vec128<ushort> src, ref ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt16* Z0.As::refptr(System.UInt16&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.UInt16>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.UInt16*,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
void movdqa(in Vec128<int> src, ref int dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Int32>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.Int32*,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
void movdqa(in Vec128<uint> src, ref uint dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.UInt32>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.UInt32*,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
void movdqa(in Vec128<long> src, ref long dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Int64>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.Int64*,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
void movdqa(in Vec128<ulong> src, ref ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.UInt64>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.UInt64*,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
void movdqa(in Vec256<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.SByte* Z0.As::refptr(System.SByte&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec256`1<System.SByte>
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.SByte*,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
void movdqa(in Vec256<byte> src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Byte* Z0.As::refptr(System.Byte&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec256`1<System.Byte>
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.Byte*,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
void movdqa(in Vec256<short> src, ref short dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int16* Z0.As::refptr(System.Int16&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec256`1<System.Int16>
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.Int16*,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
void movdqa(in Vec256<ushort> src, ref ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt16* Z0.As::refptr(System.UInt16&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec256`1<System.UInt16>
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.UInt16*,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
void movdqa(in Vec256<int> src, ref int dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec256`1<System.Int32>
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.Int32*,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
void movdqa(in Vec256<uint> src, ref uint dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec256`1<System.UInt32>
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.UInt32*,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
void movdqa(in Vec256<long> src, ref long dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec256`1<System.Int64>
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.Int64*,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
void movdqa(in Vec256<ulong> src, ref ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec256`1<System.UInt64>
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.UInt64*,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
int movemask(in Vec128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: call System.Int32 System.Runtime.Intrinsics.X86.Sse2::MoveMask(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0010: ret

}
int movemask(in Vec128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: call System.Int32 System.Runtime.Intrinsics.X86.Sse2::MoveMask(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0010: ret

}
int movemask(in Vec128<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: call System.Int32 System.Runtime.Intrinsics.X86.Sse::MoveMask(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0010: ret

}
int movemask(in Vec128<double> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: call System.Int32 System.Runtime.Intrinsics.X86.Sse2::MoveMask(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0010: ret

}
int movemask(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: call System.Int32 System.Runtime.Intrinsics.X86.Avx2::MoveMask(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0010: ret

}
int movemask(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: call System.Int32 System.Runtime.Intrinsics.X86.Avx2::MoveMask(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0010: ret

}
int movemask(in Vec256<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>)
    IL_000B: call System.Int32 System.Runtime.Intrinsics.X86.Avx::MoveMask(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0010: ret

}
int movemask(in Vec256<double> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>)
    IL_000B: call System.Int32 System.Runtime.Intrinsics.X86.Avx::MoveMask(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0010: ret

}
Vec256<byte> permute(in Vec256<byte> src, in Vec256<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: call Z0.Vec256`1<System.Byte> Z0.dinx::swaphl(Z0.Vec256`1<System.Byte>&)
    IL_000D: stloc.1
    IL_000E: ldloca.s V_0
    IL_0010: ldarg.1
    IL_0011: ldsflda Z0.Vec256`1<System.Byte> Z0.dinx::K0
    IL_0016: call Z0.Vec256`1<System.Byte> Z0.dinx::add(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_001B: stloc.s V_4
    IL_001D: ldloca.s V_4
    IL_001F: call Z0.Vec256`1<System.Byte> Z0.dinx::shuffle(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0024: stloc.2
    IL_0025: ldloca.s V_1
    IL_0027: ldarg.1
    IL_0028: ldsflda Z0.Vec256`1<System.Byte> Z0.dinx::K1
    IL_002D: call Z0.Vec256`1<System.Byte> Z0.dinx::add(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0032: stloc.s V_4
    IL_0034: ldloca.s V_4
    IL_0036: call Z0.Vec256`1<System.Byte> Z0.dinx::shuffle(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_003B: stloc.3
    IL_003C: ldloca.s V_2
    IL_003E: ldloca.s V_3
    IL_0040: call Z0.Vec256`1<System.Byte> Z0.dinx::or(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0045: ret

}
Vec128<int> permute(in Vec128<int> src, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> permute(in Vec128<uint> src, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec256<sbyte> perm2x128(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0021: ret

}
Vec256<byte> perm2x128(in Vec256<byte> lhs, in Vec256<byte> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<short> perm2x128(in Vec256<short> lhs, in Vec256<short> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0021: ret

}
Vec256<ushort> perm2x128(in Vec256<ushort> lhs, in Vec256<ushort> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0021: ret

}
Vec256<int> perm2x128(in Vec256<int> lhs, in Vec256<int> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0021: ret

}
Vec256<uint> perm2x128(in Vec256<uint> lhs, in Vec256<uint> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0021: ret

}
Vec256<long> perm2x128(in Vec256<long> lhs, in Vec256<long> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0021: ret

}
Vec256<ulong> perm2x128(in Vec256<ulong> lhs, in Vec256<ulong> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0021: ret

}
Vec256<float> perm2x128(in Vec256<float> lhs, in Vec256<float> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0021: ret

}
Vec256<double> perm2x128(in Vec256<double> lhs, in Vec256<double> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0021: ret

}
Vec256<int> perm8x32(in Vec256<int> src, in Vec256<int> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec256<uint> perm8x32(in Vec256<uint> src, in Vec256<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0020: ret

}
Vec256<float> perm8x32(in Vec256<float> src, in Vec256<int> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0020: ret

}
Vec256<long> perm4x64(in Vec256<long> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> perm4x64(in Vec256<ulong> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec128<byte> swap(in Vec128<byte> src, Swap[] swaps)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Byte> Z0.Vec128Pattern::Swap<System.Byte>(Z0.Swap[])
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: call Z0.Vec128`1<System.Byte> Z0.dinx::shuffle(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_000F: ret

}
Vec128<byte> reverse(in Vec128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 15
    IL_0003: call Z0.Swap[] System.Array::Empty<Z0.Swap>()
    IL_0008: call Z0.Vec128`1<System.Byte> Z0.Vec128Pattern::Decrements<System.Byte>(System.Byte,Z0.Swap[])
    IL_000D: stloc.0
    IL_000E: ldloca.s V_0
    IL_0010: call Z0.Vec128`1<System.Byte> Z0.dinx::shuffle(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0015: ret

}
Vec128<sbyte> reverse(in Vec128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 15
    IL_0003: call Z0.Swap[] System.Array::Empty<Z0.Swap>()
    IL_0008: call Z0.Vec128`1<System.SByte> Z0.Vec128Pattern::Decrements<System.SByte>(System.SByte,Z0.Swap[])
    IL_000D: stloc.0
    IL_000E: ldloca.s V_0
    IL_0010: call Z0.Vec128`1<System.SByte> Z0.dinx::shuffle(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_0015: ret

}
Vec128<int> reverse(in Vec128<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 27
    IL_0003: call Z0.Vec128`1<System.Int32> Z0.dinx::shuffle(Z0.Vec128`1<System.Int32>&,System.Byte)
    IL_0008: ret

}
Vec128<uint> reverse(in Vec128<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 27
    IL_0003: call Z0.Vec128`1<System.UInt32> Z0.dinx::shuffle(Z0.Vec128`1<System.UInt32>&,System.Byte)
    IL_0008: ret

}
Vec256<byte> reverse(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 31
    IL_0003: call Z0.Swap[] System.Array::Empty<Z0.Swap>()
    IL_0008: call Z0.Vec256`1<System.Byte> Z0.Vec256Pattern::Decrements<System.Byte>(System.Byte,Z0.Swap[])
    IL_000D: stloc.0
    IL_000E: ldloca.s V_0
    IL_0010: call Z0.Vec256`1<System.Byte> Z0.dinx::permute(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0015: ret

}
Vec256<int> reverse(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldsflda Z0.Vec256`1<System.Int32> Z0.dinx::MRev256i32
    IL_0006: call Z0.Vec256`1<System.Int32> Z0.dinx::perm8x32(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_000B: ret

}
Vec256<uint> reverse(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldsflda Z0.Vec256`1<System.UInt32> Z0.dinx::MRev256u32
    IL_0006: call Z0.Vec256`1<System.UInt32> Z0.dinx::perm8x32(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_000B: ret

}
Vec256<float> reverse(in Vec256<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldsflda Z0.Vec256`1<System.Int32> Z0.dinx::MRev256f32
    IL_0006: call Z0.Vec256`1<System.Single> Z0.dinx::perm8x32(Z0.Vec256`1<System.Single>&,Z0.Vec256`1<System.Int32>&)
    IL_000B: ret

}
Vec128<short> shufflehi(in Vec128<short> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShuffleHigh(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> shufflehi(in Vec128<ushort> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<short> shufflelo(in Vec128<short> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> shufflelo(in Vec128<ushort> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> shuffle(in Vec128<int> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> shuffle(in Vec128<uint> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<byte> shuffle(in Vec128<byte> src, in Vec128<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<sbyte> shuffle(in Vec128<sbyte> src, in Vec128<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Ssse3::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec256<int> shuffle(in Vec256<int> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> shuffle(in Vec256<uint> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<byte> shuffle(in Vec256<byte> src, in Vec256<byte> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<sbyte> shuffle(in Vec256<sbyte> src, in Vec256<sbyte> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<int> swap(Vec256<int> src, byte i, byte j)
{
    IL_0000: ldsfld System.Int32 Z0.Vec256`1<System.Int32>::Length
    IL_0005: stloc.1
    IL_0006: ldloc.1
    IL_0007: conv.u
    IL_0008: ldc.i4.4
    IL_0009: mul.ovf.un
    IL_000A: localloc
    IL_000C: ldloc.1
    IL_000D: newobj System.Void System.Span`1<System.Int32>::.ctor(System.Void*,System.Int32)
    IL_0012: stloc.2
    IL_0013: ldloc.2
    IL_0014: stloc.0
    IL_0015: ldc.i4.0
    IL_0016: stloc.3
    IL_0017: br.s IL_0048
    IL_0019: ldloc.3
    IL_001A: ldarg.1
    IL_001B: bne.un.s IL_0029
    IL_001D: ldloca.s V_0
    IL_001F: ldloc.3
    IL_0020: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0025: ldarg.2
    IL_0026: stind.i4
    IL_0027: br.s IL_0043
    IL_0029: ldloc.3
    IL_002A: ldarg.2
    IL_002B: bne.un.s IL_0039
    IL_002D: ldloca.s V_0
    IL_002F: ldloc.3
    IL_0030: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0035: ldarg.1
    IL_0036: stind.i4
    IL_0037: br.s IL_0043
    IL_0039: ldloca.s V_0
    IL_003B: ldloc.3
    IL_003C: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0041: ldloc.3
    IL_0042: stind.i4
    IL_0043: ldloc.3
    IL_0044: ldc.i4.1
    IL_0045: add
    IL_0046: conv.u1
    IL_0047: stloc.3
    IL_0048: ldloc.3
    IL_0049: ldloca.s V_0
    IL_004B: call System.Int32 System.Span`1<System.Int32>::get_Length()
    IL_0050: blt.s IL_0019
    IL_0052: ldarga.s src
    IL_0054: ldloc.0
    IL_0055: call Z0.Vec256`1<System.Int32> Z0.Vec256::Load<System.Int32>(System.Span`1<System.Int32>)
    IL_005A: stloc.s V_4
    IL_005C: ldloca.s V_4
    IL_005E: call Z0.Vec256`1<System.Int32> Z0.dinx::perm8x32(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0063: ret

}
Vec256<byte> swaphl(in Vec256<byte> src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.Vec256`1<System.Byte>
    IL_0008: ldarg.0
    IL_0009: ldc.i4.1
    IL_000A: call Z0.Vec128`1<System.Byte> Z0.dinx::extract128(Z0.Vec256`1<System.Byte>&,System.Byte)
    IL_000F: stloc.1
    IL_0010: ldloca.s V_1
    IL_0012: ldloca.s V_0
    IL_0014: ldc.i4.0
    IL_0015: call Z0.Vec256`1<System.Byte> Z0.dinx::insert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,System.Byte)
    IL_001A: stloc.0
    IL_001B: ldarg.0
    IL_001C: ldc.i4.0
    IL_001D: call Z0.Vec128`1<System.Byte> Z0.dinx::extract128(Z0.Vec256`1<System.Byte>&,System.Byte)
    IL_0022: stloc.1
    IL_0023: ldloca.s V_1
    IL_0025: ldloca.s V_0
    IL_0027: ldc.i4.1
    IL_0028: call Z0.Vec256`1<System.Byte> Z0.dinx::insert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,System.Byte)
    IL_002D: stloc.0
    IL_002E: ldloc.0
    IL_002F: ret

}
Vec256<sbyte> swaphl(in Vec256<sbyte> src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.Vec256`1<System.SByte>
    IL_0008: ldarg.0
    IL_0009: ldc.i4.1
    IL_000A: call Z0.Vec128`1<System.SByte> Z0.dinx::extract128(Z0.Vec256`1<System.SByte>&,System.Byte)
    IL_000F: stloc.1
    IL_0010: ldloca.s V_1
    IL_0012: ldloca.s V_0
    IL_0014: ldc.i4.0
    IL_0015: call Z0.Vec256`1<System.SByte> Z0.dinx::insert(Z0.Vec128`1<System.SByte>&,Z0.Vec256`1<System.SByte>&,System.Byte)
    IL_001A: stloc.0
    IL_001B: ldarg.0
    IL_001C: ldc.i4.0
    IL_001D: call Z0.Vec128`1<System.SByte> Z0.dinx::extract128(Z0.Vec256`1<System.SByte>&,System.Byte)
    IL_0022: stloc.1
    IL_0023: ldloca.s V_1
    IL_0025: ldloca.s V_0
    IL_0027: ldc.i4.1
    IL_0028: call Z0.Vec256`1<System.SByte> Z0.dinx::insert(Z0.Vec128`1<System.SByte>&,Z0.Vec256`1<System.SByte>&,System.Byte)
    IL_002D: stloc.0
    IL_002E: ldloc.0
    IL_002F: ret

}
Vec256<short> swaphl(in Vec256<short> src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.Vec256`1<System.Int16>
    IL_0008: ldarg.0
    IL_0009: ldc.i4.1
    IL_000A: call Z0.Vec128`1<System.Int16> Z0.dinx::extract128(Z0.Vec256`1<System.Int16>&,System.Byte)
    IL_000F: stloc.1
    IL_0010: ldloca.s V_1
    IL_0012: ldloca.s V_0
    IL_0014: ldc.i4.0
    IL_0015: call Z0.Vec256`1<System.Int16> Z0.dinx::insert(Z0.Vec128`1<System.Int16>&,Z0.Vec256`1<System.Int16>&,System.Byte)
    IL_001A: stloc.0
    IL_001B: ldarg.0
    IL_001C: ldc.i4.0
    IL_001D: call Z0.Vec128`1<System.Int16> Z0.dinx::extract128(Z0.Vec256`1<System.Int16>&,System.Byte)
    IL_0022: stloc.1
    IL_0023: ldloca.s V_1
    IL_0025: ldloca.s V_0
    IL_0027: ldc.i4.1
    IL_0028: call Z0.Vec256`1<System.Int16> Z0.dinx::insert(Z0.Vec128`1<System.Int16>&,Z0.Vec256`1<System.Int16>&,System.Byte)
    IL_002D: stloc.0
    IL_002E: ldloc.0
    IL_002F: ret

}
Vec256<ushort> swaphl(in Vec256<ushort> src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.Vec256`1<System.UInt16>
    IL_0008: ldarg.0
    IL_0009: ldc.i4.1
    IL_000A: call Z0.Vec128`1<System.UInt16> Z0.dinx::extract128(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_000F: stloc.1
    IL_0010: ldloca.s V_1
    IL_0012: ldloca.s V_0
    IL_0014: ldc.i4.0
    IL_0015: call Z0.Vec256`1<System.UInt16> Z0.dinx::insert(Z0.Vec128`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_001A: stloc.0
    IL_001B: ldarg.0
    IL_001C: ldc.i4.0
    IL_001D: call Z0.Vec128`1<System.UInt16> Z0.dinx::extract128(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0022: stloc.1
    IL_0023: ldloca.s V_1
    IL_0025: ldloca.s V_0
    IL_0027: ldc.i4.1
    IL_0028: call Z0.Vec256`1<System.UInt16> Z0.dinx::insert(Z0.Vec128`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_002D: stloc.0
    IL_002E: ldloc.0
    IL_002F: ret

}
Vec256<long> swaphl(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldc.i4.s 78
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0017: ret

}
Vec256<ulong> swaphl(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldc.i4.s 78
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0017: ret

}
Vec256<double> swaphl(in Vec256<double> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>)
    IL_000B: ldc.i4.s 78
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0017: ret

}
Vec128<sbyte> unpackhi(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<byte> unpackhi(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<short> unpackhi(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<ushort> unpackhi(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec128<int> unpackhi(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec128<uint> unpackhi(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: ret

}
Vec128<long> unpackhi(in Vec128<long> lhs, in Vec128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: ret

}
Vec128<ulong> unpackhi(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: ret

}
Vec256<sbyte> unpackhi(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<byte> unpackhi(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<short> unpackhi(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<ushort> unpackhi(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
Vec256<int> unpackhi(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec256<uint> unpackhi(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0020: ret

}
Vec256<long> unpackhi(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0020: ret

}
Vec128<byte> sub(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<sbyte> sub(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<short> sub(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<ushort> sub(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec128<int> sub(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec128<uint> sub(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: ret

}
Vec128<long> sub(in Vec128<long> lhs, in Vec128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: ret

}
Vec128<ulong> sub(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: ret

}
Vec256<byte> sub(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<sbyte> sub(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<short> sub(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<ushort> sub(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
Vec256<int> sub(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec256<uint> sub(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0020: ret

}
Vec256<long> sub(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0020: ret

}
Vec256<ulong> sub(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0020: ret

}
Vec128<short> hsub(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Ssse3::HorizontalSubtract(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<int> hsub(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Ssse3::HorizontalSubtract(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec256<short> subh(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::HorizontalSubtract(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<int> hsub(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::HorizontalSubtract(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec128<byte> subs(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::SubtractSaturate(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<sbyte> subs(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::SubtractSaturate(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<short> subs(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::SubtractSaturate(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<ushort> subs(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::SubtractSaturate(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec256<byte> subs(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<sbyte> subs(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<short> subs(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<ushort> subs(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
short Sum(ReadOnlySpan<short> src)
{
    IL_0000: ldsfld System.Int32 Z0.Vec128`1<System.Int16>::Length
    IL_0005: stloc.0
    IL_0006: ldc.i4.2
    IL_0007: ldloc.0
    IL_0008: mul
    IL_0009: stloc.1
    IL_000A: ldarga.s src
    IL_000C: call System.Int32 System.ReadOnlySpan`1<System.Int16>::get_Length()
    IL_0011: stloc.2
    IL_0012: ldloc.2
    IL_0013: ldloc.1
    IL_0014: rem
    IL_0015: ldc.i4.0
    IL_0016: ceq
    IL_0018: ldnull
    IL_0019: ldstr "J:\\dev\\projects\\z0\\inx\\src\\core\\ops\\arithmetic\\sum.cs"
    IL_001E: ldstr "J:\\dev\\projects\\z0\\inx\\src\\core\\ops\\arithmetic\\sum.cs"
    IL_0023: ldc.i4.s 22
    IL_0025: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_002A: call System.Boolean zfunc::require(System.Boolean,System.String,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_002F: pop
    IL_0030: ldc.i4.0
    IL_0031: call Z0.Vec128`1<System.Int16> Z0.Vec128::Fill<System.Int16>(System.Int16)
    IL_0036: stloc.3
    IL_0037: ldc.i4.0
    IL_0038: stloc.s V_4
    IL_003A: ldc.i4.0
    IL_003B: stloc.s V_7
    IL_003D: br.s IL_007C
    IL_003F: ldarga.s src
    IL_0041: ldloc.s V_4
    IL_0043: call Z0.Vec128`1<System.Int16> Z0.Vec128::Load<System.Int16>(System.ReadOnlySpan`1<System.Int16>&,System.Int32)
    IL_0048: stloc.s V_8
    IL_004A: ldloc.s V_4
    IL_004C: ldloc.0
    IL_004D: add
    IL_004E: stloc.s V_4
    IL_0050: ldarga.s src
    IL_0052: ldloc.s V_4
    IL_0054: call Z0.Vec128`1<System.Int16> Z0.Vec128::Load<System.Int16>(System.ReadOnlySpan`1<System.Int16>&,System.Int32)
    IL_0059: stloc.s V_9
    IL_005B: ldloc.s V_4
    IL_005D: ldloc.0
    IL_005E: add
    IL_005F: stloc.s V_4
    IL_0061: ldloca.s V_8
    IL_0063: ldloca.s V_9
    IL_0065: call Z0.Vec128`1<System.Int16> Z0.dinx::hadd(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_006A: stloc.s V_10
    IL_006C: ldloca.s V_3
    IL_006E: ldloca.s V_10
    IL_0070: call Z0.Vec128`1<System.Int16> Z0.dinx::add(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_0075: stloc.3
    IL_0076: ldloc.s V_7
    IL_0078: ldloc.1
    IL_0079: add
    IL_007A: stloc.s V_7
    IL_007C: ldloc.s V_7
    IL_007E: ldloc.2
    IL_007F: blt.s IL_003F
    IL_0081: ldloc.0
    IL_0082: stloc.s V_11
    IL_0084: ldloc.s V_11
    IL_0086: conv.u
    IL_0087: ldc.i4.2
    IL_0088: mul.ovf.un
    IL_0089: localloc
    IL_008B: ldloc.s V_11
    IL_008D: newobj System.Void System.Span`1<System.Int16>::.ctor(System.Void*,System.Int32)
    IL_0092: stloc.s V_12
    IL_0094: ldloc.s V_12
    IL_0096: stloc.s V_5
    IL_0098: ldloca.s V_3
    IL_009A: ldloca.s V_5
    IL_009C: ldc.i4.0
    IL_009D: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_00A2: call System.Void zfunc::vstore<System.Int16>(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_00A7: ldc.i4.0
    IL_00A8: stloc.s V_6
    IL_00AA: ldc.i4.0
    IL_00AB: stloc.s V_13
    IL_00AD: br.s IL_00C5
    IL_00AF: ldloc.s V_6
    IL_00B1: ldloca.s V_5
    IL_00B3: ldloc.s V_13
    IL_00B5: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_00BA: ldind.i2
    IL_00BB: add
    IL_00BC: conv.i2
    IL_00BD: stloc.s V_6
    IL_00BF: ldloc.s V_13
    IL_00C1: ldc.i4.1
    IL_00C2: add
    IL_00C3: stloc.s V_13
    IL_00C5: ldloc.s V_13
    IL_00C7: ldloc.0
    IL_00C8: blt.s IL_00AF
    IL_00CA: ldloc.s V_6
    IL_00CC: ret

}
int Sum(ReadOnlySpan<int> src)
{
    IL_0000: ldsfld System.Int32 Z0.Vec128`1<System.Int32>::Length
    IL_0005: stloc.0
    IL_0006: ldc.i4.2
    IL_0007: ldloc.0
    IL_0008: mul
    IL_0009: stloc.1
    IL_000A: ldarga.s src
    IL_000C: call System.Int32 System.ReadOnlySpan`1<System.Int32>::get_Length()
    IL_0011: stloc.2
    IL_0012: ldloc.2
    IL_0013: ldloc.1
    IL_0014: rem
    IL_0015: ldc.i4.0
    IL_0016: ceq
    IL_0018: ldnull
    IL_0019: ldstr "J:\\dev\\projects\\z0\\inx\\src\\core\\ops\\arithmetic\\sum.cs"
    IL_001E: ldstr "J:\\dev\\projects\\z0\\inx\\src\\core\\ops\\arithmetic\\sum.cs"
    IL_0023: ldc.i4.s 51
    IL_0025: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_002A: call System.Boolean zfunc::require(System.Boolean,System.String,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_002F: pop
    IL_0030: ldc.i4.0
    IL_0031: call Z0.Vec128`1<System.Int32> Z0.Vec128::Fill<System.Int32>(System.Int32)
    IL_0036: stloc.3
    IL_0037: ldc.i4.0
    IL_0038: stloc.s V_4
    IL_003A: ldc.i4.0
    IL_003B: stloc.s V_7
    IL_003D: br.s IL_007C
    IL_003F: ldarga.s src
    IL_0041: ldloc.s V_4
    IL_0043: call Z0.Vec128`1<System.Int32> Z0.Vec128::Load<System.Int32>(System.ReadOnlySpan`1<System.Int32>&,System.Int32)
    IL_0048: stloc.s V_8
    IL_004A: ldloc.s V_4
    IL_004C: ldloc.0
    IL_004D: add
    IL_004E: stloc.s V_4
    IL_0050: ldarga.s src
    IL_0052: ldloc.s V_4
    IL_0054: call Z0.Vec128`1<System.Int32> Z0.Vec128::Load<System.Int32>(System.ReadOnlySpan`1<System.Int32>&,System.Int32)
    IL_0059: stloc.s V_9
    IL_005B: ldloc.s V_4
    IL_005D: ldloc.0
    IL_005E: add
    IL_005F: stloc.s V_4
    IL_0061: ldloca.s V_8
    IL_0063: ldloca.s V_9
    IL_0065: call Z0.Vec128`1<System.Int32> Z0.dinx::hadd(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_006A: stloc.s V_10
    IL_006C: ldloca.s V_3
    IL_006E: ldloca.s V_10
    IL_0070: call Z0.Vec128`1<System.Int32> Z0.dinx::add(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_0075: stloc.3
    IL_0076: ldloc.s V_7
    IL_0078: ldloc.1
    IL_0079: add
    IL_007A: stloc.s V_7
    IL_007C: ldloc.s V_7
    IL_007E: ldloc.2
    IL_007F: blt.s IL_003F
    IL_0081: ldloc.0
    IL_0082: stloc.s V_11
    IL_0084: ldloc.s V_11
    IL_0086: conv.u
    IL_0087: ldc.i4.4
    IL_0088: mul.ovf.un
    IL_0089: localloc
    IL_008B: ldloc.s V_11
    IL_008D: newobj System.Void System.Span`1<System.Int32>::.ctor(System.Void*,System.Int32)
    IL_0092: stloc.s V_12
    IL_0094: ldloc.s V_12
    IL_0096: stloc.s V_5
    IL_0098: ldloca.s V_3
    IL_009A: ldloca.s V_5
    IL_009C: ldc.i4.0
    IL_009D: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_00A2: call System.Void zfunc::vstore<System.Int32>(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_00A7: ldc.i4.0
    IL_00A8: stloc.s V_6
    IL_00AA: ldc.i4.0
    IL_00AB: stloc.s V_13
    IL_00AD: br.s IL_00C4
    IL_00AF: ldloc.s V_6
    IL_00B1: ldloca.s V_5
    IL_00B3: ldloc.s V_13
    IL_00B5: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_00BA: ldind.i4
    IL_00BB: add
    IL_00BC: stloc.s V_6
    IL_00BE: ldloc.s V_13
    IL_00C0: ldc.i4.1
    IL_00C1: add
    IL_00C2: stloc.s V_13
    IL_00C4: ldloc.s V_13
    IL_00C6: ldloc.0
    IL_00C7: blt.s IL_00AF
    IL_00C9: ldloc.s V_6
    IL_00CB: ret

}
int Sum(Span<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.ReadOnlySpan`1<System.Int32> Z0.SpanExtensions::ReadOnly<System.Int32>(System.Span`1<System.Int32>)
    IL_0006: call System.Int32 Z0.dinx::Sum(System.ReadOnlySpan`1<System.Int32>)
    IL_000B: ret

}
Vec128<sbyte> alignr(Vec128<sbyte> left, Vec128<sbyte> right, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0017: ret

}
Vec128<byte> alignr(Vec128<byte> left, Vec128<byte> right, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0017: ret

}
Vec128<short> alignr(Vec128<short> left, Vec128<short> right, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0017: ret

}
Vec128<ushort> alignr(Vec128<ushort> left, Vec128<ushort> right, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0017: ret

}
Vec128<int> alignr(Vec128<int> left, Vec128<int> right, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0017: ret

}
Vec128<uint> alignr(Vec128<uint> left, Vec128<uint> right, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0017: ret

}
Vec128<long> alignr(Vec128<long> left, Vec128<long> right, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0017: ret

}
Vec128<ulong> alignr(Vec128<ulong> left, Vec128<ulong> right, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0017: ret

}
Vec256<byte> alignr(Vec256<byte> left, Vec256<byte> right, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0017: ret

}
Vec256<sbyte> alignr(Vec256<sbyte> left, Vec256<sbyte> right, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0017: ret

}
Vec256<short> alignr(Vec256<short> left, Vec256<short> right, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0017: ret

}
Vec256<ushort> alignr(Vec256<ushort> left, Vec256<ushort> right, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0017: ret

}
Vec256<int> alignr(Vec256<int> left, Vec256<int> right, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0017: ret

}
Vec256<uint> alignr(Vec256<uint> left, Vec256<uint> right, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0017: ret

}
Vec256<long> alignr(Vec256<long> left, Vec256<long> right, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0017: ret

}
Vec256<ulong> alignr(Vec256<ulong> left, Vec256<ulong> right, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0017: ret

}
Vec128<short> blend(in Vec128<short> x, in Vec128<short> y, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::Blend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0021: ret

}
Vec128<ushort> blend(in Vec128<ushort> x, in Vec128<ushort> y, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse41::Blend(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0021: ret

}
Vec128<int> blend(in Vec128<int> x, in Vec128<int> y, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0021: ret

}
Vec128<uint> blend(in Vec128<uint> x, in Vec128<uint> y, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0021: ret

}
Vec256<short> blend(in Vec256<short> x, in Vec256<short> y, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0021: ret

}
Vec256<ushort> blend(in Vec256<ushort> x, in Vec256<ushort> y, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0021: ret

}
Vec256<int> blend(in Vec256<int> x, in Vec256<int> y, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0021: ret

}
Vec256<uint> blend(in Vec256<uint> x, in Vec256<uint> y, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0021: ret

}
Vec256<byte> blendv(in Vec256<byte> x, in Vec256<byte> y, in Vec256<byte> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldarg.2
    IL_0017: ldobj Z0.Vec256`1<System.Byte>
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0021: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0026: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_002B: ret

}
Vec256<sbyte> blendv(in Vec256<sbyte> x, in Vec256<sbyte> y, in Vec256<sbyte> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: ldarg.2
    IL_0017: ldobj Z0.Vec256`1<System.SByte>
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0021: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0026: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_002B: ret

}
Vec256<short> blendv(in Vec256<short> x, in Vec256<short> y, in Vec256<short> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: ldarg.2
    IL_0017: ldobj Z0.Vec256`1<System.Int16>
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0021: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0026: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_002B: ret

}
Vec256<ushort> blendv(in Vec256<ushort> x, in Vec256<ushort> y, in Vec256<ushort> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: ldarg.2
    IL_0017: ldobj Z0.Vec256`1<System.UInt16>
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0021: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0026: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_002B: ret

}
Vec256<int> blendv(in Vec256<int> x, in Vec256<int> y, in Vec256<int> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: ldarg.2
    IL_0017: ldobj Z0.Vec256`1<System.Int32>
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0021: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0026: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_002B: ret

}
Vec256<uint> blendv(in Vec256<uint> x, in Vec256<uint> y, in Vec256<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: ldarg.2
    IL_0017: ldobj Z0.Vec256`1<System.UInt32>
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0021: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0026: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_002B: ret

}
Vec256<long> blendv(in Vec256<long> x, in Vec256<long> y, in Vec256<long> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: ldarg.2
    IL_0017: ldobj Z0.Vec256`1<System.Int64>
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0021: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0026: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_002B: ret

}
Vec256<ulong> blendv(in Vec256<ulong> x, in Vec256<ulong> y, in Vec256<ulong> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0016: ldarg.2
    IL_0017: ldobj Z0.Vec256`1<System.UInt64>
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0021: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0026: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_002B: ret

}
ref Vec256<sbyte> broadcast(in sbyte src, out Vec256<sbyte> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.SByte& Z0.As::asRef<System.SByte>(System.SByte&)
    IL_0007: call System.SByte* Z0.As::refptr(System.SByte&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.SByte*)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: stobj Z0.Vec256`1<System.SByte>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<byte> broadcast(in byte src, out Vec256<byte> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Byte& Z0.As::asRef<System.Byte>(System.Byte&)
    IL_0007: call System.Byte* Z0.As::refptr(System.Byte&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.Byte*)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: stobj Z0.Vec256`1<System.Byte>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<short> broadcast(in short src, out Vec256<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int16& Z0.As::asRef<System.Int16>(System.Int16&)
    IL_0007: call System.Int16* Z0.As::refptr(System.Int16&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.Int16*)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: stobj Z0.Vec256`1<System.Int16>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<ushort> broadcast(in ushort src, out Vec256<ushort> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt16& Z0.As::asRef<System.UInt16>(System.UInt16&)
    IL_0007: call System.UInt16* Z0.As::refptr(System.UInt16&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.UInt16*)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: stobj Z0.Vec256`1<System.UInt16>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<int> broadcast(in int src, out Vec256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int32& Z0.As::asRef<System.Int32>(System.Int32&)
    IL_0007: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.Int32*)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: stobj Z0.Vec256`1<System.Int32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<uint> broadcast(in uint src, out Vec256<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt32& Z0.As::asRef<System.UInt32>(System.UInt32&)
    IL_0007: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.UInt32*)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: stobj Z0.Vec256`1<System.UInt32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<long> broadcast(in long src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int64& Z0.As::asRef<System.Int64>(System.Int64&)
    IL_0007: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.Int64*)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: stobj Z0.Vec256`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<ulong> broadcast(in ulong src, out Vec256<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt64& Z0.As::asRef<System.UInt64>(System.UInt64&)
    IL_0007: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.UInt64*)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: stobj Z0.Vec256`1<System.UInt64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<sbyte> broadcast(in sbyte src, out Vec128<sbyte> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.SByte& Z0.As::asRef<System.SByte>(System.SByte&)
    IL_0007: call System.SByte* Z0.As::refptr(System.SByte&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.SByte*)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: stobj Z0.Vec128`1<System.SByte>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<byte> broadcast(in byte src, out Vec128<byte> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Byte& Z0.As::asRef<System.Byte>(System.Byte&)
    IL_0007: call System.Byte* Z0.As::refptr(System.Byte&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.Byte*)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: stobj Z0.Vec128`1<System.Byte>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<short> broadcast(in short src, out Vec128<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int16& Z0.As::asRef<System.Int16>(System.Int16&)
    IL_0007: call System.Int16* Z0.As::refptr(System.Int16&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.Int16*)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: stobj Z0.Vec128`1<System.Int16>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<ushort> broadcast(in ushort src, out Vec128<ushort> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt16& Z0.As::asRef<System.UInt16>(System.UInt16&)
    IL_0007: call System.UInt16* Z0.As::refptr(System.UInt16&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.UInt16*)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: stobj Z0.Vec128`1<System.UInt16>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<int> broadcast(in int src, out Vec128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int32& Z0.As::asRef<System.Int32>(System.Int32&)
    IL_0007: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.Int32*)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: stobj Z0.Vec128`1<System.Int32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<uint> broadcast(in uint src, out Vec128<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt32& Z0.As::asRef<System.UInt32>(System.UInt32&)
    IL_0007: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.UInt32*)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: stobj Z0.Vec128`1<System.UInt32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<long> broadcast(in long src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int64& Z0.As::asRef<System.Int64>(System.Int64&)
    IL_0007: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.Int64*)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: stobj Z0.Vec128`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<ulong> broadcast(in ulong src, out Vec128<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt64& Z0.As::asRef<System.UInt64>(System.UInt64&)
    IL_0007: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.UInt64*)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: stobj Z0.Vec128`1<System.UInt64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<short> convert(in Vec128<sbyte> src, out Vec128<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int16(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: stobj Z0.Vec128`1<System.Int16>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<int> convert(in Vec128<sbyte> src, out Vec128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: stobj Z0.Vec128`1<System.Int32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<long> convert(in Vec128<sbyte> src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: stobj Z0.Vec128`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<short> convert(in Vec128<byte> src, out Vec128<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: stobj Z0.Vec128`1<System.Int16>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<int> convert(in Vec128<byte> src, out Vec128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: stobj Z0.Vec128`1<System.Int32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<long> convert(in Vec128<byte> src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: stobj Z0.Vec128`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
Vec128<int> convert(in Vec128<short> src, out Vec128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Int16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: dup
    IL_0017: stloc.0
    IL_0018: stobj Z0.Vec128`1<System.Int32>
    IL_001D: ldloc.0
    IL_001E: ret

}
ref Vec128<long> convert(in Vec128<short> src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Int16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: stobj Z0.Vec128`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<int> convert(in Vec128<ushort> src, out Vec128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: stobj Z0.Vec128`1<System.Int32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<long> convert(in Vec128<ushort> src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: stobj Z0.Vec128`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<long> convert(in Vec128<int> src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Int32>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: stobj Z0.Vec128`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<long> convert(in Vec128<uint> src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt32>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: stobj Z0.Vec128`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<short> convert(in Vec128<sbyte> src, out Vec256<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int16(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: stobj Z0.Vec256`1<System.Int16>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<int> convert(in Vec128<sbyte> src, out Vec256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: stobj Z0.Vec256`1<System.Int32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<long> convert(in Vec128<sbyte> src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: stobj Z0.Vec256`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<short> convert(in Vec128<byte> src, out Vec256<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: stobj Z0.Vec256`1<System.Int16>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<int> convert(in Vec128<byte> src, out Vec256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: stobj Z0.Vec256`1<System.Int32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<long> convert(in Vec128<byte> src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: stobj Z0.Vec256`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<int> convert(in Vec128<short> src, out Vec256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Int16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: stobj Z0.Vec256`1<System.Int32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<long> convert(in Vec128<int> src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Int32>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: stobj Z0.Vec256`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<long> convert(in Vec128<short> src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Int16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: stobj Z0.Vec256`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<int> convert(in Vec128<ushort> src, out Vec256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: stobj Z0.Vec256`1<System.Int32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<int> convert(ref ushort src, out Vec256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt16* Z0.As::refptr(System.UInt16&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.UInt16*)
    IL_000C: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stobj Z0.Vec256`1<System.Int32>
    IL_0016: ldarg.1
    IL_0017: ret

}
ref Vec256<long> convert(in Vec128<ushort> src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: stobj Z0.Vec256`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<long> convert(ref ushort src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt16* Z0.As::refptr(System.UInt16&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.UInt16*)
    IL_000C: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stobj Z0.Vec256`1<System.Int64>
    IL_0016: ldarg.1
    IL_0017: ret

}
ref Vec256<long> convert(in Vec128<uint> src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt32>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: stobj Z0.Vec256`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<long> convert(ref uint src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.UInt32*)
    IL_000C: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stobj Z0.Vec256`1<System.Int64>
    IL_0016: ldarg.1
    IL_0017: ret

}
byte extract(in Vec128<byte> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: call System.Byte System.Runtime.Intrinsics.X86.Sse41::Extract(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0011: ret

}
uint extract(in Vec128<ushort> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.UInt16 System.Runtime.Intrinsics.X86.Sse2::Extract(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: ret

}
int extract(in Vec128<int> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Int32 System.Runtime.Intrinsics.X86.Sse41::Extract(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0011: ret

}
uint extract(in Vec128<uint> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.UInt32 System.Runtime.Intrinsics.X86.Sse41::Extract(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: ret

}
long extract(in Vec128<long> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Int64 System.Runtime.Intrinsics.X86.Sse41/X64::Extract(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0011: ret

}
ulong extract(in Vec128<ulong> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.UInt64 System.Runtime.Intrinsics.X86.Sse41/X64::Extract(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0011: ret

}
float extract(in Vec128<float> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: call System.Single System.Runtime.Intrinsics.X86.Sse41::Extract(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Byte)
    IL_0011: ret

}
Vec128<sbyte> extract128(in Vec256<sbyte> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<byte> extract128(in Vec256<byte> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<short> extract128(in Vec256<short> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> extract128(in Vec256<ushort> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> extract128(in Vec256<int> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> extract128(in Vec256<uint> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> extract128(in Vec256<long> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> extract128(in Vec256<ulong> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec128<float> extract128(in Vec256<float> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0016: ret

}
Vec128<double> extract128(in Vec256<double> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0016: ret

}
Vec128<byte> insert(byte src, in Vec128<byte> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.0
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse41::Insert(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte,System.Byte)
    IL_0012: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0017: ret

}
Vec128<sbyte> insert(sbyte src, in Vec128<sbyte> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.0
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse41::Insert(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.SByte,System.Byte)
    IL_0012: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0017: ret

}
Vec128<short> insert(short src, in Vec128<short> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.0
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Insert(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Int16,System.Byte)
    IL_0012: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0017: ret

}
Vec128<ushort> insert(ushort src, in Vec128<ushort> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.0
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Insert(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.UInt16,System.Byte)
    IL_0012: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0017: ret

}
Vec128<int> insert(int src, in Vec128<int> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.0
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::Insert(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Int32,System.Byte)
    IL_0012: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0017: ret

}
Vec128<byte> abs(in Vec128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::Abs(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0010: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0015: ret

}
Vec128<ushort> abs(in Vec128<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Ssse3::Abs(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0010: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0015: ret

}
Vec128<uint> abs(in Vec128<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Ssse3::Abs(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0010: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0015: ret

}
Vec128<long> abs(in Vec128<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 63
    IL_0003: call Z0.Vec128`1<System.Int64> Z0.dinx::srl(Z0.Vec128`1<System.Int64>&,System.Byte)
    IL_0008: stloc.1
    IL_0009: ldloca.s V_1
    IL_000B: call Z0.Vec128`1<System.Int64> Z0.dinx::negate(Z0.Vec128`1<System.Int64>&)
    IL_0010: stloc.0
    IL_0011: ldloca.s V_0
    IL_0013: ldarg.0
    IL_0014: call Z0.Vec128`1<System.Int64> Z0.dinx::xor(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldloca.s V_0
    IL_001E: call Z0.Vec128`1<System.Int64> Z0.dinx::sub(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0023: ret

}
Vec256<byte> abs(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0010: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0015: ret

}
Vec256<ushort> abs(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0010: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0015: ret

}
Vec256<uint> abs(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0010: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0015: ret

}
Vec256<long> abs(Vec256<long> src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.s 63
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.dinx::srl(Z0.Vec256`1<System.Int64>&,System.Byte)
    IL_0009: stloc.1
    IL_000A: ldloca.s V_1
    IL_000C: call Z0.Vec256`1<System.Int64> Z0.dinx::negate(Z0.Vec256`1<System.Int64>&)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: ldarga.s src
    IL_0016: call Z0.Vec256`1<System.Int64> Z0.dinx::xor(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_001B: stloc.1
    IL_001C: ldloca.s V_1
    IL_001E: ldloca.s V_0
    IL_0020: call Z0.Vec256`1<System.Int64> Z0.dinx::sub(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_0025: ret

}
Span128<byte> abs(ReadOnlySpan128<sbyte> src, Span128<byte> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_002D
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) Z0.ReadOnlySpan128`1<System.SByte>::Block(System.Int32)
    IL_000C: call Z0.Vec128`1<System.SByte> Z0.Vec128::Loadi<System.SByte>(System.SByte&)
    IL_0011: stloc.1
    IL_0012: ldloca.s V_1
    IL_0014: call Z0.Vec128`1<System.Byte> Z0.dinx::abs(Z0.Vec128`1<System.SByte>&)
    IL_0019: stloc.2
    IL_001A: ldloca.s V_2
    IL_001C: ldarga.s dst
    IL_001E: ldloc.0
    IL_001F: call System.Byte& Z0.Span128`1<System.Byte>::get_Item(System.Int32)
    IL_0024: call System.Void zfunc::vstore<System.Byte>(Z0.Vec128`1<System.Byte>&,System.Byte&)
    IL_0029: ldloc.0
    IL_002A: ldc.i4.1
    IL_002B: add
    IL_002C: stloc.0
    IL_002D: ldloc.0
    IL_002E: ldarga.s src
    IL_0030: call System.Int32 Z0.ReadOnlySpan128`1<System.SByte>::get_BlockCount()
    IL_0035: blt.s IL_0004
    IL_0037: ldarg.1
    IL_0038: ret

}
Span128<ushort> abs(ReadOnlySpan128<short> src, Span128<ushort> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_002D
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) Z0.ReadOnlySpan128`1<System.Int16>::Block(System.Int32)
    IL_000C: call Z0.Vec128`1<System.Int16> Z0.Vec128::Loadi<System.Int16>(System.Int16&)
    IL_0011: stloc.1
    IL_0012: ldloca.s V_1
    IL_0014: call Z0.Vec128`1<System.UInt16> Z0.dinx::abs(Z0.Vec128`1<System.Int16>&)
    IL_0019: stloc.2
    IL_001A: ldloca.s V_2
    IL_001C: ldarga.s dst
    IL_001E: ldloc.0
    IL_001F: call System.UInt16& Z0.Span128`1<System.UInt16>::get_Item(System.Int32)
    IL_0024: call System.Void zfunc::vstore<System.UInt16>(Z0.Vec128`1<System.UInt16>&,System.UInt16&)
    IL_0029: ldloc.0
    IL_002A: ldc.i4.1
    IL_002B: add
    IL_002C: stloc.0
    IL_002D: ldloc.0
    IL_002E: ldarga.s src
    IL_0030: call System.Int32 Z0.ReadOnlySpan128`1<System.Int16>::get_BlockCount()
    IL_0035: blt.s IL_0004
    IL_0037: ldarg.1
    IL_0038: ret

}
Span128<uint> abs(ReadOnlySpan128<int> src, Span128<uint> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_002D
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) Z0.ReadOnlySpan128`1<System.Int32>::Block(System.Int32)
    IL_000C: call Z0.Vec128`1<System.Int32> Z0.Vec128::Loadi<System.Int32>(System.Int32&)
    IL_0011: stloc.1
    IL_0012: ldloca.s V_1
    IL_0014: call Z0.Vec128`1<System.UInt32> Z0.dinx::abs(Z0.Vec128`1<System.Int32>&)
    IL_0019: stloc.2
    IL_001A: ldloca.s V_2
    IL_001C: ldarga.s dst
    IL_001E: ldloc.0
    IL_001F: call System.UInt32& Z0.Span128`1<System.UInt32>::get_Item(System.Int32)
    IL_0024: call System.Void zfunc::vstore<System.UInt32>(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_0029: ldloc.0
    IL_002A: ldc.i4.1
    IL_002B: add
    IL_002C: stloc.0
    IL_002D: ldloc.0
    IL_002E: ldarga.s src
    IL_0030: call System.Int32 Z0.ReadOnlySpan128`1<System.Int32>::get_BlockCount()
    IL_0035: blt.s IL_0004
    IL_0037: ldarg.1
    IL_0038: ret

}
Span256<byte> abs(ReadOnlySpan256<sbyte> src, Span256<byte> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_002D
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.SByte& modreq(System.Runtime.InteropServices.InAttribute) Z0.ReadOnlySpan256`1<System.SByte>::Block(System.Int32)
    IL_000C: call Z0.Vec256`1<System.SByte> Z0.Vec256::Loadi<System.SByte>(System.SByte&)
    IL_0011: stloc.1
    IL_0012: ldloca.s V_1
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.dinx::abs(Z0.Vec256`1<System.SByte>&)
    IL_0019: stloc.2
    IL_001A: ldloca.s V_2
    IL_001C: ldarga.s dst
    IL_001E: ldloc.0
    IL_001F: call System.Byte& Z0.Span256`1<System.Byte>::get_Item(System.Int32)
    IL_0024: call System.Void zfunc::vstore<System.Byte>(Z0.Vec256`1<System.Byte>&,System.Byte&)
    IL_0029: ldloc.0
    IL_002A: ldc.i4.1
    IL_002B: add
    IL_002C: stloc.0
    IL_002D: ldloc.0
    IL_002E: ldarga.s src
    IL_0030: call System.Int32 Z0.ReadOnlySpan256`1<System.SByte>::get_BlockCount()
    IL_0035: blt.s IL_0004
    IL_0037: ldarg.1
    IL_0038: ret

}
Span256<ushort> abs(ReadOnlySpan256<short> src, Span256<ushort> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_002D
    IL_0004: ldarga.s src
    IL_0006: ldloc.0
    IL_0007: call System.Int16& modreq(System.Runtime.InteropServices.InAttribute) Z0.ReadOnlySpan256`1<System.Int16>::Block(System.Int32)
    IL_000C: call Z0.Vec256`1<System.Int16> Z0.Vec256::Loadi<System.Int16>(System.Int16&)
    IL_0011: stloc.1
    IL_0012: ldloca.s V_1
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.dinx::abs(Z0.Vec256`1<System.Int16>&)
    IL_0019: stloc.2
    IL_001A: ldloca.s V_2
    IL_001C: ldarga.s dst
    IL_001E: ldloc.0
    IL_001F: call System.UInt16& Z0.Span256`1<System.UInt16>::get_Item(System.Int32)
    IL_0024: call System.Void zfunc::vstore<System.UInt16>(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_0029: ldloc.0
    IL_002A: ldc.i4.1
    IL_002B: add
    IL_002C: stloc.0
    IL_002D: ldloc.0
    IL_002E: ldarga.s src
    IL_0030: call System.Int32 Z0.ReadOnlySpan256`1<System.Int16>::get_BlockCount()
    IL_0035: blt.s IL_0004
    IL_0037: ldarg.1
    IL_0038: ret

}
Span256<uint> abs(in ReadOnlySpan256<int> src, Span256<uint> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0034
    IL_0004: ldarg.0
    IL_0005: ldobj Z0.ReadOnlySpan256`1<System.Int32>
    IL_000A: stloc.2
    IL_000B: ldloca.s V_2
    IL_000D: ldloc.0
    IL_000E: call System.Int32& modreq(System.Runtime.InteropServices.InAttribute) Z0.ReadOnlySpan256`1<System.Int32>::Block(System.Int32)
    IL_0013: call Z0.Vec256`1<System.Int32> Z0.Vec256::Loadi<System.Int32>(System.Int32&)
    IL_0018: stloc.1
    IL_0019: ldloca.s V_1
    IL_001B: call Z0.Vec256`1<System.UInt32> Z0.dinx::abs(Z0.Vec256`1<System.Int32>&)
    IL_0020: stloc.3
    IL_0021: ldloca.s V_3
    IL_0023: ldarga.s dst
    IL_0025: ldloc.0
    IL_0026: call System.UInt32& Z0.Span256`1<System.UInt32>::get_Item(System.Int32)
    IL_002B: call System.Void zfunc::vstore<System.UInt32>(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_0030: ldloc.0
    IL_0031: ldc.i4.1
    IL_0032: add
    IL_0033: stloc.0
    IL_0034: ldloc.0
    IL_0035: ldarg.0
    IL_0036: ldobj Z0.ReadOnlySpan256`1<System.Int32>
    IL_003B: stloc.2
    IL_003C: ldloca.s V_2
    IL_003E: call System.Int32 Z0.ReadOnlySpan256`1<System.Int32>::get_BlockCount()
    IL_0043: blt.s IL_0004
    IL_0045: ldarg.1
    IL_0046: ret

}
Vec128<byte> add(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<sbyte> add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<short> add(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<ushort> add(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec128<int> add(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec128<uint> add(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: ret

}
Vec128<long> add(in Vec128<long> lhs, in Vec128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: ret

}
Vec128<ulong> add(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: ret

}
Vec256<byte> add(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<sbyte> add(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<short> add(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<ushort> add(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
Vec256<int> add(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec256<uint> add(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0020: ret

}
Vec256<long> add(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0020: ret

}
Vec256<ulong> add(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0020: ret

}
Span128<sbyte> add(ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, Span128<sbyte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span128`1<System.SByte>::get_BlockCount()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_003A
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec128`1<System.SByte> Z0.ginxs::LoadVec128<System.SByte>(Z0.ReadOnlySpan128`1<System.SByte>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: ldloc.1
    IL_0018: call Z0.Vec128`1<System.SByte> Z0.ginxs::LoadVec128<System.SByte>(Z0.ReadOnlySpan128`1<System.SByte>,System.Int32)
    IL_001D: stloc.3
    IL_001E: ldloca.s V_3
    IL_0020: call Z0.Vec128`1<System.SByte> Z0.dinx::add(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_0025: stloc.s V_4
    IL_0027: ldloca.s V_4
    IL_0029: ldarga.s dst
    IL_002B: ldloc.1
    IL_002C: call System.SByte& Z0.Span128`1<System.SByte>::Block(System.Int32)
    IL_0031: call System.Void zfunc::vstore<System.SByte>(Z0.Vec128`1<System.SByte>&,System.SByte&)
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_000C
    IL_003E: ldarg.2
    IL_003F: ret

}
Span128<byte> add(ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, Span128<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span128`1<System.Byte>::get_BlockCount()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_003A
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec128`1<System.Byte> Z0.ginxs::LoadVec128<System.Byte>(Z0.ReadOnlySpan128`1<System.Byte>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: ldloc.1
    IL_0018: call Z0.Vec128`1<System.Byte> Z0.ginxs::LoadVec128<System.Byte>(Z0.ReadOnlySpan128`1<System.Byte>,System.Int32)
    IL_001D: stloc.3
    IL_001E: ldloca.s V_3
    IL_0020: call Z0.Vec128`1<System.Byte> Z0.dinx::add(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0025: stloc.s V_4
    IL_0027: ldloca.s V_4
    IL_0029: ldarga.s dst
    IL_002B: ldloc.1
    IL_002C: call System.Byte& Z0.Span128`1<System.Byte>::Block(System.Int32)
    IL_0031: call System.Void zfunc::vstore<System.Byte>(Z0.Vec128`1<System.Byte>&,System.Byte&)
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_000C
    IL_003E: ldarg.2
    IL_003F: ret

}
Span128<short> add(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, Span128<short> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span128`1<System.Int16>::get_BlockCount()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_003A
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec128`1<System.Int16> Z0.ginxs::LoadVec128<System.Int16>(Z0.ReadOnlySpan128`1<System.Int16>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: ldloc.1
    IL_0018: call Z0.Vec128`1<System.Int16> Z0.ginxs::LoadVec128<System.Int16>(Z0.ReadOnlySpan128`1<System.Int16>,System.Int32)
    IL_001D: stloc.3
    IL_001E: ldloca.s V_3
    IL_0020: call Z0.Vec128`1<System.Int16> Z0.dinx::add(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_0025: stloc.s V_4
    IL_0027: ldloca.s V_4
    IL_0029: ldarga.s dst
    IL_002B: ldloc.1
    IL_002C: call System.Int16& Z0.Span128`1<System.Int16>::Block(System.Int32)
    IL_0031: call System.Void zfunc::vstore<System.Int16>(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_000C
    IL_003E: ldarg.2
    IL_003F: ret

}
Span128<ushort> add(ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, Span128<ushort> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span128`1<System.UInt16>::get_BlockCount()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_003A
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec128`1<System.UInt16> Z0.ginxs::LoadVec128<System.UInt16>(Z0.ReadOnlySpan128`1<System.UInt16>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: ldloc.1
    IL_0018: call Z0.Vec128`1<System.UInt16> Z0.ginxs::LoadVec128<System.UInt16>(Z0.ReadOnlySpan128`1<System.UInt16>,System.Int32)
    IL_001D: stloc.3
    IL_001E: ldloca.s V_3
    IL_0020: call Z0.Vec128`1<System.UInt16> Z0.dinx::add(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0025: stloc.s V_4
    IL_0027: ldloca.s V_4
    IL_0029: ldarga.s dst
    IL_002B: ldloc.1
    IL_002C: call System.UInt16& Z0.Span128`1<System.UInt16>::Block(System.Int32)
    IL_0031: call System.Void zfunc::vstore<System.UInt16>(Z0.Vec128`1<System.UInt16>&,System.UInt16&)
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_000C
    IL_003E: ldarg.2
    IL_003F: ret

}
Span128<int> add(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, Span128<int> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span128`1<System.Int32>::get_BlockCount()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_003A
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec128`1<System.Int32> Z0.ginxs::LoadVec128<System.Int32>(Z0.ReadOnlySpan128`1<System.Int32>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: ldloc.1
    IL_0018: call Z0.Vec128`1<System.Int32> Z0.ginxs::LoadVec128<System.Int32>(Z0.ReadOnlySpan128`1<System.Int32>,System.Int32)
    IL_001D: stloc.3
    IL_001E: ldloca.s V_3
    IL_0020: call Z0.Vec128`1<System.Int32> Z0.dinx::add(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_0025: stloc.s V_4
    IL_0027: ldloca.s V_4
    IL_0029: ldarga.s dst
    IL_002B: ldloc.1
    IL_002C: call System.Int32& Z0.Span128`1<System.Int32>::Block(System.Int32)
    IL_0031: call System.Void zfunc::vstore<System.Int32>(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_000C
    IL_003E: ldarg.2
    IL_003F: ret

}
Span128<uint> add(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, Span128<uint> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span128`1<System.UInt32>::get_BlockCount()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_003A
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec128`1<System.UInt32> Z0.ginxs::LoadVec128<System.UInt32>(Z0.ReadOnlySpan128`1<System.UInt32>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: ldloc.1
    IL_0018: call Z0.Vec128`1<System.UInt32> Z0.ginxs::LoadVec128<System.UInt32>(Z0.ReadOnlySpan128`1<System.UInt32>,System.Int32)
    IL_001D: stloc.3
    IL_001E: ldloca.s V_3
    IL_0020: call Z0.Vec128`1<System.UInt32> Z0.dinx::add(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0025: stloc.s V_4
    IL_0027: ldloca.s V_4
    IL_0029: ldarga.s dst
    IL_002B: ldloc.1
    IL_002C: call System.UInt32& Z0.Span128`1<System.UInt32>::Block(System.Int32)
    IL_0031: call System.Void zfunc::vstore<System.UInt32>(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_000C
    IL_003E: ldarg.2
    IL_003F: ret

}
Span128<long> add(ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, Span128<long> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span128`1<System.Int64>::get_BlockCount()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_003A
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec128`1<System.Int64> Z0.ginxs::LoadVec128<System.Int64>(Z0.ReadOnlySpan128`1<System.Int64>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: ldloc.1
    IL_0018: call Z0.Vec128`1<System.Int64> Z0.ginxs::LoadVec128<System.Int64>(Z0.ReadOnlySpan128`1<System.Int64>,System.Int32)
    IL_001D: stloc.3
    IL_001E: ldloca.s V_3
    IL_0020: call Z0.Vec128`1<System.Int64> Z0.dinx::add(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0025: stloc.s V_4
    IL_0027: ldloca.s V_4
    IL_0029: ldarga.s dst
    IL_002B: ldloc.1
    IL_002C: call System.Int64& Z0.Span128`1<System.Int64>::Block(System.Int32)
    IL_0031: call System.Void zfunc::vstore<System.Int64>(Z0.Vec128`1<System.Int64>&,System.Int64&)
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_000C
    IL_003E: ldarg.2
    IL_003F: ret

}
Span128<ulong> add(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, Span128<ulong> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span128`1<System.UInt64>::get_BlockCount()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_003A
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec128`1<System.UInt64> Z0.ginxs::LoadVec128<System.UInt64>(Z0.ReadOnlySpan128`1<System.UInt64>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: ldloc.1
    IL_0018: call Z0.Vec128`1<System.UInt64> Z0.ginxs::LoadVec128<System.UInt64>(Z0.ReadOnlySpan128`1<System.UInt64>,System.Int32)
    IL_001D: stloc.3
    IL_001E: ldloca.s V_3
    IL_0020: call Z0.Vec128`1<System.UInt64> Z0.dinx::add(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0025: stloc.s V_4
    IL_0027: ldloca.s V_4
    IL_0029: ldarga.s dst
    IL_002B: ldloc.1
    IL_002C: call System.UInt64& Z0.Span128`1<System.UInt64>::Block(System.Int32)
    IL_0031: call System.Void zfunc::vstore<System.UInt64>(Z0.Vec128`1<System.UInt64>&,System.UInt64&)
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_000C
    IL_003E: ldarg.2
    IL_003F: ret

}
Span256<sbyte> add(ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, Span256<sbyte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span256`1<System.SByte>::get_BlockCount()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_003A
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec256`1<System.SByte> Z0.ginxs::LoadVec256<System.SByte>(Z0.ReadOnlySpan256`1<System.SByte>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: ldloc.1
    IL_0018: call Z0.Vec256`1<System.SByte> Z0.ginxs::LoadVec256<System.SByte>(Z0.ReadOnlySpan256`1<System.SByte>,System.Int32)
    IL_001D: stloc.3
    IL_001E: ldloca.s V_3
    IL_0020: call Z0.Vec256`1<System.SByte> Z0.dinx::add(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_0025: stloc.s V_4
    IL_0027: ldloca.s V_4
    IL_0029: ldarga.s dst
    IL_002B: ldloc.1
    IL_002C: call System.SByte& Z0.Span256`1<System.SByte>::Block(System.Int32)
    IL_0031: call System.Void zfunc::vstore<System.SByte>(Z0.Vec256`1<System.SByte>&,System.SByte&)
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_000C
    IL_003E: ldarg.2
    IL_003F: ret

}
Span256<byte> add(ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, Span256<byte> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span256`1<System.Byte>::get_BlockCount()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_003A
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec256`1<System.Byte> Z0.ginxs::LoadVec256<System.Byte>(Z0.ReadOnlySpan256`1<System.Byte>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: ldloc.1
    IL_0018: call Z0.Vec256`1<System.Byte> Z0.ginxs::LoadVec256<System.Byte>(Z0.ReadOnlySpan256`1<System.Byte>,System.Int32)
    IL_001D: stloc.3
    IL_001E: ldloca.s V_3
    IL_0020: call Z0.Vec256`1<System.Byte> Z0.dinx::add(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0025: stloc.s V_4
    IL_0027: ldloca.s V_4
    IL_0029: ldarga.s dst
    IL_002B: ldloc.1
    IL_002C: call System.Byte& Z0.Span256`1<System.Byte>::Block(System.Int32)
    IL_0031: call System.Void zfunc::vstore<System.Byte>(Z0.Vec256`1<System.Byte>&,System.Byte&)
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_000C
    IL_003E: ldarg.2
    IL_003F: ret

}
Span256<short> add(ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, Span256<short> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span256`1<System.Int16>::get_BlockCount()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_003A
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec256`1<System.Int16> Z0.ginxs::LoadVec256<System.Int16>(Z0.ReadOnlySpan256`1<System.Int16>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: ldloc.1
    IL_0018: call Z0.Vec256`1<System.Int16> Z0.ginxs::LoadVec256<System.Int16>(Z0.ReadOnlySpan256`1<System.Int16>,System.Int32)
    IL_001D: stloc.3
    IL_001E: ldloca.s V_3
    IL_0020: call Z0.Vec256`1<System.Int16> Z0.dinx::add(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_0025: stloc.s V_4
    IL_0027: ldloca.s V_4
    IL_0029: ldarga.s dst
    IL_002B: ldloc.1
    IL_002C: call System.Int16& Z0.Span256`1<System.Int16>::Block(System.Int32)
    IL_0031: call System.Void zfunc::vstore<System.Int16>(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_000C
    IL_003E: ldarg.2
    IL_003F: ret

}
Span256<ushort> add(ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, Span256<ushort> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span256`1<System.UInt16>::get_BlockCount()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_003A
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec256`1<System.UInt16> Z0.ginxs::LoadVec256<System.UInt16>(Z0.ReadOnlySpan256`1<System.UInt16>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: ldloc.1
    IL_0018: call Z0.Vec256`1<System.UInt16> Z0.ginxs::LoadVec256<System.UInt16>(Z0.ReadOnlySpan256`1<System.UInt16>,System.Int32)
    IL_001D: stloc.3
    IL_001E: ldloca.s V_3
    IL_0020: call Z0.Vec256`1<System.UInt16> Z0.dinx::add(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_0025: stloc.s V_4
    IL_0027: ldloca.s V_4
    IL_0029: ldarga.s dst
    IL_002B: ldloc.1
    IL_002C: call System.UInt16& Z0.Span256`1<System.UInt16>::get_Item(System.Int32)
    IL_0031: call System.Void zfunc::vstore<System.UInt16>(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_000C
    IL_003E: ldarg.2
    IL_003F: ret

}
Span256<int> add(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, Span256<int> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span256`1<System.Int32>::get_BlockCount()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_003A
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec256`1<System.Int32> Z0.ginxs::LoadVec256<System.Int32>(Z0.ReadOnlySpan256`1<System.Int32>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: ldloc.1
    IL_0018: call Z0.Vec256`1<System.Int32> Z0.ginxs::LoadVec256<System.Int32>(Z0.ReadOnlySpan256`1<System.Int32>,System.Int32)
    IL_001D: stloc.3
    IL_001E: ldloca.s V_3
    IL_0020: call Z0.Vec256`1<System.Int32> Z0.dinx::add(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0025: stloc.s V_4
    IL_0027: ldloca.s V_4
    IL_0029: ldarga.s dst
    IL_002B: ldloc.1
    IL_002C: call System.Int32& Z0.Span256`1<System.Int32>::Block(System.Int32)
    IL_0031: call System.Void zfunc::vstore<System.Int32>(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_000C
    IL_003E: ldarg.2
    IL_003F: ret

}
Span256<uint> add(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, Span256<uint> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span256`1<System.UInt32>::get_BlockCount()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_003A
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec256`1<System.UInt32> Z0.ginxs::LoadVec256<System.UInt32>(Z0.ReadOnlySpan256`1<System.UInt32>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: ldloc.1
    IL_0018: call Z0.Vec256`1<System.UInt32> Z0.ginxs::LoadVec256<System.UInt32>(Z0.ReadOnlySpan256`1<System.UInt32>,System.Int32)
    IL_001D: stloc.3
    IL_001E: ldloca.s V_3
    IL_0020: call Z0.Vec256`1<System.UInt32> Z0.dinx::add(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0025: stloc.s V_4
    IL_0027: ldloca.s V_4
    IL_0029: ldarga.s dst
    IL_002B: ldloc.1
    IL_002C: call System.UInt32& Z0.Span256`1<System.UInt32>::Block(System.Int32)
    IL_0031: call System.Void zfunc::vstore<System.UInt32>(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_000C
    IL_003E: ldarg.2
    IL_003F: ret

}
Span256<long> add(ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, Span256<long> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span256`1<System.Int64>::get_BlockCount()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_003A
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec256`1<System.Int64> Z0.ginxs::LoadVec256<System.Int64>(Z0.ReadOnlySpan256`1<System.Int64>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: ldloc.1
    IL_0018: call Z0.Vec256`1<System.Int64> Z0.ginxs::LoadVec256<System.Int64>(Z0.ReadOnlySpan256`1<System.Int64>,System.Int32)
    IL_001D: stloc.3
    IL_001E: ldloca.s V_3
    IL_0020: call Z0.Vec256`1<System.Int64> Z0.dinx::add(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_0025: stloc.s V_4
    IL_0027: ldloca.s V_4
    IL_0029: ldarga.s dst
    IL_002B: ldloc.1
    IL_002C: call System.Int64& Z0.Span256`1<System.Int64>::Block(System.Int32)
    IL_0031: call System.Void zfunc::vstore<System.Int64>(Z0.Vec256`1<System.Int64>&,System.Int64&)
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_000C
    IL_003E: ldarg.2
    IL_003F: ret

}
Span256<ulong> add(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, Span256<ulong> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span256`1<System.UInt64>::get_BlockCount()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_003A
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec256`1<System.UInt64> Z0.ginxs::LoadVec256<System.UInt64>(Z0.ReadOnlySpan256`1<System.UInt64>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: ldloc.1
    IL_0018: call Z0.Vec256`1<System.UInt64> Z0.ginxs::LoadVec256<System.UInt64>(Z0.ReadOnlySpan256`1<System.UInt64>,System.Int32)
    IL_001D: stloc.3
    IL_001E: ldloca.s V_3
    IL_0020: call Z0.Vec256`1<System.UInt64> Z0.dinx::add(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0025: stloc.s V_4
    IL_0027: ldloca.s V_4
    IL_0029: ldarga.s dst
    IL_002B: ldloc.1
    IL_002C: call System.UInt64& Z0.Span256`1<System.UInt64>::Block(System.Int32)
    IL_0031: call System.Void zfunc::vstore<System.UInt64>(Z0.Vec256`1<System.UInt64>&,System.UInt64&)
    IL_0036: ldloc.1
    IL_0037: ldc.i4.1
    IL_0038: add
    IL_0039: stloc.1
    IL_003A: ldloc.1
    IL_003B: ldloc.0
    IL_003C: blt.s IL_000C
    IL_003E: ldarg.2
    IL_003F: ret

}
Vec128<short> hadd(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Ssse3::HorizontalAdd(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<int> hadd(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Ssse3::HorizontalAdd(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec256<short> hadd(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::HorizontalAdd(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<int> hadd(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::HorizontalAdd(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec128<byte> adds(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::AddSaturate(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<sbyte> adds(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::AddSaturate(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<short> adds(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::AddSaturate(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<ushort> adds(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::AddSaturate(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec256<byte> adds(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<sbyte> adds(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<short> adds(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<ushort> adds(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
Vec128<byte> avg(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Average(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<ushort> avg(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Average(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec256<byte> avg(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Average(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<ushort> avg(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Average(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
UInt128 clmul(ulong lhs, ulong rhs)
{
    IL_0000: ldarga.s lhs
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.Vec128::LoadScalar<System.UInt64>(System.UInt64&)
    IL_0007: stloc.0
    IL_0008: ldarga.s rhs
    IL_000A: call Z0.Vec128`1<System.UInt64> Z0.Vec128::LoadScalar<System.UInt64>(System.UInt64&)
    IL_000F: stloc.1
    IL_0010: ldloc.0
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: ldloc.1
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_001C: ldc.i4.0
    IL_001D: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Pclmulqdq::CarrylessMultiply(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0022: stloc.2
    IL_0023: ldloca.s V_2
    IL_0025: call Z0.UInt128 Z0.UInt128::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>&)
    IL_002A: ret

}
Vec128<ulong> clmul(Scalar128<ulong> a, Scalar128<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Scalar128`1<System.UInt64>::op_Implicit(Z0.Scalar128`1<System.UInt64>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Scalar128`1<System.UInt64>::op_Implicit(Z0.Scalar128`1<System.UInt64>)
    IL_000C: ldc.i4.0
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Pclmulqdq::CarrylessMultiply(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0017: ret

}
Vec128<ulong> clmul(in Vec128<ulong> lhs, in Vec128<ulong> rhs, byte mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Pclmulqdq::CarrylessMultiply(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0021: ret

}
ushort clmul(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.dinx::clmul(System.UInt32,System.UInt32)
    IL_0007: conv.u2
    IL_0008: ret

}
uint clmul(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.dinx::clmul(System.UInt32,System.UInt32)
    IL_0007: conv.u4
    IL_0008: ret

}
ulong clmul(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: ldarg.1
    IL_0003: conv.u8
    IL_0004: call Z0.UInt128 Z0.dinx::clmul(System.UInt64,System.UInt64)
    IL_0009: ldfld System.UInt64 Z0.UInt128::lo
    IL_000E: ret

}
ref Vec512<ulong> clmul(in Vec128<ulong> lhs, in Vec128<ulong> rhs, out Vec512<ulong> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.0
    IL_0004: call Z0.Vec128`1<System.UInt64> Z0.dinx::clmul(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.ClMulMask)
    IL_0009: ldarg.0
    IL_000A: ldarg.1
    IL_000B: ldc.i4.1
    IL_000C: call Z0.Vec128`1<System.UInt64> Z0.dinx::clmul(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.ClMulMask)
    IL_0011: ldarg.0
    IL_0012: ldarg.1
    IL_0013: ldc.i4.s 16
    IL_0015: call Z0.Vec128`1<System.UInt64> Z0.dinx::clmul(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.ClMulMask)
    IL_001A: ldarg.0
    IL_001B: ldarg.1
    IL_001C: ldc.i4.s 17
    IL_001E: call Z0.Vec128`1<System.UInt64> Z0.dinx::clmul(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.ClMulMask)
    IL_0023: call Z0.Vec512`1<System.UInt64> Z0.Vec512::FromParts<System.UInt64>(Z0.Vec128`1<System.UInt64>,Z0.Vec128`1<System.UInt64>,Z0.Vec128`1<System.UInt64>,Z0.Vec128`1<System.UInt64>)
    IL_0028: stobj Z0.Vec512`1<System.UInt64>
    IL_002D: ldarg.2
    IL_002E: ret

}
long dot(Vec256<int> lhs, Vec256<int> rhs)
{
    IL_0000: ldarga.s lhs
    IL_0002: ldarga.s rhs
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.dinx::mul(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0009: stloc.0
    IL_000A: ldloca.s V_0
    IL_000C: ldc.i4.0
    IL_000D: call Z0.Vec128`1<System.Int64> Z0.dinx::extract128(Z0.Vec256`1<System.Int64>&,System.Byte)
    IL_0012: stloc.3
    IL_0013: ldloca.s V_3
    IL_0015: ldloca.s V_0
    IL_0017: ldc.i4.1
    IL_0018: call Z0.Vec128`1<System.Int64> Z0.dinx::extract128(Z0.Vec256`1<System.Int64>&,System.Byte)
    IL_001D: stloc.s V_4
    IL_001F: ldloca.s V_4
    IL_0021: call Z0.Vec128`1<System.Int64> Z0.dinx::add(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0026: stloc.1
    IL_0027: ldloc.1
    IL_0028: call Z0.Span128`1<System.Int64> Z0.VSpanX::ToSpan128<System.Int64>(Z0.Vec128`1<System.Int64>)
    IL_002D: stloc.2
    IL_002E: ldloca.s V_2
    IL_0030: ldc.i4.0
    IL_0031: call System.Int64& Z0.Span128`1<System.Int64>::get_Item(System.Int32)
    IL_0036: ldind.i8
    IL_0037: ldloca.s V_2
    IL_0039: ldc.i4.1
    IL_003A: call System.Int64& Z0.Span128`1<System.Int64>::get_Item(System.Int32)
    IL_003F: ldind.i8
    IL_0040: add
    IL_0041: ret

}
ulong dot(Vec256<uint> lhs, Vec256<uint> rhs)
{
    IL_0000: ldarga.s lhs
    IL_0002: ldarga.s rhs
    IL_0004: call Z0.Vec256`1<System.UInt64> Z0.dinx::mul(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0009: stloc.0
    IL_000A: ldloca.s V_0
    IL_000C: ldc.i4.0
    IL_000D: call Z0.Vec128`1<System.UInt64> Z0.dinx::extract128(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0012: stloc.3
    IL_0013: ldloca.s V_3
    IL_0015: ldloca.s V_0
    IL_0017: ldc.i4.1
    IL_0018: call Z0.Vec128`1<System.UInt64> Z0.dinx::extract128(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_001D: stloc.s V_4
    IL_001F: ldloca.s V_4
    IL_0021: call Z0.Vec128`1<System.UInt64> Z0.dinx::add(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0026: stloc.1
    IL_0027: ldloc.1
    IL_0028: call Z0.Span128`1<System.UInt64> Z0.VSpanX::ToSpan128<System.UInt64>(Z0.Vec128`1<System.UInt64>)
    IL_002D: stloc.2
    IL_002E: ldloca.s V_2
    IL_0030: ldc.i4.0
    IL_0031: call System.UInt64& Z0.Span128`1<System.UInt64>::get_Item(System.Int32)
    IL_0036: ldind.i8
    IL_0037: ldloca.s V_2
    IL_0039: ldc.i4.1
    IL_003A: call System.UInt64& Z0.Span128`1<System.UInt64>::get_Item(System.Int32)
    IL_003F: ldind.i8
    IL_0040: add
    IL_0041: ret

}
Vec128<byte> max(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Max(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<sbyte> max(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse41::Max(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<short> max(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Max(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<int> max(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::Max(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec128<uint> max(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse41::Max(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: ret

}
Vec256<byte> max(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<sbyte> max(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<short> max(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec128<ushort> max(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse41::Max(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec256<ushort> max(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
Vec256<int> max(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec256<uint> max(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0020: ret

}
Vec128<byte> min(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Min(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<sbyte> min(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse41::Min(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<short> min(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Min(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<ushort> min(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse41::Min(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec128<int> min(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::Min(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec128<uint> min(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse41::Min(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: ret

}
Vec256<byte> min(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<sbyte> min(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<short> min(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<ushort> min(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
Vec256<int> min(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec256<uint> min(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0020: ret

}
Vec128<long> mul(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::Multiply(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: ret

}
Vec128<ulong> mul(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Multiply(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: ret

}
Vec256<long> mul(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Multiply(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0020: ret

}
Vec256<ulong> mul(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Multiply(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0020: ret

}
Vec256<ulong> mul(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldc.i4.m1
    IL_0001: conv.u8
    IL_0002: call Z0.Vec256`1<System.UInt64> Z0.Vec256::Fill<System.UInt64>(System.UInt64)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec256`1<System.UInt64> Z0.dinx::and(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0010: stloc.s V_13
    IL_0012: ldloca.s V_13
    IL_0014: ldloca.s V_12
    IL_0016: call Z0.Vec256`1<System.UInt32>& Z0.Vec256`1<System.UInt64>::As<System.UInt32>(Z0.Vec256`1<System.UInt32>&)
    IL_001B: stloc.1
    IL_001C: ldarg.0
    IL_001D: ldc.i4.s 32
    IL_001F: call Z0.Vec256`1<System.UInt64> Z0.dinx::srl(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0024: stloc.s V_13
    IL_0026: ldloca.s V_13
    IL_0028: ldloca.s V_14
    IL_002A: call Z0.Vec256`1<System.UInt32>& Z0.Vec256`1<System.UInt64>::As<System.UInt32>(Z0.Vec256`1<System.UInt32>&)
    IL_002F: stloc.2
    IL_0030: ldarg.1
    IL_0031: ldloca.s V_0
    IL_0033: call Z0.Vec256`1<System.UInt64> Z0.dinx::and(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0038: stloc.s V_13
    IL_003A: ldloca.s V_13
    IL_003C: ldloca.s V_15
    IL_003E: call Z0.Vec256`1<System.UInt32>& Z0.Vec256`1<System.UInt64>::As<System.UInt32>(Z0.Vec256`1<System.UInt32>&)
    IL_0043: stloc.3
    IL_0044: ldarg.1
    IL_0045: ldc.i4.s 32
    IL_0047: call Z0.Vec256`1<System.UInt64> Z0.dinx::srl(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_004C: stloc.s V_13
    IL_004E: ldloca.s V_13
    IL_0050: ldloca.s V_16
    IL_0052: call Z0.Vec256`1<System.UInt32>& Z0.Vec256`1<System.UInt64>::As<System.UInt32>(Z0.Vec256`1<System.UInt32>&)
    IL_0057: stloc.s V_4
    IL_0059: ldloc.2
    IL_005A: ldloc.3
    IL_005B: call Z0.Vec256`1<System.UInt64> Z0.dinx::mul(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0060: stloc.s V_5
    IL_0062: ldloca.s V_5
    IL_0064: ldc.i4.s 32
    IL_0066: call Z0.Vec256`1<System.UInt64> Z0.dinx::sll(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_006B: stloc.s V_6
    IL_006D: ldloc.2
    IL_006E: ldloc.s V_4
    IL_0070: call Z0.Vec256`1<System.UInt64> Z0.dinx::mul(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0075: stloc.s V_7
    IL_0077: ldloca.s V_7
    IL_0079: ldc.i4.s 32
    IL_007B: call Z0.Vec256`1<System.UInt64> Z0.dinx::sll(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0080: stloc.s V_8
    IL_0082: ldloc.1
    IL_0083: ldloc.3
    IL_0084: call Z0.Vec256`1<System.UInt64> Z0.dinx::mul(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0089: stloc.s V_9
    IL_008B: ldloca.s V_6
    IL_008D: ldloca.s V_8
    IL_008F: call Z0.Vec256`1<System.UInt64> Z0.dinx::add(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0094: stloc.s V_10
    IL_0096: ldloca.s V_9
    IL_0098: ldloca.s V_10
    IL_009A: call Z0.Vec256`1<System.UInt64> Z0.dinx::add(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_009F: stloc.s V_11
    IL_00A1: ldloc.s V_11
    IL_00A3: ret

}
ushort mulx(byte a, byte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::MultiplyNoFlags(System.UInt32,System.UInt32)
    IL_0007: conv.u2
    IL_0008: ret

}
uint mulx(ushort a, ushort b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::MultiplyNoFlags(System.UInt32,System.UInt32)
    IL_0007: ret

}
void mulx(uint a, uint b, ref uint lo, ref uint hi)
{
    IL_0000: ldarg.3
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0009: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::MultiplyNoFlags(System.UInt32,System.UInt32,System.UInt32*)
    IL_000E: stind.i4
    IL_000F: ret

}
void mulx(ulong a, ulong b, ref ulong lo, ref ulong hi)
{
    IL_0000: ldarg.3
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_0009: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi2/X64::MultiplyNoFlags(System.UInt64,System.UInt64,System.UInt64*)
    IL_000E: stind.i8
    IL_000F: ret

}
Vec128<sbyte> negate(in Vec128<sbyte> src)
{
    IL_0000: ldsflda Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec128`1<System.SByte> Z0.dinx::sub(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_000B: ret

}
Vec128<byte> negate(in Vec128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Byte> Z0.BitUtil::flip(Z0.Vec128`1<System.Byte>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.Byte>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128::Ones<System.Byte>()
    IL_000E: call Z0.Vec128`1<System.Byte> Z0.dinx::add(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0013: ret

}
Vec128<short> negate(in Vec128<short> src)
{
    IL_0000: ldsflda Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec128`1<System.Int16> Z0.dinx::sub(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_000B: ret

}
Vec128<ushort> negate(in Vec128<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt16> Z0.BitUtil::flip(Z0.Vec128`1<System.UInt16>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.UInt16>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128::Ones<System.UInt16>()
    IL_000E: call Z0.Vec128`1<System.UInt16> Z0.dinx::add(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0013: ret

}
Vec128<int> negate(in Vec128<int> src)
{
    IL_0000: ldsflda Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec128`1<System.Int32> Z0.dinx::sub(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_000B: ret

}
Vec128<uint> negate(in Vec128<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt32> Z0.BitUtil::flip(Z0.Vec128`1<System.UInt32>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.UInt32>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128::Ones<System.UInt32>()
    IL_000E: call Z0.Vec128`1<System.UInt32> Z0.dinx::add(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0013: ret

}
Vec128<long> negate(in Vec128<long> src)
{
    IL_0000: ldsflda Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec128`1<System.Int64> Z0.dinx::sub(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_000B: ret

}
Vec128<ulong> negate(in Vec128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt64> Z0.BitUtil::flip(Z0.Vec128`1<System.UInt64>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.UInt64>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128::Ones<System.UInt64>()
    IL_000E: call Z0.Vec128`1<System.UInt64> Z0.dinx::add(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0013: ret

}
Vec256<byte> negate(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Byte> Z0.BitUtil::flip(Z0.Vec256`1<System.Byte>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.Byte>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256::Ones<System.Byte>()
    IL_000E: call Z0.Vec256`1<System.Byte> Z0.dinx::add(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0013: ret

}
Vec256<short> negate(in Vec256<short> src)
{
    IL_0000: ldsflda Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec256`1<System.Int16> Z0.dinx::sub(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_000B: ret

}
Vec256<ushort> negate(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt16> Z0.BitUtil::flip(Z0.Vec256`1<System.UInt16>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.UInt16>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256::Ones<System.UInt16>()
    IL_000E: call Z0.Vec256`1<System.UInt16> Z0.dinx::add(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_0013: ret

}
Vec256<int> negate(in Vec256<int> src)
{
    IL_0000: ldsflda Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec256`1<System.Int32> Z0.dinx::sub(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_000B: ret

}
Vec256<uint> negate(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt32> Z0.BitUtil::flip(Z0.Vec256`1<System.UInt32>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.UInt32>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256::Ones<System.UInt32>()
    IL_000E: call Z0.Vec256`1<System.UInt32> Z0.dinx::add(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0013: ret

}
Vec256<long> negate(in Vec256<long> src)
{
    IL_0000: ldsflda Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec256`1<System.Int64> Z0.dinx::sub(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_000B: ret

}
Vec256<ulong> negate(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt64> Z0.BitUtil::flip(Z0.Vec256`1<System.UInt64>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.UInt64>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256::Ones<System.UInt64>()
    IL_000E: call Z0.Vec256`1<System.UInt64> Z0.dinx::add(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0013: ret

}
Vec256<sbyte> negate(in Vec256<sbyte> src)
{
    IL_0000: ldsflda Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec256`1<System.SByte> Z0.dinx::sub(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_000B: ret

}
Vec128<ushort> sad(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::SumAbsoluteDifferences(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec256<ushort> sad(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::SumAbsoluteDifferences(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
Vec128<sbyte> sign(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Ssse3::Sign(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<short> sign(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Ssse3::Sign(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<int> sign(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Ssse3::Sign(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec256<sbyte> sign(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Sign(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<short> sign(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Sign(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<int> sign(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Sign(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}

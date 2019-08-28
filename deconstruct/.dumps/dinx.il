// 2019-08-27 17:10:31:255
Vec256<int> xor(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> xor(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> xor(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> xor(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec256<float> xor(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Xor(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: ret

}
Vec256<double> xor(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Xor(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0016: ret

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
    IL_0020: call Z0.Vec128Cmp`1<System.SByte> Z0.Vec128Cmp::Define<System.SByte>(Z0.Vec128`1<System.SByte>)
    IL_0025: ret

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
    IL_0020: call Z0.Vec128Cmp`1<System.Byte> Z0.Vec128Cmp::Define<System.Byte>(Z0.Vec128`1<System.Byte>)
    IL_0025: ret

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
    IL_0020: call Z0.Vec128Cmp`1<System.Int16> Z0.Vec128Cmp::Define<System.Int16>(Z0.Vec128`1<System.Int16>)
    IL_0025: ret

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
    IL_0020: call Z0.Vec128Cmp`1<System.UInt16> Z0.Vec128Cmp::Define<System.UInt16>(Z0.Vec128`1<System.UInt16>)
    IL_0025: ret

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
    IL_0020: call Z0.Vec128Cmp`1<System.Int32> Z0.Vec128Cmp::Define<System.Int32>(Z0.Vec128`1<System.Int32>)
    IL_0025: ret

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
    IL_0020: call Z0.Vec128Cmp`1<System.UInt32> Z0.Vec128Cmp::Define<System.UInt32>(Z0.Vec128`1<System.UInt32>)
    IL_0025: ret

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
    IL_0020: call Z0.Vec128Cmp`1<System.Int64> Z0.Vec128Cmp::Define<System.Int64>(Z0.Vec128`1<System.Int64>)
    IL_0025: ret

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
    IL_0020: call Z0.Vec128Cmp`1<System.UInt64> Z0.Vec128Cmp::Define<System.UInt64>(Z0.Vec128`1<System.UInt64>)
    IL_0025: ret

}
Vec256Cmp<sbyte> eq(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: call Z0.Vec256Cmp`1<System.SByte> Z0.Vec256Cmp::Define<System.SByte>(Z0.Vec256`1<System.SByte>)
    IL_001B: ret

}
Vec256Cmp<byte> eq(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: call Z0.Vec256Cmp`1<System.Byte> Z0.Vec256Cmp::Define<System.Byte>(Z0.Vec256`1<System.Byte>)
    IL_001B: ret

}
Vec256Cmp<short> eq(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: call Z0.Vec256Cmp`1<System.Int16> Z0.Vec256Cmp::Define<System.Int16>(Z0.Vec256`1<System.Int16>)
    IL_001B: ret

}
Vec256Cmp<ushort> eq(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: call Z0.Vec256Cmp`1<System.UInt16> Z0.Vec256Cmp::Define<System.UInt16>(Z0.Vec256`1<System.UInt16>)
    IL_001B: ret

}
Vec256Cmp<int> eq(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: call Z0.Vec256Cmp`1<System.Int32> Z0.Vec256Cmp::Define<System.Int32>(Z0.Vec256`1<System.Int32>)
    IL_001B: ret

}
Vec256Cmp<uint> eq(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: call Z0.Vec256Cmp`1<System.UInt32> Z0.Vec256Cmp::Define<System.UInt32>(Z0.Vec256`1<System.UInt32>)
    IL_001B: ret

}
Vec256Cmp<long> eq(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: call Z0.Vec256Cmp`1<System.Int64> Z0.Vec256Cmp::Define<System.Int64>(Z0.Vec256`1<System.Int64>)
    IL_001B: ret

}
Vec256Cmp<ulong> eq(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: call Z0.Vec256Cmp`1<System.UInt64> Z0.Vec256Cmp::Define<System.UInt64>(Z0.Vec256`1<System.UInt64>)
    IL_001B: ret

}
Vec128Cmp<sbyte> gt(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: call Z0.Vec128Cmp`1<System.SByte> Z0.Vec128Cmp::Define<System.SByte>(Z0.Vec128`1<System.SByte>)
    IL_0025: ret

}
Vec128Cmp<short> gt(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: call Z0.Vec128Cmp`1<System.Int16> Z0.Vec128Cmp::Define<System.Int16>(Z0.Vec128`1<System.Int16>)
    IL_0025: ret

}
Vec128Cmp<int> gt(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: call Z0.Vec128Cmp`1<System.Int32> Z0.Vec128Cmp::Define<System.Int32>(Z0.Vec128`1<System.Int32>)
    IL_0025: ret

}
Vec256Cmp<sbyte> gt(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: call Z0.Vec256Cmp`1<System.SByte> Z0.Vec256Cmp::Define<System.SByte>(Z0.Vec256`1<System.SByte>)
    IL_001B: ret

}
Vec256Cmp<short> gt(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: call Z0.Vec256Cmp`1<System.Int16> Z0.Vec256Cmp::Define<System.Int16>(Z0.Vec256`1<System.Int16>)
    IL_001B: ret

}
Vec256Cmp<int> gt(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: call Z0.Vec256Cmp`1<System.Int32> Z0.Vec256Cmp::Define<System.Int32>(Z0.Vec256`1<System.Int32>)
    IL_001B: ret

}
Vec256Cmp<long> gt(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: call Z0.Vec256Cmp`1<System.Int64> Z0.Vec256Cmp::Define<System.Int64>(Z0.Vec256`1<System.Int64>)
    IL_001B: ret

}
Vec128Cmp<sbyte> lt(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareLessThan(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: call Z0.Vec128Cmp`1<System.SByte> Z0.Vec128Cmp::Define<System.SByte>(Z0.Vec128`1<System.SByte>)
    IL_0025: ret

}
Vec128Cmp<short> lt(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareLessThan(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: call Z0.Vec128Cmp`1<System.Int16> Z0.Vec128Cmp::Define<System.Int16>(Z0.Vec128`1<System.Int16>)
    IL_0025: ret

}
Vec128Cmp<int> lt(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareLessThan(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: call Z0.Vec128Cmp`1<System.Int32> Z0.Vec128Cmp::Define<System.Int32>(Z0.Vec128`1<System.Int32>)
    IL_0025: ret

}
uint crc(uint crc, byte data)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Sse42::Crc32(System.UInt32,System.Byte)
    IL_0007: ret

}
uint crc(uint crc, ushort data)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Sse42::Crc32(System.UInt32,System.UInt16)
    IL_0007: ret

}
uint crc(uint crc, uint data)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Sse42::Crc32(System.UInt32,System.UInt32)
    IL_0007: ret

}
ulong crc(uint crc, ulong data)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: ldarg.1
    IL_0003: call System.UInt64 System.Runtime.Intrinsics.X86.Sse42/X64::Crc32(System.UInt64,System.UInt64)
    IL_0008: ret

}
Vec128<byte> encrypt(Vec128<byte> src, Vec128<byte> key)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Aes::Encrypt(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<byte> encryptLast(Vec128<byte> src, Vec128<byte> key)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Aes::EncryptLast(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<byte> decrypt(Vec128<byte> src, Vec128<byte> key)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Aes::Decrypt(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<byte> decryptLast(Vec128<byte> src, Vec128<byte> key)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Aes::DecryptLast(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<byte> keygen(Vec128<byte> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Aes::KeygenAssist(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: ret

}
Num128<float> max(in Num128<float> lhs, in Num128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::MaxScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Num128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>&)
    IL_0019: ret

}
Num128<double> max(in Num128<double> lhs, in Num128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::MaxScalar(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Num128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>&)
    IL_0019: ret

}
Num128<float> min(in Num128<float> lhs, in Num128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::MinScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Num128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>&)
    IL_0019: ret

}
Num128<double> min(in Num128<double> lhs, in Num128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::MinScalar(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Num128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>&)
    IL_0019: ret

}
void add(in Num128<float> lhs, in Num128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::AddScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: ldarg.2
    IL_0015: call System.Void zfunc::vstore(System.Runtime.Intrinsics.Vector128`1<System.Single>&,System.Single&)
    IL_001A: ret

}
void add(in Num128<double> lhs, in Num128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::AddScalar(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: ldarg.2
    IL_0015: call System.Void zfunc::vstore(System.Runtime.Intrinsics.Vector128`1<System.Double>&,System.Double&)
    IL_001A: ret

}
Num128<float> add(in Num128<float> lhs, in Num128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::AddScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Num128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>&)
    IL_0019: ret

}
Num128<double> add(in Num128<double> lhs, in Num128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::AddScalar(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Num128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>&)
    IL_0019: ret

}
void sub(in Num128<float> lhs, in Num128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::SubtractScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: ldarg.2
    IL_0015: call System.Void zfunc::vstore(System.Runtime.Intrinsics.Vector128`1<System.Single>&,System.Single&)
    IL_001A: ret

}
void sub(in Num128<double> lhs, in Num128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::SubtractScalar(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: ldarg.2
    IL_0015: call System.Void zfunc::vstore(System.Runtime.Intrinsics.Vector128`1<System.Double>&,System.Double&)
    IL_001A: ret

}
Num128<float> sub(in Num128<float> lhs, in Num128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::SubtractScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Num128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>&)
    IL_0019: ret

}
Num128<double> sub(in Num128<double> lhs, in Num128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::SubtractScalar(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Num128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>&)
    IL_0019: ret

}
Num128<float> div(in Num128<float> lhs, in Num128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::DivideScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Num128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>&)
    IL_0019: ret

}
Num128<double> div(in Num128<double> lhs, in Num128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::DivideScalar(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Num128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>&)
    IL_0019: ret

}
void div(in Num128<float> lhs, in Num128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::DivideScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: ldarg.2
    IL_0015: call System.Void zfunc::vstore(System.Runtime.Intrinsics.Vector128`1<System.Single>&,System.Single&)
    IL_001A: ret

}
void div(in Num128<double> lhs, in Num128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::DivideScalar(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: ldarg.2
    IL_0015: call System.Void zfunc::vstore(System.Runtime.Intrinsics.Vector128`1<System.Double>&,System.Double&)
    IL_001A: ret

}
bool cmpf(in Num128<float> lhs, in Num128<float> rhs, byte mode)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Avx::CompareScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.X86.FloatComparisonMode)
    IL_0012: ldc.i4.0
    IL_0013: call System.Boolean Z0.dinx::IsNaN(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Int32)
    IL_0018: ret

}
bool cmpf(in Num128<double> lhs, in Num128<double> rhs, byte mode)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Avx::CompareScalar(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.X86.FloatComparisonMode)
    IL_0012: ldc.i4.0
    IL_0013: call System.Boolean Z0.dinx::IsNaN(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Int32)
    IL_0018: ret

}
bool lt(in Num128<float> lhs, in Num128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse::CompareScalarOrderedLessThan(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: ret

}
bool lt(in Num128<double> lhs, in Num128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse2::CompareScalarOrderedLessThan(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: ret

}
Vec128<float> gteq(Vec128<float> lhs, Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::CompareGreaterThanOrEqual(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0016: ret

}
Vec128<double> gteq(Vec128<double> lhs, Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::CompareGreaterThanOrEqual(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0016: ret

}
bool gteq(in Num128<float> lhs, in Num128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse::CompareScalarOrderedGreaterThanOrEqual(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: ret

}
bool gteq(in Num128<double> lhs, in Num128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse2::CompareScalarOrderedGreaterThanOrEqual(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: ret

}
bool eq(in Num128<float> lhs, in Num128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse::CompareScalarUnorderedEqual(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: ret

}
bool eq(in Num128<double> lhs, in Num128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse2::CompareScalarUnorderedEqual(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: ret

}
bool gt(in Num128<float> lhs, in Num128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse::CompareScalarOrderedGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: ret

}
bool gt(in Num128<double> lhs, in Num128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse2::CompareScalarOrderedGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: ret

}
bool lteq(in Num128<float> lhs, in Num128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse::CompareScalarUnorderedLessThanOrEqual(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: ret

}
bool lteq(in Num128<double> lhs, in Num128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse2::CompareScalarUnorderedLessThanOrEqual(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: ret

}
bool neq(in Num128<float> lhs, in Num128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse::CompareScalarOrderedNotEqual(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: ret

}
bool neq(in Num128<double> lhs, in Num128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse2::CompareScalarOrderedNotEqual(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: ret

}
bool ngt(in Num128<float> lhs, in Num128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::CompareScalarNotGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: ldc.i4.0
    IL_0012: call System.Boolean Z0.dinx::IsNaN(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Int32)
    IL_0017: ret

}
bool ngt(in Num128<double> lhs, in Num128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::CompareScalarNotGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: ldc.i4.0
    IL_0012: call System.Boolean Z0.dinx::IsNaN(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Int32)
    IL_0017: ret

}
bool nlt(in Num128<float> lhs, in Num128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::CompareScalarNotLessThan(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: ldc.i4.0
    IL_0012: call System.Boolean Z0.dinx::IsNaN(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Int32)
    IL_0017: ret

}
bool nlt(in Num128<double> lhs, in Num128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::CompareScalarNotLessThan(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: ldc.i4.0
    IL_0012: call System.Boolean Z0.dinx::IsNaN(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Int32)
    IL_0017: ret

}
ref Num128<float> ceil(ref Num128<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse41::CeilingScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Num128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>&)
    IL_0014: stobj Z0.Num128`1<System.Single>
    IL_0019: ldarg.0
    IL_001A: ret

}
ref Num128<double> ceil(ref Num128<double> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse41::CeilingScalar(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Num128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>&)
    IL_0014: stobj Z0.Num128`1<System.Double>
    IL_0019: ldarg.0
    IL_001A: ret

}
ref Num128<float> floor(ref Num128<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse41::FloorScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Num128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>&)
    IL_0014: stobj Z0.Num128`1<System.Single>
    IL_0019: ldarg.0
    IL_001A: ret

}
ref Num128<double> floor(ref Num128<double> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse41::FloorScalar(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Num128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>&)
    IL_0014: stobj Z0.Num128`1<System.Double>
    IL_0019: ldarg.0
    IL_001A: ret

}
Num128<float> mul(in Num128<float> lhs, in Num128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::MultiplyScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Num128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>&)
    IL_0019: ret

}
Num128<double> mul(in Num128<double> lhs, in Num128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::MultiplyScalar(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Num128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>&)
    IL_0019: ret

}
Num128<float> mulAdd(in Num128<float> x, in Num128<float> y, in Num128<float> z)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Fma::MultiplyAddScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.Num128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>&)
    IL_001F: ret

}
Num128<double> mulAdd(in Num128<double> x, in Num128<double> y, in Num128<double> z)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Fma::MultiplyAddScalar(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.Num128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>&)
    IL_001F: ret

}
Vec128<float> recipsqrt(Vec128<float> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::ReciprocalSqrt(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_000B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0010: ret

}
ref Num128<float> recipsqrt(ref Num128<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::ReciprocalSqrtScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Num128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>&)
    IL_0014: stobj Z0.Num128`1<System.Single>
    IL_0019: ldarg.0
    IL_001A: ret

}
Vec128<float> recip(Vec128<float> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Reciprocal(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_000B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0010: ret

}
Vec256<float> recip(Vec256<float> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Reciprocal(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_000C: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: ret

}
ref Num128<float> recip(ref Num128<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::ReciprocalScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Num128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>&)
    IL_0014: stobj Z0.Num128`1<System.Single>
    IL_0019: ldarg.0
    IL_001A: ret

}
Num128<float> sqrt(in Num128<float> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::SqrtScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: call Z0.Num128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>&)
    IL_0013: ret

}
Num128<double> sqrt(in Num128<double> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::SqrtScalar(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: call Z0.Num128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>&)
    IL_0013: ret

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
Vec256<uint> perm8x32(in Vec256<uint> src, in Vec256<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<float> perm8x32(in Vec256<float> src, in Vec256<int> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: ret

}
Vec256<byte> perm4x64(in Vec256<byte> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.Byte>::As<System.UInt64>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call Z0.Vec256`1<System.UInt64> Z0.dinx::perm4x64(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_000F: stloc.1
    IL_0010: ldloca.s V_1
    IL_0012: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.UInt64>::As<System.Byte>()
    IL_0017: ret

}
Vec256<sbyte> perm4x64(in Vec256<sbyte> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.SByte>::As<System.Int64>()
    IL_0006: ldarg.1
    IL_0007: call Z0.Vec256`1<System.Int64> Z0.dinx::perm4x64(Z0.Vec256`1<System.Int64>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.Int64>::As<System.SByte>()
    IL_0014: ret

}
Vec256<short> perm4x64(in Vec256<short> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int16>::As<System.Int64>()
    IL_0006: ldarg.1
    IL_0007: call Z0.Vec256`1<System.Int64> Z0.dinx::perm4x64(Z0.Vec256`1<System.Int64>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int64>::As<System.Int16>()
    IL_0014: ret

}
Vec256<ushort> perm4x64(in Vec256<ushort> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt16>::As<System.UInt64>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call Z0.Vec256`1<System.UInt64> Z0.dinx::perm4x64(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_000F: stloc.1
    IL_0010: ldloca.s V_1
    IL_0012: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt64>::As<System.UInt16>()
    IL_0017: ret

}
Vec256<uint> perm4x64(Vec256<uint> value, byte control)
{
    IL_0000: ldarga.s value
    IL_0002: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt32>::As<System.UInt64>()
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.1
    IL_000B: call Z0.Vec256`1<System.UInt64> Z0.dinx::perm4x64(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0010: stloc.1
    IL_0011: ldloca.s V_1
    IL_0013: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt64>::As<System.UInt32>()
    IL_0018: ret

}
Vec256<int> perm4x64(Vec256<int> value, byte control)
{
    IL_0000: ldarga.s value
    IL_0002: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int32>::As<System.Int64>()
    IL_0007: ldarg.1
    IL_0008: call Z0.Vec256`1<System.Int64> Z0.dinx::perm4x64(Z0.Vec256`1<System.Int64>,System.Byte)
    IL_000D: stloc.0
    IL_000E: ldloca.s V_0
    IL_0010: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int64>::As<System.Int32>()
    IL_0015: ret

}
Vec256<long> perm4x64(Vec256<long> value, byte control)
{
    IL_0000: ldarga.s value
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0007: ldarg.1
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_000D: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0012: ret

}
Vec256<long> perm4x64test(in Vector256<long> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: ret

}
Vec256<ulong> perm4x64(in Vec256<ulong> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: ret

}
Vec256<float> perm4x64(in Vec256<float> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Single>::As<System.Int64>()
    IL_0006: ldarg.1
    IL_0007: call Z0.Vec256`1<System.Int64> Z0.dinx::perm4x64(Z0.Vec256`1<System.Int64>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Int64>::As<System.Single>()
    IL_0014: ret

}
Vec256<double> perm4x64(in Vec256<double> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: ret

}
Vec128<byte> swap(in Vec128<byte> src, Swap[] swaps)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Byte> Z0.Vec128Pattern::SwapU8(Z0.Swap[])
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: call Z0.Vec128`1<System.Byte> Z0.dinx::shuffle(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_000F: ret

}
Vec128<byte> reverse(in Vec128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldsflda Z0.Vec128`1<System.Byte> Z0.Vec128Pattern::ReverseU8
    IL_0006: call Z0.Vec128`1<System.Byte> Z0.dinx::shuffle(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_000B: ret

}
Vec128<sbyte> reverse(in Vec128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldsflda Z0.Vec128`1<System.SByte> Z0.Vec128Pattern::ReverseI8
    IL_0006: call Z0.Vec128`1<System.SByte> Z0.dinx::shuffle(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_000B: ret

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
    IL_0001: call Z0.Vec256`1<System.Byte>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::get_ReverseU8()
    IL_0006: call Z0.Vec256`1<System.Byte> Z0.dinx::permute(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_000B: ret

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
Vec128<float> shuffle(in Vec128<float> lhs, in Vec128<float> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0021: ret

}
Vec128<double> shuffle(in Vec128<double> lhs, in Vec128<double> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0021: ret

}
Vec128<short> shuffleHi(in Vec128<short> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShuffleHigh(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> shuffleHi(in Vec128<ushort> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<short> shuffleLo(in Vec128<short> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> shuffleLo(in Vec128<ushort> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> shuffle(in Vec256<int> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
Vec256<uint> shuffle(in Vec256<uint> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ret

}
Vec256<byte> shuffle(in Vec256<byte> src, in Vec256<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> shuffle(in Vec256<sbyte> src, in Vec256<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
void transpose(ref Vec128<float> row0, ref Vec128<float> row1, ref Vec128<float> row2, ref Vec128<float> row3)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 68
    IL_0004: call Z0.Vec128`1<System.Single> Z0.dinx::shuffle(Z0.Vec128`1<System.Single>&,Z0.Vec128`1<System.Single>&,System.Byte)
    IL_0009: stloc.0
    IL_000A: ldarg.0
    IL_000B: ldarg.1
    IL_000C: ldc.i4 238
    IL_0011: call Z0.Vec128`1<System.Single> Z0.dinx::shuffle(Z0.Vec128`1<System.Single>&,Z0.Vec128`1<System.Single>&,System.Byte)
    IL_0016: stloc.1
    IL_0017: ldarg.2
    IL_0018: ldarg.3
    IL_0019: ldc.i4.s 68
    IL_001B: call Z0.Vec128`1<System.Single> Z0.dinx::shuffle(Z0.Vec128`1<System.Single>&,Z0.Vec128`1<System.Single>&,System.Byte)
    IL_0020: stloc.2
    IL_0021: ldarg.2
    IL_0022: ldarg.3
    IL_0023: ldc.i4 238
    IL_0028: call Z0.Vec128`1<System.Single> Z0.dinx::shuffle(Z0.Vec128`1<System.Single>&,Z0.Vec128`1<System.Single>&,System.Byte)
    IL_002D: stloc.3
    IL_002E: ldarg.0
    IL_002F: ldloca.s V_0
    IL_0031: ldloca.s V_2
    IL_0033: ldc.i4 136
    IL_0038: call Z0.Vec128`1<System.Single> Z0.dinx::shuffle(Z0.Vec128`1<System.Single>&,Z0.Vec128`1<System.Single>&,System.Byte)
    IL_003D: stobj Z0.Vec128`1<System.Single>
    IL_0042: ldarg.1
    IL_0043: ldloca.s V_0
    IL_0045: ldloca.s V_2
    IL_0047: ldc.i4 221
    IL_004C: call Z0.Vec128`1<System.Single> Z0.dinx::shuffle(Z0.Vec128`1<System.Single>&,Z0.Vec128`1<System.Single>&,System.Byte)
    IL_0051: stobj Z0.Vec128`1<System.Single>
    IL_0056: ldarg.2
    IL_0057: ldloca.s V_1
    IL_0059: ldloca.s V_3
    IL_005B: ldc.i4 136
    IL_0060: call Z0.Vec128`1<System.Single> Z0.dinx::shuffle(Z0.Vec128`1<System.Single>&,Z0.Vec128`1<System.Single>&,System.Byte)
    IL_0065: stobj Z0.Vec128`1<System.Single>
    IL_006A: ldarg.3
    IL_006B: ldloca.s V_1
    IL_006D: ldloca.s V_3
    IL_006F: ldc.i4 221
    IL_0074: call Z0.Vec128`1<System.Single> Z0.dinx::shuffle(Z0.Vec128`1<System.Single>&,Z0.Vec128`1<System.Single>&,System.Byte)
    IL_0079: stobj Z0.Vec128`1<System.Single>
    IL_007E: ret

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
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 78
    IL_0003: call Z0.Vec256`1<System.Byte> Z0.dinx::perm4x64(Z0.Vec256`1<System.Byte>&,System.Byte)
    IL_0008: ret

}
Vec256<sbyte> swaphl(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 78
    IL_0003: call Z0.Vec256`1<System.SByte> Z0.dinx::perm4x64(Z0.Vec256`1<System.SByte>&,System.Byte)
    IL_0008: ret

}
Vec256<short> swaphl(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 78
    IL_0003: call Z0.Vec256`1<System.Int16> Z0.dinx::perm4x64(Z0.Vec256`1<System.Int16>&,System.Byte)
    IL_0008: ret

}
Vec256<ushort> swaphl(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 78
    IL_0003: call Z0.Vec256`1<System.UInt16> Z0.dinx::perm4x64(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0008: ret

}
Vec256<int> swaphl(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: ldc.i4.s 78
    IL_0008: call Z0.Vec256`1<System.Int32> Z0.dinx::perm4x64(Z0.Vec256`1<System.Int32>,System.Byte)
    IL_000D: ret

}
Vec256<uint> swaphl(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: ldc.i4.s 78
    IL_0008: call Z0.Vec256`1<System.UInt32> Z0.dinx::perm4x64(Z0.Vec256`1<System.UInt32>,System.Byte)
    IL_000D: ret

}
Vec256<long> swaphl(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: ldc.i4.s 78
    IL_0008: call Z0.Vec256`1<System.Int64> Z0.dinx::perm4x64(Z0.Vec256`1<System.Int64>,System.Byte)
    IL_000D: ret

}
Vec256<ulong> swaphl(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 78
    IL_0003: call Z0.Vec256`1<System.UInt64> Z0.dinx::perm4x64(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0008: ret

}
Vec256<double> swaphl(in Vec256<double> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 78
    IL_0003: call Z0.Vec256`1<System.Double> Z0.dinx::perm4x64(Z0.Vec256`1<System.Double>&,System.Byte)
    IL_0008: ret

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
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<short> and(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<sbyte> and(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<ushort> and(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> and(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> and(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> and(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> and(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec256<float> and(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::And(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: ret

}
Vec256<double> and(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::And(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0016: ret

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
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<short> or(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<sbyte> or(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<ushort> or(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> or(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> or(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> or(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> or(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec256<float> or(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Or(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: ret

}
Vec256<double> or(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Or(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0016: ret

}
Vec128<short> slli(in Vec128<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> slli(in Vec128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> slli(in Vec128<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> slli(in Vec128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> slli(in Vec128<long> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> slli(in Vec128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec128<ulong> slli32(in Vec128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt64>::As<System.UInt32>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call Z0.Vec128`1<System.UInt32> Z0.dinx::slli(Z0.Vec128`1<System.UInt32>&,System.Byte)
    IL_000F: stloc.1
    IL_0010: ldloca.s V_1
    IL_0012: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt32>::As<System.UInt64>()
    IL_0017: ret

}
Vec256<short> slli(in Vec256<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: ret

}
Vec256<ushort> slli(in Vec256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: ret

}
Vec256<int> slli(in Vec256<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
Vec256<uint> slli(in Vec256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ret

}
Vec256<long> slli(in Vec256<long> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: ret

}
Vec256<ulong> slli(in Vec256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: ret

}
Vec128<short> srli(in Vec128<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> srli(in Vec128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> srli(in Vec128<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> srli(in Vec128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> srli(in Vec128<long> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> srli(in Vec128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<short> srli(in Vec256<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: ret

}
Vec256<ushort> srli(in Vec256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: ret

}
Vec256<int> srli(in Vec256<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
Vec256<uint> srli(in Vec256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ret

}
Vec256<long> srli(in Vec256<long> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: ret

}
Vec256<ulong> srli(in Vec256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: ret

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
Vec128<float> xor(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Xor(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> xor(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

}
Vec256<byte> xor(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<short> xor(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<sbyte> xor(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<ushort> xor(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec128<byte> extract128(in Vec256<byte> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: ret

}
Vec128<short> extract128(in Vec256<short> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
Vec128<ushort> extract128(in Vec256<ushort> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
Vec128<int> extract128(in Vec256<int> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ret

}
Vec128<uint> extract128(in Vec256<uint> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: ret

}
Vec128<long> extract128(in Vec256<long> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: ret

}
Vec128<ulong> extract128(in Vec256<ulong> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: ret

}
Vec128<float> extract128(in Vec256<float> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: ret

}
Vec128<double> extract128(in Vec256<double> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: ret

}
Vec128<sbyte> hi(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldc.i4.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: ret

}
Vec128<byte> hi(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldc.i4.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: ret

}
Vec128<short> hi(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldc.i4.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
Vec128<ushort> hi(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldc.i4.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
Vec128<int> hi(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldc.i4.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ret

}
Vec128<uint> hi(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldc.i4.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: ret

}
Vec128<long> hi(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldc.i4.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: ret

}
Vec128<ulong> hi(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldc.i4.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: ret

}
Vec128<float> hi(in Vec256<float> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldc.i4.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: ret

}
Vec128<double> hi(in Vec256<double> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldc.i4.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: ret

}
Vec128<sbyte> hi(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
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
Vec128<byte> hi(in Vec128<byte> lhs, in Vec128<byte> rhs)
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
Vec128<short> hi(in Vec128<short> lhs, in Vec128<short> rhs)
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
Vec128<ushort> hi(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
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
Vec128<int> hi(in Vec128<int> lhs, in Vec128<int> rhs)
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
Vec128<uint> hi(in Vec128<uint> lhs, in Vec128<uint> rhs)
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
Vec128<long> hi(in Vec128<long> lhs, in Vec128<long> rhs)
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
Vec128<ulong> hi(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
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
Vec128<float> hi(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> hi(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

}
Vec256<byte> hi(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> hi(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> hi(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> hi(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> hi(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> hi(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> hi(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> hi(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec256<float> hi(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: ret

}
Vec256<double> hi(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
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
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.SByte>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0011: ldarg.2
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Byte)
    IL_0017: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001C: ret

}
ref Vec256<sbyte> insert(in Vec128<sbyte> lo, in Vec128<sbyte> hi, ref Vec256<sbyte> dst)
{
    IL_0000: ldarg.2
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.SByte>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0011: ldc.i4.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Byte)
    IL_0017: stloc.0
    IL_0018: ldarg.2
    IL_0019: ldloc.0
    IL_001A: ldarg.1
    IL_001B: ldobj Z0.Vec128`1<System.SByte>
    IL_0020: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0025: ldc.i4.1
    IL_0026: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Byte)
    IL_002B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0030: stobj Z0.Vec256`1<System.SByte>
    IL_0035: ldarg.2
    IL_0036: ret

}
Vec256<byte> insert(in Vec128<byte> src, in Vec256<byte> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Byte>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0011: ldarg.2
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0017: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001C: ret

}
ref Vec256<byte> insert(in Vec128<byte> lo, in Vec128<byte> hi, ref Vec256<byte> dst)
{
    IL_0000: ldarg.2
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Byte>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0011: ldc.i4.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0017: stloc.0
    IL_0018: ldarg.2
    IL_0019: ldloc.0
    IL_001A: ldarg.1
    IL_001B: ldobj Z0.Vec128`1<System.Byte>
    IL_0020: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0025: ldc.i4.1
    IL_0026: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_002B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0030: stobj Z0.Vec256`1<System.Byte>
    IL_0035: ldarg.2
    IL_0036: ret

}
Vec256<short> insert(in Vec128<short> src, in Vec256<short> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Int16>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0011: ldarg.2
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0017: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001C: ret

}
ref Vec256<short> insert(in Vec128<short> lo, in Vec128<short> hi, ref Vec256<short> dst)
{
    IL_0000: ldarg.2
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Int16>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0011: ldc.i4.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0017: stloc.0
    IL_0018: ldarg.2
    IL_0019: ldloc.0
    IL_001A: ldarg.1
    IL_001B: ldobj Z0.Vec128`1<System.Int16>
    IL_0020: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0025: ldc.i4.1
    IL_0026: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_002B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0030: stobj Z0.Vec256`1<System.Int16>
    IL_0035: ldarg.2
    IL_0036: ret

}
Vec256<ushort> insert(in Vec128<ushort> src, in Vec256<ushort> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.UInt16>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0011: ldarg.2
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0017: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001C: ret

}
Vec256<int> insert(in Vec128<int> src, in Vec256<int> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Int32>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0011: ldarg.2
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0017: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001C: ret

}
Vec256<uint> insert(in Vec128<uint> src, in Vec256<uint> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.UInt32>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0011: ldarg.2
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0017: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001C: ret

}
Vec256<long> insert(in Vec128<long> src, in Vec256<long> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Int64>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0011: ldarg.2
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0017: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001C: ret

}
Vec256<ulong> insert(in Vec128<ulong> src, in Vec256<ulong> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.UInt64>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0011: ldarg.2
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0017: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001C: ret

}
Vec256<float> insert(in Vec128<float> src, in Vec256<float> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Single>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0011: ldarg.2
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Byte)
    IL_0017: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_001C: ret

}
Vec256<double> insert(in Vec128<double> src, in Vec256<double> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Double>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0011: ldarg.2
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Byte)
    IL_0017: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_001C: ret

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
Vec128<sbyte> lo(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldc.i4.0
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: ret

}
Vec128<byte> lo(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldc.i4.0
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: ret

}
Vec128<short> lo(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldc.i4.0
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
Vec128<ushort> lo(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldc.i4.0
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
Vec128<int> lo(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldc.i4.0
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ret

}
Vec128<uint> lo(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldc.i4.0
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: ret

}
Vec128<long> lo(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldc.i4.0
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: ret

}
Vec128<ulong> lo(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldc.i4.0
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: ret

}
Vec128<float> lo(in Vec256<float> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldc.i4.0
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: ret

}
Vec128<double> lo(in Vec256<double> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldc.i4.0
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: ret

}
Vec128<sbyte> lo(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
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
Vec128<byte> lo(in Vec128<byte> lhs, in Vec128<byte> rhs)
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
Vec128<short> lo(in Vec128<short> lhs, in Vec128<short> rhs)
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
Vec128<ushort> lo(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
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
Vec128<int> lo(in Vec128<int> lhs, in Vec128<int> rhs)
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
Vec128<uint> lo(in Vec128<uint> lhs, in Vec128<uint> rhs)
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
Vec128<long> lo(in Vec128<long> lhs, in Vec128<long> rhs)
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
Vec128<ulong> lo(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
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
Vec128<float> lo(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> lo(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

}
Vec256<byte> lo(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> lo(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> lo(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> lo(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> lo(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> lo(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> lo(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> lo(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec256<float> lo(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: ret

}
Vec256<double> lo(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0016: ret

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
Vec128<float> permute(in Vec128<float> value, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Permute(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0016: ret

}
Vec128<double> permute(in Vec128<double> value, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Permute(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0016: ret

}
Vec256<float> permute(in Vec256<float> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Permute(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: ret

}
Vec256<double> permute(in Vec256<double> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Permute(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: ret

}
Vec128<float> permvar(in Vec128<float> lhs, in Vec128<int> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Avx::PermuteVar(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> permvar(in Vec128<double> lhs, in Vec128<long> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Avx::PermuteVar(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

}
Vec256<float> permvar(Vec256<float> lhs, in Vec256<int> control)
{
    IL_0000: ldarga.s lhs
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0007: ldarg.1
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::PermuteVar(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0012: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0017: ret

}
Vec256<double> permvar(Vec256<double> lhs, in Vec256<long> control)
{
    IL_0000: ldarga.s lhs
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0007: ldarg.1
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::PermuteVar(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0012: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0017: ret

}
Vec256<sbyte> perm2x128(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0017: ret

}
Vec256<byte> perm2x128(in Vec256<byte> lhs, in Vec256<byte> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0017: ret

}
Vec256<short> perm2x128(in Vec256<short> lhs, in Vec256<short> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0017: ret

}
Vec256<ushort> perm2x128(in Vec256<ushort> lhs, in Vec256<ushort> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0017: ret

}
Vec256<int> perm2x128(in Vec256<int> lhs, in Vec256<int> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0017: ret

}
Vec256<uint> perm2x128(in Vec256<uint> lhs, in Vec256<uint> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0017: ret

}
Vec256<long> perm2x128(in Vec256<long> lhs, in Vec256<long> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0017: ret

}
Vec256<ulong> perm2x128(in Vec256<ulong> lhs, in Vec256<ulong> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0017: ret

}
Vec256<float> perm2x128(in Vec256<float> lhs, in Vec256<float> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0017: ret

}
Vec256<double> perm2x128(in Vec256<double> lhs, in Vec256<double> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0017: ret

}
Vec256<int> perm8x32(in Vec256<int> src, in Vec256<int> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

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
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Sign(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> sign(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Sign(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<int> sign(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Sign(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

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
Vec128<float> sub(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> sub(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

}
Vec256<byte> sub(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> sub(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> sub(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> sub(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> sub(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> sub(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> sub(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> sub(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec256<float> sub(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: ret

}
Vec256<double> sub(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0016: ret

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
Vec128<float> hsub(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse3::HorizontalSubtract(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> hsub(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse3::HorizontalSubtract(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

}
Vec256<short> subh(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::HorizontalSubtract(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<int> hsub(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::HorizontalSubtract(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<float> hsub(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::HorizontalSubtract(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: ret

}
Vec256<double> hsub(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::HorizontalSubtract(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0016: ret

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
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> subs(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> subs(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> subs(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec128<short> blend(in Vec128<short> lhs, in Vec128<short> rhs, byte control)
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
Vec128<ushort> blend(in Vec128<ushort> lhs, in Vec128<ushort> rhs, byte control)
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
Vec128<int> blend(in Vec128<int> lhs, in Vec128<int> rhs, byte control)
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
Vec128<uint> blend(in Vec128<uint> lhs, in Vec128<uint> rhs, byte control)
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
Vec128<float> blend(in Vec128<float> lhs, in Vec128<float> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse41::Blend(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0021: ret

}
Vec128<double> blend(in Vec128<double> lhs, in Vec128<double> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse41::Blend(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0021: ret

}
Vec256<short> blend(in Vec256<short> lhs, in Vec256<short> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0017: ret

}
Vec256<ushort> blend(in Vec256<ushort> lhs, in Vec256<ushort> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0017: ret

}
Vec256<int> blend(in Vec256<int> lhs, in Vec256<int> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0017: ret

}
Vec256<uint> blend(in Vec256<uint> lhs, in Vec256<uint> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0017: ret

}
Vec256<float> blend(in Vec256<float> lhs, in Vec256<float> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Blend(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0017: ret

}
Vec256<double> blend(in Vec256<double> lhs, in Vec256<double> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Blend(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0017: ret

}
Vec256<byte> blendv(in Vec256<byte> lhs, in Vec256<byte> rhs, in Vec256<byte> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0017: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001C: ret

}
Vec256<sbyte> blendv(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, in Vec256<sbyte> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0017: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001C: ret

}
Vec256<short> blendv(in Vec256<short> lhs, in Vec256<short> rhs, in Vec256<short> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0017: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001C: ret

}
Vec256<ushort> blendv(in Vec256<ushort> lhs, in Vec256<ushort> rhs, in Vec256<ushort> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0017: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001C: ret

}
Vec256<int> blendv(in Vec256<int> lhs, in Vec256<int> rhs, in Vec256<int> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0017: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001C: ret

}
Vec256<uint> blendv(in Vec256<uint> lhs, in Vec256<uint> rhs, in Vec256<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0017: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001C: ret

}
Vec256<long> blendv(in Vec256<long> lhs, in Vec256<long> rhs, in Vec256<long> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0017: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001C: ret

}
Vec256<ulong> blendv(in Vec256<ulong> lhs, in Vec256<ulong> rhs, in Vec256<ulong> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0017: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001C: ret

}
Vec256<float> blendv(in Vec256<float> lhs, in Vec256<float> rhs, in Vec256<float> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0017: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_001C: ret

}
Vec256<double> blendv(in Vec256<double> lhs, in Vec256<double> rhs, in Vec256<double> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0017: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_001C: ret

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
ref Vec256<float> broadcast(in float src, out Vec256<float> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Single& Z0.As::asRef<System.Single>(System.Single&)
    IL_0007: call System.Single* Z0.As::refptr(System.Single&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::BroadcastScalarToVector256(System.Single*)
    IL_0011: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: stobj Z0.Vec256`1<System.Single>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<double> broadcast(in double src, out Vec256<double> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Double& Z0.As::asRef<System.Double>(System.Double&)
    IL_0007: call System.Double* Z0.As::refptr(System.Double&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::BroadcastScalarToVector256(System.Double*)
    IL_0011: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0016: stobj Z0.Vec256`1<System.Double>
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
ref Vec128<float> broadcast(in float src, out Vec128<float> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Single& Z0.As::asRef<System.Single>(System.Single&)
    IL_0007: call System.Single* Z0.As::refptr(System.Single&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Avx::BroadcastScalarToVector128(System.Single*)
    IL_0011: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0016: stobj Z0.Vec128`1<System.Single>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<double> broadcast(in double src, out Vec128<double> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldarg.0
    IL_0004: ldind.r8
    IL_0005: call Z0.Vec128`1<System.Double> Z0.Vec128::FromParts(System.Double,System.Double)
    IL_000A: stobj Z0.Vec128`1<System.Double>
    IL_000F: ldarg.1
    IL_0010: ret

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
ref Vec128<ushort> convert(in Vec128<byte> src, out Vec128<ushort> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldloca.s V_0
    IL_0004: call Z0.Vec128`1<System.Int16>& Z0.dinx::convert(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Int16>&)
    IL_0009: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.Int16>::As<System.UInt16>()
    IL_000E: stobj Z0.Vec128`1<System.UInt16>
    IL_0013: ldarg.1
    IL_0014: ret

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
ref Vec128<uint> convert(in Vec128<byte> src, out Vec128<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldloca.s V_0
    IL_0004: call Z0.Vec128`1<System.Int32>& Z0.dinx::convert(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Int32>&)
    IL_0009: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.Int32>::As<System.UInt32>()
    IL_000E: stobj Z0.Vec128`1<System.UInt32>
    IL_0013: ldarg.1
    IL_0014: ret

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
ref Vec128<ulong> convert(in Vec128<byte> src, out Vec128<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldloca.s V_0
    IL_0004: call Z0.Vec128`1<System.Int64>& Z0.dinx::convert(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Int64>&)
    IL_0009: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.Int64>::As<System.UInt64>()
    IL_000E: stobj Z0.Vec128`1<System.UInt64>
    IL_0013: ldarg.1
    IL_0014: ret

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
ref Vec128<uint> convert(in Vec128<ushort> src, out Vec128<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldloca.s V_0
    IL_0004: call Z0.Vec128`1<System.Int32>& Z0.dinx::convert(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.Int32>&)
    IL_0009: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.Int32>::As<System.UInt32>()
    IL_000E: stobj Z0.Vec128`1<System.UInt32>
    IL_0013: ldarg.1
    IL_0014: ret

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
ref Vec128<ulong> convert(in Vec128<ushort> src, out Vec128<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldloca.s V_0
    IL_0004: call Z0.Vec128`1<System.Int64>& Z0.dinx::convert(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.Int64>&)
    IL_0009: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.Int64>::As<System.UInt64>()
    IL_000E: stobj Z0.Vec128`1<System.UInt64>
    IL_0013: ldarg.1
    IL_0014: ret

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
ref Vec128<ulong> convert(in Vec128<uint> src, out Vec128<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldloca.s V_0
    IL_0004: call Z0.Vec128`1<System.Int64>& Z0.dinx::convert(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.Int64>&)
    IL_0009: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.Int64>::As<System.UInt64>()
    IL_000E: stobj Z0.Vec128`1<System.UInt64>
    IL_0013: ldarg.1
    IL_0014: ret

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
ref Vec256<ushort> convert(in Vec128<byte> src, out Vec256<ushort> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.Vector256::AsUInt16<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: stobj Z0.Vec256`1<System.UInt16>
    IL_0020: ldarg.1
    IL_0021: ret

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
ref Vec256<uint> convert(in Vec128<byte> src, out Vec256<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.Vector256::AsUInt32<System.Int32>(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: stobj Z0.Vec256`1<System.UInt32>
    IL_0020: ldarg.1
    IL_0021: ret

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
ref Vec256<ulong> convert(in Vec128<byte> src, out Vec256<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.Vector256::AsUInt64<System.Int32>(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: stobj Z0.Vec256`1<System.UInt64>
    IL_0020: ldarg.1
    IL_0021: ret

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
ref Vec256<uint> convert(in Vec128<ushort> src, out Vec256<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.Vector256::AsUInt32<System.Int32>(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: stobj Z0.Vec256`1<System.UInt32>
    IL_0020: ldarg.1
    IL_0021: ret

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
ref Vec256<ulong> convert(in Vec128<ushort> src, out Vec256<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.Vector256::AsUInt64<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: stobj Z0.Vec256`1<System.UInt64>
    IL_0020: ldarg.1
    IL_0021: ret

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
ref Vec256<ulong> convert(in Vec128<uint> src, out Vec256<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt32>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.Vector256::AsUInt64<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: stobj Z0.Vec256`1<System.UInt64>
    IL_0020: ldarg.1
    IL_0021: ret

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
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: ret

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
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Average(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<ushort> avg(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Average(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

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
Vec128<float> max(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Max(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> max(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Max(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

}
Vec256<byte> max(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> max(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> max(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

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
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> max(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> max(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<float> max(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Max(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: ret

}
Vec256<double> max(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Max(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0016: ret

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
Vec128<float> min(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Min(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> min(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Min(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

}
Vec256<byte> min(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> min(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> min(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> min(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> min(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> min(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<float> min(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Min(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: ret

}
Vec256<double> min(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Min(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0016: ret

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
    IL_0003: call Z0.Vec128`1<System.Int64> Z0.dinx::srli(Z0.Vec128`1<System.Int64>&,System.Byte)
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
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_000B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0010: ret

}
Vec256<ushort> abs(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_000B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0010: ret

}
Vec256<uint> abs(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0010: ret

}
Vec256<long> abs(Vec256<long> src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.s 63
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.dinx::srli(Z0.Vec256`1<System.Int64>&,System.Byte)
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
Vec128<float> add(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Add(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> add(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

}
Vec256<byte> add(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> add(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> add(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> add(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> add(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> add(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> add(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> add(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec256<float> add(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Add(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: ret

}
Vec256<double> add(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Add(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0016: ret

}
Vec128<short> addh(in Vec128<short> lhs, in Vec128<short> rhs)
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
Vec128<int> addh(in Vec128<int> lhs, in Vec128<int> rhs)
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
Vec128<float> addh(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse3::HorizontalAdd(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> addh(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse3::HorizontalAdd(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

}
Vec256<short> addh(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::HorizontalAdd(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<int> addh(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::HorizontalAdd(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<float> addh(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::HorizontalAdd(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: ret

}
Vec256<double> addh(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::HorizontalAdd(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0016: ret

}
void addh(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int16> Z0.dinx::addh(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_0010: ret

}
void addh(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int32> Z0.dinx::addh(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_0010: ret

}
void addh(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Single> Z0.dinx::addh(Z0.Vec128`1<System.Single>&,Z0.Vec128`1<System.Single>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_0010: ret

}
void addh(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Double> Z0.dinx::addh(Z0.Vec128`1<System.Double>&,Z0.Vec128`1<System.Double>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_0010: ret

}
void addh(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int16> Z0.dinx::addh(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_0010: ret

}
void addh(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int32> Z0.dinx::addh(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_0010: ret

}
void addh(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Single> Z0.dinx::addh(Z0.Vec256`1<System.Single>&,Z0.Vec256`1<System.Single>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec256`1<System.Single>&,System.Single&)
    IL_0010: ret

}
void addh(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Double> Z0.dinx::addh(Z0.Vec256`1<System.Double>&,Z0.Vec256`1<System.Double>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec256`1<System.Double>&,System.Double&)
    IL_0010: ret

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
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> adds(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> adds(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> adds(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

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
    IL_0002: stloc.0
    IL_0003: ldloca.s V_0
    IL_0005: call Z0.Vec128`1<System.UInt64> Z0.Vec128::LoadScalar<System.UInt64>(System.UInt64&)
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000F: ldarg.1
    IL_0010: conv.u8
    IL_0011: stloc.1
    IL_0012: ldloca.s V_1
    IL_0014: call Z0.Vec128`1<System.UInt64> Z0.Vec128::LoadScalar<System.UInt64>(System.UInt64&)
    IL_0019: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_001E: ldc.i4.0
    IL_001F: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Pclmulqdq::CarrylessMultiply(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0024: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0029: stloc.2
    IL_002A: ldloca.s V_2
    IL_002C: ldc.i4.0
    IL_002D: call System.UInt64 Z0.dinx::extract(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_0032: ret

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
ref Vec512<ulong> clmul(in Vec128<ulong> lhs, in Vec128<ulong> rhs, out Vec512<ulong> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.0
    IL_0004: call Z0.Vec128`1<System.UInt64> Z0.dinx::clmul(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.ClMulMask)
    IL_0009: stloc.0
    IL_000A: ldloca.s V_0
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_000E: ldc.i4.1
    IL_000F: call Z0.Vec128`1<System.UInt64> Z0.dinx::clmul(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.ClMulMask)
    IL_0014: stloc.1
    IL_0015: ldloca.s V_1
    IL_0017: ldarg.0
    IL_0018: ldarg.1
    IL_0019: ldc.i4.s 16
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.dinx::clmul(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.ClMulMask)
    IL_0020: stloc.2
    IL_0021: ldloca.s V_2
    IL_0023: ldarg.0
    IL_0024: ldarg.1
    IL_0025: ldc.i4.s 17
    IL_0027: call Z0.Vec128`1<System.UInt64> Z0.dinx::clmul(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.ClMulMask)
    IL_002C: stloc.3
    IL_002D: ldloca.s V_3
    IL_002F: call Z0.Vec512`1<System.UInt64> Z0.Vec512::FromParts<System.UInt64>(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0034: stobj Z0.Vec512`1<System.UInt64>
    IL_0039: ldarg.2
    IL_003A: ret

}
long dot(Vec256<int> lhs, Vec256<int> rhs)
{
    IL_0000: ldarga.s lhs
    IL_0002: ldarga.s rhs
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.dinx::mul(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0009: stloc.0
    IL_000A: ldloca.s V_0
    IL_000C: call Z0.Vec128`1<System.Int64> Z0.dinx::lo(Z0.Vec256`1<System.Int64>&)
    IL_0011: stloc.1
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec128`1<System.Int64> Z0.dinx::hi(Z0.Vec256`1<System.Int64>&)
    IL_0019: stloc.2
    IL_001A: ldloca.s V_1
    IL_001C: ldloca.s V_2
    IL_001E: call Z0.Vec128`1<System.Int64> Z0.dinx::add(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0023: stloc.3
    IL_0024: ldloc.3
    IL_0025: call Z0.Span128`1<System.Int64> Z0.ginxs::ToSpan128<System.Int64>(Z0.Vec128`1<System.Int64>)
    IL_002A: stloc.s V_4
    IL_002C: ldloca.s V_4
    IL_002E: ldc.i4.0
    IL_002F: call System.Int64& Z0.Span128`1<System.Int64>::get_Item(System.Int32)
    IL_0034: ldind.i8
    IL_0035: ldloca.s V_4
    IL_0037: ldc.i4.1
    IL_0038: call System.Int64& Z0.Span128`1<System.Int64>::get_Item(System.Int32)
    IL_003D: ldind.i8
    IL_003E: add
    IL_003F: ret

}
Vec128<float> dot(Vec128<float> lhs, Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000C: ldc.i4 255
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse41::DotProduct(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Byte)
    IL_0016: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: ret

}
Vec128<double> dot(Vec128<double> lhs, Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000C: ldc.i4 255
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse41::DotProduct(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Byte)
    IL_0016: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: ret

}
Vec256<float> dot(Vec256<float> lhs, Vec256<float> rhs)
{
    IL_0000: ldarga.s lhs
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0007: ldarga.s rhs
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000E: ldc.i4 255
    IL_0013: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::DotProduct(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Byte)
    IL_0018: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_001D: ret

}
void dot(Vec128<float> lhs, Vec128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000C: ldc.i4.0
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse41::DotProduct(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Byte)
    IL_0012: stloc.0
    IL_0013: ldloca.s V_0
    IL_0015: ldarg.2
    IL_0016: call System.Void zfunc::vstore(System.Runtime.Intrinsics.Vector128`1<System.Single>&,System.Single&)
    IL_001B: ret

}
void dot(Vec128<double> lhs, Vec128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000C: ldc.i4.0
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse41::DotProduct(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Byte)
    IL_0012: stloc.0
    IL_0013: ldloca.s V_0
    IL_0015: ldarg.2
    IL_0016: call System.Void zfunc::vstore(System.Runtime.Intrinsics.Vector128`1<System.Double>&,System.Double&)
    IL_001B: ret

}
void dot(Vec256<float> lhs, Vec256<float> rhs, ref float dst)
{
    IL_0000: ldarga.s lhs
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0007: ldarga.s rhs
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000E: ldc.i4.0
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::DotProduct(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Byte)
    IL_0014: stloc.0
    IL_0015: ldloca.s V_0
    IL_0017: ldarg.2
    IL_0018: call System.Void zfunc::vstore(System.Runtime.Intrinsics.Vector256`1<System.Single>&,System.Single&)
    IL_001D: ret

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
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Multiply(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> mul(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Multiply(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

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
    IL_001F: call Z0.Vec256`1<System.UInt64> Z0.dinx::srli(Z0.Vec256`1<System.UInt64>&,System.Byte)
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
    IL_0047: call Z0.Vec256`1<System.UInt64> Z0.dinx::srli(Z0.Vec256`1<System.UInt64>&,System.Byte)
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
    IL_0066: call Z0.Vec256`1<System.UInt64> Z0.dinx::slli(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_006B: stloc.s V_6
    IL_006D: ldloc.2
    IL_006E: ldloc.s V_4
    IL_0070: call Z0.Vec256`1<System.UInt64> Z0.dinx::mul(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0075: stloc.s V_7
    IL_0077: ldloca.s V_7
    IL_0079: ldc.i4.s 32
    IL_007B: call Z0.Vec256`1<System.UInt64> Z0.dinx::slli(Z0.Vec256`1<System.UInt64>&,System.Byte)
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
Vec128<float> negate(in Vec128<float> src)
{
    IL_0000: ldsflda Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec128`1<System.Single> Z0.dinx::sub(Z0.Vec128`1<System.Single>&,Z0.Vec128`1<System.Single>&)
    IL_000B: ret

}
Vec128<double> negate(in Vec128<double> src)
{
    IL_0000: ldsflda Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec128`1<System.Double> Z0.dinx::sub(Z0.Vec128`1<System.Double>&,Z0.Vec128`1<System.Double>&)
    IL_000B: ret

}
Vec256<sbyte> negate(in Vec256<sbyte> src)
{
    IL_0000: ldsflda Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec256`1<System.SByte> Z0.dinx::sub(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_000B: ret

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
Vec256<float> negate(in Vec256<float> src)
{
    IL_0000: ldsflda Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec256`1<System.Single> Z0.dinx::sub(Z0.Vec256`1<System.Single>&,Z0.Vec256`1<System.Single>&)
    IL_000B: ret

}
Vec256<double> negate(in Vec256<double> src)
{
    IL_0000: ldsflda Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec256`1<System.Double> Z0.dinx::sub(Z0.Vec256`1<System.Double>&,Z0.Vec256`1<System.Double>&)
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
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::SumAbsoluteDifferences(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}

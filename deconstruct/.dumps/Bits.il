// 2019-08-26 19:39:48:262
Vec128<uint> srl(in Vec128<uint> src, Vec128<uint> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: ret

}
Vec128<long> srl(in Vec128<long> src, Vec128<long> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: ret

}
Vec128<ulong> srl(in Vec128<ulong> src, Vec128<ulong> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: ret

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
Vec128<ulong> srli32(in Vec128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt64>::As<System.UInt32>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call Z0.Vec128`1<System.UInt32> Z0.Bits::srli(Z0.Vec128`1<System.UInt32>&,System.Byte)
    IL_000F: stloc.1
    IL_0010: ldloca.s V_1
    IL_0012: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt32>::As<System.UInt64>()
    IL_0017: ret

}
Vec256<short> srli(in Vec256<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0014: ret

}
Vec256<ushort> srli(in Vec256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0014: ret

}
Vec256<int> srli(in Vec256<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0014: ret

}
Vec256<uint> srli(in Vec256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0014: ret

}
Vec256<long> srli(in Vec256<long> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0014: ret

}
Vec256<ulong> srli(in Vec256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0014: ret

}
Vec128<int> srlv(in Vec128<int> src, in Vec128<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec128<uint> srlv(in Vec128<uint> src, in Vec128<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: ret

}
Vec128<long> srlv(in Vec128<long> src, in Vec128<ulong> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: ret

}
Vec128<ulong> srlv(in Vec128<ulong> src, in Vec128<ulong> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: ret

}
Vec256<int> srlv(in Vec256<int> src, in Vec256<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: ret

}
Vec256<uint> srlv(in Vec256<uint> src, in Vec256<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: ret

}
Vec256<long> srlv(in Vec256<long> src, in Vec256<ulong> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: ret

}
Vec256<ulong> srlv(in Vec256<ulong> src, in Vec256<ulong> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: ret

}
bool testc(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
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
bool testc(in Vec128<byte> lhs, in Vec128<byte> rhs)
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
bool testc(in Vec128<short> lhs, in Vec128<short> rhs)
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
bool testc(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
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
bool testc(in Vec128<int> lhs, in Vec128<int> rhs)
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
bool testc(in Vec128<uint> lhs, in Vec128<uint> rhs)
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
bool testc(in Vec128<long> lhs, in Vec128<long> rhs)
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
bool testc(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
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
bool testc(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: ret

}
bool testc(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: ret

}
bool testc(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: ret

}
bool testc(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: ret

}
bool testc(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: ret

}
bool testc(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: ret

}
bool testc(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
bool testc(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ret

}
bool testc(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: ret

}
bool testc(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: ret

}
bool testc(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: ret

}
bool testc(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: ret

}
bool testz(in Vec128<byte> lhs, in Vec128<byte> rhs)
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
bool testz(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
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
bool testz(in Vec128<short> lhs, in Vec128<short> rhs)
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
bool testz(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
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
bool testz(in Vec128<int> lhs, in Vec128<int> rhs)
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
bool testz(in Vec128<uint> lhs, in Vec128<uint> rhs)
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
bool testz(in Vec128<long> lhs, in Vec128<long> rhs)
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
bool testz(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
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
bool testz(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: ret

}
bool testz(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: ret

}
bool testz(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: ret

}
bool testz(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: ret

}
bool testz(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: ret

}
bool testz(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: ret

}
bool testz(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
bool testz(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ret

}
bool testz(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: ret

}
bool testz(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: ret

}
bool testz(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: ret

}
bool testz(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: ret

}
UInt128 xor(in UInt128 lhs, in UInt128 rhs)
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
    IL_001C: call Z0.Vec128`1<System.UInt64> Z0.Bits::xor(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0021: stloc.2
    IL_0022: ldloca.s V_2
    IL_0024: call Z0.UInt128 Z0.UInt128X::ToUInt128(Z0.Vec128`1<System.UInt64>&)
    IL_0029: ret

}
ref UInt128 xor(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
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
    IL_001D: call Z0.Vec128`1<System.UInt64> Z0.Bits::xor(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0022: stloc.2
    IL_0023: ldloca.s V_2
    IL_0025: call Z0.UInt128 Z0.UInt128X::ToUInt128(Z0.Vec128`1<System.UInt64>&)
    IL_002A: stobj Z0.UInt128
    IL_002F: ldarg.2
    IL_0030: ret

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
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: ret

}
Vec256<short> xor(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: ret

}
Vec256<sbyte> xor(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: ret

}
Vec256<ushort> xor(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: ret

}
Vec256<int> xor(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: ret

}
Vec256<uint> xor(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: ret

}
Vec256<long> xor(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: ret

}
Vec256<ulong> xor(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: ret

}
Vec256<float> xor(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Xor(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: ret

}
Vec256<double> xor(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Xor(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: ret

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
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: ret

}
Vec256<short> or(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: ret

}
Vec256<sbyte> or(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: ret

}
Vec256<ushort> or(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: ret

}
Vec256<int> or(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: ret

}
Vec256<uint> or(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: ret

}
Vec256<long> or(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: ret

}
Vec256<ulong> or(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: ret

}
Vec256<float> or(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Or(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: ret

}
Vec256<double> or(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Or(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: ret

}
void or(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.SByte> Z0.Bits::or(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec128`1<System.SByte>&,System.SByte&)
    IL_0010: ret

}
void or(in Vec128<byte> lhs, in Vec128<byte> rhs, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Byte> Z0.Bits::or(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec128`1<System.Byte>&,System.Byte&)
    IL_0010: ret

}
void or(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int16> Z0.Bits::or(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_0010: ret

}
void or(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt16> Z0.Bits::or(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec128`1<System.UInt16>&,System.UInt16&)
    IL_0010: ret

}
void or(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int32> Z0.Bits::or(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_0010: ret

}
void or(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt32> Z0.Bits::or(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_0010: ret

}
void or(in Vec128<long> lhs, in Vec128<long> rhs, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int64> Z0.Bits::or(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec128`1<System.Int64>&,System.Int64&)
    IL_0010: ret

}
void or(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.Bits::or(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec128`1<System.UInt64>&,System.UInt64&)
    IL_0010: ret

}
void or(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Single> Z0.Bits::or(Z0.Vec128`1<System.Single>&,Z0.Vec128`1<System.Single>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_0010: ret

}
void or(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Double> Z0.Bits::or(Z0.Vec128`1<System.Double>&,Z0.Vec128`1<System.Double>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_0010: ret

}
void or(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.SByte> Z0.Bits::or(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec256`1<System.SByte>&,System.SByte&)
    IL_0010: ret

}
void or(in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Byte> Z0.Bits::or(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec256`1<System.Byte>&,System.Byte&)
    IL_0010: ret

}
void or(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int16> Z0.Bits::or(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_0010: ret

}
void or(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt16> Z0.Bits::or(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_0010: ret

}
void or(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int32> Z0.Bits::or(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_0010: ret

}
void or(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt32> Z0.Bits::or(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_0010: ret

}
void or(in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int64> Z0.Bits::or(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec256`1<System.Int64>&,System.Int64&)
    IL_0010: ret

}
void or(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt64> Z0.Bits::or(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec256`1<System.UInt64>&,System.UInt64&)
    IL_0010: ret

}
void or(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Single> Z0.Bits::or(Z0.Vec256`1<System.Single>&,Z0.Vec256`1<System.Single>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec256`1<System.Single>&,System.Single&)
    IL_0010: ret

}
void or(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Double> Z0.Bits::or(Z0.Vec256`1<System.Double>&,Z0.Vec256`1<System.Double>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void zfunc::vstore(Z0.Vec256`1<System.Double>&,System.Double&)
    IL_0010: ret

}
Vec128<sbyte> pack(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::PackSignedSaturate(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<byte> pack(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.UInt16>::As<System.Int16>()
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.UInt16>::As<System.Int16>()
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::PackUnsignedSaturate(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<short> pack(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::PackSignedSaturate(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<ushort> pack(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.UInt32>::As<System.Int32>()
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.UInt32>::As<System.Int32>()
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse41::PackUnsignedSaturate(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec256<sbyte> pack(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::PackSignedSaturate(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: ret

}
Vec256<byte> pack(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.UInt16>::As<System.Int16>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000E: ldarg.1
    IL_000F: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.UInt16>::As<System.Int16>()
    IL_0014: stloc.1
    IL_0015: ldloca.s V_1
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::PackUnsignedSaturate(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0021: stloc.2
    IL_0022: ldloca.s V_2
    IL_0024: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0029: ret

}
Vec256<short> pack(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::PackSignedSaturate(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: ret

}
Vec256<ushort> pack(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.UInt32>::As<System.Int32>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000E: ldarg.1
    IL_000F: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.UInt32>::As<System.Int32>()
    IL_0014: stloc.1
    IL_0015: ldloca.s V_1
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::PackUnsignedSaturate(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0021: stloc.2
    IL_0022: ldloca.s V_2
    IL_0024: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0029: ret

}
uint pop(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Popcnt::PopCount(System.UInt32)
    IL_0006: ret

}
uint pop(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Popcnt::PopCount(System.UInt32)
    IL_0006: ret

}
uint pop(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Popcnt::PopCount(System.UInt32)
    IL_0006: ret

}
uint pop(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Popcnt::PopCount(System.UInt32)
    IL_0006: ret

}
uint pop(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Popcnt::PopCount(System.UInt32)
    IL_0006: ret

}
uint pop(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Popcnt::PopCount(System.UInt32)
    IL_0006: ret

}
uint pop(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 System.Runtime.Intrinsics.X86.Popcnt/X64::PopCount(System.UInt64)
    IL_0006: conv.u4
    IL_0007: ret

}
uint pop(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 System.Runtime.Intrinsics.X86.Popcnt/X64::PopCount(System.UInt64)
    IL_0006: conv.u4
    IL_0007: ret

}
ulong pop(Span<byte> src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldc.i4.0
    IL_0004: stloc.1
    IL_0005: br.s IL_001D
    IL_0007: ldloc.0
    IL_0008: ldarga.s src
    IL_000A: ldloc.1
    IL_000B: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0010: ldind.u1
    IL_0011: call System.UInt32 Z0.Bits::pop(System.Byte)
    IL_0016: conv.u8
    IL_0017: add
    IL_0018: stloc.0
    IL_0019: ldloc.1
    IL_001A: ldc.i4.1
    IL_001B: add
    IL_001C: stloc.1
    IL_001D: ldloc.1
    IL_001E: ldarga.s src
    IL_0020: call System.Int32 System.Span`1<System.Byte>::get_Length()
    IL_0025: blt.s IL_0007
    IL_0027: ldloc.0
    IL_0028: ret

}
ulong pop(Span<ulong> src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldc.i4.0
    IL_0004: stloc.1
    IL_0005: br.s IL_001D
    IL_0007: ldloc.0
    IL_0008: ldarga.s src
    IL_000A: ldloc.1
    IL_000B: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0010: ldind.i8
    IL_0011: call System.UInt32 Z0.Bits::pop(System.UInt64)
    IL_0016: conv.u8
    IL_0017: add
    IL_0018: stloc.0
    IL_0019: ldloc.1
    IL_001A: ldc.i4.1
    IL_001B: add
    IL_001C: stloc.1
    IL_001D: ldloc.1
    IL_001E: ldarga.s src
    IL_0020: call System.Int32 System.Span`1<System.UInt64>::get_Length()
    IL_0025: blt.s IL_0007
    IL_0027: ldloc.0
    IL_0028: ret

}
ulong pop(Span<uint> src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldc.i4.0
    IL_0004: stloc.1
    IL_0005: br.s IL_001D
    IL_0007: ldloc.0
    IL_0008: ldarga.s src
    IL_000A: ldloc.1
    IL_000B: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0010: ldind.u4
    IL_0011: call System.UInt32 System.Runtime.Intrinsics.X86.Popcnt::PopCount(System.UInt32)
    IL_0016: conv.u8
    IL_0017: add
    IL_0018: stloc.0
    IL_0019: ldloc.1
    IL_001A: ldc.i4.1
    IL_001B: add
    IL_001C: stloc.1
    IL_001D: ldloc.1
    IL_001E: ldarga.s src
    IL_0020: call System.Int32 System.Span`1<System.UInt32>::get_Length()
    IL_0025: blt.s IL_0007
    IL_0027: ldloc.0
    IL_0028: ret

}
ulong pop(Span<ushort> src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldc.i4.0
    IL_0004: stloc.1
    IL_0005: br.s IL_001D
    IL_0007: ldloc.0
    IL_0008: ldarga.s src
    IL_000A: ldloc.1
    IL_000B: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0010: ldind.u2
    IL_0011: call System.UInt32 System.Runtime.Intrinsics.X86.Popcnt::PopCount(System.UInt32)
    IL_0016: conv.u8
    IL_0017: add
    IL_0018: stloc.0
    IL_0019: ldloc.1
    IL_001A: ldc.i4.1
    IL_001B: add
    IL_001C: stloc.1
    IL_001D: ldloc.1
    IL_001E: ldarga.s src
    IL_0020: call System.Int32 System.Span`1<System.UInt16>::get_Length()
    IL_0025: blt.s IL_0007
    IL_0027: ldloc.0
    IL_0028: ret

}
sbyte range(sbyte src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: conv.u1
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.Byte Z0.Bits::range(System.Byte,Z0.BitPos,Z0.BitPos)
    IL_0009: conv.i1
    IL_000A: ret

}
byte range(byte src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.BitPos::op_Implicit(Z0.BitPos)
    IL_0007: ldarga.s i1
    IL_0009: ldarga.s i0
    IL_000B: call Z0.BitSize Z0.BitPos::op_Subtraction(Z0.BitPos&,Z0.BitPos&)
    IL_0010: call System.Byte Z0.BitSize::op_Explicit(Z0.BitSize)
    IL_0015: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_001A: conv.u1
    IL_001B: ret

}
ushort range(ushort src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.BitPos::op_Implicit(Z0.BitPos)
    IL_0007: ldarga.s i1
    IL_0009: ldarga.s i0
    IL_000B: call Z0.BitSize Z0.BitPos::op_Subtraction(Z0.BitPos&,Z0.BitPos&)
    IL_0010: call System.Byte Z0.BitSize::op_Explicit(Z0.BitSize)
    IL_0015: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_001A: conv.u2
    IL_001B: ret

}
short range(short src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: conv.u2
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.UInt16 Z0.Bits::range(System.UInt16,Z0.BitPos,Z0.BitPos)
    IL_0009: conv.i2
    IL_000A: ret

}
uint range(uint src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.BitPos::op_Implicit(Z0.BitPos)
    IL_0007: ldarga.s i1
    IL_0009: ldarga.s i0
    IL_000B: call Z0.BitSize Z0.BitPos::op_Subtraction(Z0.BitPos&,Z0.BitPos&)
    IL_0010: call System.Byte Z0.BitSize::op_Explicit(Z0.BitSize)
    IL_0015: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_001A: ret

}
int range(int src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.Bits::range(System.UInt32,Z0.BitPos,Z0.BitPos)
    IL_0008: ret

}
ulong range(ulong src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.BitPos::op_Implicit(Z0.BitPos)
    IL_0007: ldarga.s i1
    IL_0009: ldarga.s i0
    IL_000B: call Z0.BitSize Z0.BitPos::op_Subtraction(Z0.BitPos&,Z0.BitPos&)
    IL_0010: call System.Byte Z0.BitSize::op_Explicit(Z0.BitSize)
    IL_0015: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::BitFieldExtract(System.UInt64,System.Byte,System.Byte)
    IL_001A: ret

}
long range(long src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.Bits::range(System.UInt64,Z0.BitPos,Z0.BitPos)
    IL_0008: ret

}
float range(float src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call System.Int32 Z0.Bits::range(System.Int32,Z0.BitPos,Z0.BitPos)
    IL_000D: call System.Single System.BitConverter::Int32BitsToSingle(System.Int32)
    IL_0012: ret

}
double range(double src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call System.Int64 Z0.Bits::range(System.Int64,Z0.BitPos,Z0.BitPos)
    IL_000D: call System.Double System.BitConverter::Int64BitsToDouble(System.Int64)
    IL_0012: ret

}
uint rank(byte src, BitPos pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_0007: ldarg.1
    IL_0008: call System.Byte Z0.Bits::range(System.Byte,Z0.BitPos,Z0.BitPos)
    IL_000D: call System.UInt32 Z0.Bits::pop(System.Byte)
    IL_0012: ret

}
uint rank(sbyte src, BitPos pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_0007: ldarg.1
    IL_0008: call System.SByte Z0.Bits::range(System.SByte,Z0.BitPos,Z0.BitPos)
    IL_000D: call System.UInt32 Z0.Bits::pop(System.SByte)
    IL_0012: ret

}
uint rank(short src, BitPos pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_0007: ldarg.1
    IL_0008: call System.Int16 Z0.Bits::range(System.Int16,Z0.BitPos,Z0.BitPos)
    IL_000D: call System.UInt32 Z0.Bits::pop(System.Int16)
    IL_0012: ret

}
uint rank(ushort src, BitPos pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_0007: ldarg.1
    IL_0008: call System.UInt16 Z0.Bits::range(System.UInt16,Z0.BitPos,Z0.BitPos)
    IL_000D: call System.UInt32 Z0.Bits::pop(System.UInt16)
    IL_0012: ret

}
uint rank(int src, BitPos pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_0007: ldarg.1
    IL_0008: call System.Int32 Z0.Bits::range(System.Int32,Z0.BitPos,Z0.BitPos)
    IL_000D: call System.UInt32 Z0.Bits::pop(System.Int32)
    IL_0012: ret

}
uint rank(uint src, BitPos pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_0007: ldarg.1
    IL_0008: call System.UInt32 Z0.Bits::range(System.UInt32,Z0.BitPos,Z0.BitPos)
    IL_000D: call System.UInt32 Z0.Bits::pop(System.UInt32)
    IL_0012: ret

}
uint rank(long src, BitPos pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_0007: ldarg.1
    IL_0008: call System.Int64 Z0.Bits::range(System.Int64,Z0.BitPos,Z0.BitPos)
    IL_000D: call System.UInt32 Z0.Bits::pop(System.Int64)
    IL_0012: ret

}
uint rank(ulong src, BitPos pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_0007: ldarg.1
    IL_0008: call System.UInt64 Z0.Bits::range(System.UInt64,Z0.BitPos,Z0.BitPos)
    IL_000D: call System.UInt32 Z0.Bits::pop(System.UInt64)
    IL_0012: ret

}
Vec128<ushort> rotl(Vec128<ushort> src, byte offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec128`1<System.UInt16> Z0.Bits::slli(Z0.Vec128`1<System.UInt16>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldarga.s src
    IL_000B: ldc.i4.s 16
    IL_000D: ldarg.1
    IL_000E: sub
    IL_000F: conv.u1
    IL_0010: call Z0.Vec128`1<System.UInt16> Z0.Bits::srli(Z0.Vec128`1<System.UInt16>&,System.Byte)
    IL_0015: stloc.1
    IL_0016: ldloca.s V_0
    IL_0018: ldloca.s V_1
    IL_001A: call Z0.Vec128`1<System.UInt16> Z0.Bits::or(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_001F: ret

}
Vec128<uint> rotl(Vec128<uint> src, byte offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec128`1<System.UInt32> Z0.Bits::slli(Z0.Vec128`1<System.UInt32>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldarga.s src
    IL_000B: ldc.i4.s 16
    IL_000D: ldarg.1
    IL_000E: sub
    IL_000F: conv.u1
    IL_0010: call Z0.Vec128`1<System.UInt32> Z0.Bits::srli(Z0.Vec128`1<System.UInt32>&,System.Byte)
    IL_0015: stloc.1
    IL_0016: ldloca.s V_0
    IL_0018: ldloca.s V_1
    IL_001A: call Z0.Vec128`1<System.UInt32> Z0.Bits::or(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_001F: ret

}
Vec128<ulong> rotl(Vec128<ulong> src, byte offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec128`1<System.UInt64> Z0.Bits::slli(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldarga.s src
    IL_000B: ldc.i4.s 16
    IL_000D: ldarg.1
    IL_000E: sub
    IL_000F: conv.u1
    IL_0010: call Z0.Vec128`1<System.UInt64> Z0.Bits::srli(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_0015: stloc.1
    IL_0016: ldloca.s V_0
    IL_0018: ldloca.s V_1
    IL_001A: call Z0.Vec128`1<System.UInt64> Z0.Bits::or(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_001F: ret

}
Vec256<ushort> rotl(Vec256<ushort> src, byte offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec256`1<System.UInt16> Z0.Bits::slli(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldarga.s src
    IL_000B: ldc.i4.s 16
    IL_000D: ldarg.1
    IL_000E: sub
    IL_000F: conv.u1
    IL_0010: call Z0.Vec256`1<System.UInt16> Z0.Bits::srli(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0015: stloc.1
    IL_0016: ldloca.s V_0
    IL_0018: ldloca.s V_1
    IL_001A: call Z0.Vec256`1<System.UInt16> Z0.Bits::or(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_001F: ret

}
Vec256<uint> rotl(Vec256<uint> src, byte offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec256`1<System.UInt32> Z0.Bits::slli(Z0.Vec256`1<System.UInt32>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldarga.s src
    IL_000B: ldc.i4.s 32
    IL_000D: ldarg.1
    IL_000E: sub
    IL_000F: conv.u1
    IL_0010: call Z0.Vec256`1<System.UInt32> Z0.Bits::srli(Z0.Vec256`1<System.UInt32>&,System.Byte)
    IL_0015: stloc.1
    IL_0016: ldloca.s V_0
    IL_0018: ldloca.s V_1
    IL_001A: call Z0.Vec256`1<System.UInt32> Z0.Bits::or(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_001F: ret

}
Vec256<ulong> rotl(Vec256<ulong> src, byte offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec256`1<System.UInt64> Z0.Bits::slli(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldarga.s src
    IL_000B: ldc.i4.s 64
    IL_000D: ldarg.1
    IL_000E: sub
    IL_000F: conv.u1
    IL_0010: call Z0.Vec256`1<System.UInt64> Z0.Bits::srli(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0015: stloc.1
    IL_0016: ldloca.s V_0
    IL_0018: ldloca.s V_1
    IL_001A: call Z0.Vec256`1<System.UInt64> Z0.Bits::or(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_001F: ret

}
Vec256<ulong> rotl(Vec256<ulong> src, Vec256<ulong> offsets)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offsets
    IL_0004: call Z0.Vec256`1<System.UInt64> Z0.Bits::sllv(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0009: stloc.0
    IL_000A: ldarga.s src
    IL_000C: ldsflda Z0.Vec256`1<System.UInt64> Z0.Bits::Vec256u64
    IL_0011: ldarga.s offsets
    IL_0013: call Z0.Vec256`1<System.UInt64> Z0.dinx::sub(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0018: stloc.2
    IL_0019: ldloca.s V_2
    IL_001B: call Z0.Vec256`1<System.UInt64> Z0.Bits::srlv(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0020: stloc.1
    IL_0021: ldloca.s V_0
    IL_0023: ldloca.s V_1
    IL_0025: call Z0.Vec256`1<System.UInt64> Z0.Bits::or(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_002A: ret

}
Vec256<uint> rotl(Vec256<uint> src, Vec256<uint> offsets)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offsets
    IL_0004: call Z0.Vec256`1<System.UInt32> Z0.Bits::sllv(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0009: stloc.0
    IL_000A: ldarga.s src
    IL_000C: ldsflda Z0.Vec256`1<System.UInt32> Z0.Bits::Vec256u32
    IL_0011: ldarga.s offsets
    IL_0013: call Z0.Vec256`1<System.UInt32> Z0.dinx::sub(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0018: stloc.2
    IL_0019: ldloca.s V_2
    IL_001B: call Z0.Vec256`1<System.UInt32> Z0.Bits::srlv(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0020: stloc.1
    IL_0021: ldloca.s V_0
    IL_0023: ldloca.s V_1
    IL_0025: call Z0.Vec256`1<System.UInt32> Z0.Bits::or(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_002A: ret

}
Vec128<ulong> rotl(Vec128<ulong> src, Vec128<ulong> offsets)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offsets
    IL_0004: call Z0.Vec128`1<System.UInt64> Z0.Bits::sllv(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0009: stloc.0
    IL_000A: ldarga.s src
    IL_000C: ldsflda Z0.Vec128`1<System.UInt64> Z0.Bits::Vec128u64
    IL_0011: ldarga.s offsets
    IL_0013: call Z0.Vec128`1<System.UInt64> Z0.dinx::sub(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0018: stloc.2
    IL_0019: ldloca.s V_2
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Bits::srlv(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0020: stloc.1
    IL_0021: ldloca.s V_0
    IL_0023: ldloca.s V_1
    IL_0025: call Z0.Vec128`1<System.UInt64> Z0.Bits::or(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_002A: ret

}
Vec128<uint> rotl(Vec128<uint> src, Vec128<uint> offsets)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offsets
    IL_0004: call Z0.Vec128`1<System.UInt32> Z0.Bits::sllv(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0009: stloc.0
    IL_000A: ldarga.s src
    IL_000C: ldsflda Z0.Vec128`1<System.UInt32> Z0.Bits::Vec128u32
    IL_0011: ldarga.s offsets
    IL_0013: call Z0.Vec128`1<System.UInt32> Z0.dinx::sub(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0018: stloc.2
    IL_0019: ldloca.s V_2
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Bits::srlv(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0020: stloc.1
    IL_0021: ldloca.s V_0
    IL_0023: ldloca.s V_1
    IL_0025: call Z0.Vec128`1<System.UInt32> Z0.Bits::or(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_002A: ret

}
Vec128<ushort> rotr(Vec128<ushort> src, byte offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec128`1<System.UInt16> Z0.Bits::srli(Z0.Vec128`1<System.UInt16>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldarga.s src
    IL_000B: ldc.i4.s 16
    IL_000D: ldarg.1
    IL_000E: sub
    IL_000F: conv.u1
    IL_0010: call Z0.Vec128`1<System.UInt16> Z0.Bits::slli(Z0.Vec128`1<System.UInt16>&,System.Byte)
    IL_0015: stloc.1
    IL_0016: ldloca.s V_0
    IL_0018: ldloca.s V_1
    IL_001A: call Z0.Vec128`1<System.UInt16> Z0.Bits::or(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_001F: ret

}
Vec128<uint> rotr(Vec128<uint> src, byte offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec128`1<System.UInt32> Z0.Bits::srli(Z0.Vec128`1<System.UInt32>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldarga.s src
    IL_000B: ldc.i4.s 32
    IL_000D: ldarg.1
    IL_000E: sub
    IL_000F: conv.u1
    IL_0010: call Z0.Vec128`1<System.UInt32> Z0.Bits::slli(Z0.Vec128`1<System.UInt32>&,System.Byte)
    IL_0015: stloc.1
    IL_0016: ldloca.s V_0
    IL_0018: ldloca.s V_1
    IL_001A: call Z0.Vec128`1<System.UInt32> Z0.Bits::or(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_001F: ret

}
Vec128<ulong> rotr(Vec128<ulong> src, byte offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec128`1<System.UInt64> Z0.Bits::srli(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldarga.s src
    IL_000B: ldc.i4.s 64
    IL_000D: ldarg.1
    IL_000E: sub
    IL_000F: conv.u1
    IL_0010: call Z0.Vec128`1<System.UInt64> Z0.Bits::slli(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_0015: stloc.1
    IL_0016: ldloca.s V_0
    IL_0018: ldloca.s V_1
    IL_001A: call Z0.Vec128`1<System.UInt64> Z0.Bits::or(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_001F: ret

}
Vec256<ushort> rotr(Vec256<ushort> src, byte offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec256`1<System.UInt16> Z0.Bits::srli(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldarga.s src
    IL_000B: ldc.i4.s 16
    IL_000D: ldarg.1
    IL_000E: sub
    IL_000F: conv.u1
    IL_0010: call Z0.Vec256`1<System.UInt16> Z0.Bits::slli(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0015: stloc.1
    IL_0016: ldloca.s V_0
    IL_0018: ldloca.s V_1
    IL_001A: call Z0.Vec256`1<System.UInt16> Z0.Bits::or(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_001F: ret

}
Vec256<uint> rotr(Vec256<uint> src, byte offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec256`1<System.UInt32> Z0.Bits::srli(Z0.Vec256`1<System.UInt32>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldarga.s src
    IL_000B: ldc.i4.s 32
    IL_000D: ldarg.1
    IL_000E: sub
    IL_000F: conv.u1
    IL_0010: call Z0.Vec256`1<System.UInt32> Z0.Bits::slli(Z0.Vec256`1<System.UInt32>&,System.Byte)
    IL_0015: stloc.1
    IL_0016: ldloca.s V_0
    IL_0018: ldloca.s V_1
    IL_001A: call Z0.Vec256`1<System.UInt32> Z0.Bits::or(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_001F: ret

}
Vec256<ulong> rotr(Vec256<ulong> src, byte offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec256`1<System.UInt64> Z0.Bits::srli(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldarga.s src
    IL_000B: ldc.i4.s 64
    IL_000D: ldarg.1
    IL_000E: sub
    IL_000F: conv.u1
    IL_0010: call Z0.Vec256`1<System.UInt64> Z0.Bits::slli(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0015: stloc.1
    IL_0016: ldloca.s V_0
    IL_0018: ldloca.s V_1
    IL_001A: call Z0.Vec256`1<System.UInt64> Z0.Bits::or(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_001F: ret

}
Vec128<uint> rotr(Vec128<uint> src, Vec128<uint> offsets)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offsets
    IL_0004: call Z0.Vec128`1<System.UInt32> Z0.Bits::srlv(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0009: stloc.0
    IL_000A: ldarga.s src
    IL_000C: ldsflda Z0.Vec128`1<System.UInt32> Z0.Bits::Vec128u32
    IL_0011: ldarga.s offsets
    IL_0013: call Z0.Vec128`1<System.UInt32> Z0.dinx::sub(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0018: stloc.2
    IL_0019: ldloca.s V_2
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Bits::sllv(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0020: stloc.1
    IL_0021: ldloca.s V_0
    IL_0023: ldloca.s V_1
    IL_0025: call Z0.Vec128`1<System.UInt32> Z0.Bits::or(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_002A: ret

}
Vec128<ulong> rotr(Vec128<ulong> src, Vec128<ulong> offsets)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offsets
    IL_0004: call Z0.Vec128`1<System.UInt64> Z0.Bits::srlv(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0009: stloc.0
    IL_000A: ldarga.s src
    IL_000C: ldsflda Z0.Vec128`1<System.UInt64> Z0.Bits::Vec128u64
    IL_0011: ldarga.s offsets
    IL_0013: call Z0.Vec128`1<System.UInt64> Z0.dinx::sub(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0018: stloc.2
    IL_0019: ldloca.s V_2
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Bits::sllv(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0020: stloc.1
    IL_0021: ldloca.s V_0
    IL_0023: ldloca.s V_1
    IL_0025: call Z0.Vec128`1<System.UInt64> Z0.Bits::or(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_002A: ret

}
Vec256<uint> rotr(Vec256<uint> src, Vec256<uint> offsets)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offsets
    IL_0004: call Z0.Vec256`1<System.UInt32> Z0.Bits::srlv(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0009: stloc.0
    IL_000A: ldarga.s src
    IL_000C: ldsflda Z0.Vec256`1<System.UInt32> Z0.Bits::Vec256u32
    IL_0011: ldarga.s offsets
    IL_0013: call Z0.Vec256`1<System.UInt32> Z0.dinx::sub(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0018: stloc.2
    IL_0019: ldloca.s V_2
    IL_001B: call Z0.Vec256`1<System.UInt32> Z0.Bits::sllv(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0020: stloc.1
    IL_0021: ldloca.s V_0
    IL_0023: ldloca.s V_1
    IL_0025: call Z0.Vec256`1<System.UInt32> Z0.Bits::or(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_002A: ret

}
Vec256<ulong> rotr(Vec256<ulong> src, Vec256<ulong> offsets)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offsets
    IL_0004: call Z0.Vec256`1<System.UInt64> Z0.Bits::srlv(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0009: stloc.0
    IL_000A: ldarga.s src
    IL_000C: ldsflda Z0.Vec256`1<System.UInt64> Z0.Bits::Vec256u64
    IL_0011: ldarga.s offsets
    IL_0013: call Z0.Vec256`1<System.UInt64> Z0.dinx::sub(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0018: stloc.2
    IL_0019: ldloca.s V_2
    IL_001B: call Z0.Vec256`1<System.UInt64> Z0.Bits::sllv(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0020: stloc.1
    IL_0021: ldloca.s V_0
    IL_0023: ldloca.s V_1
    IL_0025: call Z0.Vec256`1<System.UInt64> Z0.Bits::or(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_002A: ret

}
Vec128<short> sll(in Vec128<short> src, Vec128<short> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: ret

}
Vec128<ushort> sll(in Vec128<ushort> src, Vec128<ushort> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: ret

}
Vec128<int> sll(in Vec128<int> src, Vec128<int> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: ret

}
Vec128<uint> sll(in Vec128<uint> src, Vec128<uint> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: ret

}
Vec128<long> sll(in Vec128<long> src, Vec128<long> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: ret

}
Vec128<ulong> sll(in Vec128<ulong> src, Vec128<ulong> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: ret

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
    IL_000A: call Z0.Vec128`1<System.UInt32> Z0.Bits::slli(Z0.Vec128`1<System.UInt32>&,System.Byte)
    IL_000F: stloc.1
    IL_0010: ldloca.s V_1
    IL_0012: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt32>::As<System.UInt64>()
    IL_0017: ret

}
Vec256<byte> slli(Vec256<byte> src, byte offset)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec128`1<System.Byte> Z0.dinx::lo(Z0.Vec256`1<System.Byte>&)
    IL_0007: stloc.s V_12
    IL_0009: ldloca.s V_12
    IL_000B: ldloca.s V_11
    IL_000D: call Z0.Vec256`1<System.UInt16>& Z0.dinx::convert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.UInt16>&)
    IL_0012: stloc.0
    IL_0013: ldarga.s src
    IL_0015: call Z0.Vec128`1<System.Byte> Z0.dinx::hi(Z0.Vec256`1<System.Byte>&)
    IL_001A: stloc.s V_14
    IL_001C: ldloca.s V_14
    IL_001E: ldloca.s V_13
    IL_0020: call Z0.Vec256`1<System.UInt16>& Z0.dinx::convert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.UInt16>&)
    IL_0025: stloc.1
    IL_0026: ldloc.0
    IL_0027: ldarg.1
    IL_0028: call Z0.Vec256`1<System.UInt16> Z0.Bits::slli(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_002D: stloc.s V_15
    IL_002F: ldloca.s V_15
    IL_0031: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.UInt16>::As<System.Byte>()
    IL_0036: stloc.2
    IL_0037: ldloc.1
    IL_0038: ldarg.1
    IL_0039: call Z0.Vec256`1<System.UInt16> Z0.Bits::slli(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_003E: stloc.s V_15
    IL_0040: ldloca.s V_15
    IL_0042: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.UInt16>::As<System.Byte>()
    IL_0047: stloc.3
    IL_0048: call Z0.Vec256`1<System.Byte>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::ClearAlt<System.Byte>()
    IL_004D: stloc.s V_4
    IL_004F: ldloca.s V_2
    IL_0051: ldloc.s V_4
    IL_0053: call Z0.Vec256`1<System.Byte> Z0.dinx::shuffle(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0058: stloc.s V_5
    IL_005A: ldloca.s V_3
    IL_005C: ldloc.s V_4
    IL_005E: call Z0.Vec256`1<System.Byte> Z0.dinx::shuffle(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0063: stloc.s V_6
    IL_0065: call Z0.Vec256`1<System.Byte>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::LaneMerge<System.Byte>()
    IL_006A: stloc.s V_7
    IL_006C: ldloca.s V_5
    IL_006E: ldloc.s V_7
    IL_0070: call Z0.Vec256`1<System.Byte> Z0.dinx::permute(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0075: stloc.s V_8
    IL_0077: ldloca.s V_6
    IL_0079: ldloc.s V_7
    IL_007B: call Z0.Vec256`1<System.Byte> Z0.dinx::permute(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0080: stloc.s V_9
    IL_0082: ldloca.s V_10
    IL_0084: initobj Z0.Vec256`1<System.Byte>
    IL_008A: ldloca.s V_8
    IL_008C: ldc.i4.0
    IL_008D: call Z0.Vec128`1<System.Byte> Z0.dinx::extract128(Z0.Vec256`1<System.Byte>&,System.Byte)
    IL_0092: stloc.s V_16
    IL_0094: ldloca.s V_16
    IL_0096: ldloca.s V_9
    IL_0098: ldc.i4.0
    IL_0099: call Z0.Vec128`1<System.Byte> Z0.dinx::extract128(Z0.Vec256`1<System.Byte>&,System.Byte)
    IL_009E: stloc.s V_17
    IL_00A0: ldloca.s V_17
    IL_00A2: ldloca.s V_10
    IL_00A4: call Z0.Vec256`1<System.Byte>& Z0.dinx::insert(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_00A9: pop
    IL_00AA: ldloc.s V_10
    IL_00AC: ret

}
Vec256<short> slli(in Vec256<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0014: ret

}
Vec256<ushort> slli(in Vec256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0014: ret

}
Vec256<int> slli(in Vec256<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0014: ret

}
Vec256<uint> slli(in Vec256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0014: ret

}
Vec256<long> slli(in Vec256<long> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0014: ret

}
Vec256<ulong> slli(in Vec256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0014: ret

}
Vec128<int> sllv(in Vec128<int> src, in Vec128<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec128<uint> sllv(in Vec128<uint> src, in Vec128<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: ret

}
Vec128<long> sllv(in Vec128<long> src, in Vec128<ulong> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: ret

}
Vec128<ulong> sllv(in Vec128<ulong> src, in Vec128<ulong> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: ret

}
Vec256<int> sllv(in Vec256<int> src, in Vec256<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: ret

}
Vec256<uint> sllv(in Vec256<uint> src, in Vec256<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: ret

}
Vec256<long> sllv(in Vec256<long> src, in Vec256<ulong> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: ret

}
Vec256<ulong> sllv(in Vec256<ulong> src, in Vec256<ulong> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: ret

}
Vec256<short> srai(in Vec256<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightArithmetic(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0014: ret

}
Vec256<int> srai(in Vec256<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightArithmetic(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0014: ret

}
Vec128<int> srav(in Vec128<int> src, in Vec128<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightArithmeticVariable(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec256<int> srav(in Vec256<int> src, in Vec256<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightArithmeticVariable(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: ret

}
Vec128<short> srl(in Vec128<short> src, Vec128<short> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: ret

}
Vec128<ushort> srl(in Vec128<ushort> src, Vec128<ushort> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: ret

}
Vec128<int> srl(in Vec128<int> src, Vec128<int> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: ret

}
uint toggle(uint src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shl
    IL_0007: xor
    IL_0008: dup
    IL_0009: starg.s src
    IL_000B: ret

}
long toggle(long src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: conv.i8
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 63
    IL_0006: and
    IL_0007: shl
    IL_0008: xor
    IL_0009: dup
    IL_000A: starg.s src
    IL_000C: ret

}
ulong toggle(ulong src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: conv.i8
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 63
    IL_0006: and
    IL_0007: shl
    IL_0008: xor
    IL_0009: dup
    IL_000A: starg.s src
    IL_000C: ret

}
float toggle(float src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32& System.Runtime.CompilerServices.Unsafe::As<System.Single,System.Int32>(System.Single&)
    IL_0007: stloc.0
    IL_0008: ldloc.0
    IL_0009: ldloc.0
    IL_000A: ldind.i4
    IL_000B: ldc.i4.1
    IL_000C: ldarg.1
    IL_000D: ldc.i4.s 31
    IL_000F: and
    IL_0010: shl
    IL_0011: xor
    IL_0012: stind.i4
    IL_0013: ldarg.0
    IL_0014: ret

}
double toggle(double src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int64& System.Runtime.CompilerServices.Unsafe::As<System.Double,System.Int64>(System.Double&)
    IL_0007: stloc.0
    IL_0008: ldloc.0
    IL_0009: ldloc.0
    IL_000A: ldind.i8
    IL_000B: ldc.i4.1
    IL_000C: conv.i8
    IL_000D: ldarg.1
    IL_000E: ldc.i4.s 63
    IL_0010: and
    IL_0011: shl
    IL_0012: xor
    IL_0013: stind.i8
    IL_0014: ldarg.0
    IL_0015: ret

}
ref sbyte toggle(ref sbyte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldc.i4.1
    IL_0004: ldarg.1
    IL_0005: ldc.i4.s 31
    IL_0007: and
    IL_0008: shl
    IL_0009: conv.i1
    IL_000A: xor
    IL_000B: conv.i1
    IL_000C: stind.i1
    IL_000D: ldarg.0
    IL_000E: ret

}
ref byte toggle(ref byte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldc.i4.1
    IL_0004: ldarg.1
    IL_0005: ldc.i4.s 31
    IL_0007: and
    IL_0008: shl
    IL_0009: conv.u1
    IL_000A: xor
    IL_000B: conv.u1
    IL_000C: stind.i1
    IL_000D: ldarg.0
    IL_000E: ret

}
ref short toggle(ref short src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldc.i4.1
    IL_0004: ldarg.1
    IL_0005: ldc.i4.s 31
    IL_0007: and
    IL_0008: shl
    IL_0009: conv.i2
    IL_000A: xor
    IL_000B: conv.i2
    IL_000C: stind.i2
    IL_000D: ldarg.0
    IL_000E: ret

}
ref ushort toggle(ref ushort src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldc.i4.1
    IL_0004: ldarg.1
    IL_0005: ldc.i4.s 31
    IL_0007: and
    IL_0008: shl
    IL_0009: conv.u2
    IL_000A: xor
    IL_000B: conv.u2
    IL_000C: stind.i2
    IL_000D: ldarg.0
    IL_000E: ret

}
ref int toggle(ref int src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldc.i4.1
    IL_0004: ldarg.1
    IL_0005: ldc.i4.s 31
    IL_0007: and
    IL_0008: shl
    IL_0009: xor
    IL_000A: stind.i4
    IL_000B: ldarg.0
    IL_000C: ret

}
ref uint toggle(ref uint src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldc.i4.1
    IL_0004: ldarg.1
    IL_0005: ldc.i4.s 31
    IL_0007: and
    IL_0008: shl
    IL_0009: xor
    IL_000A: stind.i4
    IL_000B: ldarg.0
    IL_000C: ret

}
ref long toggle(ref long src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: xor
    IL_000B: stind.i8
    IL_000C: ldarg.0
    IL_000D: ret

}
ref ulong toggle(ref ulong src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: xor
    IL_000B: stind.i8
    IL_000C: ldarg.0
    IL_000D: ret

}
ref float toggle(ref float src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32& System.Runtime.CompilerServices.Unsafe::As<System.Single,System.Int32>(System.Single&)
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: ldloc.0
    IL_0009: ldind.i4
    IL_000A: ldc.i4.1
    IL_000B: ldarg.1
    IL_000C: ldc.i4.s 31
    IL_000E: and
    IL_000F: shl
    IL_0010: xor
    IL_0011: stind.i4
    IL_0012: ldarg.0
    IL_0013: ret

}
ref double toggle(ref double src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64& System.Runtime.CompilerServices.Unsafe::As<System.Double,System.Int64>(System.Double&)
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: ldloc.0
    IL_0009: ldind.i8
    IL_000A: ldc.i4.1
    IL_000B: conv.i8
    IL_000C: ldarg.1
    IL_000D: ldc.i4.s 63
    IL_000F: and
    IL_0010: shl
    IL_0011: xor
    IL_0012: stind.i8
    IL_0013: ldarg.0
    IL_0014: ret

}
byte truncate(byte src, byte len)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ZeroHighBits(System.UInt32,System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
ushort truncate(ushort src, byte len)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ZeroHighBits(System.UInt32,System.UInt32)
    IL_0007: conv.u2
    IL_0008: ret

}
uint truncate(uint src, byte len)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ZeroHighBits(System.UInt32,System.UInt32)
    IL_0007: ret

}
ulong truncate(ulong src, byte len)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.u8
    IL_0003: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi2/X64::ZeroHighBits(System.UInt64,System.UInt64)
    IL_0008: ret

}
byte mulx(byte a, byte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::MultiplyNoFlags(System.UInt32,System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
ushort mulx(ushort a, ushort b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::MultiplyNoFlags(System.UInt32,System.UInt32)
    IL_0007: conv.u2
    IL_0008: ret

}
uint mulx(uint a, uint b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::MultiplyNoFlags(System.UInt32,System.UInt32)
    IL_0007: ret

}
ulong mulx(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi2/X64::MultiplyNoFlags(System.UInt64,System.UInt64)
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
Span<Bit> unpack(in byte src, out Span<Bit> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.8
    IL_0002: newarr Z0.Bit
    IL_0007: call System.Span`1<Z0.Bit> System.Span`1<Z0.Bit>::op_Implicit(Z0.Bit[])
    IL_000C: stobj System.Span`1<Z0.Bit>
    IL_0011: ldc.i4.0
    IL_0012: stloc.0
    IL_0013: br.s IL_0029
    IL_0015: ldarg.0
    IL_0016: ldloca.s V_0
    IL_0018: ldarg.1
    IL_0019: ldloc.0
    IL_001A: call Z0.Bit& System.Span`1<Z0.Bit>::get_Item(System.Int32)
    IL_001F: call Z0.Bit& Z0.Bits::read(System.Byte&,System.Int32&,Z0.Bit&)
    IL_0024: pop
    IL_0025: ldloc.0
    IL_0026: ldc.i4.1
    IL_0027: add
    IL_0028: stloc.0
    IL_0029: ldloc.0
    IL_002A: ldarg.1
    IL_002B: call System.Int32 System.Span`1<Z0.Bit>::get_Length()
    IL_0030: blt.s IL_0015
    IL_0032: ldarg.1
    IL_0033: ldobj System.Span`1<Z0.Bit>
    IL_0038: ret

}
Span<Bit> unpack(in ushort src, out Span<Bit> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.s 16
    IL_0003: newarr Z0.Bit
    IL_0008: call System.Span`1<Z0.Bit> System.Span`1<Z0.Bit>::op_Implicit(Z0.Bit[])
    IL_000D: stobj System.Span`1<Z0.Bit>
    IL_0012: ldc.i4.0
    IL_0013: stloc.0
    IL_0014: br.s IL_002A
    IL_0016: ldarg.0
    IL_0017: ldloca.s V_0
    IL_0019: ldarg.1
    IL_001A: ldloc.0
    IL_001B: call Z0.Bit& System.Span`1<Z0.Bit>::get_Item(System.Int32)
    IL_0020: call Z0.Bit& Z0.Bits::read(System.UInt16&,System.Int32&,Z0.Bit&)
    IL_0025: pop
    IL_0026: ldloc.0
    IL_0027: ldc.i4.1
    IL_0028: add
    IL_0029: stloc.0
    IL_002A: ldloc.0
    IL_002B: ldarg.1
    IL_002C: call System.Int32 System.Span`1<Z0.Bit>::get_Length()
    IL_0031: blt.s IL_0016
    IL_0033: ldarg.1
    IL_0034: ldobj System.Span`1<Z0.Bit>
    IL_0039: ret

}
Span<Bit> unpack(in uint src, out Span<Bit> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.s 32
    IL_0003: newarr Z0.Bit
    IL_0008: call System.Span`1<Z0.Bit> System.Span`1<Z0.Bit>::op_Implicit(Z0.Bit[])
    IL_000D: stobj System.Span`1<Z0.Bit>
    IL_0012: ldc.i4.0
    IL_0013: stloc.0
    IL_0014: br.s IL_002A
    IL_0016: ldarg.0
    IL_0017: ldloca.s V_0
    IL_0019: ldarg.1
    IL_001A: ldloc.0
    IL_001B: call Z0.Bit& System.Span`1<Z0.Bit>::get_Item(System.Int32)
    IL_0020: call Z0.Bit& Z0.Bits::read(System.UInt32&,System.Int32&,Z0.Bit&)
    IL_0025: pop
    IL_0026: ldloc.0
    IL_0027: ldc.i4.1
    IL_0028: add
    IL_0029: stloc.0
    IL_002A: ldloc.0
    IL_002B: ldarg.1
    IL_002C: call System.Int32 System.Span`1<Z0.Bit>::get_Length()
    IL_0031: blt.s IL_0016
    IL_0033: ldarg.1
    IL_0034: ldobj System.Span`1<Z0.Bit>
    IL_0039: ret

}
Span<Bit> unpack(in ulong src, out Span<Bit> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.s 64
    IL_0003: newarr Z0.Bit
    IL_0008: call System.Span`1<Z0.Bit> System.Span`1<Z0.Bit>::op_Implicit(Z0.Bit[])
    IL_000D: stobj System.Span`1<Z0.Bit>
    IL_0012: ldc.i4.0
    IL_0013: stloc.0
    IL_0014: br.s IL_002A
    IL_0016: ldarg.0
    IL_0017: ldloca.s V_0
    IL_0019: ldarg.1
    IL_001A: ldloc.0
    IL_001B: call Z0.Bit& System.Span`1<Z0.Bit>::get_Item(System.Int32)
    IL_0020: call Z0.Bit& Z0.Bits::read(System.UInt64&,System.Int32&,Z0.Bit&)
    IL_0025: pop
    IL_0026: ldloc.0
    IL_0027: ldc.i4.1
    IL_0028: add
    IL_0029: stloc.0
    IL_002A: ldloc.0
    IL_002B: ldarg.1
    IL_002C: call System.Int32 System.Span`1<Z0.Bit>::get_Length()
    IL_0031: blt.s IL_0016
    IL_0033: ldarg.1
    IL_0034: ldobj System.Span`1<Z0.Bit>
    IL_0039: ret

}
BitSize width(in byte src)
{
    IL_0000: ldc.i4.8
    IL_0001: ldarg.0
    IL_0002: call System.Byte Z0.Bits::nlz(System.Byte&)
    IL_0007: sub
    IL_0008: call Z0.BitSize Z0.BitSize::op_Implicit(System.Int32)
    IL_000D: ret

}
BitSize width(in ushort src)
{
    IL_0000: ldc.i4.s 16
    IL_0002: ldarg.0
    IL_0003: call System.Byte Z0.Bits::nlz(System.UInt16&)
    IL_0008: sub
    IL_0009: call Z0.BitSize Z0.BitSize::op_Implicit(System.Int32)
    IL_000E: ret

}
BitSize width(in uint src)
{
    IL_0000: ldc.i4.s 32
    IL_0002: ldarg.0
    IL_0003: call System.Byte Z0.Bits::nlz(System.UInt32&)
    IL_0008: sub
    IL_0009: call Z0.BitSize Z0.BitSize::op_Implicit(System.Int32)
    IL_000E: ret

}
BitSize width(in ulong src)
{
    IL_0000: ldc.i4.s 64
    IL_0002: ldarg.0
    IL_0003: call System.Byte Z0.Bits::nlz(System.UInt64&)
    IL_0008: sub
    IL_0009: call Z0.BitSize Z0.BitSize::op_Implicit(System.Int32)
    IL_000E: ret

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
    IL_001C: call Z0.Vec128`1<System.UInt64> Z0.Bits::and(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
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
    IL_001D: call Z0.Vec128`1<System.UInt64> Z0.Bits::and(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
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
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: ret

}
Vec256<short> and(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: ret

}
Vec256<sbyte> and(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: ret

}
Vec256<ushort> and(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: ret

}
Vec256<int> and(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: ret

}
Vec256<uint> and(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: ret

}
Vec256<long> and(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: ret

}
Vec256<ulong> and(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: ret

}
Vec256<float> and(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::And(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: ret

}
Vec256<double> and(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::And(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: ret

}
Vec128<sbyte> andnot(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<byte> andnot(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<short> andnot(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<ushort> andnot(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec128<int> andnot(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec128<uint> andnot(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: ret

}
Vec128<long> andnot(in Vec128<long> lhs, in Vec128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: ret

}
Vec128<ulong> andnot(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: ret

}
Vec128<float> andnot(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> andnot(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

}
Vec256<sbyte> andnot(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: ret

}
Vec256<byte> andnot(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: ret

}
Vec256<short> andnot(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: ret

}
Vec256<ushort> andnot(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: ret

}
Vec256<int> andnot(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: ret

}
Vec256<uint> andnot(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: ret

}
Vec256<long> andnot(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: ret

}
Vec256<ulong> andnot(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: ret

}
Vec256<float> andnot(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: ret

}
Vec256<double> andnot(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: ret

}
byte between(in byte src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u1
    IL_0002: ldarg.1
    IL_0003: call System.Byte Z0.BitPos::op_Implicit(Z0.BitPos)
    IL_0008: ldarga.s i1
    IL_000A: ldarga.s i0
    IL_000C: call Z0.BitSize Z0.BitPos::op_Subtraction(Z0.BitPos&,Z0.BitPos&)
    IL_0011: call System.Byte Z0.BitSize::op_Explicit(Z0.BitSize)
    IL_0016: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_001B: conv.u1
    IL_001C: ret

}
ushort between(in ushort src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u2
    IL_0002: ldarg.1
    IL_0003: call System.Byte Z0.BitPos::op_Implicit(Z0.BitPos)
    IL_0008: ldarga.s i1
    IL_000A: ldarga.s i0
    IL_000C: call Z0.BitSize Z0.BitPos::op_Subtraction(Z0.BitPos&,Z0.BitPos&)
    IL_0011: call System.Byte Z0.BitSize::op_Explicit(Z0.BitSize)
    IL_0016: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_001B: conv.u2
    IL_001C: ret

}
uint between(in uint src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u4
    IL_0002: ldarg.1
    IL_0003: call System.Byte Z0.BitPos::op_Implicit(Z0.BitPos)
    IL_0008: ldarga.s i1
    IL_000A: ldarga.s i0
    IL_000C: call Z0.BitSize Z0.BitPos::op_Subtraction(Z0.BitPos&,Z0.BitPos&)
    IL_0011: call System.Byte Z0.BitSize::op_Explicit(Z0.BitSize)
    IL_0016: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_001B: ret

}
ulong between(in ulong src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: ldarg.1
    IL_0003: call System.Byte Z0.BitPos::op_Implicit(Z0.BitPos)
    IL_0008: ldarga.s i1
    IL_000A: ldarga.s i0
    IL_000C: call Z0.BitSize Z0.BitPos::op_Subtraction(Z0.BitPos&,Z0.BitPos&)
    IL_0011: call System.Byte Z0.BitSize::op_Explicit(Z0.BitSize)
    IL_0016: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::BitFieldExtract(System.UInt64,System.Byte,System.Byte)
    IL_001B: ret

}
UInt128 bslli(UInt128 src, byte bytes)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.UInt128::op_Implicit(Z0.UInt128&)
    IL_0007: ldarg.1
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_000D: stloc.0
    IL_000E: ldloca.s V_0
    IL_0010: call Z0.UInt128 Z0.UInt128X::ToUInt128(System.Runtime.Intrinsics.Vector128`1<System.UInt64>&)
    IL_0015: ret

}
Vec128<short> bslli(in Vec128<short> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> bslli(in Vec128<ushort> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> bslli(in Vec128<int> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> bslli(in Vec128<uint> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> bslli(in Vec128<long> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> bslli(in Vec128<ulong> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<short> bslli(in Vec256<short> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0014: ret

}
Vec256<ushort> bslli(in Vec256<ushort> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0014: ret

}
Vec256<int> bslli(in Vec256<int> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0014: ret

}
Vec256<uint> bslli(in Vec256<uint> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0014: ret

}
Vec256<long> bslli(in Vec256<long> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0014: ret

}
Vec256<ulong> bslli(in Vec256<ulong> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0014: ret

}
Vec128<short> bsrli(in Vec128<short> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> bsrli(in Vec128<ushort> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> bsrli(in Vec128<int> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> bsrli(in Vec128<uint> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> bsrli(in Vec128<long> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> bsrli(in Vec128<ulong> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<short> bsrli(in Vec256<short> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0014: ret

}
Vec256<ushort> bsrli(in Vec256<ushort> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0014: ret

}
Vec256<int> bsrli(in Vec256<int> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0014: ret

}
Vec256<uint> bsrli(in Vec256<uint> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0014: ret

}
Vec256<long> bsrli(in Vec256<long> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0014: ret

}
Vec256<ulong> bsrli(in Vec256<ulong> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0014: ret

}
int movemask(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: call Z0.Vec128`1<System.UInt64>& Z0.Vec128::LoadScalar<System.UInt64>(System.UInt64,Z0.Vec128`1<System.UInt64>&)
    IL_0008: pop
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.UInt64>::As<System.Byte>()
    IL_0010: stloc.1
    IL_0011: ldloca.s V_1
    IL_0013: call System.Int32 Z0.Bits::movemask(Z0.Vec128`1<System.Byte>&)
    IL_0018: ret

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
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: call System.Int32 System.Runtime.Intrinsics.X86.Avx2::MoveMask(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_000B: ret

}
int movemask(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: call System.Int32 System.Runtime.Intrinsics.X86.Avx2::MoveMask(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_000B: ret

}
int movemask(in Vec256<float> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: call System.Int32 System.Runtime.Intrinsics.X86.Avx::MoveMask(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_000B: ret

}
int movemask(in Vec256<double> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: call System.Int32 System.Runtime.Intrinsics.X86.Avx::MoveMask(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_000B: ret

}
ulong ntz(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::TrailingZeroCount(System.UInt32)
    IL_0006: conv.u8
    IL_0007: ret

}
ulong ntz(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::TrailingZeroCount(System.UInt32)
    IL_0006: conv.u8
    IL_0007: ret

}
ulong ntz(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::TrailingZeroCount(System.UInt32)
    IL_0006: conv.u8
    IL_0007: ret

}
ulong ntz(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::TrailingZeroCount(System.UInt32)
    IL_0006: conv.u8
    IL_0007: ret

}
ulong ntz(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::TrailingZeroCount(System.UInt32)
    IL_0006: conv.u8
    IL_0007: ret

}
ulong ntz(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::TrailingZeroCount(System.UInt32)
    IL_0006: conv.u8
    IL_0007: ret

}
ulong ntz(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::TrailingZeroCount(System.UInt64)
    IL_0006: ret

}
ulong ntz(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::TrailingZeroCount(System.UInt64)
    IL_0006: ret

}
UInt128 or(in UInt128 lhs, in UInt128 rhs)
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
    IL_001C: call Z0.Vec128`1<System.UInt64> Z0.Bits::or(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0021: stloc.2
    IL_0022: ldloca.s V_2
    IL_0024: call Z0.UInt128 Z0.UInt128X::ToUInt128(Z0.Vec128`1<System.UInt64>&)
    IL_0029: ret

}
ref UInt128 or(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
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
    IL_001D: call Z0.Vec128`1<System.UInt64> Z0.Bits::or(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0022: stloc.2
    IL_0023: ldloca.s V_2
    IL_0025: call Z0.UInt128 Z0.UInt128X::ToUInt128(Z0.Vec128`1<System.UInt64>&)
    IL_002A: stobj Z0.UInt128
    IL_002F: ldarg.2
    IL_0030: ret

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
double log2(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Log2(System.Double)
    IL_0006: ret

}
byte lopos(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::ExtractLowestSetBit(System.UInt32)
    IL_0006: conv.u1
    IL_0007: call System.Byte Z0.Pow2`1<System.Byte>::inv(System.Byte)
    IL_000C: ret

}
ushort lopos(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::ExtractLowestSetBit(System.UInt32)
    IL_0006: conv.u2
    IL_0007: call System.Byte Z0.Pow2`1<System.UInt16>::inv(System.UInt16)
    IL_000C: ret

}
uint lopos(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::ExtractLowestSetBit(System.UInt32)
    IL_0006: call System.Byte Z0.Pow2`1<System.UInt32>::inv(System.UInt32)
    IL_000B: ret

}
ulong lopos(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::ExtractLowestSetBit(System.UInt64)
    IL_0006: call System.Byte Z0.Pow2`1<System.UInt64>::inv(System.UInt64)
    IL_000B: conv.u8
    IL_000C: ret

}
ref ulong mask(ref ulong dst, Byte[] indices)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0015
    IL_0004: ldarg.0
    IL_0005: ldarg.0
    IL_0006: ldind.i8
    IL_0007: ldarg.1
    IL_0008: ldloc.0
    IL_0009: ldelem.u1
    IL_000A: call System.UInt64 Z0.Pow2::pow(System.Byte)
    IL_000F: or
    IL_0010: stind.i8
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: ldarg.1
    IL_0017: ldlen
    IL_0018: conv.i4
    IL_0019: blt.s IL_0004
    IL_001B: ldarg.0
    IL_001C: ret

}
ref ulong mask(ref ulong dst, byte i0)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: call System.UInt64 Z0.Pow2::pow(System.Byte)
    IL_0009: or
    IL_000A: stind.i8
    IL_000B: ldarg.0
    IL_000C: ret

}
ref ulong mask(ref ulong dst, byte i0, byte i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: call System.UInt64 Z0.Pow2`1<System.UInt64>::pow(System.Byte)
    IL_0009: or
    IL_000A: stind.i8
    IL_000B: ldarg.0
    IL_000C: ldarg.0
    IL_000D: ldind.i8
    IL_000E: ldarg.2
    IL_000F: call System.UInt64 Z0.Pow2`1<System.UInt64>::pow(System.Byte)
    IL_0014: or
    IL_0015: stind.i8
    IL_0016: ldarg.0
    IL_0017: ret

}
ref ulong mask(ref ulong dst, byte i0, byte i1, byte i2)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Byte,System.Byte)
    IL_0008: pop
    IL_0009: ldarg.0
    IL_000A: ldarg.3
    IL_000B: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Byte)
    IL_0010: pop
    IL_0011: ldarg.0
    IL_0012: ret

}
ref ulong mask(ref ulong dst, byte i0, byte i1, byte i2, byte i3)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Byte,System.Byte)
    IL_0008: pop
    IL_0009: ldarg.0
    IL_000A: ldarg.3
    IL_000B: ldarg.s i3
    IL_000D: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Byte,System.Byte)
    IL_0012: pop
    IL_0013: ldarg.0
    IL_0014: ret

}
byte nlz(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Lzcnt::LeadingZeroCount(System.UInt32)
    IL_0007: ldc.i4.s 24
    IL_0009: sub
    IL_000A: conv.u1
    IL_000B: ret

}
byte nlz(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u2
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Lzcnt::LeadingZeroCount(System.UInt32)
    IL_0007: ldc.i4.s 16
    IL_0009: sub
    IL_000A: conv.u1
    IL_000B: ret

}
byte nlz(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u4
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Lzcnt::LeadingZeroCount(System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
byte nlz(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: call System.UInt64 System.Runtime.Intrinsics.X86.Lzcnt/X64::LeadingZeroCount(System.UInt64)
    IL_0007: conv.u1
    IL_0008: ret

}
ushort pack(byte x0, byte x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.8
    IL_0003: shl
    IL_0004: or
    IL_0005: conv.u2
    IL_0006: ret

}
uint pack(ushort x0, ushort x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 16
    IL_0004: shl
    IL_0005: or
    IL_0006: ret

}
ulong pack(in uint x0, in uint x1)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u4
    IL_0002: conv.u8
    IL_0003: ldarg.1
    IL_0004: ldind.u4
    IL_0005: conv.u8
    IL_0006: ldc.i4.s 32
    IL_0008: shl
    IL_0009: or
    IL_000A: ret

}
uint pack(byte x0, byte x1, byte x2, byte x3)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.8
    IL_0003: shl
    IL_0004: or
    IL_0005: ldarg.2
    IL_0006: ldc.i4.s 16
    IL_0008: shl
    IL_0009: or
    IL_000A: ldarg.3
    IL_000B: ldc.i4.s 24
    IL_000D: shl
    IL_000E: or
    IL_000F: ret

}
ulong pack(ushort x0, ushort x1, ushort x2, ushort x3)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: ldarg.1
    IL_0003: conv.u8
    IL_0004: ldc.i4.s 16
    IL_0006: shl
    IL_0007: or
    IL_0008: ldarg.1
    IL_0009: conv.u8
    IL_000A: ldc.i4.s 32
    IL_000C: shl
    IL_000D: or
    IL_000E: ldarg.1
    IL_000F: conv.u8
    IL_0010: ldc.i4.s 48
    IL_0012: shl
    IL_0013: or
    IL_0014: ret

}
ulong pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: ldarg.1
    IL_0003: conv.u8
    IL_0004: ldc.i4.8
    IL_0005: shl
    IL_0006: or
    IL_0007: ldarg.2
    IL_0008: conv.u8
    IL_0009: ldc.i4.s 16
    IL_000B: shl
    IL_000C: or
    IL_000D: ldarg.3
    IL_000E: conv.u8
    IL_000F: ldc.i4.s 24
    IL_0011: shl
    IL_0012: or
    IL_0013: ldarg.s x4
    IL_0015: conv.u8
    IL_0016: ldc.i4.s 32
    IL_0018: shl
    IL_0019: or
    IL_001A: ldarg.s x5
    IL_001C: conv.u8
    IL_001D: ldc.i4.s 40
    IL_001F: shl
    IL_0020: or
    IL_0021: ldarg.s x6
    IL_0023: conv.u8
    IL_0024: ldc.i4.s 48
    IL_0026: shl
    IL_0027: or
    IL_0028: ldarg.s x7
    IL_002A: conv.u8
    IL_002B: ldc.i4.s 56
    IL_002D: shl
    IL_002E: or
    IL_002F: ret

}
ref byte pack(in byte x0, in byte x1, in byte x2, in byte x3, in byte x4, in byte x5, in byte x6, in byte x7, in byte pos, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.s pos
    IL_0003: ldind.u1
    IL_0004: call System.Boolean Z0.BitMask::test(System.Byte&,System.Byte)
    IL_0009: brfalse.s IL_0017
    IL_000B: ldarg.s dst
    IL_000D: ldc.i4.0
    IL_000E: stloc.0
    IL_000F: ldloca.s V_0
    IL_0011: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32&)
    IL_0016: pop
    IL_0017: ldarg.1
    IL_0018: ldarg.s pos
    IL_001A: ldind.u1
    IL_001B: call System.Boolean Z0.BitMask::test(System.Byte&,System.Byte)
    IL_0020: brfalse.s IL_002E
    IL_0022: ldarg.s dst
    IL_0024: ldc.i4.1
    IL_0025: stloc.0
    IL_0026: ldloca.s V_0
    IL_0028: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32&)
    IL_002D: pop
    IL_002E: ldarg.2
    IL_002F: ldarg.s pos
    IL_0031: ldind.u1
    IL_0032: call System.Boolean Z0.BitMask::test(System.Byte&,System.Byte)
    IL_0037: brfalse.s IL_0045
    IL_0039: ldarg.s dst
    IL_003B: ldc.i4.2
    IL_003C: stloc.0
    IL_003D: ldloca.s V_0
    IL_003F: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32&)
    IL_0044: pop
    IL_0045: ldarg.3
    IL_0046: ldarg.s pos
    IL_0048: ldind.u1
    IL_0049: call System.Boolean Z0.BitMask::test(System.Byte&,System.Byte)
    IL_004E: brfalse.s IL_005C
    IL_0050: ldarg.s dst
    IL_0052: ldc.i4.3
    IL_0053: stloc.0
    IL_0054: ldloca.s V_0
    IL_0056: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32&)
    IL_005B: pop
    IL_005C: ldarg.s x4
    IL_005E: ldarg.s pos
    IL_0060: ldind.u1
    IL_0061: call System.Boolean Z0.BitMask::test(System.Byte&,System.Byte)
    IL_0066: brfalse.s IL_0074
    IL_0068: ldarg.s dst
    IL_006A: ldc.i4.4
    IL_006B: stloc.0
    IL_006C: ldloca.s V_0
    IL_006E: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32&)
    IL_0073: pop
    IL_0074: ldarg.s x5
    IL_0076: ldarg.s pos
    IL_0078: ldind.u1
    IL_0079: call System.Boolean Z0.BitMask::test(System.Byte&,System.Byte)
    IL_007E: brfalse.s IL_008C
    IL_0080: ldarg.s dst
    IL_0082: ldc.i4.5
    IL_0083: stloc.0
    IL_0084: ldloca.s V_0
    IL_0086: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32&)
    IL_008B: pop
    IL_008C: ldarg.s x6
    IL_008E: ldarg.s pos
    IL_0090: ldind.u1
    IL_0091: call System.Boolean Z0.BitMask::test(System.Byte&,System.Byte)
    IL_0096: brfalse.s IL_00A4
    IL_0098: ldarg.s dst
    IL_009A: ldc.i4.6
    IL_009B: stloc.0
    IL_009C: ldloca.s V_0
    IL_009E: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32&)
    IL_00A3: pop
    IL_00A4: ldarg.s x7
    IL_00A6: ldarg.s pos
    IL_00A8: ldind.u1
    IL_00A9: call System.Boolean Z0.BitMask::test(System.Byte&,System.Byte)
    IL_00AE: brfalse.s IL_00BC
    IL_00B0: ldarg.s dst
    IL_00B2: ldc.i4.7
    IL_00B3: stloc.0
    IL_00B4: ldloca.s V_0
    IL_00B6: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32&)
    IL_00BB: pop
    IL_00BC: ldarg.s dst
    IL_00BE: ret

}
Span<byte> pack(ReadOnlySpan<Bit> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.ReadOnlySpan`1<Z0.Bit>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldloc.0
    IL_0009: ldc.i4.3
    IL_000A: shr
    IL_000B: stloc.1
    IL_000C: ldloc.0
    IL_000D: ldc.i4.7
    IL_000E: and
    IL_000F: brfalse.s IL_0015
    IL_0011: ldloc.1
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.1
    IL_0015: ldarg.0
    IL_0016: ldloc.1
    IL_0017: newarr System.Byte
    IL_001C: call System.Span`1<System.Byte> System.Span`1<System.Byte>::op_Implicit(System.Byte[])
    IL_0021: call System.Span`1<System.Byte> Z0.Bits::pack(System.ReadOnlySpan`1<Z0.Bit>,System.Span`1<System.Byte>)
    IL_0026: ret

}
Span<byte> pack(ReadOnlySpan<Bit> src, Span<byte> dst)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.ReadOnlySpan`1<Z0.Bit>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_003C
    IL_000C: ldarga.s src
    IL_000E: ldloc.1
    IL_000F: call Z0.Bit& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<Z0.Bit>::get_Item(System.Int32)
    IL_0014: ldobj Z0.Bit
    IL_0019: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_001E: brfalse.s IL_0038
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: ldc.i4.3
    IL_0024: shr
    IL_0025: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_002A: dup
    IL_002B: ldind.u1
    IL_002C: ldc.i4.1
    IL_002D: ldloc.1
    IL_002E: ldc.i4.7
    IL_002F: and
    IL_0030: ldc.i4.s 31
    IL_0032: and
    IL_0033: shl
    IL_0034: conv.u1
    IL_0035: or
    IL_0036: conv.u1
    IL_0037: stind.i1
    IL_0038: ldloc.1
    IL_0039: ldc.i4.1
    IL_003A: add
    IL_003B: stloc.1
    IL_003C: ldloc.1
    IL_003D: ldloc.0
    IL_003E: blt.s IL_000C
    IL_0040: ldarg.1
    IL_0041: ret

}
Span<byte> pack(Boolean[] src)
{
    IL_0000: ldarg.0
    IL_0001: ldlen
    IL_0002: conv.i4
    IL_0003: stloc.0
    IL_0004: ldloc.0
    IL_0005: ldc.i4.3
    IL_0006: shr
    IL_0007: stloc.1
    IL_0008: ldloc.0
    IL_0009: ldc.i4.7
    IL_000A: and
    IL_000B: brfalse.s IL_0011
    IL_000D: ldloc.1
    IL_000E: ldc.i4.1
    IL_000F: add
    IL_0010: stloc.1
    IL_0011: ldloc.1
    IL_0012: newarr System.Byte
    IL_0017: call System.Span`1<System.Byte> System.Span`1<System.Byte>::op_Implicit(System.Byte[])
    IL_001C: stloc.2
    IL_001D: ldc.i4.0
    IL_001E: stloc.3
    IL_001F: br.s IL_0042
    IL_0021: ldarg.0
    IL_0022: ldloc.3
    IL_0023: ldelem.u1
    IL_0024: brfalse.s IL_003E
    IL_0026: ldloca.s V_2
    IL_0028: ldloc.3
    IL_0029: ldc.i4.3
    IL_002A: shr
    IL_002B: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0030: dup
    IL_0031: ldind.u1
    IL_0032: ldc.i4.1
    IL_0033: ldloc.3
    IL_0034: ldc.i4.7
    IL_0035: and
    IL_0036: ldc.i4.s 31
    IL_0038: and
    IL_0039: shl
    IL_003A: conv.u1
    IL_003B: or
    IL_003C: conv.u1
    IL_003D: stind.i1
    IL_003E: ldloc.3
    IL_003F: ldc.i4.1
    IL_0040: add
    IL_0041: stloc.3
    IL_0042: ldloc.3
    IL_0043: ldloc.0
    IL_0044: blt.s IL_0021
    IL_0046: ldloc.2
    IL_0047: ret

}
ref Bit read(in sbyte src, in int pos, out Bit dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.Bits::test(System.SByte&,System.Int32&)
    IL_0008: call Z0.Bit Z0.Bit::op_Implicit(System.Boolean)
    IL_000D: stobj Z0.Bit
    IL_0012: ldarg.2
    IL_0013: ret

}
ref Bit read(in byte src, in int pos, out Bit dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.Bits::test(System.Byte&,System.Int32&)
    IL_0008: call Z0.Bit Z0.Bit::op_Implicit(System.Boolean)
    IL_000D: stobj Z0.Bit
    IL_0012: ldarg.2
    IL_0013: ret

}
ref Bit read(in short src, in int pos, out Bit dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.Bits::test(System.Int16&,System.Int32&)
    IL_0008: call Z0.Bit Z0.Bit::op_Implicit(System.Boolean)
    IL_000D: stobj Z0.Bit
    IL_0012: ldarg.2
    IL_0013: ret

}
ref Bit read(in ushort src, in int pos, out Bit dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.Bits::test(System.UInt16&,System.Int32&)
    IL_0008: call Z0.Bit Z0.Bit::op_Implicit(System.Boolean)
    IL_000D: stobj Z0.Bit
    IL_0012: ldarg.2
    IL_0013: ret

}
ref Bit read(in int src, in int pos, out Bit dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.Bits::test(System.Int32&,System.Int32&)
    IL_0008: call Z0.Bit Z0.Bit::op_Implicit(System.Boolean)
    IL_000D: stobj Z0.Bit
    IL_0012: ldarg.2
    IL_0013: ret

}
ref Bit read(in uint src, in int pos, out Bit dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.Bits::test(System.UInt32&,System.Int32&)
    IL_0008: call Z0.Bit Z0.Bit::op_Implicit(System.Boolean)
    IL_000D: stobj Z0.Bit
    IL_0012: ldarg.2
    IL_0013: ret

}
ref Bit read(in long src, in int pos, out Bit dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.Bits::test(System.Int64&,System.Int32&)
    IL_0008: call Z0.Bit Z0.Bit::op_Implicit(System.Boolean)
    IL_000D: stobj Z0.Bit
    IL_0012: ldarg.2
    IL_0013: ret

}
ref Bit read(in ulong src, in int pos, out Bit dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.Bits::test(System.UInt64&,System.Int32&)
    IL_0008: call Z0.Bit Z0.Bit::op_Implicit(System.Boolean)
    IL_000D: stobj Z0.Bit
    IL_0012: ldarg.2
    IL_0013: ret

}
byte rev(byte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: ldc.i4 -2145384446
    IL_0007: conv.u8
    IL_0008: mul
    IL_0009: ldc.i8 36578664720
    IL_0012: and
    IL_0013: ldc.i8 4311810305
    IL_001C: mul
    IL_001D: ldc.i4.s 32
    IL_001F: shr.un
    IL_0020: conv.u1
    IL_0021: ret

}
ushort rev(ushort src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Byte Z0.Bits::hi(System.UInt16&)
    IL_0007: call System.Byte Z0.Bits::rev(System.Byte)
    IL_000C: ldarga.s src
    IL_000E: call System.Byte Z0.Bits::lo(System.UInt16&)
    IL_0013: call System.Byte Z0.Bits::rev(System.Byte)
    IL_0018: call System.UInt16 Z0.Bits::pack(System.Byte,System.Byte)
    IL_001D: ret

}
uint rev(uint src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt16 Z0.Bits::hi(System.UInt32&)
    IL_0007: call System.UInt16 Z0.Bits::rev(System.UInt16)
    IL_000C: ldarga.s src
    IL_000E: call System.UInt16 Z0.Bits::lo(System.UInt32&)
    IL_0013: call System.UInt16 Z0.Bits::rev(System.UInt16)
    IL_0018: call System.UInt32 Z0.Bits::pack(System.UInt16,System.UInt16)
    IL_001D: ret

}
ulong rev(ulong src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt32 Z0.Bits::hi(System.UInt64&)
    IL_0007: call System.UInt32 Z0.Bits::rev(System.UInt32)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: ldarga.s src
    IL_0011: call System.UInt32 Z0.Bits::lo(System.UInt64&)
    IL_0016: call System.UInt32 Z0.Bits::rev(System.UInt32)
    IL_001B: stloc.1
    IL_001C: ldloca.s V_1
    IL_001E: call System.UInt64 Z0.Bits::pack(System.UInt32&,System.UInt32&)
    IL_0023: ret

}
byte rotl(byte src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: ldarg.0
    IL_0007: ldc.i4.8
    IL_0008: ldarg.1
    IL_0009: sub
    IL_000A: ldc.i4.s 31
    IL_000C: and
    IL_000D: shr
    IL_000E: or
    IL_000F: conv.u1
    IL_0010: ret

}
ushort rotl(ushort src, ushort offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 16
    IL_0009: ldarg.1
    IL_000A: sub
    IL_000B: ldc.i4.s 31
    IL_000D: and
    IL_000E: shr
    IL_000F: or
    IL_0010: conv.u2
    IL_0011: ret

}
uint rotl(uint src, uint offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 32
    IL_0009: ldarg.1
    IL_000A: sub
    IL_000B: ldc.i4.s 31
    IL_000D: and
    IL_000E: shr.un
    IL_000F: or
    IL_0010: ret

}
ulong rotl(ulong src, ulong offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.i4
    IL_0003: ldc.i4.s 63
    IL_0005: and
    IL_0006: shl
    IL_0007: ldarg.0
    IL_0008: ldc.i4.s 64
    IL_000A: ldarg.1
    IL_000B: conv.i4
    IL_000C: sub
    IL_000D: ldc.i4.s 63
    IL_000F: and
    IL_0010: shr.un
    IL_0011: or
    IL_0012: ret

}
ref byte rotl(ref byte src, in byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldind.u1
    IL_0005: call System.Byte Z0.Bits::rotl(System.Byte,System.Byte)
    IL_000A: stind.i1
    IL_000B: ldarg.0
    IL_000C: ret

}
ref ushort rotl(ref ushort src, in ushort offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldind.u2
    IL_0005: call System.UInt16 Z0.Bits::rotl(System.UInt16,System.UInt16)
    IL_000A: stind.i2
    IL_000B: ldarg.0
    IL_000C: ret

}
ref uint rotl(ref uint src, in uint offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldind.u4
    IL_0005: call System.UInt32 Z0.Bits::rotl(System.UInt32,System.UInt32)
    IL_000A: stind.i4
    IL_000B: ldarg.0
    IL_000C: ret

}
ref ulong rotl(ref ulong src, in ulong offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: call System.UInt64 Z0.Bits::rotl(System.UInt64,System.UInt64)
    IL_000A: stind.i8
    IL_000B: ldarg.0
    IL_000C: ret

}
byte rotr(byte src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr
    IL_0006: ldarg.0
    IL_0007: ldc.i4.8
    IL_0008: ldarg.1
    IL_0009: sub
    IL_000A: ldc.i4.s 31
    IL_000C: and
    IL_000D: shl
    IL_000E: or
    IL_000F: conv.u1
    IL_0010: ret

}
ushort rotr(ushort src, ushort offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 16
    IL_0009: ldarg.1
    IL_000A: sub
    IL_000B: ldc.i4.s 31
    IL_000D: and
    IL_000E: shl
    IL_000F: or
    IL_0010: conv.u2
    IL_0011: ret

}
uint rotr(uint src, uint offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr.un
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 32
    IL_0009: ldarg.1
    IL_000A: sub
    IL_000B: ldc.i4.s 31
    IL_000D: and
    IL_000E: shl
    IL_000F: or
    IL_0010: ret

}
ulong rotr(ulong src, ulong offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.i4
    IL_0003: ldc.i4.s 63
    IL_0005: and
    IL_0006: shr.un
    IL_0007: ldarg.0
    IL_0008: ldc.i4.s 64
    IL_000A: ldarg.1
    IL_000B: conv.i4
    IL_000C: sub
    IL_000D: ldc.i4.s 63
    IL_000F: and
    IL_0010: shl
    IL_0011: or
    IL_0012: ret

}
ref byte rotr(ref byte src, in byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldind.u1
    IL_0005: call System.Byte Z0.Bits::rotr(System.Byte,System.Byte)
    IL_000A: stind.i1
    IL_000B: ldarg.0
    IL_000C: ret

}
ref ushort rotr(ref ushort src, in ushort offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldind.u2
    IL_0005: call System.UInt16 Z0.Bits::rotr(System.UInt16,System.UInt16)
    IL_000A: stind.i2
    IL_000B: ldarg.0
    IL_000C: ret

}
ref uint rotr(ref uint src, in uint offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldind.u4
    IL_0005: call System.UInt32 Z0.Bits::rotr(System.UInt32,System.UInt32)
    IL_000A: stind.i4
    IL_000B: ldarg.0
    IL_000C: ret

}
ref ulong rotr(ref ulong src, in ulong offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: call System.UInt64 Z0.Bits::rotr(System.UInt64,System.UInt64)
    IL_000A: stind.i8
    IL_000B: ldarg.0
    IL_000C: ret

}
ValueTuple<sbyte,sbyte> split(short src, N2 parts)
{
    IL_0000: ldarga.s src
    IL_0002: call System.SByte Z0.Bits::lo(System.Int16&)
    IL_0007: ldarga.s src
    IL_0009: call System.SByte Z0.Bits::hi(System.Int16&)
    IL_000E: newobj System.Void System.ValueTuple`2<System.SByte,System.SByte>::.ctor(System.SByte,System.SByte)
    IL_0013: ret

}
ValueTuple<byte,byte> split(ushort src, N2 parts)
{
    IL_0000: ldarg.0
    IL_0001: conv.u1
    IL_0002: ldarg.0
    IL_0003: ldc.i4.8
    IL_0004: shr
    IL_0005: conv.u1
    IL_0006: newobj System.Void System.ValueTuple`2<System.Byte,System.Byte>::.ctor(System.Byte,System.Byte)
    IL_000B: ret

}
ValueTuple<short,short> split(int src, N2 parts)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int16 Z0.Bits::lo(System.Int32&)
    IL_0007: ldarga.s src
    IL_0009: call System.Int16 Z0.Bits::hi(System.Int32&)
    IL_000E: newobj System.Void System.ValueTuple`2<System.Int16,System.Int16>::.ctor(System.Int16,System.Int16)
    IL_0013: ret

}
ValueTuple<ushort,ushort> split(uint src, N2 parts)
{
    IL_0000: ldarg.0
    IL_0001: conv.u2
    IL_0002: ldarg.0
    IL_0003: ldc.i4.s 16
    IL_0005: shr.un
    IL_0006: conv.u2
    IL_0007: newobj System.Void System.ValueTuple`2<System.UInt16,System.UInt16>::.ctor(System.UInt16,System.UInt16)
    IL_000C: ret

}
ValueTuple<int,int> split(long src, N2 parts)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 Z0.Bits::lo(System.Int64&)
    IL_0007: ldarga.s src
    IL_0009: call System.Int32 Z0.Bits::hi(System.Int64&)
    IL_000E: newobj System.Void System.ValueTuple`2<System.Int32,System.Int32>::.ctor(System.Int32,System.Int32)
    IL_0013: ret

}
ValueTuple<uint,uint> split(ulong src, N2 parts)
{
    IL_0000: ldarg.0
    IL_0001: conv.u4
    IL_0002: ldarg.0
    IL_0003: ldc.i4.s 32
    IL_0005: shr.un
    IL_0006: conv.u4
    IL_0007: newobj System.Void System.ValueTuple`2<System.UInt32,System.UInt32>::.ctor(System.UInt32,System.UInt32)
    IL_000C: ret

}
ValueTuple<byte,byte,byte,byte> split(uint src, N4 parts)
{
    IL_0000: ldarg.0
    IL_0001: conv.u1
    IL_0002: ldarg.0
    IL_0003: ldc.i4.8
    IL_0004: shr.un
    IL_0005: conv.u1
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 16
    IL_0009: shr.un
    IL_000A: conv.u1
    IL_000B: ldarg.0
    IL_000C: ldc.i4.s 24
    IL_000E: shr.un
    IL_000F: conv.u1
    IL_0010: newobj System.Void System.ValueTuple`4<System.Byte,System.Byte,System.Byte,System.Byte>::.ctor(System.Byte,System.Byte,System.Byte,System.Byte)
    IL_0015: ret

}
ValueTuple<byte,byte,byte,byte,byte,byte,byte,ValueTuple<byte>> split(ulong src, N8 parts)
{
    IL_0000: ldarg.0
    IL_0001: conv.u1
    IL_0002: ldarg.0
    IL_0003: ldc.i4.8
    IL_0004: shr.un
    IL_0005: conv.u1
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 16
    IL_0009: shr.un
    IL_000A: conv.u1
    IL_000B: ldarg.0
    IL_000C: ldc.i4.s 24
    IL_000E: shr.un
    IL_000F: conv.u1
    IL_0010: ldarg.0
    IL_0011: ldc.i4.s 32
    IL_0013: shr.un
    IL_0014: conv.u1
    IL_0015: ldarg.0
    IL_0016: ldc.i4.s 40
    IL_0018: shr.un
    IL_0019: conv.u1
    IL_001A: ldarg.0
    IL_001B: ldc.i4.s 48
    IL_001D: shr.un
    IL_001E: conv.u1
    IL_001F: ldarg.0
    IL_0020: ldc.i4.s 56
    IL_0022: shr.un
    IL_0023: conv.u1
    IL_0024: newobj System.Void System.ValueTuple`1<System.Byte>::.ctor(System.Byte)
    IL_0029: newobj System.Void System.ValueTuple`8<System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.ValueTuple`1<System.Byte>>::.ctor(System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.ValueTuple`1<System.Byte>)
    IL_002E: ret

}
bool subset(byte test, byte set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(byte test, sbyte set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(byte test, short set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(byte test, ushort set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(byte test, int set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(byte test, uint set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(byte test, long set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: conv.u8
    IL_0003: and
    IL_0004: ldarg.0
    IL_0005: conv.u8
    IL_0006: ceq
    IL_0008: ret

}
bool subset(byte test, ulong set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: conv.u8
    IL_0003: and
    IL_0004: ldarg.0
    IL_0005: conv.u8
    IL_0006: ceq
    IL_0008: ret

}
bool subset(byte test, float set)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0006: ldarg.0
    IL_0007: and
    IL_0008: ldarg.0
    IL_0009: ceq
    IL_000B: ret

}
bool subset(byte test, double set)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0006: ldarg.0
    IL_0007: conv.u8
    IL_0008: and
    IL_0009: ldarg.0
    IL_000A: conv.u8
    IL_000B: ceq
    IL_000D: ret

}
bool subset(sbyte test, byte set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(sbyte test, sbyte set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(sbyte test, short set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(sbyte test, ushort set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(sbyte test, int set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(sbyte test, uint set)
{
    IL_0000: ldarg.1
    IL_0001: conv.u8
    IL_0002: ldarg.0
    IL_0003: conv.i8
    IL_0004: and
    IL_0005: ldarg.0
    IL_0006: conv.i8
    IL_0007: ceq
    IL_0009: ret

}
bool subset(sbyte test, long set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: conv.i8
    IL_0003: and
    IL_0004: ldarg.0
    IL_0005: conv.i8
    IL_0006: ceq
    IL_0008: ret

}
bool subset(sbyte test, ulong set)
{
    IL_0000: ldarg.1
    IL_0001: conv.u1
    IL_0002: ldarg.0
    IL_0003: and
    IL_0004: ldarg.0
    IL_0005: ceq
    IL_0007: ret

}
bool subset(sbyte test, float set)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0006: ldarg.0
    IL_0007: and
    IL_0008: ldarg.0
    IL_0009: ceq
    IL_000B: ret

}
bool subset(sbyte test, double set)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0006: ldarg.0
    IL_0007: conv.i8
    IL_0008: and
    IL_0009: ldarg.0
    IL_000A: conv.i8
    IL_000B: ceq
    IL_000D: ret

}
bool subset(ushort test, short set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(ushort test, ushort set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(ushort test, int set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(ushort test, uint set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(ushort test, long set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: conv.u8
    IL_0003: and
    IL_0004: ldarg.0
    IL_0005: conv.u8
    IL_0006: ceq
    IL_0008: ret

}
bool subset(ushort test, ulong set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: conv.u8
    IL_0003: and
    IL_0004: ldarg.0
    IL_0005: conv.u8
    IL_0006: ceq
    IL_0008: ret

}
bool subset(ushort test, float set)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0006: ldarg.0
    IL_0007: and
    IL_0008: ldarg.0
    IL_0009: ceq
    IL_000B: ret

}
bool subset(short test, short set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(short test, ushort set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(short test, int set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(short test, uint set)
{
    IL_0000: ldarg.1
    IL_0001: conv.u8
    IL_0002: ldarg.0
    IL_0003: conv.i8
    IL_0004: and
    IL_0005: ldarg.0
    IL_0006: conv.i8
    IL_0007: ceq
    IL_0009: ret

}
bool subset(short test, long set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: conv.i8
    IL_0003: and
    IL_0004: ldarg.0
    IL_0005: conv.i8
    IL_0006: ceq
    IL_0008: ret

}
bool subset(short test, ulong set)
{
    IL_0000: ldarg.1
    IL_0001: conv.u2
    IL_0002: ldarg.0
    IL_0003: and
    IL_0004: ldarg.0
    IL_0005: ceq
    IL_0007: ret

}
bool subset(short test, float set)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0006: ldarg.0
    IL_0007: and
    IL_0008: ldarg.0
    IL_0009: ceq
    IL_000B: ret

}
bool subset(uint test, int set)
{
    IL_0000: ldarg.1
    IL_0001: conv.i8
    IL_0002: ldarg.0
    IL_0003: conv.u8
    IL_0004: and
    IL_0005: ldarg.0
    IL_0006: conv.u8
    IL_0007: ceq
    IL_0009: ret

}
bool subset(uint test, uint set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(uint test, long set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: conv.u8
    IL_0003: and
    IL_0004: ldarg.0
    IL_0005: conv.u8
    IL_0006: ceq
    IL_0008: ret

}
bool subset(uint test, ulong set)
{
    IL_0000: ldarg.1
    IL_0001: conv.u2
    IL_0002: ldarg.0
    IL_0003: and
    IL_0004: ldarg.0
    IL_0005: ceq
    IL_0007: ret

}
bool subset(uint test, float set)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0006: conv.i8
    IL_0007: ldarg.0
    IL_0008: conv.u8
    IL_0009: and
    IL_000A: ldarg.0
    IL_000B: conv.u8
    IL_000C: ceq
    IL_000E: ret

}
bool subset(uint test, double set)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0006: ldarg.0
    IL_0007: conv.u8
    IL_0008: and
    IL_0009: ldarg.0
    IL_000A: conv.u8
    IL_000B: ceq
    IL_000D: ret

}
bool subset(int test, int set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(int test, uint set)
{
    IL_0000: ldarg.1
    IL_0001: conv.u8
    IL_0002: ldarg.0
    IL_0003: conv.i8
    IL_0004: and
    IL_0005: ldarg.0
    IL_0006: conv.i8
    IL_0007: ceq
    IL_0009: ret

}
bool subset(int test, long set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: conv.i8
    IL_0003: and
    IL_0004: ldarg.0
    IL_0005: conv.i8
    IL_0006: ceq
    IL_0008: ret

}
bool subset(int test, ulong set)
{
    IL_0000: ldarg.1
    IL_0001: conv.u2
    IL_0002: ldarg.0
    IL_0003: and
    IL_0004: ldarg.0
    IL_0005: ceq
    IL_0007: ret

}
bool subset(int test, float set)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0006: ldarg.0
    IL_0007: and
    IL_0008: ldarg.0
    IL_0009: ceq
    IL_000B: ret

}
bool subset(int test, double set)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0006: ldarg.0
    IL_0007: conv.i8
    IL_0008: and
    IL_0009: ldarg.0
    IL_000A: conv.i8
    IL_000B: ceq
    IL_000D: ret

}
bool subset(long test, long set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(long test, ulong set)
{
    IL_0000: ldarg.1
    IL_0001: conv.u2
    IL_0002: conv.u8
    IL_0003: ldarg.0
    IL_0004: and
    IL_0005: ldarg.0
    IL_0006: ceq
    IL_0008: ret

}
bool subset(long test, float set)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0006: conv.i8
    IL_0007: ldarg.0
    IL_0008: and
    IL_0009: ldarg.0
    IL_000A: ceq
    IL_000C: ret

}
bool subset(long test, double set)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0006: ldarg.0
    IL_0007: and
    IL_0008: ldarg.0
    IL_0009: ceq
    IL_000B: ret

}
bool subset(ulong test, long set)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ceq
    IL_0006: ret

}
bool subset(ulong test, ulong set)
{
    IL_0000: ldarg.1
    IL_0001: conv.u2
    IL_0002: conv.u8
    IL_0003: ldarg.0
    IL_0004: and
    IL_0005: ldarg.0
    IL_0006: ceq
    IL_0008: ret

}
bool subset(ulong test, double set)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0006: ldarg.0
    IL_0007: and
    IL_0008: ldarg.0
    IL_0009: ceq
    IL_000B: ret

}
bool test(in sbyte src, in int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMask::test(System.SByte&,System.Int32&)
    IL_0007: ret

}
bool test(in byte src, in int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMask::test(System.Byte&,System.Int32&)
    IL_0007: ret

}
bool test(in short src, in int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMask::test(System.Int16&,System.Int32&)
    IL_0007: ret

}
bool test(in ushort src, in int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMask::test(System.UInt16&,System.Int32&)
    IL_0007: ret

}
bool test(in int src, in int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMask::test(System.Int32&,System.Int32&)
    IL_0007: ret

}
bool test(in uint src, in int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMask::test(System.UInt32&,System.Int32&)
    IL_0007: ret

}
bool test(in long src, in int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMask::test(System.Int64&,System.Int32&)
    IL_0007: ret

}
bool test(in ulong src, in int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMask::test(System.UInt64&,System.Int32&)
    IL_0007: ret

}
bool test(in float src, in int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMask::test(System.Single&,System.Int32&)
    IL_0007: ret

}
bool test(in double src, in int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMask::test(System.Double&,System.Int32&)
    IL_0007: ret

}
sbyte toggle(sbyte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shl
    IL_0007: conv.i1
    IL_0008: xor
    IL_0009: conv.i1
    IL_000A: dup
    IL_000B: starg.s src
    IL_000D: ret

}
byte toggle(byte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shl
    IL_0007: conv.u1
    IL_0008: xor
    IL_0009: conv.u1
    IL_000A: dup
    IL_000B: starg.s src
    IL_000D: ret

}
short toggle(short src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shl
    IL_0007: conv.i2
    IL_0008: xor
    IL_0009: conv.i2
    IL_000A: dup
    IL_000B: starg.s src
    IL_000D: ret

}
ushort toggle(ushort src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shl
    IL_0007: conv.u2
    IL_0008: xor
    IL_0009: conv.u2
    IL_000A: dup
    IL_000B: starg.s src
    IL_000D: ret

}
int toggle(int src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shl
    IL_0007: xor
    IL_0008: dup
    IL_0009: starg.s src
    IL_000B: ret

}
Vec128<sbyte> flip(in Vec128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: ldarg.0
    IL_0017: ldobj Z0.Vec128`1<System.SByte>
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0021: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0026: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_002B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0030: ret

}
Vec128<byte> flip(in Vec128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldarg.0
    IL_0017: ldobj Z0.Vec128`1<System.Byte>
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0021: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0026: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_002B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0030: ret

}
Vec128<short> flip(in Vec128<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: ldarg.0
    IL_0017: ldobj Z0.Vec128`1<System.Int16>
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0021: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0026: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_002B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0030: ret

}
Vec128<ushort> flip(in Vec128<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: ldarg.0
    IL_0017: ldobj Z0.Vec128`1<System.UInt16>
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0021: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0026: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_002B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0030: ret

}
Vec128<int> flip(in Vec128<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: ldarg.0
    IL_0017: ldobj Z0.Vec128`1<System.Int32>
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0021: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0026: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_002B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0030: ret

}
Vec128<uint> flip(in Vec128<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: ldarg.0
    IL_0017: ldobj Z0.Vec128`1<System.UInt32>
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0021: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0026: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_002B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0030: ret

}
Vec128<long> flip(in Vec128<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Int64 Z0.Vec128`1<System.Int64>::get_Item(System.Int32)
    IL_0007: not
    IL_0008: ldarg.0
    IL_0009: ldc.i4.1
    IL_000A: call System.Int64 Z0.Vec128`1<System.Int64>::get_Item(System.Int32)
    IL_000F: not
    IL_0010: call Z0.Vec128`1<System.Int64> Z0.Vec128::FromParts(System.Int64,System.Int64)
    IL_0015: ret

}
Vec128<ulong> flip(in Vec128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.UInt64 Z0.Vec128`1<System.UInt64>::get_Item(System.Int32)
    IL_0007: not
    IL_0008: ldarg.0
    IL_0009: ldc.i4.1
    IL_000A: call System.UInt64 Z0.Vec128`1<System.UInt64>::get_Item(System.Int32)
    IL_000F: not
    IL_0010: call Z0.Vec128`1<System.UInt64> Z0.Vec128::FromParts(System.UInt64,System.UInt64)
    IL_0015: ret

}
Vec256<sbyte> flip(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: ldarg.0
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001C: stloc.0
    IL_001D: ldloca.s V_0
    IL_001F: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0024: ret

}
Vec256<byte> flip(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: ldarg.0
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001C: stloc.0
    IL_001D: ldloca.s V_0
    IL_001F: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0024: ret

}
Vec256<short> flip(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: ldarg.0
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001C: stloc.0
    IL_001D: ldloca.s V_0
    IL_001F: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0024: ret

}
Vec256<ushort> flip(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: ldarg.0
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001C: stloc.0
    IL_001D: ldloca.s V_0
    IL_001F: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0024: ret

}
Vec256<int> flip(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: ldarg.0
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001C: stloc.0
    IL_001D: ldloca.s V_0
    IL_001F: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0024: ret

}
Vec256<uint> flip(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: ldarg.0
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001C: stloc.0
    IL_001D: ldloca.s V_0
    IL_001F: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0024: ret

}
Vec256<long> flip(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: ldarg.0
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001C: stloc.0
    IL_001D: ldloca.s V_0
    IL_001F: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0024: ret

}
Vec256<ulong> flip(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: ldarg.0
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001C: stloc.0
    IL_001D: ldloca.s V_0
    IL_001F: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0024: ret

}
void flip(in Vec128<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.SByte> Z0.Bits::flip(Z0.Vec128`1<System.SByte>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void zfunc::vstore(Z0.Vec128`1<System.SByte>&,System.SByte&)
    IL_000F: ret

}
void flip(in Vec128<byte> src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Byte> Z0.Bits::flip(Z0.Vec128`1<System.Byte>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void zfunc::vstore(Z0.Vec128`1<System.Byte>&,System.Byte&)
    IL_000F: ret

}
void flip(in Vec128<short> src, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int16> Z0.Bits::flip(Z0.Vec128`1<System.Int16>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void zfunc::vstore(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_000F: ret

}
void flip(in Vec128<ushort> src, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt16> Z0.Bits::flip(Z0.Vec128`1<System.UInt16>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void zfunc::vstore(Z0.Vec128`1<System.UInt16>&,System.UInt16&)
    IL_000F: ret

}
void flip(in Vec128<int> src, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int32> Z0.Bits::flip(Z0.Vec128`1<System.Int32>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void zfunc::vstore(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_000F: ret

}
void flip(in Vec128<uint> src, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt32> Z0.Bits::flip(Z0.Vec128`1<System.UInt32>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void zfunc::vstore(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_000F: ret

}
void flip(in Vec128<long> src, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int64> Z0.Bits::flip(Z0.Vec128`1<System.Int64>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void zfunc::vstore(Z0.Vec128`1<System.Int64>&,System.Int64&)
    IL_000F: ret

}
void flip(in Vec128<ulong> src, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt64> Z0.Bits::flip(Z0.Vec128`1<System.UInt64>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void zfunc::vstore(Z0.Vec128`1<System.UInt64>&,System.UInt64&)
    IL_000F: ret

}
void flip(in Vec256<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.SByte> Z0.Bits::flip(Z0.Vec256`1<System.SByte>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void zfunc::vstore(Z0.Vec256`1<System.SByte>&,System.SByte&)
    IL_000F: ret

}
void flip(in Vec256<byte> src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Byte> Z0.Bits::flip(Z0.Vec256`1<System.Byte>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void zfunc::vstore(Z0.Vec256`1<System.Byte>&,System.Byte&)
    IL_000F: ret

}
void flip(in Vec256<short> src, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int16> Z0.Bits::flip(Z0.Vec256`1<System.Int16>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void zfunc::vstore(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_000F: ret

}
void flip(in Vec256<ushort> src, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt16> Z0.Bits::flip(Z0.Vec256`1<System.UInt16>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void zfunc::vstore(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_000F: ret

}
void flip(in Vec256<int> src, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int32> Z0.Bits::flip(Z0.Vec256`1<System.Int32>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void zfunc::vstore(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_000F: ret

}
void flip(in Vec256<uint> src, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt32> Z0.Bits::flip(Z0.Vec256`1<System.UInt32>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void zfunc::vstore(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_000F: ret

}
void flip(in Vec256<long> src, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int64> Z0.Bits::flip(Z0.Vec256`1<System.Int64>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void zfunc::vstore(Z0.Vec256`1<System.Int64>&,System.Int64&)
    IL_000F: ret

}
void flip(in Vec256<ulong> src, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt64> Z0.Bits::flip(Z0.Vec256`1<System.UInt64>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void zfunc::vstore(Z0.Vec256`1<System.UInt64>&,System.UInt64&)
    IL_000F: ret

}
Span<sbyte> flip(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "flip"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops\\flip.d.cs"
    IL_000C: ldc.i4 151
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
    IL_0031: call System.SByte Z0.math::flip(System.SByte)
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
Span<byte> flip(ReadOnlySpan<byte> src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "flip"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops\\flip.d.cs"
    IL_000C: ldc.i4 159
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
    IL_0031: call System.Byte Z0.math::flip(System.Byte)
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
Span<short> flip(ReadOnlySpan<short> src, Span<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "flip"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops\\flip.d.cs"
    IL_000C: ldc.i4 167
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
    IL_0031: call System.Int16 Z0.math::flip(System.Int16)
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
Span<ushort> flip(ReadOnlySpan<ushort> src, Span<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "flip"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops\\flip.d.cs"
    IL_000C: ldc.i4 175
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
    IL_0031: call System.UInt16 Z0.math::flip(System.UInt16)
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
Span<int> flip(ReadOnlySpan<int> src, Span<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "flip"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops\\flip.d.cs"
    IL_000C: ldc.i4 183
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
    IL_0031: call System.Int32 Z0.math::flip(System.Int32)
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
Span<uint> flip(ReadOnlySpan<uint> src, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "flip"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops\\flip.d.cs"
    IL_000C: ldc.i4 191
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
    IL_0031: call System.UInt32 Z0.math::flip(System.UInt32)
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
Span<long> flip(ReadOnlySpan<long> src, Span<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "flip"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops\\flip.d.cs"
    IL_000C: ldc.i4 199
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
    IL_0031: call System.Int64 Z0.math::flip(System.Int64)
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
Span<ulong> flip(ReadOnlySpan<ulong> src, Span<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "flip"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\bits\\src\\ops\\flip.d.cs"
    IL_000C: ldc.i4 207
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
    IL_0031: call System.UInt64 Z0.math::flip(System.UInt64)
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
    IL_0001: ldc.i4.0
    IL_0002: call System.Span`1<System.SByte> Z0.SpanExtensions::Replicate<System.SByte>(System.ReadOnlySpan`1<System.SByte>,System.Boolean)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: call System.Span`1<System.SByte>& Z0.Bits::flip(System.Span`1<System.SByte>&)
    IL_000F: ldobj System.Span`1<System.SByte>
    IL_0014: ret

}
Span<byte> flip(ReadOnlySpan<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Span`1<System.Byte> Z0.SpanExtensions::Replicate<System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.Boolean)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: call System.Span`1<System.Byte>& Z0.Bits::flip(System.Span`1<System.Byte>&)
    IL_000F: ldobj System.Span`1<System.Byte>
    IL_0014: ret

}
Span<short> flip(ReadOnlySpan<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Span`1<System.Int16> Z0.SpanExtensions::Replicate<System.Int16>(System.ReadOnlySpan`1<System.Int16>,System.Boolean)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: call System.Span`1<System.Int16>& Z0.Bits::flip(System.Span`1<System.Int16>&)
    IL_000F: ldobj System.Span`1<System.Int16>
    IL_0014: ret

}
Span<ushort> flip(ReadOnlySpan<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Span`1<System.UInt16> Z0.SpanExtensions::Replicate<System.UInt16>(System.ReadOnlySpan`1<System.UInt16>,System.Boolean)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: call System.Span`1<System.UInt16>& Z0.Bits::flip(System.Span`1<System.UInt16>&)
    IL_000F: ldobj System.Span`1<System.UInt16>
    IL_0014: ret

}
Span<int> flip(ReadOnlySpan<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Span`1<System.Int32> Z0.SpanExtensions::Replicate<System.Int32>(System.ReadOnlySpan`1<System.Int32>,System.Boolean)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: call System.Span`1<System.Int32>& Z0.Bits::flip(System.Span`1<System.Int32>&)
    IL_000F: ldobj System.Span`1<System.Int32>
    IL_0014: ret

}
Span<uint> flip(ReadOnlySpan<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Span`1<System.UInt32> Z0.SpanExtensions::Replicate<System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.Boolean)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: call System.Span`1<System.UInt32>& Z0.Bits::flip(System.Span`1<System.UInt32>&)
    IL_000F: ldobj System.Span`1<System.UInt32>
    IL_0014: ret

}
Span<long> flip(ReadOnlySpan<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Span`1<System.Int64> Z0.SpanExtensions::Replicate<System.Int64>(System.ReadOnlySpan`1<System.Int64>,System.Boolean)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: call System.Span`1<System.Int64>& Z0.Bits::flip(System.Span`1<System.Int64>&)
    IL_000F: ldobj System.Span`1<System.Int64>
    IL_0014: ret

}
Span<ulong> flip(ReadOnlySpan<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Span`1<System.UInt64> Z0.SpanExtensions::Replicate<System.UInt64>(System.ReadOnlySpan`1<System.UInt64>,System.Boolean)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: call System.Span`1<System.UInt64>& Z0.Bits::flip(System.Span`1<System.UInt64>&)
    IL_000F: ldobj System.Span`1<System.UInt64>
    IL_0014: ret

}
byte andn(in byte lhs, in byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u1
    IL_0002: ldarg.1
    IL_0003: ldind.u1
    IL_0004: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::AndNot(System.UInt32,System.UInt32)
    IL_0009: conv.u1
    IL_000A: ret

}
ushort andn(in ushort lhs, in ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u2
    IL_0002: ldarg.1
    IL_0003: ldind.u2
    IL_0004: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::AndNot(System.UInt32,System.UInt32)
    IL_0009: conv.u2
    IL_000A: ret

}
uint andn(in uint lhs, in uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u4
    IL_0002: ldarg.1
    IL_0003: ldind.u4
    IL_0004: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::AndNot(System.UInt32,System.UInt32)
    IL_0009: ret

}
ulong andn(in ulong lhs, in ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: ldarg.1
    IL_0003: ldind.i8
    IL_0004: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::AndNot(System.UInt64,System.UInt64)
    IL_0009: ret

}
ref sbyte bitmap(in sbyte src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i1
    IL_0005: ldarg.0
    IL_0006: ldarga.s srcOffset
    IL_0008: ldarga.s len
    IL_000A: call System.SByte Z0.Bits::extract(System.SByte&,System.Byte&,System.Byte&)
    IL_000F: ldarg.3
    IL_0010: ldc.i4.s 31
    IL_0012: and
    IL_0013: shl
    IL_0014: conv.i1
    IL_0015: or
    IL_0016: conv.i1
    IL_0017: stind.i1
    IL_0018: ldarg.s dst
    IL_001A: ret

}
ref byte bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.u1
    IL_0005: ldarg.0
    IL_0006: ldarga.s srcOffset
    IL_0008: ldarga.s len
    IL_000A: call System.Byte Z0.Bits::extract(System.Byte&,System.Byte&,System.Byte&)
    IL_000F: ldarg.3
    IL_0010: ldc.i4.s 31
    IL_0012: and
    IL_0013: shl
    IL_0014: conv.u1
    IL_0015: or
    IL_0016: conv.u1
    IL_0017: stind.i1
    IL_0018: ldarg.s dst
    IL_001A: ret

}
ref short bitmap(in short src, byte srcOffset, byte len, byte dstOffset, ref short dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i2
    IL_0005: ldarg.0
    IL_0006: ldarga.s srcOffset
    IL_0008: ldarga.s len
    IL_000A: call System.Int16 Z0.Bits::extract(System.Int16&,System.Byte&,System.Byte&)
    IL_000F: ldarg.3
    IL_0010: ldc.i4.s 31
    IL_0012: and
    IL_0013: shl
    IL_0014: conv.i2
    IL_0015: or
    IL_0016: conv.i2
    IL_0017: stind.i2
    IL_0018: ldarg.s dst
    IL_001A: ret

}
ref ushort bitmap(in ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.u2
    IL_0005: ldarg.0
    IL_0006: ldarga.s srcOffset
    IL_0008: ldarga.s len
    IL_000A: call System.UInt16 Z0.Bits::extract(System.UInt16&,System.Byte&,System.Byte&)
    IL_000F: ldarg.3
    IL_0010: ldc.i4.s 31
    IL_0012: and
    IL_0013: shl
    IL_0014: conv.u2
    IL_0015: or
    IL_0016: conv.u2
    IL_0017: stind.i2
    IL_0018: ldarg.s dst
    IL_001A: ret

}
ref int bitmap(in int src, byte srcOffset, byte len, byte dstOffset, ref int dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i4
    IL_0005: ldarg.0
    IL_0006: ldarga.s srcOffset
    IL_0008: ldarga.s len
    IL_000A: call System.Int32 Z0.Bits::extract(System.Int32&,System.Byte&,System.Byte&)
    IL_000F: ldarg.3
    IL_0010: ldc.i4.s 31
    IL_0012: and
    IL_0013: shl
    IL_0014: or
    IL_0015: stind.i4
    IL_0016: ldarg.s dst
    IL_0018: ret

}
ref uint bitmap(in uint src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.u4
    IL_0005: ldarg.0
    IL_0006: ldarga.s srcOffset
    IL_0008: ldarga.s len
    IL_000A: call System.UInt32 Z0.Bits::extract(System.UInt32&,System.Byte&,System.Byte&)
    IL_000F: ldarg.3
    IL_0010: ldc.i4.s 31
    IL_0012: and
    IL_0013: shl
    IL_0014: or
    IL_0015: stind.i4
    IL_0016: ldarg.s dst
    IL_0018: ret

}
ref long bitmap(in long src, byte srcOffset, byte len, byte dstOffset, ref long dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i8
    IL_0005: ldarg.0
    IL_0006: ldarga.s srcOffset
    IL_0008: ldarga.s len
    IL_000A: call System.Int64 Z0.Bits::extract(System.Int64&,System.Byte&,System.Byte&)
    IL_000F: ldarg.3
    IL_0010: ldc.i4.s 63
    IL_0012: and
    IL_0013: shl
    IL_0014: or
    IL_0015: stind.i8
    IL_0016: ldarg.s dst
    IL_0018: ret

}
ref ulong bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i8
    IL_0005: ldarg.0
    IL_0006: ldarga.s srcOffset
    IL_0008: ldarga.s len
    IL_000A: call System.UInt64 Z0.Bits::extract(System.UInt64&,System.Byte&,System.Byte&)
    IL_000F: ldarg.3
    IL_0010: ldc.i4.s 63
    IL_0012: and
    IL_0013: shl
    IL_0014: or
    IL_0015: stind.i8
    IL_0016: ldarg.s dst
    IL_0018: ret

}
ref float bitmap(in float src, byte srcOffset, byte len, byte dstOffset, ref float dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.0
    IL_0003: ldind.r4
    IL_0004: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0009: stloc.0
    IL_000A: ldloca.s V_0
    IL_000C: ldarga.s srcOffset
    IL_000E: ldarga.s len
    IL_0010: call System.Int32 Z0.Bits::extract(System.Int32&,System.Byte&,System.Byte&)
    IL_0015: ldarg.3
    IL_0016: ldc.i4.s 31
    IL_0018: and
    IL_0019: shl
    IL_001A: conv.r4
    IL_001B: call System.Single& Z0.math::or(System.Single&,System.Single)
    IL_0020: pop
    IL_0021: ldarg.s dst
    IL_0023: ret

}
ref double bitmap(in double src, byte srcOffset, byte len, byte dstOffset, ref double dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.0
    IL_0003: ldind.r8
    IL_0004: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0009: stloc.0
    IL_000A: ldloca.s V_0
    IL_000C: ldarga.s srcOffset
    IL_000E: ldarga.s len
    IL_0010: call System.Int64 Z0.Bits::extract(System.Int64&,System.Byte&,System.Byte&)
    IL_0015: ldarg.3
    IL_0016: ldc.i4.s 63
    IL_0018: and
    IL_0019: shl
    IL_001A: conv.r8
    IL_001B: call System.Double& Z0.math::or(System.Double&,System.Double)
    IL_0020: pop
    IL_0021: ldarg.s dst
    IL_0023: ret

}
string bstext(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.String Z0.BitStore::BitText(System.Byte)
    IL_0006: ret

}
string bstext(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.String Z0.BitStore::BitText(System.SByte)
    IL_0006: ret

}
string bstext(ushort src)
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
    IL_001C: ldloc.1
    IL_001D: call System.String Z0.Bits::bstext(System.Byte)
    IL_0022: ldloc.0
    IL_0023: call System.String Z0.Bits::bstext(System.Byte)
    IL_0028: call System.String System.String::Concat(System.String,System.String)
    IL_002D: ret

}
string bstext(short src)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_2
    IL_0003: initobj Z0.N2
    IL_0009: ldloc.2
    IL_000A: call System.ValueTuple`2<System.SByte,System.SByte> Z0.Bits::split(System.Int16,Z0.N2)
    IL_000F: dup
    IL_0010: ldfld System.SByte System.ValueTuple`2<System.SByte,System.SByte>::Item1
    IL_0015: stloc.0
    IL_0016: ldfld System.SByte System.ValueTuple`2<System.SByte,System.SByte>::Item2
    IL_001B: stloc.1
    IL_001C: ldloc.1
    IL_001D: call System.String Z0.Bits::bstext(System.SByte)
    IL_0022: ldloc.0
    IL_0023: call System.String Z0.Bits::bstext(System.SByte)
    IL_0028: call System.String System.String::Concat(System.String,System.String)
    IL_002D: ret

}
string bstext(uint src)
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
    IL_001C: ldloc.1
    IL_001D: call System.String Z0.Bits::bstext(System.UInt16)
    IL_0022: ldloc.0
    IL_0023: call System.String Z0.Bits::bstext(System.UInt16)
    IL_0028: call System.String System.String::Concat(System.String,System.String)
    IL_002D: ret

}
string bstext(int src)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_2
    IL_0003: initobj Z0.N2
    IL_0009: ldloc.2
    IL_000A: call System.ValueTuple`2<System.Int16,System.Int16> Z0.Bits::split(System.Int32,Z0.N2)
    IL_000F: dup
    IL_0010: ldfld System.Int16 System.ValueTuple`2<System.Int16,System.Int16>::Item1
    IL_0015: stloc.0
    IL_0016: ldfld System.Int16 System.ValueTuple`2<System.Int16,System.Int16>::Item2
    IL_001B: stloc.1
    IL_001C: ldloc.1
    IL_001D: call System.String Z0.Bits::bstext(System.Int16)
    IL_0022: ldloc.0
    IL_0023: call System.String Z0.Bits::bstext(System.Int16)
    IL_0028: call System.String System.String::Concat(System.String,System.String)
    IL_002D: ret

}
string bstext(ulong src)
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
    IL_001C: ldloc.1
    IL_001D: call System.String Z0.Bits::bstext(System.UInt32)
    IL_0022: ldloc.0
    IL_0023: call System.String Z0.Bits::bstext(System.UInt32)
    IL_0028: call System.String System.String::Concat(System.String,System.String)
    IL_002D: ret

}
string bstext(long src)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_2
    IL_0003: initobj Z0.N2
    IL_0009: ldloc.2
    IL_000A: call System.ValueTuple`2<System.Int32,System.Int32> Z0.Bits::split(System.Int64,Z0.N2)
    IL_000F: dup
    IL_0010: ldfld System.Int32 System.ValueTuple`2<System.Int32,System.Int32>::Item1
    IL_0015: stloc.0
    IL_0016: ldfld System.Int32 System.ValueTuple`2<System.Int32,System.Int32>::Item2
    IL_001B: stloc.1
    IL_001C: ldloc.1
    IL_001D: call System.String Z0.Bits::bstext(System.Int32)
    IL_0022: ldloc.0
    IL_0023: call System.String Z0.Bits::bstext(System.Int32)
    IL_0028: call System.String System.String::Concat(System.String,System.String)
    IL_002D: ret

}
byte deposit(in byte src, in byte mask)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u1
    IL_0002: ldarg.1
    IL_0003: ldind.u1
    IL_0004: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitDeposit(System.UInt32,System.UInt32)
    IL_0009: conv.u1
    IL_000A: ret

}
ushort deposit(in ushort src, in ushort mask)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u2
    IL_0002: ldarg.1
    IL_0003: ldind.u2
    IL_0004: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitDeposit(System.UInt32,System.UInt32)
    IL_0009: conv.u2
    IL_000A: ret

}
uint deposit(in uint src, in uint mask)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u4
    IL_0002: ldarg.1
    IL_0003: ldind.u4
    IL_0004: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitDeposit(System.UInt32,System.UInt32)
    IL_0009: ret

}
ulong deposit(in ulong src, in ulong mask)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: ldarg.1
    IL_0003: ldind.i8
    IL_0004: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi2/X64::ParallelBitDeposit(System.UInt64,System.UInt64)
    IL_0009: ret

}
ref byte deposit(ref byte io, byte mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitDeposit(System.UInt32,System.UInt32)
    IL_0009: conv.u1
    IL_000A: stind.i1
    IL_000B: ldarg.0
    IL_000C: ret

}
ref ushort deposit(ref ushort io, ushort mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitDeposit(System.UInt32,System.UInt32)
    IL_0009: conv.u2
    IL_000A: stind.i2
    IL_000B: ldarg.0
    IL_000C: ret

}
ref uint deposit(ref uint io, uint mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitDeposit(System.UInt32,System.UInt32)
    IL_0009: stind.i4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref ulong deposit(ref ulong io, ulong mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi2/X64::ParallelBitDeposit(System.UInt64,System.UInt64)
    IL_0009: stind.i8
    IL_000A: ldarg.0
    IL_000B: ret

}
byte extract(in byte src, in byte mask)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u1
    IL_0002: ldarg.1
    IL_0003: ldind.u1
    IL_0004: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitExtract(System.UInt32,System.UInt32)
    IL_0009: conv.u1
    IL_000A: ret

}
byte extract(in sbyte src, in byte mask)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i1
    IL_0002: ldarg.1
    IL_0003: ldind.u1
    IL_0004: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitExtract(System.UInt32,System.UInt32)
    IL_0009: conv.u1
    IL_000A: ret

}
ushort extract(in ushort src, in ushort mask)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u2
    IL_0002: ldarg.1
    IL_0003: ldind.u2
    IL_0004: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitExtract(System.UInt32,System.UInt32)
    IL_0009: conv.u2
    IL_000A: ret

}
uint extract(in int src, in uint mask)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i4
    IL_0002: ldarg.1
    IL_0003: ldind.u4
    IL_0004: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitExtract(System.UInt32,System.UInt32)
    IL_0009: ret

}
uint extract(in uint src, in uint mask)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u4
    IL_0002: ldarg.1
    IL_0003: ldind.u4
    IL_0004: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitExtract(System.UInt32,System.UInt32)
    IL_0009: ret

}
ulong extract(in long src, in ulong mask)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: ldarg.1
    IL_0003: ldind.i8
    IL_0004: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi2/X64::ParallelBitExtract(System.UInt64,System.UInt64)
    IL_0009: ret

}
ulong extract(in ulong src, in ulong mask)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: ldarg.1
    IL_0003: ldind.i8
    IL_0004: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi2/X64::ParallelBitExtract(System.UInt64,System.UInt64)
    IL_0009: ret

}
byte extract(in byte src, byte mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: stloc.0
    IL_0003: ldloca.s V_0
    IL_0005: call System.Byte Z0.Bits::extract(System.Byte&,System.Byte&)
    IL_000A: ret

}
ushort extract(in ushort src, ushort mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: stloc.0
    IL_0003: ldloca.s V_0
    IL_0005: call System.UInt16 Z0.Bits::extract(System.UInt16&,System.UInt16&)
    IL_000A: ret

}
uint extract(in uint src, uint mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: stloc.0
    IL_0003: ldloca.s V_0
    IL_0005: call System.UInt32 Z0.Bits::extract(System.UInt32&,System.UInt32&)
    IL_000A: ret

}
ulong extract(in ulong src, ulong mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: stloc.0
    IL_0003: ldloca.s V_0
    IL_0005: call System.UInt64 Z0.Bits::extract(System.UInt64&,System.UInt64&)
    IL_000A: ret

}
sbyte extract(in sbyte src, in byte start, in byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i1
    IL_0002: ldarg.1
    IL_0003: ldind.u1
    IL_0004: ldarg.2
    IL_0005: ldind.u1
    IL_0006: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_000B: conv.i1
    IL_000C: ret

}
byte extract(in byte src, in byte start, in byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u1
    IL_0002: ldarg.1
    IL_0003: ldind.u1
    IL_0004: ldarg.2
    IL_0005: ldind.u1
    IL_0006: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_000B: conv.u1
    IL_000C: ret

}
short extract(in short src, in byte start, in byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i2
    IL_0002: ldarg.1
    IL_0003: ldind.u1
    IL_0004: ldarg.2
    IL_0005: ldind.u1
    IL_0006: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_000B: conv.i2
    IL_000C: ret

}
ushort extract(in ushort src, in byte start, in byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u2
    IL_0002: ldarg.1
    IL_0003: ldind.u1
    IL_0004: ldarg.2
    IL_0005: ldind.u1
    IL_0006: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_000B: conv.u2
    IL_000C: ret

}
uint extract(in uint src, in byte start, in byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u4
    IL_0002: ldarg.1
    IL_0003: ldind.u1
    IL_0004: ldarg.2
    IL_0005: ldind.u1
    IL_0006: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_000B: ret

}
int extract(in int src, in byte start, in byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i4
    IL_0002: ldarg.1
    IL_0003: ldind.u1
    IL_0004: ldarg.2
    IL_0005: ldind.u1
    IL_0006: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_000B: ret

}
long extract(in long src, in byte start, in byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: ldarg.1
    IL_0003: ldind.u1
    IL_0004: ldarg.2
    IL_0005: ldind.u1
    IL_0006: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::BitFieldExtract(System.UInt64,System.Byte,System.Byte)
    IL_000B: ret

}
ulong extract(in ulong src, in byte start, in byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: ldarg.1
    IL_0003: ldind.u1
    IL_0004: ldarg.2
    IL_0005: ldind.u1
    IL_0006: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::BitFieldExtract(System.UInt64,System.Byte,System.Byte)
    IL_000B: ret

}
float extract(in float src, in byte start, in byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldind.r4
    IL_0002: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.1
    IL_000B: ldarg.2
    IL_000C: call System.Int32 Z0.Bits::extract(System.Int32&,System.Byte&,System.Byte&)
    IL_0011: call System.Single System.BitConverter::Int32BitsToSingle(System.Int32)
    IL_0016: ret

}
double extract(in double src, in byte start, in byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldind.r8
    IL_0002: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.1
    IL_000B: ldarg.2
    IL_000C: call System.Int64 Z0.Bits::extract(System.Int64&,System.Byte&,System.Byte&)
    IL_0011: call System.Double System.BitConverter::Int64BitsToDouble(System.Int64)
    IL_0016: ret

}
ushort hi(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u4
    IL_0002: ldc.i4.s 16
    IL_0004: shr.un
    IL_0005: conv.u2
    IL_0006: ret

}
ushort lo(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u4
    IL_0002: conv.u2
    IL_0003: ret

}
uint hi(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: ldc.i4.s 32
    IL_0004: shr.un
    IL_0005: conv.u4
    IL_0006: ret

}
uint lo(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: conv.u4
    IL_0003: ret

}
sbyte hi(in sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i1
    IL_0002: ldc.i4.4
    IL_0003: shr
    IL_0004: conv.i1
    IL_0005: ret

}
sbyte lo(in sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i1
    IL_0002: ldc.i4.4
    IL_0003: shl
    IL_0004: conv.i1
    IL_0005: ldc.i4.4
    IL_0006: shr
    IL_0007: conv.i1
    IL_0008: ret

}
byte hi(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u1
    IL_0002: ldc.i4.4
    IL_0003: shr
    IL_0004: conv.u1
    IL_0005: ret

}
byte lo(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u1
    IL_0002: ldc.i4.4
    IL_0003: shl
    IL_0004: conv.u1
    IL_0005: ldc.i4.4
    IL_0006: shr
    IL_0007: conv.u1
    IL_0008: ret

}
byte hi(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u2
    IL_0002: ldc.i4.8
    IL_0003: shr
    IL_0004: conv.u1
    IL_0005: ret

}
byte lo(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u2
    IL_0002: conv.u1
    IL_0003: ret

}
sbyte hi(in short src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i2
    IL_0002: ldc.i4.8
    IL_0003: shr
    IL_0004: conv.i1
    IL_0005: ret

}
sbyte lo(in short src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i2
    IL_0002: conv.i1
    IL_0003: ret

}
short hi(in int src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i4
    IL_0002: ldc.i4.s 16
    IL_0004: shr
    IL_0005: conv.i2
    IL_0006: ret

}
short lo(in int src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i4
    IL_0002: conv.i2
    IL_0003: ret

}
int hi(in long src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: ldc.i4.s 32
    IL_0004: shr
    IL_0005: conv.i4
    IL_0006: ret

}
int lo(in long src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: conv.i4
    IL_0003: ret

}
int log2(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 System.Numerics.BitOperations::Log2(System.UInt32)
    IL_0006: ret

}
int log2(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 System.Numerics.BitOperations::Log2(System.UInt32)
    IL_0006: ret

}
int log2(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 System.Numerics.BitOperations::Log2(System.UInt32)
    IL_0006: ret

}
int log2(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 System.Numerics.BitOperations::Log2(System.UInt64)
    IL_0006: ret

}
float log2(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Log2(System.Single)
    IL_0006: ret

}

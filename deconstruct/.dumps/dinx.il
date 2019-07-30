// 2019-07-29 18:32:30:365
ref Vec256<ushort> loadDqu(in ushort src, out Vec256<ushort> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt16* Z0.As::constptr(System.UInt16&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.UInt16*)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0014: stobj Z0.Vec256`1<System.UInt16>
    IL_0019: ldarg.1
    IL_001A: ret

}
ref Vec256<int> loadDqu(in int src, out Vec256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int32* Z0.As::constptr(System.Int32&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Int32*)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0014: stobj Z0.Vec256`1<System.Int32>
    IL_0019: ldarg.1
    IL_001A: ret

}
ref Vec256<uint> loadDqu(in uint src, out Vec256<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.UInt32*)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0014: stobj Z0.Vec256`1<System.UInt32>
    IL_0019: ldarg.1
    IL_001A: ret

}
ref Vec256<long> loadDqu(in long src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int64* Z0.As::constptr(System.Int64&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Int64*)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0014: stobj Z0.Vec256`1<System.Int64>
    IL_0019: ldarg.1
    IL_001A: ret

}
ref Vec256<ulong> loadDqu(in ulong src, out Vec256<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.UInt64*)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0014: stobj Z0.Vec256`1<System.UInt64>
    IL_0019: ldarg.1
    IL_001A: ret

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
Vec128<float> movescalar(in Vec128<float> a, in Vec128<float> b)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::MoveScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> movescalar(in Vec128<double> a, in Vec128<double> b)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::MoveScalar(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

}
Vec128<float> permute(in Vec128<float> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Permute(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0016: ret

}
Vec128<double> permute(in Vec128<double> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Permute(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0016: ret

}
Vec128<float> permute(in Vec128<float> lhs, in Vec128<int> control)
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
Vec128<double> permute(in Vec128<double> lhs, in Vec128<long> control)
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
Vec256<float> permute(Vec256<float> lhs, in Vec256<int> control)
{
    IL_0000: ldarga.s lhs
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0007: ldarg.1
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::PermuteVar(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0012: stloc.0
    IL_0013: ldloca.s V_0
    IL_0015: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_001A: ret

}
Vec256<double> permute(Vec256<double> lhs, in Vec256<long> control)
{
    IL_0000: ldarga.s lhs
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0007: ldarg.1
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::PermuteVar(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0012: stloc.0
    IL_0013: ldloca.s V_0
    IL_0015: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_001A: ret

}
Vec256<long> permute4x64(in Vec256<long> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0014: ret

}
Vec256<ulong> permute4x64(in Vec256<ulong> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0014: ret

}
Vec256<double> permute4x64(in Vec256<double> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0014: ret

}
Vec256<sbyte> permute2x128(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Byte)
    IL_0012: stloc.0
    IL_0013: ldloca.s V_0
    IL_0015: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_001A: ret

}
Vec256<byte> permute2x128(in Vec256<byte> lhs, in Vec256<byte> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0012: stloc.0
    IL_0013: ldloca.s V_0
    IL_0015: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_001A: ret

}
Vec256<short> permute2x128(in Vec256<short> lhs, in Vec256<short> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0012: stloc.0
    IL_0013: ldloca.s V_0
    IL_0015: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_001A: ret

}
Vec256<ushort> permute2x128(in Vec256<ushort> lhs, in Vec256<ushort> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0012: stloc.0
    IL_0013: ldloca.s V_0
    IL_0015: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_001A: ret

}
Vec256<int> permute2x128(in Vec256<int> lhs, in Vec256<int> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0012: stloc.0
    IL_0013: ldloca.s V_0
    IL_0015: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_001A: ret

}
Vec256<uint> permute2x128(in Vec256<uint> lhs, in Vec256<uint> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0012: stloc.0
    IL_0013: ldloca.s V_0
    IL_0015: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_001A: ret

}
Vec256<long> permute2x128(in Vec256<long> lhs, in Vec256<long> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0012: stloc.0
    IL_0013: ldloca.s V_0
    IL_0015: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_001A: ret

}
Vec256<ulong> permute2x128(in Vec256<ulong> lhs, in Vec256<ulong> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0012: stloc.0
    IL_0013: ldloca.s V_0
    IL_0015: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_001A: ret

}
Vec256<float> permute2x128(in Vec256<float> lhs, in Vec256<float> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Byte)
    IL_0012: stloc.0
    IL_0013: ldloca.s V_0
    IL_0015: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_001A: ret

}
Vec256<double> permute2x128(in Vec256<double> lhs, in Vec256<double> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_0012: stloc.0
    IL_0013: ldloca.s V_0
    IL_0015: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_001A: ret

}
Vec256<int> permute8x32(in Vec256<int> src, in Vec256<int> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: ret

}
Vec256<uint> permute8x32(in Vec256<uint> src, in Vec256<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: ret

}
Vec256<float> permute8x32(in Vec256<float> src, in Vec256<int> control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: ret

}
Vec256<int> reverse(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldsflda Z0.Vec256`1<System.Int32> Z0.dinx::Reverse256i32Control
    IL_0006: call Z0.Vec256`1<System.Int32> Z0.dinx::permute8x32(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_000B: ret

}
Vec256<uint> reverse(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldsflda Z0.Vec256`1<System.UInt32> Z0.dinx::Reverse256u32Control
    IL_0006: call Z0.Vec256`1<System.UInt32> Z0.dinx::permute8x32(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_000B: ret

}
Vec256<float> reverse(in Vec256<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldsflda Z0.Vec256`1<System.Int32> Z0.dinx::Reverse256f32Control
    IL_0006: call Z0.Vec256`1<System.Single> Z0.dinx::permute8x32(Z0.Vec256`1<System.Single>&,Z0.Vec256`1<System.Int32>&)
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
Vec256<int> shuffle(in Vec256<int> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0014: ret

}
Vec256<uint> shuffle(in Vec256<uint> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0014: ret

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
Vec128<short> shuffleLow(in Vec128<short> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> shuffleLow(in Vec128<ushort> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
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
Vec256<byte> shuffle(in Vec256<byte> src, in Vec256<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: ret

}
Vec256<sbyte> shuffle(in Vec256<sbyte> src, in Vec256<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: ret

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
void store(in Vec128<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.SByte* Z0.As::refptr(System.SByte&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.SByte>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Sse2::Store(System.SByte*,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
void store(in Vec128<byte> src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Byte* Z0.As::refptr(System.Byte&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Byte>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Sse2::Store(System.Byte*,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
void store(in Vec128<short> src, ref short dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int16* Z0.As::refptr(System.Int16&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Int16>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Sse2::Store(System.Int16*,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
void store(in Vec128<ushort> src, ref ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt16* Z0.As::refptr(System.UInt16&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.UInt16>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Sse2::Store(System.UInt16*,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
void store(in Vec128<int> src, ref int dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Int32>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Sse2::Store(System.Int32*,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
void store(in Vec128<uint> src, ref uint dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.UInt32>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Sse2::Store(System.UInt32*,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
void store(in Vec128<long> src, ref long dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Int64>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Sse2::Store(System.Int64*,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
void store(in Vec128<ulong> src, ref ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.UInt64>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Sse2::Store(System.UInt64*,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
void store(in Vec128<float> src, ref float dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Single* Z0.As::refptr(System.Single&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Single>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Sse::Store(System.Single*,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0016: ret

}
void store(in Vec128<double> src, ref double dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Double* Z0.As::refptr(System.Double&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Double>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0011: call System.Void System.Runtime.Intrinsics.X86.Sse2::Store(System.Double*,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0016: ret

}
void store(in Vec256<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.SByte* Z0.As::refptr(System.SByte&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.SByte*,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: ret

}
void store(in Vec256<byte> src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Byte* Z0.As::refptr(System.Byte&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.Byte*,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: ret

}
void store(in Vec256<short> src, ref short dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int16* Z0.As::refptr(System.Int16&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.Int16*,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: ret

}
void store(in Vec256<ushort> src, ref ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt16* Z0.As::refptr(System.UInt16&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.UInt16*,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: ret

}
void store(in Vec256<int> src, ref int dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.Int32*,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
void store(in Vec256<uint> src, ref uint dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.UInt32*,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ret

}
void store(in Vec256<long> src, ref long dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.Int64*,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: ret

}
void store(in Vec256<ulong> src, ref ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.UInt64*,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: ret

}
void store(in Vec256<float> src, ref float dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Single* Z0.As::refptr(System.Single&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.Single*,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: ret

}
void store(in Vec256<double> src, ref double dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Double* Z0.As::refptr(System.Double&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.Double*,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: ret

}
Vec256<uint> swap(Vec256<uint> src, byte i, byte j)
{
    IL_0000: ldsfld System.Int32 Z0.Vec256`1<System.UInt32>::Length
    IL_0005: stloc.1
    IL_0006: ldloc.1
    IL_0007: conv.u
    IL_0008: ldc.i4.4
    IL_0009: mul.ovf.un
    IL_000A: localloc
    IL_000C: ldloc.1
    IL_000D: newobj System.Void System.Span`1<System.UInt32>::.ctor(System.Void*,System.Int32)
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
    IL_0020: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0025: ldarg.2
    IL_0026: stind.i4
    IL_0027: br.s IL_0043
    IL_0029: ldloc.3
    IL_002A: ldarg.2
    IL_002B: bne.un.s IL_0039
    IL_002D: ldloca.s V_0
    IL_002F: ldloc.3
    IL_0030: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0035: ldarg.1
    IL_0036: stind.i4
    IL_0037: br.s IL_0043
    IL_0039: ldloca.s V_0
    IL_003B: ldloc.3
    IL_003C: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0041: ldloc.3
    IL_0042: stind.i4
    IL_0043: ldloc.3
    IL_0044: ldc.i4.1
    IL_0045: add
    IL_0046: conv.u1
    IL_0047: stloc.3
    IL_0048: ldloc.3
    IL_0049: ldloca.s V_0
    IL_004B: call System.Int32 System.Span`1<System.UInt32>::get_Length()
    IL_0050: blt.s IL_0019
    IL_0052: ldarga.s src
    IL_0054: ldloca.s V_0
    IL_0056: ldc.i4.0
    IL_0057: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_005C: call Z0.Vec256`1<System.UInt32> Z0.Vec256::load<System.UInt32>(System.UInt32&)
    IL_0061: stloc.s V_4
    IL_0063: ldloca.s V_4
    IL_0065: call Z0.Vec256`1<System.UInt32> Z0.dinx::permute8x32(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_006A: ret

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
    IL_0054: ldloca.s V_0
    IL_0056: ldc.i4.0
    IL_0057: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_005C: call Z0.Vec256`1<System.Int32> Z0.Vec256::load<System.Int32>(System.Int32&)
    IL_0061: stloc.s V_4
    IL_0063: ldloca.s V_4
    IL_0065: call Z0.Vec256`1<System.Int32> Z0.dinx::permute8x32(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_006A: ret

}
void subh(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::HorizontalSubtract(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_0022: ret

}
void subh(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::HorizontalSubtract(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_0022: ret

}
void subh(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::HorizontalSubtract(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Single>&,System.Single&)
    IL_0022: ret

}
void subh(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::HorizontalSubtract(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Double>&,System.Double&)
    IL_0022: ret

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
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: ret

}
Vec256<sbyte> subs(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: ret

}
Vec256<short> subs(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: ret

}
Vec256<ushort> subs(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: ret

}
ref Vec256<sbyte> broadcast(in sbyte src, out Vec256<sbyte> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.SByte& Z0.As::asRef<System.SByte>(System.SByte&)
    IL_0007: call System.SByte* Z0.As::refptr(System.SByte&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.SByte*)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: stobj Z0.Vec256`1<System.SByte>
    IL_001E: ldarg.1
    IL_001F: ret

}
ref Vec256<byte> broadcast(in byte src, out Vec256<byte> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Byte& Z0.As::asRef<System.Byte>(System.Byte&)
    IL_0007: call System.Byte* Z0.As::refptr(System.Byte&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.Byte*)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: stobj Z0.Vec256`1<System.Byte>
    IL_001E: ldarg.1
    IL_001F: ret

}
ref Vec256<short> broadcast(in short src, out Vec256<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int16& Z0.As::asRef<System.Int16>(System.Int16&)
    IL_0007: call System.Int16* Z0.As::refptr(System.Int16&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.Int16*)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: stobj Z0.Vec256`1<System.Int16>
    IL_001E: ldarg.1
    IL_001F: ret

}
ref Vec256<ushort> broadcast(in ushort src, out Vec256<ushort> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt16& Z0.As::asRef<System.UInt16>(System.UInt16&)
    IL_0007: call System.UInt16* Z0.As::refptr(System.UInt16&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.UInt16*)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: stobj Z0.Vec256`1<System.UInt16>
    IL_001E: ldarg.1
    IL_001F: ret

}
ref Vec256<int> broadcast(in int src, out Vec256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int32& Z0.As::asRef<System.Int32>(System.Int32&)
    IL_0007: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.Int32*)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: stobj Z0.Vec256`1<System.Int32>
    IL_001E: ldarg.1
    IL_001F: ret

}
ref Vec256<uint> broadcast(in uint src, out Vec256<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt32& Z0.As::asRef<System.UInt32>(System.UInt32&)
    IL_0007: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.UInt32*)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: stobj Z0.Vec256`1<System.UInt32>
    IL_001E: ldarg.1
    IL_001F: ret

}
ref Vec256<long> broadcast(in long src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int64& Z0.As::asRef<System.Int64>(System.Int64&)
    IL_0007: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.Int64*)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: stobj Z0.Vec256`1<System.Int64>
    IL_001E: ldarg.1
    IL_001F: ret

}
ref Vec256<ulong> broadcast(in ulong src, out Vec256<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt64& Z0.As::asRef<System.UInt64>(System.UInt64&)
    IL_0007: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.UInt64*)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: stobj Z0.Vec256`1<System.UInt64>
    IL_001E: ldarg.1
    IL_001F: ret

}
ref Vec256<float> broadcast(in float src, out Vec256<float> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Single& Z0.As::asRef<System.Single>(System.Single&)
    IL_0007: call System.Single* Z0.As::refptr(System.Single&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::BroadcastScalarToVector256(System.Single*)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: stobj Z0.Vec256`1<System.Single>
    IL_001E: ldarg.1
    IL_001F: ret

}
ref Vec256<double> broadcast(in double src, out Vec256<double> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Double& Z0.As::asRef<System.Double>(System.Double&)
    IL_0007: call System.Double* Z0.As::refptr(System.Double&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::BroadcastScalarToVector256(System.Double*)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: stobj Z0.Vec256`1<System.Double>
    IL_001E: ldarg.1
    IL_001F: ret

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
    IL_0005: call Z0.Vec128`1<System.Double> Z0.Vec128::define(System.Double,System.Double)
    IL_000A: stobj Z0.Vec128`1<System.Double>
    IL_000F: ldarg.1
    IL_0010: ret

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
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: ret

}
Vec256<sbyte> hi(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: ret

}
Vec256<short> hi(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: ret

}
Vec256<ushort> hi(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: ret

}
Vec256<int> hi(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: ret

}
Vec256<uint> hi(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: ret

}
Vec256<long> hi(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: ret

}
Vec256<ulong> hi(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: ret

}
Vec256<float> hi(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: ret

}
Vec256<double> hi(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: ret

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
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Byte)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_001F: ret

}
Vec256<byte> insert(in Vec128<byte> src, in Vec256<byte> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Byte>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0011: ldarg.2
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_001F: ret

}
Vec256<short> insert(in Vec128<short> src, in Vec256<short> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Int16>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0011: ldarg.2
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_001F: ret

}
Vec256<ushort> insert(in Vec128<ushort> src, in Vec256<ushort> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.UInt16>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0011: ldarg.2
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_001F: ret

}
Vec256<int> insert(in Vec128<int> src, in Vec256<int> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Int32>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0011: ldarg.2
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_001F: ret

}
Vec256<uint> insert(in Vec128<uint> src, in Vec256<uint> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.UInt32>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0011: ldarg.2
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_001F: ret

}
Vec256<long> insert(in Vec128<long> src, in Vec256<long> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.Int64>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0011: ldarg.2
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_001F: ret

}
Vec256<ulong> insert(in Vec128<ulong> src, in Vec256<ulong> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.0
    IL_0007: ldobj Z0.Vec128`1<System.UInt64>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0011: ldarg.2
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_001F: ret

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
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_001F: ret

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
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_001F: ret

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
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: ret

}
Vec256<sbyte> lo(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: ret

}
Vec256<short> lo(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: ret

}
Vec256<ushort> lo(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: ret

}
Vec256<int> lo(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: ret

}
Vec256<uint> lo(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: ret

}
Vec256<long> lo(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: ret

}
Vec256<ulong> lo(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: ret

}
Vec256<float> lo(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: ret

}
Vec256<double> lo(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: ret

}
ref Vec128<sbyte> loadDqu(in sbyte src, out Vec128<sbyte> dst)
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
ref Vec128<byte> loadDqu(in byte src, out Vec128<byte> dst)
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
ref Vec128<short> loadDqu(in short src, out Vec128<short> dst)
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
ref Vec128<ushort> loadDqu(in ushort src, out Vec128<ushort> dst)
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
ref Vec128<int> loadDqu(in int src, out Vec128<int> dst)
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
ref Vec128<uint> loadDqu(in uint src, out Vec128<uint> dst)
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
ref Vec128<long> loadDqu(in long src, out Vec128<long> dst)
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
ref Vec128<ulong> loadDqu(in ulong src, out Vec128<ulong> dst)
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
ref Vec256<sbyte> loadDqu(in sbyte src, out Vec256<sbyte> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.SByte* Z0.As::constptr(System.SByte&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.SByte*)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0014: stobj Z0.Vec256`1<System.SByte>
    IL_0019: ldarg.1
    IL_001A: ret

}
ref Vec256<byte> loadDqu(in byte src, out Vec256<byte> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Byte* Z0.As::constptr(System.Byte&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Byte*)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0014: stobj Z0.Vec256`1<System.Byte>
    IL_0019: ldarg.1
    IL_001A: ret

}
ref Vec256<short> loadDqu(in short src, out Vec256<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int16* Z0.As::constptr(System.Int16&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Int16*)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0014: stobj Z0.Vec256`1<System.Int16>
    IL_0019: ldarg.1
    IL_001A: ret

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
    IL_0011: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0016: stloc.0
    IL_0017: ldloca.s V_0
    IL_0019: ldarg.2
    IL_001A: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_001F: ret

}
void div(in Num128<double> lhs, in Num128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::DivideScalar(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0016: stloc.0
    IL_0017: ldloca.s V_0
    IL_0019: ldarg.2
    IL_001A: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_001F: ret

}
void mul(uint lhs, uint rhs, out uint lo, out uint hi)
{
    IL_0000: ldarg.2
    IL_0001: ldc.i4.0
    IL_0002: stind.i4
    IL_0003: ldarg.3
    IL_0004: ldarg.0
    IL_0005: ldarg.1
    IL_0006: ldarg.2
    IL_0007: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_000C: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::MultiplyNoFlags(System.UInt32,System.UInt32,System.UInt32*)
    IL_0011: stind.i4
    IL_0012: ret

}
uint umulHi(uint lhs, uint rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldloca.s V_0
    IL_0006: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_000B: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::MultiplyNoFlags(System.UInt32,System.UInt32,System.UInt32*)
    IL_0010: ret

}
ulong umul64(uint lhs, uint rhs)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: ldloca.s V_0
    IL_0006: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_000B: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::MultiplyNoFlags(System.UInt32,System.UInt32,System.UInt32*)
    IL_0010: conv.u8
    IL_0011: ldc.i4.s 32
    IL_0013: shl
    IL_0014: ldloc.0
    IL_0015: conv.u8
    IL_0016: or
    IL_0017: ret

}
ref UInt128 umul128(ulong lhs, ulong rhs, out UInt128 dst)
{
    IL_0000: ldarg.2
    IL_0001: initobj Z0.UInt128
    IL_0007: ldarg.2
    IL_0008: ldarg.0
    IL_0009: ldarg.1
    IL_000A: ldarg.2
    IL_000B: ldflda System.UInt64 Z0.UInt128::lo
    IL_0010: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_0015: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi2/X64::MultiplyNoFlags(System.UInt64,System.UInt64,System.UInt64*)
    IL_001A: stfld System.UInt64 Z0.UInt128::hi
    IL_001F: ldarg.2
    IL_0020: ret

}
ulong umulHi(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldloca.s V_0
    IL_0004: call Z0.UInt128& Z0.dinx::umul128(System.UInt64,System.UInt64,Z0.UInt128&)
    IL_0009: ldfld System.UInt64 Z0.UInt128::hi
    IL_000E: ret

}
ulong umulLo(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldloca.s V_0
    IL_0004: call Z0.UInt128& Z0.dinx::umul128(System.UInt64,System.UInt64,Z0.UInt128&)
    IL_0009: ldfld System.UInt64 Z0.UInt128::lo
    IL_000E: ret

}
Vec256<ulong> vumul256(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldloca.s V_12
    IL_0004: call Z0.Vec1024`1<System.UInt32>& Z0.Vec1024::Merge(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&,Z0.Vec1024`1<System.UInt32>&)
    IL_0009: stloc.0
    IL_000A: ldloc.0
    IL_000B: ldc.i4.3
    IL_000C: call Z0.Vec256`1<System.UInt32>& Z0.Vec1024::At<System.UInt32>(Z0.Vec1024`1<System.UInt32>&,System.Int32)
    IL_0011: stloc.1
    IL_0012: ldloc.0
    IL_0013: ldc.i4.2
    IL_0014: call Z0.Vec256`1<System.UInt32>& Z0.Vec1024::At<System.UInt32>(Z0.Vec1024`1<System.UInt32>&,System.Int32)
    IL_0019: stloc.2
    IL_001A: ldloc.0
    IL_001B: ldc.i4.1
    IL_001C: call Z0.Vec256`1<System.UInt32>& Z0.Vec1024::At<System.UInt32>(Z0.Vec1024`1<System.UInt32>&,System.Int32)
    IL_0021: stloc.3
    IL_0022: ldloc.0
    IL_0023: ldc.i4.0
    IL_0024: call Z0.Vec256`1<System.UInt32>& Z0.Vec1024::At<System.UInt32>(Z0.Vec1024`1<System.UInt32>&,System.Int32)
    IL_0029: stloc.s V_4
    IL_002B: ldloc.1
    IL_002C: ldloc.s V_4
    IL_002E: call Z0.Vec256`1<System.UInt64> Z0.dinx::mul(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0033: stloc.s V_5
    IL_0035: ldloca.s V_5
    IL_0037: ldc.i4.s 32
    IL_0039: call Z0.Vec256`1<System.UInt64> Z0.dinx::shiftl(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_003E: stloc.s V_6
    IL_0040: ldloc.1
    IL_0041: ldloc.3
    IL_0042: call Z0.Vec256`1<System.UInt64> Z0.dinx::mul(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0047: stloc.s V_7
    IL_0049: ldloca.s V_7
    IL_004B: ldc.i4.s 32
    IL_004D: call Z0.Vec256`1<System.UInt64> Z0.dinx::shiftl(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0052: stloc.s V_8
    IL_0054: ldloc.2
    IL_0055: ldloc.s V_4
    IL_0057: call Z0.Vec256`1<System.UInt64> Z0.dinx::mul(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_005C: stloc.s V_9
    IL_005E: ldloca.s V_6
    IL_0060: ldloca.s V_8
    IL_0062: call Z0.Vec256`1<System.UInt64> Z0.dinx::add(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0067: stloc.s V_10
    IL_0069: ldloca.s V_9
    IL_006B: ldloca.s V_10
    IL_006D: call Z0.Vec256`1<System.UInt64> Z0.dinx::add(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0072: stloc.s V_11
    IL_0074: ldloc.s V_11
    IL_0076: ret

}
Vec128<long> clmul(in Vec128<long> lhs, in Vec128<long> rhs, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Pclmulqdq::CarrylessMultiply(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0021: ret

}
Vec128<ulong> clmul(in Vec128<ulong> lhs, in Vec128<ulong> rhs, byte control)
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
Vec128<float> mul(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Multiply(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> mul(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Multiply(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

}
Vec256<long> mul(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Multiply(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: ret

}
Vec256<ulong> mul(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Multiply(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: ret

}
Vec256<float> mul(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Multiply(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: ret

}
Vec256<double> mul(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Multiply(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: ret

}
void mul(in Vec128<int> lhs, in Vec128<int> rhs, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::Multiply(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int64>&,System.Int64&)
    IL_0029: ret

}
void mul(in Vec128<uint> lhs, in Vec128<uint> rhs, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Multiply(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt64>&,System.UInt64&)
    IL_0029: ret

}
void mul(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Multiply(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_0029: ret

}
void mul(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Multiply(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_0029: ret

}
void mul(in Vec256<int> lhs, in Vec256<int> rhs, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Multiply(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int64>&,System.Int64&)
    IL_0022: ret

}
void mul(in Vec256<uint> lhs, in Vec256<uint> rhs, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Multiply(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt64>&,System.UInt64&)
    IL_0022: ret

}
void mul(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Multiply(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Single>&,System.Single&)
    IL_0022: ret

}
void mul(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Multiply(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Double>&,System.Double&)
    IL_0022: ret

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
ref Vec128<float> mulAdd(ref Vec128<float> x, in Vec128<float> y, in Vec128<float> z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Single>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000C: ldarg.1
    IL_000D: ldobj Z0.Vec128`1<System.Single>
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0017: ldarg.2
    IL_0018: ldobj Z0.Vec128`1<System.Single>
    IL_001D: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0022: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Fma::MultiplyAdd(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0027: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_002C: stobj Z0.Vec128`1<System.Single>
    IL_0031: ldarg.0
    IL_0032: ret

}
ref Vec128<double> mulAdd(ref Vec128<double> x, in Vec128<double> y, in Vec128<double> z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Double>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000C: ldarg.1
    IL_000D: ldobj Z0.Vec128`1<System.Double>
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0017: ldarg.2
    IL_0018: ldobj Z0.Vec128`1<System.Double>
    IL_001D: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0022: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Fma::MultiplyAdd(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0027: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_002C: stobj Z0.Vec128`1<System.Double>
    IL_0031: ldarg.0
    IL_0032: ret

}
Vec128<float> mulAddNegated(in Vec128<float> x, in Vec128<float> y, in Vec128<float> z)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: ldarg.2
    IL_0017: ldobj Z0.Vec128`1<System.Single>
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0021: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Fma::MultiplyAddNegated(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0026: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_002B: ret

}
Vec128<double> mulAddNegated(in Vec128<double> x, in Vec128<double> y, in Vec128<double> z)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: ldarg.2
    IL_0017: ldobj Z0.Vec128`1<System.Double>
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0021: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Fma::MultiplyAddNegated(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0026: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_002B: ret

}
Vec128<float> mulAddSub(in Vec128<float> x, in Vec128<float> y, in Vec128<float> z)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: ldarg.2
    IL_0017: ldobj Z0.Vec128`1<System.Single>
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0021: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Fma::MultiplyAddSubtract(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0026: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_002B: ret

}
Vec128<double> mulAddSub(in Vec128<double> x, in Vec128<double> y, in Vec128<double> z)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: ldarg.2
    IL_0017: ldobj Z0.Vec128`1<System.Double>
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0021: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Fma::MultiplyAddSubtract(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0026: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_002B: ret

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
Vec256<float> mulAdd(in Vec256<float> x, in Vec256<float> y, in Vec256<float> z)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Fma::MultiplyAdd(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_001F: ret

}
Vec256<double> mulAdd(in Vec256<double> x, in Vec256<double> y, in Vec256<double> z)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Fma::MultiplyAdd(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_001F: ret

}
Vec256<float> mulAddNegated(in Vec256<float> x, in Vec256<float> y, in Vec256<float> z)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Fma::MultiplyAddNegated(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_001F: ret

}
Vec256<double> mulAddNegated(in Vec256<double> x, in Vec256<double> y, in Vec256<double> z)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Fma::MultiplyAddNegated(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_001F: ret

}
Vec256<float> mulAddSub(in Vec256<float> x, in Vec256<float> y, in Vec256<float> z)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Fma::MultiplyAddSubtract(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_001F: ret

}
Vec256<double> mulAddSub(in Vec256<double> x, in Vec256<double> y, in Vec256<double> z)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Fma::MultiplyAddSubtract(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_001F: ret

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
    IL_0001: call Z0.Vec128`1<System.Byte> Z0.dinx::flip(Z0.Vec128`1<System.Byte>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldsflda Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::Ones
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
    IL_0001: call Z0.Vec128`1<System.UInt16> Z0.dinx::flip(Z0.Vec128`1<System.UInt16>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldsflda Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::Ones
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
    IL_0001: call Z0.Vec128`1<System.UInt32> Z0.dinx::flip(Z0.Vec128`1<System.UInt32>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldsflda Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::Ones
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
    IL_0001: call Z0.Vec128`1<System.UInt64> Z0.dinx::flip(Z0.Vec128`1<System.UInt64>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldsflda Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::Ones
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
    IL_0001: call Z0.Vec256`1<System.Byte> Z0.dinx::flip(Z0.Vec256`1<System.Byte>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldsflda Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::Ones
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
    IL_0001: call Z0.Vec256`1<System.UInt16> Z0.dinx::flip(Z0.Vec256`1<System.UInt16>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldsflda Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::Ones
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
    IL_0001: call Z0.Vec256`1<System.UInt32> Z0.dinx::flip(Z0.Vec256`1<System.UInt32>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldsflda Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::Ones
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
    IL_0001: call Z0.Vec256`1<System.UInt64> Z0.dinx::flip(Z0.Vec256`1<System.UInt64>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldsflda Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::Ones
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
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: ret

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
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: ret

}
Vec256<short> sign(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Sign(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: ret

}
Vec256<int> sign(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Sign(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: ret

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
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: ret

}
Vec256<sbyte> sub(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: ret

}
Vec256<short> sub(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: ret

}
Vec256<ushort> sub(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: ret

}
Vec256<int> sub(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: ret

}
Vec256<uint> sub(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: ret

}
Vec256<long> sub(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: ret

}
Vec256<ulong> sub(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: ret

}
Vec256<float> sub(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: ret

}
Vec256<double> sub(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: ret

}
void sub(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.SByte>&,System.SByte&)
    IL_0029: ret

}
void sub(in Vec128<byte> lhs, in Vec128<byte> rhs, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Byte>&,System.Byte&)
    IL_0029: ret

}
void sub(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_0029: ret

}
void sub(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt16>&,System.UInt16&)
    IL_0029: ret

}
void sub(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_0029: ret

}
void sub(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_0029: ret

}
void sub(in Vec128<long> lhs, in Vec128<long> rhs, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int64>&,System.Int64&)
    IL_0029: ret

}
void sub(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt64>&,System.UInt64&)
    IL_0029: ret

}
void sub(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Single> Z0.dinx::sub(Z0.Vec128`1<System.Single>&,Z0.Vec128`1<System.Single>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_0010: ret

}
void sub(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Double> Z0.dinx::sub(Z0.Vec128`1<System.Double>&,Z0.Vec128`1<System.Double>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_0010: ret

}
void sub(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.SByte>&,System.SByte&)
    IL_0022: ret

}
void sub(in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Byte>&,System.Byte&)
    IL_0022: ret

}
void sub(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_0022: ret

}
void sub(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_0022: ret

}
void sub(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_0022: ret

}
void sub(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_0022: ret

}
void sub(in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int64>&,System.Int64&)
    IL_0022: ret

}
void sub(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt64>&,System.UInt64&)
    IL_0022: ret

}
void sub(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Single>&,System.Single&)
    IL_0022: ret

}
void sub(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Double>&,System.Double&)
    IL_0022: ret

}
void sub(in Num128<float> lhs, in Num128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::SubtractScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0016: stloc.0
    IL_0017: ldloca.s V_0
    IL_0019: ldarg.2
    IL_001A: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_001F: ret

}
void sub(in Num128<double> lhs, in Num128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::SubtractScalar(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0016: stloc.0
    IL_0017: ldloca.s V_0
    IL_0019: ldarg.2
    IL_001A: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_001F: ret

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
Vec128<short> subh(in Vec128<short> lhs, in Vec128<short> rhs)
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
Vec128<int> subh(in Vec128<int> lhs, in Vec128<int> rhs)
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
Vec128<float> subh(in Vec128<float> lhs, in Vec128<float> rhs)
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
Vec128<double> subh(in Vec128<double> lhs, in Vec128<double> rhs)
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
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: ret

}
Vec256<int> subh(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::HorizontalSubtract(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: ret

}
Vec256<float> subh(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::HorizontalSubtract(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: ret

}
Vec256<double> subh(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::HorizontalSubtract(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: ret

}
void subh(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Ssse3::HorizontalSubtract(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_0029: ret

}
void subh(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Ssse3::HorizontalSubtract(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_0029: ret

}
void subh(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse3::HorizontalSubtract(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_0029: ret

}
void subh(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse3::HorizontalSubtract(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_0029: ret

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
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: ret

}
Vec256<sbyte> max(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: ret

}
Vec256<short> max(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: ret

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
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: ret

}
Vec256<int> max(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: ret

}
Vec256<uint> max(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: ret

}
Vec256<float> max(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Max(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: ret

}
Vec256<double> max(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Max(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: ret

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
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: ret

}
Vec256<sbyte> min(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: ret

}
Vec256<short> min(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: ret

}
Vec256<ushort> min(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: ret

}
Vec256<int> min(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: ret

}
Vec256<uint> min(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: ret

}
Vec256<float> min(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Min(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: ret

}
Vec256<double> min(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Min(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
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
Vec256<byte> abs(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0013: ret

}
Vec256<ushort> abs(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0013: ret

}
Vec256<uint> abs(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0013: ret

}
void abs(in Vec128<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::Abs(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0010: pop
    IL_0011: ret

}
void abs(in Vec128<short> src, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Ssse3::Abs(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0010: pop
    IL_0011: ret

}
void abs(in Vec128<int> src, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Ssse3::Abs(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0010: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0015: stloc.0
    IL_0016: ldloca.s V_0
    IL_0018: ldarg.1
    IL_0019: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_001E: ret

}
void abs(in Vec256<sbyte> src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0013: stloc.1
    IL_0014: ldloca.s V_1
    IL_0016: ldarg.1
    IL_0017: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Byte>&,System.Byte&)
    IL_001C: ret

}
void abs(in Vec256<short> src, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0013: stloc.1
    IL_0014: ldloca.s V_1
    IL_0016: ldarg.1
    IL_0017: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_001C: ret

}
void abs(in Vec256<int> src, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0013: stloc.1
    IL_0014: ldloca.s V_1
    IL_0016: ldarg.1
    IL_0017: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_001C: ret

}
Span128<byte> abs(in Span128<sbyte> src, Span128<byte> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_003D
    IL_0004: ldarg.0
    IL_0005: ldobj Z0.Span128`1<System.SByte>
    IL_000A: stloc.2
    IL_000B: ldloca.s V_2
    IL_000D: ldloc.0
    IL_000E: call System.SByte& Z0.Span128`1<System.SByte>::Block(System.Int32)
    IL_0013: call Z0.Vec128`1<System.SByte> Z0.Vec128::load<System.SByte>(System.SByte&)
    IL_0018: stloc.1
    IL_0019: ldloc.1
    IL_001A: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_001F: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::Abs(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0024: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0029: stloc.3
    IL_002A: ldloca.s V_3
    IL_002C: ldarga.s dst
    IL_002E: ldloc.0
    IL_002F: call System.Byte& Z0.Span128`1<System.Byte>::get_Item(System.Int32)
    IL_0034: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Byte>&,System.Byte&)
    IL_0039: ldloc.0
    IL_003A: ldc.i4.1
    IL_003B: add
    IL_003C: stloc.0
    IL_003D: ldloc.0
    IL_003E: ldarg.0
    IL_003F: ldobj Z0.Span128`1<System.SByte>
    IL_0044: stloc.2
    IL_0045: ldloca.s V_2
    IL_0047: call System.Int32 Z0.Span128`1<System.SByte>::get_BlockCount()
    IL_004C: blt.s IL_0004
    IL_004E: ldarg.1
    IL_004F: ret

}
Span128<ushort> abs(in Span128<short> src, Span128<ushort> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_003D
    IL_0004: ldarg.0
    IL_0005: ldobj Z0.Span128`1<System.Int16>
    IL_000A: stloc.2
    IL_000B: ldloca.s V_2
    IL_000D: ldloc.0
    IL_000E: call System.Int16& Z0.Span128`1<System.Int16>::Block(System.Int32)
    IL_0013: call Z0.Vec128`1<System.Int16> Z0.Vec128::load<System.Int16>(System.Int16&)
    IL_0018: stloc.1
    IL_0019: ldloc.1
    IL_001A: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_001F: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Ssse3::Abs(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0024: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0029: stloc.3
    IL_002A: ldloca.s V_3
    IL_002C: ldarga.s dst
    IL_002E: ldloc.0
    IL_002F: call System.UInt16& Z0.Span128`1<System.UInt16>::get_Item(System.Int32)
    IL_0034: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt16>&,System.UInt16&)
    IL_0039: ldloc.0
    IL_003A: ldc.i4.1
    IL_003B: add
    IL_003C: stloc.0
    IL_003D: ldloc.0
    IL_003E: ldarg.0
    IL_003F: ldobj Z0.Span128`1<System.Int16>
    IL_0044: stloc.2
    IL_0045: ldloca.s V_2
    IL_0047: call System.Int32 Z0.Span128`1<System.Int16>::get_BlockCount()
    IL_004C: blt.s IL_0004
    IL_004E: ldarg.1
    IL_004F: ret

}
Span128<uint> abs(in Span128<int> src, Span128<uint> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_003D
    IL_0004: ldarg.0
    IL_0005: ldobj Z0.Span128`1<System.Int32>
    IL_000A: stloc.2
    IL_000B: ldloca.s V_2
    IL_000D: ldloc.0
    IL_000E: call System.Int32& Z0.Span128`1<System.Int32>::Block(System.Int32)
    IL_0013: call Z0.Vec128`1<System.Int32> Z0.Vec128::load<System.Int32>(System.Int32&)
    IL_0018: stloc.1
    IL_0019: ldloc.1
    IL_001A: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_001F: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Ssse3::Abs(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0024: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0029: stloc.3
    IL_002A: ldloca.s V_3
    IL_002C: ldarga.s dst
    IL_002E: ldloc.0
    IL_002F: call System.UInt32& Z0.Span128`1<System.UInt32>::get_Item(System.Int32)
    IL_0034: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_0039: ldloc.0
    IL_003A: ldc.i4.1
    IL_003B: add
    IL_003C: stloc.0
    IL_003D: ldloc.0
    IL_003E: ldarg.0
    IL_003F: ldobj Z0.Span128`1<System.Int32>
    IL_0044: stloc.2
    IL_0045: ldloca.s V_2
    IL_0047: call System.Int32 Z0.Span128`1<System.Int32>::get_BlockCount()
    IL_004C: blt.s IL_0004
    IL_004E: ldarg.1
    IL_004F: ret

}
Span256<byte> abs(in Span256<sbyte> src, Span256<byte> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0042
    IL_0004: ldarg.0
    IL_0005: ldobj Z0.Span256`1<System.SByte>
    IL_000A: stloc.2
    IL_000B: ldloca.s V_2
    IL_000D: ldloc.0
    IL_000E: call System.SByte& Z0.Span256`1<System.SByte>::Block(System.Int32)
    IL_0013: call Z0.Vec256`1<System.SByte> Z0.Vec256::load<System.SByte>(System.SByte&)
    IL_0018: stloc.1
    IL_0019: ldloca.s V_1
    IL_001B: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0020: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0025: stloc.3
    IL_0026: ldloca.s V_3
    IL_0028: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_002D: stloc.s V_4
    IL_002F: ldloca.s V_4
    IL_0031: ldarga.s dst
    IL_0033: ldloc.0
    IL_0034: call System.Byte& Z0.Span256`1<System.Byte>::get_Item(System.Int32)
    IL_0039: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Byte>&,System.Byte&)
    IL_003E: ldloc.0
    IL_003F: ldc.i4.1
    IL_0040: add
    IL_0041: stloc.0
    IL_0042: ldloc.0
    IL_0043: ldarg.0
    IL_0044: ldobj Z0.Span256`1<System.SByte>
    IL_0049: stloc.2
    IL_004A: ldloca.s V_2
    IL_004C: call System.Int32 Z0.Span256`1<System.SByte>::get_BlockCount()
    IL_0051: blt.s IL_0004
    IL_0053: ldarg.1
    IL_0054: ret

}
Span256<ushort> abs(in Span256<short> src, Span256<ushort> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0042
    IL_0004: ldarg.0
    IL_0005: ldobj Z0.Span256`1<System.Int16>
    IL_000A: stloc.2
    IL_000B: ldloca.s V_2
    IL_000D: ldloc.0
    IL_000E: call System.Int16& Z0.Span256`1<System.Int16>::Block(System.Int32)
    IL_0013: call Z0.Vec256`1<System.Int16> Z0.Vec256::load<System.Int16>(System.Int16&)
    IL_0018: stloc.1
    IL_0019: ldloca.s V_1
    IL_001B: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0020: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0025: stloc.3
    IL_0026: ldloca.s V_3
    IL_0028: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_002D: stloc.s V_4
    IL_002F: ldloca.s V_4
    IL_0031: ldarga.s dst
    IL_0033: ldloc.0
    IL_0034: call System.UInt16& Z0.Span256`1<System.UInt16>::get_Item(System.Int32)
    IL_0039: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_003E: ldloc.0
    IL_003F: ldc.i4.1
    IL_0040: add
    IL_0041: stloc.0
    IL_0042: ldloc.0
    IL_0043: ldarg.0
    IL_0044: ldobj Z0.Span256`1<System.Int16>
    IL_0049: stloc.2
    IL_004A: ldloca.s V_2
    IL_004C: call System.Int32 Z0.Span256`1<System.Int16>::get_BlockCount()
    IL_0051: blt.s IL_0004
    IL_0053: ldarg.1
    IL_0054: ret

}
Span256<uint> abs(in Span256<int> src, Span256<uint> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0042
    IL_0004: ldarg.0
    IL_0005: ldobj Z0.Span256`1<System.Int32>
    IL_000A: stloc.2
    IL_000B: ldloca.s V_2
    IL_000D: ldloc.0
    IL_000E: call System.Int32& Z0.Span256`1<System.Int32>::Block(System.Int32)
    IL_0013: call Z0.Vec256`1<System.Int32> Z0.Vec256::load<System.Int32>(System.Int32&)
    IL_0018: stloc.1
    IL_0019: ldloca.s V_1
    IL_001B: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0020: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0025: stloc.3
    IL_0026: ldloca.s V_3
    IL_0028: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_002D: stloc.s V_4
    IL_002F: ldloca.s V_4
    IL_0031: ldarga.s dst
    IL_0033: ldloc.0
    IL_0034: call System.UInt32& Z0.Span256`1<System.UInt32>::get_Item(System.Int32)
    IL_0039: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_003E: ldloc.0
    IL_003F: ldc.i4.1
    IL_0040: add
    IL_0041: stloc.0
    IL_0042: ldloc.0
    IL_0043: ldarg.0
    IL_0044: ldobj Z0.Span256`1<System.Int32>
    IL_0049: stloc.2
    IL_004A: ldloca.s V_2
    IL_004C: call System.Int32 Z0.Span256`1<System.Int32>::get_BlockCount()
    IL_0051: blt.s IL_0004
    IL_0053: ldarg.1
    IL_0054: ret

}
void add(in Num128<float> lhs, in Num128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Num128`1<System.Single>::op_Implicit(Z0.Num128`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::AddScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0016: stloc.0
    IL_0017: ldloca.s V_0
    IL_0019: ldarg.2
    IL_001A: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_001F: ret

}
void add(in Num128<double> lhs, in Num128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Num128`1<System.Double>::op_Implicit(Z0.Num128`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::AddScalar(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0016: stloc.0
    IL_0017: ldloca.s V_0
    IL_0019: ldarg.2
    IL_001A: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_001F: ret

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
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: ret

}
Vec256<sbyte> add(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: ret

}
Vec256<short> add(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: ret

}
Vec256<ushort> add(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: ret

}
Vec256<int> add(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: ret

}
Vec256<uint> add(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: ret

}
Vec256<long> add(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: ret

}
Vec256<ulong> add(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: ret

}
Vec256<float> add(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Add(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: ret

}
Vec256<double> add(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Add(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: ret

}
void add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.SByte>&,System.SByte&)
    IL_0029: ret

}
void add(in Vec128<byte> lhs, in Vec128<byte> rhs, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Byte>&,System.Byte&)
    IL_0029: ret

}
void add(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_0029: ret

}
void add(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt16>&,System.UInt16&)
    IL_0029: ret

}
void add(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_0029: ret

}
void add(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_0029: ret

}
void add(in Vec128<long> lhs, in Vec128<long> rhs, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int64>&,System.Int64&)
    IL_0029: ret

}
void add(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt64>&,System.UInt64&)
    IL_0029: ret

}
void add(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Add(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_0029: ret

}
void add(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_0029: ret

}
void add(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.SByte>&,System.SByte&)
    IL_0022: ret

}
void add(in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Byte>&,System.Byte&)
    IL_0022: ret

}
void add(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_0022: ret

}
void add(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_0022: ret

}
void add(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_0022: ret

}
void add(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_0022: ret

}
void add(in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int64>&,System.Int64&)
    IL_0022: ret

}
void add(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt64>&,System.UInt64&)
    IL_0022: ret

}
void add(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Add(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Single>&,System.Single&)
    IL_0022: ret

}
void add(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Add(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Double>&,System.Double&)
    IL_0022: ret

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
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: ret

}
Vec256<int> addh(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::HorizontalAdd(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: ret

}
Vec256<float> addh(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::HorizontalAdd(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: ret

}
Vec256<double> addh(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::HorizontalAdd(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: ret

}
void addh(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Ssse3::HorizontalAdd(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_0029: ret

}
void addh(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Ssse3::HorizontalAdd(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_0029: ret

}
void addh(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse3::HorizontalAdd(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_0029: ret

}
void addh(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse3::HorizontalAdd(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_0029: ret

}
void addh(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::HorizontalAdd(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_0022: ret

}
void addh(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::HorizontalAdd(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_0022: ret

}
void addh(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::HorizontalAdd(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Single>&,System.Single&)
    IL_0022: ret

}
void addh(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::HorizontalAdd(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Double>&,System.Double&)
    IL_0022: ret

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
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: ret

}
Vec256<sbyte> adds(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: ret

}
Vec256<short> adds(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: ret

}
Vec256<ushort> adds(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: ret

}
Vec128<float> div(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Divide(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> div(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Divide(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

}
void div(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Divide(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_0029: ret

}
void div(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Divide(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_0029: ret

}
Vec256<float> div(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Divide(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: ret

}
Vec256<double> div(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Divide(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: ret

}
void div(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Divide(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Single>&,System.Single&)
    IL_0022: ret

}
void div(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Divide(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Double>&,System.Double&)
    IL_0022: ret

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
Vec256Cmp<sbyte> gt(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: call Z0.Vec256Cmp`1<System.SByte> Z0.Vec256Cmp::Define<System.SByte>(Z0.Vec256`1<System.SByte>)
    IL_001E: ret

}
Vec256Cmp<short> gt(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: call Z0.Vec256Cmp`1<System.Int16> Z0.Vec256Cmp::Define<System.Int16>(Z0.Vec256`1<System.Int16>)
    IL_001E: ret

}
Vec256Cmp<int> gt(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: call Z0.Vec256Cmp`1<System.Int32> Z0.Vec256Cmp::Define<System.Int32>(Z0.Vec256`1<System.Int32>)
    IL_001E: ret

}
Vec256Cmp<long> gt(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: call Z0.Vec256Cmp`1<System.Int64> Z0.Vec256Cmp::Define<System.Int64>(Z0.Vec256`1<System.Int64>)
    IL_001E: ret

}
Vec256Cmp<float> gt(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: ldc.i4.s 30
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Compare(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.X86.FloatComparisonMode)
    IL_0013: stloc.0
    IL_0014: ldloca.s V_0
    IL_0016: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_001B: call Z0.Vec256Cmp`1<System.Single> Z0.Vec256Cmp::Define<System.Single>(Z0.Vec256`1<System.Single>)
    IL_0020: ret

}
Vec256Cmp<double> gt(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: ldc.i4.s 30
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Compare(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.X86.FloatComparisonMode)
    IL_0013: stloc.0
    IL_0014: ldloca.s V_0
    IL_0016: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_001B: call Z0.Vec256Cmp`1<System.Double> Z0.Vec256Cmp::Define<System.Double>(Z0.Vec256`1<System.Double>)
    IL_0020: ret

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
Vec128Cmp<float> lt(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::CompareLessThan(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: call Z0.Vec128Cmp`1<System.Single> Z0.Vec128Cmp::Define<System.Single>(Z0.Vec128`1<System.Single>)
    IL_0025: ret

}
Vec128Cmp<double> lt(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::CompareLessThan(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: call Z0.Vec128Cmp`1<System.Double> Z0.Vec128Cmp::Define<System.Double>(Z0.Vec128`1<System.Double>)
    IL_0025: ret

}
Vec256Cmp<float> lt(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: ldc.i4.s 17
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Compare(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.X86.FloatComparisonMode)
    IL_0013: stloc.0
    IL_0014: ldloca.s V_0
    IL_0016: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_001B: call Z0.Vec256Cmp`1<System.Single> Z0.Vec256Cmp::Define<System.Single>(Z0.Vec256`1<System.Single>)
    IL_0020: ret

}
Vec256Cmp<double> lt(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: ldc.i4.s 17
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Compare(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.X86.FloatComparisonMode)
    IL_0013: stloc.0
    IL_0014: ldloca.s V_0
    IL_0016: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_001B: call Z0.Vec256Cmp`1<System.Double> Z0.Vec256Cmp::Define<System.Double>(Z0.Vec256`1<System.Double>)
    IL_0020: ret

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
Vec128<float> lteq(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::CompareLessThanOrEqual(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> lteq(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::CompareLessThanOrEqual(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

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
Vec128<float> neq(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::CompareNotEqual(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> neq(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::CompareNotEqual(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

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
Vec128<float> ngt(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::CompareNotGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: ret

}
Vec128<double> ngt(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::CompareNotGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: ret

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
Vec128<float> nlt(Vec128<float> lhs, Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::CompareNotLessThan(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0016: ret

}
Vec128<double> nlt(Vec128<double> lhs, Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::CompareNotLessThan(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0016: ret

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
bool nonzero(in Vec128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool nonzero(in Vec128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool nonzero(in Vec128<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool nonzero(in Vec128<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool nonzero(in Vec128<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool nonzero(in Vec128<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool nonzero(in Vec128<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool nonzero(in Vec128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool nonzero(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool nonzero(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool nonzero(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool nonzero(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool nonzero(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool nonzero(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool nonzero(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool nonzero(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
Vec128<short> convert(in Vec128<sbyte> src, out Vec128<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int16(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: dup
    IL_0017: stloc.0
    IL_0018: stobj Z0.Vec128`1<System.Int16>
    IL_001D: ldloc.0
    IL_001E: ret

}
Vec128<int> convert(in Vec128<sbyte> src, out Vec128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: dup
    IL_0017: stloc.0
    IL_0018: stobj Z0.Vec128`1<System.Int32>
    IL_001D: ldloc.0
    IL_001E: ret

}
Vec128<long> convert(in Vec128<sbyte> src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: dup
    IL_0017: stloc.0
    IL_0018: stobj Z0.Vec128`1<System.Int64>
    IL_001D: ldloc.0
    IL_001E: ret

}
Vec128<short> convert(in Vec128<byte> src, out Vec128<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: dup
    IL_0017: stloc.0
    IL_0018: stobj Z0.Vec128`1<System.Int16>
    IL_001D: ldloc.0
    IL_001E: ret

}
Vec128<int> convert(in Vec128<byte> src, out Vec128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: dup
    IL_0017: stloc.0
    IL_0018: stobj Z0.Vec128`1<System.Int32>
    IL_001D: ldloc.0
    IL_001E: ret

}
Vec128<long> convert(in Vec128<byte> src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: dup
    IL_0017: stloc.0
    IL_0018: stobj Z0.Vec128`1<System.Int64>
    IL_001D: ldloc.0
    IL_001E: ret

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
Vec128<long> convert(in Vec128<short> src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Int16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: dup
    IL_0017: stloc.0
    IL_0018: stobj Z0.Vec128`1<System.Int64>
    IL_001D: ldloc.0
    IL_001E: ret

}
Vec128<int> convert(in Vec128<ushort> src, out Vec128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: dup
    IL_0017: stloc.0
    IL_0018: stobj Z0.Vec128`1<System.Int32>
    IL_001D: ldloc.0
    IL_001E: ret

}
Vec128<long> convert(in Vec128<ushort> src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: dup
    IL_0017: stloc.0
    IL_0018: stobj Z0.Vec128`1<System.Int64>
    IL_001D: ldloc.0
    IL_001E: ret

}
Vec128<long> convert(in Vec128<int> src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Int32>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: dup
    IL_0017: stloc.0
    IL_0018: stobj Z0.Vec128`1<System.Int64>
    IL_001D: ldloc.0
    IL_001E: ret

}
Vec128<long> convert(in Vec128<uint> src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt32>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: dup
    IL_0017: stloc.0
    IL_0018: stobj Z0.Vec128`1<System.Int64>
    IL_001D: ldloc.0
    IL_001E: ret

}
Vec256<short> convert(in Vec128<sbyte> src, out Vec256<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int16(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: dup
    IL_001A: stloc.1
    IL_001B: stobj Z0.Vec256`1<System.Int16>
    IL_0020: ldloc.1
    IL_0021: ret

}
Vec256<int> convert(in Vec128<sbyte> src, out Vec256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: dup
    IL_001A: stloc.1
    IL_001B: stobj Z0.Vec256`1<System.Int32>
    IL_0020: ldloc.1
    IL_0021: ret

}
Vec256<long> convert(in Vec128<sbyte> src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: dup
    IL_001A: stloc.1
    IL_001B: stobj Z0.Vec256`1<System.Int64>
    IL_0020: ldloc.1
    IL_0021: ret

}
Vec256<short> convert(in Vec128<byte> src, out Vec256<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: dup
    IL_001A: stloc.1
    IL_001B: stobj Z0.Vec256`1<System.Int16>
    IL_0020: ldloc.1
    IL_0021: ret

}
Vec256<int> convert(in Vec128<byte> src, out Vec256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: dup
    IL_001A: stloc.1
    IL_001B: stobj Z0.Vec256`1<System.Int32>
    IL_0020: ldloc.1
    IL_0021: ret

}
Vec256<long> convert(in Vec128<byte> src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: dup
    IL_001A: stloc.1
    IL_001B: stobj Z0.Vec256`1<System.Int64>
    IL_0020: ldloc.1
    IL_0021: ret

}
Vec256<int> convert(in Vec128<short> src, out Vec256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Int16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: dup
    IL_001A: stloc.1
    IL_001B: stobj Z0.Vec256`1<System.Int32>
    IL_0020: ldloc.1
    IL_0021: ret

}
Vec256<long> convert(in Vec128<short> src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Int16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: dup
    IL_001A: stloc.1
    IL_001B: stobj Z0.Vec256`1<System.Int64>
    IL_0020: ldloc.1
    IL_0021: ret

}
Vec256<int> convert(in Vec128<ushort> src, out Vec256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: dup
    IL_001A: stloc.1
    IL_001B: stobj Z0.Vec256`1<System.Int32>
    IL_0020: ldloc.1
    IL_0021: ret

}
Vec256<long> convert(in Vec128<ushort> src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: dup
    IL_001A: stloc.1
    IL_001B: stobj Z0.Vec256`1<System.Int64>
    IL_0020: ldloc.1
    IL_0021: ret

}
Vec256<long> convert(in Vec128<int> src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Int32>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: dup
    IL_001A: stloc.1
    IL_001B: stobj Z0.Vec256`1<System.Int64>
    IL_0020: ldloc.1
    IL_0021: ret

}
Vec256<long> convert(in Vec128<uint> src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt32>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: dup
    IL_001A: stloc.1
    IL_001B: stobj Z0.Vec256`1<System.Int64>
    IL_0020: ldloc.1
    IL_0021: ret

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
Vec128<float> ceil(in Vec128<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse41::Ceiling(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0010: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0015: ret

}
Vec128<double> ceil(in Vec128<double> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse41::Ceiling(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0010: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0015: ret

}
Vec256<float> ceil(in Vec256<float> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Ceiling(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0013: ret

}
Vec256<double> ceil(in Vec256<double> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Ceiling(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0013: ret

}
void ceil(in Vec128<float> src, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse41::Ceiling(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0010: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0015: stloc.0
    IL_0016: ldloca.s V_0
    IL_0018: ldarg.1
    IL_0019: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_001E: ret

}
void ceil(in Vec128<double> src, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse41::Ceiling(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0010: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0015: stloc.0
    IL_0016: ldloca.s V_0
    IL_0018: ldarg.1
    IL_0019: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_001E: ret

}
void ceil(in Vec256<float> src, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Ceiling(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0013: stloc.1
    IL_0014: ldloca.s V_1
    IL_0016: ldarg.1
    IL_0017: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Single>&,System.Single&)
    IL_001C: ret

}
void ceil(in Vec256<double> src, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Ceiling(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0013: stloc.1
    IL_0014: ldloca.s V_1
    IL_0016: ldarg.1
    IL_0017: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Double>&,System.Double&)
    IL_001C: ret

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
Vec128<float> dot(Vec128<float> lhs, Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000C: ldc.i4.0
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse41::DotProduct(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0017: ret

}
Vec128<double> dot(Vec128<double> lhs, Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000C: ldc.i4.0
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse41::DotProduct(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0017: ret

}
Vec256<float> dot(Vec256<float> lhs, Vec256<float> rhs)
{
    IL_0000: ldarga.s lhs
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0007: ldarga.s rhs
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000E: ldc.i4.0
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::DotProduct(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Byte)
    IL_0014: stloc.0
    IL_0015: ldloca.s V_0
    IL_0017: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_001C: ret

}
void dot(Vec128<float> lhs, Vec128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000C: ldc.i4.0
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse41::DotProduct(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: ldarg.2
    IL_001B: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_0020: ret

}
void dot(Vec128<double> lhs, Vec128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000C: ldc.i4.0
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse41::DotProduct(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: ldarg.2
    IL_001B: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_0020: ret

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
    IL_0017: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_001C: stloc.1
    IL_001D: ldloca.s V_1
    IL_001F: ldarg.2
    IL_0020: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Single>&,System.Single&)
    IL_0025: ret

}
Vec128<float> floor(Vec128<float> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse41::Floor(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_000B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0010: ret

}
Vec128<double> floor(Vec128<double> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse41::Floor(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_000B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0010: ret

}
Vec256<float> floor(Vec256<float> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Floor(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0014: ret

}
Vec256<double> floor(Vec256<double> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Floor(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0014: ret

}
void floor(Vec128<float> src, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse41::Floor(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_000B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0010: stloc.0
    IL_0011: ldloca.s V_0
    IL_0013: ldarg.1
    IL_0014: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_0019: ret

}
void floor(Vec128<double> src, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse41::Floor(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_000B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0010: stloc.0
    IL_0011: ldloca.s V_0
    IL_0013: ldarg.1
    IL_0014: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_0019: ret

}
void floor(Vec256<float> src, ref float dst)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Floor(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0014: stloc.1
    IL_0015: ldloca.s V_1
    IL_0017: ldarg.1
    IL_0018: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Single>&,System.Single&)
    IL_001D: ret

}
void floor(Vec256<double> src, ref double dst)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Ceiling(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0014: stloc.1
    IL_0015: ldloca.s V_1
    IL_0017: ldarg.1
    IL_0018: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Double>&,System.Double&)
    IL_001D: ret

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
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0014: ret

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
Vec128<float> sqrt(in Vec128<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Sqrt(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0010: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0015: ret

}
Vec128<double> sqrt(in Vec128<double> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Sqrt(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0010: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0015: ret

}
Vec256<float> sqrt(in Vec256<float> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Sqrt(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0013: ret

}
Vec256<double> sqrt(in Vec256<double> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Sqrt(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0013: ret

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
Span256<double> sqrt(in Span256<double> src, Span256<double> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0042
    IL_0004: ldarg.0
    IL_0005: ldobj Z0.Span256`1<System.Double>
    IL_000A: stloc.2
    IL_000B: ldloca.s V_2
    IL_000D: ldloc.0
    IL_000E: call System.Double& Z0.Span256`1<System.Double>::Block(System.Int32)
    IL_0013: call Z0.Vec256`1<System.Double> Z0.Vec256::load<System.Double>(System.Double&)
    IL_0018: stloc.1
    IL_0019: ldloca.s V_1
    IL_001B: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0020: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Sqrt(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0025: stloc.3
    IL_0026: ldloca.s V_3
    IL_0028: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_002D: stloc.s V_4
    IL_002F: ldloca.s V_4
    IL_0031: ldarga.s dst
    IL_0033: ldloc.0
    IL_0034: call System.Double& Z0.Span256`1<System.Double>::get_Item(System.Int32)
    IL_0039: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Double>&,System.Double&)
    IL_003E: ldloc.0
    IL_003F: ldc.i4.1
    IL_0040: add
    IL_0041: stloc.0
    IL_0042: ldloc.0
    IL_0043: ldarg.0
    IL_0044: ldobj Z0.Span256`1<System.Double>
    IL_0049: stloc.2
    IL_004A: ldloca.s V_2
    IL_004C: call System.Int32 Z0.Span256`1<System.Double>::get_BlockCount()
    IL_0051: blt.s IL_0004
    IL_0053: ldarg.1
    IL_0054: ret

}
Span256<float> sqrt(in Span256<float> src, Span256<float> dst)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_0042
    IL_0004: ldarg.0
    IL_0005: ldobj Z0.Span256`1<System.Single>
    IL_000A: stloc.2
    IL_000B: ldloca.s V_2
    IL_000D: ldloc.0
    IL_000E: call System.Single& Z0.Span256`1<System.Single>::Block(System.Int32)
    IL_0013: call Z0.Vec256`1<System.Single> Z0.Vec256::load<System.Single>(System.Single&)
    IL_0018: stloc.1
    IL_0019: ldloca.s V_1
    IL_001B: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0020: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Sqrt(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0025: stloc.3
    IL_0026: ldloca.s V_3
    IL_0028: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_002D: stloc.s V_4
    IL_002F: ldloca.s V_4
    IL_0031: ldarga.s dst
    IL_0033: ldloc.0
    IL_0034: call System.Single& Z0.Span256`1<System.Single>::get_Item(System.Int32)
    IL_0039: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Single>&,System.Single&)
    IL_003E: ldloc.0
    IL_003F: ldc.i4.1
    IL_0040: add
    IL_0041: stloc.0
    IL_0042: ldloc.0
    IL_0043: ldarg.0
    IL_0044: ldobj Z0.Span256`1<System.Single>
    IL_0049: stloc.2
    IL_004A: ldloca.s V_2
    IL_004C: call System.Int32 Z0.Span256`1<System.Single>::get_BlockCount()
    IL_0051: blt.s IL_0004
    IL_0053: ldarg.1
    IL_0054: ret

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
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: ret

}
Vec256<ushort> avg(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Average(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: ret

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
Span256<uint> shiftr(ReadOnlySpan256<uint> lhs, byte count, Span256<uint> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span256`1<System.UInt32>::get_BlockWidth()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec256`1<System.UInt32> Z0.ginxs::LoadVec256<System.UInt32>(Z0.ReadOnlySpan256`1<System.UInt32>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: call Z0.Vec256`1<System.UInt32> Z0.dinx::shiftr(Z0.Vec256`1<System.UInt32>&,System.Byte)
    IL_001C: stloc.3
    IL_001D: ldloca.s V_3
    IL_001F: ldarga.s dst
    IL_0021: ldloc.1
    IL_0022: call System.UInt32& Z0.Span256`1<System.UInt32>::get_Item(System.Int32)
    IL_0027: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_002C: ldloc.1
    IL_002D: ldloc.0
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldarga.s lhs
    IL_0033: call System.Int32 Z0.ReadOnlySpan256`1<System.UInt32>::get_Length()
    IL_0038: blt.s IL_000C
    IL_003A: ldarg.2
    IL_003B: ret

}
Span256<long> shiftr(ReadOnlySpan256<long> lhs, byte count, Span256<long> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span256`1<System.Int64>::get_BlockWidth()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec256`1<System.Int64> Z0.ginxs::LoadVec256<System.Int64>(Z0.ReadOnlySpan256`1<System.Int64>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: call Z0.Vec256`1<System.Int64> Z0.dinx::shiftr(Z0.Vec256`1<System.Int64>&,System.Byte)
    IL_001C: stloc.3
    IL_001D: ldloca.s V_3
    IL_001F: ldarga.s dst
    IL_0021: ldloc.1
    IL_0022: call System.Int64& Z0.Span256`1<System.Int64>::get_Item(System.Int32)
    IL_0027: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int64>&,System.Int64&)
    IL_002C: ldloc.1
    IL_002D: ldloc.0
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldarga.s lhs
    IL_0033: call System.Int32 Z0.ReadOnlySpan256`1<System.Int64>::get_Length()
    IL_0038: blt.s IL_000C
    IL_003A: ldarg.2
    IL_003B: ret

}
Span256<ulong> shiftr(ReadOnlySpan256<ulong> lhs, byte count, Span256<ulong> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span256`1<System.UInt64>::get_BlockWidth()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec256`1<System.UInt64> Z0.ginxs::LoadVec256<System.UInt64>(Z0.ReadOnlySpan256`1<System.UInt64>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: call Z0.Vec256`1<System.UInt64> Z0.dinx::shiftr(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_001C: stloc.3
    IL_001D: ldloca.s V_3
    IL_001F: ldarga.s dst
    IL_0021: ldloc.1
    IL_0022: call System.UInt64& Z0.Span256`1<System.UInt64>::get_Item(System.Int32)
    IL_0027: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt64>&,System.UInt64&)
    IL_002C: ldloc.1
    IL_002D: ldloc.0
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldarga.s lhs
    IL_0033: call System.Int32 Z0.ReadOnlySpan256`1<System.UInt64>::get_Length()
    IL_0038: blt.s IL_000C
    IL_003A: ldarg.2
    IL_003B: ret

}
Vec128<short> shiftrw(in Vec128<short> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> shiftrw(in Vec128<ushort> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> shiftrw(in Vec128<int> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> shiftrw(in Vec128<uint> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> shiftrw(in Vec128<long> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> shiftrw(in Vec128<ulong> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<short> shiftrw(in Vec256<short> src, byte count)
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
Vec256<ushort> shiftrw(in Vec256<ushort> src, byte count)
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
Vec256<int> shiftrw(in Vec256<int> src, byte count)
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
Vec256<uint> shiftrw(in Vec256<uint> src, byte count)
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
Vec256<long> shiftrw(in Vec256<long> src, byte count)
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
Vec256<ulong> shiftrw(in Vec256<ulong> src, byte count)
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
    IL_0001: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128&)
    IL_000F: stloc.1
    IL_0010: ldloca.s V_1
    IL_0012: call Z0.Vec128`1<System.UInt64> Z0.dinx::xor(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0017: stloc.2
    IL_0018: ldloca.s V_2
    IL_001A: call Z0.UInt128 Z0.UInt128X::ToUInt128(Z0.Vec128`1<System.UInt64>&)
    IL_001F: ret

}
ref UInt128 xor(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.1
    IL_000B: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128&)
    IL_0010: stloc.1
    IL_0011: ldloca.s V_1
    IL_0013: call Z0.Vec128`1<System.UInt64> Z0.dinx::xor(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0018: stloc.2
    IL_0019: ldloca.s V_2
    IL_001B: call Z0.UInt128 Z0.UInt128X::ToUInt128(Z0.Vec128`1<System.UInt64>&)
    IL_0020: stobj Z0.UInt128
    IL_0025: ldarg.2
    IL_0026: ret

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
void xor(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.SByte>&,System.SByte&)
    IL_0029: ret

}
void xor(in Vec128<byte> lhs, in Vec128<byte> rhs, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Byte>&,System.Byte&)
    IL_0029: ret

}
void xor(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_0029: ret

}
void xor(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt16>&,System.UInt16&)
    IL_0029: ret

}
void xor(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_0029: ret

}
void xor(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_0029: ret

}
void xor(in Vec128<long> lhs, in Vec128<long> rhs, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int64>&,System.Int64&)
    IL_0029: ret

}
void xor(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt64>&,System.UInt64&)
    IL_0029: ret

}
void xor(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Xor(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_0029: ret

}
void xor(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_0029: ret

}
void xor(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.SByte>&,System.SByte&)
    IL_0022: ret

}
void xor(in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Byte>&,System.Byte&)
    IL_0022: ret

}
void xor(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_0022: ret

}
void xor(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_0022: ret

}
void xor(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_0022: ret

}
void xor(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_0022: ret

}
void xor(in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int64>&,System.Int64&)
    IL_0022: ret

}
void xor(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt64>&,System.UInt64&)
    IL_0022: ret

}
void xor(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Xor(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Single>&,System.Single&)
    IL_0022: ret

}
void xor(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Xor(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Double>&,System.Double&)
    IL_0022: ret

}
Boolean[] cmpf(in Vec128<float> lhs, in Vec128<float> rhs, byte mode)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Compare(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.X86.FloatComparisonMode)
    IL_001C: call System.Boolean[] Z0.dinx::TestNaN(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0021: ret

}
Boolean[] cmpf(in Vec128<double> lhs, in Vec128<double> rhs, byte mode)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Compare(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.X86.FloatComparisonMode)
    IL_001C: call System.Boolean[] Z0.dinx::TestNaN(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0021: ret

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
Boolean[] TestNaN(Vector128<float> src)
{
    IL_0000: ldc.i4.4
    IL_0001: newarr System.Boolean
    IL_0006: dup
    IL_0007: ldc.i4.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.0
    IL_000A: call System.Single System.Runtime.Intrinsics.Vector128::GetElement<System.Single>(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Int32)
    IL_000F: call System.Boolean Z0.xfunc::IsNaN(System.Single)
    IL_0014: stelem.i1
    IL_0015: dup
    IL_0016: ldc.i4.1
    IL_0017: ldarg.0
    IL_0018: ldc.i4.1
    IL_0019: call System.Single System.Runtime.Intrinsics.Vector128::GetElement<System.Single>(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Int32)
    IL_001E: call System.Boolean Z0.xfunc::IsNaN(System.Single)
    IL_0023: stelem.i1
    IL_0024: dup
    IL_0025: ldc.i4.2
    IL_0026: ldarg.0
    IL_0027: ldc.i4.2
    IL_0028: call System.Single System.Runtime.Intrinsics.Vector128::GetElement<System.Single>(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Int32)
    IL_002D: call System.Boolean Z0.xfunc::IsNaN(System.Single)
    IL_0032: stelem.i1
    IL_0033: dup
    IL_0034: ldc.i4.3
    IL_0035: ldarg.0
    IL_0036: ldc.i4.3
    IL_0037: call System.Single System.Runtime.Intrinsics.Vector128::GetElement<System.Single>(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Int32)
    IL_003C: call System.Boolean Z0.xfunc::IsNaN(System.Single)
    IL_0041: stelem.i1
    IL_0042: call System.Boolean[] zfunc::array<System.Boolean>(System.Boolean[])
    IL_0047: ret

}
Boolean[] TestNaN(Vector128<double> src)
{
    IL_0000: ldc.i4.2
    IL_0001: newarr System.Boolean
    IL_0006: dup
    IL_0007: ldc.i4.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.0
    IL_000A: call System.Double System.Runtime.Intrinsics.Vector128::GetElement<System.Double>(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Int32)
    IL_000F: call System.Boolean Z0.xfunc::IsNaN(System.Double)
    IL_0014: stelem.i1
    IL_0015: dup
    IL_0016: ldc.i4.1
    IL_0017: ldarg.0
    IL_0018: ldc.i4.1
    IL_0019: call System.Double System.Runtime.Intrinsics.Vector128::GetElement<System.Double>(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Int32)
    IL_001E: call System.Boolean Z0.xfunc::IsNaN(System.Double)
    IL_0023: stelem.i1
    IL_0024: call System.Boolean[] zfunc::array<System.Boolean>(System.Boolean[])
    IL_0029: ret

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
Vec128Cmp<float> eq(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: call Z0.Vec128Cmp`1<System.Single> Z0.Vec128Cmp::Define<System.Single>(Z0.Vec128`1<System.Single>)
    IL_0025: ret

}
Vec128Cmp<double> eq(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: call Z0.Vec128Cmp`1<System.Double> Z0.Vec128Cmp::Define<System.Double>(Z0.Vec128`1<System.Double>)
    IL_0025: ret

}
Vec256Cmp<sbyte> eq(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: call Z0.Vec256Cmp`1<System.SByte> Z0.Vec256Cmp::Define<System.SByte>(Z0.Vec256`1<System.SByte>)
    IL_001E: ret

}
Vec256Cmp<byte> eq(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: call Z0.Vec256Cmp`1<System.Byte> Z0.Vec256Cmp::Define<System.Byte>(Z0.Vec256`1<System.Byte>)
    IL_001E: ret

}
Vec256Cmp<short> eq(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: call Z0.Vec256Cmp`1<System.Int16> Z0.Vec256Cmp::Define<System.Int16>(Z0.Vec256`1<System.Int16>)
    IL_001E: ret

}
Vec256Cmp<ushort> eq(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: call Z0.Vec256Cmp`1<System.UInt16> Z0.Vec256Cmp::Define<System.UInt16>(Z0.Vec256`1<System.UInt16>)
    IL_001E: ret

}
Vec256Cmp<int> eq(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: call Z0.Vec256Cmp`1<System.Int32> Z0.Vec256Cmp::Define<System.Int32>(Z0.Vec256`1<System.Int32>)
    IL_001E: ret

}
Vec256Cmp<uint> eq(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: call Z0.Vec256Cmp`1<System.UInt32> Z0.Vec256Cmp::Define<System.UInt32>(Z0.Vec256`1<System.UInt32>)
    IL_001E: ret

}
Vec256Cmp<long> eq(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: call Z0.Vec256Cmp`1<System.Int64> Z0.Vec256Cmp::Define<System.Int64>(Z0.Vec256`1<System.Int64>)
    IL_001E: ret

}
Vec256Cmp<ulong> eq(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: call Z0.Vec256Cmp`1<System.UInt64> Z0.Vec256Cmp::Define<System.UInt64>(Z0.Vec256`1<System.UInt64>)
    IL_001E: ret

}
Vec256Cmp<float> eq(in Vec256<float> lhs, in Vec256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: ldc.i4.8
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Compare(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.X86.FloatComparisonMode)
    IL_0012: stloc.0
    IL_0013: ldloca.s V_0
    IL_0015: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_001A: call Z0.Vec256Cmp`1<System.Single> Z0.Vec256Cmp::Define<System.Single>(Z0.Vec256`1<System.Single>)
    IL_001F: ret

}
Vec256Cmp<double> eq(in Vec256<double> lhs, in Vec256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: ldc.i4.8
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Compare(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.X86.FloatComparisonMode)
    IL_0012: stloc.0
    IL_0013: ldloca.s V_0
    IL_0015: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_001A: call Z0.Vec256Cmp`1<System.Double> Z0.Vec256Cmp::Define<System.Double>(Z0.Vec256`1<System.Double>)
    IL_001F: ret

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
Vec128Cmp<float> gt(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::CompareGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: call Z0.Vec128Cmp`1<System.Single> Z0.Vec128Cmp::Define<System.Single>(Z0.Vec128`1<System.Single>)
    IL_0025: ret

}
Vec128Cmp<double> gt(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::CompareGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: call Z0.Vec128Cmp`1<System.Double> Z0.Vec128Cmp::Define<System.Double>(Z0.Vec128`1<System.Double>)
    IL_0025: ret

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
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.SByte>&,System.SByte&)
    IL_0029: ret

}
void or(in Vec128<byte> lhs, in Vec128<byte> rhs, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Byte>&,System.Byte&)
    IL_0029: ret

}
void or(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_0029: ret

}
void or(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt16>&,System.UInt16&)
    IL_0029: ret

}
void or(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_0029: ret

}
void or(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_0029: ret

}
void or(in Vec128<long> lhs, in Vec128<long> rhs, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int64>&,System.Int64&)
    IL_0029: ret

}
void or(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt64>&,System.UInt64&)
    IL_0029: ret

}
void or(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Or(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_0029: ret

}
void or(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_0029: ret

}
void or(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.SByte>&,System.SByte&)
    IL_0022: ret

}
void or(in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Byte>&,System.Byte&)
    IL_0022: ret

}
void or(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_0022: ret

}
void or(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_0022: ret

}
void or(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_0022: ret

}
void or(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_0022: ret

}
void or(in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int64>&,System.Int64&)
    IL_0022: ret

}
void or(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt64>&,System.UInt64&)
    IL_0022: ret

}
void or(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Or(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Single>&,System.Single&)
    IL_0022: ret

}
void or(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Or(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Double>&,System.Double&)
    IL_0022: ret

}
Vec128<short> shiftl(in Vec128<short> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> shiftl(in Vec128<ushort> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> shiftl(in Vec128<int> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> shiftl(in Vec128<uint> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> shiftl(in Vec128<long> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> shiftl(in Vec128<ulong> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<short> shiftl(in Vec256<short> src, byte count)
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
Vec256<ushort> shiftl(in Vec256<ushort> src, byte count)
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
Vec256<int> shiftl(in Vec256<int> src, byte count)
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
Vec256<uint> shiftl(in Vec256<uint> src, byte count)
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
Vec256<long> shiftl(in Vec256<long> src, byte count)
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
Vec256<ulong> shiftl(in Vec256<ulong> src, byte count)
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
void shiftl(in Vec128<short> lhs, byte count, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int16> Z0.dinx::shiftl(Z0.Vec128`1<System.Int16>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_0010: ret

}
void shiftl(in Vec128<ushort> lhs, byte count, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt16> Z0.dinx::shiftl(Z0.Vec128`1<System.UInt16>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt16>&,System.UInt16&)
    IL_0010: ret

}
void shiftl(in Vec128<int> lhs, byte count, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int32> Z0.dinx::shiftl(Z0.Vec128`1<System.Int32>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_0010: ret

}
void shiftl(in Vec128<uint> lhs, byte count, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt32> Z0.dinx::shiftl(Z0.Vec128`1<System.UInt32>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_0010: ret

}
void shiftl(in Vec128<long> lhs, byte count, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int64> Z0.dinx::shiftl(Z0.Vec128`1<System.Int64>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int64>&,System.Int64&)
    IL_0010: ret

}
void shiftl(in Vec128<ulong> lhs, byte count, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.dinx::shiftl(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt64>&,System.UInt64&)
    IL_0010: ret

}
void shiftl(in Vec256<short> lhs, byte count, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int16> Z0.dinx::shiftl(Z0.Vec256`1<System.Int16>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_0010: ret

}
void shiftl(in Vec256<ushort> lhs, byte count, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt16> Z0.dinx::shiftl(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_0010: ret

}
void shiftl(in Vec256<int> lhs, byte count, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int32> Z0.dinx::shiftl(Z0.Vec256`1<System.Int32>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_0010: ret

}
void shiftl(in Vec256<uint> lhs, byte count, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt32> Z0.dinx::shiftl(Z0.Vec256`1<System.UInt32>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_0010: ret

}
void shiftl(in Vec256<long> lhs, byte count, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int64> Z0.dinx::shiftl(Z0.Vec256`1<System.Int64>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int64>&,System.Int64&)
    IL_0010: ret

}
void shiftl(in Vec256<ulong> lhs, byte count, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt64> Z0.dinx::shiftl(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt64>&,System.UInt64&)
    IL_0010: ret

}
Vec128<int> shiftl(in Vec128<int> src, in Vec128<uint> count)
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
Vec128<uint> shiftl(in Vec128<uint> src, in Vec128<uint> shifts)
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
Vec128<long> shiftl(in Vec128<long> src, in Vec128<ulong> shifts)
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
Vec128<ulong> shiftl(in Vec128<ulong> src, in Vec128<ulong> shifts)
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
Vec256<int> shiftl(in Vec256<int> src, in Vec256<uint> shifts)
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
Vec256<uint> shiftl(in Vec256<uint> src, in Vec256<uint> shifts)
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
Vec256<long> shiftl(in Vec256<long> src, in Vec256<ulong> shifts)
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
Vec256<ulong> shiftl(in Vec256<ulong> src, in Vec256<ulong> shifts)
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
UInt128 shiftlw(UInt128 src, byte count)
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
Vec128<short> shiftlw(in Vec128<short> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> shiftlw(in Vec128<ushort> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> shiftlw(in Vec128<int> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> shiftlw(in Vec128<uint> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> shiftlw(in Vec128<long> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> shiftlw(in Vec128<ulong> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<short> shiftlw(in Vec256<short> src, byte count)
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
Vec256<ushort> shiftlw(in Vec256<ushort> src, byte count)
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
Vec256<int> shiftlw(in Vec256<int> src, byte count)
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
Vec256<uint> shiftlw(in Vec256<uint> src, byte count)
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
Vec256<long> shiftlw(in Vec256<long> src, byte count)
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
Vec256<ulong> shiftlw(in Vec256<ulong> src, byte count)
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
Vec128<short> shiftr(in Vec128<short> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> shiftr(in Vec128<ushort> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> shiftr(in Vec128<int> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> shiftr(in Vec128<uint> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> shiftr(in Vec128<long> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> shiftr(in Vec128<ulong> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<short> shiftr(in Vec256<short> src, byte count)
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
Vec256<ushort> shiftr(in Vec256<ushort> src, byte count)
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
Vec256<int> shiftr(in Vec256<int> src, byte count)
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
Vec256<uint> shiftr(in Vec256<uint> src, byte count)
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
Vec256<long> shiftr(in Vec256<long> src, byte count)
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
Vec256<ulong> shiftr(in Vec256<ulong> src, byte count)
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
Vec128<int> shiftr(in Vec128<int> src, in Vec128<uint> count)
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
Vec128<uint> shiftr(in Vec128<uint> src, in Vec128<uint> shifts)
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
Vec128<long> shiftr(in Vec128<long> src, in Vec128<ulong> shifts)
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
Vec128<ulong> shiftr(in Vec128<ulong> src, in Vec128<ulong> shifts)
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
Vec256<int> shiftr(in Vec256<int> src, in Vec256<uint> shifts)
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
Vec256<uint> shiftr(in Vec256<uint> src, in Vec256<uint> shifts)
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
Vec256<long> shiftr(in Vec256<long> src, in Vec256<ulong> shifts)
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
Vec256<ulong> shiftr(in Vec256<ulong> src, in Vec256<ulong> shifts)
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
void shiftr(in Vec128<int> lhs, in Vec128<uint> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_0029: ret

}
void shiftr(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_0029: ret

}
void shiftr(in Vec128<long> lhs, in Vec128<ulong> rhs, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int64>&,System.Int64&)
    IL_0029: ret

}
void shiftr(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt64>&,System.UInt64&)
    IL_0029: ret

}
void shiftr(in Vec256<int> lhs, in Vec256<uint> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_0022: ret

}
void shiftr(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_0022: ret

}
void shiftr(in Vec256<long> lhs, in Vec256<ulong> rhs, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int64>&,System.Int64&)
    IL_0022: ret

}
void shiftr(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt64>&,System.UInt64&)
    IL_0022: ret

}
void shiftr(in Vec128<short> lhs, byte count, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int16> Z0.dinx::shiftr(Z0.Vec128`1<System.Int16>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_0010: ret

}
void shiftr(in Vec128<ushort> lhs, byte count, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt16> Z0.dinx::shiftr(Z0.Vec128`1<System.UInt16>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt16>&,System.UInt16&)
    IL_0010: ret

}
void shiftr(in Vec128<int> lhs, byte count, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int32> Z0.dinx::shiftr(Z0.Vec128`1<System.Int32>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_0010: ret

}
void shiftr(in Vec128<uint> lhs, byte count, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt32> Z0.dinx::shiftr(Z0.Vec128`1<System.UInt32>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_0010: ret

}
void shiftr(in Vec128<long> lhs, byte count, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int64> Z0.dinx::shiftr(Z0.Vec128`1<System.Int64>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int64>&,System.Int64&)
    IL_0010: ret

}
void shiftr(in Vec128<ulong> lhs, byte count, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.dinx::shiftr(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt64>&,System.UInt64&)
    IL_0010: ret

}
void shiftr(in Vec256<short> lhs, byte count, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int16> Z0.dinx::shiftr(Z0.Vec256`1<System.Int16>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_0010: ret

}
void shiftr(in Vec256<ushort> lhs, byte count, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt16> Z0.dinx::shiftr(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_0010: ret

}
void shiftr(in Vec256<int> lhs, byte count, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int32> Z0.dinx::shiftr(Z0.Vec256`1<System.Int32>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_0010: ret

}
void shiftr(in Vec256<uint> lhs, byte count, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt32> Z0.dinx::shiftr(Z0.Vec256`1<System.UInt32>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_0010: ret

}
void shiftr(in Vec256<long> lhs, byte count, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int64> Z0.dinx::shiftr(Z0.Vec256`1<System.Int64>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int64>&,System.Int64&)
    IL_0010: ret

}
void shiftr(in Vec256<ulong> lhs, byte count, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt64> Z0.dinx::shiftr(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt64>&,System.UInt64&)
    IL_0010: ret

}
Span128<int> shiftr(in ReadOnlySpan128<int> lhs, in ReadOnlySpan128<uint> rhs, in Span128<int> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldobj Z0.Span128`1<System.Int32>
    IL_0006: stloc.2
    IL_0007: ldloca.s V_2
    IL_0009: call System.Int32 Z0.Span128`1<System.Int32>::get_BlockWidth()
    IL_000E: stloc.0
    IL_000F: ldarg.0
    IL_0010: ldobj Z0.ReadOnlySpan128`1<System.Int32>
    IL_0015: ldarg.1
    IL_0016: ldobj Z0.ReadOnlySpan128`1<System.UInt32>
    IL_001B: ldstr "J:\\dev\\projects\\z0\\inx\\direct\\bitwise\\shiftr.cs"
    IL_0020: ldstr "J:\\dev\\projects\\z0\\inx\\direct\\bitwise\\shiftr.cs"
    IL_0025: ldc.i4 188
    IL_002A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_002F: call System.Int32 Z0.Span128::length<System.Int32,System.UInt32>(Z0.ReadOnlySpan128`1<System.Int32>,Z0.ReadOnlySpan128`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0034: stloc.1
    IL_0035: ldc.i4.0
    IL_0036: stloc.3
    IL_0037: br.s IL_0071
    IL_0039: ldarg.0
    IL_003A: ldobj Z0.ReadOnlySpan128`1<System.Int32>
    IL_003F: ldloc.3
    IL_0040: call Z0.Vec128`1<System.Int32> Z0.ginxs::LoadVec128<System.Int32>(Z0.ReadOnlySpan128`1<System.Int32>,System.Int32)
    IL_0045: stloc.s V_4
    IL_0047: ldloca.s V_4
    IL_0049: ldarg.1
    IL_004A: ldobj Z0.ReadOnlySpan128`1<System.UInt32>
    IL_004F: ldloc.3
    IL_0050: call Z0.Vec128`1<System.UInt32> Z0.ginxs::LoadVec128<System.UInt32>(Z0.ReadOnlySpan128`1<System.UInt32>,System.Int32)
    IL_0055: stloc.s V_5
    IL_0057: ldloca.s V_5
    IL_0059: ldarg.2
    IL_005A: ldobj Z0.Span128`1<System.Int32>
    IL_005F: stloc.2
    IL_0060: ldloca.s V_2
    IL_0062: ldloc.3
    IL_0063: call System.Int32& Z0.Span128`1<System.Int32>::get_Item(System.Int32)
    IL_0068: call System.Void Z0.dinx::shiftr(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.UInt32>&,System.Int32&)
    IL_006D: ldloc.3
    IL_006E: ldloc.0
    IL_006F: add
    IL_0070: stloc.3
    IL_0071: ldloc.3
    IL_0072: ldloc.1
    IL_0073: blt.s IL_0039
    IL_0075: ldarg.2
    IL_0076: ldobj Z0.Span128`1<System.Int32>
    IL_007B: ret

}
Span128<uint> shiftr(in ReadOnlySpan128<uint> lhs, in ReadOnlySpan128<uint> rhs, in Span128<uint> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldobj Z0.Span128`1<System.UInt32>
    IL_0006: stloc.2
    IL_0007: ldloca.s V_2
    IL_0009: call System.Int32 Z0.Span128`1<System.UInt32>::get_BlockWidth()
    IL_000E: stloc.0
    IL_000F: ldarg.0
    IL_0010: ldobj Z0.ReadOnlySpan128`1<System.UInt32>
    IL_0015: ldarg.1
    IL_0016: ldobj Z0.ReadOnlySpan128`1<System.UInt32>
    IL_001B: ldstr "J:\\dev\\projects\\z0\\inx\\direct\\bitwise\\shiftr.cs"
    IL_0020: ldstr "J:\\dev\\projects\\z0\\inx\\direct\\bitwise\\shiftr.cs"
    IL_0025: ldc.i4 197
    IL_002A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_002F: call System.Int32 Z0.Span128::length<System.UInt32,System.UInt32>(Z0.ReadOnlySpan128`1<System.UInt32>,Z0.ReadOnlySpan128`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0034: stloc.1
    IL_0035: ldc.i4.0
    IL_0036: stloc.3
    IL_0037: br.s IL_0071
    IL_0039: ldarg.0
    IL_003A: ldobj Z0.ReadOnlySpan128`1<System.UInt32>
    IL_003F: ldloc.3
    IL_0040: call Z0.Vec128`1<System.UInt32> Z0.ginxs::LoadVec128<System.UInt32>(Z0.ReadOnlySpan128`1<System.UInt32>,System.Int32)
    IL_0045: stloc.s V_4
    IL_0047: ldloca.s V_4
    IL_0049: ldarg.1
    IL_004A: ldobj Z0.ReadOnlySpan128`1<System.UInt32>
    IL_004F: ldloc.3
    IL_0050: call Z0.Vec128`1<System.UInt32> Z0.ginxs::LoadVec128<System.UInt32>(Z0.ReadOnlySpan128`1<System.UInt32>,System.Int32)
    IL_0055: stloc.s V_5
    IL_0057: ldloca.s V_5
    IL_0059: ldarg.2
    IL_005A: ldobj Z0.Span128`1<System.UInt32>
    IL_005F: stloc.2
    IL_0060: ldloca.s V_2
    IL_0062: ldloc.3
    IL_0063: call System.UInt32& Z0.Span128`1<System.UInt32>::get_Item(System.Int32)
    IL_0068: call System.Void Z0.dinx::shiftr(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_006D: ldloc.3
    IL_006E: ldloc.0
    IL_006F: add
    IL_0070: stloc.3
    IL_0071: ldloc.3
    IL_0072: ldloc.1
    IL_0073: blt.s IL_0039
    IL_0075: ldarg.2
    IL_0076: ldobj Z0.Span128`1<System.UInt32>
    IL_007B: ret

}
Span128<long> shiftr(in ReadOnlySpan128<long> lhs, in ReadOnlySpan128<ulong> rhs, in Span128<long> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldobj Z0.Span128`1<System.Int64>
    IL_0006: stloc.2
    IL_0007: ldloca.s V_2
    IL_0009: call System.Int32 Z0.Span128`1<System.Int64>::get_BlockWidth()
    IL_000E: stloc.0
    IL_000F: ldarg.0
    IL_0010: ldobj Z0.ReadOnlySpan128`1<System.Int64>
    IL_0015: ldarg.1
    IL_0016: ldobj Z0.ReadOnlySpan128`1<System.UInt64>
    IL_001B: ldstr "J:\\dev\\projects\\z0\\inx\\direct\\bitwise\\shiftr.cs"
    IL_0020: ldstr "J:\\dev\\projects\\z0\\inx\\direct\\bitwise\\shiftr.cs"
    IL_0025: ldc.i4 206
    IL_002A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_002F: call System.Int32 Z0.Span128::length<System.Int64,System.UInt64>(Z0.ReadOnlySpan128`1<System.Int64>,Z0.ReadOnlySpan128`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0034: stloc.1
    IL_0035: ldc.i4.0
    IL_0036: stloc.3
    IL_0037: br.s IL_0071
    IL_0039: ldarg.0
    IL_003A: ldobj Z0.ReadOnlySpan128`1<System.Int64>
    IL_003F: ldloc.3
    IL_0040: call Z0.Vec128`1<System.Int64> Z0.ginxs::LoadVec128<System.Int64>(Z0.ReadOnlySpan128`1<System.Int64>,System.Int32)
    IL_0045: stloc.s V_4
    IL_0047: ldloca.s V_4
    IL_0049: ldarg.1
    IL_004A: ldobj Z0.ReadOnlySpan128`1<System.UInt64>
    IL_004F: ldloc.3
    IL_0050: call Z0.Vec128`1<System.UInt64> Z0.ginxs::LoadVec128<System.UInt64>(Z0.ReadOnlySpan128`1<System.UInt64>,System.Int32)
    IL_0055: stloc.s V_5
    IL_0057: ldloca.s V_5
    IL_0059: ldarg.2
    IL_005A: ldobj Z0.Span128`1<System.Int64>
    IL_005F: stloc.2
    IL_0060: ldloca.s V_2
    IL_0062: ldloc.3
    IL_0063: call System.Int64& Z0.Span128`1<System.Int64>::get_Item(System.Int32)
    IL_0068: call System.Void Z0.dinx::shiftr(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.UInt64>&,System.Int64&)
    IL_006D: ldloc.3
    IL_006E: ldloc.0
    IL_006F: add
    IL_0070: stloc.3
    IL_0071: ldloc.3
    IL_0072: ldloc.1
    IL_0073: blt.s IL_0039
    IL_0075: ldarg.2
    IL_0076: ldobj Z0.Span128`1<System.Int64>
    IL_007B: ret

}
Span128<ulong> shiftr(in ReadOnlySpan128<ulong> lhs, in ReadOnlySpan128<ulong> rhs, in Span128<ulong> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldobj Z0.Span128`1<System.UInt64>
    IL_0006: stloc.2
    IL_0007: ldloca.s V_2
    IL_0009: call System.Int32 Z0.Span128`1<System.UInt64>::get_BlockWidth()
    IL_000E: stloc.0
    IL_000F: ldarg.0
    IL_0010: ldobj Z0.ReadOnlySpan128`1<System.UInt64>
    IL_0015: ldarg.1
    IL_0016: ldobj Z0.ReadOnlySpan128`1<System.UInt64>
    IL_001B: ldstr "J:\\dev\\projects\\z0\\inx\\direct\\bitwise\\shiftr.cs"
    IL_0020: ldstr "J:\\dev\\projects\\z0\\inx\\direct\\bitwise\\shiftr.cs"
    IL_0025: ldc.i4 215
    IL_002A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_002F: call System.Int32 Z0.Span128::length<System.UInt64,System.UInt64>(Z0.ReadOnlySpan128`1<System.UInt64>,Z0.ReadOnlySpan128`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0034: stloc.1
    IL_0035: ldc.i4.0
    IL_0036: stloc.3
    IL_0037: br.s IL_0071
    IL_0039: ldarg.0
    IL_003A: ldobj Z0.ReadOnlySpan128`1<System.UInt64>
    IL_003F: ldloc.3
    IL_0040: call Z0.Vec128`1<System.UInt64> Z0.ginxs::LoadVec128<System.UInt64>(Z0.ReadOnlySpan128`1<System.UInt64>,System.Int32)
    IL_0045: stloc.s V_4
    IL_0047: ldloca.s V_4
    IL_0049: ldarg.1
    IL_004A: ldobj Z0.ReadOnlySpan128`1<System.UInt64>
    IL_004F: ldloc.3
    IL_0050: call Z0.Vec128`1<System.UInt64> Z0.ginxs::LoadVec128<System.UInt64>(Z0.ReadOnlySpan128`1<System.UInt64>,System.Int32)
    IL_0055: stloc.s V_5
    IL_0057: ldloca.s V_5
    IL_0059: ldarg.2
    IL_005A: ldobj Z0.Span128`1<System.UInt64>
    IL_005F: stloc.2
    IL_0060: ldloca.s V_2
    IL_0062: ldloc.3
    IL_0063: call System.UInt64& Z0.Span128`1<System.UInt64>::get_Item(System.Int32)
    IL_0068: call System.Void Z0.dinx::shiftr(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,System.UInt64&)
    IL_006D: ldloc.3
    IL_006E: ldloc.0
    IL_006F: add
    IL_0070: stloc.3
    IL_0071: ldloc.3
    IL_0072: ldloc.1
    IL_0073: blt.s IL_0039
    IL_0075: ldarg.2
    IL_0076: ldobj Z0.Span128`1<System.UInt64>
    IL_007B: ret

}
Span256<int> shiftr(in ReadOnlySpan256<int> lhs, in ReadOnlySpan256<uint> rhs, in Span256<int> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldobj Z0.Span256`1<System.Int32>
    IL_0006: stloc.2
    IL_0007: ldloca.s V_2
    IL_0009: call System.Int32 Z0.Span256`1<System.Int32>::get_BlockWidth()
    IL_000E: stloc.0
    IL_000F: ldarg.0
    IL_0010: ldobj Z0.ReadOnlySpan256`1<System.Int32>
    IL_0015: ldarg.1
    IL_0016: ldobj Z0.ReadOnlySpan256`1<System.UInt32>
    IL_001B: ldstr "shiftr"
    IL_0020: ldstr "J:\\dev\\projects\\z0\\inx\\direct\\bitwise\\shiftr.cs"
    IL_0025: ldc.i4 224
    IL_002A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_002F: call System.Int32 zfunc::length<System.Int32,System.UInt32>(Z0.ReadOnlySpan256`1<System.Int32>,Z0.ReadOnlySpan256`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0034: stloc.1
    IL_0035: ldc.i4.0
    IL_0036: stloc.3
    IL_0037: br.s IL_0071
    IL_0039: ldarg.0
    IL_003A: ldobj Z0.ReadOnlySpan256`1<System.Int32>
    IL_003F: ldloc.3
    IL_0040: call Z0.Vec256`1<System.Int32> Z0.ginxs::LoadVec256<System.Int32>(Z0.ReadOnlySpan256`1<System.Int32>,System.Int32)
    IL_0045: stloc.s V_4
    IL_0047: ldloca.s V_4
    IL_0049: ldarg.1
    IL_004A: ldobj Z0.ReadOnlySpan256`1<System.UInt32>
    IL_004F: ldloc.3
    IL_0050: call Z0.Vec256`1<System.UInt32> Z0.ginxs::LoadVec256<System.UInt32>(Z0.ReadOnlySpan256`1<System.UInt32>,System.Int32)
    IL_0055: stloc.s V_5
    IL_0057: ldloca.s V_5
    IL_0059: ldarg.2
    IL_005A: ldobj Z0.Span256`1<System.Int32>
    IL_005F: stloc.2
    IL_0060: ldloca.s V_2
    IL_0062: ldloc.3
    IL_0063: call System.Int32& Z0.Span256`1<System.Int32>::get_Item(System.Int32)
    IL_0068: call System.Void Z0.dinx::shiftr(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.UInt32>&,System.Int32&)
    IL_006D: ldloc.3
    IL_006E: ldloc.0
    IL_006F: add
    IL_0070: stloc.3
    IL_0071: ldloc.3
    IL_0072: ldloc.1
    IL_0073: blt.s IL_0039
    IL_0075: ldarg.2
    IL_0076: ldobj Z0.Span256`1<System.Int32>
    IL_007B: ret

}
Span256<uint> shiftr(in ReadOnlySpan256<uint> lhs, in ReadOnlySpan256<uint> rhs, in Span256<uint> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldobj Z0.Span256`1<System.UInt32>
    IL_0006: stloc.2
    IL_0007: ldloca.s V_2
    IL_0009: call System.Int32 Z0.Span256`1<System.UInt32>::get_BlockWidth()
    IL_000E: stloc.0
    IL_000F: ldarg.0
    IL_0010: ldobj Z0.ReadOnlySpan256`1<System.UInt32>
    IL_0015: ldarg.1
    IL_0016: ldobj Z0.ReadOnlySpan256`1<System.UInt32>
    IL_001B: ldstr "shiftr"
    IL_0020: ldstr "J:\\dev\\projects\\z0\\inx\\direct\\bitwise\\shiftr.cs"
    IL_0025: ldc.i4 233
    IL_002A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_002F: call System.Int32 zfunc::length<System.UInt32,System.UInt32>(Z0.ReadOnlySpan256`1<System.UInt32>,Z0.ReadOnlySpan256`1<System.UInt32>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0034: stloc.1
    IL_0035: ldc.i4.0
    IL_0036: stloc.3
    IL_0037: br.s IL_0071
    IL_0039: ldarg.0
    IL_003A: ldobj Z0.ReadOnlySpan256`1<System.UInt32>
    IL_003F: ldloc.3
    IL_0040: call Z0.Vec256`1<System.UInt32> Z0.ginxs::LoadVec256<System.UInt32>(Z0.ReadOnlySpan256`1<System.UInt32>,System.Int32)
    IL_0045: stloc.s V_4
    IL_0047: ldloca.s V_4
    IL_0049: ldarg.1
    IL_004A: ldobj Z0.ReadOnlySpan256`1<System.UInt32>
    IL_004F: ldloc.3
    IL_0050: call Z0.Vec256`1<System.UInt32> Z0.ginxs::LoadVec256<System.UInt32>(Z0.ReadOnlySpan256`1<System.UInt32>,System.Int32)
    IL_0055: stloc.s V_5
    IL_0057: ldloca.s V_5
    IL_0059: ldarg.2
    IL_005A: ldobj Z0.Span256`1<System.UInt32>
    IL_005F: stloc.2
    IL_0060: ldloca.s V_2
    IL_0062: ldloc.3
    IL_0063: call System.UInt32& Z0.Span256`1<System.UInt32>::get_Item(System.Int32)
    IL_0068: call System.Void Z0.dinx::shiftr(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_006D: ldloc.3
    IL_006E: ldloc.0
    IL_006F: add
    IL_0070: stloc.3
    IL_0071: ldloc.3
    IL_0072: ldloc.1
    IL_0073: blt.s IL_0039
    IL_0075: ldarg.2
    IL_0076: ldobj Z0.Span256`1<System.UInt32>
    IL_007B: ret

}
Span256<long> shiftr(in ReadOnlySpan256<long> lhs, in ReadOnlySpan256<ulong> rhs, in Span256<long> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldobj Z0.Span256`1<System.Int64>
    IL_0006: stloc.2
    IL_0007: ldloca.s V_2
    IL_0009: call System.Int32 Z0.Span256`1<System.Int64>::get_BlockWidth()
    IL_000E: stloc.0
    IL_000F: ldarg.0
    IL_0010: ldobj Z0.ReadOnlySpan256`1<System.Int64>
    IL_0015: ldarg.1
    IL_0016: ldobj Z0.ReadOnlySpan256`1<System.UInt64>
    IL_001B: ldstr "shiftr"
    IL_0020: ldstr "J:\\dev\\projects\\z0\\inx\\direct\\bitwise\\shiftr.cs"
    IL_0025: ldc.i4 242
    IL_002A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_002F: call System.Int32 zfunc::length<System.Int64,System.UInt64>(Z0.ReadOnlySpan256`1<System.Int64>,Z0.ReadOnlySpan256`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0034: stloc.1
    IL_0035: ldc.i4.0
    IL_0036: stloc.3
    IL_0037: br.s IL_0071
    IL_0039: ldarg.0
    IL_003A: ldobj Z0.ReadOnlySpan256`1<System.Int64>
    IL_003F: ldloc.3
    IL_0040: call Z0.Vec256`1<System.Int64> Z0.ginxs::LoadVec256<System.Int64>(Z0.ReadOnlySpan256`1<System.Int64>,System.Int32)
    IL_0045: stloc.s V_4
    IL_0047: ldloca.s V_4
    IL_0049: ldarg.1
    IL_004A: ldobj Z0.ReadOnlySpan256`1<System.UInt64>
    IL_004F: ldloc.3
    IL_0050: call Z0.Vec256`1<System.UInt64> Z0.ginxs::LoadVec256<System.UInt64>(Z0.ReadOnlySpan256`1<System.UInt64>,System.Int32)
    IL_0055: stloc.s V_5
    IL_0057: ldloca.s V_5
    IL_0059: ldarg.2
    IL_005A: ldobj Z0.Span256`1<System.Int64>
    IL_005F: stloc.2
    IL_0060: ldloca.s V_2
    IL_0062: ldloc.3
    IL_0063: call System.Int64& Z0.Span256`1<System.Int64>::get_Item(System.Int32)
    IL_0068: call System.Void Z0.dinx::shiftr(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.UInt64>&,System.Int64&)
    IL_006D: ldloc.3
    IL_006E: ldloc.0
    IL_006F: add
    IL_0070: stloc.3
    IL_0071: ldloc.3
    IL_0072: ldloc.1
    IL_0073: blt.s IL_0039
    IL_0075: ldarg.2
    IL_0076: ldobj Z0.Span256`1<System.Int64>
    IL_007B: ret

}
Span256<ulong> shiftr(in ReadOnlySpan256<ulong> lhs, in ReadOnlySpan256<ulong> rhs, in Span256<ulong> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldobj Z0.Span256`1<System.UInt64>
    IL_0006: stloc.2
    IL_0007: ldloca.s V_2
    IL_0009: call System.Int32 Z0.Span256`1<System.UInt64>::get_BlockWidth()
    IL_000E: stloc.0
    IL_000F: ldarg.0
    IL_0010: ldobj Z0.ReadOnlySpan256`1<System.UInt64>
    IL_0015: ldarg.1
    IL_0016: ldobj Z0.ReadOnlySpan256`1<System.UInt64>
    IL_001B: ldstr "shiftr"
    IL_0020: ldstr "J:\\dev\\projects\\z0\\inx\\direct\\bitwise\\shiftr.cs"
    IL_0025: ldc.i4 251
    IL_002A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_002F: call System.Int32 zfunc::length<System.UInt64,System.UInt64>(Z0.ReadOnlySpan256`1<System.UInt64>,Z0.ReadOnlySpan256`1<System.UInt64>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0034: stloc.1
    IL_0035: ldc.i4.0
    IL_0036: stloc.3
    IL_0037: br.s IL_0071
    IL_0039: ldarg.0
    IL_003A: ldobj Z0.ReadOnlySpan256`1<System.UInt64>
    IL_003F: ldloc.3
    IL_0040: call Z0.Vec256`1<System.UInt64> Z0.ginxs::LoadVec256<System.UInt64>(Z0.ReadOnlySpan256`1<System.UInt64>,System.Int32)
    IL_0045: stloc.s V_4
    IL_0047: ldloca.s V_4
    IL_0049: ldarg.1
    IL_004A: ldobj Z0.ReadOnlySpan256`1<System.UInt64>
    IL_004F: ldloc.3
    IL_0050: call Z0.Vec256`1<System.UInt64> Z0.ginxs::LoadVec256<System.UInt64>(Z0.ReadOnlySpan256`1<System.UInt64>,System.Int32)
    IL_0055: stloc.s V_5
    IL_0057: ldloca.s V_5
    IL_0059: ldarg.2
    IL_005A: ldobj Z0.Span256`1<System.UInt64>
    IL_005F: stloc.2
    IL_0060: ldloca.s V_2
    IL_0062: ldloc.3
    IL_0063: call System.UInt64& Z0.Span256`1<System.UInt64>::get_Item(System.Int32)
    IL_0068: call System.Void Z0.dinx::shiftr(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&,System.UInt64&)
    IL_006D: ldloc.3
    IL_006E: ldloc.0
    IL_006F: add
    IL_0070: stloc.3
    IL_0071: ldloc.3
    IL_0072: ldloc.1
    IL_0073: blt.s IL_0039
    IL_0075: ldarg.2
    IL_0076: ldobj Z0.Span256`1<System.UInt64>
    IL_007B: ret

}
Span128<short> shiftr(ReadOnlySpan128<short> lhs, byte count, Span128<short> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span128`1<System.Int16>::get_BlockWidth()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec128`1<System.Int16> Z0.ginxs::LoadVec128<System.Int16>(Z0.ReadOnlySpan128`1<System.Int16>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: call Z0.Vec128`1<System.Int16> Z0.dinx::shiftr(Z0.Vec128`1<System.Int16>&,System.Byte)
    IL_001C: stloc.3
    IL_001D: ldloca.s V_3
    IL_001F: ldarga.s dst
    IL_0021: ldloc.1
    IL_0022: call System.Int16& Z0.Span128`1<System.Int16>::get_Item(System.Int32)
    IL_0027: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_002C: ldloc.1
    IL_002D: ldloc.0
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldarga.s lhs
    IL_0033: call System.Int32 Z0.ReadOnlySpan128`1<System.Int16>::get_Length()
    IL_0038: blt.s IL_000C
    IL_003A: ldarg.2
    IL_003B: ret

}
Span128<ushort> shiftr(ReadOnlySpan128<ushort> lhs, byte count, Span128<ushort> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span128`1<System.UInt16>::get_BlockWidth()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec128`1<System.UInt16> Z0.ginxs::LoadVec128<System.UInt16>(Z0.ReadOnlySpan128`1<System.UInt16>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: call Z0.Vec128`1<System.UInt16> Z0.dinx::shiftr(Z0.Vec128`1<System.UInt16>&,System.Byte)
    IL_001C: stloc.3
    IL_001D: ldloca.s V_3
    IL_001F: ldarga.s dst
    IL_0021: ldloc.1
    IL_0022: call System.UInt16& Z0.Span128`1<System.UInt16>::get_Item(System.Int32)
    IL_0027: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt16>&,System.UInt16&)
    IL_002C: ldloc.1
    IL_002D: ldloc.0
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldarga.s lhs
    IL_0033: call System.Int32 Z0.ReadOnlySpan128`1<System.UInt16>::get_Length()
    IL_0038: blt.s IL_000C
    IL_003A: ldarg.2
    IL_003B: ret

}
Span128<int> shiftr(ReadOnlySpan128<int> lhs, byte count, Span128<int> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span128`1<System.Int32>::get_BlockWidth()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec128`1<System.Int32> Z0.ginxs::LoadVec128<System.Int32>(Z0.ReadOnlySpan128`1<System.Int32>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: call Z0.Vec128`1<System.Int32> Z0.dinx::shiftr(Z0.Vec128`1<System.Int32>&,System.Byte)
    IL_001C: stloc.3
    IL_001D: ldloca.s V_3
    IL_001F: ldarga.s dst
    IL_0021: ldloc.1
    IL_0022: call System.Int32& Z0.Span128`1<System.Int32>::get_Item(System.Int32)
    IL_0027: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_002C: ldloc.1
    IL_002D: ldloc.0
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldarga.s lhs
    IL_0033: call System.Int32 Z0.ReadOnlySpan128`1<System.Int32>::get_Length()
    IL_0038: blt.s IL_000C
    IL_003A: ldarg.2
    IL_003B: ret

}
Span128<uint> shiftr(ReadOnlySpan128<uint> lhs, byte count, Span128<uint> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span128`1<System.UInt32>::get_BlockWidth()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec128`1<System.UInt32> Z0.ginxs::LoadVec128<System.UInt32>(Z0.ReadOnlySpan128`1<System.UInt32>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: call Z0.Vec128`1<System.UInt32> Z0.dinx::shiftr(Z0.Vec128`1<System.UInt32>&,System.Byte)
    IL_001C: stloc.3
    IL_001D: ldloca.s V_3
    IL_001F: ldarga.s dst
    IL_0021: ldloc.1
    IL_0022: call System.UInt32& Z0.Span128`1<System.UInt32>::get_Item(System.Int32)
    IL_0027: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_002C: ldloc.1
    IL_002D: ldloc.0
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldarga.s lhs
    IL_0033: call System.Int32 Z0.ReadOnlySpan128`1<System.UInt32>::get_Length()
    IL_0038: blt.s IL_000C
    IL_003A: ldarg.2
    IL_003B: ret

}
Span128<long> shiftr(ReadOnlySpan128<long> lhs, byte count, Span128<long> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span128`1<System.Int64>::get_BlockWidth()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec128`1<System.Int64> Z0.ginxs::LoadVec128<System.Int64>(Z0.ReadOnlySpan128`1<System.Int64>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: call Z0.Vec128`1<System.Int64> Z0.dinx::shiftr(Z0.Vec128`1<System.Int64>&,System.Byte)
    IL_001C: stloc.3
    IL_001D: ldloca.s V_3
    IL_001F: ldarga.s dst
    IL_0021: ldloc.1
    IL_0022: call System.Int64& Z0.Span128`1<System.Int64>::get_Item(System.Int32)
    IL_0027: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int64>&,System.Int64&)
    IL_002C: ldloc.1
    IL_002D: ldloc.0
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldarga.s lhs
    IL_0033: call System.Int32 Z0.ReadOnlySpan128`1<System.Int64>::get_Length()
    IL_0038: blt.s IL_000C
    IL_003A: ldarg.2
    IL_003B: ret

}
Span128<ulong> shiftr(ReadOnlySpan128<ulong> lhs, byte count, Span128<ulong> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span128`1<System.UInt64>::get_BlockWidth()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec128`1<System.UInt64> Z0.ginxs::LoadVec128<System.UInt64>(Z0.ReadOnlySpan128`1<System.UInt64>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: call Z0.Vec128`1<System.UInt64> Z0.dinx::shiftr(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_001C: stloc.3
    IL_001D: ldloca.s V_3
    IL_001F: ldarga.s dst
    IL_0021: ldloc.1
    IL_0022: call System.UInt64& Z0.Span128`1<System.UInt64>::get_Item(System.Int32)
    IL_0027: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt64>&,System.UInt64&)
    IL_002C: ldloc.1
    IL_002D: ldloc.0
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldarga.s lhs
    IL_0033: call System.Int32 Z0.ReadOnlySpan128`1<System.UInt64>::get_Length()
    IL_0038: blt.s IL_000C
    IL_003A: ldarg.2
    IL_003B: ret

}
Span256<short> shiftr(ReadOnlySpan256<short> lhs, byte count, Span256<short> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span256`1<System.Int16>::get_BlockWidth()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec256`1<System.Int16> Z0.ginxs::LoadVec256<System.Int16>(Z0.ReadOnlySpan256`1<System.Int16>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: call Z0.Vec256`1<System.Int16> Z0.dinx::shiftr(Z0.Vec256`1<System.Int16>&,System.Byte)
    IL_001C: stloc.3
    IL_001D: ldloca.s V_3
    IL_001F: ldarga.s dst
    IL_0021: ldloc.1
    IL_0022: call System.Int16& Z0.Span256`1<System.Int16>::get_Item(System.Int32)
    IL_0027: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_002C: ldloc.1
    IL_002D: ldloc.0
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldarga.s lhs
    IL_0033: call System.Int32 Z0.ReadOnlySpan256`1<System.Int16>::get_Length()
    IL_0038: blt.s IL_000C
    IL_003A: ldarg.2
    IL_003B: ret

}
Span256<ushort> shiftr(ReadOnlySpan256<ushort> lhs, byte count, Span256<ushort> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span256`1<System.UInt16>::get_BlockWidth()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec256`1<System.UInt16> Z0.ginxs::LoadVec256<System.UInt16>(Z0.ReadOnlySpan256`1<System.UInt16>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: call Z0.Vec256`1<System.UInt16> Z0.dinx::shiftr(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_001C: stloc.3
    IL_001D: ldloca.s V_3
    IL_001F: ldarga.s dst
    IL_0021: ldloc.1
    IL_0022: call System.UInt16& Z0.Span256`1<System.UInt16>::get_Item(System.Int32)
    IL_0027: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_002C: ldloc.1
    IL_002D: ldloc.0
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldarga.s lhs
    IL_0033: call System.Int32 Z0.ReadOnlySpan256`1<System.UInt16>::get_Length()
    IL_0038: blt.s IL_000C
    IL_003A: ldarg.2
    IL_003B: ret

}
Span256<int> shiftr(ReadOnlySpan256<int> lhs, byte count, Span256<int> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: call System.Int32 Z0.Span256`1<System.Int32>::get_BlockWidth()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0030
    IL_000C: ldarg.0
    IL_000D: ldloc.1
    IL_000E: call Z0.Vec256`1<System.Int32> Z0.ginxs::LoadVec256<System.Int32>(Z0.ReadOnlySpan256`1<System.Int32>,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldloca.s V_2
    IL_0016: ldarg.1
    IL_0017: call Z0.Vec256`1<System.Int32> Z0.dinx::shiftr(Z0.Vec256`1<System.Int32>&,System.Byte)
    IL_001C: stloc.3
    IL_001D: ldloca.s V_3
    IL_001F: ldarga.s dst
    IL_0021: ldloc.1
    IL_0022: call System.Int32& Z0.Span256`1<System.Int32>::get_Item(System.Int32)
    IL_0027: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_002C: ldloc.1
    IL_002D: ldloc.0
    IL_002E: add
    IL_002F: stloc.1
    IL_0030: ldloc.1
    IL_0031: ldarga.s lhs
    IL_0033: call System.Int32 Z0.ReadOnlySpan256`1<System.Int32>::get_Length()
    IL_0038: blt.s IL_000C
    IL_003A: ldarg.2
    IL_003B: ret

}
UInt128 and(in UInt128 lhs, in UInt128 rhs)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128&)
    IL_000F: stloc.1
    IL_0010: ldloca.s V_1
    IL_0012: call Z0.Vec128`1<System.UInt64> Z0.dinx::and(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0017: stloc.2
    IL_0018: ldloca.s V_2
    IL_001A: call Z0.UInt128 Z0.UInt128X::ToUInt128(Z0.Vec128`1<System.UInt64>&)
    IL_001F: ret

}
ref UInt128 and(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.1
    IL_000B: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128&)
    IL_0010: stloc.1
    IL_0011: ldloca.s V_1
    IL_0013: call Z0.Vec128`1<System.UInt64> Z0.dinx::and(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0018: stloc.2
    IL_0019: ldloca.s V_2
    IL_001B: call Z0.UInt128 Z0.UInt128X::ToUInt128(Z0.Vec128`1<System.UInt64>&)
    IL_0020: stobj Z0.UInt128
    IL_0025: ldarg.2
    IL_0026: ret

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
void and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.SByte>&,System.SByte&)
    IL_0029: ret

}
void and(in Vec128<byte> lhs, in Vec128<byte> rhs, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Byte>&,System.Byte&)
    IL_0029: ret

}
void and(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_0029: ret

}
void and(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt16>&,System.UInt16&)
    IL_0029: ret

}
void and(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_0029: ret

}
void and(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_0029: ret

}
void and(in Vec128<long> lhs, in Vec128<long> rhs, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int64>&,System.Int64&)
    IL_0029: ret

}
void and(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt64>&,System.UInt64&)
    IL_0029: ret

}
void and(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::And(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_0029: ret

}
void and(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_0029: ret

}
void and(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.SByte>&,System.SByte&)
    IL_0022: ret

}
void and(in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Byte>&,System.Byte&)
    IL_0022: ret

}
void and(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_0022: ret

}
void and(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_0022: ret

}
void and(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_0022: ret

}
void and(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_0022: ret

}
void and(in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int64>&,System.Int64&)
    IL_0022: ret

}
void and(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt64>&,System.UInt64&)
    IL_0022: ret

}
void and(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::And(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Single>&,System.Single&)
    IL_0022: ret

}
void and(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::And(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Double>&,System.Double&)
    IL_0022: ret

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
void andnot(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.SByte>&,System.SByte&)
    IL_0029: ret

}
void andnot(in Vec128<byte> lhs, in Vec128<byte> rhs, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Byte>&,System.Byte&)
    IL_0029: ret

}
void andnot(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_0029: ret

}
void andnot(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt16>&,System.UInt16&)
    IL_0029: ret

}
void andnot(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_0029: ret

}
void andnot(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_0029: ret

}
void andnot(in Vec128<long> lhs, in Vec128<long> rhs, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int64>&,System.Int64&)
    IL_0029: ret

}
void andnot(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt64>&,System.UInt64&)
    IL_0029: ret

}
void andnot(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(Z0.Vec128`1<System.Single>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_0029: ret

}
void andnot(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(Z0.Vec128`1<System.Double>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0020: stloc.0
    IL_0021: ldloca.s V_0
    IL_0023: ldarg.2
    IL_0024: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_0029: ret

}
void andnot(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.SByte>&,System.SByte&)
    IL_0022: ret

}
void andnot(in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Byte>&,System.Byte&)
    IL_0022: ret

}
void andnot(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_0022: ret

}
void andnot(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_0022: ret

}
void andnot(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_0022: ret

}
void andnot(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_0022: ret

}
void andnot(in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int64>&,System.Int64&)
    IL_0022: ret

}
void andnot(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt64>&,System.UInt64&)
    IL_0022: ret

}
void andnot(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Single>&,System.Single&)
    IL_0022: ret

}
void andnot(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldarg.2
    IL_001D: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Double>&,System.Double&)
    IL_0022: ret

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
    IL_0010: call Z0.Vec128`1<System.Int64> Z0.Vec128::define(System.Int64,System.Int64)
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
    IL_0010: call Z0.Vec128`1<System.UInt64> Z0.Vec128::define(System.UInt64,System.UInt64)
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
    IL_0001: call Z0.Vec128`1<System.SByte> Z0.dinx::flip(Z0.Vec128`1<System.SByte>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void Z0.dinx::store(Z0.Vec128`1<System.SByte>&,System.SByte&)
    IL_000F: ret

}
void flip(in Vec128<byte> src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Byte> Z0.dinx::flip(Z0.Vec128`1<System.Byte>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Byte>&,System.Byte&)
    IL_000F: ret

}
void flip(in Vec128<short> src, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int16> Z0.dinx::flip(Z0.Vec128`1<System.Int16>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_000F: ret

}
void flip(in Vec128<ushort> src, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt16> Z0.dinx::flip(Z0.Vec128`1<System.UInt16>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt16>&,System.UInt16&)
    IL_000F: ret

}
void flip(in Vec128<int> src, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int32> Z0.dinx::flip(Z0.Vec128`1<System.Int32>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void Z0.dinx::store(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_000F: ret

}
void flip(in Vec128<uint> src, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt32> Z0.dinx::flip(Z0.Vec128`1<System.UInt32>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void Z0.dinx::store(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_000F: ret

}
void flip(in Vec256<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.SByte> Z0.dinx::flip(Z0.Vec256`1<System.SByte>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void Z0.dinx::store(Z0.Vec256`1<System.SByte>&,System.SByte&)
    IL_000F: ret

}
void flip(in Vec256<byte> src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Byte> Z0.dinx::flip(Z0.Vec256`1<System.Byte>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Byte>&,System.Byte&)
    IL_000F: ret

}
void flip(in Vec256<short> src, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int16> Z0.dinx::flip(Z0.Vec256`1<System.Int16>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_000F: ret

}
void flip(in Vec256<ushort> src, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt16> Z0.dinx::flip(Z0.Vec256`1<System.UInt16>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_000F: ret

}
void flip(in Vec256<int> src, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int32> Z0.dinx::flip(Z0.Vec256`1<System.Int32>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_000F: ret

}
void flip(in Vec256<uint> src, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt32> Z0.dinx::flip(Z0.Vec256`1<System.UInt32>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_000F: ret

}
void flip(in Vec256<long> src, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int64> Z0.dinx::flip(Z0.Vec256`1<System.Int64>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void Z0.dinx::store(Z0.Vec256`1<System.Int64>&,System.Int64&)
    IL_000F: ret

}
void flip(in Vec256<ulong> src, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt64> Z0.dinx::flip(Z0.Vec256`1<System.UInt64>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call System.Void Z0.dinx::store(Z0.Vec256`1<System.UInt64>&,System.UInt64&)
    IL_000F: ret

}
UInt128 or(in UInt128 lhs, in UInt128 rhs)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128&)
    IL_000F: stloc.1
    IL_0010: ldloca.s V_1
    IL_0012: call Z0.Vec128`1<System.UInt64> Z0.dinx::or(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0017: stloc.2
    IL_0018: ldloca.s V_2
    IL_001A: call Z0.UInt128 Z0.UInt128X::ToUInt128(Z0.Vec128`1<System.UInt64>&)
    IL_001F: ret

}
ref UInt128 or(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.1
    IL_000B: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128&)
    IL_0010: stloc.1
    IL_0011: ldloca.s V_1
    IL_0013: call Z0.Vec128`1<System.UInt64> Z0.dinx::or(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0018: stloc.2
    IL_0019: ldloca.s V_2
    IL_001B: call Z0.UInt128 Z0.UInt128X::ToUInt128(Z0.Vec128`1<System.UInt64>&)
    IL_0020: stobj Z0.UInt128
    IL_0025: ldarg.2
    IL_0026: ret

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

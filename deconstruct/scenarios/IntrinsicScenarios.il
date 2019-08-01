// 2019-07-31 06:08:35:411
Vector128<sbyte> addv8u128(in Vector128<sbyte> lhs, in Vector128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector128`1<System.SByte>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.SByte>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: ret

}
Vector128<sbyte> add2(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<sbyte> add3(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector256<sbyte> add4(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<sbyte> add5(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<long> shiftlw(in Vector256<long> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_000C: ret

}
Vector256<ulong> shiftlw(Vector256<ulong> src, byte count)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vector128<float> permute(in Vector128<float> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector128`1<System.Single>
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Permute(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Byte)
    IL_000C: ret

}
Vector128<double> permute(in Vector128<double> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector128`1<System.Double>
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Permute(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Byte)
    IL_000C: ret

}
Vector128<float> permute(in Vector128<float> lhs, in Vector128<int> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector128`1<System.Single>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.Int32>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Avx::PermuteVar(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ret

}
Vector128<double> permute(in Vector128<double> lhs, in Vector128<long> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector128`1<System.Double>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.Int64>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Avx::PermuteVar(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: ret

}
Vector256<float> permute(Vector256<float> lhs, in Vector256<int> control)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::PermuteVar(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000C: ret

}
Vector256<double> permute(Vector256<double> lhs, in Vector256<long> control)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::PermuteVar(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_000C: ret

}
Vector256<sbyte> permute2x128(in Vector256<sbyte> lhs, in Vector256<sbyte> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.SByte>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.SByte>
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Byte)
    IL_0012: ret

}
Vector256<byte> permute2x128(in Vector256<byte> lhs, in Vector256<byte> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0012: ret

}
Vector256<short> permute2x128(in Vector256<short> lhs, in Vector256<short> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int16>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int16>
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0012: ret

}
Vector256<ushort> permute2x128(in Vector256<ushort> lhs, in Vector256<ushort> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.UInt16>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.UInt16>
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0012: ret

}
Vector256<int> permute2x128(in Vector256<int> lhs, in Vector256<int> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0012: ret

}
Vector256<uint> permute2x128(in Vector256<uint> lhs, in Vector256<uint> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0012: ret

}
Vector256<long> permute2x128(in Vector256<long> lhs, in Vector256<long> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0012: ret

}
Vector256<ulong> permute2x128(in Vector256<ulong> lhs, in Vector256<ulong> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0012: ret

}
Vector256<float> permute2x128(in Vector256<float> lhs, in Vector256<float> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.Single>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.Single>
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Byte)
    IL_0012: ret

}
Vector256<double> permute2x128(in Vector256<double> lhs, in Vector256<double> rhs, byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.Double>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.Double>
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_0012: ret

}
Vector256<int> permute8x32(in Vector256<int> src, in Vector256<int> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
Vector256<uint> permute8x32(in Vector256<uint> src, in Vector256<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ret

}
Vector256<float> permute8x32(in Vector256<float> src, in Vector256<int> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.Single>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
Vector256<long> permute4x64(in Vector256<long> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_000C: ret

}
Vector256<ulong> permute4x64(in Vector256<ulong> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_000C: ret

}
Vector256<double> permute4x64(in Vector256<double> value, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.Double>
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_000C: ret

}
bool testz(in Vector128<byte> lhs, in Vector128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector128`1<System.Byte>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.Byte>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: ret

}
bool testz(in Vector128<sbyte> lhs, in Vector128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector128`1<System.SByte>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.SByte>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: ret

}
bool testz(in Vector128<short> lhs, in Vector128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector128`1<System.Int16>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.Int16>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
bool testz(in Vector128<ushort> lhs, in Vector128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector128`1<System.UInt16>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.UInt16>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
bool testz(in Vector128<int> lhs, in Vector128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector128`1<System.Int32>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.Int32>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ret

}
bool testz(in Vector128<uint> lhs, in Vector128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector128`1<System.UInt32>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.UInt32>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: ret

}
bool testz(in Vector128<long> lhs, in Vector128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector128`1<System.Int64>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.Int64>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: ret

}
bool testz(in Vector128<ulong> lhs, in Vector128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector128`1<System.UInt64>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.UInt64>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: ret

}
bool testz(in Vector128<float> lhs, in Vector128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector128`1<System.Single>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.Single>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: ret

}
bool testz(in Vector128<double> lhs, in Vector128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector128`1<System.Double>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.Double>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: ret

}
bool testz(in Vector256<sbyte> lhs, in Vector256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.SByte>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.SByte>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: ret

}
bool testz(in Vector256<byte> lhs, in Vector256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: ret

}
bool testz(in Vector256<short> lhs, in Vector256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int16>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int16>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: ret

}
bool testz(in Vector256<ushort> lhs, in Vector256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.UInt16>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.UInt16>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: ret

}
bool testz(in Vector256<int> lhs, in Vector256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
bool testz(in Vector256<uint> lhs, in Vector256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ret

}
bool testz(in Vector256<long> lhs, in Vector256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: ret

}
bool testz(in Vector256<ulong> lhs, in Vector256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: ret

}
bool testz(in Vector256<float> lhs, in Vector256<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.Single>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.Single>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: ret

}
bool testz(in Vector256<double> lhs, in Vector256<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj System.Runtime.Intrinsics.Vector256`1<System.Double>
    IL_0006: ldarg.1
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.Double>
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: ret

}

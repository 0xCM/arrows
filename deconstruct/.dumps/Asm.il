// 2019-09-22 15:32:03:480
XMM pmovzxbw(XMM a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.XMM&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
Vector128<short> pmovzxbw_ref(Vector128<byte> a)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0006: ret

}
XMM pmovzxbd(XMM a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.XMM&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ret

}
ref XMM pmovzxbd_out_xmm(XMM a, out XMM dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s a
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.XMM&)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000D: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0012: stobj Z0.XMM
    IL_0017: ldarg.1
    IL_0018: ret

}
ref Vector128<int> pmovzxbd_out_vec(XMM a, out Vector128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s a
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.XMM&)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000D: stobj System.Runtime.Intrinsics.Vector128`1<System.Int32>
    IL_0012: ldarg.1
    IL_0013: ret

}
Vector128<int> pmovzxbd_ref(Vector128<byte> a)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0006: ret

}
XMM pmovzxbq(XMM a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.XMM&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: ret

}
XMM pmovzxwd(XMM a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Asm::vload<System.UInt16>(Z0.XMM&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_000C: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ret

}
XMM pmovzxwq(XMM a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Asm::vload<System.UInt16>(Z0.XMM&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_000C: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: ret

}
XMM pmovzxdq(XMM a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Asm::vload<System.UInt32>(Z0.XMM&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000C: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: ret

}
XMM pmovzxbd32(XMM a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.XMM&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ret

}
XMM pmovzxbq64(XMM a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.XMM&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: ret

}
XMM pmovzxbw16(XMM a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.XMM&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
ref XMM movdqa(XMM src, ref XMM dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.XMM&)
    IL_0008: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_000D: stobj Z0.XMM
    IL_0012: ldarg.1
    IL_0013: ret

}
ref XMEM movdqa(XMM src, ref XMEM dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.XMM&)
    IL_0008: call Z0.XMEM Z0.XMEM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_000D: stobj Z0.XMEM
    IL_0012: ldarg.1
    IL_0013: ret

}
ref YMM vmovdqa(YMM src, ref YMM dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.YMM&)
    IL_0008: call Z0.YMM Z0.YMM::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000D: stobj Z0.YMM
    IL_0012: ldarg.1
    IL_0013: ret

}
ref YMEM vmovdqa(YMM src, ref YMEM dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarga.s src
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.YMM&)
    IL_0008: call Z0.YMEM Z0.YMEM::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000D: stobj Z0.YMEM
    IL_0012: ldarg.1
    IL_0013: ret

}
Vector256<int> vpadd_ref1(Vector256<int> v1, Vector256<int> v2)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vec256<int> vpadd_ref2(Vec256<int> v1, Vec256<int> v2)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
YMM vpadd(YMM ymm0, YMM ymm1)
{
    IL_0000: ldarga.s ymm0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Asm::vload<System.Int64>(Z0.YMM&)
    IL_0007: ldarga.s ymm1
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Asm::vload<System.Int64>(Z0.YMM&)
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0013: call Z0.YMM Z0.YMM::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0018: ret

}
ref Vector256<long> vpadd(YMM ymm0, YMM ymm1, ref Vector256<long> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarga.s ymm0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Asm::vload<System.Int64>(Z0.YMM&)
    IL_0008: ldarga.s ymm1
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Asm::vload<System.Int64>(Z0.YMM&)
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0014: stobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_0019: ldarg.2
    IL_001A: ret

}
XMM vpblendw(XMM xmm2, XMM xmm3, Imm8 imm8)
{
    IL_0000: ldarga.s xmm2
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Asm::vload<System.UInt16>(Z0.XMM&)
    IL_0007: ldarga.s xmm3
    IL_0009: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Asm::vload<System.UInt16>(Z0.XMM&)
    IL_000E: ldarg.2
    IL_000F: call System.Byte Z0.IMM/Imm8::op_Implicit(Z0.IMM/Imm8)
    IL_0014: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse41::Blend(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0019: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001E: ret

}
Vector128<ushort> vpblendw_ref(Vector128<ushort> xmm0, Vector128<ushort> xmm1, byte imm8)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse41::Blend(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0008: ret

}
Vector256<ushort> vpblendw_ref(Vector256<ushort> xmm0, Vector256<ushort> xmm1, byte imm8)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0008: ret

}
Vector256<uint> vpblendd_ref(Vector256<uint> xmm0, Vector256<uint> xmm1, byte imm8)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0008: ret

}
Vector256<float> vpblendps_ref(Vector256<float> xmm0, Vector256<float> xmm1, byte imm8)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Blend(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Byte)
    IL_0008: ret

}
XMM vpcmpeqb(XMM xmm0, XMM xmm1)
{
    IL_0000: ldarga.s xmm0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.XMM&)
    IL_0007: ldarga.s xmm1
    IL_0009: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.XMM&)
    IL_000E: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0013: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0018: ret

}
ref Vector128<byte> vpcmpeqb(XMM xmm0, XMM xmm1, ref Vector128<byte> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarga.s xmm0
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.XMM&)
    IL_0008: ldarga.s xmm1
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.XMM&)
    IL_000F: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0014: stobj System.Runtime.Intrinsics.Vector128`1<System.Byte>
    IL_0019: ldarg.2
    IL_001A: ret

}
Vector256<ulong> vcmpeqq_ref(Vector256<ulong> ymm0, Vector256<ulong> ymm1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
YMM vcmpeqq(YMM ymm0, YMM ymm1)
{
    IL_0000: ldarga.s ymm0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.YMM&)
    IL_0007: ldarga.s ymm1
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.YMM&)
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0013: call Z0.YMM Z0.YMM::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0018: ret

}
ref Vector256<ulong> vcmpeqq(YMM ymm0, YMM ymm1, ref Vector256<ulong> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarga.s ymm0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.YMM&)
    IL_0008: ldarga.s ymm1
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.YMM&)
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0014: stobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_0019: ldarg.2
    IL_001A: ret

}
Vector256<byte> vpcmpeqb(YMM ymm0, YMM ymm1)
{
    IL_0000: ldarga.s ymm0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.YMM&)
    IL_0007: ldarga.s ymm1
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.YMM&)
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0013: ret

}
Vector256<byte> vcmpeqb(MemoryBuffer ymm0, MemoryBuffer ymm1)
{
    IL_0000: ldarga.s ymm0
    IL_0002: call System.Byte& Z0.MemoryBuffer::Head<System.Byte>()
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::load256(System.Byte&)
    IL_000C: stloc.0
    IL_000D: ldarga.s ymm1
    IL_000F: call System.Byte& Z0.MemoryBuffer::Head<System.Byte>()
    IL_0014: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::load256(System.Byte&)
    IL_0019: stloc.1
    IL_001A: ldloc.0
    IL_001B: ldloc.1
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vector256<ulong> vperm2i128(YMM a, YMM b, byte control)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.YMM&)
    IL_0007: ldarga.s b
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.YMM&)
    IL_000E: ldarg.2
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0014: ret

}
Vector256<ulong> vperm2i128(Vector256<ulong> a, Vector256<ulong> b, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0008: ret

}
Vector256<double> vperm2f128(YMM a, YMM b, byte control)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Asm::vload<System.Double>(Z0.YMM&)
    IL_0007: ldarga.s b
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Asm::vload<System.Double>(Z0.YMM&)
    IL_000E: ldarg.2
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_0014: ret

}
YMM vperm2i128(YMM a, YMM b, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vperm2i128(Z0.YMM,Z0.YMM,System.Byte)
    IL_0008: call Z0.YMM Z0.YMM::From<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000D: ret

}
Vector256<byte> vperm2f128(YMM a, YMM b, byte control)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.YMM&)
    IL_0007: ldarga.s b
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.YMM&)
    IL_000E: ldarg.2
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0014: ret

}
Vector256<uint> vpermd(YMM src, YMM control)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Asm::vload<System.UInt32>(Z0.YMM&)
    IL_0007: ldarga.s control
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Asm::vload<System.UInt32>(Z0.YMM&)
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0013: ret

}
Perm<N8> ToPerm(uint rep)
{
    IL_0000: ldarg.0
    IL_0001: stloc.0
    IL_0002: call Z0.Perm`1<Z0.N8> Z0.Perm`1<Z0.N8>::Alloc()
    IL_0007: stloc.1
    IL_0008: ldc.i4.0
    IL_0009: stloc.2
    IL_000A: ldc.i4.0
    IL_000B: stloc.3
    IL_000C: br.s IL_0034
    IL_000E: ldloca.s V_1
    IL_0010: ldloc.2
    IL_0011: call System.Int32& Z0.Perm`1<Z0.N8>::get_Item(System.Int32)
    IL_0016: ldloca.s V_0
    IL_0018: ldloc.3
    IL_0019: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_001E: ldloc.3
    IL_001F: ldc.i4.2
    IL_0020: add
    IL_0021: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_0026: call System.UInt32 Z0.BitMask::between(System.UInt32&,Z0.BitPos,Z0.BitPos)
    IL_002B: stind.i4
    IL_002C: ldloc.2
    IL_002D: ldc.i4.1
    IL_002E: add
    IL_002F: stloc.2
    IL_0030: ldloc.3
    IL_0031: ldc.i4.3
    IL_0032: add
    IL_0033: stloc.3
    IL_0034: ldloc.2
    IL_0035: ldloca.s V_1
    IL_0037: call System.Int32 Z0.Perm`1<Z0.N8>::get_Length()
    IL_003C: blt.s IL_000E
    IL_003E: ldloc.1
    IL_003F: ret

}
YMM vpermd(YMM src, uint spec)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.Perm`1<Z0.N8> Z0.Asm::ToPerm(Z0.Perm8)
    IL_0006: stloc.0
    IL_0007: ldarga.s src
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Asm::vload<System.Int32>(Z0.YMM&)
    IL_000E: stloc.1
    IL_000F: ldloca.s V_0
    IL_0011: ldc.i4.0
    IL_0012: call System.Int32& Z0.Perm`1<Z0.N8>::get_Item(System.Int32)
    IL_0017: call Z0.Vec256`1<System.Int32> Z0.ginx::lddqu256<System.Int32>(System.Int32&)
    IL_001C: stloc.2
    IL_001D: ldloc.1
    IL_001E: ldloc.2
    IL_001F: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0024: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0029: call Z0.YMM Z0.YMM::From<System.Int32>(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_002E: ret

}
XMM pxor(XMM xmm0, XMM xmm1)
{
    IL_0000: ldarga.s xmm0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.XMM&)
    IL_0007: ldarga.s xmm1
    IL_0009: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.XMM&)
    IL_000E: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0013: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0018: ret

}
Vector256<ulong> vpxor_ref(Vector256<ulong> ymm0, Vector256<ulong> ymm1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
YMM vpxor(YMM ymm0, YMM ymm1)
{
    IL_0000: ldarga.s ymm0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.YMM&)
    IL_0007: ldarga.s ymm1
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.YMM&)
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0013: call Z0.YMM Z0.YMM::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0018: ret

}
ref YMM vpxor(YMM ymm0, YMM ymm1, ref YMM ymm2)
{
    IL_0000: ldarg.2
    IL_0001: ldarga.s ymm0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.YMM&)
    IL_0008: ldarga.s ymm1
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.YMM&)
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0014: call Z0.YMM Z0.YMM::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0019: stobj Z0.YMM
    IL_001E: ldarg.2
    IL_001F: ret

}
ref Vector256<ulong> vpxor(YMM ymm0, YMM ymm1, out Vector256<ulong> ymm2)
{
    IL_0000: ldarg.2
    IL_0001: ldarga.s ymm0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.YMM&)
    IL_0008: ldarga.s ymm1
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.YMM&)
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0014: stobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_0019: ldarg.2
    IL_001A: ret

}

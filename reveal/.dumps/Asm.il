// 2019-09-24 17:05:47:204
XMM pmovzxbw(XMM a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.XMM&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

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
YMM vpaddq(YMM ymm0, YMM ymm1)
{
    IL_0000: ldarga.s ymm0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.YMM&)
    IL_0007: ldarga.s ymm1
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.YMM&)
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0013: call Z0.YMM Z0.YMM::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0018: ret

}
YMM<long> vpaddq(YMM<long> ymm0, YMM<long> ymm1)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.YMM`1<System.Int64>::op_Implicit(Z0.YMM`1<System.Int64>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.YMM`1<System.Int64>::op_Implicit(Z0.YMM`1<System.Int64>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.YMM`1<System.Int64> Z0.YMM`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
YMM<ulong> vpaddq(YMM<ulong> ymm0, YMM<ulong> ymm1)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.YMM`1<System.UInt64>::op_Implicit(Z0.YMM`1<System.UInt64>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.YMM`1<System.UInt64>::op_Implicit(Z0.YMM`1<System.UInt64>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.YMM`1<System.UInt64> Z0.YMM`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
ref YMM<long> vpaddq(YMM ymm0, YMM ymm1, ref YMM<long> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarga.s ymm0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Asm::vload<System.Int64>(Z0.YMM&)
    IL_0008: ldarga.s ymm1
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Asm::vload<System.Int64>(Z0.YMM&)
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0014: call Z0.YMM`1<System.Int64> Z0.YMM`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0019: stobj Z0.YMM`1<System.Int64>
    IL_001E: ldarg.2
    IL_001F: ret

}
ref YMM<ulong> vpaddq(YMM ymm0, YMM ymm1, ref YMM<ulong> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarga.s ymm0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.YMM&)
    IL_0008: ldarga.s ymm1
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vload<System.UInt64>(Z0.YMM&)
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0014: call Z0.YMM`1<System.UInt64> Z0.YMM`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0019: stobj Z0.YMM`1<System.UInt64>
    IL_001E: ldarg.2
    IL_001F: ret

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
YMM vperm2i128(YMM a, YMM b, Perm2x128:byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::vperm2i128(Z0.YMM,Z0.YMM,System.Byte)
    IL_0008: call Z0.YMM Z0.YMM::From<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000D: ret

}
Vector256<byte> vperm2f128(YMM a, YMM b, Perm2x128:byte control)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.YMM&)
    IL_0007: ldarga.s b
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Asm::vload<System.Byte>(Z0.YMM&)
    IL_000E: ldarg.2
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0014: ret

}
YMM vpermd(YMM src, YMM control)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Asm::vload<System.UInt32>(Z0.YMM&)
    IL_0007: ldarga.s control
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Asm::vload<System.UInt32>(Z0.YMM&)
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0013: call Z0.YMM Z0.YMM::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0018: ret

}
YMM<uint> vpermd(YMM<uint> ymm0, Perm8 spec)
{
    IL_0000: ldarga.s spec
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Asm::vload<System.UInt32>(Z0.Perm8&)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.YMM`1<System.UInt32>::op_Implicit(Z0.YMM`1<System.UInt32>)
    IL_000E: ldloc.0
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0014: call Z0.YMM`1<System.UInt32> Z0.YMM`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0019: ret

}
YMM vpermd(YMM src, Perm8 spec)
{
    IL_0000: ldarga.s spec
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Asm::vload<System.UInt32>(Z0.Perm8&)
    IL_0007: stloc.0
    IL_0008: ldarga.s src
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Asm::vload<System.UInt32>(Z0.YMM&)
    IL_000F: stloc.1
    IL_0010: ldloc.1
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0017: call Z0.YMM Z0.YMM::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001C: ret

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

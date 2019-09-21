// 2019-09-21 00:21:45:615
XMM pmovzxbw(in XMM a)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Reg::vec<System.Byte>(Z0.XMM&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000B: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0010: ret

}
XMM pmovzxbd(in XMM a)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Reg::vec<System.Byte>(Z0.XMM&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000B: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0010: ret

}
XMM pmovzxbq(in XMM a)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Reg::vec<System.Byte>(Z0.XMM&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000B: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0010: ret

}
XMM pmovzxwd(in XMM a)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Reg::vec<System.UInt16>(Z0.XMM&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_000B: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0010: ret

}
XMM pmovzxwq(in XMM a)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Reg::vec<System.UInt16>(Z0.XMM&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_000B: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0010: ret

}
XMM pmovzxdq(in XMM a)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Reg::vec<System.UInt32>(Z0.XMM&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000B: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0010: ret

}
ref XMM pmovzxbd(in XMM a, ref XMM b)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Reg::vec<System.Byte>(Z0.XMM&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: stobj Z0.XMM
    IL_0016: ldarg.1
    IL_0017: ret

}
ref XMM pmovzxbq(in XMM a, ref XMM b)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Reg::vec<System.Byte>(Z0.XMM&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: stobj Z0.XMM
    IL_0016: ldarg.1
    IL_0017: ret

}
ref XMM pmovzxbw(in XMM a, ref XMM b)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Reg::vec<System.Byte>(Z0.XMM&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: stobj Z0.XMM
    IL_0016: ldarg.1
    IL_0017: ret

}
ref XMM movdqa(in XMM src, ref XMM dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.XMM
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call System.UInt64& Z0.XMM::First<System.UInt64>()
    IL_000E: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Asm::load128(System.UInt64&)
    IL_0013: ldarg.1
    IL_0014: call Z0.XMM& Z0.Reg::move<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,Z0.XMM&)
    IL_0019: ret

}
ref XMEM movdqa(in XMM src, ref XMEM dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.XMM
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call System.UInt64& Z0.XMM::First<System.UInt64>()
    IL_000E: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Asm::load128(System.UInt64&)
    IL_0013: ldarg.1
    IL_0014: call Z0.XMEM& Z0.Reg::move<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,Z0.XMEM&)
    IL_0019: ret

}
ref YMM vmovdqa(in YMM src, ref YMM dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.YMM
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call System.UInt64& Z0.YMM::First<System.UInt64>()
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::load256(System.UInt64&)
    IL_0013: ldarg.1
    IL_0014: call Z0.YMM& Z0.Reg::move<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.YMM&)
    IL_0019: ret

}
ref YMEM vmovdqa(in YMM src, ref YMEM dst)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.YMM
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call System.UInt64& Z0.YMM::First<System.UInt64>()
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Asm::load256(System.UInt64&)
    IL_0013: ldarg.1
    IL_0014: call Z0.YMEM& Z0.Reg::move<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.YMEM&)
    IL_0019: ret

}
Vector128<ulong> load128(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::LoadAlignedVector128(System.UInt64*)
    IL_000B: ret

}
Vector256<ulong> load256(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::LoadAlignedVector256(System.UInt64*)
    IL_000B: ret

}
ref XMM vpblendw(ref XMM xmm1, in XMM xmm2, in XMM xmm3, Imm8 imm8)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Reg::vec<System.UInt16>(Z0.XMM&)
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Reg::vec<System.UInt16>(Z0.XMM&)
    IL_000D: ldarg.3
    IL_000E: call System.Byte Z0.IMM/Imm8::op_Implicit(Z0.IMM/Imm8)
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse41::Blend(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0018: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001D: stobj Z0.XMM
    IL_0022: ldarg.0
    IL_0023: ret

}
XMM vpblendw(XMM xmm2, XMM xmm3, Imm8 imm8)
{
    IL_0000: ldarga.s xmm2
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Reg::vec<System.UInt16>(Z0.XMM&)
    IL_0007: ldarga.s xmm3
    IL_0009: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Reg::vec<System.UInt16>(Z0.XMM&)
    IL_000E: ldarg.2
    IL_000F: call System.Byte Z0.IMM/Imm8::op_Implicit(Z0.IMM/Imm8)
    IL_0014: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse41::Blend(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0019: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001E: ret

}
Vector256<int> vpblendd(Vector256<int> ymm2, Vector256<int> ymm3, byte imm8)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0008: ret

}
Vector256<int> vpaddd(Vector256<int> ymm2, Vector256<int> ymm3)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
ref XMM vpcmpeqb(ref XMM xmm1, in XMM xmm2, in XMM xmm3)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Reg::vec<System.Byte>(Z0.XMM&)
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Reg::vec<System.Byte>(Z0.XMM&)
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0012: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0017: stobj Z0.XMM
    IL_001C: ldarg.0
    IL_001D: ret

}
ref YMM vpcmpeqb(ref YMM ymm1, in YMM ymm2, in YMM ymm3)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Reg::vec<System.Byte>(Z0.YMM&)
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Reg::vec<System.Byte>(Z0.YMM&)
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0012: call Z0.YMM Z0.YMM::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0017: stobj Z0.YMM
    IL_001C: ldarg.0
    IL_001D: ret

}
YMM vperm2i128(in YMM a, in YMM b, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Reg::vec<System.UInt64>(Z0.YMM&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Reg::vec<System.UInt64>(Z0.YMM&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0012: call Z0.YMM Z0.YMM::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0017: ret

}
YMM vperm2f128(in YMM a, in YMM b, byte control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Reg::vec<System.Double>(Z0.YMM&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Reg::vec<System.Double>(Z0.YMM&)
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_0012: call Z0.YMM Z0.YMM::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0017: ret

}
YMM vperm2i128(in YMM a, in YMM b, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.YMM Z0.Asm::vperm2i128(Z0.YMM&,Z0.YMM&,System.Byte)
    IL_0008: ret

}
YMM vperm2f128(in YMM a, in YMM b, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.YMM Z0.Asm::vperm2f128(Z0.YMM&,Z0.YMM&,System.Byte)
    IL_0008: ret

}
YMM vpermd(in YMM src, in YMM control)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Reg::vec<System.UInt32>(Z0.YMM&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Reg::vec<System.UInt32>(Z0.YMM&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.YMM Z0.YMM::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
YMM vpermd(in YMM src, uint spec)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.Perm`1<Z0.N8> Z0.PermX::ToPerm(Z0.Perm8)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldc.i4.0
    IL_000A: call System.Int32& Z0.Perm`1<Z0.N8>::get_Item(System.Int32)
    IL_000F: call Z0.YMM Z0.YMM::Load<System.Int32>(System.Int32&)
    IL_0014: stloc.1
    IL_0015: ldarg.0
    IL_0016: ldloca.s V_1
    IL_0018: call Z0.YMM Z0.Asm::vpermd(Z0.YMM&,Z0.YMM&)
    IL_001D: ret

}
XMM pxor(in XMM a, in XMM b)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Reg::vec<System.UInt64>(Z0.XMM&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Reg::vec<System.UInt64>(Z0.XMM&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.XMM Z0.XMM::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
YMM vpxor(in YMM a, in YMM b)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Reg::vec<System.UInt64>(Z0.YMM&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Reg::vec<System.UInt64>(Z0.YMM&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.YMM Z0.YMM::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}

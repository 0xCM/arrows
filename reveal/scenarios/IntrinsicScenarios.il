// 2019-09-25 03:34:27:209
BitVector64 newBv64(ulong src)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.BitVector64 Z0.bitvector::bv64<System.UInt64>(System.UInt64)
    IL_0006: ret

}
BitVector64 newBv64(int src)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.BitVector64 Z0.bitvector::bv64<System.Int32>(System.Int32)
    IL_0006: ret

}
BitVector64 newBv8(int src)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.BitVector64 Z0.bitvector::bv64<System.Int32>(System.Int32)
    IL_0006: ret

}
int abs(int x)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int32 Z0.gmath::abs<System.Int32>(System.Int32)
    IL_0006: ret

}
uint add(uint a, uint b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.gmath::add<System.UInt32>(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint and(uint a, uint b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.gmath::and<System.UInt32>(System.UInt32,System.UInt32)
    IL_0007: ret

}
Vector256<byte> load(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::lddqu256<System.Byte>(System.Byte&)
    IL_0006: ret

}
uint xor32u(uint x, uint y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.gmath::xor<System.UInt32>(System.UInt32,System.UInt32)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.1
    IL_000B: call System.UInt32& Z0.gmath::xor<System.UInt32>(System.UInt32&,System.UInt32)
    IL_0010: ldind.u4
    IL_0011: ret

}
Vector256<uint> xor256x32u(Vector256<uint> ymm0, Vector256<uint> ymm1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.gbits::vxor<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<uint> and256x32u(Vector256<uint> ymm0, Vector256<uint> ymm1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.gbits::vand<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<byte> vpxor(in byte ymm0, in byte ymm1, in byte ymm2, in byte ymm3)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldloca.s V_0
    IL_0004: ldloca.s V_1
    IL_0006: call System.Void Z0.dinx::load256(System.Byte&,System.Byte&,System.Runtime.Intrinsics.Vector256`1<System.Byte>&,System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_000B: ldarg.2
    IL_000C: ldarg.3
    IL_000D: ldloca.s V_2
    IL_000F: ldloca.s V_3
    IL_0011: call System.Void Z0.dinx::load256(System.Byte&,System.Byte&,System.Runtime.Intrinsics.Vector256`1<System.Byte>&,System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0016: ldloc.0
    IL_0017: ldloc.1
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001D: stloc.s V_4
    IL_001F: ldloc.2
    IL_0020: ldloc.3
    IL_0021: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0026: stloc.s V_5
    IL_0028: ldloc.s V_4
    IL_002A: ldloc.s V_5
    IL_002C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0031: stloc.s V_6
    IL_0033: ldloc.s V_6
    IL_0035: ret

}
Vector256<ulong> vpaddq(in ulong ymm0, in ulong ymm1, in ulong ymm2, in ulong ymm3, in ulong ymm4, in ulong ymm5, in ulong ymm6, in ulong ymm7, in ulong ymm8, in ulong ymm9, in ulong ymm10, in ulong ymm11, in ulong ymm12, in ulong ymm13, in ulong ymm14, in ulong ymm15)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::lddqu256(System.UInt64&)
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::lddqu256(System.UInt64&)
    IL_000D: stloc.1
    IL_000E: ldarg.2
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::lddqu256(System.UInt64&)
    IL_0014: stloc.2
    IL_0015: ldarg.3
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::lddqu256(System.UInt64&)
    IL_001B: stloc.3
    IL_001C: ldarg.s ymm4
    IL_001E: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::lddqu256(System.UInt64&)
    IL_0023: stloc.s V_4
    IL_0025: ldarg.s ymm5
    IL_0027: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::lddqu256(System.UInt64&)
    IL_002C: stloc.s V_5
    IL_002E: ldarg.s ymm6
    IL_0030: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::lddqu256(System.UInt64&)
    IL_0035: stloc.s V_6
    IL_0037: ldarg.s ymm7
    IL_0039: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::lddqu256(System.UInt64&)
    IL_003E: stloc.s V_7
    IL_0040: ldarg.s ymm8
    IL_0042: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::lddqu256(System.UInt64&)
    IL_0047: stloc.s V_8
    IL_0049: ldarg.s ymm9
    IL_004B: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::lddqu256(System.UInt64&)
    IL_0050: stloc.s V_9
    IL_0052: ldarg.s ymm10
    IL_0054: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::lddqu256(System.UInt64&)
    IL_0059: stloc.s V_10
    IL_005B: ldarg.s ymm11
    IL_005D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::lddqu256(System.UInt64&)
    IL_0062: stloc.s V_11
    IL_0064: ldarg.s ymm12
    IL_0066: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::lddqu256(System.UInt64&)
    IL_006B: stloc.s V_12
    IL_006D: ldarg.s ymm13
    IL_006F: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::lddqu256(System.UInt64&)
    IL_0074: stloc.s V_13
    IL_0076: ldarg.s ymm14
    IL_0078: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::lddqu256(System.UInt64&)
    IL_007D: stloc.s V_14
    IL_007F: ldarg.s ymm15
    IL_0081: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::lddqu256(System.UInt64&)
    IL_0086: stloc.s V_15
    IL_0088: ldloc.0
    IL_0089: ldloc.1
    IL_008A: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_008F: stloc.s V_16
    IL_0091: ldloc.2
    IL_0092: ldloc.3
    IL_0093: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0098: stloc.s V_17
    IL_009A: ldloc.s V_4
    IL_009C: ldloc.s V_5
    IL_009E: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_00A3: stloc.s V_18
    IL_00A5: ldloc.s V_6
    IL_00A7: ldloc.s V_7
    IL_00A9: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_00AE: stloc.s V_19
    IL_00B0: ldloc.s V_8
    IL_00B2: ldloc.s V_9
    IL_00B4: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_00B9: stloc.s V_20
    IL_00BB: ldloc.s V_10
    IL_00BD: ldloc.s V_11
    IL_00BF: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_00C4: stloc.s V_21
    IL_00C6: ldloc.s V_12
    IL_00C8: ldloc.s V_13
    IL_00CA: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_00CF: stloc.s V_22
    IL_00D1: ldloc.s V_14
    IL_00D3: ldloc.s V_15
    IL_00D5: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_00DA: stloc.s V_23
    IL_00DC: ldloc.s V_16
    IL_00DE: ldloc.s V_17
    IL_00E0: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_00E5: stloc.s V_24
    IL_00E7: ldloc.s V_18
    IL_00E9: ldloc.s V_19
    IL_00EB: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_00F0: stloc.s V_25
    IL_00F2: ldloc.s V_19
    IL_00F4: ldloc.s V_20
    IL_00F6: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_00FB: stloc.s V_26
    IL_00FD: ldloc.s V_20
    IL_00FF: ldloc.s V_21
    IL_0101: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0106: stloc.s V_27
    IL_0108: ldloc.s V_22
    IL_010A: ldloc.s V_23
    IL_010C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0111: stloc.s V_28
    IL_0113: ldloc.s V_24
    IL_0115: ldloc.s V_25
    IL_0117: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_011C: stloc.s V_29
    IL_011E: ldloc.s V_26
    IL_0120: ldloc.s V_27
    IL_0122: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0127: stloc.s V_30
    IL_0129: ldloc.s V_29
    IL_012B: ldloc.s V_30
    IL_012D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0132: stloc.s V_31
    IL_0134: ldloc.s V_31
    IL_0136: ldloc.s V_28
    IL_0138: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_013D: stloc.s V_32
    IL_013F: ldloc.s V_32
    IL_0141: ret

}

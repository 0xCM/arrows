// 2019-09-22 15:32:03:543
Vector256<long> perm_256x64i(Vector256<long> ymm0, byte imm8)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0007: ret

}
byte project1(byte src, uint part)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: conv.u1
    IL_0004: stloc.0
    IL_0005: ldloca.s V_0
    IL_0007: call System.Byte Z0.Bits::scatter(System.Byte&,System.Byte&)
    IL_000C: ret

}
byte project2(uint src, uint part)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: stloc.0
    IL_0004: ldloca.s V_0
    IL_0006: call System.UInt32 Z0.Bits::scatter(System.UInt32&,System.UInt32&)
    IL_000B: conv.u1
    IL_000C: ret

}
uint project3(uint src, uint part)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: stloc.0
    IL_0004: ldloca.s V_0
    IL_0006: call System.UInt32 Z0.Bits::scatter(System.UInt32&,System.UInt32&)
    IL_000B: ret

}
uint project4(uint src, uint part)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s part
    IL_0004: call System.UInt32 Z0.Bits::scatter(System.UInt32&,System.UInt32&)
    IL_0009: ret

}
PseudoByte project5(PseudoByte src, uint part)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.PseudoByte::op_Implicit(Z0.PseudoByte)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: stloc.1
    IL_000B: ldloca.s V_1
    IL_000D: call System.UInt32 Z0.Bits::scatter(System.UInt32&,System.UInt32&)
    IL_0012: call Z0.PseudoByte Z0.PseudoByte::op_Implicit(System.UInt32)
    IL_0017: ret

}
PseudoByte project6(PseudoByte src, uint part)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.PseudoByte::op_Implicit(Z0.PseudoByte)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: stloc.1
    IL_000B: ldloca.s V_1
    IL_000D: call System.UInt32 Z0.Bits::scatter(System.UInt32&,System.UInt32&)
    IL_0012: call Z0.PseudoByte Z0.PseudoByte::op_Implicit(System.UInt32)
    IL_0017: ret

}
uint project7(uint src, uint part)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: stloc.0
    IL_0004: ldloca.s V_0
    IL_0006: call System.UInt32 Z0.Bits::scatter(System.UInt32&,System.UInt32&)
    IL_000B: ret

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
Vector256<int> blend_256x32i(in int ymm0, int ymm1, byte imm8)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.dinx::load256(System.Int32&)
    IL_0006: stloc.0
    IL_0007: ldarga.s ymm1
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.dinx::load256(System.Int32&)
    IL_000E: stloc.1
    IL_000F: ldloc.0
    IL_0010: ldloc.1
    IL_0011: ldarg.2
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0017: stloc.2
    IL_0018: ldloc.2
    IL_0019: ret

}
Vector128<byte> vpaddb(Span<byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_000D: stloc.0
    IL_000E: ldarga.s src
    IL_0010: ldc.i4.s 16
    IL_0012: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_001C: stloc.1
    IL_001D: ldarga.s src
    IL_001F: ldc.i4.s 32
    IL_0021: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0026: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_002B: stloc.2
    IL_002C: ldarga.s src
    IL_002E: ldc.i4.s 48
    IL_0030: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0035: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_003A: stloc.3
    IL_003B: ldarga.s src
    IL_003D: ldc.i4.s 64
    IL_003F: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0044: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_0049: stloc.s V_4
    IL_004B: ldarga.s src
    IL_004D: ldc.i4.s 80
    IL_004F: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0054: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_0059: stloc.s V_5
    IL_005B: ldarga.s src
    IL_005D: ldc.i4.s 96
    IL_005F: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0064: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_0069: stloc.s V_6
    IL_006B: ldarga.s src
    IL_006D: ldc.i4.s 112
    IL_006F: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0074: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_0079: stloc.s V_7
    IL_007B: ldarga.s src
    IL_007D: ldc.i4 128
    IL_0082: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0087: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_008C: stloc.s V_8
    IL_008E: ldarga.s src
    IL_0090: ldc.i4 144
    IL_0095: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_009A: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_009F: stloc.s V_9
    IL_00A1: ldarga.s src
    IL_00A3: ldc.i4 160
    IL_00A8: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00AD: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_00B2: stloc.s V_10
    IL_00B4: ldarga.s src
    IL_00B6: ldc.i4 176
    IL_00BB: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00C0: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_00C5: stloc.s V_11
    IL_00C7: ldarga.s src
    IL_00C9: ldc.i4 192
    IL_00CE: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00D3: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_00D8: stloc.s V_12
    IL_00DA: ldarga.s src
    IL_00DC: ldc.i4 208
    IL_00E1: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00E6: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_00EB: stloc.s V_13
    IL_00ED: ldarga.s src
    IL_00EF: ldc.i4 224
    IL_00F4: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_00F9: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_00FE: stloc.s V_14
    IL_0100: ldarga.s src
    IL_0102: ldc.i4 240
    IL_0107: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_010C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_0111: stloc.s V_15
    IL_0113: ldloc.0
    IL_0114: ldloc.1
    IL_0115: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_011A: stloc.s V_16
    IL_011C: ldloc.2
    IL_011D: ldloc.3
    IL_011E: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0123: stloc.s V_17
    IL_0125: ldloc.s V_4
    IL_0127: ldloc.s V_5
    IL_0129: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_012E: stloc.s V_18
    IL_0130: ldloc.s V_6
    IL_0132: ldloc.s V_7
    IL_0134: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0139: stloc.s V_19
    IL_013B: ldloc.s V_8
    IL_013D: ldloc.s V_9
    IL_013F: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0144: stloc.s V_20
    IL_0146: ldloc.s V_10
    IL_0148: ldloc.s V_11
    IL_014A: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_014F: stloc.s V_21
    IL_0151: ldloc.s V_12
    IL_0153: ldloc.s V_13
    IL_0155: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_015A: stloc.s V_22
    IL_015C: ldloc.s V_14
    IL_015E: ldloc.s V_15
    IL_0160: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0165: stloc.s V_23
    IL_0167: ldloc.s V_16
    IL_0169: ldloc.s V_17
    IL_016B: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0170: stloc.s V_24
    IL_0172: ldloc.s V_18
    IL_0174: ldloc.s V_19
    IL_0176: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_017B: stloc.s V_25
    IL_017D: ldloc.s V_19
    IL_017F: ldloc.s V_20
    IL_0181: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0186: stloc.s V_26
    IL_0188: ldloc.s V_20
    IL_018A: ldloc.s V_21
    IL_018C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0191: stloc.s V_27
    IL_0193: ldloc.s V_22
    IL_0195: ldloc.s V_23
    IL_0197: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_019C: stloc.s V_28
    IL_019E: ldloc.s V_24
    IL_01A0: ldloc.s V_25
    IL_01A2: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_01A7: stloc.s V_29
    IL_01A9: ldloc.s V_26
    IL_01AB: ldloc.s V_27
    IL_01AD: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_01B2: stloc.s V_30
    IL_01B4: ldloc.s V_29
    IL_01B6: ldloc.s V_30
    IL_01B8: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_01BD: stloc.s V_31
    IL_01BF: ldloc.s V_31
    IL_01C1: ldloc.s V_28
    IL_01C3: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_01C8: stloc.s V_32
    IL_01CA: ldloc.s V_32
    IL_01CC: ret

}
Vector128<byte> vpaddb(in byte xmm0, in byte xmm1, in byte xmm2, in byte xmm3, in byte xmm4, in byte xmm5, in byte xmm6, in byte xmm7, in byte xmm8, in byte xmm9, in byte xmm10, in byte xmm11, in byte xmm12, in byte xmm13, in byte xmm14, in byte xmm15)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_000D: stloc.1
    IL_000E: ldarg.2
    IL_000F: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_0014: stloc.2
    IL_0015: ldarg.3
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_001B: stloc.3
    IL_001C: ldarg.s xmm4
    IL_001E: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_0023: stloc.s V_4
    IL_0025: ldarg.s xmm5
    IL_0027: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_002C: stloc.s V_5
    IL_002E: ldarg.s xmm6
    IL_0030: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_0035: stloc.s V_6
    IL_0037: ldarg.s xmm7
    IL_0039: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_003E: stloc.s V_7
    IL_0040: ldarg.s xmm8
    IL_0042: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_0047: stloc.s V_8
    IL_0049: ldarg.s xmm9
    IL_004B: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_0050: stloc.s V_9
    IL_0052: ldarg.s xmm10
    IL_0054: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_0059: stloc.s V_10
    IL_005B: ldarg.s xmm11
    IL_005D: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_0062: stloc.s V_11
    IL_0064: ldarg.s xmm12
    IL_0066: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_006B: stloc.s V_12
    IL_006D: ldarg.s xmm13
    IL_006F: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_0074: stloc.s V_13
    IL_0076: ldarg.s xmm14
    IL_0078: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_007D: stloc.s V_14
    IL_007F: ldarg.s xmm15
    IL_0081: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::load128(System.Byte&)
    IL_0086: stloc.s V_15
    IL_0088: ldloc.0
    IL_0089: ldloc.1
    IL_008A: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_008F: stloc.s V_16
    IL_0091: ldloc.2
    IL_0092: ldloc.3
    IL_0093: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0098: stloc.s V_17
    IL_009A: ldloc.s V_4
    IL_009C: ldloc.s V_5
    IL_009E: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_00A3: stloc.s V_18
    IL_00A5: ldloc.s V_6
    IL_00A7: ldloc.s V_7
    IL_00A9: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_00AE: stloc.s V_19
    IL_00B0: ldloc.s V_8
    IL_00B2: ldloc.s V_9
    IL_00B4: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_00B9: stloc.s V_20
    IL_00BB: ldloc.s V_10
    IL_00BD: ldloc.s V_11
    IL_00BF: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_00C4: stloc.s V_21
    IL_00C6: ldloc.s V_12
    IL_00C8: ldloc.s V_13
    IL_00CA: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_00CF: stloc.s V_22
    IL_00D1: ldloc.s V_14
    IL_00D3: ldloc.s V_15
    IL_00D5: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_00DA: stloc.s V_23
    IL_00DC: ldloc.s V_16
    IL_00DE: ldloc.s V_17
    IL_00E0: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_00E5: stloc.s V_24
    IL_00E7: ldloc.s V_18
    IL_00E9: ldloc.s V_19
    IL_00EB: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_00F0: stloc.s V_25
    IL_00F2: ldloc.s V_19
    IL_00F4: ldloc.s V_20
    IL_00F6: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_00FB: stloc.s V_26
    IL_00FD: ldloc.s V_20
    IL_00FF: ldloc.s V_21
    IL_0101: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0106: stloc.s V_27
    IL_0108: ldloc.s V_22
    IL_010A: ldloc.s V_23
    IL_010C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0111: stloc.s V_28
    IL_0113: ldloc.s V_24
    IL_0115: ldloc.s V_25
    IL_0117: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_011C: stloc.s V_29
    IL_011E: ldloc.s V_26
    IL_0120: ldloc.s V_27
    IL_0122: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0127: stloc.s V_30
    IL_0129: ldloc.s V_29
    IL_012B: ldloc.s V_30
    IL_012D: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0132: stloc.s V_31
    IL_0134: ldloc.s V_31
    IL_0136: ldloc.s V_28
    IL_0138: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_013D: stloc.s V_32
    IL_013F: ldloc.s V_32
    IL_0141: ret

}

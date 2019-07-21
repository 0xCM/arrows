// 2019-07-20 02:42:57:544
ReadOnlySpan<byte> get_U8Data()
{
    IL_0000: ldsflda <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::4C95376F0126070C5E113DDFB17BBF8C2071FC7B
    IL_0005: ldc.i4.s 64
    IL_0007: newobj System.Void System.ReadOnlySpan`1<System.Byte>::.ctor(System.Void*,System.Int32)
    IL_000C: ret

}
ReadOnlySpan<uint> get_U32Data()
{
    IL_0000: ldc.i4.s 16
    IL_0002: newarr System.UInt32
    IL_0007: dup
    IL_0008: ldtoken <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::2609FDA7513B2554C91B1C8B04A5DE75A8ED6688
    IL_000D: call System.Void System.Runtime.CompilerServices.RuntimeHelpers::InitializeArray(System.Array,System.RuntimeFieldHandle)
    IL_0012: call System.ReadOnlySpan`1<System.UInt32> System.ReadOnlySpan`1<System.UInt32>::op_Implicit(System.UInt32[])
    IL_0017: ret

}
sbyte AddI8(sbyte x, sbyte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: conv.i1
    IL_0004: ret

}
sbyte AddI8Inline(sbyte x, sbyte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: conv.i1
    IL_0004: ret

}
int AddI32Inline(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
ulong AddU64Inline(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
int SubI32Inline(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ret

}
int MulI32Inline(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
byte AndU8Inline(byte x, byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: conv.u1
    IL_0004: ret

}
ushort AndU16(ushort x, ushort y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: conv.u2
    IL_0004: ret

}
ulong AndU64(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
int AddI32LoopInline()
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0004: br.s IL_000E
    IL_0006: ldloc.0
    IL_0007: ldloc.1
    IL_0008: add
    IL_0009: stloc.0
    IL_000A: ldloc.1
    IL_000B: ldc.i4.1
    IL_000C: add
    IL_000D: stloc.1
    IL_000E: ldloc.1
    IL_000F: ldc.i4.s 100
    IL_0011: blt.s IL_0006
    IL_0013: ldloc.0
    IL_0014: ret

}
int AddI32Loop()
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0004: br.s IL_000E
    IL_0006: ldloc.0
    IL_0007: ldloc.1
    IL_0008: add
    IL_0009: stloc.0
    IL_000A: ldloc.1
    IL_000B: ldc.i4.1
    IL_000C: add
    IL_000D: stloc.1
    IL_000E: ldloc.1
    IL_000F: ldc.i4.s 100
    IL_0011: blt.s IL_0006
    IL_0013: ldloc.0
    IL_0014: ret

}
int AddI32LoopInlineCall()
{
    IL_0000: call System.Int32 Z0.CommonPrimalScenarios::AddI32LoopInline()
    IL_0005: ret

}
int AddI32LoopCall()
{
    IL_0000: call System.Int32 Z0.CommonPrimalScenarios::AddI32Loop()
    IL_0005: ret

}
uint Or8Inline(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ldarg.2
    IL_0004: or
    IL_0005: ldarg.3
    IL_0006: or
    IL_0007: ldarg.s x4
    IL_0009: or
    IL_000A: ldarg.s x5
    IL_000C: or
    IL_000D: ldarg.s x6
    IL_000F: or
    IL_0010: ldarg.s x7
    IL_0012: or
    IL_0013: ret

}
uint RotLU32Inline(uint x, int offset)
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
int ChoiceSwitchInline(int x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: switch(IL_001E,IL_0020,IL_0022,IL_0024,IL_0027)
    IL_001C: br.s IL_002A
    IL_001E: ldc.i4.1
    IL_001F: ret
    IL_0020: ldc.i4.4
    IL_0021: ret
    IL_0022: ldc.i4.8
    IL_0023: ret
    IL_0024: ldc.i4.s 16
    IL_0026: ret
    IL_0027: ldc.i4.s 32
    IL_0029: ret
    IL_002A: ldc.i4.0
    IL_002B: ret

}
int ChoiceIfElse5Inline(int x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.1
    IL_0002: bne.un.s IL_0006
    IL_0004: ldc.i4.1
    IL_0005: ret
    IL_0006: ldarg.1
    IL_0007: ldc.i4.2
    IL_0008: bne.un.s IL_000C
    IL_000A: ldc.i4.4
    IL_000B: ret
    IL_000C: ldarg.1
    IL_000D: ldc.i4.3
    IL_000E: bne.un.s IL_0012
    IL_0010: ldc.i4.8
    IL_0011: ret
    IL_0012: ldarg.1
    IL_0013: ldc.i4.4
    IL_0014: bne.un.s IL_0019
    IL_0016: ldc.i4.s 16
    IL_0018: ret
    IL_0019: ldarg.1
    IL_001A: ldc.i4.5
    IL_001B: bne.un.s IL_0020
    IL_001D: ldc.i4.s 32
    IL_001F: ret
    IL_0020: ldc.i4.0
    IL_0021: ret

}
int ChoiceIfElse10Inline(int x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.1
    IL_0002: bne.un.s IL_0006
    IL_0004: ldc.i4.1
    IL_0005: ret
    IL_0006: ldarg.1
    IL_0007: ldc.i4.2
    IL_0008: bne.un.s IL_000C
    IL_000A: ldc.i4.4
    IL_000B: ret
    IL_000C: ldarg.1
    IL_000D: ldc.i4.3
    IL_000E: bne.un.s IL_0012
    IL_0010: ldc.i4.8
    IL_0011: ret
    IL_0012: ldarg.1
    IL_0013: ldc.i4.4
    IL_0014: bne.un.s IL_0019
    IL_0016: ldc.i4.s 16
    IL_0018: ret
    IL_0019: ldarg.1
    IL_001A: ldc.i4.5
    IL_001B: bne.un.s IL_0020
    IL_001D: ldc.i4.s 32
    IL_001F: ret
    IL_0020: ldarg.1
    IL_0021: ldc.i4.6
    IL_0022: bne.un.s IL_0027
    IL_0024: ldc.i4.s 64
    IL_0026: ret
    IL_0027: ldarg.1
    IL_0028: ldc.i4.7
    IL_0029: bne.un.s IL_0031
    IL_002B: ldc.i4 128
    IL_0030: ret
    IL_0031: ldarg.1
    IL_0032: ldc.i4.8
    IL_0033: bne.un.s IL_003B
    IL_0035: ldc.i4 256
    IL_003A: ret
    IL_003B: ldarg.1
    IL_003C: ldc.i4.s 9
    IL_003E: bne.un.s IL_0046
    IL_0040: ldc.i4 512
    IL_0045: ret
    IL_0046: ldarg.1
    IL_0047: ldc.i4.s 10
    IL_0049: bne.un.s IL_0051
    IL_004B: ldc.i4 1024
    IL_0050: ret
    IL_0051: ldc.i4.0
    IL_0052: ret

}
int CallChoiceSwitchInline(int x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int32 Z0.CommonPrimalScenarios::ChoiceSwitchInline(System.Int32)
    IL_0007: ret

}
int CallChoiceIfElse5Inline(int x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int32 Z0.CommonPrimalScenarios::ChoiceIfElse5Inline(System.Int32)
    IL_0007: ret

}
int CallChoiceIfElse10Inline(int x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int32 Z0.CommonPrimalScenarios::ChoiceIfElse10Inline(System.Int32)
    IL_0007: ret

}
int InvokeBinOp(Func<int,int,int> f, int x, int y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: ldarg.3
    IL_0003: callvirt System.Int32 System.Func`3<System.Int32,System.Int32,System.Int32>::Invoke(System.Int32,System.Int32)
    IL_0008: ret

}
int AddMulInline(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ldarg.0
    IL_0004: mul
    IL_0005: ldarg.0
    IL_0006: ldarg.1
    IL_0007: add
    IL_0008: ldarg.1
    IL_0009: mul
    IL_000A: add
    IL_000B: ret

}
int CallInvokeBinOp(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldnull
    IL_0002: ldftn System.Int32 Z0.CommonPrimalScenarios::AddMulInline(System.Int32,System.Int32)
    IL_0008: newobj System.Void System.Func`3<System.Int32,System.Int32,System.Int32>::.ctor(System.Object,System.IntPtr)
    IL_000D: ldarg.1
    IL_000E: ldarg.2
    IL_000F: call System.Int32 Z0.CommonPrimalScenarios::InvokeBinOp(System.Func`3<System.Int32,System.Int32,System.Int32>,System.Int32,System.Int32)
    IL_0014: ret

}
int JumpTarget1()
{
    IL_0000: ldc.i4.1
    IL_0001: ret

}
int JumpTarget2()
{
    IL_0000: ldc.i4.2
    IL_0001: ret

}
int JumpTarget3()
{
    IL_0000: ldc.i4.3
    IL_0001: ret

}
int JumpTarget4()
{
    IL_0000: ldc.i4.4
    IL_0001: ret

}
int Jump(int target)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.1
    IL_0002: beq.s IL_0021
    IL_0004: ldarg.1
    IL_0005: ldc.i4.2
    IL_0006: beq.s IL_001A
    IL_0008: ldarg.1
    IL_0009: ldc.i4.3
    IL_000A: beq.s IL_0013
    IL_000C: ldarg.0
    IL_000D: call System.Int32 Z0.CommonPrimalScenarios::JumpTarget4()
    IL_0012: ret
    IL_0013: ldarg.0
    IL_0014: call System.Int32 Z0.CommonPrimalScenarios::JumpTarget3()
    IL_0019: ret
    IL_001A: ldarg.0
    IL_001B: call System.Int32 Z0.CommonPrimalScenarios::JumpTarget2()
    IL_0020: ret
    IL_0021: ldarg.0
    IL_0022: call System.Int32 Z0.CommonPrimalScenarios::JumpTarget1()
    IL_0027: ret

}
uint CallRotLU32Inline(uint x, int offset)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: call System.UInt32 Z0.CommonPrimalScenarios::RotLU32Inline(System.UInt32,System.Int32)
    IL_0007: ret

}
uint CallOr8InlineConst()
{
    IL_0000: ldc.i4.2
    IL_0001: ldc.i4.4
    IL_0002: ldc.i4.8
    IL_0003: ldc.i4.s 12
    IL_0005: ldc.i4.s 16
    IL_0007: ldc.i4.s 32
    IL_0009: ldc.i4.s 68
    IL_000B: ldc.i4.s 64
    IL_000D: call System.UInt32 Z0.CommonPrimalScenarios::Or8Inline(System.UInt32,System.UInt32,System.UInt32,System.UInt32,System.UInt32,System.UInt32,System.UInt32,System.UInt32)
    IL_0012: ret

}
uint CallOr8InlineVar(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: ldarg.3
    IL_0003: ldarg.s x3
    IL_0005: ldarg.s x4
    IL_0007: ldarg.s x5
    IL_0009: ldarg.s x6
    IL_000B: ldarg.s x7
    IL_000D: call System.UInt32 Z0.CommonPrimalScenarios::Or8Inline(System.UInt32,System.UInt32,System.UInt32,System.UInt32,System.UInt32,System.UInt32,System.UInt32,System.UInt32)
    IL_0012: ret

}
ReadOnlySpan<byte> ReadU8Data(int count)
{
    IL_0000: call System.ReadOnlySpan`1<System.Byte> Z0.CommonPrimalScenarios::get_U8Data()
    IL_0005: stloc.0
    IL_0006: ldloca.s V_0
    IL_0008: ldc.i4.0
    IL_0009: ldarg.1
    IL_000A: call System.ReadOnlySpan`1<System.Byte> System.ReadOnlySpan`1<System.Byte>::Slice(System.Int32,System.Int32)
    IL_000F: ret

}
ReadOnlySpan<uint> ReadU32Data(int count)
{
    IL_0000: call System.ReadOnlySpan`1<System.UInt32> Z0.CommonPrimalScenarios::get_U32Data()
    IL_0005: stloc.0
    IL_0006: ldloca.s V_0
    IL_0008: ldc.i4.0
    IL_0009: ldarg.1
    IL_000A: call System.ReadOnlySpan`1<System.UInt32> System.ReadOnlySpan`1<System.UInt32>::Slice(System.Int32,System.Int32)
    IL_000F: ret

}
void VoidReturn()
{
    IL_0000: ldstr ""
    IL_0005: call System.Void System.Console::Write(System.String)
    IL_000A: ret

}

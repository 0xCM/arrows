// 2019-07-01 01:15:28:499
sbyte addI8(sbyte x, sbyte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: conv.i1
    IL_0004: ret

}
int addI32(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
ulong addU64(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
int subI32(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ret

}
int mulI32(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
byte andU8(byte x, byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: conv.u1
    IL_0004: ret

}
ushort andU16(ushort x, ushort y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: conv.u2
    IL_0004: ret

}
ulong andU64(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
int addI32Loop()
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
int addI32LoopOptimize()
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
int AddI32LoopCall()
{
    IL_0000: call System.Int32 Z0.CommonPrimalScenarios::addI32Loop()
    IL_0005: ret

}

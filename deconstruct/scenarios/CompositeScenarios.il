// 2019-07-31 03:55:30:228
byte rotr8u(byte src, byte offset)
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
ushort rotr16u(ushort src, ushort offset)
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
uint rotr32u(uint src, uint offset)
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
ulong rotr64u(ulong src, ulong offset)
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
byte rotl8u(byte x, byte offset)
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
ushort rotl16u(ushort x, ushort offset)
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
    IL_000E: shr.un
    IL_000F: or
    IL_0010: conv.u2
    IL_0011: ret

}
uint rotl32u(uint x, uint offset)
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
ulong rotl64u(ulong x, ulong offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.i4
    IL_0003: ldc.i4.s 63
    IL_0005: and
    IL_0006: shl
    IL_0007: ldarg.0
    IL_0008: ldc.i4.s 64
    IL_000A: conv.i8
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.i4
    IL_000E: ldc.i4.s 63
    IL_0010: and
    IL_0011: shr.un
    IL_0012: or
    IL_0013: ret

}
void loopedCall(int count, Action<int> callee)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: br.s IL_000F
    IL_0004: ldarg.1
    IL_0005: ldloc.0
    IL_0006: callvirt System.Void System.Action`1<System.Int32>::Invoke(System.Int32)
    IL_000B: ldloc.0
    IL_000C: ldc.i4.1
    IL_000D: add
    IL_000E: stloc.0
    IL_000F: ldloc.0
    IL_0010: ldarg.0
    IL_0011: blt.s IL_0004
    IL_0013: ret

}
void swap8u(ref byte x, ref byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u1
    IL_0002: stloc.0
    IL_0003: ldarg.0
    IL_0004: ldarg.1
    IL_0005: ldind.u1
    IL_0006: stind.i1
    IL_0007: ldarg.1
    IL_0008: ldloc.0
    IL_0009: stind.i1
    IL_000A: ret

}
void swap32i(ref int x, ref int y)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i4
    IL_0002: stloc.0
    IL_0003: ldarg.0
    IL_0004: ldarg.1
    IL_0005: ldind.i4
    IL_0006: stind.i4
    IL_0007: ldarg.1
    IL_0008: ldloc.0
    IL_0009: stind.i4
    IL_000A: ret

}
int space3()
{
    IL_0000: ldsfld System.Int32 Z0.CompositeScenarios::A
    IL_0005: stloc.0
    IL_0006: ldsfld System.Int32 Z0.CompositeScenarios::B
    IL_000B: stloc.1
    IL_000C: ldsfld System.Int32 Z0.CompositeScenarios::C
    IL_0011: stloc.2
    IL_0012: ldloc.0
    IL_0013: ldloc.1
    IL_0014: add
    IL_0015: ldloc.2
    IL_0016: add
    IL_0017: ret

}

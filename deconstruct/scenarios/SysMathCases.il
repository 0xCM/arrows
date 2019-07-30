// 2019-07-30 03:30:04:380
sbyte Abs(sbyte value)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: bge.s IL_0009
    IL_0004: ldarg.0
    IL_0005: neg
    IL_0006: conv.i1
    IL_0007: starg.s value
    IL_0009: ldarg.0
    IL_000A: ret

}
short Abs16(short value)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: bge.s IL_0009
    IL_0004: ldarg.0
    IL_0005: neg
    IL_0006: conv.i2
    IL_0007: starg.s value
    IL_0009: ldarg.0
    IL_000A: ret

}
int Abs32(int value)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: bge.s IL_0008
    IL_0004: ldarg.0
    IL_0005: neg
    IL_0006: starg.s value
    IL_0008: ldarg.0
    IL_0009: ret

}
long Abs64(long value)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: conv.i8
    IL_0003: bge.s IL_0009
    IL_0005: ldarg.0
    IL_0006: neg
    IL_0007: starg.s value
    IL_0009: ldarg.0
    IL_000A: ret

}
byte Max(byte val1, byte val2)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bge.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
short Max(short val1, short val2)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bge.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
int Max(int val1, int val2)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bge.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
long Max(long val1, long val2)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bge.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
sbyte Max(sbyte val1, sbyte val2)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bge.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}

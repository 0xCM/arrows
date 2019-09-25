// 2019-09-25 16:30:31:203
byte add_8u(byte x, byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: conv.u1
    IL_0004: ret

}
byte add_g8u(byte x, byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.gmath::add<System.Byte>(System.Byte,System.Byte)
    IL_0007: ret

}
ulong mul_64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
ulong mul_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::mul<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
byte mul_8u(byte x, byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: conv.u1
    IL_0004: ret

}
byte mul_g8u(byte x, byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.gmath::mul<System.Byte>(System.Byte,System.Byte)
    IL_0007: ret

}
ulong and_64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
ulong and_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::and<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong mod_64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem.un
    IL_0003: ret

}
ulong mod_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::mod<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
long abs_64i(long x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.math::abs(System.Int64)
    IL_0006: ret

}
long abs_g64i(long x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.gmath::abs<System.Int64>(System.Int64)
    IL_0006: ret

}
ulong or_64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
ulong or_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::or<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong xor_64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret

}
ulong xor_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::xor<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
double inc_64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r8 1
    IL_000A: add
    IL_000B: dup
    IL_000C: starg.s x
    IL_000E: ret

}
double inc_g64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.gfp::inc<System.Double>(System.Double)
    IL_0006: ret

}
double dec_64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r8 1
    IL_000A: sub
    IL_000B: dup
    IL_000C: starg.s x
    IL_000E: ret

}
double dec_g64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.gfp::dec<System.Double>(System.Double)
    IL_0006: ret

}
double dec_64f(ref double x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldc.r8 1
    IL_000C: sub
    IL_000D: stloc.0
    IL_000E: ldloc.0
    IL_000F: stind.r8
    IL_0010: ldloc.0
    IL_0011: ret

}
ref double dec_g64f(ref double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double& Z0.gfp::dec<System.Double>(System.Double&)
    IL_0006: ret

}
sbyte emit8i()
{
    IL_0000: ldc.i4.s -37
    IL_0002: ret

}
byte emit8u()
{
    IL_0000: ldc.i4.s 37
    IL_0002: ret

}
short emit16i()
{
    IL_0000: ldc.i4 -21554
    IL_0005: ret

}
ushort emit16u()
{
    IL_0000: ldc.i4 21554
    IL_0005: ret

}
int emit32i()
{
    IL_0000: ldc.i4 -2171941
    IL_0005: ret

}
uint emit32u()
{
    IL_0000: ldc.i4 1141059618
    IL_0005: ret

}
long emit64i()
{
    IL_0000: ldc.i8 -9223372036854775808
    IL_0009: ret

}
ulong emit64u()
{
    IL_0000: ldc.i8 28716289921069090
    IL_0009: ret

}
float emit32f()
{
    IL_0000: ldc.r4 20304050
    IL_0005: ret

}
double emit64f()
{
    IL_0000: ldc.r8 -358298783.335255
    IL_0009: ret

}

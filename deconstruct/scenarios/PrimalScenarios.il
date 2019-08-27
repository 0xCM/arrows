// 2019-08-26 19:39:48:623
sbyte flip8i(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: conv.i1
    IL_0003: ret

}
byte flip8u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: conv.u1
    IL_0003: ret

}
short flip16i(short src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: conv.i2
    IL_0003: ret

}
ushort flip16u(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: conv.u2
    IL_0003: ret

}
int flip32i(int src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ret

}
uint flip32u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ret

}
long flip64i(long src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ret

}
ulong flip64u(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ret

}
float flip32f(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 System.BitConverter::SingleToInt32Bits(System.Single)
    IL_0006: not
    IL_0007: call System.Single System.BitConverter::Int32BitsToSingle(System.Int32)
    IL_000C: ret

}
double flip64f(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 System.BitConverter::DoubleToInt64Bits(System.Double)
    IL_0006: not
    IL_0007: call System.Double System.BitConverter::Int64BitsToDouble(System.Int64)
    IL_000C: ret

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
int abs(int x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 31
    IL_0003: shr
    IL_0004: stloc.0
    IL_0005: ldarg.0
    IL_0006: ldloc.0
    IL_0007: xor
    IL_0008: ldloc.0
    IL_0009: sub
    IL_000A: ret

}
short abs(short x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.PrimalScenarios::abs(System.Int32)
    IL_0006: conv.i2
    IL_0007: ret

}
sbyte add8i(sbyte x, sbyte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: conv.i1
    IL_0004: ret

}
sbyte add8i_In(in sbyte x, in sbyte y)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i1
    IL_0002: ldarg.1
    IL_0003: ldind.i1
    IL_0004: add
    IL_0005: conv.i1
    IL_0006: ret

}
ref sbyte add8i_Ref(ref sbyte x, in sbyte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: ldind.i1
    IL_0005: add
    IL_0006: conv.i1
    IL_0007: stind.i1
    IL_0008: ldarg.0
    IL_0009: ret

}
byte add8u(byte x, byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: conv.u1
    IL_0004: ret

}
byte add8u_In(in byte x, in byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u1
    IL_0002: ldarg.1
    IL_0003: ldind.u1
    IL_0004: add
    IL_0005: conv.u1
    IL_0006: ret

}
ref byte add8u_Ref(ref byte x, in byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldind.u1
    IL_0005: add
    IL_0006: conv.u1
    IL_0007: stind.i1
    IL_0008: ldarg.0
    IL_0009: ret

}
short add16i(short x, short y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: conv.i2
    IL_0004: ret

}
short add16i_In(in short x, in short y)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i2
    IL_0002: ldarg.1
    IL_0003: ldind.i2
    IL_0004: add
    IL_0005: conv.i2
    IL_0006: ret

}
ref short add16i_Ref(ref short x, in short y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: ldind.i2
    IL_0005: add
    IL_0006: conv.i2
    IL_0007: stind.i2
    IL_0008: ldarg.0
    IL_0009: ret

}
ushort add16u(ushort x, ushort y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: conv.u2
    IL_0004: ret

}
ushort add16u_In(in ushort x, in ushort y)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u2
    IL_0002: ldarg.1
    IL_0003: ldind.u2
    IL_0004: add
    IL_0005: conv.u2
    IL_0006: ret

}
ref ushort add16u_Ref(ref ushort x, in ushort y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldind.u2
    IL_0005: add
    IL_0006: conv.u2
    IL_0007: stind.i2
    IL_0008: ldarg.0
    IL_0009: ret

}
int add32i(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
int add32i_In(in int x, in int y)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i4
    IL_0002: ldarg.1
    IL_0003: ldind.i4
    IL_0004: add
    IL_0005: ret

}
ref int add32i_Ref(ref int x, in int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: ldind.i4
    IL_0005: add
    IL_0006: stind.i4
    IL_0007: ldarg.0
    IL_0008: ret

}
uint add32u(uint x, uint y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
uint add32u_In(in uint x, in uint y)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u4
    IL_0002: ldarg.1
    IL_0003: ldind.u4
    IL_0004: add
    IL_0005: ret

}
ref uint add32u_Ref(ref uint x, in uint y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldind.u4
    IL_0005: add
    IL_0006: stind.i4
    IL_0007: ldarg.0
    IL_0008: ret

}
long add64i(long x, long y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
long add64i_In(in long x, in long y)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: ldarg.1
    IL_0003: ldind.i8
    IL_0004: add
    IL_0005: ret

}
ref long add64i_Ref(ref long x, in long y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: add
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
ulong add64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
ulong add64u_In(in ulong x, in ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: ldarg.1
    IL_0003: ldind.i8
    IL_0004: add
    IL_0005: ret

}
ref ulong add64u_Ref(ref ulong x, in ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: add
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
float add32f(float x, float y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
double add64f(double x, double y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
double add64f_In(in double x, in double y)
{
    IL_0000: ldarg.0
    IL_0001: ldind.r8
    IL_0002: ldarg.1
    IL_0003: ldind.r8
    IL_0004: add
    IL_0005: ret

}
ref double add64f_Ref(ref double x, in double y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldarg.1
    IL_0004: ldind.r8
    IL_0005: add
    IL_0006: stind.r8
    IL_0007: ldarg.0
    IL_0008: ret

}
float add32f_In(in float x, in float y)
{
    IL_0000: ldarg.0
    IL_0001: ldind.r4
    IL_0002: ldarg.1
    IL_0003: ldind.r4
    IL_0004: add
    IL_0005: ret

}
ref float add32f_Ref(ref float x, in float y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: ldarg.1
    IL_0004: ldind.r4
    IL_0005: add
    IL_0006: stind.r4
    IL_0007: ldarg.0
    IL_0008: ret

}
sbyte add8ix3(sbyte x, sbyte y, sbyte z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: conv.i1
    IL_0006: ret

}
byte add8ux3(byte x, byte y, byte z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: conv.u1
    IL_0006: ret

}
short add16ix3(short x, short y, short z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: conv.i2
    IL_0006: ret

}
ushort add16ux3(ushort x, ushort y, ushort z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: conv.u2
    IL_0006: ret

}
int add32ix3(int x, int y, int z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: ret

}
uint add32ux3(uint x, uint y, uint z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: ret

}
long add64ix3(long x, long y, long z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: ret

}
ulong add64ux3(ulong x, ulong y, ulong z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: ret

}
float add32fx3(float x, float y, float z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: ret

}
double add64fx3(double x, double y, double z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: ret

}
byte and8u(byte x, byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: conv.u1
    IL_0004: ret

}
sbyte and8i(sbyte x, sbyte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: conv.i1
    IL_0004: ret

}
short and16i(short x, short y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: conv.i2
    IL_0004: ret

}
ushort and16u(ushort x, ushort y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: conv.u2
    IL_0004: ret

}
int and32i(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
uint and32u(uint x, uint y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
long and64i(long x, long y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
ulong and64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
sbyte div8i(sbyte x, sbyte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: conv.i1
    IL_0004: ret

}
byte div8u(byte x, byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: conv.u1
    IL_0004: ret

}
short div16i(short x, short y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: conv.i2
    IL_0004: ret

}
ushort div16u(ushort x, ushort y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: conv.u2
    IL_0004: ret

}
int div32i(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: ret

}
uint div32u(uint x, uint y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div.un
    IL_0003: ret

}
long div64i(long x, long y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: ret

}
ulong div64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div.un
    IL_0003: ret

}
float div32f(float x, float y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: ret

}
double div64f(double x, double y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: ret

}
sbyte mul8i(sbyte x, sbyte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: conv.i1
    IL_0004: ret

}
byte mul8u(byte x, byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: conv.u1
    IL_0004: ret

}
short mul16i(short x, short y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: conv.i2
    IL_0004: ret

}
ushort mul16u(ushort x, ushort y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: conv.u2
    IL_0004: ret

}
int mul32i(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
int mul32i(int x, int y, int z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ldarg.2
    IL_0004: mul
    IL_0005: ret

}
int mul32i(int a, int b, int c, int d, int e, int f)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ldarg.2
    IL_0004: mul
    IL_0005: ldarg.3
    IL_0006: mul
    IL_0007: ldarg.s e
    IL_0009: mul
    IL_000A: ldarg.s f
    IL_000C: mul
    IL_000D: ret

}
uint mul32u(uint x, uint y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
long mul64i(long x, long y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
ulong mul64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
float mul32f(float x, float y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
double mul64f(double x, double y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
sbyte mod8i(sbyte x, sbyte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: conv.i1
    IL_0004: ret

}
byte mod8u(byte x, byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: conv.u1
    IL_0004: ret

}
short mod16i(short x, short y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: conv.i2
    IL_0004: ret

}
ushort mod16u(ushort x, ushort y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: conv.u2
    IL_0004: ret

}
int mod32i(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: ret

}
uint mod32u(uint x, uint y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem.un
    IL_0003: ret

}
long mod64i(long x, long y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: ret

}
ulong mod64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem.un
    IL_0003: ret

}
float mod32f(float x, float y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: ret

}
double mod64f(double x, double y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: ret

}
byte or8u(byte x, byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: conv.u1
    IL_0004: ret

}
sbyte or8i(sbyte x, sbyte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: conv.i1
    IL_0004: ret

}
short or16i(short x, short y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: conv.i2
    IL_0004: ret

}
ushort or16u(ushort x, ushort y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: conv.u2
    IL_0004: ret

}
ushort or16u_2(ushort x, ushort y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: conv.u2
    IL_0004: dup
    IL_0005: starg.s x
    IL_0007: ret

}
int or32i(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
uint or32u(uint x, uint y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
long or64i(long x, long y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
ulong or64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
byte xor8u(byte x, byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: conv.u1
    IL_0004: ret

}
sbyte xor8i(sbyte x, sbyte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: conv.i1
    IL_0004: ret

}
short xor16i(short x, short y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: conv.i2
    IL_0004: ret

}
ushort xor16u(ushort x, ushort y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: conv.u2
    IL_0004: ret

}
int xor32i(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret

}
uint xor32u(uint x, uint y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret

}
long xor64i(long x, long y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret

}
ulong xor64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret

}
sbyte sub8i(sbyte x, sbyte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: conv.i1
    IL_0004: ret

}
byte sub8u(byte x, byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: conv.u1
    IL_0004: ret

}
short sub16i(short x, short y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: conv.i2
    IL_0004: ret

}
ushort sub16u(ushort x, ushort y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: conv.u2
    IL_0004: ret

}
int sub32i(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ret

}
uint sub32u(uint x, uint y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ret

}
long sub64i(long x, long y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ret

}
ulong sub64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ret

}
float sub32f(float x, float y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ret

}
double sub64f(double x, double y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ret

}
sbyte negate8i(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: neg
    IL_0002: conv.i1
    IL_0003: ret

}
byte negate8u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: conv.u1
    IL_0005: ret

}
short negate16i(short src)
{
    IL_0000: ldarg.0
    IL_0001: neg
    IL_0002: conv.i2
    IL_0003: ret

}
ushort negate16u(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: conv.u2
    IL_0005: ret

}
int negate32i(int src)
{
    IL_0000: ldarg.0
    IL_0001: neg
    IL_0002: ret

}
uint negate32u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: ret

}
long negate64i(long src)
{
    IL_0000: ldarg.0
    IL_0001: neg
    IL_0002: ret

}
ulong negate64u(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ldc.i4.1
    IL_0003: conv.i8
    IL_0004: add
    IL_0005: ret

}
float negate32f(float src)
{
    IL_0000: ldc.r4 0
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ret

}
double negate64f(double src)
{
    IL_0000: ldc.r8 0
    IL_0009: ldarg.0
    IL_000A: sub
    IL_000B: ret

}
sbyte inc(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: conv.i1
    IL_0005: starg.s src
    IL_0007: ret

}
byte inc(byte src)
{
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: conv.u1
    IL_0005: starg.s src
    IL_0007: ret

}
short inc(short src)
{
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: conv.i2
    IL_0005: starg.s src
    IL_0007: ret

}
ushort inc(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: conv.u2
    IL_0005: starg.s src
    IL_0007: ret

}
int inc(int src)
{
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: starg.s src
    IL_0006: ret

}
uint inc(uint src)
{
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: starg.s src
    IL_0006: ret

}
long inc(long src)
{
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0002: ldc.i4.1
    IL_0003: conv.i8
    IL_0004: add
    IL_0005: starg.s src
    IL_0007: ret

}
ulong inc(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0002: ldc.i4.1
    IL_0003: conv.i8
    IL_0004: add
    IL_0005: starg.s src
    IL_0007: ret

}
float inc(float src)
{
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0002: ldc.r4 1
    IL_0007: add
    IL_0008: starg.s src
    IL_000A: ret

}
double inc(double src)
{
    IL_0000: ldarg.0
    IL_0001: dup
    IL_0002: ldc.r8 1
    IL_000B: add
    IL_000C: starg.s src
    IL_000E: ret

}

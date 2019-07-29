// 2019-07-29 03:15:51:239
BitSize GetWidth(IImm<byte> src)
{
    IL_0000: ldarg.1
    IL_0001: callvirt Z0.BitSize Z0.Cpu.IImm`1<System.Byte>::get_Width()
    IL_0006: ret

}
string GetLabel(IImm<byte> src)
{
    IL_0000: ldarg.1
    IL_0001: callvirt System.String Z0.Cpu.IImm`1<System.Byte>::get_Label()
    IL_0006: ret

}
byte GetValue1(IImm<byte> src)
{
    IL_0000: ldarg.1
    IL_0001: callvirt System.Byte Z0.Cpu.IImm`1<System.Byte>::get_Value()
    IL_0006: ret

}
byte GetValue2(Imm8 src)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Byte Z0.Cpu.Imm8::Value
    IL_0006: ret

}
byte GetValue3(IImm<byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: ldloca.s V_0
    IL_0004: call Z0.Cpu.Imm8& zfunc::imagine<Z0.Cpu.IImm`1<System.Byte>,Z0.Cpu.Imm8>(Z0.Cpu.IImm`1<System.Byte>&,Z0.Cpu.Imm8&)
    IL_0009: ldfld System.Byte Z0.Cpu.Imm8::Value
    IL_000E: ret

}
byte GetValue4(IImm<byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: ldloca.s V_0
    IL_0004: call System.Byte& zfunc::imagine<Z0.Cpu.IImm`1<System.Byte>,System.Byte>(Z0.Cpu.IImm`1<System.Byte>&,System.Byte&)
    IL_0009: ldind.u1
    IL_000A: ret

}
byte GetValue5(IImm<byte> src)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.Cpu.Imm`1<System.Byte> Z0.Cpu.Imm`1<System.Byte>::From(Z0.Cpu.IImm`1<System.Byte>)
    IL_0006: ldfld System.Byte Z0.Cpu.Imm`1<System.Byte>::Value
    IL_000B: ret

}
bool IsSignExtended(IImm<byte> src)
{
    IL_0000: ldarg.1
    IL_0001: callvirt System.Boolean Z0.Cpu.IImm`1<System.Byte>::get_IsSignExtended()
    IL_0006: ret

}

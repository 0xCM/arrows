// 2019-07-27 22:39:10:381
byte sub<byte>(byte lhs, byte rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::subI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::subU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::subI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::subU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::subI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::subU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::subI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::subU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::subF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::subF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0168: ldc.i4.s 44
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
ushort sub<ushort>(ushort lhs, ushort rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::subI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::subU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::subI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::subU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::subI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::subU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::subI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::subU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::subF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::subF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0168: ldc.i4.s 44
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
uint sub<uint>(uint lhs, uint rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::subI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::subU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::subI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::subU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::subI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::subU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::subI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::subU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::subF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::subF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0168: ldc.i4.s 44
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
ulong sub<ulong>(ulong lhs, ulong rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::subI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::subU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::subI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::subU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::subI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::subU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::subI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::subU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::subF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::subF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0168: ldc.i4.s 44
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
sbyte sub<sbyte>(sbyte lhs, sbyte rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::subI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::subU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::subI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::subU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::subI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::subU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::subI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::subU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::subF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::subF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0168: ldc.i4.s 44
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
short sub<short>(short lhs, short rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::subI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::subU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::subI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::subU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::subI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::subU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::subI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::subU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::subF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::subF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0168: ldc.i4.s 44
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
int sub<int>(int lhs, int rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::subI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::subU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::subI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::subU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::subI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::subU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::subI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::subU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::subF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::subF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0168: ldc.i4.s 44
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
long sub<long>(long lhs, long rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::subI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::subU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::subI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::subU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::subI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::subU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::subI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::subU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::subF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::subF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0168: ldc.i4.s 44
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
float sub<float>(float lhs, float rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::subI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::subU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::subI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::subU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::subI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::subU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::subI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::subU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::subF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::subF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0168: ldc.i4.s 44
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
double sub<double>(double lhs, double rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::subI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::subU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::subI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::subU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::subI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::subU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::subI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::subU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::subF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::subF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Sub.cs"
    IL_0168: ldc.i4.s 44
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
byte add<byte>(byte lhs, byte rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: add
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: add
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: add
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: add
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: add
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: add
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: add
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: add
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: add
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: add
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
ushort add<ushort>(ushort lhs, ushort rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: add
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: add
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: add
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: add
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: add
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: add
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: add
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: add
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: add
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: add
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
uint add<uint>(uint lhs, uint rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: add
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: add
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: add
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: add
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: add
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: add
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: add
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: add
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: add
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: add
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
ulong add<ulong>(ulong lhs, ulong rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: add
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: add
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: add
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: add
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: add
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: add
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: add
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: add
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: add
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: add
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
sbyte add<sbyte>(sbyte lhs, sbyte rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: add
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: add
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: add
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: add
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: add
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: add
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: add
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: add
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: add
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: add
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
short add<short>(short lhs, short rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: add
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: add
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: add
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: add
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: add
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: add
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: add
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: add
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: add
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: add
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
int add<int>(int lhs, int rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: add
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: add
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: add
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: add
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: add
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: add
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: add
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: add
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: add
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: add
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
long add<long>(long lhs, long rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: add
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: add
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: add
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: add
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: add
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: add
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: add
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: add
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: add
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: add
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
float add<float>(float lhs, float rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: add
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: add
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: add
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: add
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: add
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: add
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: add
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: add
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: add
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: add
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
double add<double>(double lhs, double rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: add
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: add
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: add
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: add
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: add
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: add
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: add
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: add
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: add
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: add
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Add.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
byte div<byte>(byte lhs, byte rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: div
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: div
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: div
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: div
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: div
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: div.un
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: div
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: div.un
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: div
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: div
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
ushort div<ushort>(ushort lhs, ushort rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: div
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: div
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: div
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: div
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: div
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: div.un
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: div
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: div.un
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: div
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: div
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
uint div<uint>(uint lhs, uint rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: div
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: div
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: div
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: div
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: div
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: div.un
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: div
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: div.un
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: div
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: div
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
ulong div<ulong>(ulong lhs, ulong rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: div
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: div
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: div
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: div
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: div
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: div.un
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: div
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: div.un
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: div
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: div
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
sbyte div<sbyte>(sbyte lhs, sbyte rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: div
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: div
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: div
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: div
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: div
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: div.un
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: div
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: div.un
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: div
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: div
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
short div<short>(short lhs, short rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: div
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: div
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: div
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: div
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: div
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: div.un
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: div
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: div.un
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: div
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: div
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
int div<int>(int lhs, int rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: div
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: div
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: div
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: div
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: div
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: div.un
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: div
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: div.un
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: div
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: div
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
long div<long>(long lhs, long rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: div
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: div
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: div
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: div
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: div
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: div.un
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: div
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: div.un
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: div
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: div
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
float div<float>(float lhs, float rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: div
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: div
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: div
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: div
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: div
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: div.un
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: div
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: div.un
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: div
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: div
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
double div<double>(double lhs, double rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002F
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: div
    IL_0028: conv.i1
    IL_0029: call T Z0.As::generic<T>(System.SByte)
    IL_002E: ret
    IL_002F: ldtoken T
    IL_0034: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0039: ldtoken System.Byte
    IL_003E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0043: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0048: brfalse.s IL_005E
    IL_004A: ldarg.0
    IL_004B: call System.Byte Z0.As::uint8<T>(T)
    IL_0050: ldarg.1
    IL_0051: call System.Byte Z0.As::uint8<T>(T)
    IL_0056: div
    IL_0057: conv.u1
    IL_0058: call T Z0.As::generic<T>(System.Byte)
    IL_005D: ret
    IL_005E: ldtoken T
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: ldtoken System.Int16
    IL_006D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0072: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0077: brfalse.s IL_008D
    IL_0079: ldarg.0
    IL_007A: call System.Int16 Z0.As::int16<T>(T)
    IL_007F: ldarg.1
    IL_0080: call System.Int16 Z0.As::int16<T>(T)
    IL_0085: div
    IL_0086: conv.i2
    IL_0087: call T Z0.As::generic<T>(System.Int16)
    IL_008C: ret
    IL_008D: ldtoken T
    IL_0092: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0097: ldtoken System.UInt16
    IL_009C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A6: brfalse.s IL_00BC
    IL_00A8: ldarg.0
    IL_00A9: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AE: ldarg.1
    IL_00AF: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B4: div
    IL_00B5: conv.u2
    IL_00B6: call T Z0.As::generic<T>(System.UInt16)
    IL_00BB: ret
    IL_00BC: ldtoken T
    IL_00C1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C6: ldtoken System.Int32
    IL_00CB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D5: brfalse.s IL_00EA
    IL_00D7: ldarg.0
    IL_00D8: call System.Int32 Z0.As::int32<T>(T)
    IL_00DD: ldarg.1
    IL_00DE: call System.Int32 Z0.As::int32<T>(T)
    IL_00E3: div
    IL_00E4: call T Z0.As::generic<T>(System.Int32)
    IL_00E9: ret
    IL_00EA: ldtoken T
    IL_00EF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F4: ldtoken System.UInt32
    IL_00F9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FE: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0103: brfalse.s IL_0118
    IL_0105: ldarg.0
    IL_0106: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010B: ldarg.1
    IL_010C: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0111: div.un
    IL_0112: call T Z0.As::generic<T>(System.UInt32)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Int64
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_0146
    IL_0133: ldarg.0
    IL_0134: call System.Int64 Z0.As::int64<T>(T)
    IL_0139: ldarg.1
    IL_013A: call System.Int64 Z0.As::int64<T>(T)
    IL_013F: div
    IL_0140: call T Z0.As::generic<T>(System.Int64)
    IL_0145: ret
    IL_0146: ldtoken T
    IL_014B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0150: ldtoken System.UInt64
    IL_0155: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015F: brfalse.s IL_0174
    IL_0161: ldarg.0
    IL_0162: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0167: ldarg.1
    IL_0168: call System.UInt64 Z0.As::uint64<T>(T)
    IL_016D: div.un
    IL_016E: call T Z0.As::generic<T>(System.UInt64)
    IL_0173: ret
    IL_0174: ldtoken T
    IL_0179: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017E: ldtoken System.Single
    IL_0183: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0188: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_018D: brfalse.s IL_01A2
    IL_018F: ldarg.0
    IL_0190: call System.Single Z0.As::float32<T>(T)
    IL_0195: ldarg.1
    IL_0196: call System.Single Z0.As::float32<T>(T)
    IL_019B: div
    IL_019C: call T Z0.As::generic<T>(System.Single)
    IL_01A1: ret
    IL_01A2: ldtoken T
    IL_01A7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01AC: ldtoken System.Double
    IL_01B1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01BB: brfalse.s IL_01D0
    IL_01BD: ldarg.0
    IL_01BE: call System.Double Z0.As::float64<T>(T)
    IL_01C3: ldarg.1
    IL_01C4: call System.Double Z0.As::float64<T>(T)
    IL_01C9: div
    IL_01CA: call T Z0.As::generic<T>(System.Double)
    IL_01CF: ret
    IL_01D0: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01D5: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Div.cs"
    IL_01DA: ldc.i4.s 43
    IL_01DC: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01E1: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E6: throw

}
byte mod<byte>(byte lhs, byte rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002E
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: rem
    IL_0028: call T Z0.As::generic<T>(System.Int32)
    IL_002D: ret
    IL_002E: ldtoken T
    IL_0033: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0038: ldtoken System.Byte
    IL_003D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0042: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0047: brfalse.s IL_005C
    IL_0049: ldarg.0
    IL_004A: call System.Byte Z0.As::uint8<T>(T)
    IL_004F: ldarg.1
    IL_0050: call System.Byte Z0.As::uint8<T>(T)
    IL_0055: rem
    IL_0056: call T Z0.As::generic<T>(System.Int32)
    IL_005B: ret
    IL_005C: ldtoken T
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: ldtoken System.Int16
    IL_006B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0070: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0075: brfalse.s IL_008A
    IL_0077: ldarg.0
    IL_0078: call System.Int16 Z0.As::int16<T>(T)
    IL_007D: ldarg.1
    IL_007E: call System.Int16 Z0.As::int16<T>(T)
    IL_0083: rem
    IL_0084: call T Z0.As::generic<T>(System.Int32)
    IL_0089: ret
    IL_008A: ldtoken T
    IL_008F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0094: ldtoken System.UInt16
    IL_0099: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_009E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A3: brfalse.s IL_00B8
    IL_00A5: ldarg.0
    IL_00A6: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AB: ldarg.1
    IL_00AC: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B1: rem
    IL_00B2: call T Z0.As::generic<T>(System.Int32)
    IL_00B7: ret
    IL_00B8: ldtoken T
    IL_00BD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C2: ldtoken System.Int32
    IL_00C7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00CC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D1: brfalse.s IL_00E6
    IL_00D3: ldarg.0
    IL_00D4: call System.Int32 Z0.As::int32<T>(T)
    IL_00D9: ldarg.1
    IL_00DA: call System.Int32 Z0.As::int32<T>(T)
    IL_00DF: rem
    IL_00E0: call T Z0.As::generic<T>(System.Int32)
    IL_00E5: ret
    IL_00E6: ldtoken T
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: ldtoken System.UInt32
    IL_00F5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FA: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00FF: brfalse.s IL_0114
    IL_0101: ldarg.0
    IL_0102: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0107: ldarg.1
    IL_0108: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010D: rem.un
    IL_010E: call T Z0.As::generic<T>(System.UInt32)
    IL_0113: ret
    IL_0114: ldtoken T
    IL_0119: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011E: ldtoken System.Int64
    IL_0123: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0128: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_012D: brfalse.s IL_0142
    IL_012F: ldarg.0
    IL_0130: call System.Int64 Z0.As::int64<T>(T)
    IL_0135: ldarg.1
    IL_0136: call System.Int64 Z0.As::int64<T>(T)
    IL_013B: rem
    IL_013C: call T Z0.As::generic<T>(System.Int64)
    IL_0141: ret
    IL_0142: ldtoken T
    IL_0147: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014C: ldtoken System.UInt64
    IL_0151: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0156: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015B: brfalse.s IL_0170
    IL_015D: ldarg.0
    IL_015E: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0163: ldarg.1
    IL_0164: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0169: rem.un
    IL_016A: call T Z0.As::generic<T>(System.UInt64)
    IL_016F: ret
    IL_0170: ldtoken T
    IL_0175: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017A: ldtoken System.Single
    IL_017F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0184: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0189: brfalse.s IL_019E
    IL_018B: ldarg.0
    IL_018C: call System.Single Z0.As::float32<T>(T)
    IL_0191: ldarg.1
    IL_0192: call System.Single Z0.As::float32<T>(T)
    IL_0197: rem
    IL_0198: call T Z0.As::generic<T>(System.Single)
    IL_019D: ret
    IL_019E: ldtoken T
    IL_01A3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A8: ldtoken System.Double
    IL_01AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B2: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01B7: brfalse.s IL_01CC
    IL_01B9: ldarg.0
    IL_01BA: call System.Double Z0.As::float64<T>(T)
    IL_01BF: ldarg.1
    IL_01C0: call System.Double Z0.As::float64<T>(T)
    IL_01C5: rem
    IL_01C6: call T Z0.As::generic<T>(System.Double)
    IL_01CB: ret
    IL_01CC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D6: ldc.i4.s 43
    IL_01D8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01DD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E2: throw

}
ushort mod<ushort>(ushort lhs, ushort rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002E
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: rem
    IL_0028: call T Z0.As::generic<T>(System.Int32)
    IL_002D: ret
    IL_002E: ldtoken T
    IL_0033: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0038: ldtoken System.Byte
    IL_003D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0042: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0047: brfalse.s IL_005C
    IL_0049: ldarg.0
    IL_004A: call System.Byte Z0.As::uint8<T>(T)
    IL_004F: ldarg.1
    IL_0050: call System.Byte Z0.As::uint8<T>(T)
    IL_0055: rem
    IL_0056: call T Z0.As::generic<T>(System.Int32)
    IL_005B: ret
    IL_005C: ldtoken T
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: ldtoken System.Int16
    IL_006B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0070: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0075: brfalse.s IL_008A
    IL_0077: ldarg.0
    IL_0078: call System.Int16 Z0.As::int16<T>(T)
    IL_007D: ldarg.1
    IL_007E: call System.Int16 Z0.As::int16<T>(T)
    IL_0083: rem
    IL_0084: call T Z0.As::generic<T>(System.Int32)
    IL_0089: ret
    IL_008A: ldtoken T
    IL_008F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0094: ldtoken System.UInt16
    IL_0099: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_009E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A3: brfalse.s IL_00B8
    IL_00A5: ldarg.0
    IL_00A6: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AB: ldarg.1
    IL_00AC: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B1: rem
    IL_00B2: call T Z0.As::generic<T>(System.Int32)
    IL_00B7: ret
    IL_00B8: ldtoken T
    IL_00BD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C2: ldtoken System.Int32
    IL_00C7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00CC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D1: brfalse.s IL_00E6
    IL_00D3: ldarg.0
    IL_00D4: call System.Int32 Z0.As::int32<T>(T)
    IL_00D9: ldarg.1
    IL_00DA: call System.Int32 Z0.As::int32<T>(T)
    IL_00DF: rem
    IL_00E0: call T Z0.As::generic<T>(System.Int32)
    IL_00E5: ret
    IL_00E6: ldtoken T
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: ldtoken System.UInt32
    IL_00F5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FA: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00FF: brfalse.s IL_0114
    IL_0101: ldarg.0
    IL_0102: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0107: ldarg.1
    IL_0108: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010D: rem.un
    IL_010E: call T Z0.As::generic<T>(System.UInt32)
    IL_0113: ret
    IL_0114: ldtoken T
    IL_0119: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011E: ldtoken System.Int64
    IL_0123: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0128: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_012D: brfalse.s IL_0142
    IL_012F: ldarg.0
    IL_0130: call System.Int64 Z0.As::int64<T>(T)
    IL_0135: ldarg.1
    IL_0136: call System.Int64 Z0.As::int64<T>(T)
    IL_013B: rem
    IL_013C: call T Z0.As::generic<T>(System.Int64)
    IL_0141: ret
    IL_0142: ldtoken T
    IL_0147: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014C: ldtoken System.UInt64
    IL_0151: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0156: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015B: brfalse.s IL_0170
    IL_015D: ldarg.0
    IL_015E: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0163: ldarg.1
    IL_0164: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0169: rem.un
    IL_016A: call T Z0.As::generic<T>(System.UInt64)
    IL_016F: ret
    IL_0170: ldtoken T
    IL_0175: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017A: ldtoken System.Single
    IL_017F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0184: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0189: brfalse.s IL_019E
    IL_018B: ldarg.0
    IL_018C: call System.Single Z0.As::float32<T>(T)
    IL_0191: ldarg.1
    IL_0192: call System.Single Z0.As::float32<T>(T)
    IL_0197: rem
    IL_0198: call T Z0.As::generic<T>(System.Single)
    IL_019D: ret
    IL_019E: ldtoken T
    IL_01A3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A8: ldtoken System.Double
    IL_01AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B2: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01B7: brfalse.s IL_01CC
    IL_01B9: ldarg.0
    IL_01BA: call System.Double Z0.As::float64<T>(T)
    IL_01BF: ldarg.1
    IL_01C0: call System.Double Z0.As::float64<T>(T)
    IL_01C5: rem
    IL_01C6: call T Z0.As::generic<T>(System.Double)
    IL_01CB: ret
    IL_01CC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D6: ldc.i4.s 43
    IL_01D8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01DD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E2: throw

}
uint mod<uint>(uint lhs, uint rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002E
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: rem
    IL_0028: call T Z0.As::generic<T>(System.Int32)
    IL_002D: ret
    IL_002E: ldtoken T
    IL_0033: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0038: ldtoken System.Byte
    IL_003D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0042: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0047: brfalse.s IL_005C
    IL_0049: ldarg.0
    IL_004A: call System.Byte Z0.As::uint8<T>(T)
    IL_004F: ldarg.1
    IL_0050: call System.Byte Z0.As::uint8<T>(T)
    IL_0055: rem
    IL_0056: call T Z0.As::generic<T>(System.Int32)
    IL_005B: ret
    IL_005C: ldtoken T
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: ldtoken System.Int16
    IL_006B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0070: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0075: brfalse.s IL_008A
    IL_0077: ldarg.0
    IL_0078: call System.Int16 Z0.As::int16<T>(T)
    IL_007D: ldarg.1
    IL_007E: call System.Int16 Z0.As::int16<T>(T)
    IL_0083: rem
    IL_0084: call T Z0.As::generic<T>(System.Int32)
    IL_0089: ret
    IL_008A: ldtoken T
    IL_008F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0094: ldtoken System.UInt16
    IL_0099: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_009E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A3: brfalse.s IL_00B8
    IL_00A5: ldarg.0
    IL_00A6: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AB: ldarg.1
    IL_00AC: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B1: rem
    IL_00B2: call T Z0.As::generic<T>(System.Int32)
    IL_00B7: ret
    IL_00B8: ldtoken T
    IL_00BD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C2: ldtoken System.Int32
    IL_00C7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00CC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D1: brfalse.s IL_00E6
    IL_00D3: ldarg.0
    IL_00D4: call System.Int32 Z0.As::int32<T>(T)
    IL_00D9: ldarg.1
    IL_00DA: call System.Int32 Z0.As::int32<T>(T)
    IL_00DF: rem
    IL_00E0: call T Z0.As::generic<T>(System.Int32)
    IL_00E5: ret
    IL_00E6: ldtoken T
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: ldtoken System.UInt32
    IL_00F5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FA: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00FF: brfalse.s IL_0114
    IL_0101: ldarg.0
    IL_0102: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0107: ldarg.1
    IL_0108: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010D: rem.un
    IL_010E: call T Z0.As::generic<T>(System.UInt32)
    IL_0113: ret
    IL_0114: ldtoken T
    IL_0119: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011E: ldtoken System.Int64
    IL_0123: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0128: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_012D: brfalse.s IL_0142
    IL_012F: ldarg.0
    IL_0130: call System.Int64 Z0.As::int64<T>(T)
    IL_0135: ldarg.1
    IL_0136: call System.Int64 Z0.As::int64<T>(T)
    IL_013B: rem
    IL_013C: call T Z0.As::generic<T>(System.Int64)
    IL_0141: ret
    IL_0142: ldtoken T
    IL_0147: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014C: ldtoken System.UInt64
    IL_0151: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0156: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015B: brfalse.s IL_0170
    IL_015D: ldarg.0
    IL_015E: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0163: ldarg.1
    IL_0164: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0169: rem.un
    IL_016A: call T Z0.As::generic<T>(System.UInt64)
    IL_016F: ret
    IL_0170: ldtoken T
    IL_0175: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017A: ldtoken System.Single
    IL_017F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0184: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0189: brfalse.s IL_019E
    IL_018B: ldarg.0
    IL_018C: call System.Single Z0.As::float32<T>(T)
    IL_0191: ldarg.1
    IL_0192: call System.Single Z0.As::float32<T>(T)
    IL_0197: rem
    IL_0198: call T Z0.As::generic<T>(System.Single)
    IL_019D: ret
    IL_019E: ldtoken T
    IL_01A3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A8: ldtoken System.Double
    IL_01AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B2: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01B7: brfalse.s IL_01CC
    IL_01B9: ldarg.0
    IL_01BA: call System.Double Z0.As::float64<T>(T)
    IL_01BF: ldarg.1
    IL_01C0: call System.Double Z0.As::float64<T>(T)
    IL_01C5: rem
    IL_01C6: call T Z0.As::generic<T>(System.Double)
    IL_01CB: ret
    IL_01CC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D6: ldc.i4.s 43
    IL_01D8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01DD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E2: throw

}
ulong mod<ulong>(ulong lhs, ulong rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002E
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: rem
    IL_0028: call T Z0.As::generic<T>(System.Int32)
    IL_002D: ret
    IL_002E: ldtoken T
    IL_0033: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0038: ldtoken System.Byte
    IL_003D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0042: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0047: brfalse.s IL_005C
    IL_0049: ldarg.0
    IL_004A: call System.Byte Z0.As::uint8<T>(T)
    IL_004F: ldarg.1
    IL_0050: call System.Byte Z0.As::uint8<T>(T)
    IL_0055: rem
    IL_0056: call T Z0.As::generic<T>(System.Int32)
    IL_005B: ret
    IL_005C: ldtoken T
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: ldtoken System.Int16
    IL_006B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0070: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0075: brfalse.s IL_008A
    IL_0077: ldarg.0
    IL_0078: call System.Int16 Z0.As::int16<T>(T)
    IL_007D: ldarg.1
    IL_007E: call System.Int16 Z0.As::int16<T>(T)
    IL_0083: rem
    IL_0084: call T Z0.As::generic<T>(System.Int32)
    IL_0089: ret
    IL_008A: ldtoken T
    IL_008F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0094: ldtoken System.UInt16
    IL_0099: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_009E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A3: brfalse.s IL_00B8
    IL_00A5: ldarg.0
    IL_00A6: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AB: ldarg.1
    IL_00AC: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B1: rem
    IL_00B2: call T Z0.As::generic<T>(System.Int32)
    IL_00B7: ret
    IL_00B8: ldtoken T
    IL_00BD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C2: ldtoken System.Int32
    IL_00C7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00CC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D1: brfalse.s IL_00E6
    IL_00D3: ldarg.0
    IL_00D4: call System.Int32 Z0.As::int32<T>(T)
    IL_00D9: ldarg.1
    IL_00DA: call System.Int32 Z0.As::int32<T>(T)
    IL_00DF: rem
    IL_00E0: call T Z0.As::generic<T>(System.Int32)
    IL_00E5: ret
    IL_00E6: ldtoken T
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: ldtoken System.UInt32
    IL_00F5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FA: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00FF: brfalse.s IL_0114
    IL_0101: ldarg.0
    IL_0102: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0107: ldarg.1
    IL_0108: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010D: rem.un
    IL_010E: call T Z0.As::generic<T>(System.UInt32)
    IL_0113: ret
    IL_0114: ldtoken T
    IL_0119: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011E: ldtoken System.Int64
    IL_0123: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0128: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_012D: brfalse.s IL_0142
    IL_012F: ldarg.0
    IL_0130: call System.Int64 Z0.As::int64<T>(T)
    IL_0135: ldarg.1
    IL_0136: call System.Int64 Z0.As::int64<T>(T)
    IL_013B: rem
    IL_013C: call T Z0.As::generic<T>(System.Int64)
    IL_0141: ret
    IL_0142: ldtoken T
    IL_0147: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014C: ldtoken System.UInt64
    IL_0151: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0156: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015B: brfalse.s IL_0170
    IL_015D: ldarg.0
    IL_015E: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0163: ldarg.1
    IL_0164: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0169: rem.un
    IL_016A: call T Z0.As::generic<T>(System.UInt64)
    IL_016F: ret
    IL_0170: ldtoken T
    IL_0175: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017A: ldtoken System.Single
    IL_017F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0184: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0189: brfalse.s IL_019E
    IL_018B: ldarg.0
    IL_018C: call System.Single Z0.As::float32<T>(T)
    IL_0191: ldarg.1
    IL_0192: call System.Single Z0.As::float32<T>(T)
    IL_0197: rem
    IL_0198: call T Z0.As::generic<T>(System.Single)
    IL_019D: ret
    IL_019E: ldtoken T
    IL_01A3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A8: ldtoken System.Double
    IL_01AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B2: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01B7: brfalse.s IL_01CC
    IL_01B9: ldarg.0
    IL_01BA: call System.Double Z0.As::float64<T>(T)
    IL_01BF: ldarg.1
    IL_01C0: call System.Double Z0.As::float64<T>(T)
    IL_01C5: rem
    IL_01C6: call T Z0.As::generic<T>(System.Double)
    IL_01CB: ret
    IL_01CC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D6: ldc.i4.s 43
    IL_01D8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01DD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E2: throw

}
sbyte mod<sbyte>(sbyte lhs, sbyte rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002E
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: rem
    IL_0028: call T Z0.As::generic<T>(System.Int32)
    IL_002D: ret
    IL_002E: ldtoken T
    IL_0033: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0038: ldtoken System.Byte
    IL_003D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0042: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0047: brfalse.s IL_005C
    IL_0049: ldarg.0
    IL_004A: call System.Byte Z0.As::uint8<T>(T)
    IL_004F: ldarg.1
    IL_0050: call System.Byte Z0.As::uint8<T>(T)
    IL_0055: rem
    IL_0056: call T Z0.As::generic<T>(System.Int32)
    IL_005B: ret
    IL_005C: ldtoken T
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: ldtoken System.Int16
    IL_006B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0070: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0075: brfalse.s IL_008A
    IL_0077: ldarg.0
    IL_0078: call System.Int16 Z0.As::int16<T>(T)
    IL_007D: ldarg.1
    IL_007E: call System.Int16 Z0.As::int16<T>(T)
    IL_0083: rem
    IL_0084: call T Z0.As::generic<T>(System.Int32)
    IL_0089: ret
    IL_008A: ldtoken T
    IL_008F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0094: ldtoken System.UInt16
    IL_0099: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_009E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A3: brfalse.s IL_00B8
    IL_00A5: ldarg.0
    IL_00A6: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AB: ldarg.1
    IL_00AC: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B1: rem
    IL_00B2: call T Z0.As::generic<T>(System.Int32)
    IL_00B7: ret
    IL_00B8: ldtoken T
    IL_00BD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C2: ldtoken System.Int32
    IL_00C7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00CC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D1: brfalse.s IL_00E6
    IL_00D3: ldarg.0
    IL_00D4: call System.Int32 Z0.As::int32<T>(T)
    IL_00D9: ldarg.1
    IL_00DA: call System.Int32 Z0.As::int32<T>(T)
    IL_00DF: rem
    IL_00E0: call T Z0.As::generic<T>(System.Int32)
    IL_00E5: ret
    IL_00E6: ldtoken T
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: ldtoken System.UInt32
    IL_00F5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FA: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00FF: brfalse.s IL_0114
    IL_0101: ldarg.0
    IL_0102: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0107: ldarg.1
    IL_0108: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010D: rem.un
    IL_010E: call T Z0.As::generic<T>(System.UInt32)
    IL_0113: ret
    IL_0114: ldtoken T
    IL_0119: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011E: ldtoken System.Int64
    IL_0123: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0128: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_012D: brfalse.s IL_0142
    IL_012F: ldarg.0
    IL_0130: call System.Int64 Z0.As::int64<T>(T)
    IL_0135: ldarg.1
    IL_0136: call System.Int64 Z0.As::int64<T>(T)
    IL_013B: rem
    IL_013C: call T Z0.As::generic<T>(System.Int64)
    IL_0141: ret
    IL_0142: ldtoken T
    IL_0147: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014C: ldtoken System.UInt64
    IL_0151: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0156: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015B: brfalse.s IL_0170
    IL_015D: ldarg.0
    IL_015E: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0163: ldarg.1
    IL_0164: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0169: rem.un
    IL_016A: call T Z0.As::generic<T>(System.UInt64)
    IL_016F: ret
    IL_0170: ldtoken T
    IL_0175: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017A: ldtoken System.Single
    IL_017F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0184: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0189: brfalse.s IL_019E
    IL_018B: ldarg.0
    IL_018C: call System.Single Z0.As::float32<T>(T)
    IL_0191: ldarg.1
    IL_0192: call System.Single Z0.As::float32<T>(T)
    IL_0197: rem
    IL_0198: call T Z0.As::generic<T>(System.Single)
    IL_019D: ret
    IL_019E: ldtoken T
    IL_01A3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A8: ldtoken System.Double
    IL_01AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B2: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01B7: brfalse.s IL_01CC
    IL_01B9: ldarg.0
    IL_01BA: call System.Double Z0.As::float64<T>(T)
    IL_01BF: ldarg.1
    IL_01C0: call System.Double Z0.As::float64<T>(T)
    IL_01C5: rem
    IL_01C6: call T Z0.As::generic<T>(System.Double)
    IL_01CB: ret
    IL_01CC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D6: ldc.i4.s 43
    IL_01D8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01DD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E2: throw

}
short mod<short>(short lhs, short rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002E
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: rem
    IL_0028: call T Z0.As::generic<T>(System.Int32)
    IL_002D: ret
    IL_002E: ldtoken T
    IL_0033: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0038: ldtoken System.Byte
    IL_003D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0042: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0047: brfalse.s IL_005C
    IL_0049: ldarg.0
    IL_004A: call System.Byte Z0.As::uint8<T>(T)
    IL_004F: ldarg.1
    IL_0050: call System.Byte Z0.As::uint8<T>(T)
    IL_0055: rem
    IL_0056: call T Z0.As::generic<T>(System.Int32)
    IL_005B: ret
    IL_005C: ldtoken T
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: ldtoken System.Int16
    IL_006B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0070: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0075: brfalse.s IL_008A
    IL_0077: ldarg.0
    IL_0078: call System.Int16 Z0.As::int16<T>(T)
    IL_007D: ldarg.1
    IL_007E: call System.Int16 Z0.As::int16<T>(T)
    IL_0083: rem
    IL_0084: call T Z0.As::generic<T>(System.Int32)
    IL_0089: ret
    IL_008A: ldtoken T
    IL_008F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0094: ldtoken System.UInt16
    IL_0099: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_009E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A3: brfalse.s IL_00B8
    IL_00A5: ldarg.0
    IL_00A6: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AB: ldarg.1
    IL_00AC: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B1: rem
    IL_00B2: call T Z0.As::generic<T>(System.Int32)
    IL_00B7: ret
    IL_00B8: ldtoken T
    IL_00BD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C2: ldtoken System.Int32
    IL_00C7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00CC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D1: brfalse.s IL_00E6
    IL_00D3: ldarg.0
    IL_00D4: call System.Int32 Z0.As::int32<T>(T)
    IL_00D9: ldarg.1
    IL_00DA: call System.Int32 Z0.As::int32<T>(T)
    IL_00DF: rem
    IL_00E0: call T Z0.As::generic<T>(System.Int32)
    IL_00E5: ret
    IL_00E6: ldtoken T
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: ldtoken System.UInt32
    IL_00F5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FA: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00FF: brfalse.s IL_0114
    IL_0101: ldarg.0
    IL_0102: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0107: ldarg.1
    IL_0108: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010D: rem.un
    IL_010E: call T Z0.As::generic<T>(System.UInt32)
    IL_0113: ret
    IL_0114: ldtoken T
    IL_0119: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011E: ldtoken System.Int64
    IL_0123: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0128: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_012D: brfalse.s IL_0142
    IL_012F: ldarg.0
    IL_0130: call System.Int64 Z0.As::int64<T>(T)
    IL_0135: ldarg.1
    IL_0136: call System.Int64 Z0.As::int64<T>(T)
    IL_013B: rem
    IL_013C: call T Z0.As::generic<T>(System.Int64)
    IL_0141: ret
    IL_0142: ldtoken T
    IL_0147: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014C: ldtoken System.UInt64
    IL_0151: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0156: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015B: brfalse.s IL_0170
    IL_015D: ldarg.0
    IL_015E: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0163: ldarg.1
    IL_0164: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0169: rem.un
    IL_016A: call T Z0.As::generic<T>(System.UInt64)
    IL_016F: ret
    IL_0170: ldtoken T
    IL_0175: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017A: ldtoken System.Single
    IL_017F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0184: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0189: brfalse.s IL_019E
    IL_018B: ldarg.0
    IL_018C: call System.Single Z0.As::float32<T>(T)
    IL_0191: ldarg.1
    IL_0192: call System.Single Z0.As::float32<T>(T)
    IL_0197: rem
    IL_0198: call T Z0.As::generic<T>(System.Single)
    IL_019D: ret
    IL_019E: ldtoken T
    IL_01A3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A8: ldtoken System.Double
    IL_01AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B2: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01B7: brfalse.s IL_01CC
    IL_01B9: ldarg.0
    IL_01BA: call System.Double Z0.As::float64<T>(T)
    IL_01BF: ldarg.1
    IL_01C0: call System.Double Z0.As::float64<T>(T)
    IL_01C5: rem
    IL_01C6: call T Z0.As::generic<T>(System.Double)
    IL_01CB: ret
    IL_01CC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D6: ldc.i4.s 43
    IL_01D8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01DD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E2: throw

}
int mod<int>(int lhs, int rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002E
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: rem
    IL_0028: call T Z0.As::generic<T>(System.Int32)
    IL_002D: ret
    IL_002E: ldtoken T
    IL_0033: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0038: ldtoken System.Byte
    IL_003D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0042: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0047: brfalse.s IL_005C
    IL_0049: ldarg.0
    IL_004A: call System.Byte Z0.As::uint8<T>(T)
    IL_004F: ldarg.1
    IL_0050: call System.Byte Z0.As::uint8<T>(T)
    IL_0055: rem
    IL_0056: call T Z0.As::generic<T>(System.Int32)
    IL_005B: ret
    IL_005C: ldtoken T
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: ldtoken System.Int16
    IL_006B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0070: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0075: brfalse.s IL_008A
    IL_0077: ldarg.0
    IL_0078: call System.Int16 Z0.As::int16<T>(T)
    IL_007D: ldarg.1
    IL_007E: call System.Int16 Z0.As::int16<T>(T)
    IL_0083: rem
    IL_0084: call T Z0.As::generic<T>(System.Int32)
    IL_0089: ret
    IL_008A: ldtoken T
    IL_008F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0094: ldtoken System.UInt16
    IL_0099: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_009E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A3: brfalse.s IL_00B8
    IL_00A5: ldarg.0
    IL_00A6: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AB: ldarg.1
    IL_00AC: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B1: rem
    IL_00B2: call T Z0.As::generic<T>(System.Int32)
    IL_00B7: ret
    IL_00B8: ldtoken T
    IL_00BD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C2: ldtoken System.Int32
    IL_00C7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00CC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D1: brfalse.s IL_00E6
    IL_00D3: ldarg.0
    IL_00D4: call System.Int32 Z0.As::int32<T>(T)
    IL_00D9: ldarg.1
    IL_00DA: call System.Int32 Z0.As::int32<T>(T)
    IL_00DF: rem
    IL_00E0: call T Z0.As::generic<T>(System.Int32)
    IL_00E5: ret
    IL_00E6: ldtoken T
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: ldtoken System.UInt32
    IL_00F5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FA: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00FF: brfalse.s IL_0114
    IL_0101: ldarg.0
    IL_0102: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0107: ldarg.1
    IL_0108: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010D: rem.un
    IL_010E: call T Z0.As::generic<T>(System.UInt32)
    IL_0113: ret
    IL_0114: ldtoken T
    IL_0119: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011E: ldtoken System.Int64
    IL_0123: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0128: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_012D: brfalse.s IL_0142
    IL_012F: ldarg.0
    IL_0130: call System.Int64 Z0.As::int64<T>(T)
    IL_0135: ldarg.1
    IL_0136: call System.Int64 Z0.As::int64<T>(T)
    IL_013B: rem
    IL_013C: call T Z0.As::generic<T>(System.Int64)
    IL_0141: ret
    IL_0142: ldtoken T
    IL_0147: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014C: ldtoken System.UInt64
    IL_0151: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0156: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015B: brfalse.s IL_0170
    IL_015D: ldarg.0
    IL_015E: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0163: ldarg.1
    IL_0164: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0169: rem.un
    IL_016A: call T Z0.As::generic<T>(System.UInt64)
    IL_016F: ret
    IL_0170: ldtoken T
    IL_0175: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017A: ldtoken System.Single
    IL_017F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0184: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0189: brfalse.s IL_019E
    IL_018B: ldarg.0
    IL_018C: call System.Single Z0.As::float32<T>(T)
    IL_0191: ldarg.1
    IL_0192: call System.Single Z0.As::float32<T>(T)
    IL_0197: rem
    IL_0198: call T Z0.As::generic<T>(System.Single)
    IL_019D: ret
    IL_019E: ldtoken T
    IL_01A3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A8: ldtoken System.Double
    IL_01AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B2: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01B7: brfalse.s IL_01CC
    IL_01B9: ldarg.0
    IL_01BA: call System.Double Z0.As::float64<T>(T)
    IL_01BF: ldarg.1
    IL_01C0: call System.Double Z0.As::float64<T>(T)
    IL_01C5: rem
    IL_01C6: call T Z0.As::generic<T>(System.Double)
    IL_01CB: ret
    IL_01CC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D6: ldc.i4.s 43
    IL_01D8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01DD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E2: throw

}
long mod<long>(long lhs, long rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002E
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: rem
    IL_0028: call T Z0.As::generic<T>(System.Int32)
    IL_002D: ret
    IL_002E: ldtoken T
    IL_0033: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0038: ldtoken System.Byte
    IL_003D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0042: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0047: brfalse.s IL_005C
    IL_0049: ldarg.0
    IL_004A: call System.Byte Z0.As::uint8<T>(T)
    IL_004F: ldarg.1
    IL_0050: call System.Byte Z0.As::uint8<T>(T)
    IL_0055: rem
    IL_0056: call T Z0.As::generic<T>(System.Int32)
    IL_005B: ret
    IL_005C: ldtoken T
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: ldtoken System.Int16
    IL_006B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0070: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0075: brfalse.s IL_008A
    IL_0077: ldarg.0
    IL_0078: call System.Int16 Z0.As::int16<T>(T)
    IL_007D: ldarg.1
    IL_007E: call System.Int16 Z0.As::int16<T>(T)
    IL_0083: rem
    IL_0084: call T Z0.As::generic<T>(System.Int32)
    IL_0089: ret
    IL_008A: ldtoken T
    IL_008F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0094: ldtoken System.UInt16
    IL_0099: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_009E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A3: brfalse.s IL_00B8
    IL_00A5: ldarg.0
    IL_00A6: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AB: ldarg.1
    IL_00AC: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B1: rem
    IL_00B2: call T Z0.As::generic<T>(System.Int32)
    IL_00B7: ret
    IL_00B8: ldtoken T
    IL_00BD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C2: ldtoken System.Int32
    IL_00C7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00CC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D1: brfalse.s IL_00E6
    IL_00D3: ldarg.0
    IL_00D4: call System.Int32 Z0.As::int32<T>(T)
    IL_00D9: ldarg.1
    IL_00DA: call System.Int32 Z0.As::int32<T>(T)
    IL_00DF: rem
    IL_00E0: call T Z0.As::generic<T>(System.Int32)
    IL_00E5: ret
    IL_00E6: ldtoken T
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: ldtoken System.UInt32
    IL_00F5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FA: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00FF: brfalse.s IL_0114
    IL_0101: ldarg.0
    IL_0102: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0107: ldarg.1
    IL_0108: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010D: rem.un
    IL_010E: call T Z0.As::generic<T>(System.UInt32)
    IL_0113: ret
    IL_0114: ldtoken T
    IL_0119: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011E: ldtoken System.Int64
    IL_0123: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0128: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_012D: brfalse.s IL_0142
    IL_012F: ldarg.0
    IL_0130: call System.Int64 Z0.As::int64<T>(T)
    IL_0135: ldarg.1
    IL_0136: call System.Int64 Z0.As::int64<T>(T)
    IL_013B: rem
    IL_013C: call T Z0.As::generic<T>(System.Int64)
    IL_0141: ret
    IL_0142: ldtoken T
    IL_0147: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014C: ldtoken System.UInt64
    IL_0151: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0156: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015B: brfalse.s IL_0170
    IL_015D: ldarg.0
    IL_015E: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0163: ldarg.1
    IL_0164: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0169: rem.un
    IL_016A: call T Z0.As::generic<T>(System.UInt64)
    IL_016F: ret
    IL_0170: ldtoken T
    IL_0175: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017A: ldtoken System.Single
    IL_017F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0184: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0189: brfalse.s IL_019E
    IL_018B: ldarg.0
    IL_018C: call System.Single Z0.As::float32<T>(T)
    IL_0191: ldarg.1
    IL_0192: call System.Single Z0.As::float32<T>(T)
    IL_0197: rem
    IL_0198: call T Z0.As::generic<T>(System.Single)
    IL_019D: ret
    IL_019E: ldtoken T
    IL_01A3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A8: ldtoken System.Double
    IL_01AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B2: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01B7: brfalse.s IL_01CC
    IL_01B9: ldarg.0
    IL_01BA: call System.Double Z0.As::float64<T>(T)
    IL_01BF: ldarg.1
    IL_01C0: call System.Double Z0.As::float64<T>(T)
    IL_01C5: rem
    IL_01C6: call T Z0.As::generic<T>(System.Double)
    IL_01CB: ret
    IL_01CC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D6: ldc.i4.s 43
    IL_01D8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01DD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E2: throw

}
float mod<float>(float lhs, float rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002E
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: rem
    IL_0028: call T Z0.As::generic<T>(System.Int32)
    IL_002D: ret
    IL_002E: ldtoken T
    IL_0033: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0038: ldtoken System.Byte
    IL_003D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0042: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0047: brfalse.s IL_005C
    IL_0049: ldarg.0
    IL_004A: call System.Byte Z0.As::uint8<T>(T)
    IL_004F: ldarg.1
    IL_0050: call System.Byte Z0.As::uint8<T>(T)
    IL_0055: rem
    IL_0056: call T Z0.As::generic<T>(System.Int32)
    IL_005B: ret
    IL_005C: ldtoken T
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: ldtoken System.Int16
    IL_006B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0070: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0075: brfalse.s IL_008A
    IL_0077: ldarg.0
    IL_0078: call System.Int16 Z0.As::int16<T>(T)
    IL_007D: ldarg.1
    IL_007E: call System.Int16 Z0.As::int16<T>(T)
    IL_0083: rem
    IL_0084: call T Z0.As::generic<T>(System.Int32)
    IL_0089: ret
    IL_008A: ldtoken T
    IL_008F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0094: ldtoken System.UInt16
    IL_0099: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_009E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A3: brfalse.s IL_00B8
    IL_00A5: ldarg.0
    IL_00A6: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AB: ldarg.1
    IL_00AC: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B1: rem
    IL_00B2: call T Z0.As::generic<T>(System.Int32)
    IL_00B7: ret
    IL_00B8: ldtoken T
    IL_00BD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C2: ldtoken System.Int32
    IL_00C7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00CC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D1: brfalse.s IL_00E6
    IL_00D3: ldarg.0
    IL_00D4: call System.Int32 Z0.As::int32<T>(T)
    IL_00D9: ldarg.1
    IL_00DA: call System.Int32 Z0.As::int32<T>(T)
    IL_00DF: rem
    IL_00E0: call T Z0.As::generic<T>(System.Int32)
    IL_00E5: ret
    IL_00E6: ldtoken T
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: ldtoken System.UInt32
    IL_00F5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FA: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00FF: brfalse.s IL_0114
    IL_0101: ldarg.0
    IL_0102: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0107: ldarg.1
    IL_0108: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010D: rem.un
    IL_010E: call T Z0.As::generic<T>(System.UInt32)
    IL_0113: ret
    IL_0114: ldtoken T
    IL_0119: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011E: ldtoken System.Int64
    IL_0123: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0128: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_012D: brfalse.s IL_0142
    IL_012F: ldarg.0
    IL_0130: call System.Int64 Z0.As::int64<T>(T)
    IL_0135: ldarg.1
    IL_0136: call System.Int64 Z0.As::int64<T>(T)
    IL_013B: rem
    IL_013C: call T Z0.As::generic<T>(System.Int64)
    IL_0141: ret
    IL_0142: ldtoken T
    IL_0147: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014C: ldtoken System.UInt64
    IL_0151: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0156: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015B: brfalse.s IL_0170
    IL_015D: ldarg.0
    IL_015E: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0163: ldarg.1
    IL_0164: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0169: rem.un
    IL_016A: call T Z0.As::generic<T>(System.UInt64)
    IL_016F: ret
    IL_0170: ldtoken T
    IL_0175: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017A: ldtoken System.Single
    IL_017F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0184: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0189: brfalse.s IL_019E
    IL_018B: ldarg.0
    IL_018C: call System.Single Z0.As::float32<T>(T)
    IL_0191: ldarg.1
    IL_0192: call System.Single Z0.As::float32<T>(T)
    IL_0197: rem
    IL_0198: call T Z0.As::generic<T>(System.Single)
    IL_019D: ret
    IL_019E: ldtoken T
    IL_01A3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A8: ldtoken System.Double
    IL_01AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B2: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01B7: brfalse.s IL_01CC
    IL_01B9: ldarg.0
    IL_01BA: call System.Double Z0.As::float64<T>(T)
    IL_01BF: ldarg.1
    IL_01C0: call System.Double Z0.As::float64<T>(T)
    IL_01C5: rem
    IL_01C6: call T Z0.As::generic<T>(System.Double)
    IL_01CB: ret
    IL_01CC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D6: ldc.i4.s 43
    IL_01D8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01DD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E2: throw

}
double mod<double>(double lhs, double rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002E
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldarg.1
    IL_0022: call System.SByte Z0.As::int8<T>(T)
    IL_0027: rem
    IL_0028: call T Z0.As::generic<T>(System.Int32)
    IL_002D: ret
    IL_002E: ldtoken T
    IL_0033: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0038: ldtoken System.Byte
    IL_003D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0042: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0047: brfalse.s IL_005C
    IL_0049: ldarg.0
    IL_004A: call System.Byte Z0.As::uint8<T>(T)
    IL_004F: ldarg.1
    IL_0050: call System.Byte Z0.As::uint8<T>(T)
    IL_0055: rem
    IL_0056: call T Z0.As::generic<T>(System.Int32)
    IL_005B: ret
    IL_005C: ldtoken T
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: ldtoken System.Int16
    IL_006B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0070: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0075: brfalse.s IL_008A
    IL_0077: ldarg.0
    IL_0078: call System.Int16 Z0.As::int16<T>(T)
    IL_007D: ldarg.1
    IL_007E: call System.Int16 Z0.As::int16<T>(T)
    IL_0083: rem
    IL_0084: call T Z0.As::generic<T>(System.Int32)
    IL_0089: ret
    IL_008A: ldtoken T
    IL_008F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0094: ldtoken System.UInt16
    IL_0099: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_009E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A3: brfalse.s IL_00B8
    IL_00A5: ldarg.0
    IL_00A6: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00AB: ldarg.1
    IL_00AC: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00B1: rem
    IL_00B2: call T Z0.As::generic<T>(System.Int32)
    IL_00B7: ret
    IL_00B8: ldtoken T
    IL_00BD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C2: ldtoken System.Int32
    IL_00C7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00CC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00D1: brfalse.s IL_00E6
    IL_00D3: ldarg.0
    IL_00D4: call System.Int32 Z0.As::int32<T>(T)
    IL_00D9: ldarg.1
    IL_00DA: call System.Int32 Z0.As::int32<T>(T)
    IL_00DF: rem
    IL_00E0: call T Z0.As::generic<T>(System.Int32)
    IL_00E5: ret
    IL_00E6: ldtoken T
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: ldtoken System.UInt32
    IL_00F5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FA: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00FF: brfalse.s IL_0114
    IL_0101: ldarg.0
    IL_0102: call System.UInt32 Z0.As::uint32<T>(T)
    IL_0107: ldarg.1
    IL_0108: call System.UInt32 Z0.As::uint32<T>(T)
    IL_010D: rem.un
    IL_010E: call T Z0.As::generic<T>(System.UInt32)
    IL_0113: ret
    IL_0114: ldtoken T
    IL_0119: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011E: ldtoken System.Int64
    IL_0123: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0128: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_012D: brfalse.s IL_0142
    IL_012F: ldarg.0
    IL_0130: call System.Int64 Z0.As::int64<T>(T)
    IL_0135: ldarg.1
    IL_0136: call System.Int64 Z0.As::int64<T>(T)
    IL_013B: rem
    IL_013C: call T Z0.As::generic<T>(System.Int64)
    IL_0141: ret
    IL_0142: ldtoken T
    IL_0147: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014C: ldtoken System.UInt64
    IL_0151: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0156: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_015B: brfalse.s IL_0170
    IL_015D: ldarg.0
    IL_015E: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0163: ldarg.1
    IL_0164: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0169: rem.un
    IL_016A: call T Z0.As::generic<T>(System.UInt64)
    IL_016F: ret
    IL_0170: ldtoken T
    IL_0175: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_017A: ldtoken System.Single
    IL_017F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0184: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0189: brfalse.s IL_019E
    IL_018B: ldarg.0
    IL_018C: call System.Single Z0.As::float32<T>(T)
    IL_0191: ldarg.1
    IL_0192: call System.Single Z0.As::float32<T>(T)
    IL_0197: rem
    IL_0198: call T Z0.As::generic<T>(System.Single)
    IL_019D: ret
    IL_019E: ldtoken T
    IL_01A3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A8: ldtoken System.Double
    IL_01AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01B2: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01B7: brfalse.s IL_01CC
    IL_01B9: ldarg.0
    IL_01BA: call System.Double Z0.As::float64<T>(T)
    IL_01BF: ldarg.1
    IL_01C0: call System.Double Z0.As::float64<T>(T)
    IL_01C5: rem
    IL_01C6: call T Z0.As::generic<T>(System.Double)
    IL_01CB: ret
    IL_01CC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_01D6: ldc.i4.s 43
    IL_01D8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01DD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01E2: throw

}
byte mul<byte>(byte lhs, byte rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::mulI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::mulU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::mulI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::mulU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::mulI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::mulU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::mulI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::mulU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::mulF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::mulF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
ushort mul<ushort>(ushort lhs, ushort rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::mulI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::mulU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::mulI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::mulU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::mulI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::mulU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::mulI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::mulU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::mulF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::mulF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
uint mul<uint>(uint lhs, uint rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::mulI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::mulU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::mulI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::mulU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::mulI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::mulU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::mulI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::mulU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::mulF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::mulF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
ulong mul<ulong>(ulong lhs, ulong rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::mulI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::mulU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::mulI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::mulU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::mulI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::mulU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::mulI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::mulU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::mulF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::mulF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
sbyte mul<sbyte>(sbyte lhs, sbyte rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::mulI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::mulU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::mulI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::mulU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::mulI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::mulU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::mulI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::mulU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::mulF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::mulF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
short mul<short>(short lhs, short rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::mulI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::mulU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::mulI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::mulU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::mulI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::mulU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::mulI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::mulU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::mulF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::mulF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
int mul<int>(int lhs, int rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::mulI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::mulU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::mulI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::mulU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::mulI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::mulU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::mulI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::mulU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::mulF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::mulF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
long mul<long>(long lhs, long rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::mulI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::mulU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::mulI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::mulU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::mulI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::mulU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::mulI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::mulU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::mulF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::mulF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
float mul<float>(float lhs, float rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::mulI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::mulU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::mulI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::mulU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::mulI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::mulU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::mulI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::mulU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::mulF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::mulF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
double mul<double>(double lhs, double rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::mulI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::mulU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::mulI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::mulU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::mulI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::mulU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::mulI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::mulU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::mulF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::mulF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mul.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
byte negate<byte>(byte src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002C
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: call System.SByte Z0.math::negate(System.SByte)
    IL_0026: call T Z0.As::generic<T>(System.SByte)
    IL_002B: ret
    IL_002C: ldtoken T
    IL_0031: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0036: ldtoken System.Byte
    IL_003B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0040: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0045: brfalse.s IL_0058
    IL_0047: ldarg.0
    IL_0048: call System.Byte Z0.As::uint8<T>(T)
    IL_004D: call System.Byte Z0.math::negate(System.Byte)
    IL_0052: call T Z0.As::generic<T>(System.Byte)
    IL_0057: ret
    IL_0058: ldtoken T
    IL_005D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0062: ldtoken System.Int16
    IL_0067: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_006C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0071: brfalse.s IL_0084
    IL_0073: ldarg.0
    IL_0074: call System.Int16 Z0.As::int16<T>(T)
    IL_0079: call System.Int16 Z0.math::negate(System.Int16)
    IL_007E: call T Z0.As::generic<T>(System.Int16)
    IL_0083: ret
    IL_0084: ldtoken T
    IL_0089: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008E: ldtoken System.UInt16
    IL_0093: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0098: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_009D: brfalse.s IL_00B0
    IL_009F: ldarg.0
    IL_00A0: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00A5: call System.UInt16 Z0.math::negate(System.UInt16)
    IL_00AA: call T Z0.As::generic<T>(System.UInt16)
    IL_00AF: ret
    IL_00B0: ldtoken T
    IL_00B5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BA: ldtoken System.Int32
    IL_00BF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C4: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C9: brfalse.s IL_00DC
    IL_00CB: ldarg.0
    IL_00CC: call System.Int32 Z0.As::int32<T>(T)
    IL_00D1: call System.Int32 Z0.math::negate(System.Int32)
    IL_00D6: call T Z0.As::generic<T>(System.Int32)
    IL_00DB: ret
    IL_00DC: ldtoken T
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: ldtoken System.UInt32
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00F5: brfalse.s IL_0108
    IL_00F7: ldarg.0
    IL_00F8: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00FD: call System.UInt32 Z0.math::negate(System.UInt32)
    IL_0102: call T Z0.As::generic<T>(System.UInt32)
    IL_0107: ret
    IL_0108: ldtoken T
    IL_010D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0112: ldtoken System.Int64
    IL_0117: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0121: brfalse.s IL_0134
    IL_0123: ldarg.0
    IL_0124: call System.Int64 Z0.As::int64<T>(T)
    IL_0129: call System.Int64 Z0.math::negate(System.Int64)
    IL_012E: call T Z0.As::generic<T>(System.Int64)
    IL_0133: ret
    IL_0134: ldtoken T
    IL_0139: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_013E: ldtoken System.UInt64
    IL_0143: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0148: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_014D: brfalse.s IL_0160
    IL_014F: ldarg.0
    IL_0150: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0155: call System.UInt64 Z0.math::negate(System.UInt64)
    IL_015A: call T Z0.As::generic<T>(System.UInt64)
    IL_015F: ret
    IL_0160: ldtoken T
    IL_0165: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_016A: ldtoken System.Single
    IL_016F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0174: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0179: brfalse.s IL_018C
    IL_017B: ldarg.0
    IL_017C: call System.Single Z0.As::float32<T>(T)
    IL_0181: call System.Single Z0.math::negate(System.Single)
    IL_0186: call T Z0.As::generic<T>(System.Single)
    IL_018B: ret
    IL_018C: ldtoken T
    IL_0191: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0196: ldtoken System.Double
    IL_019B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01A5: brfalse.s IL_01B8
    IL_01A7: ldarg.0
    IL_01A8: call System.Double Z0.As::float64<T>(T)
    IL_01AD: call System.Double Z0.math::negate(System.Double)
    IL_01B2: call T Z0.As::generic<T>(System.Double)
    IL_01B7: ret
    IL_01B8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01BD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01C2: ldc.i4.s 43
    IL_01C4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01C9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01CE: throw

}
ushort negate<ushort>(ushort src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002C
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: call System.SByte Z0.math::negate(System.SByte)
    IL_0026: call T Z0.As::generic<T>(System.SByte)
    IL_002B: ret
    IL_002C: ldtoken T
    IL_0031: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0036: ldtoken System.Byte
    IL_003B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0040: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0045: brfalse.s IL_0058
    IL_0047: ldarg.0
    IL_0048: call System.Byte Z0.As::uint8<T>(T)
    IL_004D: call System.Byte Z0.math::negate(System.Byte)
    IL_0052: call T Z0.As::generic<T>(System.Byte)
    IL_0057: ret
    IL_0058: ldtoken T
    IL_005D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0062: ldtoken System.Int16
    IL_0067: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_006C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0071: brfalse.s IL_0084
    IL_0073: ldarg.0
    IL_0074: call System.Int16 Z0.As::int16<T>(T)
    IL_0079: call System.Int16 Z0.math::negate(System.Int16)
    IL_007E: call T Z0.As::generic<T>(System.Int16)
    IL_0083: ret
    IL_0084: ldtoken T
    IL_0089: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008E: ldtoken System.UInt16
    IL_0093: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0098: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_009D: brfalse.s IL_00B0
    IL_009F: ldarg.0
    IL_00A0: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00A5: call System.UInt16 Z0.math::negate(System.UInt16)
    IL_00AA: call T Z0.As::generic<T>(System.UInt16)
    IL_00AF: ret
    IL_00B0: ldtoken T
    IL_00B5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BA: ldtoken System.Int32
    IL_00BF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C4: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C9: brfalse.s IL_00DC
    IL_00CB: ldarg.0
    IL_00CC: call System.Int32 Z0.As::int32<T>(T)
    IL_00D1: call System.Int32 Z0.math::negate(System.Int32)
    IL_00D6: call T Z0.As::generic<T>(System.Int32)
    IL_00DB: ret
    IL_00DC: ldtoken T
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: ldtoken System.UInt32
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00F5: brfalse.s IL_0108
    IL_00F7: ldarg.0
    IL_00F8: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00FD: call System.UInt32 Z0.math::negate(System.UInt32)
    IL_0102: call T Z0.As::generic<T>(System.UInt32)
    IL_0107: ret
    IL_0108: ldtoken T
    IL_010D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0112: ldtoken System.Int64
    IL_0117: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0121: brfalse.s IL_0134
    IL_0123: ldarg.0
    IL_0124: call System.Int64 Z0.As::int64<T>(T)
    IL_0129: call System.Int64 Z0.math::negate(System.Int64)
    IL_012E: call T Z0.As::generic<T>(System.Int64)
    IL_0133: ret
    IL_0134: ldtoken T
    IL_0139: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_013E: ldtoken System.UInt64
    IL_0143: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0148: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_014D: brfalse.s IL_0160
    IL_014F: ldarg.0
    IL_0150: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0155: call System.UInt64 Z0.math::negate(System.UInt64)
    IL_015A: call T Z0.As::generic<T>(System.UInt64)
    IL_015F: ret
    IL_0160: ldtoken T
    IL_0165: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_016A: ldtoken System.Single
    IL_016F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0174: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0179: brfalse.s IL_018C
    IL_017B: ldarg.0
    IL_017C: call System.Single Z0.As::float32<T>(T)
    IL_0181: call System.Single Z0.math::negate(System.Single)
    IL_0186: call T Z0.As::generic<T>(System.Single)
    IL_018B: ret
    IL_018C: ldtoken T
    IL_0191: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0196: ldtoken System.Double
    IL_019B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01A5: brfalse.s IL_01B8
    IL_01A7: ldarg.0
    IL_01A8: call System.Double Z0.As::float64<T>(T)
    IL_01AD: call System.Double Z0.math::negate(System.Double)
    IL_01B2: call T Z0.As::generic<T>(System.Double)
    IL_01B7: ret
    IL_01B8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01BD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01C2: ldc.i4.s 43
    IL_01C4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01C9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01CE: throw

}
uint negate<uint>(uint src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002C
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: call System.SByte Z0.math::negate(System.SByte)
    IL_0026: call T Z0.As::generic<T>(System.SByte)
    IL_002B: ret
    IL_002C: ldtoken T
    IL_0031: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0036: ldtoken System.Byte
    IL_003B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0040: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0045: brfalse.s IL_0058
    IL_0047: ldarg.0
    IL_0048: call System.Byte Z0.As::uint8<T>(T)
    IL_004D: call System.Byte Z0.math::negate(System.Byte)
    IL_0052: call T Z0.As::generic<T>(System.Byte)
    IL_0057: ret
    IL_0058: ldtoken T
    IL_005D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0062: ldtoken System.Int16
    IL_0067: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_006C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0071: brfalse.s IL_0084
    IL_0073: ldarg.0
    IL_0074: call System.Int16 Z0.As::int16<T>(T)
    IL_0079: call System.Int16 Z0.math::negate(System.Int16)
    IL_007E: call T Z0.As::generic<T>(System.Int16)
    IL_0083: ret
    IL_0084: ldtoken T
    IL_0089: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008E: ldtoken System.UInt16
    IL_0093: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0098: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_009D: brfalse.s IL_00B0
    IL_009F: ldarg.0
    IL_00A0: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00A5: call System.UInt16 Z0.math::negate(System.UInt16)
    IL_00AA: call T Z0.As::generic<T>(System.UInt16)
    IL_00AF: ret
    IL_00B0: ldtoken T
    IL_00B5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BA: ldtoken System.Int32
    IL_00BF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C4: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C9: brfalse.s IL_00DC
    IL_00CB: ldarg.0
    IL_00CC: call System.Int32 Z0.As::int32<T>(T)
    IL_00D1: call System.Int32 Z0.math::negate(System.Int32)
    IL_00D6: call T Z0.As::generic<T>(System.Int32)
    IL_00DB: ret
    IL_00DC: ldtoken T
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: ldtoken System.UInt32
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00F5: brfalse.s IL_0108
    IL_00F7: ldarg.0
    IL_00F8: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00FD: call System.UInt32 Z0.math::negate(System.UInt32)
    IL_0102: call T Z0.As::generic<T>(System.UInt32)
    IL_0107: ret
    IL_0108: ldtoken T
    IL_010D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0112: ldtoken System.Int64
    IL_0117: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0121: brfalse.s IL_0134
    IL_0123: ldarg.0
    IL_0124: call System.Int64 Z0.As::int64<T>(T)
    IL_0129: call System.Int64 Z0.math::negate(System.Int64)
    IL_012E: call T Z0.As::generic<T>(System.Int64)
    IL_0133: ret
    IL_0134: ldtoken T
    IL_0139: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_013E: ldtoken System.UInt64
    IL_0143: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0148: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_014D: brfalse.s IL_0160
    IL_014F: ldarg.0
    IL_0150: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0155: call System.UInt64 Z0.math::negate(System.UInt64)
    IL_015A: call T Z0.As::generic<T>(System.UInt64)
    IL_015F: ret
    IL_0160: ldtoken T
    IL_0165: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_016A: ldtoken System.Single
    IL_016F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0174: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0179: brfalse.s IL_018C
    IL_017B: ldarg.0
    IL_017C: call System.Single Z0.As::float32<T>(T)
    IL_0181: call System.Single Z0.math::negate(System.Single)
    IL_0186: call T Z0.As::generic<T>(System.Single)
    IL_018B: ret
    IL_018C: ldtoken T
    IL_0191: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0196: ldtoken System.Double
    IL_019B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01A5: brfalse.s IL_01B8
    IL_01A7: ldarg.0
    IL_01A8: call System.Double Z0.As::float64<T>(T)
    IL_01AD: call System.Double Z0.math::negate(System.Double)
    IL_01B2: call T Z0.As::generic<T>(System.Double)
    IL_01B7: ret
    IL_01B8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01BD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01C2: ldc.i4.s 43
    IL_01C4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01C9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01CE: throw

}
ulong negate<ulong>(ulong src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002C
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: call System.SByte Z0.math::negate(System.SByte)
    IL_0026: call T Z0.As::generic<T>(System.SByte)
    IL_002B: ret
    IL_002C: ldtoken T
    IL_0031: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0036: ldtoken System.Byte
    IL_003B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0040: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0045: brfalse.s IL_0058
    IL_0047: ldarg.0
    IL_0048: call System.Byte Z0.As::uint8<T>(T)
    IL_004D: call System.Byte Z0.math::negate(System.Byte)
    IL_0052: call T Z0.As::generic<T>(System.Byte)
    IL_0057: ret
    IL_0058: ldtoken T
    IL_005D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0062: ldtoken System.Int16
    IL_0067: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_006C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0071: brfalse.s IL_0084
    IL_0073: ldarg.0
    IL_0074: call System.Int16 Z0.As::int16<T>(T)
    IL_0079: call System.Int16 Z0.math::negate(System.Int16)
    IL_007E: call T Z0.As::generic<T>(System.Int16)
    IL_0083: ret
    IL_0084: ldtoken T
    IL_0089: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008E: ldtoken System.UInt16
    IL_0093: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0098: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_009D: brfalse.s IL_00B0
    IL_009F: ldarg.0
    IL_00A0: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00A5: call System.UInt16 Z0.math::negate(System.UInt16)
    IL_00AA: call T Z0.As::generic<T>(System.UInt16)
    IL_00AF: ret
    IL_00B0: ldtoken T
    IL_00B5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BA: ldtoken System.Int32
    IL_00BF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C4: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C9: brfalse.s IL_00DC
    IL_00CB: ldarg.0
    IL_00CC: call System.Int32 Z0.As::int32<T>(T)
    IL_00D1: call System.Int32 Z0.math::negate(System.Int32)
    IL_00D6: call T Z0.As::generic<T>(System.Int32)
    IL_00DB: ret
    IL_00DC: ldtoken T
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: ldtoken System.UInt32
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00F5: brfalse.s IL_0108
    IL_00F7: ldarg.0
    IL_00F8: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00FD: call System.UInt32 Z0.math::negate(System.UInt32)
    IL_0102: call T Z0.As::generic<T>(System.UInt32)
    IL_0107: ret
    IL_0108: ldtoken T
    IL_010D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0112: ldtoken System.Int64
    IL_0117: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0121: brfalse.s IL_0134
    IL_0123: ldarg.0
    IL_0124: call System.Int64 Z0.As::int64<T>(T)
    IL_0129: call System.Int64 Z0.math::negate(System.Int64)
    IL_012E: call T Z0.As::generic<T>(System.Int64)
    IL_0133: ret
    IL_0134: ldtoken T
    IL_0139: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_013E: ldtoken System.UInt64
    IL_0143: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0148: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_014D: brfalse.s IL_0160
    IL_014F: ldarg.0
    IL_0150: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0155: call System.UInt64 Z0.math::negate(System.UInt64)
    IL_015A: call T Z0.As::generic<T>(System.UInt64)
    IL_015F: ret
    IL_0160: ldtoken T
    IL_0165: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_016A: ldtoken System.Single
    IL_016F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0174: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0179: brfalse.s IL_018C
    IL_017B: ldarg.0
    IL_017C: call System.Single Z0.As::float32<T>(T)
    IL_0181: call System.Single Z0.math::negate(System.Single)
    IL_0186: call T Z0.As::generic<T>(System.Single)
    IL_018B: ret
    IL_018C: ldtoken T
    IL_0191: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0196: ldtoken System.Double
    IL_019B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01A5: brfalse.s IL_01B8
    IL_01A7: ldarg.0
    IL_01A8: call System.Double Z0.As::float64<T>(T)
    IL_01AD: call System.Double Z0.math::negate(System.Double)
    IL_01B2: call T Z0.As::generic<T>(System.Double)
    IL_01B7: ret
    IL_01B8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01BD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01C2: ldc.i4.s 43
    IL_01C4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01C9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01CE: throw

}
sbyte negate<sbyte>(sbyte src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002C
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: call System.SByte Z0.math::negate(System.SByte)
    IL_0026: call T Z0.As::generic<T>(System.SByte)
    IL_002B: ret
    IL_002C: ldtoken T
    IL_0031: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0036: ldtoken System.Byte
    IL_003B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0040: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0045: brfalse.s IL_0058
    IL_0047: ldarg.0
    IL_0048: call System.Byte Z0.As::uint8<T>(T)
    IL_004D: call System.Byte Z0.math::negate(System.Byte)
    IL_0052: call T Z0.As::generic<T>(System.Byte)
    IL_0057: ret
    IL_0058: ldtoken T
    IL_005D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0062: ldtoken System.Int16
    IL_0067: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_006C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0071: brfalse.s IL_0084
    IL_0073: ldarg.0
    IL_0074: call System.Int16 Z0.As::int16<T>(T)
    IL_0079: call System.Int16 Z0.math::negate(System.Int16)
    IL_007E: call T Z0.As::generic<T>(System.Int16)
    IL_0083: ret
    IL_0084: ldtoken T
    IL_0089: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008E: ldtoken System.UInt16
    IL_0093: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0098: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_009D: brfalse.s IL_00B0
    IL_009F: ldarg.0
    IL_00A0: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00A5: call System.UInt16 Z0.math::negate(System.UInt16)
    IL_00AA: call T Z0.As::generic<T>(System.UInt16)
    IL_00AF: ret
    IL_00B0: ldtoken T
    IL_00B5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BA: ldtoken System.Int32
    IL_00BF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C4: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C9: brfalse.s IL_00DC
    IL_00CB: ldarg.0
    IL_00CC: call System.Int32 Z0.As::int32<T>(T)
    IL_00D1: call System.Int32 Z0.math::negate(System.Int32)
    IL_00D6: call T Z0.As::generic<T>(System.Int32)
    IL_00DB: ret
    IL_00DC: ldtoken T
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: ldtoken System.UInt32
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00F5: brfalse.s IL_0108
    IL_00F7: ldarg.0
    IL_00F8: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00FD: call System.UInt32 Z0.math::negate(System.UInt32)
    IL_0102: call T Z0.As::generic<T>(System.UInt32)
    IL_0107: ret
    IL_0108: ldtoken T
    IL_010D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0112: ldtoken System.Int64
    IL_0117: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0121: brfalse.s IL_0134
    IL_0123: ldarg.0
    IL_0124: call System.Int64 Z0.As::int64<T>(T)
    IL_0129: call System.Int64 Z0.math::negate(System.Int64)
    IL_012E: call T Z0.As::generic<T>(System.Int64)
    IL_0133: ret
    IL_0134: ldtoken T
    IL_0139: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_013E: ldtoken System.UInt64
    IL_0143: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0148: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_014D: brfalse.s IL_0160
    IL_014F: ldarg.0
    IL_0150: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0155: call System.UInt64 Z0.math::negate(System.UInt64)
    IL_015A: call T Z0.As::generic<T>(System.UInt64)
    IL_015F: ret
    IL_0160: ldtoken T
    IL_0165: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_016A: ldtoken System.Single
    IL_016F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0174: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0179: brfalse.s IL_018C
    IL_017B: ldarg.0
    IL_017C: call System.Single Z0.As::float32<T>(T)
    IL_0181: call System.Single Z0.math::negate(System.Single)
    IL_0186: call T Z0.As::generic<T>(System.Single)
    IL_018B: ret
    IL_018C: ldtoken T
    IL_0191: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0196: ldtoken System.Double
    IL_019B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01A5: brfalse.s IL_01B8
    IL_01A7: ldarg.0
    IL_01A8: call System.Double Z0.As::float64<T>(T)
    IL_01AD: call System.Double Z0.math::negate(System.Double)
    IL_01B2: call T Z0.As::generic<T>(System.Double)
    IL_01B7: ret
    IL_01B8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01BD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01C2: ldc.i4.s 43
    IL_01C4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01C9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01CE: throw

}
short negate<short>(short src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002C
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: call System.SByte Z0.math::negate(System.SByte)
    IL_0026: call T Z0.As::generic<T>(System.SByte)
    IL_002B: ret
    IL_002C: ldtoken T
    IL_0031: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0036: ldtoken System.Byte
    IL_003B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0040: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0045: brfalse.s IL_0058
    IL_0047: ldarg.0
    IL_0048: call System.Byte Z0.As::uint8<T>(T)
    IL_004D: call System.Byte Z0.math::negate(System.Byte)
    IL_0052: call T Z0.As::generic<T>(System.Byte)
    IL_0057: ret
    IL_0058: ldtoken T
    IL_005D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0062: ldtoken System.Int16
    IL_0067: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_006C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0071: brfalse.s IL_0084
    IL_0073: ldarg.0
    IL_0074: call System.Int16 Z0.As::int16<T>(T)
    IL_0079: call System.Int16 Z0.math::negate(System.Int16)
    IL_007E: call T Z0.As::generic<T>(System.Int16)
    IL_0083: ret
    IL_0084: ldtoken T
    IL_0089: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008E: ldtoken System.UInt16
    IL_0093: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0098: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_009D: brfalse.s IL_00B0
    IL_009F: ldarg.0
    IL_00A0: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00A5: call System.UInt16 Z0.math::negate(System.UInt16)
    IL_00AA: call T Z0.As::generic<T>(System.UInt16)
    IL_00AF: ret
    IL_00B0: ldtoken T
    IL_00B5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BA: ldtoken System.Int32
    IL_00BF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C4: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C9: brfalse.s IL_00DC
    IL_00CB: ldarg.0
    IL_00CC: call System.Int32 Z0.As::int32<T>(T)
    IL_00D1: call System.Int32 Z0.math::negate(System.Int32)
    IL_00D6: call T Z0.As::generic<T>(System.Int32)
    IL_00DB: ret
    IL_00DC: ldtoken T
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: ldtoken System.UInt32
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00F5: brfalse.s IL_0108
    IL_00F7: ldarg.0
    IL_00F8: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00FD: call System.UInt32 Z0.math::negate(System.UInt32)
    IL_0102: call T Z0.As::generic<T>(System.UInt32)
    IL_0107: ret
    IL_0108: ldtoken T
    IL_010D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0112: ldtoken System.Int64
    IL_0117: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0121: brfalse.s IL_0134
    IL_0123: ldarg.0
    IL_0124: call System.Int64 Z0.As::int64<T>(T)
    IL_0129: call System.Int64 Z0.math::negate(System.Int64)
    IL_012E: call T Z0.As::generic<T>(System.Int64)
    IL_0133: ret
    IL_0134: ldtoken T
    IL_0139: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_013E: ldtoken System.UInt64
    IL_0143: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0148: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_014D: brfalse.s IL_0160
    IL_014F: ldarg.0
    IL_0150: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0155: call System.UInt64 Z0.math::negate(System.UInt64)
    IL_015A: call T Z0.As::generic<T>(System.UInt64)
    IL_015F: ret
    IL_0160: ldtoken T
    IL_0165: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_016A: ldtoken System.Single
    IL_016F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0174: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0179: brfalse.s IL_018C
    IL_017B: ldarg.0
    IL_017C: call System.Single Z0.As::float32<T>(T)
    IL_0181: call System.Single Z0.math::negate(System.Single)
    IL_0186: call T Z0.As::generic<T>(System.Single)
    IL_018B: ret
    IL_018C: ldtoken T
    IL_0191: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0196: ldtoken System.Double
    IL_019B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01A5: brfalse.s IL_01B8
    IL_01A7: ldarg.0
    IL_01A8: call System.Double Z0.As::float64<T>(T)
    IL_01AD: call System.Double Z0.math::negate(System.Double)
    IL_01B2: call T Z0.As::generic<T>(System.Double)
    IL_01B7: ret
    IL_01B8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01BD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01C2: ldc.i4.s 43
    IL_01C4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01C9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01CE: throw

}
int negate<int>(int src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002C
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: call System.SByte Z0.math::negate(System.SByte)
    IL_0026: call T Z0.As::generic<T>(System.SByte)
    IL_002B: ret
    IL_002C: ldtoken T
    IL_0031: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0036: ldtoken System.Byte
    IL_003B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0040: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0045: brfalse.s IL_0058
    IL_0047: ldarg.0
    IL_0048: call System.Byte Z0.As::uint8<T>(T)
    IL_004D: call System.Byte Z0.math::negate(System.Byte)
    IL_0052: call T Z0.As::generic<T>(System.Byte)
    IL_0057: ret
    IL_0058: ldtoken T
    IL_005D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0062: ldtoken System.Int16
    IL_0067: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_006C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0071: brfalse.s IL_0084
    IL_0073: ldarg.0
    IL_0074: call System.Int16 Z0.As::int16<T>(T)
    IL_0079: call System.Int16 Z0.math::negate(System.Int16)
    IL_007E: call T Z0.As::generic<T>(System.Int16)
    IL_0083: ret
    IL_0084: ldtoken T
    IL_0089: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008E: ldtoken System.UInt16
    IL_0093: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0098: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_009D: brfalse.s IL_00B0
    IL_009F: ldarg.0
    IL_00A0: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00A5: call System.UInt16 Z0.math::negate(System.UInt16)
    IL_00AA: call T Z0.As::generic<T>(System.UInt16)
    IL_00AF: ret
    IL_00B0: ldtoken T
    IL_00B5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BA: ldtoken System.Int32
    IL_00BF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C4: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C9: brfalse.s IL_00DC
    IL_00CB: ldarg.0
    IL_00CC: call System.Int32 Z0.As::int32<T>(T)
    IL_00D1: call System.Int32 Z0.math::negate(System.Int32)
    IL_00D6: call T Z0.As::generic<T>(System.Int32)
    IL_00DB: ret
    IL_00DC: ldtoken T
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: ldtoken System.UInt32
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00F5: brfalse.s IL_0108
    IL_00F7: ldarg.0
    IL_00F8: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00FD: call System.UInt32 Z0.math::negate(System.UInt32)
    IL_0102: call T Z0.As::generic<T>(System.UInt32)
    IL_0107: ret
    IL_0108: ldtoken T
    IL_010D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0112: ldtoken System.Int64
    IL_0117: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0121: brfalse.s IL_0134
    IL_0123: ldarg.0
    IL_0124: call System.Int64 Z0.As::int64<T>(T)
    IL_0129: call System.Int64 Z0.math::negate(System.Int64)
    IL_012E: call T Z0.As::generic<T>(System.Int64)
    IL_0133: ret
    IL_0134: ldtoken T
    IL_0139: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_013E: ldtoken System.UInt64
    IL_0143: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0148: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_014D: brfalse.s IL_0160
    IL_014F: ldarg.0
    IL_0150: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0155: call System.UInt64 Z0.math::negate(System.UInt64)
    IL_015A: call T Z0.As::generic<T>(System.UInt64)
    IL_015F: ret
    IL_0160: ldtoken T
    IL_0165: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_016A: ldtoken System.Single
    IL_016F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0174: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0179: brfalse.s IL_018C
    IL_017B: ldarg.0
    IL_017C: call System.Single Z0.As::float32<T>(T)
    IL_0181: call System.Single Z0.math::negate(System.Single)
    IL_0186: call T Z0.As::generic<T>(System.Single)
    IL_018B: ret
    IL_018C: ldtoken T
    IL_0191: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0196: ldtoken System.Double
    IL_019B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01A5: brfalse.s IL_01B8
    IL_01A7: ldarg.0
    IL_01A8: call System.Double Z0.As::float64<T>(T)
    IL_01AD: call System.Double Z0.math::negate(System.Double)
    IL_01B2: call T Z0.As::generic<T>(System.Double)
    IL_01B7: ret
    IL_01B8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01BD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01C2: ldc.i4.s 43
    IL_01C4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01C9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01CE: throw

}
long negate<long>(long src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002C
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: call System.SByte Z0.math::negate(System.SByte)
    IL_0026: call T Z0.As::generic<T>(System.SByte)
    IL_002B: ret
    IL_002C: ldtoken T
    IL_0031: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0036: ldtoken System.Byte
    IL_003B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0040: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0045: brfalse.s IL_0058
    IL_0047: ldarg.0
    IL_0048: call System.Byte Z0.As::uint8<T>(T)
    IL_004D: call System.Byte Z0.math::negate(System.Byte)
    IL_0052: call T Z0.As::generic<T>(System.Byte)
    IL_0057: ret
    IL_0058: ldtoken T
    IL_005D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0062: ldtoken System.Int16
    IL_0067: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_006C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0071: brfalse.s IL_0084
    IL_0073: ldarg.0
    IL_0074: call System.Int16 Z0.As::int16<T>(T)
    IL_0079: call System.Int16 Z0.math::negate(System.Int16)
    IL_007E: call T Z0.As::generic<T>(System.Int16)
    IL_0083: ret
    IL_0084: ldtoken T
    IL_0089: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008E: ldtoken System.UInt16
    IL_0093: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0098: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_009D: brfalse.s IL_00B0
    IL_009F: ldarg.0
    IL_00A0: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00A5: call System.UInt16 Z0.math::negate(System.UInt16)
    IL_00AA: call T Z0.As::generic<T>(System.UInt16)
    IL_00AF: ret
    IL_00B0: ldtoken T
    IL_00B5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BA: ldtoken System.Int32
    IL_00BF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C4: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C9: brfalse.s IL_00DC
    IL_00CB: ldarg.0
    IL_00CC: call System.Int32 Z0.As::int32<T>(T)
    IL_00D1: call System.Int32 Z0.math::negate(System.Int32)
    IL_00D6: call T Z0.As::generic<T>(System.Int32)
    IL_00DB: ret
    IL_00DC: ldtoken T
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: ldtoken System.UInt32
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00F5: brfalse.s IL_0108
    IL_00F7: ldarg.0
    IL_00F8: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00FD: call System.UInt32 Z0.math::negate(System.UInt32)
    IL_0102: call T Z0.As::generic<T>(System.UInt32)
    IL_0107: ret
    IL_0108: ldtoken T
    IL_010D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0112: ldtoken System.Int64
    IL_0117: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0121: brfalse.s IL_0134
    IL_0123: ldarg.0
    IL_0124: call System.Int64 Z0.As::int64<T>(T)
    IL_0129: call System.Int64 Z0.math::negate(System.Int64)
    IL_012E: call T Z0.As::generic<T>(System.Int64)
    IL_0133: ret
    IL_0134: ldtoken T
    IL_0139: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_013E: ldtoken System.UInt64
    IL_0143: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0148: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_014D: brfalse.s IL_0160
    IL_014F: ldarg.0
    IL_0150: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0155: call System.UInt64 Z0.math::negate(System.UInt64)
    IL_015A: call T Z0.As::generic<T>(System.UInt64)
    IL_015F: ret
    IL_0160: ldtoken T
    IL_0165: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_016A: ldtoken System.Single
    IL_016F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0174: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0179: brfalse.s IL_018C
    IL_017B: ldarg.0
    IL_017C: call System.Single Z0.As::float32<T>(T)
    IL_0181: call System.Single Z0.math::negate(System.Single)
    IL_0186: call T Z0.As::generic<T>(System.Single)
    IL_018B: ret
    IL_018C: ldtoken T
    IL_0191: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0196: ldtoken System.Double
    IL_019B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01A5: brfalse.s IL_01B8
    IL_01A7: ldarg.0
    IL_01A8: call System.Double Z0.As::float64<T>(T)
    IL_01AD: call System.Double Z0.math::negate(System.Double)
    IL_01B2: call T Z0.As::generic<T>(System.Double)
    IL_01B7: ret
    IL_01B8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01BD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01C2: ldc.i4.s 43
    IL_01C4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01C9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01CE: throw

}
float negate<float>(float src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002C
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: call System.SByte Z0.math::negate(System.SByte)
    IL_0026: call T Z0.As::generic<T>(System.SByte)
    IL_002B: ret
    IL_002C: ldtoken T
    IL_0031: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0036: ldtoken System.Byte
    IL_003B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0040: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0045: brfalse.s IL_0058
    IL_0047: ldarg.0
    IL_0048: call System.Byte Z0.As::uint8<T>(T)
    IL_004D: call System.Byte Z0.math::negate(System.Byte)
    IL_0052: call T Z0.As::generic<T>(System.Byte)
    IL_0057: ret
    IL_0058: ldtoken T
    IL_005D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0062: ldtoken System.Int16
    IL_0067: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_006C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0071: brfalse.s IL_0084
    IL_0073: ldarg.0
    IL_0074: call System.Int16 Z0.As::int16<T>(T)
    IL_0079: call System.Int16 Z0.math::negate(System.Int16)
    IL_007E: call T Z0.As::generic<T>(System.Int16)
    IL_0083: ret
    IL_0084: ldtoken T
    IL_0089: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008E: ldtoken System.UInt16
    IL_0093: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0098: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_009D: brfalse.s IL_00B0
    IL_009F: ldarg.0
    IL_00A0: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00A5: call System.UInt16 Z0.math::negate(System.UInt16)
    IL_00AA: call T Z0.As::generic<T>(System.UInt16)
    IL_00AF: ret
    IL_00B0: ldtoken T
    IL_00B5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BA: ldtoken System.Int32
    IL_00BF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C4: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C9: brfalse.s IL_00DC
    IL_00CB: ldarg.0
    IL_00CC: call System.Int32 Z0.As::int32<T>(T)
    IL_00D1: call System.Int32 Z0.math::negate(System.Int32)
    IL_00D6: call T Z0.As::generic<T>(System.Int32)
    IL_00DB: ret
    IL_00DC: ldtoken T
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: ldtoken System.UInt32
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00F5: brfalse.s IL_0108
    IL_00F7: ldarg.0
    IL_00F8: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00FD: call System.UInt32 Z0.math::negate(System.UInt32)
    IL_0102: call T Z0.As::generic<T>(System.UInt32)
    IL_0107: ret
    IL_0108: ldtoken T
    IL_010D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0112: ldtoken System.Int64
    IL_0117: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0121: brfalse.s IL_0134
    IL_0123: ldarg.0
    IL_0124: call System.Int64 Z0.As::int64<T>(T)
    IL_0129: call System.Int64 Z0.math::negate(System.Int64)
    IL_012E: call T Z0.As::generic<T>(System.Int64)
    IL_0133: ret
    IL_0134: ldtoken T
    IL_0139: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_013E: ldtoken System.UInt64
    IL_0143: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0148: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_014D: brfalse.s IL_0160
    IL_014F: ldarg.0
    IL_0150: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0155: call System.UInt64 Z0.math::negate(System.UInt64)
    IL_015A: call T Z0.As::generic<T>(System.UInt64)
    IL_015F: ret
    IL_0160: ldtoken T
    IL_0165: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_016A: ldtoken System.Single
    IL_016F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0174: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0179: brfalse.s IL_018C
    IL_017B: ldarg.0
    IL_017C: call System.Single Z0.As::float32<T>(T)
    IL_0181: call System.Single Z0.math::negate(System.Single)
    IL_0186: call T Z0.As::generic<T>(System.Single)
    IL_018B: ret
    IL_018C: ldtoken T
    IL_0191: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0196: ldtoken System.Double
    IL_019B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01A5: brfalse.s IL_01B8
    IL_01A7: ldarg.0
    IL_01A8: call System.Double Z0.As::float64<T>(T)
    IL_01AD: call System.Double Z0.math::negate(System.Double)
    IL_01B2: call T Z0.As::generic<T>(System.Double)
    IL_01B7: ret
    IL_01B8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01BD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01C2: ldc.i4.s 43
    IL_01C4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01C9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01CE: throw

}
double negate<double>(double src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002C
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: call System.SByte Z0.math::negate(System.SByte)
    IL_0026: call T Z0.As::generic<T>(System.SByte)
    IL_002B: ret
    IL_002C: ldtoken T
    IL_0031: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0036: ldtoken System.Byte
    IL_003B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0040: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0045: brfalse.s IL_0058
    IL_0047: ldarg.0
    IL_0048: call System.Byte Z0.As::uint8<T>(T)
    IL_004D: call System.Byte Z0.math::negate(System.Byte)
    IL_0052: call T Z0.As::generic<T>(System.Byte)
    IL_0057: ret
    IL_0058: ldtoken T
    IL_005D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0062: ldtoken System.Int16
    IL_0067: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_006C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0071: brfalse.s IL_0084
    IL_0073: ldarg.0
    IL_0074: call System.Int16 Z0.As::int16<T>(T)
    IL_0079: call System.Int16 Z0.math::negate(System.Int16)
    IL_007E: call T Z0.As::generic<T>(System.Int16)
    IL_0083: ret
    IL_0084: ldtoken T
    IL_0089: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008E: ldtoken System.UInt16
    IL_0093: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0098: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_009D: brfalse.s IL_00B0
    IL_009F: ldarg.0
    IL_00A0: call System.UInt16 Z0.As::uint16<T>(T)
    IL_00A5: call System.UInt16 Z0.math::negate(System.UInt16)
    IL_00AA: call T Z0.As::generic<T>(System.UInt16)
    IL_00AF: ret
    IL_00B0: ldtoken T
    IL_00B5: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BA: ldtoken System.Int32
    IL_00BF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C4: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C9: brfalse.s IL_00DC
    IL_00CB: ldarg.0
    IL_00CC: call System.Int32 Z0.As::int32<T>(T)
    IL_00D1: call System.Int32 Z0.math::negate(System.Int32)
    IL_00D6: call T Z0.As::generic<T>(System.Int32)
    IL_00DB: ret
    IL_00DC: ldtoken T
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: ldtoken System.UInt32
    IL_00EB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00F0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00F5: brfalse.s IL_0108
    IL_00F7: ldarg.0
    IL_00F8: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00FD: call System.UInt32 Z0.math::negate(System.UInt32)
    IL_0102: call T Z0.As::generic<T>(System.UInt32)
    IL_0107: ret
    IL_0108: ldtoken T
    IL_010D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0112: ldtoken System.Int64
    IL_0117: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_011C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0121: brfalse.s IL_0134
    IL_0123: ldarg.0
    IL_0124: call System.Int64 Z0.As::int64<T>(T)
    IL_0129: call System.Int64 Z0.math::negate(System.Int64)
    IL_012E: call T Z0.As::generic<T>(System.Int64)
    IL_0133: ret
    IL_0134: ldtoken T
    IL_0139: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_013E: ldtoken System.UInt64
    IL_0143: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0148: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_014D: brfalse.s IL_0160
    IL_014F: ldarg.0
    IL_0150: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0155: call System.UInt64 Z0.math::negate(System.UInt64)
    IL_015A: call T Z0.As::generic<T>(System.UInt64)
    IL_015F: ret
    IL_0160: ldtoken T
    IL_0165: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_016A: ldtoken System.Single
    IL_016F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0174: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0179: brfalse.s IL_018C
    IL_017B: ldarg.0
    IL_017C: call System.Single Z0.As::float32<T>(T)
    IL_0181: call System.Single Z0.math::negate(System.Single)
    IL_0186: call T Z0.As::generic<T>(System.Single)
    IL_018B: ret
    IL_018C: ldtoken T
    IL_0191: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0196: ldtoken System.Double
    IL_019B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_01A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_01A5: brfalse.s IL_01B8
    IL_01A7: ldarg.0
    IL_01A8: call System.Double Z0.As::float64<T>(T)
    IL_01AD: call System.Double Z0.math::negate(System.Double)
    IL_01B2: call T Z0.As::generic<T>(System.Double)
    IL_01B7: ret
    IL_01B8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01BD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Negate.cs"
    IL_01C2: ldc.i4.s 43
    IL_01C4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01C9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01CE: throw

}
byte dec<byte>(byte src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002A
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: sub
    IL_0023: conv.i1
    IL_0024: call T Z0.As::generic<T>(System.SByte)
    IL_0029: ret
    IL_002A: ldtoken T
    IL_002F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0034: ldtoken System.Byte
    IL_0039: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0043: brfalse.s IL_0054
    IL_0045: ldarg.0
    IL_0046: call System.Byte Z0.As::uint8<T>(T)
    IL_004B: ldc.i4.1
    IL_004C: sub
    IL_004D: conv.u1
    IL_004E: call T Z0.As::generic<T>(System.Byte)
    IL_0053: ret
    IL_0054: ldtoken T
    IL_0059: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005E: ldtoken System.Int16
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006D: brfalse.s IL_007E
    IL_006F: ldarg.0
    IL_0070: call System.Int16 Z0.As::int16<T>(T)
    IL_0075: ldc.i4.1
    IL_0076: sub
    IL_0077: conv.i2
    IL_0078: call T Z0.As::generic<T>(System.Int16)
    IL_007D: ret
    IL_007E: ldtoken T
    IL_0083: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0088: ldtoken System.UInt16
    IL_008D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0092: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0097: brfalse.s IL_00A8
    IL_0099: ldarg.0
    IL_009A: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009F: ldc.i4.1
    IL_00A0: sub
    IL_00A1: conv.u2
    IL_00A2: call T Z0.As::generic<T>(System.UInt16)
    IL_00A7: ret
    IL_00A8: ldtoken T
    IL_00AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B2: ldtoken System.Int32
    IL_00B7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C1: brfalse.s IL_00D1
    IL_00C3: ldarg.0
    IL_00C4: call System.Int32 Z0.As::int32<T>(T)
    IL_00C9: ldc.i4.1
    IL_00CA: sub
    IL_00CB: call T Z0.As::generic<T>(System.Int32)
    IL_00D0: ret
    IL_00D1: ldtoken T
    IL_00D6: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DB: ldtoken System.UInt32
    IL_00E0: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E5: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EA: brfalse.s IL_00FA
    IL_00EC: ldarg.0
    IL_00ED: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00F2: ldc.i4.1
    IL_00F3: sub
    IL_00F4: call T Z0.As::generic<T>(System.UInt32)
    IL_00F9: ret
    IL_00FA: ldtoken T
    IL_00FF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0104: ldtoken System.Int64
    IL_0109: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0113: brfalse.s IL_0124
    IL_0115: ldarg.0
    IL_0116: call System.Int64 Z0.As::int64<T>(T)
    IL_011B: ldc.i4.1
    IL_011C: conv.i8
    IL_011D: sub
    IL_011E: call T Z0.As::generic<T>(System.Int64)
    IL_0123: ret
    IL_0124: ldtoken T
    IL_0129: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012E: ldtoken System.UInt64
    IL_0133: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0138: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_013D: brfalse.s IL_014E
    IL_013F: ldarg.0
    IL_0140: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0145: ldc.i4.1
    IL_0146: conv.i8
    IL_0147: sub
    IL_0148: call T Z0.As::generic<T>(System.UInt64)
    IL_014D: ret
    IL_014E: ldtoken T
    IL_0153: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0158: ldtoken System.Single
    IL_015D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0162: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0167: brfalse.s IL_017B
    IL_0169: ldarg.0
    IL_016A: call System.Single Z0.As::float32<T>(T)
    IL_016F: ldc.r4 1
    IL_0174: sub
    IL_0175: call T Z0.As::generic<T>(System.Single)
    IL_017A: ret
    IL_017B: ldtoken T
    IL_0180: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0185: ldtoken System.Double
    IL_018A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0194: brfalse.s IL_01AC
    IL_0196: ldarg.0
    IL_0197: call System.Double Z0.As::float64<T>(T)
    IL_019C: ldc.r8 1
    IL_01A5: sub
    IL_01A6: call T Z0.As::generic<T>(System.Double)
    IL_01AB: ret
    IL_01AC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B6: ldc.i4.s 41
    IL_01B8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01BD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01C2: throw

}
ushort dec<ushort>(ushort src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002A
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: sub
    IL_0023: conv.i1
    IL_0024: call T Z0.As::generic<T>(System.SByte)
    IL_0029: ret
    IL_002A: ldtoken T
    IL_002F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0034: ldtoken System.Byte
    IL_0039: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0043: brfalse.s IL_0054
    IL_0045: ldarg.0
    IL_0046: call System.Byte Z0.As::uint8<T>(T)
    IL_004B: ldc.i4.1
    IL_004C: sub
    IL_004D: conv.u1
    IL_004E: call T Z0.As::generic<T>(System.Byte)
    IL_0053: ret
    IL_0054: ldtoken T
    IL_0059: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005E: ldtoken System.Int16
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006D: brfalse.s IL_007E
    IL_006F: ldarg.0
    IL_0070: call System.Int16 Z0.As::int16<T>(T)
    IL_0075: ldc.i4.1
    IL_0076: sub
    IL_0077: conv.i2
    IL_0078: call T Z0.As::generic<T>(System.Int16)
    IL_007D: ret
    IL_007E: ldtoken T
    IL_0083: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0088: ldtoken System.UInt16
    IL_008D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0092: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0097: brfalse.s IL_00A8
    IL_0099: ldarg.0
    IL_009A: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009F: ldc.i4.1
    IL_00A0: sub
    IL_00A1: conv.u2
    IL_00A2: call T Z0.As::generic<T>(System.UInt16)
    IL_00A7: ret
    IL_00A8: ldtoken T
    IL_00AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B2: ldtoken System.Int32
    IL_00B7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C1: brfalse.s IL_00D1
    IL_00C3: ldarg.0
    IL_00C4: call System.Int32 Z0.As::int32<T>(T)
    IL_00C9: ldc.i4.1
    IL_00CA: sub
    IL_00CB: call T Z0.As::generic<T>(System.Int32)
    IL_00D0: ret
    IL_00D1: ldtoken T
    IL_00D6: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DB: ldtoken System.UInt32
    IL_00E0: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E5: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EA: brfalse.s IL_00FA
    IL_00EC: ldarg.0
    IL_00ED: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00F2: ldc.i4.1
    IL_00F3: sub
    IL_00F4: call T Z0.As::generic<T>(System.UInt32)
    IL_00F9: ret
    IL_00FA: ldtoken T
    IL_00FF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0104: ldtoken System.Int64
    IL_0109: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0113: brfalse.s IL_0124
    IL_0115: ldarg.0
    IL_0116: call System.Int64 Z0.As::int64<T>(T)
    IL_011B: ldc.i4.1
    IL_011C: conv.i8
    IL_011D: sub
    IL_011E: call T Z0.As::generic<T>(System.Int64)
    IL_0123: ret
    IL_0124: ldtoken T
    IL_0129: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012E: ldtoken System.UInt64
    IL_0133: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0138: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_013D: brfalse.s IL_014E
    IL_013F: ldarg.0
    IL_0140: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0145: ldc.i4.1
    IL_0146: conv.i8
    IL_0147: sub
    IL_0148: call T Z0.As::generic<T>(System.UInt64)
    IL_014D: ret
    IL_014E: ldtoken T
    IL_0153: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0158: ldtoken System.Single
    IL_015D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0162: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0167: brfalse.s IL_017B
    IL_0169: ldarg.0
    IL_016A: call System.Single Z0.As::float32<T>(T)
    IL_016F: ldc.r4 1
    IL_0174: sub
    IL_0175: call T Z0.As::generic<T>(System.Single)
    IL_017A: ret
    IL_017B: ldtoken T
    IL_0180: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0185: ldtoken System.Double
    IL_018A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0194: brfalse.s IL_01AC
    IL_0196: ldarg.0
    IL_0197: call System.Double Z0.As::float64<T>(T)
    IL_019C: ldc.r8 1
    IL_01A5: sub
    IL_01A6: call T Z0.As::generic<T>(System.Double)
    IL_01AB: ret
    IL_01AC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B6: ldc.i4.s 41
    IL_01B8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01BD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01C2: throw

}
uint dec<uint>(uint src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002A
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: sub
    IL_0023: conv.i1
    IL_0024: call T Z0.As::generic<T>(System.SByte)
    IL_0029: ret
    IL_002A: ldtoken T
    IL_002F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0034: ldtoken System.Byte
    IL_0039: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0043: brfalse.s IL_0054
    IL_0045: ldarg.0
    IL_0046: call System.Byte Z0.As::uint8<T>(T)
    IL_004B: ldc.i4.1
    IL_004C: sub
    IL_004D: conv.u1
    IL_004E: call T Z0.As::generic<T>(System.Byte)
    IL_0053: ret
    IL_0054: ldtoken T
    IL_0059: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005E: ldtoken System.Int16
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006D: brfalse.s IL_007E
    IL_006F: ldarg.0
    IL_0070: call System.Int16 Z0.As::int16<T>(T)
    IL_0075: ldc.i4.1
    IL_0076: sub
    IL_0077: conv.i2
    IL_0078: call T Z0.As::generic<T>(System.Int16)
    IL_007D: ret
    IL_007E: ldtoken T
    IL_0083: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0088: ldtoken System.UInt16
    IL_008D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0092: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0097: brfalse.s IL_00A8
    IL_0099: ldarg.0
    IL_009A: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009F: ldc.i4.1
    IL_00A0: sub
    IL_00A1: conv.u2
    IL_00A2: call T Z0.As::generic<T>(System.UInt16)
    IL_00A7: ret
    IL_00A8: ldtoken T
    IL_00AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B2: ldtoken System.Int32
    IL_00B7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C1: brfalse.s IL_00D1
    IL_00C3: ldarg.0
    IL_00C4: call System.Int32 Z0.As::int32<T>(T)
    IL_00C9: ldc.i4.1
    IL_00CA: sub
    IL_00CB: call T Z0.As::generic<T>(System.Int32)
    IL_00D0: ret
    IL_00D1: ldtoken T
    IL_00D6: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DB: ldtoken System.UInt32
    IL_00E0: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E5: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EA: brfalse.s IL_00FA
    IL_00EC: ldarg.0
    IL_00ED: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00F2: ldc.i4.1
    IL_00F3: sub
    IL_00F4: call T Z0.As::generic<T>(System.UInt32)
    IL_00F9: ret
    IL_00FA: ldtoken T
    IL_00FF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0104: ldtoken System.Int64
    IL_0109: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0113: brfalse.s IL_0124
    IL_0115: ldarg.0
    IL_0116: call System.Int64 Z0.As::int64<T>(T)
    IL_011B: ldc.i4.1
    IL_011C: conv.i8
    IL_011D: sub
    IL_011E: call T Z0.As::generic<T>(System.Int64)
    IL_0123: ret
    IL_0124: ldtoken T
    IL_0129: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012E: ldtoken System.UInt64
    IL_0133: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0138: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_013D: brfalse.s IL_014E
    IL_013F: ldarg.0
    IL_0140: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0145: ldc.i4.1
    IL_0146: conv.i8
    IL_0147: sub
    IL_0148: call T Z0.As::generic<T>(System.UInt64)
    IL_014D: ret
    IL_014E: ldtoken T
    IL_0153: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0158: ldtoken System.Single
    IL_015D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0162: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0167: brfalse.s IL_017B
    IL_0169: ldarg.0
    IL_016A: call System.Single Z0.As::float32<T>(T)
    IL_016F: ldc.r4 1
    IL_0174: sub
    IL_0175: call T Z0.As::generic<T>(System.Single)
    IL_017A: ret
    IL_017B: ldtoken T
    IL_0180: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0185: ldtoken System.Double
    IL_018A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0194: brfalse.s IL_01AC
    IL_0196: ldarg.0
    IL_0197: call System.Double Z0.As::float64<T>(T)
    IL_019C: ldc.r8 1
    IL_01A5: sub
    IL_01A6: call T Z0.As::generic<T>(System.Double)
    IL_01AB: ret
    IL_01AC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B6: ldc.i4.s 41
    IL_01B8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01BD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01C2: throw

}
ulong dec<ulong>(ulong src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002A
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: sub
    IL_0023: conv.i1
    IL_0024: call T Z0.As::generic<T>(System.SByte)
    IL_0029: ret
    IL_002A: ldtoken T
    IL_002F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0034: ldtoken System.Byte
    IL_0039: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0043: brfalse.s IL_0054
    IL_0045: ldarg.0
    IL_0046: call System.Byte Z0.As::uint8<T>(T)
    IL_004B: ldc.i4.1
    IL_004C: sub
    IL_004D: conv.u1
    IL_004E: call T Z0.As::generic<T>(System.Byte)
    IL_0053: ret
    IL_0054: ldtoken T
    IL_0059: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005E: ldtoken System.Int16
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006D: brfalse.s IL_007E
    IL_006F: ldarg.0
    IL_0070: call System.Int16 Z0.As::int16<T>(T)
    IL_0075: ldc.i4.1
    IL_0076: sub
    IL_0077: conv.i2
    IL_0078: call T Z0.As::generic<T>(System.Int16)
    IL_007D: ret
    IL_007E: ldtoken T
    IL_0083: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0088: ldtoken System.UInt16
    IL_008D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0092: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0097: brfalse.s IL_00A8
    IL_0099: ldarg.0
    IL_009A: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009F: ldc.i4.1
    IL_00A0: sub
    IL_00A1: conv.u2
    IL_00A2: call T Z0.As::generic<T>(System.UInt16)
    IL_00A7: ret
    IL_00A8: ldtoken T
    IL_00AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B2: ldtoken System.Int32
    IL_00B7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C1: brfalse.s IL_00D1
    IL_00C3: ldarg.0
    IL_00C4: call System.Int32 Z0.As::int32<T>(T)
    IL_00C9: ldc.i4.1
    IL_00CA: sub
    IL_00CB: call T Z0.As::generic<T>(System.Int32)
    IL_00D0: ret
    IL_00D1: ldtoken T
    IL_00D6: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DB: ldtoken System.UInt32
    IL_00E0: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E5: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EA: brfalse.s IL_00FA
    IL_00EC: ldarg.0
    IL_00ED: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00F2: ldc.i4.1
    IL_00F3: sub
    IL_00F4: call T Z0.As::generic<T>(System.UInt32)
    IL_00F9: ret
    IL_00FA: ldtoken T
    IL_00FF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0104: ldtoken System.Int64
    IL_0109: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0113: brfalse.s IL_0124
    IL_0115: ldarg.0
    IL_0116: call System.Int64 Z0.As::int64<T>(T)
    IL_011B: ldc.i4.1
    IL_011C: conv.i8
    IL_011D: sub
    IL_011E: call T Z0.As::generic<T>(System.Int64)
    IL_0123: ret
    IL_0124: ldtoken T
    IL_0129: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012E: ldtoken System.UInt64
    IL_0133: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0138: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_013D: brfalse.s IL_014E
    IL_013F: ldarg.0
    IL_0140: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0145: ldc.i4.1
    IL_0146: conv.i8
    IL_0147: sub
    IL_0148: call T Z0.As::generic<T>(System.UInt64)
    IL_014D: ret
    IL_014E: ldtoken T
    IL_0153: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0158: ldtoken System.Single
    IL_015D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0162: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0167: brfalse.s IL_017B
    IL_0169: ldarg.0
    IL_016A: call System.Single Z0.As::float32<T>(T)
    IL_016F: ldc.r4 1
    IL_0174: sub
    IL_0175: call T Z0.As::generic<T>(System.Single)
    IL_017A: ret
    IL_017B: ldtoken T
    IL_0180: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0185: ldtoken System.Double
    IL_018A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0194: brfalse.s IL_01AC
    IL_0196: ldarg.0
    IL_0197: call System.Double Z0.As::float64<T>(T)
    IL_019C: ldc.r8 1
    IL_01A5: sub
    IL_01A6: call T Z0.As::generic<T>(System.Double)
    IL_01AB: ret
    IL_01AC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B6: ldc.i4.s 41
    IL_01B8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01BD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01C2: throw

}
sbyte dec<sbyte>(sbyte src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002A
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: sub
    IL_0023: conv.i1
    IL_0024: call T Z0.As::generic<T>(System.SByte)
    IL_0029: ret
    IL_002A: ldtoken T
    IL_002F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0034: ldtoken System.Byte
    IL_0039: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0043: brfalse.s IL_0054
    IL_0045: ldarg.0
    IL_0046: call System.Byte Z0.As::uint8<T>(T)
    IL_004B: ldc.i4.1
    IL_004C: sub
    IL_004D: conv.u1
    IL_004E: call T Z0.As::generic<T>(System.Byte)
    IL_0053: ret
    IL_0054: ldtoken T
    IL_0059: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005E: ldtoken System.Int16
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006D: brfalse.s IL_007E
    IL_006F: ldarg.0
    IL_0070: call System.Int16 Z0.As::int16<T>(T)
    IL_0075: ldc.i4.1
    IL_0076: sub
    IL_0077: conv.i2
    IL_0078: call T Z0.As::generic<T>(System.Int16)
    IL_007D: ret
    IL_007E: ldtoken T
    IL_0083: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0088: ldtoken System.UInt16
    IL_008D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0092: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0097: brfalse.s IL_00A8
    IL_0099: ldarg.0
    IL_009A: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009F: ldc.i4.1
    IL_00A0: sub
    IL_00A1: conv.u2
    IL_00A2: call T Z0.As::generic<T>(System.UInt16)
    IL_00A7: ret
    IL_00A8: ldtoken T
    IL_00AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B2: ldtoken System.Int32
    IL_00B7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C1: brfalse.s IL_00D1
    IL_00C3: ldarg.0
    IL_00C4: call System.Int32 Z0.As::int32<T>(T)
    IL_00C9: ldc.i4.1
    IL_00CA: sub
    IL_00CB: call T Z0.As::generic<T>(System.Int32)
    IL_00D0: ret
    IL_00D1: ldtoken T
    IL_00D6: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DB: ldtoken System.UInt32
    IL_00E0: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E5: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EA: brfalse.s IL_00FA
    IL_00EC: ldarg.0
    IL_00ED: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00F2: ldc.i4.1
    IL_00F3: sub
    IL_00F4: call T Z0.As::generic<T>(System.UInt32)
    IL_00F9: ret
    IL_00FA: ldtoken T
    IL_00FF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0104: ldtoken System.Int64
    IL_0109: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0113: brfalse.s IL_0124
    IL_0115: ldarg.0
    IL_0116: call System.Int64 Z0.As::int64<T>(T)
    IL_011B: ldc.i4.1
    IL_011C: conv.i8
    IL_011D: sub
    IL_011E: call T Z0.As::generic<T>(System.Int64)
    IL_0123: ret
    IL_0124: ldtoken T
    IL_0129: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012E: ldtoken System.UInt64
    IL_0133: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0138: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_013D: brfalse.s IL_014E
    IL_013F: ldarg.0
    IL_0140: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0145: ldc.i4.1
    IL_0146: conv.i8
    IL_0147: sub
    IL_0148: call T Z0.As::generic<T>(System.UInt64)
    IL_014D: ret
    IL_014E: ldtoken T
    IL_0153: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0158: ldtoken System.Single
    IL_015D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0162: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0167: brfalse.s IL_017B
    IL_0169: ldarg.0
    IL_016A: call System.Single Z0.As::float32<T>(T)
    IL_016F: ldc.r4 1
    IL_0174: sub
    IL_0175: call T Z0.As::generic<T>(System.Single)
    IL_017A: ret
    IL_017B: ldtoken T
    IL_0180: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0185: ldtoken System.Double
    IL_018A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0194: brfalse.s IL_01AC
    IL_0196: ldarg.0
    IL_0197: call System.Double Z0.As::float64<T>(T)
    IL_019C: ldc.r8 1
    IL_01A5: sub
    IL_01A6: call T Z0.As::generic<T>(System.Double)
    IL_01AB: ret
    IL_01AC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B6: ldc.i4.s 41
    IL_01B8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01BD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01C2: throw

}
short dec<short>(short src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002A
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: sub
    IL_0023: conv.i1
    IL_0024: call T Z0.As::generic<T>(System.SByte)
    IL_0029: ret
    IL_002A: ldtoken T
    IL_002F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0034: ldtoken System.Byte
    IL_0039: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0043: brfalse.s IL_0054
    IL_0045: ldarg.0
    IL_0046: call System.Byte Z0.As::uint8<T>(T)
    IL_004B: ldc.i4.1
    IL_004C: sub
    IL_004D: conv.u1
    IL_004E: call T Z0.As::generic<T>(System.Byte)
    IL_0053: ret
    IL_0054: ldtoken T
    IL_0059: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005E: ldtoken System.Int16
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006D: brfalse.s IL_007E
    IL_006F: ldarg.0
    IL_0070: call System.Int16 Z0.As::int16<T>(T)
    IL_0075: ldc.i4.1
    IL_0076: sub
    IL_0077: conv.i2
    IL_0078: call T Z0.As::generic<T>(System.Int16)
    IL_007D: ret
    IL_007E: ldtoken T
    IL_0083: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0088: ldtoken System.UInt16
    IL_008D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0092: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0097: brfalse.s IL_00A8
    IL_0099: ldarg.0
    IL_009A: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009F: ldc.i4.1
    IL_00A0: sub
    IL_00A1: conv.u2
    IL_00A2: call T Z0.As::generic<T>(System.UInt16)
    IL_00A7: ret
    IL_00A8: ldtoken T
    IL_00AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B2: ldtoken System.Int32
    IL_00B7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C1: brfalse.s IL_00D1
    IL_00C3: ldarg.0
    IL_00C4: call System.Int32 Z0.As::int32<T>(T)
    IL_00C9: ldc.i4.1
    IL_00CA: sub
    IL_00CB: call T Z0.As::generic<T>(System.Int32)
    IL_00D0: ret
    IL_00D1: ldtoken T
    IL_00D6: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DB: ldtoken System.UInt32
    IL_00E0: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E5: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EA: brfalse.s IL_00FA
    IL_00EC: ldarg.0
    IL_00ED: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00F2: ldc.i4.1
    IL_00F3: sub
    IL_00F4: call T Z0.As::generic<T>(System.UInt32)
    IL_00F9: ret
    IL_00FA: ldtoken T
    IL_00FF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0104: ldtoken System.Int64
    IL_0109: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0113: brfalse.s IL_0124
    IL_0115: ldarg.0
    IL_0116: call System.Int64 Z0.As::int64<T>(T)
    IL_011B: ldc.i4.1
    IL_011C: conv.i8
    IL_011D: sub
    IL_011E: call T Z0.As::generic<T>(System.Int64)
    IL_0123: ret
    IL_0124: ldtoken T
    IL_0129: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012E: ldtoken System.UInt64
    IL_0133: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0138: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_013D: brfalse.s IL_014E
    IL_013F: ldarg.0
    IL_0140: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0145: ldc.i4.1
    IL_0146: conv.i8
    IL_0147: sub
    IL_0148: call T Z0.As::generic<T>(System.UInt64)
    IL_014D: ret
    IL_014E: ldtoken T
    IL_0153: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0158: ldtoken System.Single
    IL_015D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0162: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0167: brfalse.s IL_017B
    IL_0169: ldarg.0
    IL_016A: call System.Single Z0.As::float32<T>(T)
    IL_016F: ldc.r4 1
    IL_0174: sub
    IL_0175: call T Z0.As::generic<T>(System.Single)
    IL_017A: ret
    IL_017B: ldtoken T
    IL_0180: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0185: ldtoken System.Double
    IL_018A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0194: brfalse.s IL_01AC
    IL_0196: ldarg.0
    IL_0197: call System.Double Z0.As::float64<T>(T)
    IL_019C: ldc.r8 1
    IL_01A5: sub
    IL_01A6: call T Z0.As::generic<T>(System.Double)
    IL_01AB: ret
    IL_01AC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B6: ldc.i4.s 41
    IL_01B8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01BD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01C2: throw

}
int dec<int>(int src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002A
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: sub
    IL_0023: conv.i1
    IL_0024: call T Z0.As::generic<T>(System.SByte)
    IL_0029: ret
    IL_002A: ldtoken T
    IL_002F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0034: ldtoken System.Byte
    IL_0039: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0043: brfalse.s IL_0054
    IL_0045: ldarg.0
    IL_0046: call System.Byte Z0.As::uint8<T>(T)
    IL_004B: ldc.i4.1
    IL_004C: sub
    IL_004D: conv.u1
    IL_004E: call T Z0.As::generic<T>(System.Byte)
    IL_0053: ret
    IL_0054: ldtoken T
    IL_0059: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005E: ldtoken System.Int16
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006D: brfalse.s IL_007E
    IL_006F: ldarg.0
    IL_0070: call System.Int16 Z0.As::int16<T>(T)
    IL_0075: ldc.i4.1
    IL_0076: sub
    IL_0077: conv.i2
    IL_0078: call T Z0.As::generic<T>(System.Int16)
    IL_007D: ret
    IL_007E: ldtoken T
    IL_0083: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0088: ldtoken System.UInt16
    IL_008D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0092: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0097: brfalse.s IL_00A8
    IL_0099: ldarg.0
    IL_009A: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009F: ldc.i4.1
    IL_00A0: sub
    IL_00A1: conv.u2
    IL_00A2: call T Z0.As::generic<T>(System.UInt16)
    IL_00A7: ret
    IL_00A8: ldtoken T
    IL_00AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B2: ldtoken System.Int32
    IL_00B7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C1: brfalse.s IL_00D1
    IL_00C3: ldarg.0
    IL_00C4: call System.Int32 Z0.As::int32<T>(T)
    IL_00C9: ldc.i4.1
    IL_00CA: sub
    IL_00CB: call T Z0.As::generic<T>(System.Int32)
    IL_00D0: ret
    IL_00D1: ldtoken T
    IL_00D6: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DB: ldtoken System.UInt32
    IL_00E0: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E5: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EA: brfalse.s IL_00FA
    IL_00EC: ldarg.0
    IL_00ED: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00F2: ldc.i4.1
    IL_00F3: sub
    IL_00F4: call T Z0.As::generic<T>(System.UInt32)
    IL_00F9: ret
    IL_00FA: ldtoken T
    IL_00FF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0104: ldtoken System.Int64
    IL_0109: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0113: brfalse.s IL_0124
    IL_0115: ldarg.0
    IL_0116: call System.Int64 Z0.As::int64<T>(T)
    IL_011B: ldc.i4.1
    IL_011C: conv.i8
    IL_011D: sub
    IL_011E: call T Z0.As::generic<T>(System.Int64)
    IL_0123: ret
    IL_0124: ldtoken T
    IL_0129: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012E: ldtoken System.UInt64
    IL_0133: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0138: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_013D: brfalse.s IL_014E
    IL_013F: ldarg.0
    IL_0140: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0145: ldc.i4.1
    IL_0146: conv.i8
    IL_0147: sub
    IL_0148: call T Z0.As::generic<T>(System.UInt64)
    IL_014D: ret
    IL_014E: ldtoken T
    IL_0153: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0158: ldtoken System.Single
    IL_015D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0162: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0167: brfalse.s IL_017B
    IL_0169: ldarg.0
    IL_016A: call System.Single Z0.As::float32<T>(T)
    IL_016F: ldc.r4 1
    IL_0174: sub
    IL_0175: call T Z0.As::generic<T>(System.Single)
    IL_017A: ret
    IL_017B: ldtoken T
    IL_0180: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0185: ldtoken System.Double
    IL_018A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0194: brfalse.s IL_01AC
    IL_0196: ldarg.0
    IL_0197: call System.Double Z0.As::float64<T>(T)
    IL_019C: ldc.r8 1
    IL_01A5: sub
    IL_01A6: call T Z0.As::generic<T>(System.Double)
    IL_01AB: ret
    IL_01AC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B6: ldc.i4.s 41
    IL_01B8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01BD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01C2: throw

}
long dec<long>(long src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002A
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: sub
    IL_0023: conv.i1
    IL_0024: call T Z0.As::generic<T>(System.SByte)
    IL_0029: ret
    IL_002A: ldtoken T
    IL_002F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0034: ldtoken System.Byte
    IL_0039: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0043: brfalse.s IL_0054
    IL_0045: ldarg.0
    IL_0046: call System.Byte Z0.As::uint8<T>(T)
    IL_004B: ldc.i4.1
    IL_004C: sub
    IL_004D: conv.u1
    IL_004E: call T Z0.As::generic<T>(System.Byte)
    IL_0053: ret
    IL_0054: ldtoken T
    IL_0059: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005E: ldtoken System.Int16
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006D: brfalse.s IL_007E
    IL_006F: ldarg.0
    IL_0070: call System.Int16 Z0.As::int16<T>(T)
    IL_0075: ldc.i4.1
    IL_0076: sub
    IL_0077: conv.i2
    IL_0078: call T Z0.As::generic<T>(System.Int16)
    IL_007D: ret
    IL_007E: ldtoken T
    IL_0083: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0088: ldtoken System.UInt16
    IL_008D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0092: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0097: brfalse.s IL_00A8
    IL_0099: ldarg.0
    IL_009A: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009F: ldc.i4.1
    IL_00A0: sub
    IL_00A1: conv.u2
    IL_00A2: call T Z0.As::generic<T>(System.UInt16)
    IL_00A7: ret
    IL_00A8: ldtoken T
    IL_00AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B2: ldtoken System.Int32
    IL_00B7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C1: brfalse.s IL_00D1
    IL_00C3: ldarg.0
    IL_00C4: call System.Int32 Z0.As::int32<T>(T)
    IL_00C9: ldc.i4.1
    IL_00CA: sub
    IL_00CB: call T Z0.As::generic<T>(System.Int32)
    IL_00D0: ret
    IL_00D1: ldtoken T
    IL_00D6: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DB: ldtoken System.UInt32
    IL_00E0: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E5: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EA: brfalse.s IL_00FA
    IL_00EC: ldarg.0
    IL_00ED: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00F2: ldc.i4.1
    IL_00F3: sub
    IL_00F4: call T Z0.As::generic<T>(System.UInt32)
    IL_00F9: ret
    IL_00FA: ldtoken T
    IL_00FF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0104: ldtoken System.Int64
    IL_0109: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0113: brfalse.s IL_0124
    IL_0115: ldarg.0
    IL_0116: call System.Int64 Z0.As::int64<T>(T)
    IL_011B: ldc.i4.1
    IL_011C: conv.i8
    IL_011D: sub
    IL_011E: call T Z0.As::generic<T>(System.Int64)
    IL_0123: ret
    IL_0124: ldtoken T
    IL_0129: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012E: ldtoken System.UInt64
    IL_0133: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0138: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_013D: brfalse.s IL_014E
    IL_013F: ldarg.0
    IL_0140: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0145: ldc.i4.1
    IL_0146: conv.i8
    IL_0147: sub
    IL_0148: call T Z0.As::generic<T>(System.UInt64)
    IL_014D: ret
    IL_014E: ldtoken T
    IL_0153: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0158: ldtoken System.Single
    IL_015D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0162: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0167: brfalse.s IL_017B
    IL_0169: ldarg.0
    IL_016A: call System.Single Z0.As::float32<T>(T)
    IL_016F: ldc.r4 1
    IL_0174: sub
    IL_0175: call T Z0.As::generic<T>(System.Single)
    IL_017A: ret
    IL_017B: ldtoken T
    IL_0180: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0185: ldtoken System.Double
    IL_018A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0194: brfalse.s IL_01AC
    IL_0196: ldarg.0
    IL_0197: call System.Double Z0.As::float64<T>(T)
    IL_019C: ldc.r8 1
    IL_01A5: sub
    IL_01A6: call T Z0.As::generic<T>(System.Double)
    IL_01AB: ret
    IL_01AC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B6: ldc.i4.s 41
    IL_01B8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01BD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01C2: throw

}
float dec<float>(float src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002A
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: sub
    IL_0023: conv.i1
    IL_0024: call T Z0.As::generic<T>(System.SByte)
    IL_0029: ret
    IL_002A: ldtoken T
    IL_002F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0034: ldtoken System.Byte
    IL_0039: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0043: brfalse.s IL_0054
    IL_0045: ldarg.0
    IL_0046: call System.Byte Z0.As::uint8<T>(T)
    IL_004B: ldc.i4.1
    IL_004C: sub
    IL_004D: conv.u1
    IL_004E: call T Z0.As::generic<T>(System.Byte)
    IL_0053: ret
    IL_0054: ldtoken T
    IL_0059: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005E: ldtoken System.Int16
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006D: brfalse.s IL_007E
    IL_006F: ldarg.0
    IL_0070: call System.Int16 Z0.As::int16<T>(T)
    IL_0075: ldc.i4.1
    IL_0076: sub
    IL_0077: conv.i2
    IL_0078: call T Z0.As::generic<T>(System.Int16)
    IL_007D: ret
    IL_007E: ldtoken T
    IL_0083: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0088: ldtoken System.UInt16
    IL_008D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0092: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0097: brfalse.s IL_00A8
    IL_0099: ldarg.0
    IL_009A: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009F: ldc.i4.1
    IL_00A0: sub
    IL_00A1: conv.u2
    IL_00A2: call T Z0.As::generic<T>(System.UInt16)
    IL_00A7: ret
    IL_00A8: ldtoken T
    IL_00AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B2: ldtoken System.Int32
    IL_00B7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C1: brfalse.s IL_00D1
    IL_00C3: ldarg.0
    IL_00C4: call System.Int32 Z0.As::int32<T>(T)
    IL_00C9: ldc.i4.1
    IL_00CA: sub
    IL_00CB: call T Z0.As::generic<T>(System.Int32)
    IL_00D0: ret
    IL_00D1: ldtoken T
    IL_00D6: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DB: ldtoken System.UInt32
    IL_00E0: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E5: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EA: brfalse.s IL_00FA
    IL_00EC: ldarg.0
    IL_00ED: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00F2: ldc.i4.1
    IL_00F3: sub
    IL_00F4: call T Z0.As::generic<T>(System.UInt32)
    IL_00F9: ret
    IL_00FA: ldtoken T
    IL_00FF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0104: ldtoken System.Int64
    IL_0109: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0113: brfalse.s IL_0124
    IL_0115: ldarg.0
    IL_0116: call System.Int64 Z0.As::int64<T>(T)
    IL_011B: ldc.i4.1
    IL_011C: conv.i8
    IL_011D: sub
    IL_011E: call T Z0.As::generic<T>(System.Int64)
    IL_0123: ret
    IL_0124: ldtoken T
    IL_0129: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012E: ldtoken System.UInt64
    IL_0133: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0138: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_013D: brfalse.s IL_014E
    IL_013F: ldarg.0
    IL_0140: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0145: ldc.i4.1
    IL_0146: conv.i8
    IL_0147: sub
    IL_0148: call T Z0.As::generic<T>(System.UInt64)
    IL_014D: ret
    IL_014E: ldtoken T
    IL_0153: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0158: ldtoken System.Single
    IL_015D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0162: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0167: brfalse.s IL_017B
    IL_0169: ldarg.0
    IL_016A: call System.Single Z0.As::float32<T>(T)
    IL_016F: ldc.r4 1
    IL_0174: sub
    IL_0175: call T Z0.As::generic<T>(System.Single)
    IL_017A: ret
    IL_017B: ldtoken T
    IL_0180: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0185: ldtoken System.Double
    IL_018A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0194: brfalse.s IL_01AC
    IL_0196: ldarg.0
    IL_0197: call System.Double Z0.As::float64<T>(T)
    IL_019C: ldc.r8 1
    IL_01A5: sub
    IL_01A6: call T Z0.As::generic<T>(System.Double)
    IL_01AB: ret
    IL_01AC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B6: ldc.i4.s 41
    IL_01B8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01BD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01C2: throw

}
double dec<double>(double src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_002A
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: sub
    IL_0023: conv.i1
    IL_0024: call T Z0.As::generic<T>(System.SByte)
    IL_0029: ret
    IL_002A: ldtoken T
    IL_002F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0034: ldtoken System.Byte
    IL_0039: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0043: brfalse.s IL_0054
    IL_0045: ldarg.0
    IL_0046: call System.Byte Z0.As::uint8<T>(T)
    IL_004B: ldc.i4.1
    IL_004C: sub
    IL_004D: conv.u1
    IL_004E: call T Z0.As::generic<T>(System.Byte)
    IL_0053: ret
    IL_0054: ldtoken T
    IL_0059: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005E: ldtoken System.Int16
    IL_0063: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0068: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006D: brfalse.s IL_007E
    IL_006F: ldarg.0
    IL_0070: call System.Int16 Z0.As::int16<T>(T)
    IL_0075: ldc.i4.1
    IL_0076: sub
    IL_0077: conv.i2
    IL_0078: call T Z0.As::generic<T>(System.Int16)
    IL_007D: ret
    IL_007E: ldtoken T
    IL_0083: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0088: ldtoken System.UInt16
    IL_008D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0092: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0097: brfalse.s IL_00A8
    IL_0099: ldarg.0
    IL_009A: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009F: ldc.i4.1
    IL_00A0: sub
    IL_00A1: conv.u2
    IL_00A2: call T Z0.As::generic<T>(System.UInt16)
    IL_00A7: ret
    IL_00A8: ldtoken T
    IL_00AD: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B2: ldtoken System.Int32
    IL_00B7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00BC: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C1: brfalse.s IL_00D1
    IL_00C3: ldarg.0
    IL_00C4: call System.Int32 Z0.As::int32<T>(T)
    IL_00C9: ldc.i4.1
    IL_00CA: sub
    IL_00CB: call T Z0.As::generic<T>(System.Int32)
    IL_00D0: ret
    IL_00D1: ldtoken T
    IL_00D6: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DB: ldtoken System.UInt32
    IL_00E0: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E5: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EA: brfalse.s IL_00FA
    IL_00EC: ldarg.0
    IL_00ED: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00F2: ldc.i4.1
    IL_00F3: sub
    IL_00F4: call T Z0.As::generic<T>(System.UInt32)
    IL_00F9: ret
    IL_00FA: ldtoken T
    IL_00FF: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0104: ldtoken System.Int64
    IL_0109: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0113: brfalse.s IL_0124
    IL_0115: ldarg.0
    IL_0116: call System.Int64 Z0.As::int64<T>(T)
    IL_011B: ldc.i4.1
    IL_011C: conv.i8
    IL_011D: sub
    IL_011E: call T Z0.As::generic<T>(System.Int64)
    IL_0123: ret
    IL_0124: ldtoken T
    IL_0129: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012E: ldtoken System.UInt64
    IL_0133: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0138: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_013D: brfalse.s IL_014E
    IL_013F: ldarg.0
    IL_0140: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0145: ldc.i4.1
    IL_0146: conv.i8
    IL_0147: sub
    IL_0148: call T Z0.As::generic<T>(System.UInt64)
    IL_014D: ret
    IL_014E: ldtoken T
    IL_0153: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0158: ldtoken System.Single
    IL_015D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0162: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0167: brfalse.s IL_017B
    IL_0169: ldarg.0
    IL_016A: call System.Single Z0.As::float32<T>(T)
    IL_016F: ldc.r4 1
    IL_0174: sub
    IL_0175: call T Z0.As::generic<T>(System.Single)
    IL_017A: ret
    IL_017B: ldtoken T
    IL_0180: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0185: ldtoken System.Double
    IL_018A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0194: brfalse.s IL_01AC
    IL_0196: ldarg.0
    IL_0197: call System.Double Z0.As::float64<T>(T)
    IL_019C: ldc.r8 1
    IL_01A5: sub
    IL_01A6: call T Z0.As::generic<T>(System.Double)
    IL_01AB: ret
    IL_01AC: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B1: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Dec.cs"
    IL_01B6: ldc.i4.s 41
    IL_01B8: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01BD: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01C2: throw

}
byte inc<byte>(byte src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0029
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: add
    IL_0023: call T Z0.As::generic<T>(System.Int32)
    IL_0028: ret
    IL_0029: ldtoken T
    IL_002E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0033: ldtoken System.Byte
    IL_0038: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0042: brfalse.s IL_0052
    IL_0044: ldarg.0
    IL_0045: call System.Byte Z0.As::uint8<T>(T)
    IL_004A: ldc.i4.1
    IL_004B: add
    IL_004C: call T Z0.As::generic<T>(System.Int32)
    IL_0051: ret
    IL_0052: ldtoken T
    IL_0057: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005C: ldtoken System.Int16
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006B: brfalse.s IL_007B
    IL_006D: ldarg.0
    IL_006E: call System.Int16 Z0.As::int16<T>(T)
    IL_0073: ldc.i4.1
    IL_0074: add
    IL_0075: call T Z0.As::generic<T>(System.Int32)
    IL_007A: ret
    IL_007B: ldtoken T
    IL_0080: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0085: ldtoken System.UInt16
    IL_008A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0094: brfalse.s IL_00A4
    IL_0096: ldarg.0
    IL_0097: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009C: ldc.i4.1
    IL_009D: add
    IL_009E: call T Z0.As::generic<T>(System.Int32)
    IL_00A3: ret
    IL_00A4: ldtoken T
    IL_00A9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00AE: ldtoken System.Int32
    IL_00B3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B8: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00BD: brfalse.s IL_00CD
    IL_00BF: ldarg.0
    IL_00C0: call System.Int32 Z0.As::int32<T>(T)
    IL_00C5: ldc.i4.1
    IL_00C6: add
    IL_00C7: call T Z0.As::generic<T>(System.Int32)
    IL_00CC: ret
    IL_00CD: ldtoken T
    IL_00D2: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D7: ldtoken System.UInt32
    IL_00DC: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00E6: brfalse.s IL_00F6
    IL_00E8: ldarg.0
    IL_00E9: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00EE: ldc.i4.1
    IL_00EF: add
    IL_00F0: call T Z0.As::generic<T>(System.UInt32)
    IL_00F5: ret
    IL_00F6: ldtoken T
    IL_00FB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0100: ldtoken System.Int64
    IL_0105: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010F: brfalse.s IL_0120
    IL_0111: ldarg.0
    IL_0112: call System.Int64 Z0.As::int64<T>(T)
    IL_0117: ldc.i4.1
    IL_0118: conv.i8
    IL_0119: add
    IL_011A: call T Z0.As::generic<T>(System.Int64)
    IL_011F: ret
    IL_0120: ldtoken T
    IL_0125: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012A: ldtoken System.UInt64
    IL_012F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0134: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0139: brfalse.s IL_014A
    IL_013B: ldarg.0
    IL_013C: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0141: ldc.i4.1
    IL_0142: conv.i8
    IL_0143: add
    IL_0144: call T Z0.As::generic<T>(System.UInt64)
    IL_0149: ret
    IL_014A: ldtoken T
    IL_014F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0154: ldtoken System.Single
    IL_0159: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0163: brfalse.s IL_0177
    IL_0165: ldarg.0
    IL_0166: call System.Single Z0.As::float32<T>(T)
    IL_016B: ldc.r4 1
    IL_0170: add
    IL_0171: call T Z0.As::generic<T>(System.Single)
    IL_0176: ret
    IL_0177: ldtoken T
    IL_017C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0181: ldtoken System.Double
    IL_0186: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018B: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0190: brfalse.s IL_01A8
    IL_0192: ldarg.0
    IL_0193: call System.Double Z0.As::float64<T>(T)
    IL_0198: ldc.r8 1
    IL_01A1: add
    IL_01A2: call T Z0.As::generic<T>(System.Double)
    IL_01A7: ret
    IL_01A8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01AD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01B2: ldc.i4.s 43
    IL_01B4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01B9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01BE: throw

}
ushort inc<ushort>(ushort src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0029
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: add
    IL_0023: call T Z0.As::generic<T>(System.Int32)
    IL_0028: ret
    IL_0029: ldtoken T
    IL_002E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0033: ldtoken System.Byte
    IL_0038: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0042: brfalse.s IL_0052
    IL_0044: ldarg.0
    IL_0045: call System.Byte Z0.As::uint8<T>(T)
    IL_004A: ldc.i4.1
    IL_004B: add
    IL_004C: call T Z0.As::generic<T>(System.Int32)
    IL_0051: ret
    IL_0052: ldtoken T
    IL_0057: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005C: ldtoken System.Int16
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006B: brfalse.s IL_007B
    IL_006D: ldarg.0
    IL_006E: call System.Int16 Z0.As::int16<T>(T)
    IL_0073: ldc.i4.1
    IL_0074: add
    IL_0075: call T Z0.As::generic<T>(System.Int32)
    IL_007A: ret
    IL_007B: ldtoken T
    IL_0080: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0085: ldtoken System.UInt16
    IL_008A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0094: brfalse.s IL_00A4
    IL_0096: ldarg.0
    IL_0097: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009C: ldc.i4.1
    IL_009D: add
    IL_009E: call T Z0.As::generic<T>(System.Int32)
    IL_00A3: ret
    IL_00A4: ldtoken T
    IL_00A9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00AE: ldtoken System.Int32
    IL_00B3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B8: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00BD: brfalse.s IL_00CD
    IL_00BF: ldarg.0
    IL_00C0: call System.Int32 Z0.As::int32<T>(T)
    IL_00C5: ldc.i4.1
    IL_00C6: add
    IL_00C7: call T Z0.As::generic<T>(System.Int32)
    IL_00CC: ret
    IL_00CD: ldtoken T
    IL_00D2: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D7: ldtoken System.UInt32
    IL_00DC: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00E6: brfalse.s IL_00F6
    IL_00E8: ldarg.0
    IL_00E9: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00EE: ldc.i4.1
    IL_00EF: add
    IL_00F0: call T Z0.As::generic<T>(System.UInt32)
    IL_00F5: ret
    IL_00F6: ldtoken T
    IL_00FB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0100: ldtoken System.Int64
    IL_0105: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010F: brfalse.s IL_0120
    IL_0111: ldarg.0
    IL_0112: call System.Int64 Z0.As::int64<T>(T)
    IL_0117: ldc.i4.1
    IL_0118: conv.i8
    IL_0119: add
    IL_011A: call T Z0.As::generic<T>(System.Int64)
    IL_011F: ret
    IL_0120: ldtoken T
    IL_0125: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012A: ldtoken System.UInt64
    IL_012F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0134: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0139: brfalse.s IL_014A
    IL_013B: ldarg.0
    IL_013C: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0141: ldc.i4.1
    IL_0142: conv.i8
    IL_0143: add
    IL_0144: call T Z0.As::generic<T>(System.UInt64)
    IL_0149: ret
    IL_014A: ldtoken T
    IL_014F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0154: ldtoken System.Single
    IL_0159: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0163: brfalse.s IL_0177
    IL_0165: ldarg.0
    IL_0166: call System.Single Z0.As::float32<T>(T)
    IL_016B: ldc.r4 1
    IL_0170: add
    IL_0171: call T Z0.As::generic<T>(System.Single)
    IL_0176: ret
    IL_0177: ldtoken T
    IL_017C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0181: ldtoken System.Double
    IL_0186: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018B: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0190: brfalse.s IL_01A8
    IL_0192: ldarg.0
    IL_0193: call System.Double Z0.As::float64<T>(T)
    IL_0198: ldc.r8 1
    IL_01A1: add
    IL_01A2: call T Z0.As::generic<T>(System.Double)
    IL_01A7: ret
    IL_01A8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01AD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01B2: ldc.i4.s 43
    IL_01B4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01B9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01BE: throw

}
uint inc<uint>(uint src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0029
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: add
    IL_0023: call T Z0.As::generic<T>(System.Int32)
    IL_0028: ret
    IL_0029: ldtoken T
    IL_002E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0033: ldtoken System.Byte
    IL_0038: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0042: brfalse.s IL_0052
    IL_0044: ldarg.0
    IL_0045: call System.Byte Z0.As::uint8<T>(T)
    IL_004A: ldc.i4.1
    IL_004B: add
    IL_004C: call T Z0.As::generic<T>(System.Int32)
    IL_0051: ret
    IL_0052: ldtoken T
    IL_0057: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005C: ldtoken System.Int16
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006B: brfalse.s IL_007B
    IL_006D: ldarg.0
    IL_006E: call System.Int16 Z0.As::int16<T>(T)
    IL_0073: ldc.i4.1
    IL_0074: add
    IL_0075: call T Z0.As::generic<T>(System.Int32)
    IL_007A: ret
    IL_007B: ldtoken T
    IL_0080: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0085: ldtoken System.UInt16
    IL_008A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0094: brfalse.s IL_00A4
    IL_0096: ldarg.0
    IL_0097: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009C: ldc.i4.1
    IL_009D: add
    IL_009E: call T Z0.As::generic<T>(System.Int32)
    IL_00A3: ret
    IL_00A4: ldtoken T
    IL_00A9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00AE: ldtoken System.Int32
    IL_00B3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B8: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00BD: brfalse.s IL_00CD
    IL_00BF: ldarg.0
    IL_00C0: call System.Int32 Z0.As::int32<T>(T)
    IL_00C5: ldc.i4.1
    IL_00C6: add
    IL_00C7: call T Z0.As::generic<T>(System.Int32)
    IL_00CC: ret
    IL_00CD: ldtoken T
    IL_00D2: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D7: ldtoken System.UInt32
    IL_00DC: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00E6: brfalse.s IL_00F6
    IL_00E8: ldarg.0
    IL_00E9: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00EE: ldc.i4.1
    IL_00EF: add
    IL_00F0: call T Z0.As::generic<T>(System.UInt32)
    IL_00F5: ret
    IL_00F6: ldtoken T
    IL_00FB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0100: ldtoken System.Int64
    IL_0105: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010F: brfalse.s IL_0120
    IL_0111: ldarg.0
    IL_0112: call System.Int64 Z0.As::int64<T>(T)
    IL_0117: ldc.i4.1
    IL_0118: conv.i8
    IL_0119: add
    IL_011A: call T Z0.As::generic<T>(System.Int64)
    IL_011F: ret
    IL_0120: ldtoken T
    IL_0125: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012A: ldtoken System.UInt64
    IL_012F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0134: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0139: brfalse.s IL_014A
    IL_013B: ldarg.0
    IL_013C: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0141: ldc.i4.1
    IL_0142: conv.i8
    IL_0143: add
    IL_0144: call T Z0.As::generic<T>(System.UInt64)
    IL_0149: ret
    IL_014A: ldtoken T
    IL_014F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0154: ldtoken System.Single
    IL_0159: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0163: brfalse.s IL_0177
    IL_0165: ldarg.0
    IL_0166: call System.Single Z0.As::float32<T>(T)
    IL_016B: ldc.r4 1
    IL_0170: add
    IL_0171: call T Z0.As::generic<T>(System.Single)
    IL_0176: ret
    IL_0177: ldtoken T
    IL_017C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0181: ldtoken System.Double
    IL_0186: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018B: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0190: brfalse.s IL_01A8
    IL_0192: ldarg.0
    IL_0193: call System.Double Z0.As::float64<T>(T)
    IL_0198: ldc.r8 1
    IL_01A1: add
    IL_01A2: call T Z0.As::generic<T>(System.Double)
    IL_01A7: ret
    IL_01A8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01AD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01B2: ldc.i4.s 43
    IL_01B4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01B9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01BE: throw

}
ulong inc<ulong>(ulong src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0029
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: add
    IL_0023: call T Z0.As::generic<T>(System.Int32)
    IL_0028: ret
    IL_0029: ldtoken T
    IL_002E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0033: ldtoken System.Byte
    IL_0038: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0042: brfalse.s IL_0052
    IL_0044: ldarg.0
    IL_0045: call System.Byte Z0.As::uint8<T>(T)
    IL_004A: ldc.i4.1
    IL_004B: add
    IL_004C: call T Z0.As::generic<T>(System.Int32)
    IL_0051: ret
    IL_0052: ldtoken T
    IL_0057: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005C: ldtoken System.Int16
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006B: brfalse.s IL_007B
    IL_006D: ldarg.0
    IL_006E: call System.Int16 Z0.As::int16<T>(T)
    IL_0073: ldc.i4.1
    IL_0074: add
    IL_0075: call T Z0.As::generic<T>(System.Int32)
    IL_007A: ret
    IL_007B: ldtoken T
    IL_0080: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0085: ldtoken System.UInt16
    IL_008A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0094: brfalse.s IL_00A4
    IL_0096: ldarg.0
    IL_0097: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009C: ldc.i4.1
    IL_009D: add
    IL_009E: call T Z0.As::generic<T>(System.Int32)
    IL_00A3: ret
    IL_00A4: ldtoken T
    IL_00A9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00AE: ldtoken System.Int32
    IL_00B3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B8: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00BD: brfalse.s IL_00CD
    IL_00BF: ldarg.0
    IL_00C0: call System.Int32 Z0.As::int32<T>(T)
    IL_00C5: ldc.i4.1
    IL_00C6: add
    IL_00C7: call T Z0.As::generic<T>(System.Int32)
    IL_00CC: ret
    IL_00CD: ldtoken T
    IL_00D2: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D7: ldtoken System.UInt32
    IL_00DC: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00E6: brfalse.s IL_00F6
    IL_00E8: ldarg.0
    IL_00E9: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00EE: ldc.i4.1
    IL_00EF: add
    IL_00F0: call T Z0.As::generic<T>(System.UInt32)
    IL_00F5: ret
    IL_00F6: ldtoken T
    IL_00FB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0100: ldtoken System.Int64
    IL_0105: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010F: brfalse.s IL_0120
    IL_0111: ldarg.0
    IL_0112: call System.Int64 Z0.As::int64<T>(T)
    IL_0117: ldc.i4.1
    IL_0118: conv.i8
    IL_0119: add
    IL_011A: call T Z0.As::generic<T>(System.Int64)
    IL_011F: ret
    IL_0120: ldtoken T
    IL_0125: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012A: ldtoken System.UInt64
    IL_012F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0134: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0139: brfalse.s IL_014A
    IL_013B: ldarg.0
    IL_013C: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0141: ldc.i4.1
    IL_0142: conv.i8
    IL_0143: add
    IL_0144: call T Z0.As::generic<T>(System.UInt64)
    IL_0149: ret
    IL_014A: ldtoken T
    IL_014F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0154: ldtoken System.Single
    IL_0159: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0163: brfalse.s IL_0177
    IL_0165: ldarg.0
    IL_0166: call System.Single Z0.As::float32<T>(T)
    IL_016B: ldc.r4 1
    IL_0170: add
    IL_0171: call T Z0.As::generic<T>(System.Single)
    IL_0176: ret
    IL_0177: ldtoken T
    IL_017C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0181: ldtoken System.Double
    IL_0186: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018B: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0190: brfalse.s IL_01A8
    IL_0192: ldarg.0
    IL_0193: call System.Double Z0.As::float64<T>(T)
    IL_0198: ldc.r8 1
    IL_01A1: add
    IL_01A2: call T Z0.As::generic<T>(System.Double)
    IL_01A7: ret
    IL_01A8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01AD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01B2: ldc.i4.s 43
    IL_01B4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01B9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01BE: throw

}
sbyte inc<sbyte>(sbyte src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0029
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: add
    IL_0023: call T Z0.As::generic<T>(System.Int32)
    IL_0028: ret
    IL_0029: ldtoken T
    IL_002E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0033: ldtoken System.Byte
    IL_0038: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0042: brfalse.s IL_0052
    IL_0044: ldarg.0
    IL_0045: call System.Byte Z0.As::uint8<T>(T)
    IL_004A: ldc.i4.1
    IL_004B: add
    IL_004C: call T Z0.As::generic<T>(System.Int32)
    IL_0051: ret
    IL_0052: ldtoken T
    IL_0057: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005C: ldtoken System.Int16
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006B: brfalse.s IL_007B
    IL_006D: ldarg.0
    IL_006E: call System.Int16 Z0.As::int16<T>(T)
    IL_0073: ldc.i4.1
    IL_0074: add
    IL_0075: call T Z0.As::generic<T>(System.Int32)
    IL_007A: ret
    IL_007B: ldtoken T
    IL_0080: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0085: ldtoken System.UInt16
    IL_008A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0094: brfalse.s IL_00A4
    IL_0096: ldarg.0
    IL_0097: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009C: ldc.i4.1
    IL_009D: add
    IL_009E: call T Z0.As::generic<T>(System.Int32)
    IL_00A3: ret
    IL_00A4: ldtoken T
    IL_00A9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00AE: ldtoken System.Int32
    IL_00B3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B8: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00BD: brfalse.s IL_00CD
    IL_00BF: ldarg.0
    IL_00C0: call System.Int32 Z0.As::int32<T>(T)
    IL_00C5: ldc.i4.1
    IL_00C6: add
    IL_00C7: call T Z0.As::generic<T>(System.Int32)
    IL_00CC: ret
    IL_00CD: ldtoken T
    IL_00D2: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D7: ldtoken System.UInt32
    IL_00DC: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00E6: brfalse.s IL_00F6
    IL_00E8: ldarg.0
    IL_00E9: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00EE: ldc.i4.1
    IL_00EF: add
    IL_00F0: call T Z0.As::generic<T>(System.UInt32)
    IL_00F5: ret
    IL_00F6: ldtoken T
    IL_00FB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0100: ldtoken System.Int64
    IL_0105: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010F: brfalse.s IL_0120
    IL_0111: ldarg.0
    IL_0112: call System.Int64 Z0.As::int64<T>(T)
    IL_0117: ldc.i4.1
    IL_0118: conv.i8
    IL_0119: add
    IL_011A: call T Z0.As::generic<T>(System.Int64)
    IL_011F: ret
    IL_0120: ldtoken T
    IL_0125: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012A: ldtoken System.UInt64
    IL_012F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0134: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0139: brfalse.s IL_014A
    IL_013B: ldarg.0
    IL_013C: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0141: ldc.i4.1
    IL_0142: conv.i8
    IL_0143: add
    IL_0144: call T Z0.As::generic<T>(System.UInt64)
    IL_0149: ret
    IL_014A: ldtoken T
    IL_014F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0154: ldtoken System.Single
    IL_0159: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0163: brfalse.s IL_0177
    IL_0165: ldarg.0
    IL_0166: call System.Single Z0.As::float32<T>(T)
    IL_016B: ldc.r4 1
    IL_0170: add
    IL_0171: call T Z0.As::generic<T>(System.Single)
    IL_0176: ret
    IL_0177: ldtoken T
    IL_017C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0181: ldtoken System.Double
    IL_0186: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018B: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0190: brfalse.s IL_01A8
    IL_0192: ldarg.0
    IL_0193: call System.Double Z0.As::float64<T>(T)
    IL_0198: ldc.r8 1
    IL_01A1: add
    IL_01A2: call T Z0.As::generic<T>(System.Double)
    IL_01A7: ret
    IL_01A8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01AD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01B2: ldc.i4.s 43
    IL_01B4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01B9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01BE: throw

}
short inc<short>(short src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0029
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: add
    IL_0023: call T Z0.As::generic<T>(System.Int32)
    IL_0028: ret
    IL_0029: ldtoken T
    IL_002E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0033: ldtoken System.Byte
    IL_0038: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0042: brfalse.s IL_0052
    IL_0044: ldarg.0
    IL_0045: call System.Byte Z0.As::uint8<T>(T)
    IL_004A: ldc.i4.1
    IL_004B: add
    IL_004C: call T Z0.As::generic<T>(System.Int32)
    IL_0051: ret
    IL_0052: ldtoken T
    IL_0057: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005C: ldtoken System.Int16
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006B: brfalse.s IL_007B
    IL_006D: ldarg.0
    IL_006E: call System.Int16 Z0.As::int16<T>(T)
    IL_0073: ldc.i4.1
    IL_0074: add
    IL_0075: call T Z0.As::generic<T>(System.Int32)
    IL_007A: ret
    IL_007B: ldtoken T
    IL_0080: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0085: ldtoken System.UInt16
    IL_008A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0094: brfalse.s IL_00A4
    IL_0096: ldarg.0
    IL_0097: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009C: ldc.i4.1
    IL_009D: add
    IL_009E: call T Z0.As::generic<T>(System.Int32)
    IL_00A3: ret
    IL_00A4: ldtoken T
    IL_00A9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00AE: ldtoken System.Int32
    IL_00B3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B8: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00BD: brfalse.s IL_00CD
    IL_00BF: ldarg.0
    IL_00C0: call System.Int32 Z0.As::int32<T>(T)
    IL_00C5: ldc.i4.1
    IL_00C6: add
    IL_00C7: call T Z0.As::generic<T>(System.Int32)
    IL_00CC: ret
    IL_00CD: ldtoken T
    IL_00D2: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D7: ldtoken System.UInt32
    IL_00DC: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00E6: brfalse.s IL_00F6
    IL_00E8: ldarg.0
    IL_00E9: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00EE: ldc.i4.1
    IL_00EF: add
    IL_00F0: call T Z0.As::generic<T>(System.UInt32)
    IL_00F5: ret
    IL_00F6: ldtoken T
    IL_00FB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0100: ldtoken System.Int64
    IL_0105: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010F: brfalse.s IL_0120
    IL_0111: ldarg.0
    IL_0112: call System.Int64 Z0.As::int64<T>(T)
    IL_0117: ldc.i4.1
    IL_0118: conv.i8
    IL_0119: add
    IL_011A: call T Z0.As::generic<T>(System.Int64)
    IL_011F: ret
    IL_0120: ldtoken T
    IL_0125: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012A: ldtoken System.UInt64
    IL_012F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0134: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0139: brfalse.s IL_014A
    IL_013B: ldarg.0
    IL_013C: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0141: ldc.i4.1
    IL_0142: conv.i8
    IL_0143: add
    IL_0144: call T Z0.As::generic<T>(System.UInt64)
    IL_0149: ret
    IL_014A: ldtoken T
    IL_014F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0154: ldtoken System.Single
    IL_0159: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0163: brfalse.s IL_0177
    IL_0165: ldarg.0
    IL_0166: call System.Single Z0.As::float32<T>(T)
    IL_016B: ldc.r4 1
    IL_0170: add
    IL_0171: call T Z0.As::generic<T>(System.Single)
    IL_0176: ret
    IL_0177: ldtoken T
    IL_017C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0181: ldtoken System.Double
    IL_0186: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018B: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0190: brfalse.s IL_01A8
    IL_0192: ldarg.0
    IL_0193: call System.Double Z0.As::float64<T>(T)
    IL_0198: ldc.r8 1
    IL_01A1: add
    IL_01A2: call T Z0.As::generic<T>(System.Double)
    IL_01A7: ret
    IL_01A8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01AD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01B2: ldc.i4.s 43
    IL_01B4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01B9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01BE: throw

}
int inc<int>(int src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0029
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: add
    IL_0023: call T Z0.As::generic<T>(System.Int32)
    IL_0028: ret
    IL_0029: ldtoken T
    IL_002E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0033: ldtoken System.Byte
    IL_0038: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0042: brfalse.s IL_0052
    IL_0044: ldarg.0
    IL_0045: call System.Byte Z0.As::uint8<T>(T)
    IL_004A: ldc.i4.1
    IL_004B: add
    IL_004C: call T Z0.As::generic<T>(System.Int32)
    IL_0051: ret
    IL_0052: ldtoken T
    IL_0057: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005C: ldtoken System.Int16
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006B: brfalse.s IL_007B
    IL_006D: ldarg.0
    IL_006E: call System.Int16 Z0.As::int16<T>(T)
    IL_0073: ldc.i4.1
    IL_0074: add
    IL_0075: call T Z0.As::generic<T>(System.Int32)
    IL_007A: ret
    IL_007B: ldtoken T
    IL_0080: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0085: ldtoken System.UInt16
    IL_008A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0094: brfalse.s IL_00A4
    IL_0096: ldarg.0
    IL_0097: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009C: ldc.i4.1
    IL_009D: add
    IL_009E: call T Z0.As::generic<T>(System.Int32)
    IL_00A3: ret
    IL_00A4: ldtoken T
    IL_00A9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00AE: ldtoken System.Int32
    IL_00B3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B8: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00BD: brfalse.s IL_00CD
    IL_00BF: ldarg.0
    IL_00C0: call System.Int32 Z0.As::int32<T>(T)
    IL_00C5: ldc.i4.1
    IL_00C6: add
    IL_00C7: call T Z0.As::generic<T>(System.Int32)
    IL_00CC: ret
    IL_00CD: ldtoken T
    IL_00D2: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D7: ldtoken System.UInt32
    IL_00DC: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00E6: brfalse.s IL_00F6
    IL_00E8: ldarg.0
    IL_00E9: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00EE: ldc.i4.1
    IL_00EF: add
    IL_00F0: call T Z0.As::generic<T>(System.UInt32)
    IL_00F5: ret
    IL_00F6: ldtoken T
    IL_00FB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0100: ldtoken System.Int64
    IL_0105: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010F: brfalse.s IL_0120
    IL_0111: ldarg.0
    IL_0112: call System.Int64 Z0.As::int64<T>(T)
    IL_0117: ldc.i4.1
    IL_0118: conv.i8
    IL_0119: add
    IL_011A: call T Z0.As::generic<T>(System.Int64)
    IL_011F: ret
    IL_0120: ldtoken T
    IL_0125: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012A: ldtoken System.UInt64
    IL_012F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0134: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0139: brfalse.s IL_014A
    IL_013B: ldarg.0
    IL_013C: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0141: ldc.i4.1
    IL_0142: conv.i8
    IL_0143: add
    IL_0144: call T Z0.As::generic<T>(System.UInt64)
    IL_0149: ret
    IL_014A: ldtoken T
    IL_014F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0154: ldtoken System.Single
    IL_0159: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0163: brfalse.s IL_0177
    IL_0165: ldarg.0
    IL_0166: call System.Single Z0.As::float32<T>(T)
    IL_016B: ldc.r4 1
    IL_0170: add
    IL_0171: call T Z0.As::generic<T>(System.Single)
    IL_0176: ret
    IL_0177: ldtoken T
    IL_017C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0181: ldtoken System.Double
    IL_0186: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018B: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0190: brfalse.s IL_01A8
    IL_0192: ldarg.0
    IL_0193: call System.Double Z0.As::float64<T>(T)
    IL_0198: ldc.r8 1
    IL_01A1: add
    IL_01A2: call T Z0.As::generic<T>(System.Double)
    IL_01A7: ret
    IL_01A8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01AD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01B2: ldc.i4.s 43
    IL_01B4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01B9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01BE: throw

}
long inc<long>(long src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0029
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: add
    IL_0023: call T Z0.As::generic<T>(System.Int32)
    IL_0028: ret
    IL_0029: ldtoken T
    IL_002E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0033: ldtoken System.Byte
    IL_0038: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0042: brfalse.s IL_0052
    IL_0044: ldarg.0
    IL_0045: call System.Byte Z0.As::uint8<T>(T)
    IL_004A: ldc.i4.1
    IL_004B: add
    IL_004C: call T Z0.As::generic<T>(System.Int32)
    IL_0051: ret
    IL_0052: ldtoken T
    IL_0057: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005C: ldtoken System.Int16
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006B: brfalse.s IL_007B
    IL_006D: ldarg.0
    IL_006E: call System.Int16 Z0.As::int16<T>(T)
    IL_0073: ldc.i4.1
    IL_0074: add
    IL_0075: call T Z0.As::generic<T>(System.Int32)
    IL_007A: ret
    IL_007B: ldtoken T
    IL_0080: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0085: ldtoken System.UInt16
    IL_008A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0094: brfalse.s IL_00A4
    IL_0096: ldarg.0
    IL_0097: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009C: ldc.i4.1
    IL_009D: add
    IL_009E: call T Z0.As::generic<T>(System.Int32)
    IL_00A3: ret
    IL_00A4: ldtoken T
    IL_00A9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00AE: ldtoken System.Int32
    IL_00B3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B8: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00BD: brfalse.s IL_00CD
    IL_00BF: ldarg.0
    IL_00C0: call System.Int32 Z0.As::int32<T>(T)
    IL_00C5: ldc.i4.1
    IL_00C6: add
    IL_00C7: call T Z0.As::generic<T>(System.Int32)
    IL_00CC: ret
    IL_00CD: ldtoken T
    IL_00D2: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D7: ldtoken System.UInt32
    IL_00DC: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00E6: brfalse.s IL_00F6
    IL_00E8: ldarg.0
    IL_00E9: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00EE: ldc.i4.1
    IL_00EF: add
    IL_00F0: call T Z0.As::generic<T>(System.UInt32)
    IL_00F5: ret
    IL_00F6: ldtoken T
    IL_00FB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0100: ldtoken System.Int64
    IL_0105: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010F: brfalse.s IL_0120
    IL_0111: ldarg.0
    IL_0112: call System.Int64 Z0.As::int64<T>(T)
    IL_0117: ldc.i4.1
    IL_0118: conv.i8
    IL_0119: add
    IL_011A: call T Z0.As::generic<T>(System.Int64)
    IL_011F: ret
    IL_0120: ldtoken T
    IL_0125: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012A: ldtoken System.UInt64
    IL_012F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0134: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0139: brfalse.s IL_014A
    IL_013B: ldarg.0
    IL_013C: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0141: ldc.i4.1
    IL_0142: conv.i8
    IL_0143: add
    IL_0144: call T Z0.As::generic<T>(System.UInt64)
    IL_0149: ret
    IL_014A: ldtoken T
    IL_014F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0154: ldtoken System.Single
    IL_0159: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0163: brfalse.s IL_0177
    IL_0165: ldarg.0
    IL_0166: call System.Single Z0.As::float32<T>(T)
    IL_016B: ldc.r4 1
    IL_0170: add
    IL_0171: call T Z0.As::generic<T>(System.Single)
    IL_0176: ret
    IL_0177: ldtoken T
    IL_017C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0181: ldtoken System.Double
    IL_0186: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018B: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0190: brfalse.s IL_01A8
    IL_0192: ldarg.0
    IL_0193: call System.Double Z0.As::float64<T>(T)
    IL_0198: ldc.r8 1
    IL_01A1: add
    IL_01A2: call T Z0.As::generic<T>(System.Double)
    IL_01A7: ret
    IL_01A8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01AD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01B2: ldc.i4.s 43
    IL_01B4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01B9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01BE: throw

}
float inc<float>(float src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0029
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: add
    IL_0023: call T Z0.As::generic<T>(System.Int32)
    IL_0028: ret
    IL_0029: ldtoken T
    IL_002E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0033: ldtoken System.Byte
    IL_0038: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0042: brfalse.s IL_0052
    IL_0044: ldarg.0
    IL_0045: call System.Byte Z0.As::uint8<T>(T)
    IL_004A: ldc.i4.1
    IL_004B: add
    IL_004C: call T Z0.As::generic<T>(System.Int32)
    IL_0051: ret
    IL_0052: ldtoken T
    IL_0057: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005C: ldtoken System.Int16
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006B: brfalse.s IL_007B
    IL_006D: ldarg.0
    IL_006E: call System.Int16 Z0.As::int16<T>(T)
    IL_0073: ldc.i4.1
    IL_0074: add
    IL_0075: call T Z0.As::generic<T>(System.Int32)
    IL_007A: ret
    IL_007B: ldtoken T
    IL_0080: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0085: ldtoken System.UInt16
    IL_008A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0094: brfalse.s IL_00A4
    IL_0096: ldarg.0
    IL_0097: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009C: ldc.i4.1
    IL_009D: add
    IL_009E: call T Z0.As::generic<T>(System.Int32)
    IL_00A3: ret
    IL_00A4: ldtoken T
    IL_00A9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00AE: ldtoken System.Int32
    IL_00B3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B8: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00BD: brfalse.s IL_00CD
    IL_00BF: ldarg.0
    IL_00C0: call System.Int32 Z0.As::int32<T>(T)
    IL_00C5: ldc.i4.1
    IL_00C6: add
    IL_00C7: call T Z0.As::generic<T>(System.Int32)
    IL_00CC: ret
    IL_00CD: ldtoken T
    IL_00D2: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D7: ldtoken System.UInt32
    IL_00DC: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00E6: brfalse.s IL_00F6
    IL_00E8: ldarg.0
    IL_00E9: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00EE: ldc.i4.1
    IL_00EF: add
    IL_00F0: call T Z0.As::generic<T>(System.UInt32)
    IL_00F5: ret
    IL_00F6: ldtoken T
    IL_00FB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0100: ldtoken System.Int64
    IL_0105: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010F: brfalse.s IL_0120
    IL_0111: ldarg.0
    IL_0112: call System.Int64 Z0.As::int64<T>(T)
    IL_0117: ldc.i4.1
    IL_0118: conv.i8
    IL_0119: add
    IL_011A: call T Z0.As::generic<T>(System.Int64)
    IL_011F: ret
    IL_0120: ldtoken T
    IL_0125: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012A: ldtoken System.UInt64
    IL_012F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0134: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0139: brfalse.s IL_014A
    IL_013B: ldarg.0
    IL_013C: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0141: ldc.i4.1
    IL_0142: conv.i8
    IL_0143: add
    IL_0144: call T Z0.As::generic<T>(System.UInt64)
    IL_0149: ret
    IL_014A: ldtoken T
    IL_014F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0154: ldtoken System.Single
    IL_0159: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0163: brfalse.s IL_0177
    IL_0165: ldarg.0
    IL_0166: call System.Single Z0.As::float32<T>(T)
    IL_016B: ldc.r4 1
    IL_0170: add
    IL_0171: call T Z0.As::generic<T>(System.Single)
    IL_0176: ret
    IL_0177: ldtoken T
    IL_017C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0181: ldtoken System.Double
    IL_0186: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018B: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0190: brfalse.s IL_01A8
    IL_0192: ldarg.0
    IL_0193: call System.Double Z0.As::float64<T>(T)
    IL_0198: ldc.r8 1
    IL_01A1: add
    IL_01A2: call T Z0.As::generic<T>(System.Double)
    IL_01A7: ret
    IL_01A8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01AD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01B2: ldc.i4.s 43
    IL_01B4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01B9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01BE: throw

}
double inc<double>(double src)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0029
    IL_001B: ldarg.0
    IL_001C: call System.SByte Z0.As::int8<T>(T)
    IL_0021: ldc.i4.1
    IL_0022: add
    IL_0023: call T Z0.As::generic<T>(System.Int32)
    IL_0028: ret
    IL_0029: ldtoken T
    IL_002E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0033: ldtoken System.Byte
    IL_0038: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_003D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0042: brfalse.s IL_0052
    IL_0044: ldarg.0
    IL_0045: call System.Byte Z0.As::uint8<T>(T)
    IL_004A: ldc.i4.1
    IL_004B: add
    IL_004C: call T Z0.As::generic<T>(System.Int32)
    IL_0051: ret
    IL_0052: ldtoken T
    IL_0057: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005C: ldtoken System.Int16
    IL_0061: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0066: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_006B: brfalse.s IL_007B
    IL_006D: ldarg.0
    IL_006E: call System.Int16 Z0.As::int16<T>(T)
    IL_0073: ldc.i4.1
    IL_0074: add
    IL_0075: call T Z0.As::generic<T>(System.Int32)
    IL_007A: ret
    IL_007B: ldtoken T
    IL_0080: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0085: ldtoken System.UInt16
    IL_008A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_008F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0094: brfalse.s IL_00A4
    IL_0096: ldarg.0
    IL_0097: call System.UInt16 Z0.As::uint16<T>(T)
    IL_009C: ldc.i4.1
    IL_009D: add
    IL_009E: call T Z0.As::generic<T>(System.Int32)
    IL_00A3: ret
    IL_00A4: ldtoken T
    IL_00A9: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00AE: ldtoken System.Int32
    IL_00B3: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B8: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00BD: brfalse.s IL_00CD
    IL_00BF: ldarg.0
    IL_00C0: call System.Int32 Z0.As::int32<T>(T)
    IL_00C5: ldc.i4.1
    IL_00C6: add
    IL_00C7: call T Z0.As::generic<T>(System.Int32)
    IL_00CC: ret
    IL_00CD: ldtoken T
    IL_00D2: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00D7: ldtoken System.UInt32
    IL_00DC: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E1: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00E6: brfalse.s IL_00F6
    IL_00E8: ldarg.0
    IL_00E9: call System.UInt32 Z0.As::uint32<T>(T)
    IL_00EE: ldc.i4.1
    IL_00EF: add
    IL_00F0: call T Z0.As::generic<T>(System.UInt32)
    IL_00F5: ret
    IL_00F6: ldtoken T
    IL_00FB: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0100: ldtoken System.Int64
    IL_0105: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_010A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010F: brfalse.s IL_0120
    IL_0111: ldarg.0
    IL_0112: call System.Int64 Z0.As::int64<T>(T)
    IL_0117: ldc.i4.1
    IL_0118: conv.i8
    IL_0119: add
    IL_011A: call T Z0.As::generic<T>(System.Int64)
    IL_011F: ret
    IL_0120: ldtoken T
    IL_0125: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012A: ldtoken System.UInt64
    IL_012F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0134: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0139: brfalse.s IL_014A
    IL_013B: ldarg.0
    IL_013C: call System.UInt64 Z0.As::uint64<T>(T)
    IL_0141: ldc.i4.1
    IL_0142: conv.i8
    IL_0143: add
    IL_0144: call T Z0.As::generic<T>(System.UInt64)
    IL_0149: ret
    IL_014A: ldtoken T
    IL_014F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0154: ldtoken System.Single
    IL_0159: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_015E: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0163: brfalse.s IL_0177
    IL_0165: ldarg.0
    IL_0166: call System.Single Z0.As::float32<T>(T)
    IL_016B: ldc.r4 1
    IL_0170: add
    IL_0171: call T Z0.As::generic<T>(System.Single)
    IL_0176: ret
    IL_0177: ldtoken T
    IL_017C: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0181: ldtoken System.Double
    IL_0186: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_018B: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0190: brfalse.s IL_01A8
    IL_0192: ldarg.0
    IL_0193: call System.Double Z0.As::float64<T>(T)
    IL_0198: ldc.r8 1
    IL_01A1: add
    IL_01A2: call T Z0.As::generic<T>(System.Double)
    IL_01A7: ret
    IL_01A8: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01AD: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Inc.cs"
    IL_01B2: ldc.i4.s 43
    IL_01B4: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_01B9: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_01BE: throw

}

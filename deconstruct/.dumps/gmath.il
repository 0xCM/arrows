// 2019-07-01 01:15:29:926
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
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::modI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::modU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::modI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::modU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::modI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::modU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::modI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::modU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::modF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::modF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
ushort mod<ushort>(ushort lhs, ushort rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::modI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::modU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::modI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::modU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::modI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::modU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::modI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::modU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::modF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::modF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
uint mod<uint>(uint lhs, uint rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::modI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::modU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::modI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::modU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::modI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::modU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::modI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::modU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::modF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::modF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
ulong mod<ulong>(ulong lhs, ulong rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::modI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::modU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::modI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::modU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::modI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::modU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::modI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::modU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::modF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::modF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
sbyte mod<sbyte>(sbyte lhs, sbyte rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::modI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::modU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::modI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::modU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::modI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::modU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::modI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::modU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::modF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::modF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
short mod<short>(short lhs, short rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::modI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::modU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::modI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::modU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::modI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::modU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::modI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::modU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::modF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::modF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
int mod<int>(int lhs, int rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::modI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::modU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::modI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::modU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::modI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::modU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::modI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::modU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::modF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::modF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
long mod<long>(long lhs, long rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::modI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::modU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::modI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::modU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::modI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::modU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::modI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::modU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::modF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::modF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
float mod<float>(float lhs, float rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::modI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::modU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::modI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::modU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::modI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::modU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::modI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::modU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::modF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::modF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}
double mod<double>(double lhs, double rhs)
{
    IL_0000: ldtoken T
    IL_0005: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_000A: ldtoken System.SByte
    IL_000F: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0014: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0019: brfalse.s IL_0023
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: call T Z0.gmath::modI8<T>(T,T)
    IL_0022: ret
    IL_0023: ldtoken T
    IL_0028: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_002D: ldtoken System.Byte
    IL_0032: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0037: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_003C: brfalse.s IL_0046
    IL_003E: ldarg.0
    IL_003F: ldarg.1
    IL_0040: call T Z0.gmath::modU8<T>(T,T)
    IL_0045: ret
    IL_0046: ldtoken T
    IL_004B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0050: ldtoken System.Int16
    IL_0055: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_005A: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_005F: brfalse.s IL_0069
    IL_0061: ldarg.0
    IL_0062: ldarg.1
    IL_0063: call T Z0.gmath::modI16<T>(T,T)
    IL_0068: ret
    IL_0069: ldtoken T
    IL_006E: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0073: ldtoken System.UInt16
    IL_0078: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_007D: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0082: brfalse.s IL_008C
    IL_0084: ldarg.0
    IL_0085: ldarg.1
    IL_0086: call T Z0.gmath::modU16<T>(T,T)
    IL_008B: ret
    IL_008C: ldtoken T
    IL_0091: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0096: ldtoken System.Int32
    IL_009B: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00A0: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00A5: brfalse.s IL_00AF
    IL_00A7: ldarg.0
    IL_00A8: ldarg.1
    IL_00A9: call T Z0.gmath::modI32<T>(T,T)
    IL_00AE: ret
    IL_00AF: ldtoken T
    IL_00B4: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00B9: ldtoken System.UInt32
    IL_00BE: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00C3: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00C8: brfalse.s IL_00D2
    IL_00CA: ldarg.0
    IL_00CB: ldarg.1
    IL_00CC: call T Z0.gmath::modU32<T>(T,T)
    IL_00D1: ret
    IL_00D2: ldtoken T
    IL_00D7: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00DC: ldtoken System.Int64
    IL_00E1: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00E6: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_00EB: brfalse.s IL_00F5
    IL_00ED: ldarg.0
    IL_00EE: ldarg.1
    IL_00EF: call T Z0.gmath::modI64<T>(T,T)
    IL_00F4: ret
    IL_00F5: ldtoken T
    IL_00FA: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_00FF: ldtoken System.UInt64
    IL_0104: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0109: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_010E: brfalse.s IL_0118
    IL_0110: ldarg.0
    IL_0111: ldarg.1
    IL_0112: call T Z0.gmath::modU64<T>(T,T)
    IL_0117: ret
    IL_0118: ldtoken T
    IL_011D: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0122: ldtoken System.Single
    IL_0127: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_012C: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0131: brfalse.s IL_013B
    IL_0133: ldarg.0
    IL_0134: ldarg.1
    IL_0135: call T Z0.gmath::modF32<T>(T,T)
    IL_013A: ret
    IL_013B: ldtoken T
    IL_0140: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_0145: ldtoken System.Double
    IL_014A: call System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
    IL_014F: call System.Boolean System.Type::op_Equality(System.Type,System.Type)
    IL_0154: brfalse.s IL_015E
    IL_0156: ldarg.0
    IL_0157: ldarg.1
    IL_0158: call T Z0.gmath::modF64<T>(T,T)
    IL_015D: ret
    IL_015E: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0163: ldstr "J:\\dev\\projects\\z0\\primal\\generic\\operators\\Mod.cs"
    IL_0168: ldc.i4.s 43
    IL_016A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_016F: call Z0.AppException zfunc::unsupported<T>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0174: throw

}

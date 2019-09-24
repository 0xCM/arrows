// 2019-07-27 22:51:42:858
double dot(Span<float> x, Span<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dot"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\blas.cs"
    IL_000C: ldc.i4.s 30
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Single,System.Single>(System.Span`1<System.Single>,System.Span`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: ldarga.s x
    IL_001A: ldc.i4.0
    IL_001B: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0020: ldc.i4.1
    IL_0021: ldarga.s y
    IL_0023: ldc.i4.0
    IL_0024: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0029: ldc.i4.1
    IL_002A: call System.Single Z0.Mkl.CBLAS::cblas_sdot(System.Int32,System.Single&,System.Int32,System.Single&,System.Int32)
    IL_002F: conv.r8
    IL_0030: ret

}
double dot(Span<double> lhs, Span<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "dot"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\blas.cs"
    IL_000C: ldc.i4.s 34
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Double,System.Double>(System.Span`1<System.Double>,System.Span`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: ldarga.s lhs
    IL_001A: ldc.i4.0
    IL_001B: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0020: ldc.i4.1
    IL_0021: ldarga.s rhs
    IL_0023: ldc.i4.0
    IL_0024: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0029: ldc.i4.1
    IL_002A: call System.Double Z0.Mkl.CBLAS::cblas_ddot(System.Int32,System.Double&,System.Int32,System.Double&,System.Int32)
    IL_002F: ret

}
double asum(Span<float> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_0007: ldarga.s src
    IL_0009: ldc.i4.0
    IL_000A: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_000F: ldc.i4.1
    IL_0010: call System.Single Z0.Mkl.CBLAS::cblas_sasum(System.Int32,System.Single&,System.Int32)
    IL_0015: conv.r8
    IL_0016: ret

}
double asum(Span<double> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_0007: ldarga.s src
    IL_0009: ldc.i4.0
    IL_000A: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_000F: ldc.i4.1
    IL_0010: call System.Double Z0.Mkl.CBLAS::cblas_dasum(System.Int32,System.Double&,System.Int32)
    IL_0015: ret

}
float asum(Span<ComplexF32> x)
{
    IL_0000: ldarga.s x
    IL_0002: call System.Int32 System.Span`1<Z0.ComplexF32>::get_Length()
    IL_0007: ldarga.s x
    IL_0009: ldc.i4.0
    IL_000A: call Z0.ComplexF32& System.Span`1<Z0.ComplexF32>::get_Item(System.Int32)
    IL_000F: ldc.i4.1
    IL_0010: call System.Single Z0.Mkl.CBLAS::cblas_scasum(System.Int32,Z0.ComplexF32&,System.Int32)
    IL_0015: ret

}
double asum(Span<ComplexF64> x)
{
    IL_0000: ldarga.s x
    IL_0002: call System.Int32 System.Span`1<Z0.ComplexF64>::get_Length()
    IL_0007: ldarga.s x
    IL_0009: ldc.i4.0
    IL_000A: call Z0.ComplexF64& System.Span`1<Z0.ComplexF64>::get_Item(System.Int32)
    IL_000F: ldc.i4.1
    IL_0010: call System.Double Z0.Mkl.CBLAS::cblas_dzasum(System.Int32,Z0.ComplexF64&,System.Int32)
    IL_0015: ret

}
VslStream stream(int brng, uint seed)
{
    IL_0000: ldsfld System.IntPtr System.IntPtr::Zero
    IL_0005: stloc.0
    IL_0006: ldloca.s V_0
    IL_0008: ldarg.0
    IL_0009: ldarg.1
    IL_000A: call Z0.Mkl.VslRngStatus Z0.Mkl.VSL::vslNewStream(System.IntPtr&,Z0.Mkl.BRNG,System.UInt32)
    IL_000F: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\rng.cs"
    IL_0014: ldc.i4.s 21
    IL_0016: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_001B: call System.Boolean Z0.Mkl.VslCodeX::ThrowOnError(Z0.Mkl.VslRngStatus,System.String,System.Nullable`1<System.Int32>)
    IL_0020: pop
    IL_0021: ldloc.0
    IL_0022: call Z0.Mkl.VslStream Z0.Mkl.VslStream::op_Implicit(System.IntPtr)
    IL_0027: ret

}
int brng(VslStream stream)
{
    IL_0000: ldarg.0
    IL_0001: call System.IntPtr Z0.Mkl.VslStream::op_Implicit(Z0.Mkl.VslStream)
    IL_0006: call Z0.Mkl.BRNG Z0.Mkl.VSL::vslGetStreamStateBrng(System.IntPtr)
    IL_000B: ret

}
UniformRangeSample<int> uniform(VslStream stream, Interval<int> range, Span<int> buffer)
{
    IL_0000: ldc.i4.0
    IL_0001: ldarg.0
    IL_0002: call System.IntPtr Z0.Mkl.VslStream::op_Implicit(Z0.Mkl.VslStream)
    IL_0007: ldarga.s buffer
    IL_0009: call System.Int32 System.Span`1<System.Int32>::get_Length()
    IL_000E: ldarga.s buffer
    IL_0010: ldc.i4.0
    IL_0011: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0016: ldarg.1
    IL_0017: ldfld System.Int32 Z0.Interval`1<System.Int32>::Left
    IL_001C: ldarg.1
    IL_001D: ldfld System.Int32 Z0.Interval`1<System.Int32>::Right
    IL_0022: call Z0.Mkl.VslRngStatus Z0.Mkl.VSL::viRngUniform(System.Int32,System.IntPtr,System.Int32,System.Int32&,System.Int32,System.Int32)
    IL_0027: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\rng.cs"
    IL_002C: ldc.i4.s 43
    IL_002E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0033: call System.Boolean Z0.Mkl.VslCodeX::ThrowOnError(Z0.Mkl.VslRngStatus,System.String,System.Nullable`1<System.Int32>)
    IL_0038: pop
    IL_0039: ldarg.0
    IL_003A: call Z0.Mkl.BRNG Z0.Mkl.mklx::Brng(Z0.Mkl.VslStream)
    IL_003F: ldarg.1
    IL_0040: ldarg.2
    IL_0041: call Z0.Mkl.UniformRangeSample`1<System.Int32> Z0.Mkl.mklx::UniformRangeSampled<System.Int32>(Z0.Mkl.BRNG,Z0.Interval`1<System.Int32>,System.Span`1<System.Int32>)
    IL_0046: ret

}
UniformRangeSample<float> uniform(VslStream stream, Interval<float> range, Span<float> buffer)
{
    IL_0000: ldc.i4.0
    IL_0001: ldarg.0
    IL_0002: call System.IntPtr Z0.Mkl.VslStream::op_Implicit(Z0.Mkl.VslStream)
    IL_0007: ldarga.s buffer
    IL_0009: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_000E: ldarga.s buffer
    IL_0010: ldc.i4.0
    IL_0011: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0016: ldarg.1
    IL_0017: ldfld System.Single Z0.Interval`1<System.Single>::Left
    IL_001C: ldarg.1
    IL_001D: ldfld System.Single Z0.Interval`1<System.Single>::Right
    IL_0022: call Z0.Mkl.VslRngStatus Z0.Mkl.VSL::vsRngUniform(System.Int32,System.IntPtr,System.Int32,System.Single&,System.Single,System.Single)
    IL_0027: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\rng.cs"
    IL_002C: ldc.i4.s 50
    IL_002E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0033: call System.Boolean Z0.Mkl.VslCodeX::ThrowOnError(Z0.Mkl.VslRngStatus,System.String,System.Nullable`1<System.Int32>)
    IL_0038: pop
    IL_0039: ldarg.0
    IL_003A: call Z0.Mkl.BRNG Z0.Mkl.mklx::Brng(Z0.Mkl.VslStream)
    IL_003F: ldarg.1
    IL_0040: ldarg.2
    IL_0041: call Z0.Mkl.UniformRangeSample`1<System.Single> Z0.Mkl.mklx::UniformRangeSampled<System.Single>(Z0.Mkl.BRNG,Z0.Interval`1<System.Single>,System.Span`1<System.Single>)
    IL_0046: ret

}
UniformRangeSample<double> uniform(VslStream stream, Interval<double> range, Span<double> buffer)
{
    IL_0000: ldc.i4.0
    IL_0001: ldarg.0
    IL_0002: call System.IntPtr Z0.Mkl.VslStream::op_Implicit(Z0.Mkl.VslStream)
    IL_0007: ldarga.s buffer
    IL_0009: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_000E: ldarga.s buffer
    IL_0010: ldc.i4.0
    IL_0011: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0016: ldarg.1
    IL_0017: ldfld System.Double Z0.Interval`1<System.Double>::Left
    IL_001C: ldarg.1
    IL_001D: ldfld System.Double Z0.Interval`1<System.Double>::Right
    IL_0022: call Z0.Mkl.VslRngStatus Z0.Mkl.VSL::vdRngUniform(System.Int32,System.IntPtr,System.Int32,System.Double&,System.Double,System.Double)
    IL_0027: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\rng.cs"
    IL_002C: ldc.i4.s 57
    IL_002E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0033: call System.Boolean Z0.Mkl.VslCodeX::ThrowOnError(Z0.Mkl.VslRngStatus,System.String,System.Nullable`1<System.Int32>)
    IL_0038: pop
    IL_0039: ldarg.0
    IL_003A: call Z0.Mkl.BRNG Z0.Mkl.mklx::Brng(Z0.Mkl.VslStream)
    IL_003F: ldarg.1
    IL_0040: ldarg.2
    IL_0041: call Z0.Mkl.UniformRangeSample`1<System.Double> Z0.Mkl.mklx::UniformRangeSampled<System.Double>(Z0.Mkl.BRNG,Z0.Interval`1<System.Double>,System.Span`1<System.Double>)
    IL_0046: ret

}
Span<float> cauchy(VslStream stream, float a, float b, Span<float> buffer)
{
    IL_0000: ldc.i4.0
    IL_0001: ldarg.0
    IL_0002: call System.IntPtr Z0.Mkl.VslStream::op_Implicit(Z0.Mkl.VslStream)
    IL_0007: ldarga.s buffer
    IL_0009: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_000E: ldarga.s buffer
    IL_0010: ldc.i4.0
    IL_0011: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0016: ldarg.1
    IL_0017: ldarg.2
    IL_0018: call Z0.Mkl.VslRngStatus Z0.Mkl.VSL::vsRngCauchy(System.Int32,System.IntPtr,System.Int32,System.Single&,System.Single,System.Single)
    IL_001D: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\rng.cs"
    IL_0022: ldc.i4.s 64
    IL_0024: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0029: call System.Boolean Z0.Mkl.VslCodeX::ThrowOnError(Z0.Mkl.VslRngStatus,System.String,System.Nullable`1<System.Int32>)
    IL_002E: pop
    IL_002F: ldarg.3
    IL_0030: ret

}
Span<double> cauchy(VslStream stream, double a, double b, Span<double> buffer)
{
    IL_0000: ldc.i4.0
    IL_0001: ldarg.0
    IL_0002: call System.IntPtr Z0.Mkl.VslStream::op_Implicit(Z0.Mkl.VslStream)
    IL_0007: ldarga.s buffer
    IL_0009: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_000E: ldarga.s buffer
    IL_0010: ldc.i4.0
    IL_0011: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0016: ldarg.1
    IL_0017: ldarg.2
    IL_0018: call Z0.Mkl.VslRngStatus Z0.Mkl.VSL::vdRngCauchy(System.Int32,System.IntPtr,System.Int32,System.Double&,System.Double,System.Double)
    IL_001D: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\rng.cs"
    IL_0022: ldc.i4.s 71
    IL_0024: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0029: call System.Boolean Z0.Mkl.VslCodeX::ThrowOnError(Z0.Mkl.VslRngStatus,System.String,System.Nullable`1<System.Int32>)
    IL_002E: pop
    IL_002F: ldarg.3
    IL_0030: ret

}
UniformBitsSample<uint> ubits(VslStream stream, Span<uint> buffer)
{
    IL_0000: ldc.i4.0
    IL_0001: ldarg.0
    IL_0002: call System.IntPtr Z0.Mkl.VslStream::op_Implicit(Z0.Mkl.VslStream)
    IL_0007: ldarga.s buffer
    IL_0009: call System.Int32 System.Span`1<System.UInt32>::get_Length()
    IL_000E: ldarga.s buffer
    IL_0010: ldc.i4.0
    IL_0011: call System.UInt32& System.Span`1<System.UInt32>::get_Item(System.Int32)
    IL_0016: call Z0.Mkl.VslRngStatus Z0.Mkl.VSL::viRngUniformBits32(System.Int32,System.IntPtr,System.Int32,System.UInt32&)
    IL_001B: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\rng.cs"
    IL_0020: ldc.i4.s 84
    IL_0022: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0027: call System.Boolean Z0.Mkl.VslCodeX::ThrowOnError(Z0.Mkl.VslRngStatus,System.String,System.Nullable`1<System.Int32>)
    IL_002C: pop
    IL_002D: ldarg.0
    IL_002E: call Z0.Mkl.BRNG Z0.Mkl.mklx::Brng(Z0.Mkl.VslStream)
    IL_0033: ldarg.1
    IL_0034: call Z0.Mkl.UniformBitsSample`1<System.UInt32> Z0.Mkl.mklx::UniformBitsSampled<System.UInt32>(Z0.Mkl.BRNG,System.Span`1<System.UInt32>)
    IL_0039: ret

}
UniformBitsSample<ulong> ubits(VslStream stream, Span<ulong> buffer)
{
    IL_0000: ldc.i4.0
    IL_0001: ldarg.0
    IL_0002: call System.IntPtr Z0.Mkl.VslStream::op_Implicit(Z0.Mkl.VslStream)
    IL_0007: ldarga.s buffer
    IL_0009: call System.Int32 System.Span`1<System.UInt64>::get_Length()
    IL_000E: ldarga.s buffer
    IL_0010: ldc.i4.0
    IL_0011: call System.UInt64& System.Span`1<System.UInt64>::get_Item(System.Int32)
    IL_0016: call Z0.Mkl.VslRngStatus Z0.Mkl.VSL::viRngUniformBits64(System.Int32,System.IntPtr,System.Int32,System.UInt64&)
    IL_001B: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\rng.cs"
    IL_0020: ldc.i4.s 96
    IL_0022: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0027: call System.Boolean Z0.Mkl.VslCodeX::ThrowOnError(Z0.Mkl.VslRngStatus,System.String,System.Nullable`1<System.Int32>)
    IL_002C: pop
    IL_002D: ldarg.0
    IL_002E: call Z0.Mkl.BRNG Z0.Mkl.mklx::Brng(Z0.Mkl.VslStream)
    IL_0033: ldarg.1
    IL_0034: call Z0.Mkl.UniformBitsSample`1<System.UInt64> Z0.Mkl.mklx::UniformBitsSampled<System.UInt64>(Z0.Mkl.BRNG,System.Span`1<System.UInt64>)
    IL_0039: ret

}
GeometricSample<int> geometric(VslStream stream, double p, Span<int> buffer)
{
    IL_0000: ldc.i4.0
    IL_0001: ldarg.0
    IL_0002: call System.IntPtr Z0.Mkl.VslStream::op_Implicit(Z0.Mkl.VslStream)
    IL_0007: ldarga.s buffer
    IL_0009: call System.Int32 System.Span`1<System.Int32>::get_Length()
    IL_000E: ldarga.s buffer
    IL_0010: ldc.i4.0
    IL_0011: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0016: ldarg.1
    IL_0017: call Z0.Mkl.VslRngStatus Z0.Mkl.VSL::viRngGeometric(System.Int32,System.IntPtr,System.Int32,System.Int32&,System.Double)
    IL_001C: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\rng.cs"
    IL_0021: ldc.i4.s 109
    IL_0023: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0028: call System.Boolean Z0.Mkl.VslCodeX::ThrowOnError(Z0.Mkl.VslRngStatus,System.String,System.Nullable`1<System.Int32>)
    IL_002D: pop
    IL_002E: ldarg.0
    IL_002F: call Z0.Mkl.BRNG Z0.Mkl.mklx::Brng(Z0.Mkl.VslStream)
    IL_0034: ldarg.1
    IL_0035: ldarg.2
    IL_0036: call Z0.Mkl.GeometricSample`1<System.Int32> Z0.Mkl.mklx::GeometricSampled<System.Int32>(Z0.Mkl.BRNG,System.Double,System.Span`1<System.Int32>)
    IL_003B: ret

}
Span<Bit> bernoulli(VslStream stream, double p, Span<Bit> buffer)
{
    IL_0000: ldarga.s buffer
    IL_0002: call System.Int32 System.Span`1<Z0.Bit>::get_Length()
    IL_0007: stloc.1
    IL_0008: ldloc.1
    IL_0009: conv.u
    IL_000A: ldc.i4.4
    IL_000B: mul.ovf.un
    IL_000C: localloc
    IL_000E: ldloc.1
    IL_000F: newobj System.Void System.Span`1<System.Int32>::.ctor(System.Void*,System.Int32)
    IL_0014: stloc.2
    IL_0015: ldloc.2
    IL_0016: stloc.0
    IL_0017: ldc.i4.0
    IL_0018: ldarg.0
    IL_0019: call System.IntPtr Z0.Mkl.VslStream::op_Implicit(Z0.Mkl.VslStream)
    IL_001E: ldarga.s buffer
    IL_0020: call System.Int32 System.Span`1<Z0.Bit>::get_Length()
    IL_0025: ldloca.s V_0
    IL_0027: ldc.i4.0
    IL_0028: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_002D: ldarg.1
    IL_002E: call Z0.Mkl.VslRngStatus Z0.Mkl.VSL::viRngBernoulli(System.Int32,System.IntPtr,System.Int32,System.Int32&,System.Double)
    IL_0033: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\rng.cs"
    IL_0038: ldc.i4.s 122
    IL_003A: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_003F: call System.Boolean Z0.Mkl.VslCodeX::ThrowOnError(Z0.Mkl.VslRngStatus,System.String,System.Nullable`1<System.Int32>)
    IL_0044: pop
    IL_0045: ldc.i4.0
    IL_0046: stloc.3
    IL_0047: br.s IL_0068
    IL_0049: ldarga.s buffer
    IL_004B: ldloc.3
    IL_004C: call Z0.Bit& System.Span`1<Z0.Bit>::get_Item(System.Int32)
    IL_0051: ldloca.s V_0
    IL_0053: ldloc.3
    IL_0054: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0059: ldind.i4
    IL_005A: call Z0.Bit Z0.Bit::op_Implicit(System.Int32)
    IL_005F: stobj Z0.Bit
    IL_0064: ldloc.3
    IL_0065: ldc.i4.1
    IL_0066: add
    IL_0067: stloc.3
    IL_0068: ldloc.3
    IL_0069: ldarga.s buffer
    IL_006B: call System.Int32 System.Span`1<Z0.Bit>::get_Length()
    IL_0070: blt.s IL_0049
    IL_0072: ldarg.2
    IL_0073: ret

}
ChiSquareSample<float> chi2(VslStream stream, int freedom, Span<float> buffer)
{
    IL_0000: ldc.i4.0
    IL_0001: ldarg.0
    IL_0002: call System.IntPtr Z0.Mkl.VslStream::op_Implicit(Z0.Mkl.VslStream)
    IL_0007: ldarga.s buffer
    IL_0009: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_000E: ldarga.s buffer
    IL_0010: ldc.i4.0
    IL_0011: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0016: ldarg.1
    IL_0017: call Z0.Mkl.VslRngStatus Z0.Mkl.VSL::vsRngChiSquare(System.Int32,System.IntPtr,System.Int32,System.Single&,System.Int32)
    IL_001C: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\rng.cs"
    IL_0021: ldc.i4 131
    IL_0026: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_002B: call System.Boolean Z0.Mkl.VslCodeX::ThrowOnError(Z0.Mkl.VslRngStatus,System.String,System.Nullable`1<System.Int32>)
    IL_0030: pop
    IL_0031: ldarg.0
    IL_0032: call Z0.Mkl.BRNG Z0.Mkl.mklx::Brng(Z0.Mkl.VslStream)
    IL_0037: ldarg.1
    IL_0038: ldarg.2
    IL_0039: call Z0.Mkl.ChiSquareSample`1<System.Single> Z0.Mkl.mklx::ChiSquareSampled<System.Single>(Z0.Mkl.BRNG,System.Int32,System.Span`1<System.Single>)
    IL_003E: ret

}
ChiSquareSample<double> chi2(VslStream stream, int freedom, Span<double> buffer)
{
    IL_0000: ldc.i4.0
    IL_0001: ldarg.0
    IL_0002: call System.IntPtr Z0.Mkl.VslStream::op_Implicit(Z0.Mkl.VslStream)
    IL_0007: ldarga.s buffer
    IL_0009: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_000E: ldarga.s buffer
    IL_0010: ldc.i4.0
    IL_0011: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0016: ldarg.1
    IL_0017: call Z0.Mkl.VslRngStatus Z0.Mkl.VSL::vdRngChiSquare(System.Int32,System.IntPtr,System.Int32,System.Double&,System.Int32)
    IL_001C: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\rng.cs"
    IL_0021: ldc.i4 138
    IL_0026: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_002B: call System.Boolean Z0.Mkl.VslCodeX::ThrowOnError(Z0.Mkl.VslRngStatus,System.String,System.Nullable`1<System.Int32>)
    IL_0030: pop
    IL_0031: ldarg.0
    IL_0032: call Z0.Mkl.BRNG Z0.Mkl.mklx::Brng(Z0.Mkl.VslStream)
    IL_0037: ldarg.1
    IL_0038: ldarg.2
    IL_0039: call Z0.Mkl.ChiSquareSample`1<System.Double> Z0.Mkl.mklx::ChiSquareSampled<System.Double>(Z0.Mkl.BRNG,System.Int32,System.Span`1<System.Double>)
    IL_003E: ret

}
GaussianSample<float> gaussian(VslStream stream, float mu, float sigma, Span<float> buffer)
{
    IL_0000: ldc.i4.0
    IL_0001: ldarg.0
    IL_0002: call System.IntPtr Z0.Mkl.VslStream::op_Implicit(Z0.Mkl.VslStream)
    IL_0007: ldarga.s buffer
    IL_0009: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_000E: ldarga.s buffer
    IL_0010: ldc.i4.0
    IL_0011: call System.Single& System.Span`1<System.Single>::get_Item(System.Int32)
    IL_0016: ldarg.1
    IL_0017: ldarg.2
    IL_0018: call Z0.Mkl.VslRngStatus Z0.Mkl.VSL::vsRngGaussian(Z0.Mkl.VslGaussianMethod,System.IntPtr,System.Int32,System.Single&,System.Single,System.Single)
    IL_001D: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\rng.cs"
    IL_0022: ldc.i4 152
    IL_0027: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_002C: call System.Boolean Z0.Mkl.VslCodeX::ThrowOnError(Z0.Mkl.VslRngStatus,System.String,System.Nullable`1<System.Int32>)
    IL_0031: pop
    IL_0032: ldarg.0
    IL_0033: call Z0.Mkl.BRNG Z0.Mkl.mklx::Brng(Z0.Mkl.VslStream)
    IL_0038: ldarg.1
    IL_0039: conv.r8
    IL_003A: ldarg.2
    IL_003B: conv.r8
    IL_003C: ldarg.3
    IL_003D: call Z0.Mkl.GaussianSample`1<System.Single> Z0.Mkl.mklx::GaussianSample<System.Single>(Z0.Mkl.BRNG,System.Double,System.Double,System.Span`1<System.Single>)
    IL_0042: ret

}
GaussianSample<double> gaussian(VslStream stream, double mu, double sigma, Span<double> buffer)
{
    IL_0000: ldc.i4.0
    IL_0001: ldarg.0
    IL_0002: call System.IntPtr Z0.Mkl.VslStream::op_Implicit(Z0.Mkl.VslStream)
    IL_0007: ldarga.s buffer
    IL_0009: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_000E: ldarga.s buffer
    IL_0010: ldc.i4.0
    IL_0011: call System.Double& System.Span`1<System.Double>::get_Item(System.Int32)
    IL_0016: ldarg.1
    IL_0017: ldarg.2
    IL_0018: call Z0.Mkl.VslRngStatus Z0.Mkl.VSL::vdRngGaussian(Z0.Mkl.VslGaussianMethod,System.IntPtr,System.Int32,System.Double&,System.Double,System.Double)
    IL_001D: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\rng.cs"
    IL_0022: ldc.i4 166
    IL_0027: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_002C: call System.Boolean Z0.Mkl.VslCodeX::ThrowOnError(Z0.Mkl.VslRngStatus,System.String,System.Nullable`1<System.Int32>)
    IL_0031: pop
    IL_0032: ldarg.0
    IL_0033: call Z0.Mkl.BRNG Z0.Mkl.mklx::Brng(Z0.Mkl.VslStream)
    IL_0038: ldarg.1
    IL_0039: ldarg.2
    IL_003A: ldarg.3
    IL_003B: call Z0.Mkl.GaussianSample`1<System.Double> Z0.Mkl.mklx::GaussianSample<System.Double>(Z0.Mkl.BRNG,System.Double,System.Double,System.Span`1<System.Double>)
    IL_0040: ret

}
IVslSSTask<float> sstask(int dim, Single[] samples)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Mkl.VslSSTaskF32 Z0.Mkl.VslSSTaskF32::Define(System.Int32,System.Single[])
    IL_0007: ret

}
IVslSSTask<double> sstask(int dim, Double[] samples)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Mkl.VslSSTaskF64 Z0.Mkl.VslSSTaskF64::Define(System.Int32,System.Double[])
    IL_0007: ret

}
Span<float> add(Span<float> lhs, Span<float> rhs, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\vml.cs"
    IL_000C: ldc.i4.s 27
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Single,System.Single>(System.Span`1<System.Single>,System.Span`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: ldarg.0
    IL_0019: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_001E: ldarg.1
    IL_001F: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_0024: ldarg.2
    IL_0025: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_002A: call System.Void Z0.Mkl.VmlImport::vsAdd(System.Int32,System.Single&,System.Single&,System.Single&)
    IL_002F: ldarg.2
    IL_0030: ret

}
Span<double> add(Span<double> lhs, Span<double> rhs, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "add"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\vml.cs"
    IL_000C: ldc.i4.s 40
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Double,System.Double>(System.Span`1<System.Double>,System.Span`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: ldarg.0
    IL_0019: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_001E: ldarg.1
    IL_001F: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_0024: ldarg.2
    IL_0025: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_002A: call System.Void Z0.Mkl.VmlImport::vdAdd(System.Int32,System.Double&,System.Double&,System.Double&)
    IL_002F: ldarg.2
    IL_0030: ret

}
Span<float> sub(Span<float> lhs, Span<float> rhs, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\vml.cs"
    IL_000C: ldc.i4.s 53
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Single,System.Single>(System.Span`1<System.Single>,System.Span`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: ldarg.0
    IL_0019: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_001E: ldarg.1
    IL_001F: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_0024: ldarg.2
    IL_0025: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_002A: call System.Void Z0.Mkl.VmlImport::vsSub(System.Int32,System.Single&,System.Single&,System.Single&)
    IL_002F: ldarg.2
    IL_0030: ret

}
Span<double> sub(Span<double> lhs, Span<double> rhs, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "sub"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\vml.cs"
    IL_000C: ldc.i4.s 66
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Double,System.Double>(System.Span`1<System.Double>,System.Span`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: ldarg.0
    IL_0019: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_001E: ldarg.1
    IL_001F: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_0024: ldarg.2
    IL_0025: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_002A: call System.Void Z0.Mkl.VmlImport::vdSub(System.Int32,System.Double&,System.Double&,System.Double&)
    IL_002F: ldarg.2
    IL_0030: ret

}
Span<float> mul(Span<float> lhs, Span<float> rhs, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\vml.cs"
    IL_000C: ldc.i4.s 79
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Single,System.Single>(System.Span`1<System.Single>,System.Span`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: ldarg.0
    IL_0019: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_001E: ldarg.1
    IL_001F: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_0024: ldarg.2
    IL_0025: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_002A: call System.Void Z0.Mkl.VmlImport::vsMul(System.Int32,System.Single&,System.Single&,System.Single&)
    IL_002F: ldarg.2
    IL_0030: ret

}
Span<double> mul(Span<double> lhs, Span<double> rhs, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "mul"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\vml.cs"
    IL_000C: ldc.i4.s 92
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Double,System.Double>(System.Span`1<System.Double>,System.Span`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: ldarg.0
    IL_0019: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_001E: ldarg.1
    IL_001F: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_0024: ldarg.2
    IL_0025: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_002A: call System.Void Z0.Mkl.VmlImport::vdMul(System.Int32,System.Double&,System.Double&,System.Double&)
    IL_002F: ldarg.2
    IL_0030: ret

}
Span<float> div(Span<float> lhs, Span<float> rhs, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\vml.cs"
    IL_000C: ldc.i4.s 105
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Single,System.Single>(System.Span`1<System.Single>,System.Span`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: ldarg.0
    IL_0019: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_001E: ldarg.1
    IL_001F: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_0024: ldarg.2
    IL_0025: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_002A: call System.Void Z0.Mkl.VmlImport::vsDiv(System.Int32,System.Single&,System.Single&,System.Single&)
    IL_002F: ldarg.2
    IL_0030: ret

}
Span<double> div(Span<double> lhs, Span<double> rhs, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "div"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\vml.cs"
    IL_000C: ldc.i4.s 119
    IL_000E: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0013: call System.Int32 zfunc::length<System.Double,System.Double>(System.Span`1<System.Double>,System.Span`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0018: ldarg.0
    IL_0019: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_001E: ldarg.1
    IL_001F: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_0024: ldarg.2
    IL_0025: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_002A: call System.Void Z0.Mkl.VmlImport::vdDiv(System.Int32,System.Double&,System.Double&,System.Double&)
    IL_002F: ldarg.2
    IL_0030: ret

}
Span<float> fmod(Span<float> lhs, Span<float> rhs, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "fmod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\vml.cs"
    IL_000C: ldc.i4 132
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Single,System.Single>(System.Span`1<System.Single>,System.Span`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: ldarg.0
    IL_001C: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_0021: ldarg.1
    IL_0022: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_0027: ldarg.2
    IL_0028: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_002D: call System.Void Z0.Mkl.VmlImport::vsFmod(System.Int32,System.Single&,System.Single&,System.Single&)
    IL_0032: ldarg.2
    IL_0033: ret

}
float fmod(float lhs, float rhs)
{
    IL_0000: ldc.r4 0
    IL_0005: stloc.0
    IL_0006: ldc.i4.1
    IL_0007: ldarga.s lhs
    IL_0009: ldarga.s rhs
    IL_000B: ldloca.s V_0
    IL_000D: call System.Void Z0.Mkl.VmlImport::vsModf(System.Int32,System.Single&,System.Single&,System.Single&)
    IL_0012: ldloc.0
    IL_0013: ret

}
Span<double> fmod(Span<double> lhs, Span<double> rhs, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "fmod"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\vml.cs"
    IL_000C: ldc.i4 153
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Double,System.Double>(System.Span`1<System.Double>,System.Span`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: ldarg.0
    IL_001C: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_0021: ldarg.1
    IL_0022: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_0027: ldarg.2
    IL_0028: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_002D: call System.Void Z0.Mkl.VmlImport::vdFmod(System.Int32,System.Double&,System.Double&,System.Double&)
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<float> rem(Span<float> lhs, Span<float> rhs, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "rem"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\vml.cs"
    IL_000C: ldc.i4 166
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Single,System.Single>(System.Span`1<System.Single>,System.Span`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: ldarg.0
    IL_001C: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_0021: ldarg.1
    IL_0022: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_0027: ldarg.2
    IL_0028: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_002D: call System.Void Z0.Mkl.VmlImport::vsRemainder(System.Int32,System.Single&,System.Single&,System.Single&)
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<double> rem(Span<double> lhs, Span<double> rhs, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "rem"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\vml.cs"
    IL_000C: ldc.i4 179
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Double,System.Double>(System.Span`1<System.Double>,System.Span`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: ldarg.0
    IL_001C: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_0021: ldarg.1
    IL_0022: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_0027: ldarg.2
    IL_0028: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_002D: call System.Void Z0.Mkl.VmlImport::vdRemainder(System.Int32,System.Double&,System.Double&,System.Double&)
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<float> sqrt(Span<float> src, Span<float> dst)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_0007: ldarg.0
    IL_0008: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_000D: ldarg.1
    IL_000E: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_0013: call System.Void Z0.Mkl.VmlImport::vsSqrt(System.Int32,System.Single&,System.Single&)
    IL_0018: ldarg.1
    IL_0019: ret

}
Span<double> sqrt(Span<double> src, Span<double> dst)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_0007: ldarg.0
    IL_0008: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_000D: ldarg.1
    IL_000E: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_0013: call System.Void Z0.Mkl.VmlImport::vdSqrt(System.Int32,System.Double&,System.Double&)
    IL_0018: ldarg.1
    IL_0019: ret

}
Span<float> square(Span<float> src, Span<float> dst)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_0007: ldarg.0
    IL_0008: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_000D: ldarg.1
    IL_000E: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_0013: call System.Void Z0.Mkl.VmlImport::vsSqr(System.Int32,System.Single&,System.Single&)
    IL_0018: ldarg.1
    IL_0019: ret

}
Span<double> square(Span<double> src, Span<double> dst)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_0007: ldarg.0
    IL_0008: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_000D: ldarg.1
    IL_000E: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_0013: call System.Void Z0.Mkl.VmlImport::vdSqr(System.Int32,System.Double&,System.Double&)
    IL_0018: ldarg.1
    IL_0019: ret

}
Span<float> abs(Span<float> src, Span<float> dst)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_0007: ldarg.0
    IL_0008: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_000D: ldarg.1
    IL_000E: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_0013: call System.Void Z0.Mkl.VmlImport::vsAbs(System.Int32,System.Single&,System.Single&)
    IL_0018: ldarg.1
    IL_0019: ret

}
Span<double> abs(Span<double> src, Span<double> dst)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_0007: ldarg.0
    IL_0008: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_000D: ldarg.1
    IL_000E: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_0013: call System.Void Z0.Mkl.VmlImport::vdAbs(System.Int32,System.Double&,System.Double&)
    IL_0018: ldarg.1
    IL_0019: ret

}
Span<float> recip(Span<float> src, Span<float> dst)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_0007: ldarg.0
    IL_0008: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_000D: ldarg.1
    IL_000E: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_0013: call System.Void Z0.Mkl.VmlImport::vsInv(System.Int32,System.Single&,System.Single&)
    IL_0018: ldarg.1
    IL_0019: ret

}
Span<double> recip(Span<double> src, Span<double> dst)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_0007: ldarg.0
    IL_0008: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_000D: ldarg.1
    IL_000E: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_0013: call System.Void Z0.Mkl.VmlImport::vdInv(System.Int32,System.Double&,System.Double&)
    IL_0018: ldarg.1
    IL_0019: ret

}
Span<float> cdfNorm(Span<float> src, Span<float> dst)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_0007: ldarg.0
    IL_0008: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_000D: ldarg.1
    IL_000E: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_0013: call System.Void Z0.Mkl.VmlImport::vsCdfNorm(System.Int32,System.Single&,System.Single&)
    IL_0018: ldarg.1
    IL_0019: ret

}
Span<double> cdfNorm(Span<double> src, Span<double> dst)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_0007: ldarg.0
    IL_0008: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_000D: ldarg.1
    IL_000E: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_0013: call System.Void Z0.Mkl.VmlImport::vdCdfNorm(System.Int32,System.Double&,System.Double&)
    IL_0018: ldarg.1
    IL_0019: ret

}
Span<float> pow(Span<float> lhs, Span<float> rhs, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "pow"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\vml.cs"
    IL_000C: ldc.i4 312
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Single,System.Single>(System.Span`1<System.Single>,System.Span`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: ldarg.0
    IL_001C: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_0021: ldarg.1
    IL_0022: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_0027: ldarg.2
    IL_0028: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_002D: call System.Void Z0.Mkl.VmlImport::vsPow(System.Int32,System.Single&,System.Single&,System.Single&)
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<double> pow(Span<double> lhs, Span<double> rhs, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldstr "pow"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\vml.cs"
    IL_000C: ldc.i4 325
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Double,System.Double>(System.Span`1<System.Double>,System.Span`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: ldarg.0
    IL_001C: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_0021: ldarg.1
    IL_0022: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_0027: ldarg.2
    IL_0028: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_002D: call System.Void Z0.Mkl.VmlImport::vdPow(System.Int32,System.Double&,System.Double&,System.Double&)
    IL_0032: ldarg.2
    IL_0033: ret

}
Span<float> pow(Span<float> lhs, float rhs, Span<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: ldstr "pow"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\vml.cs"
    IL_000C: ldc.i4 338
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Single,System.Single>(System.Span`1<System.Single>,System.Span`1<System.Single>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: ldarg.0
    IL_001C: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_0021: ldarg.1
    IL_0022: ldarg.2
    IL_0023: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_0028: call System.Void Z0.Mkl.VmlImport::vsPowx(System.Int32,System.Single&,System.Single,System.Single&)
    IL_002D: ldarg.2
    IL_002E: ret

}
Span<double> pow(Span<double> lhs, double rhs, Span<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: ldstr "pow"
    IL_0007: ldstr "J:\\dev\\projects\\z0\\mkl\\api\\direct\\vml.cs"
    IL_000C: ldc.i4 351
    IL_0011: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0016: call System.Int32 zfunc::length<System.Double,System.Double>(System.Span`1<System.Double>,System.Span`1<System.Double>,System.String,System.String,System.Nullable`1<System.Int32>)
    IL_001B: ldarg.0
    IL_001C: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_0021: ldarg.1
    IL_0022: ldarg.2
    IL_0023: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_0028: call System.Void Z0.Mkl.VmlImport::vdPowx(System.Int32,System.Double&,System.Double,System.Double&)
    IL_002D: ldarg.2
    IL_002E: ret

}
Span<float> exp(Span<float> src, Span<float> dst)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.Span`1<System.Single>::get_Length()
    IL_0007: ldarg.0
    IL_0008: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_000D: ldarg.1
    IL_000E: call System.Single& zfunc::head<System.Single>(System.Span`1<System.Single>)
    IL_0013: call System.Void Z0.Mkl.VmlImport::vsExp(System.Int32,System.Single&,System.Single&)
    IL_0018: ldarg.1
    IL_0019: ret

}
Span<double> exp(Span<double> src, Span<double> dst)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.Span`1<System.Double>::get_Length()
    IL_0007: ldarg.0
    IL_0008: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_000D: ldarg.1
    IL_000E: call System.Double& zfunc::head<System.Double>(System.Span`1<System.Double>)
    IL_0013: call System.Void Z0.Mkl.VmlImport::vdExp(System.Int32,System.Double&,System.Double&)
    IL_0018: ldarg.1
    IL_0019: ret

}
float div(float lhs, float rhs)
{
    IL_0000: ldc.r4 0
    IL_0005: stloc.0
    IL_0006: ldc.i4.1
    IL_0007: ldarga.s lhs
    IL_0009: ldarga.s rhs
    IL_000B: ldloca.s V_0
    IL_000D: call System.Void Z0.Mkl.VmlImport::vsDiv(System.Int32,System.Single&,System.Single&,System.Single&)
    IL_0012: ldloc.0
    IL_0013: ret

}
double div(double lhs, double rhs)
{
    IL_0000: ldc.r8 0
    IL_0009: stloc.0
    IL_000A: ldc.i4.1
    IL_000B: ldarga.s lhs
    IL_000D: ldarga.s rhs
    IL_000F: ldloca.s V_0
    IL_0011: call System.Void Z0.Mkl.VmlImport::vdDiv(System.Int32,System.Double&,System.Double&,System.Double&)
    IL_0016: ldloc.0
    IL_0017: ret

}
float square(float src)
{
    IL_0000: ldc.r4 0
    IL_0005: stloc.0
    IL_0006: ldc.i4.1
    IL_0007: ldarga.s src
    IL_0009: ldloca.s V_0
    IL_000B: call System.Void Z0.Mkl.VmlImport::vsSqr(System.Int32,System.Single&,System.Single&)
    IL_0010: ldloc.0
    IL_0011: ret

}
void square(float src, byref Single dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.r4 0
    IL_0006: stind.r4
    IL_0007: ldc.i4.1
    IL_0008: ldarga.s src
    IL_000A: ldarg.1
    IL_000B: call System.Void Z0.Mkl.VmlImport::vsSqr(System.Int32,System.Single&,System.Single&)
    IL_0010: ret

}
double square(double src)
{
    IL_0000: ldc.r8 0
    IL_0009: stloc.0
    IL_000A: ldc.i4.1
    IL_000B: ldarga.s src
    IL_000D: ldloca.s V_0
    IL_000F: call System.Void Z0.Mkl.VmlImport::vdSqr(System.Int32,System.Double&,System.Double&)
    IL_0014: ldloc.0
    IL_0015: ret

}
void square(double src, byref Double dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.r8 0
    IL_000A: stind.r8
    IL_000B: ldc.i4.1
    IL_000C: ldarga.s src
    IL_000E: ldarg.1
    IL_000F: call System.Void Z0.Mkl.VmlImport::vdSqr(System.Int32,System.Double&,System.Double&)
    IL_0014: ret

}

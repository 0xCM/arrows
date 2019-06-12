//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using static zfunc;

	[StructLayout(LayoutKind.Sequential,CharSet=CharSet.Ansi)]
	public struct ComplexF32
	{
		public static implicit operator ComplexF32((float re, float im) x)
			=> new ComplexF32(x);

		public static implicit operator (float re, float im)(ComplexF32 x)
			=> (x.re, x.im);

		public float re;

        public float im;


		[MethodImpl(Inline)]
        public ComplexF32((float re, float im) x)
		{
			this.re = x.re;
			this.im = x.im;
		}

		[MethodImpl(Inline)]
        public ComplexF32(float re, float im)
		{
			this.re = re;
			this.im = im;
		}

		public string Format(int? scale = null)
		{
			var x = (scale != null ? MathF.Round(re,scale.Value) : re).ToString();
			var y = (scale != null ? MathF.Round(im,scale.Value) : im).ToString();
			return $"{x} + {y}i";			
		}

		public override string ToString() 
			=>  Format(4);

	}


	[StructLayout(LayoutKind.Sequential,CharSet=CharSet.Ansi)]
	public struct ComplexF64
	{
		public static implicit operator ComplexF64((double re, double im) x)
			=> new ComplexF64(x);

		public static implicit operator (double re, double im)(ComplexF64 x)
			=> (x.re, x.im);

		public double re;
        
        public double im;

		[MethodImpl(Inline)]
        public ComplexF64((double re, double im) x)
		{
			this.re = x.re;
			this.im = x.im;
		}

		
		[MethodImpl(Inline)]
        public ComplexF64(double re, double im)
		{
			this.re = re;
			this.im = im;
		}

		public string Format(int? scale = null)
		{
			var x = (scale != null ? Math.Round(re,scale.Value) : re).ToString();
			var y = (scale != null ? Math.Round(im,scale.Value) : im).ToString();
			return $"{x} + {y}i";			
		}

		public override string ToString() 
			=>  Format(4);
	}

	public static class ComplexX
	{
		[MethodImpl(Inline)]
		public static void Deconstruct(this ComplexF32 x, out float re, out float im)
		{
			re = x.re;
			im = x.im;
		}

		[MethodImpl(Inline)]
		public static void Deconstruct(this ComplexF64 x, out double re, out double im)
		{
			re = x.re;
			im = x.im;
		}

		[MethodImpl(Inline)]
		public static Span<ComplexF32> ToComplex(this Span<float> src)
		{
			if(src.Length % 2 != 0)
				throw new Exception("Missing component");
			return MemoryMarshal.Cast<float,ComplexF32>(src);
		}

		[MethodImpl(Inline)]
		public static Span<ComplexF64> ToComplex(this Span<double> src)
		{
			if(src.Length % 2 != 0)
				throw new Exception("Missing component");
			return MemoryMarshal.Cast<double,ComplexF64>(src);
		}
	}

}
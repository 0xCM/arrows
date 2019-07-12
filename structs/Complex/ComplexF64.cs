//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using static zfunc;

	/// <summary>
	/// Represents a 64-bit floating point complex value
	/// </summary>
	[StructLayout(LayoutKind.Sequential,CharSet=CharSet.Ansi)]
	public struct ComplexF64
	{
		/// <summary>
		/// Loads a span of span of complext values from a source span where adjacent 
		/// entries (i,i+j) are interpreted respectively as real and imaginary components
		/// </summary>
		/// <param name="src">The source span, which must contain an even number of elements</param>
		[MethodImpl(Inline)]
		public static Span<ComplexF64> Load(Span<double> src)
		{
			if(src.Length % 2 != 0)
				throw new Exception("Missing component");
			return MemoryMarshal.Cast<double,ComplexF64>(src);
		}

        /// <summary>
        /// Tests the operands for exact equality
        /// </summary>
        /// <param name="lhs">The first operand</param>
        /// <param name="rhs">The second operand</param>
		[MethodImpl(Inline)]
        public static bool operator ==(in ComplexF64 lhs, in ComplexF64 rhs)
            => lhs.im == rhs.im && lhs.re == rhs.re;

        /// <summary>
        /// Tests the operands for inequality
        /// </summary>
        /// <param name="lhs">The first operand</param>
        /// <param name="rhs">The second operand</param>
		[MethodImpl(Inline)]
        public static bool operator !=(in ComplexF64 lhs, in ComplexF64 rhs)
            => (lhs.im != rhs.im) || (lhs.re != rhs.re);

        /// <summary>
        /// Subtracts the second operand from the first
        /// </summary>
        /// <param name="lhs">The first operand</param>
        /// <param name="rhs">The second operand</param>
		[MethodImpl(Inline)]
        public static ComplexF64 operator -(in ComplexF64 lhs, in ComplexF64 rhs)
            => (lhs.re - rhs.re, lhs.im - rhs.im);

        /// <summary>
        /// Adds the second operand to the first
        /// </summary>
        /// <param name="lhs">The first operand</param>
        /// <param name="rhs">The second operand</param>
		[MethodImpl(Inline)]
        public static ComplexF64 operator +(in ComplexF64 lhs, in ComplexF64 rhs)
            => (lhs.re + rhs.re, lhs.im + rhs.im);

		/// <summary>
		/// Implcitly converts a 2-tuple to a complex value
		/// </summary>
		/// <param name="re">The real component</param>
		/// <param name="im">The imaginary component</param>
		[MethodImpl(Inline)]
		public static implicit operator ComplexF64(in (double re, double im) x)
			=> new ComplexF64(x);

		/// <summary>
		/// Implcitly converts a complex value to a 2-tuple
		/// </summary>
		/// <param name="x">The source value</param>
		/// <param name="re">The real component</param>
		/// <param name="im">The imaginary component</param>
		[MethodImpl(Inline)]
		public static implicit operator (double re, double im)(in ComplexF64 x)
			=> (x.re, x.im);

		/// <summary>
		/// Specifies the real component
		/// </summary>
		public double re;
        
 		/// <summary>
		/// Specifies the imaginary component
		/// </summary>
        public double im;

		/// <summary>
		/// Constructs the complex number from a tuple with real and imaginary parts
		/// </summary>
		/// <param name="re">The real component</param>
		/// <param name="im">The imaginary component</param>
		[MethodImpl(Inline)]
        public ComplexF64(in (double re, double im) x)
		{
			this.re = x.re;
			this.im = x.im;
		}

		/// <summary>
		/// Constructs the complex number from real and imaginary components
		/// </summary>
		/// <param name="re">The real component</param>
		/// <param name="im">The imaginary component</param>
		[MethodImpl(Inline)]
        public ComplexF64(double re, double im)
		{
			this.re = re;
			this.im = im;
		}

		/// <summary>
		/// Partitions the complex number into real and imanginary components
		/// </summary>
		/// <param name="re">The real component</param>
		/// <param name="im">The imaginary component</param>
		[MethodImpl(Inline)]
		public void Deconstruct(out double re, out double im)
		{
			re = this.re;
			im = this.im;
		}		

        /// <summary>
        /// Renders the value as a string per supplied options
        /// </summary>
        /// <param name="tupelize">Whether the value should be represented as a tuple (re,im) or in canonical form re +imi</param>
        /// <param name="scale">If specified, the presented scale of each component</param>
		public string Format(bool tupelize = false, int? scale = null)
		{
			var x = (scale != null ? Math.Round(re,scale.Value) : re).ToString();
			var y = (scale != null ? Math.Round(im,scale.Value) : im).ToString();
			return tupelize ? $"({x}, {y})" : $"{x} + {y}i";					
		}

		public override string ToString() 
			=>  Format(false, 4);

        public override int GetHashCode()
            => $"{re}{im}".GetHashCode();

        public override bool Equals(object src)
            => src is ComplexF64 c ? (c == this) : false;

        [MethodImpl(Inline)]
        public bool Equals(ComplexF64 src)
            => this == src;
	}


}
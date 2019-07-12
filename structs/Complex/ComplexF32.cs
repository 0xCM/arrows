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
	/// Represents a 32-bit floating point complex value
	/// </summary>
	[StructLayout(LayoutKind.Sequential,CharSet=CharSet.Ansi)]
	public struct ComplexF32 : IEquatable<ComplexF32>
	{
		/// <summary>
		/// Loads a span of span of complext values from a source span where adjacent 
		/// entries (i,i+j) are interpreted respectively as real and imaginary components
		/// </summary>
		/// <param name="src">The source span, which must contain an even number of elements</param>
		[MethodImpl(Inline)]
		public static Span<ComplexF32> Load(Span<float> src)
		{
			if(src.Length % 2 != 0)
				throw new Exception("Missing component");
			return MemoryMarshal.Cast<float,ComplexF32>(src);
		}

        /// <summary>
        /// Tests the operands for exact equality
        /// </summary>
        /// <param name="lhs">The first operand</param>
        /// <param name="rhs">The second operand</param>
		[MethodImpl(Inline)]
        public static bool operator ==(in ComplexF32 lhs, in ComplexF32 rhs)
            => lhs.im == rhs.im && lhs.re == rhs.re;

        /// <summary>
        /// Tests the operands for inequality
        /// </summary>
        /// <param name="lhs">The first operand</param>
        /// <param name="rhs">The second operand</param>
		[MethodImpl(Inline)]
        public static bool operator !=(in ComplexF32 lhs, in ComplexF32 rhs)
            => (lhs.im != rhs.im) || (lhs.re != rhs.re);

        /// <summary>
        /// Subtracts the second operand from the first
        /// </summary>
        /// <param name="lhs">The first operand</param>
        /// <param name="rhs">The second operand</param>
		[MethodImpl(Inline)]
        public static ComplexF32 operator -(in ComplexF32 lhs, in ComplexF32 rhs)
            => (lhs.re - rhs.re, lhs.im - rhs.im);

        /// <summary>
        /// Adds the second operand to the first
        /// </summary>
        /// <param name="lhs">The first operand</param>
        /// <param name="rhs">The second operand</param>
		[MethodImpl(Inline)]
        public static ComplexF32 operator +(in ComplexF32 lhs, in ComplexF32 rhs)
            => (lhs.re + rhs.re, lhs.im + rhs.im);

		/// <summary>
		/// Implcitly converts a 2-tuple to a complex value
		/// </summary>
		/// <param name="x">The source value</param>
		/// <param name="re">The real component</param>
		/// <param name="im">The imaginary component</param>
		[MethodImpl(Inline)]
		public static implicit operator ComplexF32(in (float re, float im) x)
			=> new ComplexF32(x);

		/// <summary>
		/// Implcitly converts a complex value to a 2-tuple
		/// </summary>
		/// <param name="x">The source value</param>
		/// <param name="re">The real component</param>
		/// <param name="im">The imaginary component</param>
		[MethodImpl(Inline)]
		public static implicit operator (float re, float im)(in ComplexF32 x)
			=> (x.re, x.im);

		/// <summary>
		/// specifies the real component
		/// </summary>
		public float re;

		/// <summary>
		/// Specifies the imaginary component
		/// </summary>
        public float im;

		/// <summary>
		/// Constructs the complex number from a tuple with real and imaginary parts
		/// </summary>
		/// <param name="re">The real component</param>
		/// <param name="im">The imaginary component</param>
		[MethodImpl(Inline)]
        public ComplexF32(in (float re, float im) x)
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
        public ComplexF32(float re, float im)
		{
			this.re = re;
			this.im = im;
		}

        /// <summary>
        /// Renders the value as a string per supplied options
        /// </summary>
        /// <param name="tupelize">Whether the value should be represented as a tuple (re,im) or in canonical form re +imi</param>
        /// <param name="scale">If specified, the presented scale of each component</param>
		public string Format(bool tupelize = false, int? scale = null)
		{
			var x = (scale != null ? MathF.Round(re,scale.Value) : re).ToString();
			var y = (scale != null ? MathF.Round(im,scale.Value) : im).ToString();
			return tupelize ? $"({x}, {y})" : $"{x} + {y}i";					
		}
		
		/// <summary>
		/// Partitions the complex number into real and imanginary components
		/// </summary>
		/// <param name="re">The real component</param>
		/// <param name="im">The imaginary component</param>
		[MethodImpl(Inline)]
		public void Deconstruct(out float re, out float im)
		{
			re = this.re;
			im = this.im;
		}		

		public override string ToString() 
			=>  Format(false, 4);

        public override int GetHashCode()
            => $"{re}{im}".GetHashCode();

        public override bool Equals(object src)
            => src is ComplexF32 c ? (c == this) : false;

        [MethodImpl(Inline)]
        public bool Equals(ComplexF32 src)
            => this == src;
    }

}
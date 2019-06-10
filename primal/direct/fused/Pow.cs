//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    
    using static zfunc;

    partial class math
    {
        public static Span<sbyte> pow(Span<sbyte> b, ReadOnlySpan<sbyte> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<byte> pow(Span<byte> b, ReadOnlySpan<byte> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<short> pow(Span<short> b, ReadOnlySpan<short> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<ushort> pow(Span<ushort> b, ReadOnlySpan<ushort> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<int> pow(Span<int> b, ReadOnlySpan<int> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<uint> pow(Span<uint> b, ReadOnlySpan<uint> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<long> pow(Span<long> b, ReadOnlySpan<long> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<ulong> pow(Span<ulong> b, ReadOnlySpan<ulong> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<float> pow(Span<float> b, ReadOnlySpan<float> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<double> pow(Span<double> b, ReadOnlySpan<double> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<sbyte> pow(Span<sbyte> b, sbyte exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<byte> pow(Span<byte> b, byte exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<short> pow(Span<short> b, short exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<ushort> pow(Span<ushort> b, ushort exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<int> pow(Span<int> b, int exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<uint> pow(Span<uint> b, uint exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<long> pow(Span<long> b, long exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<ulong> pow(Span<ulong> b, ulong exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<float> pow(Span<float> b, float exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<double> pow(Span<double> b, double exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

    }
}
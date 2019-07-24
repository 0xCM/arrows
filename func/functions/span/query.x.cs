//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;
    using static As;

    partial class xfunc
    {

        /// <summary>
        /// Determines whether any elements of the source match the target
        /// </summary>
        /// <param name="src">The source values</param>
        /// <param name="target">The target value to match</param>
        /// <typeparam name="T">The value type</typeparam>
        public static bool Contains<T>(this ReadOnlySpan<T> src, T target)        
            where T : struct
        {
            var enumerator = src.GetEnumerator();
            while(enumerator.MoveNext())
                if(enumerator.Current.Equals(target))
                    return true;
            return false;
        }

        [MethodImpl(Inline)]
        public static bool Contains<T>(this Span<T> src, T match)        
            where T : struct
                => src.ReadOnly().Contains(match);

        /// <summary>
        /// Returns a reference to the first element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T First<T>(this Span<T> src)
        {
            if(src.IsEmpty)
                throw Errors.EmptySourceSpan();
            return ref src[0];
        }

        /// <summary>
        /// Returns a reference to the last element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T Last<T>(this Span<T> src)
        {
            if(src.IsEmpty)
                throw Errors.EmptySourceSpan();
            return ref src[src.Length - 1];
        }

        /// <summary>
        /// Returns a readonly reference to the first element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T First<T>(this ReadOnlySpan<T> src)
        {
            if(src.IsEmpty)
                throw Errors.EmptySourceSpan();
            return ref src[0];
        }

        /// <summary>
        /// Returns a readonly reference to the last element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T Last<T>(this ReadOnlySpan<T> src)
        {
            if(src.IsEmpty)
                throw Errors.EmptySourceSpan();
            return ref src[src.Length - 1];
        }

        /// <summary>
        /// Determines whether any elements of a span satisfy a supplied predicate
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The element type</typeparam>
        public static bool Any<T>(this ReadOnlySpan<T> src, Func<T,bool> f)
        {
            var it = src.GetEnumerator();
            while(it.MoveNext())
                if(f(it.Current))
                    return true;
            return false;
        }

        [MethodImpl(Inline)]
        public static bool Any<T>(this Span<T> src, Func<T,bool> f)
             where T : struct
                => src.ReadOnly().Any(f);

        /// <summary>
        /// Determines whether all of the elements of a source span satisfy a supplied predicate
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The element type</typeparam>
        public static bool All<T>(this ReadOnlySpan<T> src, Func<T,bool> f)
             where T : struct
        {
            var it = src.GetEnumerator();
            while(it.MoveNext())
                if(!f(it.Current))
                    return false;
            return true;
        }

        /// <summary>
        /// Determines whether all of the elements of a source span satisfy a supplied predicate
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static bool All<T>(this Span<T> src, Func<T,bool> f)
             where T : struct
                => src.ReadOnly().All(f);

    }

}
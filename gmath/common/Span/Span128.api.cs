//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    using System.Diagnostics;
    
    using static zcore;
    using static inxfunc;
    using static Span128;

    public static class Span128
    {
        /// <summary>
        /// Calculates the number of cells that comprise a block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklength<T>()
            where T : struct, IEquatable<T>        
                => Span128<T>.BlockLength;

        /// <summary>
        /// Calculates the number of bytes required to represent a block constituent
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int cellsize<T>()
            where T : struct, IEquatable<T>        
                => Span128<T>.CellSize;

        /// <summary>
        /// Calculates the number of bytes requred to represent a block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocksize<T>()
            where T : struct, IEquatable<T>        
                => Span128<T>.BlockSize;

        /// <summary>
        /// Calculates the number of bytes required to represent a specified
        /// number of blocks
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int datasize<T>(int blocks)
            where T : struct, IEquatable<T>        
                => blocksize<T>()*blocks; 

        [MethodImpl(Inline)]
        public static int datasize<T>(Span<T> src)
            where T : struct, IEquatable<T>        
            => src.Length * cellsize<T>();


        [MethodImpl(Inline)]
        public static int blockcount<T>(in Span<T> src)
            where T : struct, IEquatable<T>  
                =>  src.Length / blocklength<T>();                
            
        [MethodImpl(Inline)]
        public static int blockoffset<T>(int blockIndex)
            where T : struct, IEquatable<T>        
                => blocksize<T>() * blockIndex;

        [MethodImpl(Inline)]
        public static int align<T>(int datasize)
            where T : struct, IEquatable<T>        
        {
            var remainder = datasize % blocksize<T>();
            if(remainder == 0)
                return datasize;
            else
                return (datasize - remainder) + blocksize<T>();
        }
                    
        /// <summary>
        /// Determines whether data of a specified length can be evenly covered by blocks
        /// </summary>
        /// <param name="datasize">The length, in bytes, of the source data</param>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static bool aligned<T>(int datasize)
            where T : struct, IEquatable<T>        
            => datasize % blocksize<T>() == 0;

        [MethodImpl(Inline)]
        public static bool aligned<T>(in T[] src)
            where T : struct, IEquatable<T>        
                => src.Length % blocklength<T>() == 0;

        [MethodImpl(Inline)]
        public static bool aligned<T>(in Span<T> src)
            where T : struct, IEquatable<T>        
                => src.Length % blocklength<T>() == 0;

        [MethodImpl(Inline)]
        public static bool aligned<T>(in ReadOnlySpan<T> src)
            where T : struct, IEquatable<T>        
                => src.Length % blocklength<T>() == 0;

        [MethodImpl(Inline)]
        public static Span128<T> load<T>(Span<T> src)
            where T : struct, IEquatable<T>
                => new Span128<T>(src.Slice(0, align<T>(src.Length * cellsize<T>())));

        [MethodImpl(Inline)]
        public static Span128<T> load<T>(ReadOnlySpan<T> src)
            where T : struct, IEquatable<T>
                => new Span128<T>(src.Slice(0, align<T>(src.Length * cellsize<T>())));

        [MethodImpl(Inline)]
        public static Span128<T> load<T>(T[] src)
            where T : struct, IEquatable<T>
        {
            return new Span128<T>(src);
        }

        [MethodImpl(Inline)]
        public static Span128<T> single<T>(params T[] src)
            where T : struct, IEquatable<T>
                => new Span128<T>(src);
    }
}
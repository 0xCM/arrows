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
    
    using static zfunc;
    using static nfunc;

    /// <summary>
    /// Defines Modular matrix operations
    /// </summary>
    /// <remarks>
    /// Algorithms taken from SSJ; see LICENSE file in this project root
    /// </remarks>
    public static class MatMod
    {
        /// <summary>
        /// Computes the vector u = As (mod m)
        /// </summary>
        /// <param name="A">The matrix operand</param>
        /// <param name="v">The vector to be transformed</param>
        /// <param name="u">The transformed vector</param>
        /// <param name="m">The modulus</param>
        public static ref Vector<N,uint> MVMul<N>(in Matrix<N,uint> A, in Vector<N,uint> v, uint m, ref Vector<N,uint> u) 
            where N : ITypeNat, new()
        {
            //var x = new uint[v.Length];
            var x = Vector.Alloc<N,uint>();

            for(var i = 0; i < u.Length; ++i) 
            for(int j = 0; j < v.Length; j++)
                x[i] = Mod.fma(A[i,j], v[j], x[i], m);

            for (var i = 0; i < u.Length; ++i)
                u[i] = x[i];
            return ref u;
        }

        /// <summary>
        /// Computes the vector v = As (mod m)
        /// </summary>
        /// <param name="A">The matrix operand</param>
        /// <param name="v">The vector to be transformed</param>
        /// <param name="u">The transformed vector</param>
        /// <param name="m">The modulus</param>
        public static ref Vector<N,ulong> MVMul<N>(in Matrix<N,ulong> A, in Vector<N,ulong> v, ulong m, ref Vector<N,ulong> u) 
            where N : ITypeNat, new()
        {
            //var x = new ulong[v.Length];
            var rc = A.RowCount;
            var cc = A.ColCount;
            var temp = Vector.Alloc<N,ulong>();
            for(var i = 0; i < rc;  ++i) 
            for(var j = 0; j < cc; j++)
                temp[i] = Mod.fma(A[i,j], v[j], temp[i], m);

            for (var i = 0; i < u.Length; ++i)
                u[i] = temp[i];
            
            return ref u;
        }

        /// <summary>
        /// Computes the vector u = Av (mod m)
        /// </summary>
        /// <param name="A">The matrix operand</param>
        /// <param name="v">The vector to be transformed</param>
        /// <param name="u">The transformed vector</param>
        /// <param name="m">The modulus</param>
        public static ref Vector<N,double> MVMul<N>(in Matrix<N,double> A, in Vector<N,double> v, double m, ref Vector<N,double> u) 
            where N : ITypeNat, new()
        {
            var x = new double[u.Length];
            for (var i = 0; i < u.Length;  ++i) 
            {
                for(var j = 0; j < v.Length; j++)
                    x[i] = Mod.fma(A[i,j], v[j], x[i], m);
            }

            for (var i = 0; i < u.Length;  ++i)
                u[i] = x[i];
            
            return ref u;
        }

        /// <summary>
        /// Computes the product of square matricies C = AB (mod m)
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The target matrix</param>
        /// <param name="m">The modulus</param>
        /// <typeparam name="N">The matrix order type</typeparam>
        public static ref Matrix<N,uint> Mul<N>(in Matrix<N,uint> A, in Matrix<N,uint> B, uint m, ref Matrix<N,uint> C) 
            where N: ITypeNat, new()
        {
            var rc = C.RowCount;
            var cc = C.ColCount;
            var W = Matrix.Alloc<N,uint>();
            var v = Vector.Alloc<N,uint>();

            for (var i = 0; i < cc;  ++i) 
            {
                for (var j = 0; j < rc;  ++j)
                    v[j] = B[j,i];
                
                MVMul(A, v, m, ref v);
                
                for (var j = 0; j < rc;  ++j)
                    W[j,i] = v[j];
            }

            for (var i = 0; i < rc;  ++i) 
            for (var j = 0; j < cc;  ++j)
                C[i,j] = W[i,j];
            
            return ref C;
        }

        /// <summary>
        /// Computes the matrix product C = AB (mod m)
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The result matrix</param>
        /// <param name="m">The modulus</param>
        public static ref Matrix<N,ulong> Mul<N>(in Matrix<N,ulong> A, in Matrix<N,ulong> B, ulong m, ref Matrix<N,ulong> C) 
            where N: ITypeNat, new()
        {
            var rc = C.RowCount;
            var cc = C.ColCount;
            
            var W = Matrix.Alloc<N,ulong>();
            var v = Vector.Alloc<N,ulong>();

            for (var i = 0; i < cc;  ++i) 
            {
                for (var j = 0; j < rc;  ++j)
                    v[j] = B[j,i];
                
                MVMul(A, v, m, ref v);
                
                for (var j = 0; j < rc;  ++j)
                    W[j,i] = v[j];
            }

            for (var i = 0; i < rc;  ++i) 
            for (var j = 0; j < cc;  ++j)
                C[i,j] = W[i,j];
            return ref C;
        }

        /// <summary>
        /// Computes the matrix product C = AB (mod m)
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The result matrix</param>
        /// <param name="m">The modulus</param>
        public static ref Matrix<N,double> Mul<N>(in Matrix<N,double> A, in Matrix<N,double> B, double m, ref Matrix<N,double> C) 
            where N : ITypeNat, new()
        {
            int r = C.RowCount;
            int c = B.ColCount;
            var V = Vector.Alloc<N,double>();
            var W = Matrix.Alloc<N,double>();
            for (var i = 0; i < c;  ++i) 
            {
                for (var j = 0; j < r;  ++j)
                    V[j] = B[j,i];

                MVMul<N>(A, V, m, ref V);
            
                for (var j = 0; j < r; ++j)
                    W[j,i] = V[j];
            }

            for (var i = 0; i < r;  ++i) 
            for (var j = 0; j < c;  ++j)
                C[i,j] = W[i,j];          

            return ref C;  
        }

        /// <summary>
        /// Computes B = A^e (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="e">The exponent</param>
        /// <param name="m">The modulus</param>
        /// <param name="B">The result matrix</param>
        public static ref Matrix<N,uint> Pow<N>(in Matrix<N,uint> A, uint e, uint m, ref Matrix<N,uint> B) 
            where N : ITypeNat, new()
        {
            
            var length = A.RowCount;
            var W = Matrix.Alloc<N,uint>();

            /* initialize: W = A; B = I */
            for (var i = 0; i < length; i++) 
            for (var j = 0; j < length;  ++j)  
            {
                W[i,j] = A[i,j];
                B[i,j] = 0;
            }

            for (var j = 0; j < length;  ++j)
                B[j,j] = 1;

            /* Compute B = A^c mod m using the binary decomp. of c */
            var exp = e;
            while (exp > 0) 
            {
                if ((exp % 2)==1)
                    Mul (W, B, m, ref B);
            
                Mul (W, W, m, ref W);
                exp /= 2;
            }
            return ref B;
        }

        /// <summary>
        /// Computes B = A^e (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="e">The exponent</param>
        /// <param name="m">The modulus</param>
        /// <param name="B">The result matrix</param>
        public static ref Matrix<N,ulong> Pow<N>(in Matrix<N,ulong> A, uint e, ulong m, ref Matrix<N,ulong> B) 
            where N : ITypeNat, new()
        {
            
            var length = A.RowCount;
            var W = Matrix.Alloc<N,ulong>();

            /* initialize: W = A; B = I */
            for (var i = 0; i < length; i++) 
            for (var j = 0; j < length; ++j)  
            {
                W[i,j] = A[i,j];
                B[i,j] = 0;
            }

            for (var j = 0; j < length;  ++j)
                B[j,j] = 1;

            /* Compute B = A^c mod m using the binary decomp. of c */
            var exp = e;
            while (exp > 0) 
            {
                if ((exp % 2)==1)
                    Mul (W, B, m, ref B);
            
                Mul (W, W, m, ref W);
                exp /= 2;
            }
            return ref B;
        }

        /// <summary>
        /// Computes B = A^c (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="e">The exponent</param>
        /// <param name="m">The modulus</param>
        /// <param name="B">The result matrix</param>
        public static ref Matrix<N,double> Pow<N>(in Matrix<N,double> A, uint e, double m, ref Matrix<N,double> B) 
            where N : ITypeNat, new()
        {
            int i, j;
            var n = e;
            var s = A.RowCount;
            var W = Matrix.Alloc<N,double>();

            /* initialize: W = A; B = I */
            for (i = 0; i < s; i++) 
            {
                for (j = 0; j < s;  ++j)  
                {
                    W[i,j] = A[i,j];
                    B[i,j] = 0.0;
                }
            }

            for (j = 0; j < s;  ++j)
                B[j,j] = 1.0;

            /* Compute B = A^c mod m using the binary decomp. of c */
            while (n > 0) 
            {
                if ((n % 2)==1)
                    Mul<N>(W, B, m, ref B);
            
                Mul<N>(W, W,m, ref W);
                n /= 2;
            }
            return ref B;
        }

        /// <summary>
        /// Computes B = A^{2^e} (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="e">The base-2 log of the exponent</param>
        /// <param name="m">The modulus</param>
        /// <param name="B">The result matrix</param>
        public static ref Matrix<N,uint> Pow2<N>(in Matrix<N,uint> A, uint e, uint m, ref Matrix<N,uint> B) 
            where N : ITypeNat, new()
        {            
            /* initialize: B = A */
            var n = A.RowCount;
            if (A != B) 
            {
                for (var i = 0; i < n; i++) 
                for (var j = 0; j < n; ++j)
                    B[i,j] = A[i,j];
            }

            /* Compute B = A^{2^e} */
            for (var i = 0; i < e; i++)
                Mul(B, B, m, ref B);
        
            return ref B;
        }

        /// <summary>
        /// Computes B = A^{2^e} (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="e">The base-2 log of the exponent</param>
        /// <param name="m">The modulus</param>
        /// <param name="B">The result matrix</param>
        public static ref Matrix<N,ulong> Pow2<N>(in Matrix<N,ulong> A, uint e, ulong m, ref Matrix<N,ulong> B) 
            where N : ITypeNat, new()
        {            
            /* initialize: B = A */
            var n = A.RowCount;
            if (A != B) 
            {
                for (var i = 0; i < n; i++) 
                for (var j = 0; j < n; ++j)
                    B[i,j] = A[i,j];
            }

            /* Compute B = A^{2^e} */
            for (var i = 0ul; i < e; i++)
                Mul(B, B, m, ref B);

            return ref B;
        }

        /// <summary>
        /// Computes B = A^{2^e} (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="e">The base-2 log of the exponent</param>
        /// <param name="m">The modulus</param>
        /// <param name="B">The result matrix</param>
        public static ref Matrix<N,double> Pow2<N>(in Matrix<N,double> A, uint e, double m, ref Matrix<N,double> B) 
            where N : ITypeNat, new()
        {
            /* initialize: B = A */
            var n = A.RowCount;
            if (A != B) 
            {
                for (var i = 0; i < n; i++) 
                for (var j = 0; j < n; ++j)
                    B[i,j] = A[i,j];
            }

            /* Compute B = A^{2^e} */
            for (var i = 0; i < e; i++)
                Mul<N>(B, B, m, ref B);
            return ref B;
        }
    }
}
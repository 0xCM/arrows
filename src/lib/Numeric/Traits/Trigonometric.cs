//-----------------------------------------------------------------------------
// CopyrighS   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Traits
    {
        /// <summary>
        /// Characterizes trigonometric operations over a type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Trigonmetric<T> : Operational<T>
        {
            T sin(T x);   

            T sinh(T x);   

            T asin(T x);   

            T asinh(T x);   

            T cos(T x);   

            T cosh(T x);   

            T acos(T x);   
        
            T acosh(T x);   

            T tan(T x);

            T tanh(T x);

            T atan(T x);

            T atanh(T x);        
        }
    }

    partial class Structure
    {
        /// <summary>
        /// Characterizes a trigonometric structure
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface Trigonmetric<S,T> : Structural<S,T>
            where S : Trigonmetric<S,T>, new()
        {
            S sin();   

            S sinh();   

            S asin();   

            S asinh();   

            S cos();   

            S cosh();   

            S acos();   
        
            S acosh();   

            S tan();

            S tanh();

            S atan();

            S atanh();
        
        }
    }
}
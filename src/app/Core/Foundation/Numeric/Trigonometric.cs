//-----------------------------------------------------------------------------
// CopyrighS   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    partial class Traits
    {
        public interface Trigonmetric<T>
        {
            T cos(T x);   

            T cosh(T x);   

            T acos(T x);   
        
            T acosh(T x);   

            T sin(T x);   

            T sinh(T x);   

            T asin(T x);   

            T asinh(T x);   

            T tan(T x);

            T tanh(T x);

            T atan(T x);

            T atanh(T x);
        
        }

    }

    partial class Struct
    {
        public interface Trigonmetric<S,T>
            where S : Trigonmetric<S,T>, new()
        {
            S cos();   

            S cosh();   

            S acos();   
        
            S acosh();   

            S sin();   

            S sinh();   

            S asin();   

            S asinh();   

            S tan();

            S tanh();

            S atan();

            S atanh();
        
        }
    }
}
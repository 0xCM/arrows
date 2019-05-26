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
        #region acos

        [MethodImpl(Inline)]   
        public static float acos(float x)
            => MathF.Acos(x);

        [MethodImpl(Inline)]   
        public static double acos(double x)
            => Math.Acos(x);


        #endregion 

        #region acosh

        [MethodImpl(Inline)]   
        public static float acosh(float x)
            => MathF.Acosh(x);

        [MethodImpl(Inline)]   
        public static double acosh(double x)
            => Math.Acosh(x);

        #endregion

        #region asin

        [MethodImpl(Inline)]   
        public static float asin(float x)
            => MathF.Asin(x);

        [MethodImpl(Inline)]   
        public static double asin(double x)
            => Math.Asin(x);

        #endregion

        #region asinh

        [MethodImpl(Inline)]   
        public static float asinh(float x)
            => MathF.Asinh(x);

  
        [MethodImpl(Inline)]   
        public static double asinh(double x)
            => Math.Asinh(x);

        #endregion

        #region atan

        [MethodImpl(Inline)]   
        public static float atan(float x)
            => MathF.Atan(x);

        [MethodImpl(Inline)]   
        public static double atan(double x)
            => Math.Atan(x);

        #endregion

        #region atanh

        [MethodImpl(Inline)]   
        public static float atanh(float x)
            => MathF.Atanh(x);

        [MethodImpl(Inline)]   
        public static double atanh(double x)
            => Math.Atanh(x);

        #endregion

        #region cos

        [MethodImpl(Inline)]   
        public static float cos(float x)
            => MathF.Cos(x);

        [MethodImpl(Inline)]   
        public static double cos(double x)
            => Math.Cos(x);

        #endregion

        #region cosh

        [MethodImpl(Inline)]   
        public static float cosh(float x)
            => MathF.Cosh(x);

        [MethodImpl(Inline)]   
        public static double cosh(double x)
            => Math.Cosh(x);        
 
        #endregion

        #region sin

        [MethodImpl(Inline)]   
        public static float sin(float x)
            => MathF.Sin(x);

        [MethodImpl(Inline)]   
        public static double sin(double x)
            => Math.Sin(x);

        #endregion

        #region sinh

        [MethodImpl(Inline)]   
        public static float sinh(float x)
            => MathF.Sinh(x);

        [MethodImpl(Inline)]   
        public static double sinh(double x)
            => Math.Sinh(x);
        
        #endregion

        #region tan

        [MethodImpl(Inline)]   
        public static float tan(float x)
            => MathF.Tan(x);

        [MethodImpl(Inline)]   
        public static double tan(double x)
            => Math.Tan(x);

        #endregion

        #region tanh

        [MethodImpl(Inline)]   
        public static float tanh(float x)
            => MathF.Tanh(x);
  
        [MethodImpl(Inline)]   
        public static double tanh(double x)
            => Math.Tanh(x);
 
        #endregion 
    }
}
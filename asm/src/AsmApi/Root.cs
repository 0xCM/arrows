//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static partial class asm
    {
        /// <summary>
        /// Defines a call expression for a 1-argument function
        /// </summary>
        /// <param name="f">The function identifier</param>
        /// <param name="arg0">The argument value</param>
        /// <param name="r">A sample return value, if desired, to assist type inference</param>
        /// <typeparam name="A0">The argument type</typeparam>
        /// <typeparam name="R">The return type</typeparam>
        public static Call<A0,R> call<A0,R>(string f, A0 arg0, R r = default)
            where A0 : struct
            where R : struct
        {

            return new Call<A0, R>(f, arg0);
        }

        /// <summary>
        /// Defines a call expression for a 2-argument function
        /// </summary>
        /// <param name="f">The function identifier</param>
        /// <param name="arg0">The value of the fist argument</param>
        /// <param name="arg1">The value of the second argument</param>
        /// <param name="r">A sample return value, if desired, to assist type inference</param>
        /// <typeparam name="A0">The first argument type</typeparam>
        /// <typeparam name="A0">The second argument type</typeparam>
        /// <typeparam name="R">The return type</typeparam>
        public static Call<A0,A1,R> call<A0,A1,R>(string f, A0 arg0, A1 arg1, R r = default)
            where A0 : struct
            where A1 : struct
            where R : struct
        {

               return new Call<A0,A1, R>(f, arg0, arg1);
        }

        /// <summary>
        /// Defines a call expression for a 3-argument function
        /// </summary>
        /// <param name="f">The function identifier</param>
        /// <param name="arg0">The value of the fist argument</param>
        /// <param name="arg1">The value of the second argument</param>
        /// <param name="arg2">The value of the third argument</param>
        /// <param name="r">A sample return value, if desired, to assist type inference</param>
        /// <typeparam name="A0">The first argument type</typeparam>
        /// <typeparam name="A0">The second argument type</typeparam>
        /// <typeparam name="A0">The third argument type</typeparam>
        /// <typeparam name="R">The return type</typeparam>
        public static Call<A0,A1,A2,R> call<A0,A1,A2,R>(string f, A0 arg0, A1 arg1, A2 arg2, R r = default)
            where A0 : struct
            where A1 : struct
            where A2 : struct
            where R : struct
        {

               return new Call<A0, A1, A2, R>(f, arg0, arg1,arg2);
        }


    }


}
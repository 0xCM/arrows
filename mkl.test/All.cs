//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Diagnostics;    
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static nfunc;
    using static Examples;


    static class Examples
    {
        const string Intro = "beginning";
        const string Finale = "finished";
        
        public static string intro([CallerMemberName] string method = null)
        {
            cyan($"{method} => {Intro}");
            cyan(new string('-',80));
            return method;
        }

        public static string varintro(string variation, [CallerMemberName] string method = null)
        {
            var variant = $"{method}[{variation}]";
            print();
            cyan($"{variant} => {Intro}");
            cyan(new string('-',80));
            return variant;
        }


        [MethodImpl(Inline)]
        public static double MaxEntry<M,N>(this Span<M,N,double> src)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => src.Reduce(Math.Max);

        [MethodImpl(Inline)]
        public static int EntryPadWidth<M,N>(this Span<M,N,double> src)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => ((long)src.Reduce(Math.Max)).ToDeciDigits().Length;


        public static void finale(string title, object value, Duration time, [CallerMemberName] string method = null)
        {
            magenta($"Output {title}", value);
            cyan($"{method} => {Finale} | Runtime = {format(time)}");
        }

        [MethodImpl(Inline)]
        public static void finale(string title, object value, Stopwatch sw, [CallerMemberName] string method = null)
            => finale(title, value, snapshot(sw), method);

        public static void output(object output)
            => magenta(" Actual", output);

        public static void expected(object expect)
            => magenta(" Expect", expect);


        public static void conclude(Duration time, [CallerMemberName] string method = null)    
        {
            
            cyan($"Runtime", format(time));
            print();
        }

        public static void input(object input)
            => cyan("  Input", input);

        public static void input(string title, object input)
            => cyan($"Input {title}", input);

        [MethodImpl(Inline)]
        public static Stopwatch input(string firstTitle, object firstValue, string secondTitle, object secondValue)
        {
            input(firstTitle, firstValue);
            print();
            input(secondTitle, secondValue);
            print();
            return stopwatch();
        }

    
         public static string format(Duration time)
         {  
             return $"{time.FractionalMs} ms";
         }

        public static void output(string title, object value, Duration? time = null)
        {
            magenta(title, value);
            if(time != null)            
                magenta($"Runtime", format(time.Value));
        }

    }

    public static class CBLASX
    {

        [MethodImpl(Inline)]
        static Stopwatch start()
            => stopwatch();

        public static void sasum()
        {
            var method = intro();

            var n = 10;
            var incx = 1;
            var x = floats(1.0,  -2.0,  3.0,  4.0,  -5.0,  6.0,  -7.0,  8.0,  -9.0,  10.0);
            input(x.FormatAsVector());

            var sw = stopwatch();
            var result = CBLAS.cblas_sasum(n, ref x[0], incx);
            var time = snapshot(sw);            

            output(result);            
            conclude(time);                                    
        }

        public static void dzasum()
        {
            var method = intro();
            var n = 4;
            var incx = 1;
            var x = doubles(1.2, 2.5, 3.0, 1.7, 4.0, 0.53, -5.5, -0.29).ToComplex();            
            input(x.FormatAsVector());
            
            var expect = x.Map(z => Math.Abs(z.re) + Math.Abs(z.im)).Reduce((a,b) => a + b);
            expected(expect);


            var time = start();
            var result = CBLAS.cblas_dzasum(n, ref x[0], incx);            
            output("result", result, snapshot(time));

        }

        public static void saxpy()
        {
            var method = intro();
            var n = 5;
            var incx = 1;
            var incy = 1;
            var alpha = .5f;
            var x = floats(1, 2, 3, 4, 5);
            var y = floats(.5, .5, .5, .5, .5);
            input($"alpha={alpha}, x = {x.FormatAsVector()}, y = {y.FormatAsVector()}");

            var sw = stopwatch();
            CBLAS.cblas_saxpy(n, alpha, ref x[0], incx, ref y[0], incy);
            var time = snapshot(sw);            

            output(y.FormatAsVector());
            conclude(time);                                    
        }

        static void gemm<M,N>()
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var m = nati<M>();
            var n = nati<N>();
            var method = varintro($"{m}x{n} * {n}x{m} = {m}x{m}");
            var count = m*n;
            
            var srcA = span<double>(count);
            for(var i=1; i<= count; i++)
                srcA[i-1] = i;
            var a = NatSpan.load<M,N,double>(ref srcA[0]);

            var srcB = span<double>(m*n);
            for(var i=1; i<= count; i++)
                srcB[i-1] = i;
            var b = NatSpan.load<N,M,double>(ref srcB[0]);

            var timer = input(
                nameof(a), a.Format(zpad: a.EntryPadWidth()), 
                nameof(b), b.Format(zpad: b.EntryPadWidth())
                );            
            var c = mkl.gemm(a,b);            
            var time = snapshot(timer);   
        
            finale(nameof(c), c.Format(zpad: c.EntryPadWidth()), timer, method);
        }
        
        public static void gemm()
        {
            gemm<N3,N4>();
            gemm<N5,N7>();
            gemm<N10,N10>();
            gemm<N16,N16>();
            gemm<N17,N17>();

        }
        
    }


}
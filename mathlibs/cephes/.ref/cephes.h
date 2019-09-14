#pragma once

int airy(double x, double* ai, double* aip, double* bi, double* bip);

double exp (double x);
double erfc(double a);
static double erfce(double x);
double erf(double x);
double exp2(double x);
double expx2 (double b, int e);

double fabs(double x);
double floor(double x);

double gamma (double x);

extern int isnan ( double );
extern int isfinite ( double );

double log (double x);
double ldexp ( double, int );

double polevl(double x, double coef[], int N);
double p1evl (double x, double coef[], int N);
double pow (double b, double p);

double sin(double x);
double sqrt (double x);

double zetac(double x);



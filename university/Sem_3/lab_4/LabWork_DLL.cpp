#include "stdafx.h"
#include <stdio.h>
#include <stdlib.h>

__declspec(dllexport) double InitInfo(LPWSTR input)
{
    double result = 0;
    result = wcstod(input, NULL);
    return result;
}

__declspec(dllexport) void Change(double *res, double delta)
{
    *res=*res+delta;
}

__declspec(dllexport) void Warning(double balance)
{
    if (balance < 0.0) printf("\nYour cash is negative\n");
}

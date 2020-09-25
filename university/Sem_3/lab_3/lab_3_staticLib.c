#include <stdio.h>
#include <stdlib.h>
#include <string.h>

double Init(char* input)
{
    double result = 0;
    result = strtod(input, NULL);
    return result;
}

void Change(double *result, double delta)
{
    *result = *result + delta;
}

void Warning(double balance)
{
    if (balance < 0.0)
        printf("\nYour cash is negative\n");
}

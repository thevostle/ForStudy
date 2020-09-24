#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(int args, char* argv[])
{
    double* vars = (double*)malloc((args-1)*sizeof(double));
    double sum = 0.0;

    for(int i = 0; i < args-1; i++)
    {
        if(argv[i+1] != NULL)
        {
            vars[i] = strtod(argv[i+1], NULL);
            sum += vars[i];
        }
    }

    printf("%1f\n", sum);

    return 0;
}

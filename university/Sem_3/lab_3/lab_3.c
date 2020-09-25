#include <stdio.h>
#include <stdlib.h>
#include <string.h>

double Init(char* input);
void Change(double *result, double delta);
void Warning(double balance);

int main(int argc, char* argv[])
{
    double* oper = NULL;
    int j = 0;
    char* name = malloc(sizeof(char)*(strlen(argv[1])+1));
    strcpy(name, argv[1]);

    for (int i = 2; i < argc; i++)
    {
        if (Init(argv[i]) != 0.0)
        {
            oper = realloc(oper, (++j)*sizeof(double));
            oper[j-1] = Init(argv[i]);
        }
    }

    double balance = 0.0;
    for (int i = 0; i < j; i++)
        Change(&balance, oper[i]);

    printf("%s, your cash is %1f", name, balance);

    Warning(balance);

    return 0;
}

#include <stdio.h>
#include <stdlib.h>

char str[10] = "Hello!";

void PrintReverseString(char *c);

int main()
{
    printf("Origin: %s\n", str);
    printf("Reversed: ");
    PrintReverseString(str);

    printf("\n");

    return 0;
}

void PrintReverseString(char *strInput)
{
    int l = strlen(strInput);
    for (int i = l - 1; i >= 0; i--)
        printf("%c", strInput[i]);
}

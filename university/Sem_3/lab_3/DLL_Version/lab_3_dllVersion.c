#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <windows.h>

typedef double(__stdcall* InitInfo_ptr)(char*);
typedef void (__stdcall* Change_ptr)(double*, double);
typedef void (__stdcall* Warning_ptr)(double);

int main(int argc, char* argv[])
{
    InitInfo_ptr InitInfo_ptr_f;
    Change_ptr Change_ptr_f;
    Warning_ptr Warning_ptr_f;

    HINSTANCE myDLL = LoadLibrary("lab_3_dynamicLib.dll");
    if(myDLL==NULL)
    {
        printf("Cannot attach DLL!");
        return 0;
    }

    InitInfo_ptr_f=(InitInfo_ptr)GetProcAddress(myDLL, "InitInfo");
    Change_ptr_f=(Change_ptr)GetProcAddress(myDLL, "Change");
    Warning_ptr_f=(Warning_ptr)GetProcAddress(myDLL, "Warning");

    double* oper=NULL;
    int j=0;

    char* name = malloc(sizeof(char)*(strlen(argv[1])+1));
    strcpy(name, argv[1]);

    for(int i=2; i<argc;i++)
    {
        if(InitInfo_ptr_f(argv[i])!=0.0) {
           oper=realloc(oper, (++j)*sizeof(double));
           oper[j-1]=InitInfo_ptr_f(argv[i]);
        }
    }

    double balance = 0.0;
    for(int i=0; i<j; i++)
        Change_ptr_f(&balance, oper[i]);

    printf("%s, your cash is %1f",name,balance);
    Warning_ptr_f(balance);

    return 0;
}

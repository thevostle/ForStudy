#include "stdafx.h"
#include <stdio.h>
#include <stdlib.h>
#include <shellapi.h>
#include <windows.h>

extern "C" __declspec(dllexport) int EntryPoint();

__declspec(dllexport) double InitInfo(LPWSTR input);
__declspec(dllexport) void Change(double *res, double delta);
__declspec(dllexport) void Warning(double balance);

int EntryPoint()
{
    int argc = 0;
    LPWSTR* argv;

    double* operation = NULL;
    
    double balance = 0.0;
    LPWSTR userName = NULL;

    argv = CommandLineToArgvW(GetCommandLineW(), &argc);

    AllocConsole();
    freopen("CONOUT$", "w", stdout);

    if(argc <= 1) return 0;

    userName = (LPWSTR)malloc(sizeof(LPWCH)*(wcslen(argv[3])+1));
    wcscpy(userName, argv[3]);

    int j = 0;
    for(int idx = 3; idx < argc; idx++)
    {
        if(InitInfo(argv[idx])!=0.0) {
           operation = (double*) realloc(operation, (++j)*sizeof(double));
           operation[j-1] = InitInfo(argv[idx]);
        }
    }

    for(int i=0; i<j; i++)
        Change(&balance, operation[i]);

    wprintf(L"%s, your cash is %1f\n", userName, balance);
    Warning(balance);

	system("pause");
	FreeConsole();

    return 0;
}

BOOL APIENTRY DllMain( HMODULE hModule, DWORD  ul_reason_for_call, LPVOID lpReserved)
{
	switch (ul_reason_for_call)
	{
	    case DLL_PROCESS_ATTACH:
	    case DLL_THREAD_ATTACH:
	    case DLL_THREAD_DETACH:
	    case DLL_PROCESS_DETACH:
		    break;
	}
	return TRUE;
}

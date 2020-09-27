include "main.h"

double DLL_EXPORT InitInfo(char* input)
{
    double res=0;
    res=strtod(input, NULL);
    return res;
}

void DLL_EXPORT Change(double *res, double delta)
{
    *res=*res+delta;
}

void DLL_EXPORT Warning(double balance)
{
    if(balance < 0.0) printf("\nYour cash is negative\n");
}

extern "C" DLL_EXPORT BOOL APIENTRY DllMain(HINSTANCE hinstDLL, DWORD fdwReason, LPVOID lpvReserved)
{
    switch (fdwReason)
    {
        case DLL_PROCESS_ATTACH:
            // attach to process
            // return FALSE to fail DLL load
            break;

        case DLL_PROCESS_DETACH:
            // detach from process
            break;

        case DLL_THREAD_ATTACH:
            // attach to thread
            break;

        case DLL_THREAD_DETACH:
            // detach from thread
            break;
    }
    return TRUE;
}

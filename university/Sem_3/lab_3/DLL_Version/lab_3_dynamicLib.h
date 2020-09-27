#ifndef __MAIN_H__
#define __MAIN_H__

#include <windows.h>
#include<stdio.h>
#include<stdlib.h>
#include<string.h>

#ifdef BUILD_DLL
    #define DLL_EXPORT __declspec(dllexport)
#else
    #define DLL_EXPORT __declspec(dllimport)
#endif


#ifdef __cplusplus
extern "C"
{
#endif

double DLL_EXPORT InitInfo(char* input);
void DLL_EXPORT Change(double *res, double delta);
void DLL_EXPORT Warning(double balance);

#ifdef __cplusplus
}
#endif

#endif // __MAIN_H__

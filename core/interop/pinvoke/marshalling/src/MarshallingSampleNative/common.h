#pragma once

#ifdef WINDOWS

#include <windows.h>
#define DLL_EXPORT __declspec(dllexport)

#else // !WINDOWS

#ifndef STDMETHODCALLTYPE
#define STDMETHODCALLTYPE
#endif

#if __GNUC__ >= 4
#define DLL_EXPORT __attribute__ ((visibility ("default")))
#else
#define DLL_EXPORT
#endif

typedef int BOOL;
#define TRUE 1
#define FALSE 0

typedef short VARIANT_BOOL;
#define VARIANT_TRUE -1
#define VARIANT_FALSE 0

#endif

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

#endif

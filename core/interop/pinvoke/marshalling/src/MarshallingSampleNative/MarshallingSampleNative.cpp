#include <stdio.h>
#include "common.h"

extern "C" DLL_EXPORT void STDMETHODCALLTYPE Marshal_Int32_ByValue_In(/*[In]*/ int value)
{
    printf("in: %u", value);
}

extern "C" DLL_EXPORT void STDMETHODCALLTYPE Marshal_Int32_ByValue_Out(/*[Out]*/ int value)
{
    value++;
}

extern "C" DLL_EXPORT void STDMETHODCALLTYPE Marshal_Int32_ByValue_InOut(/*[In,Out]*/ int value)
{
    printf("in: %u", value);
    value++;
}

extern "C" DLL_EXPORT void STDMETHODCALLTYPE Marshal_Int32_ByRef_In(/*[In]*/ int * pValue)
{
    printf("in: %u", *pValue);
}

extern "C" DLL_EXPORT void STDMETHODCALLTYPE Marshal_Int32_ByRef_Out(/*[Out]*/ int * pValue)
{
    (*pValue)++;
}

extern "C" DLL_EXPORT void STDMETHODCALLTYPE Marshal_Int32_ByRef_InOut(/*[In,Out]*/ int * pValue)
{
    printf("in: %u", *pValue);
    (*pValue)++;
}

extern "C" DLL_EXPORT int STDMETHODCALLTYPE Marshal_Int32_Ret(int value)
{
    printf("in: %u", value);
    return value;
}

#include <stdio.h>
#include "common.h"

extern "C" DLL_EXPORT void STDMETHODCALLTYPE Marshal_Int32_ByValIn(/*[In]*/ int value)
{
    printf("%u", value);
}

extern "C" DLL_EXPORT void STDMETHODCALLTYPE Marshal_Int32_ByValOut(/*[Out]*/ int value)
{
    value++;
}

extern "C" DLL_EXPORT void STDMETHODCALLTYPE Marshal_Int32_ByValInOut(/*[In,Out]*/ int value)
{
    printf("%u", value);
    value++;
}

extern "C" DLL_EXPORT void STDMETHODCALLTYPE Marshal_Int32_ByRefIn(/*[In]*/ int * pValue)
{
    printf("%u", *pValue);
}

extern "C" DLL_EXPORT void STDMETHODCALLTYPE Marshal_Int32_ByRefOut(/*[Out]*/ int * pValue)
{
    (*pValue)++;
}

extern "C" DLL_EXPORT void STDMETHODCALLTYPE Marshal_Int32_ByRefInOut(/*[In,Out]*/ int * pValue)
{
    printf("%u", *pValue);
    (*pValue)++;
}

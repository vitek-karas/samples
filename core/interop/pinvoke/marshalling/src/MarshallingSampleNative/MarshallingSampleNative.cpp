#include <stdio.h>
#include "common.h"

extern "C" DLL_EXPORT void STDMETHODCALLTYPE PrintInt32Argument(/*[In]*/ int value)
{
    printf("%u", value);
}

extern "C" DLL_EXPORT void STDMETHODCALLTYPE PrintInt32ByRefArgument(/*[In]*/ int * pValue)
{
    printf("%u", *pValue);
}

extern "C" DLL_EXPORT void STDMETHODCALLTYPE GetInt32OutArgument(/*[Out]*/ int * pValue)
{
    *pValue = 9;
}

extern "C" DLL_EXPORT void STDMETHODCALLTYPE ModifyInt32InOutArgument(/*[In,Out]*/ int * pValue)
{
    printf("%u", *pValue);
    (*pValue)++;
}

extern "C" DLL_EXPORT int STDMETHODCALLTYPE ReturnInt32Argument(int value)
{
    printf("%u", value);
    return value;
}

#include <stdio.h>
#include "common.h"

extern "C" DLL_EXPORT void STDMETHODCALLTYPE AcceptInt32Argument(/*[In]*/ int value)
{
}

extern "C" DLL_EXPORT void STDMETHODCALLTYPE AcceptInt32ByRefArgument(/*[In]*/ int * pValue)
{
}

extern "C" DLL_EXPORT void STDMETHODCALLTYPE GetInt32OutArgument(/*[Out]*/ int * pValue)
{
    *pValue = 9;
}

extern "C" DLL_EXPORT void STDMETHODCALLTYPE ModifyInt32InOutArgument(/*[In,Out]*/ int * pValue)
{
    (*pValue)++;
}

extern "C" DLL_EXPORT int STDMETHODCALLTYPE ReturnInt32Argument(int value)
{
    return value;
}

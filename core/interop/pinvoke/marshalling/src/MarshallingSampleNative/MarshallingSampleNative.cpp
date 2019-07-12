#include <stdio.h>
#include "common.h"


// Int32 functions
extern "C" DLL_EXPORT int STDMETHODCALLTYPE AcceptInt32Argument(/*[In]*/ int value)
{
    return value;
}

extern "C" DLL_EXPORT int STDMETHODCALLTYPE AcceptInt32ByRefArgument(/*[In]*/ int * pValue)
{
    return *pValue;
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


// Boolean functions
extern "C" DLL_EXPORT int STDMETHODCALLTYPE AcceptBOOLArgument(BOOL value)
{
    return value ? 1 : 0;
}

extern "C" DLL_EXPORT int STDMETHODCALLTYPE AcceptBOOLByRefArgument(BOOL* pValue)
{
    return (*pValue) ? 1 : 0;
}

extern "C" DLL_EXPORT void STDMETHODCALLTYPE GetBOOLOutArgument(/*[Out]*/ BOOL* pValue)
{
    *pValue = FALSE;
}

extern "C" DLL_EXPORT void STDMETHODCALLTYPE ModifyBOOLInOutArgument(/*[In,Out]*/ BOOL* pValue)
{
    *pValue = !(*pValue);
}

extern "C" DLL_EXPORT BOOL STDMETHODCALLTYPE ReturnBOOLArgument(BOOL value)
{
    return value;
}

extern "C" DLL_EXPORT int STDMETHODCALLTYPE CountTrueValues(BOOL value1, bool value2, bool value3, VARIANT_BOOL value4)
{
    int count = 0;

    count += (value1 == TRUE) ? 1 : 0;
    count += (value2 == true) ? 1 : 0;
    count += (value3 == true) ? 1 : 0;
    count += (value4 == VARIANT_TRUE) ? 1 : 0;

    return count;
}

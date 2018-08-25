//-----------------------------------------------------------------------------
//
//    ** DO NOT EDIT THIS FILE! **
//    This file was generated by a tool
//    re-running the tool will overwrite this file.
//
//-----------------------------------------------------------------------------


#include "MathFuncs.h"
#include "MathFuncs_CMSIS_MatrixFuncs.h"

using namespace CMSIS;


HRESULT Library_MathFuncs_CMSIS_MatrixFuncs::MatrixSub_Nat___STATIC__VOID__U2__U2__SZARRAY_I4__U2__U2__SZARRAY_I4__BYREF_U2__BYREF_U2__SZARRAY_I4( CLR_RT_StackFrame& stack )
{
    TINYCLR_HEADER(); hr = S_OK;
    {
        UINT16 param0;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_UINT16( stack, 0, param0 ) );

        UINT16 param1;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_UINT16( stack, 1, param1 ) );

        CLR_RT_TypedArray_INT32 param2;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_INT32_ARRAY( stack, 2, param2 ) );

        UINT16 param3;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_UINT16( stack, 3, param3 ) );

        UINT16 param4;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_UINT16( stack, 4, param4 ) );

        CLR_RT_TypedArray_INT32 param5;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_INT32_ARRAY( stack, 5, param5 ) );

        UINT16 * param6;
        UINT8 heapblock6[CLR_RT_HEAP_BLOCK_SIZE];
        TINYCLR_CHECK_HRESULT( Interop_Marshal_UINT16_ByRef( stack, heapblock6, 6, param6 ) );

        UINT16 * param7;
        UINT8 heapblock7[CLR_RT_HEAP_BLOCK_SIZE];
        TINYCLR_CHECK_HRESULT( Interop_Marshal_UINT16_ByRef( stack, heapblock7, 7, param7 ) );

        CLR_RT_TypedArray_INT32 param8;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_INT32_ARRAY( stack, 8, param8 ) );

        MatrixFuncs::MatrixSub_Nat( param0, param1, param2, param3, param4, param5, param6, param7, param8, hr );
        TINYCLR_CHECK_HRESULT( hr );
        TINYCLR_CHECK_HRESULT( Interop_Marshal_StoreRef( stack, heapblock6, 6 ) );
        TINYCLR_CHECK_HRESULT( Interop_Marshal_StoreRef( stack, heapblock7, 7 ) );
    }
    TINYCLR_NOCLEANUP();
}

HRESULT Library_MathFuncs_CMSIS_MatrixFuncs::MatrixAdd_Nat___STATIC__VOID__U2__U2__SZARRAY_I4__U2__U2__SZARRAY_I4__BYREF_U2__BYREF_U2__SZARRAY_I4( CLR_RT_StackFrame& stack )
{
    TINYCLR_HEADER(); hr = S_OK;
    {
        UINT16 param0;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_UINT16( stack, 0, param0 ) );

        UINT16 param1;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_UINT16( stack, 1, param1 ) );

        CLR_RT_TypedArray_INT32 param2;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_INT32_ARRAY( stack, 2, param2 ) );

        UINT16 param3;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_UINT16( stack, 3, param3 ) );

        UINT16 param4;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_UINT16( stack, 4, param4 ) );

        CLR_RT_TypedArray_INT32 param5;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_INT32_ARRAY( stack, 5, param5 ) );

        UINT16 * param6;
        UINT8 heapblock6[CLR_RT_HEAP_BLOCK_SIZE];
        TINYCLR_CHECK_HRESULT( Interop_Marshal_UINT16_ByRef( stack, heapblock6, 6, param6 ) );

        UINT16 * param7;
        UINT8 heapblock7[CLR_RT_HEAP_BLOCK_SIZE];
        TINYCLR_CHECK_HRESULT( Interop_Marshal_UINT16_ByRef( stack, heapblock7, 7, param7 ) );

        CLR_RT_TypedArray_INT32 param8;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_INT32_ARRAY( stack, 8, param8 ) );

        MatrixFuncs::MatrixAdd_Nat( param0, param1, param2, param3, param4, param5, param6, param7, param8, hr );
        TINYCLR_CHECK_HRESULT( hr );
        TINYCLR_CHECK_HRESULT( Interop_Marshal_StoreRef( stack, heapblock6, 6 ) );
        TINYCLR_CHECK_HRESULT( Interop_Marshal_StoreRef( stack, heapblock7, 7 ) );
    }
    TINYCLR_NOCLEANUP();
}

HRESULT Library_MathFuncs_CMSIS_MatrixFuncs::MatrixMult_Nat___STATIC__VOID__U2__U2__SZARRAY_I4__U2__U2__SZARRAY_I4__BYREF_U2__BYREF_U2__SZARRAY_I4( CLR_RT_StackFrame& stack )
{
    TINYCLR_HEADER(); hr = S_OK;
    {
        UINT16 param0;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_UINT16( stack, 0, param0 ) );

        UINT16 param1;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_UINT16( stack, 1, param1 ) );

        CLR_RT_TypedArray_INT32 param2;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_INT32_ARRAY( stack, 2, param2 ) );

        UINT16 param3;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_UINT16( stack, 3, param3 ) );

        UINT16 param4;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_UINT16( stack, 4, param4 ) );

        CLR_RT_TypedArray_INT32 param5;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_INT32_ARRAY( stack, 5, param5 ) );

        UINT16 * param6;
        UINT8 heapblock6[CLR_RT_HEAP_BLOCK_SIZE];
        TINYCLR_CHECK_HRESULT( Interop_Marshal_UINT16_ByRef( stack, heapblock6, 6, param6 ) );

        UINT16 * param7;
        UINT8 heapblock7[CLR_RT_HEAP_BLOCK_SIZE];
        TINYCLR_CHECK_HRESULT( Interop_Marshal_UINT16_ByRef( stack, heapblock7, 7, param7 ) );

        CLR_RT_TypedArray_INT32 param8;
        TINYCLR_CHECK_HRESULT( Interop_Marshal_INT32_ARRAY( stack, 8, param8 ) );

        MatrixFuncs::MatrixMult_Nat( param0, param1, param2, param3, param4, param5, param6, param7, param8, hr );
        TINYCLR_CHECK_HRESULT( hr );
        TINYCLR_CHECK_HRESULT( Interop_Marshal_StoreRef( stack, heapblock6, 6 ) );
        TINYCLR_CHECK_HRESULT( Interop_Marshal_StoreRef( stack, heapblock7, 7 ) );
    }
    TINYCLR_NOCLEANUP();
}
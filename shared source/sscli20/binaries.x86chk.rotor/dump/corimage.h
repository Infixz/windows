// ==++==
// 
//   
//    Copyright (c) 2006 Microsoft Corporation.  All rights reserved.
//   
//    The use and distribution terms for this software are contained in the file
//    named license.txt, which can be found in the root of this distribution.
//    By using this software in any fashion, you are agreeing to be bound by the
//    terms of this license.
//   
//    You must not remove this notice, or any other, from this software.
//   
// 
// ==--==

/*============================================================
**
** CorImage.h
**
** IMAGEHLP routines so we can avoid early binding to that DLL.
**
===========================================================*/

#ifndef _CORIMAGE_H_
#define _CORIMAGE_H_

#include <daccess.h>

#ifdef  __cplusplus
extern "C" {
#endif

IMAGE_NT_HEADERS *Cor_RtlImageNtHeader(VOID *pvBase,
                                       ULONG FileLength);

PIMAGE_SECTION_HEADER
Cor_RtlImageRvaToSection(PTR_IMAGE_NT_HEADERS NtHeaders,
                         ULONG Rva,
                         ULONG FileLength);
    
PIMAGE_SECTION_HEADER
Cor_RtlImageRvaRangeToSection(PTR_IMAGE_NT_HEADERS NtHeaders,
                              ULONG Rva,
                              ULONG Range,
                              ULONG FileLength);

DWORD Cor_RtlImageRvaToOffset(PTR_IMAGE_NT_HEADERS NtHeaders,
                              ULONG Rva,
                              ULONG FileLength);

PBYTE Cor_RtlImageRvaToVa(PTR_IMAGE_NT_HEADERS NtHeaders,
                          PBYTE Base,
                          ULONG Rva,
                          ULONG FileLength);

PBYTE Cor_RtlImageDirToVa(PTR_IMAGE_NT_HEADERS NtHeaders,
                          PBYTE Base,
                          UINT  DirIndex,
                          ULONG FileLength);

PBYTE Cor_RtlImageRvaToVa32(PTR_IMAGE_NT_HEADERS32 NtHeaders,
                            PBYTE Base,
                            ULONG Rva,
                            ULONG FileLength);

PBYTE Cor_RtlImageRvaToVa64(PTR_IMAGE_NT_HEADERS64 NtHeaders,
                            PBYTE Base,
                            ULONG Rva,
                            ULONG FileLength);

#ifdef __cplusplus
}
#endif

#endif // _CORIMAGE_H_
// DirectDraw.cpp: implementation of the CDirectDraw class.
//
//////////////////////////////////////////////////////////////////////

#include "stdafx.h"
#include "35.h"
#include "DirectDraw.h"

#ifdef _DEBUG
#undef THIS_FILE
static char THIS_FILE[]=__FILE__;
#define new DEBUG_NEW
#endif

//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

CDirectDraw::CDirectDraw()
{
HRESULT rezult;
DDSURFACEDESC  tempSurfdeck1;
DDSURFACEDESC  tempSurfdeck2;
DDSURFACEDESC  tempSurfdeck3;
DDSCAPS  tempCaps;
rezult = DirectDrawCreate(NULL, &lpDD, NULL );
lpDD->SetCooperativeLevel(AfxGetMainWnd()->GetSafeHwnd(),DDSCL_EXCLUSIVE | DDSCL_FULLSCREEN );
lpDD->SetDisplayMode(640,480,16);

memset(&tempSurfdeck1,0,sizeof(DDSURFACEDESC));
tempSurfdeck1.dwSize = sizeof(DDSURFACEDESC);
tempSurfdeck1.dwFlags = DDSD_CAPS | DDSD_BACKBUFFERCOUNT; 
tempSurfdeck1.ddsCaps.dwCaps = DDSCAPS_PRIMARYSURFACE | DDSCAPS_FLIP | DDSCAPS_COMPLEX; 
tempSurfdeck1.dwBackBufferCount =1;
lpDD->CreateSurface(&tempSurfdeck1,&srPrimarySurf,NULL);


tempCaps.dwCaps = DDSCAPS_BACKBUFFER;

srPrimarySurf->GetAttachedSurface(&tempCaps,&srSecondarySurf);


memset(&tempSurfdeck2,0,sizeof(DDSURFACEDESC));
tempSurfdeck2.dwSize = sizeof(DDSURFACEDESC);
tempSurfdeck2.dwFlags = DDSD_CAPS | DDSD_HEIGHT | DDSD_WIDTH;
tempSurfdeck2.ddsCaps.dwCaps  = DDSCAPS_OFFSCREENPLAIN;
tempSurfdeck2.dwHeight = 480;
tempSurfdeck2.dwWidth = 640;
lpDD->CreateSurface(&tempSurfdeck2,&srFon,NULL);
memset(&tempSurfdeck3,0,sizeof(DDSURFACEDESC));
tempSurfdeck3.dwSize = sizeof(DDSURFACEDESC);
tempSurfdeck3.dwFlags = DDSD_CAPS | DDSD_HEIGHT | DDSD_WIDTH;
tempSurfdeck3.ddsCaps.dwCaps  = DDSCAPS_OFFSCREENPLAIN;
tempSurfdeck3.dwHeight = 66;
tempSurfdeck3.dwWidth = 233;
lpDD->CreateSurface(&tempSurfdeck3,&srChip,NULL);

HANDLE hBMP;
HDC     hdc;
hBMP=LoadImage(AfxGetInstanceHandle(),MAKEINTRESOURCE(IDB_BITMAP1) , IMAGE_BITMAP, 0, 0,  LR_CREATEDIBSECTION | LR_DEFAULTSIZE);
srFon->GetDC(&hdc);
HDC hCompt = CreateCompatibleDC(hdc);
SelectObject(hCompt,hBMP);
BitBlt(hdc, 0, 0, 640, 480, hCompt, 0, 0, SRCCOPY);
srFon->ReleaseDC(hdc);  

hBMP=LoadImage(AfxGetInstanceHandle(),MAKEINTRESOURCE(IDB_BITMAP2) , IMAGE_BITMAP, 0, 0,  LR_CREATEDIBSECTION | LR_DEFAULTSIZE);
srChip->GetDC(&hdc);
hCompt = CreateCompatibleDC(hdc);
SelectObject(hCompt,hBMP);
BitBlt(hdc, 0, 0, 233, 66, hCompt, 0, 0, SRCCOPY);
srChip->ReleaseDC(hdc); 


FonToSecond();
ChipToSecond(0,0);
Flip();
FonToPrimary();
ChipToPrimary(0,0);

}

CDirectDraw::~CDirectDraw()
{
srChip->Release(); 
srFon->Release(); 
srSecondarySurf->Release(); 
srPrimarySurf->Release();
lpDD->RestoreDisplayMode(); 
lpDD->SetCooperativeLevel(AfxGetMainWnd()->GetSafeHwnd(),DDSCL_NORMAL);
lpDD->Release(); 
}

void CDirectDraw::FonToPrimary()
{
DDBLTFX ddb;
memset(&ddb,0, sizeof(DDBLTFX));
ddb.dwSize = sizeof(DDBLTFX);
ddb.dwDDFX = DDBLTFX_MIRRORLEFTRIGHT;
 
CRect r;
r.top = 0;
r.left = 0;
r.right = 640;
r.bottom = 480;
srPrimarySurf->Blt(r,srFon,r,DDBLT_WAIT,&ddb);

}

void CDirectDraw::Flip()
{
srPrimarySurf->Flip(NULL,DDFLIP_WAIT); 

}



void CDirectDraw::FonToSecond()
{
DDBLTFX ddb;
memset(&ddb,0, sizeof(DDBLTFX));
ddb.dwSize = sizeof(DDBLTFX);
ddb.dwDDFX = DDBLTFX_MIRRORLEFTRIGHT;
 
CRect r;
r.top = 0;
r.left = 0;
r.right = 640;
r.bottom = 480;
srSecondarySurf->Blt(r,srFon,r,DDBLT_WAIT,&ddb);

}

void CDirectDraw::ChipToSecond(int x, int y)
{
DDBLTFX ddb;
memset(&ddb,0, sizeof(DDBLTFX));
ddb.dwSize = sizeof(DDBLTFX);
ddb.dwDDFX = DDBLTFX_MIRRORLEFTRIGHT;
CRect r;
CRect r1;
    r.top = y;
    r.left = x;
    r.right = x + 233;
    r.bottom = y + 66;
    r1.top = 0;
    r1.left = 0;
    r1.right = 233;
    r1.bottom = 66;
srSecondarySurf->Blt(r,srChip,r1,DDBLT_WAIT,&ddb);
}

void CDirectDraw::ChipToPrimary(int x, int y)
{
DDBLTFX ddb;
memset(&ddb,0, sizeof(DDBLTFX));
ddb.dwSize = sizeof(DDBLTFX);
ddb.dwDDFX = DDBLTFX_MIRRORLEFTRIGHT;
CRect r;
CRect r1;
    r.top = y;
    r.left = x;
    r.right = x + 233;
    r.bottom = y + 66;
    r1.top = 0;
    r1.left = 0;
    r1.right = 233;
    r1.bottom = 66;
srPrimarySurf->Blt(r,srChip,r1,DDBLT_WAIT,&ddb);
}
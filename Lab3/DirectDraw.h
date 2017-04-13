// DirectDraw.h: interface for the CDirectDraw class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_DIRECTDRAW_H__1F32C3F1_990C_40D8_A675_4A1A3E4E1E54__INCLUDED_)
#define AFX_DIRECTDRAW_H__1F32C3F1_990C_40D8_A675_4A1A3E4E1E54__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include "ddraw.h" 
#pragma comment(lib,"ddraw.lib")


class CDirectDraw  
{
public:
	void ChipToSecond(int x,int y);
	void FonToSecond();
	void ChipToPrimary(int x,int y);
	void Flip();
	void FonToPrimary();
	CDirectDraw();
	virtual ~CDirectDraw();
private:

LPDIRECTDRAWSURFACE  srFon;
LPDIRECTDRAWSURFACE  srChip;
LPDIRECTDRAWSURFACE  srPrimarySurf;
LPDIRECTDRAWSURFACE  srSecondarySurf;
LPDIRECTDRAW  lpDD;
};

#endif // !defined(AFX_DIRECTDRAW_H__1F32C3F1_990C_40D8_A675_4A1A3E4E1E54__INCLUDED_)

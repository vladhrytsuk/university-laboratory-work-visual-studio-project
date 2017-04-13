// 35.h : main header file for the 35 application
//

#if !defined(AFX_35_H__D1A24E27_8F51_468D_B602_26B9AF464A7E__INCLUDED_)
#define AFX_35_H__D1A24E27_8F51_468D_B602_26B9AF464A7E__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CMy35App:
// See 35.cpp for the implementation of this class
//

class CMy35App : public CWinApp
{
public:
	CMy35App();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CMy35App)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CMy35App)

	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_35_H__D1A24E27_8F51_468D_B602_26B9AF464A7E__INCLUDED_)

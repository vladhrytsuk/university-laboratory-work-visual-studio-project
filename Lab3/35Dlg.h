// 35Dlg.h : header file
//

#if !defined(AFX_35DLG_H__67F108F4_84AF_4D73_AB93_D16C31E4AFCD__INCLUDED_)
#define AFX_35DLG_H__67F108F4_84AF_4D73_AB93_D16C31E4AFCD__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////
// CMy35Dlg dialog

#include "DirectDraw.h"

class CMy35Dlg : public CDialog
{
// Construction
public:
	void Moves();
	CDirectDraw* dr;
	int y;
	int x;
	BOOL a;
	CMy35Dlg(CWnd* pParent = NULL);	// standard constructor

          
           
// Dialog Data
	//{{AFX_DATA(CMy35Dlg)
	enum { IDD = IDD_MY35_DIALOG };
		// NOTE: the ClassWizard will add data members here
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CMy35Dlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(CMy35Dlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnKeyDown(UINT nChar, UINT nRepCnt, UINT nFlags);
	afx_msg void OnDestroy();
	afx_msg UINT OnGetDlgCode();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_35DLG_H__67F108F4_84AF_4D73_AB93_D16C31E4AFCD__INCLUDED_)

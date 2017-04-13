; CLW file contains information for the MFC ClassWizard

[General Info]
Version=1
LastClass=CNewDialog
LastTemplate=CDialog
NewFileInclude1=#include "stdafx.h"
NewFileInclude2=#include "35.h"

ClassCount=5
Class1=CMy35App
Class2=CMy35Dlg
Class3=CAboutDlg

ResourceCount=5
Resource1=IDD_ABOUTBOX
Resource2=IDR_MAINFRAME
Resource3=IDD_MY35_DIALOG
Resource4=IDD_ABOUTBOX (English (U.S.))
Class5=CNewDialog
Resource5=IDD_MY35_DIALOG (English (U.S.))

[CLS:CMy35App]
Type=0
HeaderFile=35.h
ImplementationFile=35.cpp
Filter=W
BaseClass=CWinApp
VirtualFilter=AC

[CLS:CMy35Dlg]
Type=0
HeaderFile=35Dlg.h
ImplementationFile=35Dlg.cpp
Filter=W
BaseClass=CDialog
VirtualFilter=dWC

[CLS:CAboutDlg]
Type=0
HeaderFile=35Dlg.h
ImplementationFile=35Dlg.cpp
Filter=D

[DLG:IDD_ABOUTBOX]
Type=1
ControlCount=4
Control1=IDC_STATIC,static,1342177283
Control2=IDC_STATIC,static,1342308352
Control3=IDC_STATIC,static,1342308352
Control4=IDOK,button,1342373889
Class=CAboutDlg


[DLG:IDD_MY35_DIALOG]
Type=1
ControlCount=3
Control1=IDOK,button,1342242817
Control2=IDCANCEL,button,1342242816
Control3=IDC_STATIC,static,1342308352
Class=CMy35Dlg

[DLG:IDD_MY35_DIALOG (English (U.S.))]
Type=1
Class=CMy35Dlg
ControlCount=0

[DLG:IDD_ABOUTBOX (English (U.S.))]
Type=1
Class=CAboutDlg
ControlCount=4
Control1=IDC_STATIC,static,1342177283
Control2=IDC_STATIC,static,1342308480
Control3=IDC_STATIC,static,1342308352
Control4=IDOK,button,1342373889

[CLS:CNewDialog]
Type=0
HeaderFile=NewDialog.h
ImplementationFile=NewDialog.cpp
BaseClass=CDialog
Filter=D


#define INITGUID
#include "stdafx.h"
#include "Win32Project1.h"
#include "dinput.h"
#include <strsafe.h>
#define _CRT_SECURE_NO_WARNINGS

#define KeyState(x) ((KeyStateBuffer[x] & 0x80) ? TRUE : FALSE)
#define MouseButtonState(x) ((MouseState.rgbButtons[x] & 0x80) ? TRUE : FALSE)*/

HINSTANCE MyInst;
LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);
LPCWSTR szWindowClass = L"DirectInput";

LPDIRECTINPUT8 g_pDI = NULL;
LPDIRECTINPUTDEVICE8 g_pKeyboard = NULL;
IDirectInputDevice8 *pDIDMouse;
long g_MouseXPos = 0, g_MouseYPos = 0;
DIMOUSESTATE MouseState;

BOOL InitDIAndEnumAllDevices(HWND hWnd, HINSTANCE hInst);
BOOL CALLBACK EnumDevices(LPCDIDEVICEINSTANCE pdInst, LPVOID pvRef);

IDirectInputDevice8* InitKeyboard(HWND hWnd, IDirectInput8 *pDI);
BOOL ReadKeyboard(IDirectInputDevice8 *pDIDevice, void *DataBuffer, long BufferSize);

IDirectInputDevice8* InitMouse(HWND hWnd, IDirectInput8* pDI);
BOOL ReadMouse(IDirectInputDevice8 *g_pDIDevice, DIMOUSESTATE* DataBuffer, long BufferSize);

int  WINAPI  WinMain(HINSTANCE hInst, HINSTANCE hPreInst, LPSTR lpszCmdLine, int nCmdShow) {
	HWND hWnd;
	MSG lpMsg;
	WNDCLASS wcApp;
	wcApp.lpszClassName = szWindowClass;
	wcApp.hInstance = hInst;
	MyInst = hInst;
	wcApp.lpfnWndProc = WndProc;
	wcApp.hCursor = LoadCursor(NULL, IDC_ARROW);
	wcApp.hIcon = 0;
	wcApp.lpszMenuName = 0;
	wcApp.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);
	wcApp.style = CS_HREDRAW | CS_VREDRAW;
	wcApp.cbClsExtra = 0;
	wcApp.cbWndExtra = 0;
	if (!RegisterClass(&wcApp))
		return  0;
	hWnd = CreateWindow(szWindowClass, L"Using DirectInput", WS_OVERLAPPEDWINDOW, 500, 300, 600, 400, (HWND)NULL, (HMENU)NULL, hInst, NULL);
	ShowWindow(hWnd, nCmdShow);
	UpdateWindow(hWnd);
	InitDIAndEnumAllDevices(hWnd, MyInst);
	if ((pDIDMouse = InitMouse(hWnd, g_pDI)) == NULL) {
		MessageBoxA(hWnd, "Error", "Error init mouse!", MB_OKCANCEL);
		return 0;
	}
	if ((g_pKeyboard = InitKeyboard(hWnd, g_pDI)) == NULL) {
		MessageBoxA(hWnd, "Error", "Error init keyboard!", MB_OKCANCEL);
		return 0;
	}
	unsigned char KeyStateBuffer[256];

	while (GetMessage(&lpMsg, NULL, 0, 0)) {
		TranslateMessage(&lpMsg);

		ReadKeyboard(g_pKeyboard, KeyStateBuffer, 256);
		if (KeyState(DIK_Q) == TRUE) {
			MessageBoxA(hWnd, "KEY \"Q\"", "KEY \"Q\" PRESSED", MB_OKCANCEL);
		}
		if (KeyState(DIK_W) == TRUE) {
			MessageBoxA(hWnd, "KEY \"W\"", "KEY \"W\" PRESSED", MB_OKCANCEL);
		}
		if (KeyState(DIK_E) == TRUE) {
			MessageBoxA(hWnd, "KEY \"E\"", "KEY \"E\" PRESSED", MB_OKCANCEL);
		}
		if (KeyState(DIK_A) == TRUE) {
			MessageBoxA(hWnd, "KEY \"A\"", "KEY \"A\" PRESSED", MB_OKCANCEL);
		}
		if (KeyState(DIK_S) == TRUE) {
			MessageBoxA(hWnd, "KEY \"S\"", "KEY \"S\" PRESSED", MB_OKCANCEL);
		}

		ReadMouse(pDIDMouse, &MouseState, sizeof(DIMOUSESTATE));

		InvalidateRect(hWnd, 0, TRUE);
		UpdateWindow(hWnd);

		DispatchMessage(&lpMsg);
	}

	return (lpMsg.wParam);
}

LRESULT CALLBACK  WndProc(HWND hWnd, UINT messg, WPARAM  wParam, LPARAM lParam) {
	HDC hdc;
	PAINTSTRUCT ps;
	char mouse_info[256];

	switch (messg) {
	case WM_PAINT:
		hdc = BeginPaint(hWnd, &ps);

		g_MouseXPos += MouseState.lX;
		g_MouseYPos += MouseState.lY;
		POINT cursorPos;
		GetCursorPos(&cursorPos);
		g_MouseXPos = cursorPos.x;
		g_MouseYPos = cursorPos.y;
		sprintf_s(mouse_info, "Mouse position: X = %d, Y = %d", g_MouseXPos, g_MouseYPos);
		TextOutA(hdc, 10, 10, mouse_info, strlen(mouse_info));

		ValidateRect(hWnd, NULL);
		EndPaint(hWnd, &ps);
		break;
	case WM_QUIT:
		PostQuitMessage(0);
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	default:
		return (DefWindowProc(hWnd, messg, wParam, lParam));
	}

	return 0;
}

BOOL InitDIAndEnumAllDevices(HWND hWnd, HINSTANCE hInst) {
	if (FAILED(DirectInput8Create(hInst, DIRECTINPUT_VERSION, IID_IDirectInput8, (void**)&g_pDI, NULL)))
		return FALSE;
	g_pDI->EnumDevices(DI8DEVCLASS_ALL, EnumDevices, (LPVOID)hWnd, DIEDFL_ALLDEVICES);

	return TRUE;
}

BOOL CALLBACK EnumDevices(LPCDIDEVICEINSTANCE pdInst, LPVOID pvRef) {
	int Result;
	Result = MessageBox((HWND)pvRef, pdInst->tszInstanceName, L"Device Found", MB_OKCANCEL);
	if (Result == IDOK)
		return DIENUM_CONTINUE;
	return DIENUM_STOP;
}

IDirectInputDevice8* InitKeyboard(HWND hWnd, IDirectInput8 *pDI) {
	IDirectInputDevice8 *pDIDevice;

	if (FAILED(pDI->CreateDevice(GUID_SysKeyboard, &pDIDevice, NULL)))
		return NULL;
	if (FAILED(pDIDevice->SetDataFormat(&c_dfDIKeyboard))) {
		pDIDevice->Release();
		return NULL;
	}
	if (FAILED(pDIDevice->SetCooperativeLevel(hWnd, DISCL_FOREGROUND | DISCL_NONEXCLUSIVE))) {
		pDIDevice->Release();
		return NULL;
	}
	if (FAILED(pDIDevice->Acquire())) {
		pDIDevice->Release();
		return NULL;
	}
	return pDIDevice;
}

BOOL ReadKeyboard(IDirectInputDevice8 *g_pDIDevice, void *DataBuffer, long BufferSize) {
	HRESULT hr;

	while (1) {
		g_pDIDevice->Poll();
		hr = g_pDIDevice->GetDeviceState(BufferSize, (LPVOID)DataBuffer);
		if (SUCCEEDED(hr))
			break;
		if (hr != DIERR_INPUTLOST && hr != DIERR_NOTACQUIRED)
			return FALSE;
		if (FAILED(g_pDIDevice->Acquire()))
			return FALSE;
	}
	return TRUE;
}

IDirectInputDevice8* InitMouse(HWND hWnd, IDirectInput8* pDI) {
	IDirectInputDevice8 *pDIDevice;
	if (FAILED(pDI->CreateDevice(GUID_SysMouse, &pDIDevice, NULL)))
		return NULL;
	if (FAILED(pDIDevice->SetDataFormat(&c_dfDIMouse))) {
		pDIDevice->Release();
		return NULL;
	}
	if (FAILED(pDIDevice->SetCooperativeLevel(hWnd, DISCL_NONEXCLUSIVE | DISCL_FOREGROUND))) {
		pDIDevice->Release();
		return NULL;
	}
	if (FAILED(pDIDevice->Acquire())) {
		pDIDevice->Release();
		return NULL;
	}
	return pDIDevice;
}

BOOL ReadMouse(IDirectInputDevice8 *g_pDIDevice, DIMOUSESTATE* DataBuffer, long BufferSize) {
	HRESULT hr;

	while (1) {
		g_pDIDevice->Poll();
		hr = g_pDIDevice->GetDeviceState(BufferSize, (LPVOID)DataBuffer);
		if (SUCCEEDED(hr))
			break;
		if (hr != DIERR_INPUTLOST && hr != DIERR_NOTACQUIRED)
			return FALSE;
		if (FAILED(g_pDIDevice->Acquire()))
			return FALSE;
	}
	return TRUE;
}

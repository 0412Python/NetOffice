#pragma once
#include "stdafx.h"
#include "atlbase.h"
#include <fstream>
#include <iosfwd>
#include <iostream>
#include <ctime>

extern WCHAR* LogFile_Path;
extern WCHAR* LogFile_Register_Path;
extern WCHAR* LogFile_UnRegister_Path;
extern BOOL	  Internal_LogError_MessageBoxes_Enabled;

namespace NetOffice_ShimLoader_Analytics
{
	static const int _bufferSize = 1024;

	static HRESULT GetModuleFileName(WCHAR* szPath, DWORD nPathBufferSize)
	{
		HMODULE hInstance = _AtlBaseModule.GetModuleInstance();
		if (0 == hInstance)
		{
			return E_FAIL;
		}

		DWORD dwFLen = ::GetModuleFileName(hInstance, szPath, nPathBufferSize);
		if (0 != dwFLen)
		{
			return S_OK;
		}
		else
		{
			return E_FAIL;
		}
	}

	static HRESULT GetDllDirectory(WCHAR* szPath, DWORD nPathBufferSize)
	{
		HMODULE hInstance = _AtlBaseModule.GetModuleInstance();
		if (0 == hInstance)
		{
			return E_FAIL;
		}

		TCHAR szModule[MAX_PATH + 1];
		DWORD dwFLen = ::GetModuleFileName(hInstance, szModule, MAX_PATH);
		if (0 == dwFLen)
		{
			return E_FAIL;
		}

		TCHAR* pszFileName;
		dwFLen = ::GetFullPathName(szModule, nPathBufferSize, szPath, &pszFileName);
		if (0 == dwFLen || dwFLen >= nPathBufferSize)
		{
			return E_FAIL;
		}

		*pszFileName = 0;
		return S_OK;
	}

	static HRESULT InitializeLog()
	{
		HRESULT hr = S_OK;

		WCHAR moduleFolderPath[MAX_PATH];
		WCHAR moduleFileName[MAX_PATH];
		WCHAR logFileName[MAX_PATH];
		WCHAR logRegisterFileName[MAX_PATH];
		WCHAR logUnregisterFileName[MAX_PATH];

		hr = GetDllDirectory(moduleFolderPath, MAX_PATH);
		if (FAILED(hr))
			goto Error;
		hr = GetModuleFileName(moduleFileName, MAX_PATH);
		if (FAILED(hr))
			goto Error;
		PathStripPath(moduleFileName);

		StringCchCopy(logFileName, MAX_PATH, moduleFileName);
		StringCchCat(logFileName, MAX_PATH, L".log");

		StringCchCopy(logRegisterFileName, MAX_PATH, moduleFileName);
		StringCchCat(logRegisterFileName, MAX_PATH, L".Register");
		StringCchCat(logRegisterFileName, MAX_PATH, L".log");

		StringCchCopy(logUnregisterFileName, MAX_PATH, moduleFileName);
		StringCchCat(logUnregisterFileName, MAX_PATH, L".Unregister");
		StringCchCat(logUnregisterFileName, MAX_PATH, L".log");

		PathAppend(LogFile_Path, moduleFolderPath);
		if (LogFile_Path && SUCCEEDED(PathAppend(LogFile_Path, logFileName)))
		{
			if (PathFileExists(LogFile_Path))
			{
				DeleteFile(LogFile_Path);
			}
		}

		PathAppend(LogFile_Register_Path, moduleFolderPath);
		if (LogFile_Register_Path && SUCCEEDED(PathAppend(LogFile_Register_Path, logRegisterFileName)))
		{
			if (PathFileExists(LogFile_Register_Path))
			{
				DeleteFile(LogFile_Register_Path);
			}
		}

		PathAppend(LogFile_UnRegister_Path, moduleFolderPath);
		if (LogFile_UnRegister_Path && SUCCEEDED(PathAppend(LogFile_UnRegister_Path, logUnregisterFileName)))
		{
			if (PathFileExists(LogFile_UnRegister_Path))
			{
				DeleteFile(LogFile_UnRegister_Path);
			}
		}

		return hr;

	Error:

		return hr;
	}

	static void _Write(LPCWSTR text)
	{
		std::wofstream myfile(LogFile_Path, std::ios::app);
		if (LogFile_Path && myfile.is_open())
		{
			myfile << text << std::endl;
			myfile.close();
		}
		else
		{
			#ifdef DEBUG
				MessageBox(GetDesktopWindow(), LogFile_Path, L"WriteLog::_Write::OpenFileError", 0);
			#endif
		}
	}

	static void _WriteRegister(LPCWSTR text)
	{
		std::wofstream myfile(LogFile_Register_Path, std::ios::app);
		if (LogFile_Register_Path && myfile.is_open())
		{
			myfile << text << std::endl;
			myfile.close();
		}
		else
		{
			#ifdef DEBUG
				MessageBox(GetDesktopWindow(), LogFile_Register_Path, L"WriteLog::_WriteRegister::OpenFileError", 0);
			#endif
		}
	}

	static void _WriteUnRegister(LPCWSTR text)
	{
		MessageBox(NULL, LogFile_UnRegister_Path, text, 0);
		std::wofstream myfile(LogFile_UnRegister_Path, std::ios::app);
		if (LogFile_UnRegister_Path && myfile.is_open())
		{
			myfile << text << std::endl;
			myfile.close();
		}
		else
		{
			#ifdef DEBUG
				MessageBox(GetDesktopWindow(), LogFile_UnRegister_Path, L"WriteLog::_WriteUnRegister::OpenFileError", 0);
			#endif
		}
	}

	static void WriteError(LPCWSTR text, ULONG value)
	{
		WCHAR buffer[_bufferSize];
		swprintf_s(buffer, _bufferSize, L"%s(%d)", text, value);
		_Write(text);

		#ifdef DEBUG

			if(Internal_LogError_MessageBoxes_Enabled)
				MessageBox(GetDesktopWindow(), buffer, L"WriteError", 0);

		#endif
	}

	static void WriteRegisterError(LPCWSTR text, HRESULT value)
	{
		WCHAR buffer[_bufferSize];
		swprintf_s(buffer, _bufferSize, L"%s(HR:%d)", text, value);
		_WriteRegister(text);

		#ifdef DEBUG

			if (Internal_LogError_MessageBoxes_Enabled)
				MessageBox(GetDesktopWindow(), buffer, L"WriteError", 0);

		#endif
	}

	static void WriteUnRegisterError(LPCWSTR text, HRESULT value)
	{
		WCHAR buffer[_bufferSize];
		swprintf_s(buffer, _bufferSize, L"%s(HR:%d)", text, value);
		_WriteUnRegister(text);

		#ifdef DEBUG

			if (Internal_LogError_MessageBoxes_Enabled)
				MessageBox(GetDesktopWindow(), buffer, L"WriteError", 0);

		#endif
	}

	static void WriteError(LPCWSTR text, HRESULT value)
	{
		WCHAR buffer[_bufferSize];
		swprintf_s(buffer, _bufferSize, L"%s(HR:%d)", text, value);
		_Write(text);

		#ifdef DEBUG

			if (Internal_LogError_MessageBoxes_Enabled)
				MessageBox(GetDesktopWindow(), buffer, L"WriteError", 0);

		#endif
	}

	static void WriteError(LPCWSTR text)
	{
		_Write(text);

		#ifdef DEBUG

				if (Internal_LogError_MessageBoxes_Enabled)
				MessageBox(GetDesktopWindow(), text, L"WriteError", 0);

		#endif
	}

	static void WriteError(LPCWSTR text, LPCWSTR text2)
	{
		WCHAR buffer[_bufferSize];
		swprintf_s(buffer, _bufferSize, L"%s(%s)", text, text2);
		_Write(text);

		#ifdef DEBUG

			if (Internal_LogError_MessageBoxes_Enabled)
				MessageBox(GetDesktopWindow(), buffer, L"WriteError", 0);

		#endif
	}

	static void WriteLog(LPCWSTR text, HRESULT value)
	{
		WCHAR buffer[_bufferSize];
		swprintf_s(buffer, _bufferSize, L"%s(HR:%d)", text, value);
		_Write(text);
	}

	static void WriteRegisterLog(LPCWSTR text)
	{
		_WriteRegister(text);
	}

	static void WriteUnRegisterLog(LPCWSTR text)
	{
		_WriteUnRegister(text);
	}

	static void WriteLog(LPCWSTR text)
	{
		_Write(text);
	}

	static void WriteLogTimeStamp(LPCWSTR text)
	{
		time_t t = time(NULL);
		struct tm buf;
		WCHAR timeBuffer[256];

		if (NULL == localtime_s(&buf, &t))
		{
			wcsftime(timeBuffer, 256, L"(%d-%m-%Y %I:%M:%S %p)", &buf);
			WCHAR buffer[_bufferSize];
			StringCchCopy(buffer, _bufferSize, text);
			StringCchCat(buffer, _bufferSize, timeBuffer);
			_Write(buffer);
		}
		else
		{
			_Write(text);
		}
	}

	static void WriteLog(LPCWSTR text, LPCWSTR text2)
	{
		WCHAR buffer[_bufferSize];
		swprintf_s(buffer, _bufferSize, L"%s(%s)", text, text2);
		_Write(text);
	}
}

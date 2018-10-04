#include "stdafx.h"
#include "DllRegisterMode.hpp"

using namespace NetOffice_ShimLoader;

namespace NetOffice_ShimLoader_Register32On64
{
	DWORD _regKeyOptions = KEY_ALL_ACCESS;

	HRESULT RegisterCOMComponent(HINSTANCE module, LPCWSTR progId, LPCWSTR classId, LPCWSTR version, LPCWSTR description, RegisterMode mode);
	HRESULT UnregisterCOMComponent(LPCWSTR progId, LPCWSTR classId, LPCWSTR version, RegisterMode mode);
	HRESULT RegisterCOMAddin(LPCWSTR pszOfficeApp, LPCWSTR pszProgID, LPCWSTR pszFriendlyName, LPCWSTR pszDescription, DWORD dwStartupContext, DWORD dwCommandLineSafe, bool registerPerMachine);
	HRESULT UnRegisterCOMAddin(LPCWSTR pszOfficeApp, LPCWSTR pszProgID, bool registerPerMachine);

	HKEY TargetRootKey(RegisterMode mode);
	void ProgIdSubKey(LPCWSTR progId, RegisterMode mode, WCHAR* progIdKey);
	void ClassIdSubKey(LPCWSTR classId, RegisterMode mode, WCHAR* classIdKey);
	BOOL SetKeyAndValue(HKEY hKeyRoot, LPCWSTR pszPath, LPCWSTR pszSubkey1, LPCWSTR pszSubkey2, LPCWSTR pszSubkey3, LPCWSTR pszvalueName, LPCWSTR pszValue);
	LONG RecursiveDeleteKey(HKEY hKeyParent, LPCWSTR pszKeyChild);
	LONG RecursiveDeleteKey(HKEY hKeyParent, LPCWSTR pszKeyChild, LPCWSTR pszKeyChild2);
	LONG RecursiveDeleteKey(HKEY hKeyParent, LPCWSTR pszKeyChild, LPCWSTR pszKeyChild2, LPCWSTR pszKeyChild3);

	HRESULT DllRegister(HINSTANCE module, LPCWSTR officeApplications[], DWORD addinLoadBehavior, DWORD addinCommandLineSafe, WCHAR* progId, WCHAR* classId, WCHAR* friendlyName, WCHAR* description, WCHAR* version, RegisterMode mode, BOOL addinRegistration)
	{
		HRESULT hr = S_OK;

		if (NULL == module)
			return E_INVALIDARG;
		if (NULL == officeApplications)
			return E_INVALIDARG;
		if (!progId || !progId[0])
			return E_INVALIDARG;
		if (!classId || !classId[0])
			return E_INVALIDARG;
		if (!friendlyName || !friendlyName[0])
			return E_INVALIDARG;
		if (!description || !description[0])
			return E_INVALIDARG;
		if (!version || !version[0])
			return E_INVALIDARG;

		hr = RegisterCOMComponent(module, progId, classId, version, description, mode);
		if (SUCCEEDED(hr) && addinRegistration)
		{
			size_t arraySize = (sizeof(officeApplications) / sizeof(*officeApplications));
			for (size_t i = 0; i < arraySize; i++)
			{
				hr = RegisterCOMAddin(officeApplications[i], progId, friendlyName, description, addinLoadBehavior, addinCommandLineSafe, System == mode);
				if (!SUCCEEDED(hr))
					break;
			}
		}

		return hr;
	}

	HRESULT DllUnregister(LPCWSTR officeApplications[], WCHAR* progId, WCHAR* classId, WCHAR* version, RegisterMode mode, BOOL addinRegistration)
	{
		HRESULT hr = S_OK;
		HRESULT addin = S_OK;

		if (NULL == officeApplications)
			return E_INVALIDARG;
		if (!progId || !progId[0])
			return E_INVALIDARG;
		if (!classId || !classId[0])
			return E_INVALIDARG;
		if (!version || !version[0])
			return E_INVALIDARG;

		if (addinRegistration)
		{
			size_t arraySize = (sizeof(officeApplications) / sizeof(*officeApplications));
			for (size_t i = 0; i < arraySize; i++)
			{
				if (!SUCCEEDED(UnRegisterCOMAddin(officeApplications[i], progId, 0 == mode)))
					addin = E_FAIL;
			}
		}

		hr = UnregisterCOMComponent(progId, classId, version, mode);

		return addin != S_OK ? addin : hr;
	}

	HRESULT RegisterCOMComponent(HINSTANCE module, LPCWSTR progId, LPCWSTR classId, LPCWSTR version, LPCWSTR description, RegisterMode mode)
	{
		HRESULT result = S_OK;

		WCHAR moduleFullFileName[512];
		DWORD dwResult = ::GetModuleFileName(module, moduleFullFileName, 512);
		if (0 == dwResult)
			return E_FAIL;

		HKEY targetRootKey = TargetRootKey(mode);

		WCHAR classIdKey[512];
		ClassIdSubKey(classId, mode, classIdKey);

		WCHAR progIdKey[512];
		ProgIdSubKey(progId, mode, progIdKey);

		// Target Key ProgId
		if (!SetKeyAndValue(targetRootKey, progIdKey, NULL, NULL, NULL, NULL, progId))
			return S_FALSE;
		if (!SetKeyAndValue(targetRootKey, progIdKey, L"CLSID", NULL, NULL, NULL, classId))
			return S_FALSE;

		// Target Key IID
		if (!SetKeyAndValue(targetRootKey, classIdKey, NULL, NULL, NULL, NULL, progId))
			return S_FALSE;
		if (!SetKeyAndValue(targetRootKey, classIdKey, L"InprocServer32", NULL, NULL, L"ThreadingModel", L"Apartment"))
			return S_FALSE;
		if (!SetKeyAndValue(targetRootKey, classIdKey, L"InprocServer32", NULL, NULL, NULL, moduleFullFileName))
			return S_FALSE;
		if (!SetKeyAndValue(targetRootKey, classIdKey, L"InprocServer32", version, NULL, L"ThreadingModel", L"Apartment"))
			return S_FALSE;
		if (!SetKeyAndValue(targetRootKey, classIdKey, L"InprocServer32", version, NULL, NULL, moduleFullFileName))
			return S_FALSE;
		if (!SetKeyAndValue(targetRootKey, classIdKey, L"ProgId", NULL, NULL, NULL, progId))
			return S_FALSE;

		if(mode != User)
		{
			// HKEY_CLASSES_ROOT ProgId
			if (!SetKeyAndValue(HKEY_CLASSES_ROOT, progId, NULL, NULL, NULL, NULL, progId))
				return S_FALSE;
			if (!SetKeyAndValue(HKEY_CLASSES_ROOT, progId, L"CLSID", NULL, NULL, NULL, classId))
				return S_FALSE;

			// HKEY_CLASSES_ROOT IID
			if (!SetKeyAndValue(HKEY_CLASSES_ROOT, L"CLSID", classId, NULL, NULL, NULL, progId))
				return S_FALSE;
			if (!SetKeyAndValue(HKEY_CLASSES_ROOT, L"CLSID", classId, L"InprocServer32", NULL, L"ThreadingModel", L"Apartment"))
				return S_FALSE;
			if (!SetKeyAndValue(HKEY_CLASSES_ROOT, L"CLSID", classId, L"InprocServer32", NULL, NULL, moduleFullFileName))
				return S_FALSE;
			if (!SetKeyAndValue(HKEY_CLASSES_ROOT, L"CLSID", classId, L"InprocServer32", version, L"ThreadingModel", L"Apartment"))
				return S_FALSE;
			if (!SetKeyAndValue(HKEY_CLASSES_ROOT, L"CLSID", classId, L"InprocServer32", version, NULL, moduleFullFileName))
				return S_FALSE;
			if (!SetKeyAndValue(HKEY_CLASSES_ROOT, L"CLSID", classId, L"ProgId", NULL, NULL, progId))
				return S_FALSE;
		}

		return result;
	}

	HRESULT UnregisterCOMComponent(LPCWSTR progId, LPCWSTR classId, LPCWSTR version, RegisterMode mode)
	{
		HRESULT result = S_OK;

		HKEY hKeyRoot = TargetRootKey(mode);
		WCHAR classIdKey[512];
		ClassIdSubKey(classId, mode, classIdKey);
		WCHAR progIdKey[512];
		ProgIdSubKey(progId, mode, progIdKey);

		if (mode != User)
		{
			if (ERROR_SUCCESS != RecursiveDeleteKey(HKEY_CLASSES_ROOT, progId))
				result = E_FAIL;
			if (ERROR_SUCCESS != RecursiveDeleteKey(HKEY_CLASSES_ROOT, L"CLSID", classId))
				result = E_FAIL;
		}

		if (ERROR_SUCCESS != RecursiveDeleteKey(hKeyRoot, classIdKey))
			result = E_FAIL;

		if (ERROR_SUCCESS != RecursiveDeleteKey(hKeyRoot, progIdKey))
			result = E_FAIL;

		return result;
	}

	HRESULT RegisterCOMAddin(LPCWSTR pszOfficeApp, LPCWSTR pszProgID, LPCWSTR pszFriendlyName, LPCWSTR pszDescription, DWORD dwStartupContext, DWORD dwCommandLineSafe, bool registerPerMachine)
	{
		HRESULT hr = S_OK;
		WCHAR szKeyBuf[1024];
		DWORD dwTemp = 0;
		bool keyCreated = false;
		HKEY hKey;

		lstrcpy(szKeyBuf, L"Software\\Microsoft\\Office\\");
		lstrcat(szKeyBuf, pszOfficeApp);
		lstrcat(szKeyBuf, L"\\Addins\\");
		lstrcat(szKeyBuf, pszProgID);

		HKEY root = registerPerMachine ? HKEY_LOCAL_MACHINE : HKEY_CURRENT_USER;
		IfFailGo(RegCreateKeyEx(root, szKeyBuf, 0, NULL, REG_OPTION_NON_VOLATILE, _regKeyOptions, NULL, &hKey, NULL));

		IfFailGo(RegSetValueEx(hKey, L"LoadBehavior", 0, REG_DWORD, (BYTE*)&dwStartupContext, sizeof(DWORD)));
		IfFailGo(RegSetValueEx(hKey, L"CommandLineSafe", 0, REG_DWORD, (BYTE*)&dwCommandLineSafe, sizeof(DWORD)));

		if (NULL != pszFriendlyName)
		{
#if UNICODE
			dwTemp = lstrlen(pszFriendlyName) * 2 + 2;
#else
			dwTemp = lstrlen(pszFriendlyName) + 1;
#endif
			IfFailGo(RegSetValueEx(hKey, L"FriendlyName", 0, REG_SZ, (BYTE*)pszFriendlyName, dwTemp));

#if UNICODE
			dwTemp = lstrlen(pszDescription) * 2 + 2;
#else
			dwTemp = lstrlen(pszDescription) + 1;
#endif
			IfFailGo(RegSetValueEx(hKey, L"Description", 0, REG_SZ, (BYTE*)pszDescription, dwTemp));
		}

		RegCloseKey(hKey);

		return hr;
	Error:
		if (keyCreated)
		{
			RegCloseKey(hKey);
			RegDeleteKey(hKey, szKeyBuf);
		}
		return hr;
	}

	HRESULT UnRegisterCOMAddin(LPCWSTR pszOfficeApp, LPCWSTR pszProgID, bool registerPerMachine)
	{
		HRESULT result = S_OK;

		HKEY root = registerPerMachine ? HKEY_LOCAL_MACHINE : HKEY_CURRENT_USER;
		WCHAR szKeyBuf[1024];
		lstrcpy(szKeyBuf, L"Software\\Microsoft\\Office\\");
		lstrcat(szKeyBuf, pszOfficeApp);
		lstrcat(szKeyBuf, L"\\Addins\\");
		lstrcat(szKeyBuf, pszProgID);

		HRESULT hr = RecursiveDeleteKey(root, szKeyBuf);
		if (E_ACCESSDENIED != hr) // if key is missing - we dont care
		{
			result = hr;
		}

		return result;
	}

	HKEY TargetRootKey(RegisterMode mode)
	{
		HKEY hKeyRoot = HKEY_CURRENT_USER;
		switch (mode)
		{
		case System:
		case SystemComponentAndUserAddin:
			hKeyRoot = HKEY_LOCAL_MACHINE;
			break;
		}
		return hKeyRoot;
	}

	void ClassIdSubKey(LPCWSTR classId, RegisterMode mode, WCHAR* classIdKey)
	{
		lstrcpy(classIdKey, L"Software\\Classes\\CLSID\\");
		lstrcat(classIdKey, classId);
	}

	void ProgIdSubKey(LPCWSTR progId, RegisterMode mode, WCHAR* progIdKey)
	{
		lstrcpy(progIdKey, L"Software\\Classes\\");
		lstrcat(progIdKey, progId);
	}

	BOOL SetKeyAndValue(HKEY hKeyRoot, LPCWSTR pszPath, LPCWSTR pszSubkey1, LPCWSTR pszSubkey2, LPCWSTR pszSubkey3, LPCWSTR pszvalueName, LPCWSTR pszValue)
	{
		HKEY hKey;
		WCHAR szKeyBuf[1024];

		lstrcpy(szKeyBuf, pszPath);

		if (pszSubkey1 != NULL)
		{
			lstrcat(szKeyBuf, L"\\");
			lstrcat(szKeyBuf, pszSubkey1);
		}
		if (pszSubkey2 != NULL)
		{
			lstrcat(szKeyBuf, L"\\");
			lstrcat(szKeyBuf, pszSubkey2);
		}
		if (pszSubkey3 != NULL)
		{
			lstrcat(szKeyBuf, L"\\");
			lstrcat(szKeyBuf, pszSubkey3);
		}

		// if its return 5 - E_ACCESS_DENIED
		long lResult = RegCreateKeyEx(hKeyRoot, szKeyBuf, 0, NULL, REG_OPTION_NON_VOLATILE, _regKeyOptions, NULL, &hKey, NULL);
		if (lResult != ERROR_SUCCESS)
			return FALSE;

		if (pszValue != NULL)
		{
#if UNICODE
			RegSetValueEx(hKey, pszvalueName, 0, REG_SZ, (BYTE*)pszValue, lstrlen(pszValue) * 2 + 2);
#else
			RegSetValueEx(hKey, pszvalueName, 0, REG_SZ, (BYTE*)pszValue, lstrlen(pszValue) + 1);
#endif
		}

		RegCloseKey(hKey);
		return TRUE;
	}

	LONG RecursiveDeleteKey(HKEY hKeyParent, LPCWSTR pszKeyChild, LPCWSTR pszKeyChild2)
	{
		WCHAR szKeyBuf[1024];
		lstrcpy(szKeyBuf, pszKeyChild);
		lstrcat(szKeyBuf, L"\\");
		lstrcat(szKeyBuf, pszKeyChild2);
		return RecursiveDeleteKey(hKeyParent, szKeyBuf);
	}

	LONG RecursiveDeleteKey(HKEY hKeyParent, LPCWSTR pszKeyChild, LPCWSTR pszKeyChild2, LPCWSTR pszKeyChild3)
	{
		WCHAR szKeyBuf[1024];
		lstrcpy(szKeyBuf, pszKeyChild);
		lstrcat(szKeyBuf, L"\\");
		lstrcat(szKeyBuf, pszKeyChild2);
		lstrcat(szKeyBuf, L"\\");
		lstrcat(szKeyBuf, pszKeyChild3);
		return RecursiveDeleteKey(hKeyParent, szKeyBuf);
	}

	LONG RecursiveDeleteKey(HKEY hKeyParent, LPCWSTR pszKeyChild)
	{
		HKEY hKeyChild;
		LONG lRes = RegOpenKeyEx(hKeyParent, pszKeyChild, 0, _regKeyOptions, &hKeyChild);
		if (lRes != ERROR_SUCCESS)
			return lRes;

		FILETIME time;
		WCHAR szBuffer[256];
		DWORD dwSize = 256;
		while (RegEnumKeyEx(hKeyChild, 0, szBuffer, &dwSize, NULL, NULL, NULL, &time) == S_OK)
		{
			lRes = RecursiveDeleteKey(hKeyChild, szBuffer);
			if (lRes != ERROR_SUCCESS)
			{
				RegCloseKey(hKeyChild);
				return lRes;
			}
			dwSize = 256;
		}

		RegCloseKey(hKeyChild);
		return RegDeleteKey(hKeyParent, pszKeyChild);
	}
}

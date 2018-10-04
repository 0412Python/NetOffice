#pragma once
#include "StdAfx.h"
#include "metahost.h"
#include "atlbase.h"
#include "strsafe.h"
#include "ClrHost.h"
#include "Vars.hpp"
#include "Aggregators.h"
#include "Extensibility2.h"
#include "OuterUpdateAggregator.h"
#include "ShimUpdateHost.h"

extern HANDLE		_thread;
extern HINSTANCE	_module;
extern void IncComponents(LPCWSTR type);
extern void DecComponents(LPCWSTR type);

namespace NetOffice_ShimLoader
{
	class CLRUpdateHost
	{

	public:

		// Ctor, Dtor
		CLRUpdateHost();
		virtual ~CLRUpdateHost();

		// ClrLoader Methods
		BOOL STDMETHODCALLTYPE IsLoaded();
		OuterUpdateAggregator* STDMETHODCALLTYPE OuterAggregator();
		ShimUpdateHost* STDMETHODCALLTYPE Host();
		STDMETHODIMP Load();
		STDMETHODIMP Unload();
		STDMETHODIMP LastLoadError();

	protected:

		HRESULT STDMETHODCALLTYPE AppendPath(LPWSTR pszPath, LPCWSTR pszMore);

	private:

		ICorRuntimeHost*			_runtimeHost;
		mscorlib::_AppDomain*		_appDomain;
		ShimUpdateHost*				_shimHost;
		OuterUpdateAggregator*		_outerAggregator;
		BOOL						_isLoaded;
		HRESULT						_lastLoadError;

	};
}

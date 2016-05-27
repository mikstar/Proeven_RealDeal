#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


struct t4210743776;
struct t2079406803;
struct t3343412923;
struct t2663288832;

#include "Il2CppArray.h"
#include "t4210743776.h"
#include "t2079406803.h"
#include "t3343412923.h"
#include "t3880298034.h"

#pragma once
struct t3073909409  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) t4210743776 * m_Items[1];

public:
	inline t4210743776 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline t4210743776 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, t4210743776 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
struct t883218562  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) t2079406803 * m_Items[1];

public:
	inline t2079406803 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline t2079406803 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, t2079406803 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
struct t3886485498  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) t3343412923 * m_Items[1];

public:
	inline t3343412923 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline t3343412923 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, t3343412923 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
struct t69545985  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) Il2CppObject * m_Items[1];

public:
	inline Il2CppObject * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline Il2CppObject ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, Il2CppObject * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
struct t2569392327  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) t3880298034  m_Items[1];

public:
	inline t3880298034  GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline t3880298034 * GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, t3880298034  value)
	{
		m_Items[index] = value;
	}
};

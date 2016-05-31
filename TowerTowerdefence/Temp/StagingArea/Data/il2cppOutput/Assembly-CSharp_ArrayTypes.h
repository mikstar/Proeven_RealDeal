#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


struct t774521500;
struct t3337215892;
struct t4036506763;

#include "Il2CppArray.h"
#include "t774521500.h"
#include "t3337215892.h"
#include "t4036506763.h"

#pragma once
struct t1487254389  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) t774521500 * m_Items[1];

public:
	inline t774521500 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline t774521500 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, t774521500 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
struct t2954226589  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) t3337215892 * m_Items[1];

public:
	inline t3337215892 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline t3337215892 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, t3337215892 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
struct t2805131498  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) t4036506763 * m_Items[1];

public:
	inline t4036506763 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline t4036506763 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, t4036506763 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};

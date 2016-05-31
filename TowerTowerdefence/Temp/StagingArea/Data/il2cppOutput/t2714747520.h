#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t2714747520;

#include "t271618720.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2714747520  : public t271618720
{
public:

public:
};

struct t2714747520_SFs
{
public:
	t2714747520 * f0;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t2714747520_SFs, f0)); }
	inline t2714747520 * fg0() const { return f0; }
	inline t2714747520 ** fag0() { return &f0; }
	inline void fs0(t2714747520 * value)
	{
		f0 = value;
		Il2CppCodeGenWriteBarrier(&f0, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

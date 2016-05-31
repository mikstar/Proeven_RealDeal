#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t3534713449;

#include "Il2CppObject.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t1653912743  : public Il2CppObject
{
public:
	t3534713449 * f0;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t1653912743, f0)); }
	inline t3534713449 * fg0() const { return f0; }
	inline t3534713449 ** fag0() { return &f0; }
	inline void fs0(t3534713449 * value)
	{
		f0 = value;
		Il2CppCodeGenWriteBarrier(&f0, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

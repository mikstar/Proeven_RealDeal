#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t3927647597;

#include "t3458175413.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t3623432599  : public t3458175413
{
public:
	t3927647597 * f27;
	int32_t f28;

public:
	inline static int32_t fog27() { return static_cast<int32_t>(offsetof(t3623432599, f27)); }
	inline t3927647597 * fg27() const { return f27; }
	inline t3927647597 ** fag27() { return &f27; }
	inline void fs27(t3927647597 * value)
	{
		f27 = value;
		Il2CppCodeGenWriteBarrier(&f27, value);
	}

	inline static int32_t fog28() { return static_cast<int32_t>(offsetof(t3623432599, f28)); }
	inline int32_t fg28() const { return f28; }
	inline int32_t* fag28() { return &f28; }
	inline void fs28(int32_t value)
	{
		f28 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

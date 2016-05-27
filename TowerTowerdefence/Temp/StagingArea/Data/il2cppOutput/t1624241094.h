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

struct  t1624241094  : public t3458175413
{
public:
	t3927647597 * f25;
	int32_t f26;

public:
	inline static int32_t fog25() { return static_cast<int32_t>(offsetof(t1624241094, f25)); }
	inline t3927647597 * fg25() const { return f25; }
	inline t3927647597 ** fag25() { return &f25; }
	inline void fs25(t3927647597 * value)
	{
		f25 = value;
		Il2CppCodeGenWriteBarrier(&f25, value);
	}

	inline static int32_t fog26() { return static_cast<int32_t>(offsetof(t1624241094, f26)); }
	inline int32_t fg26() const { return f26; }
	inline int32_t* fag26() { return &f26; }
	inline void fs26(int32_t value)
	{
		f26 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

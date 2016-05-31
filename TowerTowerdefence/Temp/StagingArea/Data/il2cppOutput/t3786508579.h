#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t2197338622;

#include "t774292115.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t3786508579  : public t774292115
{
public:
	t2197338622 * f2;
	float f3;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t3786508579, f2)); }
	inline t2197338622 * fg2() const { return f2; }
	inline t2197338622 ** fag2() { return &f2; }
	inline void fs2(t2197338622 * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t3786508579, f3)); }
	inline float fg3() const { return f3; }
	inline float* fag3() { return &f3; }
	inline void fs3(float value)
	{
		f3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

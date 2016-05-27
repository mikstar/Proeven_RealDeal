#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t224878301;

#include "t774292115.h"
#include "t465617797.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t1298358174  : public t774292115
{
public:
	t465617797  f2;
	float f3;
	t224878301 * f4;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t1298358174, f2)); }
	inline t465617797  fg2() const { return f2; }
	inline t465617797 * fag2() { return &f2; }
	inline void fs2(t465617797  value)
	{
		f2 = value;
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t1298358174, f3)); }
	inline float fg3() const { return f3; }
	inline float* fag3() { return &f3; }
	inline void fs3(float value)
	{
		f3 = value;
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t1298358174, f4)); }
	inline t224878301 * fg4() const { return f4; }
	inline t224878301 ** fag4() { return &f4; }
	inline void fs4(t224878301 * value)
	{
		f4 = value;
		Il2CppCodeGenWriteBarrier(&f4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

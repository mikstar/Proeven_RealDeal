#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t224878301;
struct t1205782493;

#include "Il2CppObject.h"
#include "t465617797.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t3596429954  : public Il2CppObject
{
public:
	t224878301 * f0;
	bool f1;
	float f2;
	t1205782493 * f3;
	t465617797  f4;
	float f5;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t3596429954, f0)); }
	inline t224878301 * fg0() const { return f0; }
	inline t224878301 ** fag0() { return &f0; }
	inline void fs0(t224878301 * value)
	{
		f0 = value;
		Il2CppCodeGenWriteBarrier(&f0, value);
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t3596429954, f1)); }
	inline bool fg1() const { return f1; }
	inline bool* fag1() { return &f1; }
	inline void fs1(bool value)
	{
		f1 = value;
	}

	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t3596429954, f2)); }
	inline float fg2() const { return f2; }
	inline float* fag2() { return &f2; }
	inline void fs2(float value)
	{
		f2 = value;
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t3596429954, f3)); }
	inline t1205782493 * fg3() const { return f3; }
	inline t1205782493 ** fag3() { return &f3; }
	inline void fs3(t1205782493 * value)
	{
		f3 = value;
		Il2CppCodeGenWriteBarrier(&f3, value);
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t3596429954, f4)); }
	inline t465617797  fg4() const { return f4; }
	inline t465617797 * fag4() { return &f4; }
	inline void fs4(t465617797  value)
	{
		f4 = value;
	}

	inline static int32_t fog5() { return static_cast<int32_t>(offsetof(t3596429954, f5)); }
	inline float fg5() const { return f5; }
	inline float* fag5() { return &f5; }
	inline void fs5(float value)
	{
		f5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

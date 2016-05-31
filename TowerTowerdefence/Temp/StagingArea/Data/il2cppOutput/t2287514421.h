#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t224878301;
struct t1366199518;
struct t3147878106;

#include "t2922979600.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2287514421  : public t2922979600
{
public:
	float f14;
	t224878301 * f15;
	t1366199518 * f16;
	t3147878106 * f17;

public:
	inline static int32_t fog14() { return static_cast<int32_t>(offsetof(t2287514421, f14)); }
	inline float fg14() const { return f14; }
	inline float* fag14() { return &f14; }
	inline void fs14(float value)
	{
		f14 = value;
	}

	inline static int32_t fog15() { return static_cast<int32_t>(offsetof(t2287514421, f15)); }
	inline t224878301 * fg15() const { return f15; }
	inline t224878301 ** fag15() { return &f15; }
	inline void fs15(t224878301 * value)
	{
		f15 = value;
		Il2CppCodeGenWriteBarrier(&f15, value);
	}

	inline static int32_t fog16() { return static_cast<int32_t>(offsetof(t2287514421, f16)); }
	inline t1366199518 * fg16() const { return f16; }
	inline t1366199518 ** fag16() { return &f16; }
	inline void fs16(t1366199518 * value)
	{
		f16 = value;
		Il2CppCodeGenWriteBarrier(&f16, value);
	}

	inline static int32_t fog17() { return static_cast<int32_t>(offsetof(t2287514421, f17)); }
	inline t3147878106 * fg17() const { return f17; }
	inline t3147878106 ** fag17() { return &f17; }
	inline void fs17(t3147878106 * value)
	{
		f17 = value;
		Il2CppCodeGenWriteBarrier(&f17, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

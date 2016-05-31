#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t3366424004;

#include "Il2CppObject.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2574793239  : public Il2CppObject
{
public:
	float f0;
	t3366424004 * f1;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t2574793239, f0)); }
	inline float fg0() const { return f0; }
	inline float* fag0() { return &f0; }
	inline void fs0(float value)
	{
		f0 = value;
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t2574793239, f1)); }
	inline t3366424004 * fg1() const { return f1; }
	inline t3366424004 ** fag1() { return &f1; }
	inline void fs1(t3366424004 * value)
	{
		f1 = value;
		Il2CppCodeGenWriteBarrier(&f1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

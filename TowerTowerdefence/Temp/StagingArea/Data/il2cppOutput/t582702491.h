#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t1017088280;

#include "Il2CppObject.h"
#include "t83606849.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t582702491  : public Il2CppObject
{
public:

public:
};

struct t582702491_SFs
{
public:
	t83606849  f0;
	t1017088280 * f1;
	float f2;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t582702491_SFs, f0)); }
	inline t83606849  fg0() const { return f0; }
	inline t83606849 * fag0() { return &f0; }
	inline void fs0(t83606849  value)
	{
		f0 = value;
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t582702491_SFs, f1)); }
	inline t1017088280 * fg1() const { return f1; }
	inline t1017088280 ** fag1() { return &f1; }
	inline void fs1(t1017088280 * value)
	{
		f1 = value;
		Il2CppCodeGenWriteBarrier(&f1, value);
	}

	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t582702491_SFs, f2)); }
	inline float fg2() const { return f2; }
	inline float* fag2() { return &f2; }
	inline void fs2(float value)
	{
		f2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

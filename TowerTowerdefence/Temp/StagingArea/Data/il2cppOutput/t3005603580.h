#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t2744605460;

#include "t4028081426.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t3005603580 
{
public:
	t2744605460 * f0;
	int32_t f1;
	int32_t f2;
	uint16_t f3;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t3005603580, f0)); }
	inline t2744605460 * fg0() const { return f0; }
	inline t2744605460 ** fag0() { return &f0; }
	inline void fs0(t2744605460 * value)
	{
		f0 = value;
		Il2CppCodeGenWriteBarrier(&f0, value);
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t3005603580, f1)); }
	inline int32_t fg1() const { return f1; }
	inline int32_t* fag1() { return &f1; }
	inline void fs1(int32_t value)
	{
		f1 = value;
	}

	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t3005603580, f2)); }
	inline int32_t fg2() const { return f2; }
	inline int32_t* fag2() { return &f2; }
	inline void fs2(int32_t value)
	{
		f2 = value;
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t3005603580, f3)); }
	inline uint16_t fg3() const { return f3; }
	inline uint16_t* fag3() { return &f3; }
	inline void fs3(uint16_t value)
	{
		f3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

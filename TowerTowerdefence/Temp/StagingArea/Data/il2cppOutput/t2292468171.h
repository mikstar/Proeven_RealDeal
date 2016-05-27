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
#include "t2250949164.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2292468171  : public Il2CppObject
{
public:
	t2250949164  f0;
	t3534713449 * f1;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t2292468171, f0)); }
	inline t2250949164  fg0() const { return f0; }
	inline t2250949164 * fag0() { return &f0; }
	inline void fs0(t2250949164  value)
	{
		f0 = value;
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t2292468171, f1)); }
	inline t3534713449 * fg1() const { return f1; }
	inline t3534713449 ** fag1() { return &f1; }
	inline void fs1(t3534713449 * value)
	{
		f1 = value;
		Il2CppCodeGenWriteBarrier(&f1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

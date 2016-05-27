#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t224878301;

#include "Il2CppObject.h"
#include "t83606849.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2292468105  : public Il2CppObject
{
public:
	t83606849  f0;
	t224878301 * f1;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t2292468105, f0)); }
	inline t83606849  fg0() const { return f0; }
	inline t83606849 * fag0() { return &f0; }
	inline void fs0(t83606849  value)
	{
		f0 = value;
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t2292468105, f1)); }
	inline t224878301 * fg1() const { return f1; }
	inline t224878301 ** fag1() { return &f1; }
	inline void fs1(t224878301 * value)
	{
		f1 = value;
		Il2CppCodeGenWriteBarrier(&f1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

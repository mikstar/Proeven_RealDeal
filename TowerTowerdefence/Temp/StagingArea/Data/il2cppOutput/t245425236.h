#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t1639066644;
struct t2239141661;

#include "Il2CppObject.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t245425236  : public Il2CppObject
{
public:

public:
};

struct t245425236_SFs
{
public:
	t1639066644 * f0;
	t2239141661 * f1;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t245425236_SFs, f0)); }
	inline t1639066644 * fg0() const { return f0; }
	inline t1639066644 ** fag0() { return &f0; }
	inline void fs0(t1639066644 * value)
	{
		f0 = value;
		Il2CppCodeGenWriteBarrier(&f0, value);
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t245425236_SFs, f1)); }
	inline t2239141661 * fg1() const { return f1; }
	inline t2239141661 ** fag1() { return &f1; }
	inline void fs1(t2239141661 * value)
	{
		f1 = value;
		Il2CppCodeGenWriteBarrier(&f1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

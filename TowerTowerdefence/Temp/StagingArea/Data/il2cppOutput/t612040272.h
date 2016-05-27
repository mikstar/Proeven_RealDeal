#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t2815134268;

#include "t3042280348.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t612040272  : public t3042280348
{
public:

public:
};

struct t612040272_SFs
{
public:
	t2815134268 * f0;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t612040272_SFs, f0)); }
	inline t2815134268 * fg0() const { return f0; }
	inline t2815134268 ** fag0() { return &f0; }
	inline void fs0(t2815134268 * value)
	{
		f0 = value;
		Il2CppCodeGenWriteBarrier(&f0, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

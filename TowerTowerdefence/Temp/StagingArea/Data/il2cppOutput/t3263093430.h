#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct String_t;
struct t3403052772;

#include "t774292115.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t3263093430  : public t774292115
{
public:
	String_t* f2;
	t3403052772 * f3;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t3263093430, f2)); }
	inline String_t* fg2() const { return f2; }
	inline String_t** fag2() { return &f2; }
	inline void fs2(String_t* value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t3263093430, f3)); }
	inline t3403052772 * fg3() const { return f3; }
	inline t3403052772 ** fag3() { return &f3; }
	inline void fs3(t3403052772 * value)
	{
		f3 = value;
		Il2CppCodeGenWriteBarrier(&f3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

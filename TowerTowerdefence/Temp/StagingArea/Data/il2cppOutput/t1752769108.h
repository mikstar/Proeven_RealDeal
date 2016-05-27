#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t3631216940;

#include "t774292115.h"
#include "t2250949164.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t1752769108  : public t774292115
{
public:
	t3631216940 * f2;
	bool f3;
	t2250949164  f4;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t1752769108, f2)); }
	inline t3631216940 * fg2() const { return f2; }
	inline t3631216940 ** fag2() { return &f2; }
	inline void fs2(t3631216940 * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t1752769108, f3)); }
	inline bool fg3() const { return f3; }
	inline bool* fag3() { return &f3; }
	inline void fs3(bool value)
	{
		f3 = value;
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t1752769108, f4)); }
	inline t2250949164  fg4() const { return f4; }
	inline t2250949164 * fag4() { return &f4; }
	inline void fs4(t2250949164  value)
	{
		f4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

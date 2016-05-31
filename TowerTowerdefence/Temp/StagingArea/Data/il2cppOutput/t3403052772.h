#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t2038051575;
struct t3921196294;

#include "t774292115.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t3403052772  : public t774292115
{
public:
	bool f2;
	t2038051575 * f3;
	t3921196294 * f4;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t3403052772, f2)); }
	inline bool fg2() const { return f2; }
	inline bool* fag2() { return &f2; }
	inline void fs2(bool value)
	{
		f2 = value;
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t3403052772, f3)); }
	inline t2038051575 * fg3() const { return f3; }
	inline t2038051575 ** fag3() { return &f3; }
	inline void fs3(t2038051575 * value)
	{
		f3 = value;
		Il2CppCodeGenWriteBarrier(&f3, value);
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t3403052772, f4)); }
	inline t3921196294 * fg4() const { return f4; }
	inline t3921196294 ** fag4() { return &f4; }
	inline void fs4(t3921196294 * value)
	{
		f4 = value;
		Il2CppCodeGenWriteBarrier(&f4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

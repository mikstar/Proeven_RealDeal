#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t2058862956;
struct t3653751711;
struct t1366199518;

#include "t774292115.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t4136494783  : public t774292115
{
public:
	t2058862956 * f2;
	t3653751711 * f3;
	t1366199518 * f4;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t4136494783, f2)); }
	inline t2058862956 * fg2() const { return f2; }
	inline t2058862956 ** fag2() { return &f2; }
	inline void fs2(t2058862956 * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t4136494783, f3)); }
	inline t3653751711 * fg3() const { return f3; }
	inline t3653751711 ** fag3() { return &f3; }
	inline void fs3(t3653751711 * value)
	{
		f3 = value;
		Il2CppCodeGenWriteBarrier(&f3, value);
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t4136494783, f4)); }
	inline t1366199518 * fg4() const { return f4; }
	inline t1366199518 ** fag4() { return &f4; }
	inline void fs4(t1366199518 * value)
	{
		f4 = value;
		Il2CppCodeGenWriteBarrier(&f4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

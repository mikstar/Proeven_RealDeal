#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t1366199518;
struct t4222704959;
struct t2842503568;

#include "t774292115.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t1215330191  : public t774292115
{
public:
	t1366199518 * f2;
	t4222704959 * f3;
	t2842503568 * f4;
	bool f5;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t1215330191, f2)); }
	inline t1366199518 * fg2() const { return f2; }
	inline t1366199518 ** fag2() { return &f2; }
	inline void fs2(t1366199518 * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t1215330191, f3)); }
	inline t4222704959 * fg3() const { return f3; }
	inline t4222704959 ** fag3() { return &f3; }
	inline void fs3(t4222704959 * value)
	{
		f3 = value;
		Il2CppCodeGenWriteBarrier(&f3, value);
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t1215330191, f4)); }
	inline t2842503568 * fg4() const { return f4; }
	inline t2842503568 ** fag4() { return &f4; }
	inline void fs4(t2842503568 * value)
	{
		f4 = value;
		Il2CppCodeGenWriteBarrier(&f4, value);
	}

	inline static int32_t fog5() { return static_cast<int32_t>(offsetof(t1215330191, f5)); }
	inline bool fg5() const { return f5; }
	inline bool* fag5() { return &f5; }
	inline void fs5(bool value)
	{
		f5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

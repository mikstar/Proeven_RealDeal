#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t224878301;
struct t2922979600;
struct t1366199518;
struct t3099937104;

#include "t774292115.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t4036506763  : public t774292115
{
public:
	t224878301 * f2;
	float f3;
	float f4;
	t2922979600 * f5;
	t1366199518 * f6;
	t3099937104 * f7;
	t3099937104 * f8;
	bool f9;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t4036506763, f2)); }
	inline t224878301 * fg2() const { return f2; }
	inline t224878301 ** fag2() { return &f2; }
	inline void fs2(t224878301 * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t4036506763, f3)); }
	inline float fg3() const { return f3; }
	inline float* fag3() { return &f3; }
	inline void fs3(float value)
	{
		f3 = value;
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t4036506763, f4)); }
	inline float fg4() const { return f4; }
	inline float* fag4() { return &f4; }
	inline void fs4(float value)
	{
		f4 = value;
	}

	inline static int32_t fog5() { return static_cast<int32_t>(offsetof(t4036506763, f5)); }
	inline t2922979600 * fg5() const { return f5; }
	inline t2922979600 ** fag5() { return &f5; }
	inline void fs5(t2922979600 * value)
	{
		f5 = value;
		Il2CppCodeGenWriteBarrier(&f5, value);
	}

	inline static int32_t fog6() { return static_cast<int32_t>(offsetof(t4036506763, f6)); }
	inline t1366199518 * fg6() const { return f6; }
	inline t1366199518 ** fag6() { return &f6; }
	inline void fs6(t1366199518 * value)
	{
		f6 = value;
		Il2CppCodeGenWriteBarrier(&f6, value);
	}

	inline static int32_t fog7() { return static_cast<int32_t>(offsetof(t4036506763, f7)); }
	inline t3099937104 * fg7() const { return f7; }
	inline t3099937104 ** fag7() { return &f7; }
	inline void fs7(t3099937104 * value)
	{
		f7 = value;
		Il2CppCodeGenWriteBarrier(&f7, value);
	}

	inline static int32_t fog8() { return static_cast<int32_t>(offsetof(t4036506763, f8)); }
	inline t3099937104 * fg8() const { return f8; }
	inline t3099937104 ** fag8() { return &f8; }
	inline void fs8(t3099937104 * value)
	{
		f8 = value;
		Il2CppCodeGenWriteBarrier(&f8, value);
	}

	inline static int32_t fog9() { return static_cast<int32_t>(offsetof(t4036506763, f9)); }
	inline bool fg9() const { return f9; }
	inline bool* fag9() { return &f9; }
	inline void fs9(bool value)
	{
		f9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

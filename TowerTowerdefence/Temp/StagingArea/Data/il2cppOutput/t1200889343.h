#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t2331662484;
struct t2197338622;
struct t3575456220;

#include "t774292115.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t1200889343  : public t774292115
{
public:
	float f2;
	t2331662484 * f3;
	t2197338622 * f4;
	t3575456220 * f5;
	float f6;
	bool f7;
	float f8;
	bool f9;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t1200889343, f2)); }
	inline float fg2() const { return f2; }
	inline float* fag2() { return &f2; }
	inline void fs2(float value)
	{
		f2 = value;
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t1200889343, f3)); }
	inline t2331662484 * fg3() const { return f3; }
	inline t2331662484 ** fag3() { return &f3; }
	inline void fs3(t2331662484 * value)
	{
		f3 = value;
		Il2CppCodeGenWriteBarrier(&f3, value);
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t1200889343, f4)); }
	inline t2197338622 * fg4() const { return f4; }
	inline t2197338622 ** fag4() { return &f4; }
	inline void fs4(t2197338622 * value)
	{
		f4 = value;
		Il2CppCodeGenWriteBarrier(&f4, value);
	}

	inline static int32_t fog5() { return static_cast<int32_t>(offsetof(t1200889343, f5)); }
	inline t3575456220 * fg5() const { return f5; }
	inline t3575456220 ** fag5() { return &f5; }
	inline void fs5(t3575456220 * value)
	{
		f5 = value;
		Il2CppCodeGenWriteBarrier(&f5, value);
	}

	inline static int32_t fog6() { return static_cast<int32_t>(offsetof(t1200889343, f6)); }
	inline float fg6() const { return f6; }
	inline float* fag6() { return &f6; }
	inline void fs6(float value)
	{
		f6 = value;
	}

	inline static int32_t fog7() { return static_cast<int32_t>(offsetof(t1200889343, f7)); }
	inline bool fg7() const { return f7; }
	inline bool* fag7() { return &f7; }
	inline void fs7(bool value)
	{
		f7 = value;
	}

	inline static int32_t fog8() { return static_cast<int32_t>(offsetof(t1200889343, f8)); }
	inline float fg8() const { return f8; }
	inline float* fag8() { return &f8; }
	inline void fs8(float value)
	{
		f8 = value;
	}

	inline static int32_t fog9() { return static_cast<int32_t>(offsetof(t1200889343, f9)); }
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

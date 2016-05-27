#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t224878301;

#include "t774292115.h"
#include "t465617797.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2982202219  : public t774292115
{
public:
	t224878301 * f2;
	t465617797  f3;
	float f4;
	t465617797  f5;
	t465617797  f6;
	float f7;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t2982202219, f2)); }
	inline t224878301 * fg2() const { return f2; }
	inline t224878301 ** fag2() { return &f2; }
	inline void fs2(t224878301 * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t2982202219, f3)); }
	inline t465617797  fg3() const { return f3; }
	inline t465617797 * fag3() { return &f3; }
	inline void fs3(t465617797  value)
	{
		f3 = value;
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t2982202219, f4)); }
	inline float fg4() const { return f4; }
	inline float* fag4() { return &f4; }
	inline void fs4(float value)
	{
		f4 = value;
	}

	inline static int32_t fog5() { return static_cast<int32_t>(offsetof(t2982202219, f5)); }
	inline t465617797  fg5() const { return f5; }
	inline t465617797 * fag5() { return &f5; }
	inline void fs5(t465617797  value)
	{
		f5 = value;
	}

	inline static int32_t fog6() { return static_cast<int32_t>(offsetof(t2982202219, f6)); }
	inline t465617797  fg6() const { return f6; }
	inline t465617797 * fag6() { return &f6; }
	inline void fs6(t465617797  value)
	{
		f6 = value;
	}

	inline static int32_t fog7() { return static_cast<int32_t>(offsetof(t2982202219, f7)); }
	inline float fg7() const { return f7; }
	inline float* fag7() { return &f7; }
	inline void fs7(float value)
	{
		f7 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

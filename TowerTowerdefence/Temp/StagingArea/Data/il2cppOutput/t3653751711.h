#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t3653751711;

#include "t774292115.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t3653751711  : public t774292115
{
public:
	int32_t f3;
	float f4;
	float f5;

public:
	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t3653751711, f3)); }
	inline int32_t fg3() const { return f3; }
	inline int32_t* fag3() { return &f3; }
	inline void fs3(int32_t value)
	{
		f3 = value;
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t3653751711, f4)); }
	inline float fg4() const { return f4; }
	inline float* fag4() { return &f4; }
	inline void fs4(float value)
	{
		f4 = value;
	}

	inline static int32_t fog5() { return static_cast<int32_t>(offsetof(t3653751711, f5)); }
	inline float fg5() const { return f5; }
	inline float* fag5() { return &f5; }
	inline void fs5(float value)
	{
		f5 = value;
	}
};

struct t3653751711_SFs
{
public:
	t3653751711 * f2;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t3653751711_SFs, f2)); }
	inline t3653751711 * fg2() const { return f2; }
	inline t3653751711 ** fag2() { return &f2; }
	inline void fs2(t3653751711 * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

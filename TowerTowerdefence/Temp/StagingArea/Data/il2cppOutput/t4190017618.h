#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t1521045304;
struct t3366424004;
struct t4188408365;
struct String_t;

#include "t1466230440.h"
#include "t1498964138.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t4190017618  : public t1466230440
{
public:
	float f53;
	float f54;
	float f55;
	t1498964138  f56;
	t1521045304 * f57;
	t3366424004 * f58;
	t4188408365 * f59;

public:
	inline static int32_t fog53() { return static_cast<int32_t>(offsetof(t4190017618, f53)); }
	inline float fg53() const { return f53; }
	inline float* fag53() { return &f53; }
	inline void fs53(float value)
	{
		f53 = value;
	}

	inline static int32_t fog54() { return static_cast<int32_t>(offsetof(t4190017618, f54)); }
	inline float fg54() const { return f54; }
	inline float* fag54() { return &f54; }
	inline void fs54(float value)
	{
		f54 = value;
	}

	inline static int32_t fog55() { return static_cast<int32_t>(offsetof(t4190017618, f55)); }
	inline float fg55() const { return f55; }
	inline float* fag55() { return &f55; }
	inline void fs55(float value)
	{
		f55 = value;
	}

	inline static int32_t fog56() { return static_cast<int32_t>(offsetof(t4190017618, f56)); }
	inline t1498964138  fg56() const { return f56; }
	inline t1498964138 * fag56() { return &f56; }
	inline void fs56(t1498964138  value)
	{
		f56 = value;
	}

	inline static int32_t fog57() { return static_cast<int32_t>(offsetof(t4190017618, f57)); }
	inline t1521045304 * fg57() const { return f57; }
	inline t1521045304 ** fag57() { return &f57; }
	inline void fs57(t1521045304 * value)
	{
		f57 = value;
		Il2CppCodeGenWriteBarrier(&f57, value);
	}

	inline static int32_t fog58() { return static_cast<int32_t>(offsetof(t4190017618, f58)); }
	inline t3366424004 * fg58() const { return f58; }
	inline t3366424004 ** fag58() { return &f58; }
	inline void fs58(t3366424004 * value)
	{
		f58 = value;
		Il2CppCodeGenWriteBarrier(&f58, value);
	}

	inline static int32_t fog59() { return static_cast<int32_t>(offsetof(t4190017618, f59)); }
	inline t4188408365 * fg59() const { return f59; }
	inline t4188408365 ** fag59() { return &f59; }
	inline void fs59(t4188408365 * value)
	{
		f59 = value;
		Il2CppCodeGenWriteBarrier(&f59, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t338797655;
struct t2184176355;
struct t1689743516;
struct String_t;

#include "t1466230440.h"
#include "t2099627725.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t1691352769  : public t1466230440
{
public:
	double f53;
	double f54;
	double f55;
	t2099627725  f56;
	t338797655 * f57;
	t2184176355 * f58;
	t1689743516 * f59;

public:
	inline static int32_t fog53() { return static_cast<int32_t>(offsetof(t1691352769, f53)); }
	inline double fg53() const { return f53; }
	inline double* fag53() { return &f53; }
	inline void fs53(double value)
	{
		f53 = value;
	}

	inline static int32_t fog54() { return static_cast<int32_t>(offsetof(t1691352769, f54)); }
	inline double fg54() const { return f54; }
	inline double* fag54() { return &f54; }
	inline void fs54(double value)
	{
		f54 = value;
	}

	inline static int32_t fog55() { return static_cast<int32_t>(offsetof(t1691352769, f55)); }
	inline double fg55() const { return f55; }
	inline double* fag55() { return &f55; }
	inline void fs55(double value)
	{
		f55 = value;
	}

	inline static int32_t fog56() { return static_cast<int32_t>(offsetof(t1691352769, f56)); }
	inline t2099627725  fg56() const { return f56; }
	inline t2099627725 * fag56() { return &f56; }
	inline void fs56(t2099627725  value)
	{
		f56 = value;
	}

	inline static int32_t fog57() { return static_cast<int32_t>(offsetof(t1691352769, f57)); }
	inline t338797655 * fg57() const { return f57; }
	inline t338797655 ** fag57() { return &f57; }
	inline void fs57(t338797655 * value)
	{
		f57 = value;
		Il2CppCodeGenWriteBarrier(&f57, value);
	}

	inline static int32_t fog58() { return static_cast<int32_t>(offsetof(t1691352769, f58)); }
	inline t2184176355 * fg58() const { return f58; }
	inline t2184176355 ** fag58() { return &f58; }
	inline void fs58(t2184176355 * value)
	{
		f58 = value;
		Il2CppCodeGenWriteBarrier(&f58, value);
	}

	inline static int32_t fog59() { return static_cast<int32_t>(offsetof(t1691352769, f59)); }
	inline t1689743516 * fg59() const { return f59; }
	inline t1689743516 ** fag59() { return &f59; }
	inline void fs59(t1689743516 * value)
	{
		f59 = value;
		Il2CppCodeGenWriteBarrier(&f59, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

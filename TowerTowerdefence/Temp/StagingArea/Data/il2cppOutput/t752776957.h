#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t2488847970;
struct t39259374;
struct t751167704;
struct String_t;

#include "t1466230440.h"
#include "t2099627725.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t752776957  : public t1466230440
{
public:
	uint64_t f53;
	uint64_t f54;
	uint64_t f55;
	t2099627725  f56;
	t2488847970 * f57;
	t39259374 * f58;
	t751167704 * f59;

public:
	inline static int32_t fog53() { return static_cast<int32_t>(offsetof(t752776957, f53)); }
	inline uint64_t fg53() const { return f53; }
	inline uint64_t* fag53() { return &f53; }
	inline void fs53(uint64_t value)
	{
		f53 = value;
	}

	inline static int32_t fog54() { return static_cast<int32_t>(offsetof(t752776957, f54)); }
	inline uint64_t fg54() const { return f54; }
	inline uint64_t* fag54() { return &f54; }
	inline void fs54(uint64_t value)
	{
		f54 = value;
	}

	inline static int32_t fog55() { return static_cast<int32_t>(offsetof(t752776957, f55)); }
	inline uint64_t fg55() const { return f55; }
	inline uint64_t* fag55() { return &f55; }
	inline void fs55(uint64_t value)
	{
		f55 = value;
	}

	inline static int32_t fog56() { return static_cast<int32_t>(offsetof(t752776957, f56)); }
	inline t2099627725  fg56() const { return f56; }
	inline t2099627725 * fag56() { return &f56; }
	inline void fs56(t2099627725  value)
	{
		f56 = value;
	}

	inline static int32_t fog57() { return static_cast<int32_t>(offsetof(t752776957, f57)); }
	inline t2488847970 * fg57() const { return f57; }
	inline t2488847970 ** fag57() { return &f57; }
	inline void fs57(t2488847970 * value)
	{
		f57 = value;
		Il2CppCodeGenWriteBarrier(&f57, value);
	}

	inline static int32_t fog58() { return static_cast<int32_t>(offsetof(t752776957, f58)); }
	inline t39259374 * fg58() const { return f58; }
	inline t39259374 ** fag58() { return &f58; }
	inline void fs58(t39259374 * value)
	{
		f58 = value;
		Il2CppCodeGenWriteBarrier(&f58, value);
	}

	inline static int32_t fog59() { return static_cast<int32_t>(offsetof(t752776957, f59)); }
	inline t751167704 * fg59() const { return f59; }
	inline t751167704 ** fag59() { return &f59; }
	inline void fs59(t751167704 * value)
	{
		f59 = value;
		Il2CppCodeGenWriteBarrier(&f59, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

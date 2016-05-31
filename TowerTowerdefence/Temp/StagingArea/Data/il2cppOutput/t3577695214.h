#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t1366199518;
struct t224878301;
struct t278416205;

#include "t2922979600.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t3577695214  : public t2922979600
{
public:
	t1366199518 * f14;
	t224878301 * f15;
	t278416205 * f16;

public:
	inline static int32_t fog14() { return static_cast<int32_t>(offsetof(t3577695214, f14)); }
	inline t1366199518 * fg14() const { return f14; }
	inline t1366199518 ** fag14() { return &f14; }
	inline void fs14(t1366199518 * value)
	{
		f14 = value;
		Il2CppCodeGenWriteBarrier(&f14, value);
	}

	inline static int32_t fog15() { return static_cast<int32_t>(offsetof(t3577695214, f15)); }
	inline t224878301 * fg15() const { return f15; }
	inline t224878301 ** fag15() { return &f15; }
	inline void fs15(t224878301 * value)
	{
		f15 = value;
		Il2CppCodeGenWriteBarrier(&f15, value);
	}

	inline static int32_t fog16() { return static_cast<int32_t>(offsetof(t3577695214, f16)); }
	inline t278416205 * fg16() const { return f16; }
	inline t278416205 ** fag16() { return &f16; }
	inline void fs16(t278416205 * value)
	{
		f16 = value;
		Il2CppCodeGenWriteBarrier(&f16, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

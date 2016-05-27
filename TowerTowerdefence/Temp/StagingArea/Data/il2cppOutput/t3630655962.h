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
struct t2974286096;
struct t4136494783;

#include "t774292115.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t3630655962  : public t774292115
{
public:
	t1366199518 * f2;
	int32_t f3;
	t224878301 * f4;
	t2974286096* f5;
	t224878301 * f6;
	t4136494783 * f7;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t3630655962, f2)); }
	inline t1366199518 * fg2() const { return f2; }
	inline t1366199518 ** fag2() { return &f2; }
	inline void fs2(t1366199518 * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t3630655962, f3)); }
	inline int32_t fg3() const { return f3; }
	inline int32_t* fag3() { return &f3; }
	inline void fs3(int32_t value)
	{
		f3 = value;
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t3630655962, f4)); }
	inline t224878301 * fg4() const { return f4; }
	inline t224878301 ** fag4() { return &f4; }
	inline void fs4(t224878301 * value)
	{
		f4 = value;
		Il2CppCodeGenWriteBarrier(&f4, value);
	}

	inline static int32_t fog5() { return static_cast<int32_t>(offsetof(t3630655962, f5)); }
	inline t2974286096* fg5() const { return f5; }
	inline t2974286096** fag5() { return &f5; }
	inline void fs5(t2974286096* value)
	{
		f5 = value;
		Il2CppCodeGenWriteBarrier(&f5, value);
	}

	inline static int32_t fog6() { return static_cast<int32_t>(offsetof(t3630655962, f6)); }
	inline t224878301 * fg6() const { return f6; }
	inline t224878301 ** fag6() { return &f6; }
	inline void fs6(t224878301 * value)
	{
		f6 = value;
		Il2CppCodeGenWriteBarrier(&f6, value);
	}

	inline static int32_t fog7() { return static_cast<int32_t>(offsetof(t3630655962, f7)); }
	inline t4136494783 * fg7() const { return f7; }
	inline t4136494783 ** fag7() { return &f7; }
	inline void fs7(t4136494783 * value)
	{
		f7 = value;
		Il2CppCodeGenWriteBarrier(&f7, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

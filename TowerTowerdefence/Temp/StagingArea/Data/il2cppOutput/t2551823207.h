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

#include "t774292115.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2551823207  : public t774292115
{
public:
	t224878301 * f2;
	t224878301 * f3;
	t224878301 * f4;
	t224878301 * f5;
	t2922979600 * f6;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t2551823207, f2)); }
	inline t224878301 * fg2() const { return f2; }
	inline t224878301 ** fag2() { return &f2; }
	inline void fs2(t224878301 * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t2551823207, f3)); }
	inline t224878301 * fg3() const { return f3; }
	inline t224878301 ** fag3() { return &f3; }
	inline void fs3(t224878301 * value)
	{
		f3 = value;
		Il2CppCodeGenWriteBarrier(&f3, value);
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t2551823207, f4)); }
	inline t224878301 * fg4() const { return f4; }
	inline t224878301 ** fag4() { return &f4; }
	inline void fs4(t224878301 * value)
	{
		f4 = value;
		Il2CppCodeGenWriteBarrier(&f4, value);
	}

	inline static int32_t fog5() { return static_cast<int32_t>(offsetof(t2551823207, f5)); }
	inline t224878301 * fg5() const { return f5; }
	inline t224878301 ** fag5() { return &f5; }
	inline void fs5(t224878301 * value)
	{
		f5 = value;
		Il2CppCodeGenWriteBarrier(&f5, value);
	}

	inline static int32_t fog6() { return static_cast<int32_t>(offsetof(t2551823207, f6)); }
	inline t2922979600 * fg6() const { return f6; }
	inline t2922979600 ** fag6() { return &f6; }
	inline void fs6(t2922979600 * value)
	{
		f6 = value;
		Il2CppCodeGenWriteBarrier(&f6, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t224878301;
struct t2005073387;
struct t1366199518;
struct t4136494783;

#include "t774292115.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t4269630218  : public t774292115
{
public:
	t224878301 * f2;
	t2005073387* f3;
	t1366199518 * f4;
	t4136494783 * f5;
	t1366199518 * f6;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t4269630218, f2)); }
	inline t224878301 * fg2() const { return f2; }
	inline t224878301 ** fag2() { return &f2; }
	inline void fs2(t224878301 * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t4269630218, f3)); }
	inline t2005073387* fg3() const { return f3; }
	inline t2005073387** fag3() { return &f3; }
	inline void fs3(t2005073387* value)
	{
		f3 = value;
		Il2CppCodeGenWriteBarrier(&f3, value);
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t4269630218, f4)); }
	inline t1366199518 * fg4() const { return f4; }
	inline t1366199518 ** fag4() { return &f4; }
	inline void fs4(t1366199518 * value)
	{
		f4 = value;
		Il2CppCodeGenWriteBarrier(&f4, value);
	}

	inline static int32_t fog5() { return static_cast<int32_t>(offsetof(t4269630218, f5)); }
	inline t4136494783 * fg5() const { return f5; }
	inline t4136494783 ** fag5() { return &f5; }
	inline void fs5(t4136494783 * value)
	{
		f5 = value;
		Il2CppCodeGenWriteBarrier(&f5, value);
	}

	inline static int32_t fog6() { return static_cast<int32_t>(offsetof(t4269630218, f6)); }
	inline t1366199518 * fg6() const { return f6; }
	inline t1366199518 ** fag6() { return &f6; }
	inline void fs6(t1366199518 * value)
	{
		f6 = value;
		Il2CppCodeGenWriteBarrier(&f6, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

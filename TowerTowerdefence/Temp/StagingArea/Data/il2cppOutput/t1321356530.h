#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t1685951112;

#include "Il2CppObject.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t1321356530  : public Il2CppObject
{
public:

public:
};

struct t1321356530_SFs
{
public:
	t1685951112* f0;
	t1685951112* f1;
	t1685951112* f2;
	t1685951112* f3;
	int32_t f4;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t1321356530_SFs, f0)); }
	inline t1685951112* fg0() const { return f0; }
	inline t1685951112** fag0() { return &f0; }
	inline void fs0(t1685951112* value)
	{
		f0 = value;
		Il2CppCodeGenWriteBarrier(&f0, value);
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t1321356530_SFs, f1)); }
	inline t1685951112* fg1() const { return f1; }
	inline t1685951112** fag1() { return &f1; }
	inline void fs1(t1685951112* value)
	{
		f1 = value;
		Il2CppCodeGenWriteBarrier(&f1, value);
	}

	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t1321356530_SFs, f2)); }
	inline t1685951112* fg2() const { return f2; }
	inline t1685951112** fag2() { return &f2; }
	inline void fs2(t1685951112* value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t1321356530_SFs, f3)); }
	inline t1685951112* fg3() const { return f3; }
	inline t1685951112** fag3() { return &f3; }
	inline void fs3(t1685951112* value)
	{
		f3 = value;
		Il2CppCodeGenWriteBarrier(&f3, value);
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t1321356530_SFs, f4)); }
	inline int32_t fg4() const { return f4; }
	inline int32_t* fag4() { return &f4; }
	inline void fs4(int32_t value)
	{
		f4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

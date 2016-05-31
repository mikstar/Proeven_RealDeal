#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>


#include "t4028081426.h"
#include "t3171629144.h"
#include "t2401650994.h"
#include "t465617797.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t3168814500 
{
public:
	int32_t f0;
	int32_t f1;
	t465617797  f2;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t3168814500, f0)); }
	inline int32_t fg0() const { return f0; }
	inline int32_t* fag0() { return &f0; }
	inline void fs0(int32_t value)
	{
		f0 = value;
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t3168814500, f1)); }
	inline int32_t fg1() const { return f1; }
	inline int32_t* fag1() { return &f1; }
	inline void fs1(int32_t value)
	{
		f1 = value;
	}

	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t3168814500, f2)); }
	inline t465617797  fg2() const { return f2; }
	inline t465617797 * fag2() { return &f2; }
	inline void fs2(t465617797  value)
	{
		f2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for marshalling of: DG.Tweening.Plugins.Options.QuaternionOptions
struct t3168814500_marshaled_pinvoke
{
	int32_t f0;
	int32_t f1;
	t465617797_marshaled_pinvoke f2;
};
// Native definition for marshalling of: DG.Tweening.Plugins.Options.QuaternionOptions
struct t3168814500_marshaled_com
{
	int32_t f0;
	int32_t f1;
	t465617797_marshaled_com f2;
};

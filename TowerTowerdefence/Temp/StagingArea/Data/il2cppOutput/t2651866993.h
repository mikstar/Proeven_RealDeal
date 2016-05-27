#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>


#include "t4028081426.h"
#include "t2250949164.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t2651866993 
{
public:
	t2250949164  f0;
	t2250949164  f1;

public:
	inline static int32_t fog0() { return static_cast<int32_t>(offsetof(t2651866993, f0)); }
	inline t2250949164  fg0() const { return f0; }
	inline t2250949164 * fag0() { return &f0; }
	inline void fs0(t2250949164  value)
	{
		f0 = value;
	}

	inline static int32_t fog1() { return static_cast<int32_t>(offsetof(t2651866993, f1)); }
	inline t2250949164  fg1() const { return f1; }
	inline t2250949164 * fag1() { return &f1; }
	inline void fs1(t2250949164  value)
	{
		f1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for marshalling of: DG.Tweening.Color2
struct t2651866993_marshaled_pinvoke
{
	t2250949164_marshaled_pinvoke f0;
	t2250949164_marshaled_pinvoke f1;
};
// Native definition for marshalling of: DG.Tweening.Color2
struct t2651866993_marshaled_com
{
	t2250949164_marshaled_com f0;
	t2250949164_marshaled_com f1;
};

#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>


#include "t2922979600.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t149139656  : public t2922979600
{
public:
	float f13;
	float f14;

public:
	inline static int32_t fog13() { return static_cast<int32_t>(offsetof(t149139656, f13)); }
	inline float fg13() const { return f13; }
	inline float* fag13() { return &f13; }
	inline void fs13(float value)
	{
		f13 = value;
	}

	inline static int32_t fog14() { return static_cast<int32_t>(offsetof(t149139656, f14)); }
	inline float fg14() const { return f14; }
	inline float* fag14() { return &f14; }
	inline void fs14(float value)
	{
		f14 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>


#include "codegen/il2cpp-codegen.h"


struct t2993235570;
struct t2993235570_marshaled_pinvoke;

extern "C" void t2993235570_marshal_pinvoke(const t2993235570& unmarshaled, t2993235570_marshaled_pinvoke& marshaled);
extern "C" void t2993235570_marshal_pinvoke_back(const t2993235570_marshaled_pinvoke& marshaled, t2993235570& unmarshaled);
extern "C" void t2993235570_marshal_pinvoke_cleanup(t2993235570_marshaled_pinvoke& marshaled);

struct t2993235570;
struct t2993235570_marshaled_com;

extern "C" void t2993235570_marshal_com(const t2993235570& unmarshaled, t2993235570_marshaled_com& marshaled);
extern "C" void t2993235570_marshal_com_back(const t2993235570_marshaled_com& marshaled, t2993235570& unmarshaled);
extern "C" void t2993235570_marshal_com_cleanup(t2993235570_marshaled_com& marshaled);

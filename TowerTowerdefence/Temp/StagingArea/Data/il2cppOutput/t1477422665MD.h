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


struct t1477422665;
struct t1477422665_marshaled_pinvoke;

extern "C" void t1477422665_marshal_pinvoke(const t1477422665& unmarshaled, t1477422665_marshaled_pinvoke& marshaled);
extern "C" void t1477422665_marshal_pinvoke_back(const t1477422665_marshaled_pinvoke& marshaled, t1477422665& unmarshaled);
extern "C" void t1477422665_marshal_pinvoke_cleanup(t1477422665_marshaled_pinvoke& marshaled);

struct t1477422665;
struct t1477422665_marshaled_com;

extern "C" void t1477422665_marshal_com(const t1477422665& unmarshaled, t1477422665_marshaled_com& marshaled);
extern "C" void t1477422665_marshal_com_back(const t1477422665_marshaled_com& marshaled, t1477422665& unmarshaled);
extern "C" void t1477422665_marshal_com_cleanup(t1477422665_marshaled_com& marshaled);

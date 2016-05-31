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


struct t978152011;
struct t978152011_marshaled_pinvoke;

extern "C" void t978152011_marshal_pinvoke(const t978152011& unmarshaled, t978152011_marshaled_pinvoke& marshaled);
extern "C" void t978152011_marshal_pinvoke_back(const t978152011_marshaled_pinvoke& marshaled, t978152011& unmarshaled);
extern "C" void t978152011_marshal_pinvoke_cleanup(t978152011_marshaled_pinvoke& marshaled);

struct t978152011;
struct t978152011_marshaled_com;

extern "C" void t978152011_marshal_com(const t978152011& unmarshaled, t978152011_marshaled_com& marshaled);
extern "C" void t978152011_marshal_com_back(const t978152011_marshaled_com& marshaled, t978152011& unmarshaled);
extern "C" void t978152011_marshal_com_cleanup(t978152011_marshaled_com& marshaled);

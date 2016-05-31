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


struct t3168814500;
struct t3168814500_marshaled_pinvoke;

extern "C" void t3168814500_marshal_pinvoke(const t3168814500& unmarshaled, t3168814500_marshaled_pinvoke& marshaled);
extern "C" void t3168814500_marshal_pinvoke_back(const t3168814500_marshaled_pinvoke& marshaled, t3168814500& unmarshaled);
extern "C" void t3168814500_marshal_pinvoke_cleanup(t3168814500_marshaled_pinvoke& marshaled);

struct t3168814500;
struct t3168814500_marshaled_com;

extern "C" void t3168814500_marshal_com(const t3168814500& unmarshaled, t3168814500_marshaled_com& marshaled);
extern "C" void t3168814500_marshal_com_back(const t3168814500_marshaled_com& marshaled, t3168814500& unmarshaled);
extern "C" void t3168814500_marshal_com_cleanup(t3168814500_marshaled_com& marshaled);

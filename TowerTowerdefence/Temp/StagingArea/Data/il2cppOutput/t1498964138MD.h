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


struct t1498964138;
struct t1498964138_marshaled_pinvoke;

extern "C" void t1498964138_marshal_pinvoke(const t1498964138& unmarshaled, t1498964138_marshaled_pinvoke& marshaled);
extern "C" void t1498964138_marshal_pinvoke_back(const t1498964138_marshaled_pinvoke& marshaled, t1498964138& unmarshaled);
extern "C" void t1498964138_marshal_pinvoke_cleanup(t1498964138_marshaled_pinvoke& marshaled);

struct t1498964138;
struct t1498964138_marshaled_com;

extern "C" void t1498964138_marshal_com(const t1498964138& unmarshaled, t1498964138_marshaled_com& marshaled);
extern "C" void t1498964138_marshal_com_back(const t1498964138_marshaled_com& marshaled, t1498964138& unmarshaled);
extern "C" void t1498964138_marshal_com_cleanup(t1498964138_marshaled_com& marshaled);

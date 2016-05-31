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


struct t279748722;
struct t279748722_marshaled_pinvoke;

extern "C" void t279748722_marshal_pinvoke(const t279748722& unmarshaled, t279748722_marshaled_pinvoke& marshaled);
extern "C" void t279748722_marshal_pinvoke_back(const t279748722_marshaled_pinvoke& marshaled, t279748722& unmarshaled);
extern "C" void t279748722_marshal_pinvoke_cleanup(t279748722_marshaled_pinvoke& marshaled);

struct t279748722;
struct t279748722_marshaled_com;

extern "C" void t279748722_marshal_com(const t279748722& unmarshaled, t279748722_marshaled_com& marshaled);
extern "C" void t279748722_marshal_com_back(const t279748722_marshaled_com& marshaled, t279748722& unmarshaled);
extern "C" void t279748722_marshal_com_cleanup(t279748722_marshaled_com& marshaled);

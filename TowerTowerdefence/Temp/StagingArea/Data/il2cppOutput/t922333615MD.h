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


struct t922333615;
struct t922333615_marshaled_pinvoke;

extern "C" void t922333615_marshal_pinvoke(const t922333615& unmarshaled, t922333615_marshaled_pinvoke& marshaled);
extern "C" void t922333615_marshal_pinvoke_back(const t922333615_marshaled_pinvoke& marshaled, t922333615& unmarshaled);
extern "C" void t922333615_marshal_pinvoke_cleanup(t922333615_marshaled_pinvoke& marshaled);

struct t922333615;
struct t922333615_marshaled_com;

extern "C" void t922333615_marshal_com(const t922333615& unmarshaled, t922333615_marshaled_com& marshaled);
extern "C" void t922333615_marshal_com_back(const t922333615_marshaled_com& marshaled, t922333615& unmarshaled);
extern "C" void t922333615_marshal_com_cleanup(t922333615_marshaled_com& marshaled);

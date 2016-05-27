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


struct t963149831;
struct t963149831_marshaled_pinvoke;

extern "C" void t963149831_marshal_pinvoke(const t963149831& unmarshaled, t963149831_marshaled_pinvoke& marshaled);
extern "C" void t963149831_marshal_pinvoke_back(const t963149831_marshaled_pinvoke& marshaled, t963149831& unmarshaled);
extern "C" void t963149831_marshal_pinvoke_cleanup(t963149831_marshaled_pinvoke& marshaled);

struct t963149831;
struct t963149831_marshaled_com;

extern "C" void t963149831_marshal_com(const t963149831& unmarshaled, t963149831_marshaled_com& marshaled);
extern "C" void t963149831_marshal_com_back(const t963149831_marshaled_com& marshaled, t963149831& unmarshaled);
extern "C" void t963149831_marshal_com_cleanup(t963149831_marshaled_com& marshaled);

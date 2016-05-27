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

struct String_t;

#include "codegen/il2cpp-codegen.h"
#include "t587186416.h"
#include "String_t.h"

extern "C"  String_t* m1281040133 (t587186416 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
extern "C"  void m2410239828 (t587186416 * __this, String_t* p0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
extern "C"  String_t* m2091758568 (t587186416 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
extern "C"  void m1385708911 (t587186416 * __this, String_t* p0, const MethodInfo* method) IL2CPP_METHOD_ATTR;

struct t587186416;
struct t587186416_marshaled_pinvoke;

extern "C" void t587186416_marshal_pinvoke(const t587186416& unmarshaled, t587186416_marshaled_pinvoke& marshaled);
extern "C" void t587186416_marshal_pinvoke_back(const t587186416_marshaled_pinvoke& marshaled, t587186416& unmarshaled);
extern "C" void t587186416_marshal_pinvoke_cleanup(t587186416_marshaled_pinvoke& marshaled);

struct t587186416;
struct t587186416_marshaled_com;

extern "C" void t587186416_marshal_com(const t587186416& unmarshaled, t587186416_marshaled_com& marshaled);
extern "C" void t587186416_marshal_com_back(const t587186416_marshaled_com& marshaled, t587186416& unmarshaled);
extern "C" void t587186416_marshal_com_cleanup(t587186416_marshaled_com& marshaled);

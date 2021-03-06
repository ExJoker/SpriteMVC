﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaPerfect_ObjectFormaterWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaPerfect.ObjectFormater), typeof(System.Object));
		L.RegFunction("IsBasicType", IsBasicType);
		L.RegFunction("GetAllFields", GetAllFields);
		L.RegFunction("FindProperty", FindProperty);
		L.RegFunction("GetAllProperties", GetAllProperties);
		L.RegFunction("GetClassFullName", GetClassFullName);
		L.RegFunction("GetClassInfo", GetClassInfo);
		L.RegFunction("GetChildrenGameObjects", GetChildrenGameObjects);
		L.RegFunction("FormatObject", FormatObject);
		L.RegFunction("InnerFormatObject", InnerFormatObject);
		L.RegFunction("ClearObjectCache", ClearObjectCache);
		L.RegFunction("New", _CreateLuaPerfect_ObjectFormater);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("s_classInfoDirectionary", get_s_classInfoDirectionary, set_s_classInfoDirectionary);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaPerfect_ObjectFormater(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				LuaPerfect.ObjectFormater obj = new LuaPerfect.ObjectFormater();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: LuaPerfect.ObjectFormater.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsBasicType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 1);
			bool o = LuaPerfect.ObjectFormater.IsBasicType(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAllFields(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 1);
			System.Collections.Generic.List<System.Reflection.FieldInfo> o = LuaPerfect.ObjectFormater.GetAllFields(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindProperty(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Collections.Generic.List<System.Reflection.PropertyInfo> arg0 = (System.Collections.Generic.List<System.Reflection.PropertyInfo>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<System.Reflection.PropertyInfo>));
			string arg1 = ToLua.CheckString(L, 2);
			bool o = LuaPerfect.ObjectFormater.FindProperty(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAllProperties(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 1);
			System.Collections.Generic.List<System.Reflection.PropertyInfo> o = LuaPerfect.ObjectFormater.GetAllProperties(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassFullName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 1);
			string o = LuaPerfect.ObjectFormater.GetClassFullName(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassInfo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 1);
			LuaPerfect.ClassInfoItem o = LuaPerfect.ObjectFormater.GetClassInfo(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChildrenGameObjects(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			System.Collections.Generic.List<UnityEngine.GameObject> o = LuaPerfect.ObjectFormater.GetChildrenGameObjects(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FormatObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			object arg0 = ToLua.ToVarObject(L, 1);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
			LuaPerfect.ObjectItem o = LuaPerfect.ObjectFormater.FormatObject(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InnerFormatObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			object arg0 = ToLua.ToVarObject(L, 1);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
			LuaPerfect.ObjectItem o = LuaPerfect.ObjectFormater.InnerFormatObject(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearObjectCache(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			LuaPerfect.ObjectFormater.ClearObjectCache();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_s_classInfoDirectionary(IntPtr L)
	{
		try
		{
			ToLua.PushSealed(L, LuaPerfect.ObjectFormater.s_classInfoDirectionary);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_s_classInfoDirectionary(IntPtr L)
	{
		try
		{
			System.Collections.Generic.Dictionary<System.Type,LuaPerfect.ClassInfoItem> arg0 = (System.Collections.Generic.Dictionary<System.Type,LuaPerfect.ClassInfoItem>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.Dictionary<System.Type,LuaPerfect.ClassInfoItem>));
			LuaPerfect.ObjectFormater.s_classInfoDirectionary = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}


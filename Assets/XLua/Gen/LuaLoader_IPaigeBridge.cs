﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System;


namespace XLua.CSObjectWrap
{
    public class LuaLoaderIPaigeBridge : LuaBase, LuaLoader.IPaige
    {
	    public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
		    return new LuaLoaderIPaigeBridge(reference, luaenv);
		}
		
		public LuaLoaderIPaigeBridge(int reference, LuaEnv luaenv) : base(reference, luaenv)
        {
        }
		
        
		void LuaLoader.IPaige.ShowInfo()
		{
#if THREAD_SAFE || HOTFIX_ENABLE
            lock (luaEnv.luaEnvLock)
            {
#endif
				RealStatePtr L = luaEnv.L;
				int err_func = LuaAPI.load_error_func(L, luaEnv.errorFuncRef);
				
				
				LuaAPI.lua_getref(L, luaReference);
				LuaAPI.xlua_pushasciistring(L, "ShowInfo");
				if (0 != LuaAPI.xlua_pgettable(L, -2))
				{
					luaEnv.ThrowExceptionFromError(err_func - 1);
				}
				if(!LuaAPI.lua_isfunction(L, -1))
				{
					LuaAPI.xlua_pushasciistring(L, "no such function ShowInfo");
					luaEnv.ThrowExceptionFromError(err_func - 1);
				}
				LuaAPI.lua_pushvalue(L, -2);
				LuaAPI.lua_remove(L, -3);
				
				int __gen_error = LuaAPI.lua_pcall(L, 1, 0, err_func);
				if (__gen_error != 0)
					luaEnv.ThrowExceptionFromError(err_func - 1);
				
				
				
				LuaAPI.lua_settop(L, err_func - 1);
				
#if THREAD_SAFE || HOTFIX_ENABLE
            }
#endif
		}
        

        
        string LuaLoader.IPaige.name 
        {
            
            get 
            {
#if THREAD_SAFE || HOTFIX_ENABLE
                lock (luaEnv.luaEnvLock)
                {
#endif
					RealStatePtr L = luaEnv.L;
					int oldTop = LuaAPI.lua_gettop(L);
					
					LuaAPI.lua_getref(L, luaReference);
					LuaAPI.xlua_pushasciistring(L, "name");
					if (0 != LuaAPI.xlua_pgettable(L, -2))
					{
						luaEnv.ThrowExceptionFromError(oldTop);
					}
					string __gen_ret = LuaAPI.lua_tostring(L, -1);
					LuaAPI.lua_pop(L, 2);
					return __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
                }
#endif
            }
            
            
            set
            {
#if THREAD_SAFE || HOTFIX_ENABLE
                lock (luaEnv.luaEnvLock)
                {
#endif
					RealStatePtr L = luaEnv.L;
					int oldTop = LuaAPI.lua_gettop(L);
					
					LuaAPI.lua_getref(L, luaReference);
					LuaAPI.xlua_pushasciistring(L, "name");
					LuaAPI.lua_pushstring(L, value);
					if (0 != LuaAPI.xlua_psettable(L, -3))
					{
						luaEnv.ThrowExceptionFromError(oldTop);
					}
					LuaAPI.lua_pop(L, 1);
#if THREAD_SAFE || HOTFIX_ENABLE
                }
#endif
            }
            
        }
        
        int LuaLoader.IPaige.age 
        {
            
            get 
            {
#if THREAD_SAFE || HOTFIX_ENABLE
                lock (luaEnv.luaEnvLock)
                {
#endif
					RealStatePtr L = luaEnv.L;
					int oldTop = LuaAPI.lua_gettop(L);
					
					LuaAPI.lua_getref(L, luaReference);
					LuaAPI.xlua_pushasciistring(L, "age");
					if (0 != LuaAPI.xlua_pgettable(L, -2))
					{
						luaEnv.ThrowExceptionFromError(oldTop);
					}
					int __gen_ret = LuaAPI.xlua_tointeger(L, -1);
					LuaAPI.lua_pop(L, 2);
					return __gen_ret;
#if THREAD_SAFE || HOTFIX_ENABLE
                }
#endif
            }
            
            
            set
            {
#if THREAD_SAFE || HOTFIX_ENABLE
                lock (luaEnv.luaEnvLock)
                {
#endif
					RealStatePtr L = luaEnv.L;
					int oldTop = LuaAPI.lua_gettop(L);
					
					LuaAPI.lua_getref(L, luaReference);
					LuaAPI.xlua_pushasciistring(L, "age");
					LuaAPI.xlua_pushinteger(L, value);
					if (0 != LuaAPI.xlua_psettable(L, -3))
					{
						luaEnv.ThrowExceptionFromError(oldTop);
					}
					LuaAPI.lua_pop(L, 1);
#if THREAD_SAFE || HOTFIX_ENABLE
                }
#endif
            }
            
        }
        
        
        
		
		
	}
}

/*
 *  Title: ""项目
 *
 *	Description:
 *
 *	Author:
 *
 *	Date:
 *
 *	Modify:
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;
using System.IO;
using System.Text;
using System;
public class LuaLoader : MonoBehaviour
{
    // Start is called before the first frame update
    LuaEnv env = null;
    [CSharpCallLua]
    public delegate int addDelegate(int a, int b);

    [CSharpCallLua]
    public delegate addDelegate GetPaigeAge();

    void Start()
    {

        env = new LuaEnv();

        env.AddLoader(CustomLoader);

        //env.DoString("require('CSCallLua')");
        //IPaige paige = env.Global.Get<IPaige>("paige");
        //paige.ShowInfo();
        //paige.name = "111";
        //paige.age = 26;
        //paige.ShowInfo();
        //var getAgeFunc = env.Global.Get<GetPaigeAge>("GetPaigeAge");
        //var add_func = getAgeFunc();
        //Debug.Log("age:" + add_func(1, 2));

        env.DoString("require('LuaCallCS')");
    }

    private byte[] CustomLoader(ref string fileName)
    {
        string luaPath = "Assets/GameMain/Resources/" + fileName + ".lua";
        string content = File.ReadAllText(luaPath);
        byte[] byteArray = Encoding.UTF8.GetBytes(content);
        return byteArray;
    }

    [CSharpCallLua]
    public interface IPaige
    {
        string name { get; set; }
        int age { get; set; }

        void ShowInfo();
    }

    private void OnDestroy()
    {
        env.Dispose();
    }    
}

[LuaCallCSharp]
public class Animal
{
    public void PFunc1()
    {
        Debug.Log("call parent func");
    }

}

public struct Param
{
    string name;
    int age;
}

[LuaCallCSharp]
public class Dog : Animal
{
    public void Call(string content)
    {
        Debug.Log(content);
    }

    public void Call()
    {
        Debug.Log("defual call");
    }

    public double ComplexFunc(Param p1, Action print, ref double p2, out double p3)
    {
        Debug.Log(p1);
        print();
        p2 = 20.1;
        p3 = 20.9;
        return p2 + p3;
    }
}

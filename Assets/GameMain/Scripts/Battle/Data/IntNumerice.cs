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

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntNumerice
{
    private int _value;
    private int _add;
    private int _pctAdd;
    private int _finalAdd;
    private int _finalPctAdd;

    public int Value
    {
        get{
            return _value;
        }

        set{
            _value = value;
            this.Update();
        }
    }

    public int Add
    {
        get
        {
            return _add;
        }

        set
        {
            _add = value;
            this.Update();
        }
    }

    public int PctAdd
    {
        get
        {
            return _pctAdd;
        }

        set
        {
            _pctAdd = value;
            this.Update();
        }
    }

    public int FinalAdd
    {
        get
        {
            return _finalAdd;
        }

        set
        {
            _finalAdd = value;
            this.Update();
        }
    }

    public int FinalPctAdd
    {
        get
        {
            return _finalPctAdd;
        }

        set
        {
            _finalPctAdd = value;
            this.Update();
        }
    }

    public void Update()
    {
        var value1 = _value;
        var value2 = (value1 + _add) * ((100 + _pctAdd) / 100f);
        var value3 = (value2 + _finalAdd) * ((100 + _finalPctAdd) / 100f);
        _value = Convert.ToInt32(value3);
    }

    public IntNumerice()
    {
        _value = _add = _pctAdd = _finalAdd = _finalPctAdd = 0;
    }
}

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

public class FloatNumerice
{
    private float _value;
    private float _add;
    private int _pctAdd;
    private float _finalAdd;
    private int _finalPctAdd;

    public float Value
    {
        get
        {
            return _value;
        }

        set
        {
            _value = value;
            this.Update();
        }
    }

    public float Add
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

    public float FinalAdd
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
        _value = value3;
    }

    public FloatNumerice()
    {
        _value = _add  = _finalAdd = 0f;
        _pctAdd = _finalPctAdd = 0;
    }
}

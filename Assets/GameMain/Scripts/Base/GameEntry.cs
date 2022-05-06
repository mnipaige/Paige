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

namespace Paige
{
    public partial class GameEntry : MonoBehaviour
    {
        public void Start() {
            //初始化内置组件
            InitBuiltinComponents();
            //初始化自定义组件
            InitCustomComponents();
            //初始化自定义的调试
            InitCustomDebuggers();
        }
    }
}


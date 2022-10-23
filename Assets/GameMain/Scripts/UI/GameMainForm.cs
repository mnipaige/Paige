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
    public class GameMainForm : UGUIForm
    {
        public Button GameStartBtn;
        protected override void InternalSetVisible(bool visible)
        {
            base.InternalSetVisible(visible);
        }

        protected override void OnClose(bool isShutdown, object userData)
        {
            base.OnClose(isShutdown, userData);
        }

        protected override void OnCover()
        {
            base.OnCover();
        }

        protected override void OnDepthChanged(int uiGroupDepth, int depthInUIGroup)
        {
            base.OnDepthChanged(uiGroupDepth, depthInUIGroup);
        }

        protected override void OnInit(object userData)
        {
            base.OnInit(userData);
            Debug.Log("初始化！！！！");
            GameStartBtn.onClick.AddListener(() => {
                Debug.Log("start game!!!");
            });
        }

        protected override void OnOpen(object userData)
        {
            base.OnOpen(userData);
        }

        protected override void OnPause()
        {
            base.OnPause();
        }

        protected override void OnRecycle()
        {
            base.OnRecycle();
        }

        protected override void OnRefocus(object userData)
        {
            base.OnRefocus(userData);
        }

        protected override void OnResume()
        {
            base.OnResume();
        }

        protected override void OnReveal()
        {
            base.OnReveal();
        }

        protected override void OnUpdate(float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(elapseSeconds, realElapseSeconds);
        }
    }
}



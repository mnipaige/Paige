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
using GameFramework;
using GameFramework.Fsm;

namespace Paige.Fsm.Test
{
    public class PlayerEatState : GameFramework.Fsm.FsmState<Player>
    {
        protected override void OnInit(IFsm<Player> fsm)
        {
            base.OnInit(fsm);
            Debug.Log("玩家吃状态初始化");
        }

        protected override void OnEnter(IFsm<Player> fsm)
        {
            base.OnEnter(fsm);
            Debug.Log("玩家吃的状态开始");
        }

        protected override void OnUpdate(IFsm<Player> fsm, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(fsm, elapseSeconds, realElapseSeconds);
            Debug.Log("玩家吃的状态更新");
            var player = fsm.Owner;
            player.EatValue += 10;
            if(player.EatValue >= 100)
            {
                player.EatValue = 0;
                this.ChangeState<PlayerSleepState>(fsm);
            }
        }

        protected override void OnLeave(IFsm<Player> fsm, bool isShutdown)
        {
            base.OnLeave(fsm, isShutdown);
            Debug.Log("玩家吃的状态离开");
        }

        protected override void OnDestroy(IFsm<Player> fsm)
        {
            base.OnDestroy(fsm);
            Debug.Log("玩家吃的状态销毁");
        }
    }

}


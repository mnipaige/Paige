using GameFramework;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
using Paige.Fsm.Test;
using System.Collections.Generic;

namespace GameFrameworkExample
{
    public class ProcedureLaunch : ProcedureBase
    {
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);

            // string welcomeMessage = Utility.Text.Format("Hello! This is an empty project based on Game Framework {0}.", Version.GameFrameworkVersion);
            // Log.Info(welcomeMessage);
            // Log.Warning(welcomeMessage);
            // Log.Error(welcomeMessage);
            Log.Info(Paige.GameEntry.Resource.ResourceMode);
            Player paige = new Player("Paige", 0, 0);
            var Fsm = Paige.GameEntry.Fsm;
            List<GameFramework.Fsm.FsmState<Player>> stateList = new List<GameFramework.Fsm.FsmState<Player>>();
            PlayerEatState eatState = new PlayerEatState();
            stateList.Add(eatState);
            PlayerSleepState sleepState = new PlayerSleepState();
            stateList.Add(sleepState);
            var playerFsm = Fsm.CreateFsm<Player>(paige, stateList);
            playerFsm.Start<PlayerEatState>();
        }
    }
}

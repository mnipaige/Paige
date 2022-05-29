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

namespace Paige.Fsm.Test
{
    public class Player
    {
        private string _name;
        private int _eatValue;
        private int _sleepValue;
        public Player(string name, int eatValue, int sleepValue)
        {
            _name = name;
            _eatValue = eatValue;
            _sleepValue = sleepValue;
        }

        public string Name{
            get
            {
                return _name;
            }
        }

        public int EatValue
        {
            get
            {
                return _eatValue;
            }

            set
            {
                _eatValue = value;
            }
        }
        public int SleepValue 
        {
            get {
                return _sleepValue;
            }

            set
            {
                _sleepValue = value;
            }
        }

    }
}


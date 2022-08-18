using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MaxValentine
{
    public class TimerManager : MonoBehaviour
    {
        public delegate void StartTimerAction();
        public static event StartTimerAction OnTimer;
        private void Start()
        {
            if(OnTimer != null)
            {
                OnTimer();
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MaxValentine
{
    public class CounterAnnouncer : MonoBehaviour
    {
        // We need our event here

        public delegate void StartAction();
        public static event StartAction OnStart;

        private void Start()
        {
            if(OnStart != null)
            {
                OnStart();
            }
        }
    }
}
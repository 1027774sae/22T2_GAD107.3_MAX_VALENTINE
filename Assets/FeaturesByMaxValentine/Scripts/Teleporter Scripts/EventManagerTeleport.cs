using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MaxValentine
{
    public class EventManagerTeleport : MonoBehaviour
    {
        public delegate void TeleportAction();
        public static event TeleportAction OnTeleport;

        private void OnTriggerEnter(Collider other)
        {
            if(OnTeleport != null)
            {
                OnTeleport();
            }
        }
    }
}
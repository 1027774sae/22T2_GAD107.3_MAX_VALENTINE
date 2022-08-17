using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MaxValentine
{
    public class Teleporter: MonoBehaviour
    {
        private void OnEnable()
        {
            EventManagerTeleport.OnTeleport += Teleport;
        }

        private void OnDisable()
        {
            EventManagerTeleport.OnTeleport -= Teleport;
        }

        private void Teleport()
        {
            transform.position = new Vector3(-10, 0, 13.5f);
        }
    }
}

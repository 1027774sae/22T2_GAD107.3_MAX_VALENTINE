using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MaxValentine
{
    public class TeleportPads : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Teleported " + other.gameObject.name + " !");

            other.transform.position = new Vector3(0, 7, 0);
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}

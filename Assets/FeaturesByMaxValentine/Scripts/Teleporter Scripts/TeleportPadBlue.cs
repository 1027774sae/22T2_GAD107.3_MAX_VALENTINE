using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MaxValentine
{
    public class TeleportPadBlue : MonoBehaviour
    {

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Teleported " + other.gameObject.name + " !");

            other.transform.position = new Vector3(-10, 0, 17);
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

        }
    }
}

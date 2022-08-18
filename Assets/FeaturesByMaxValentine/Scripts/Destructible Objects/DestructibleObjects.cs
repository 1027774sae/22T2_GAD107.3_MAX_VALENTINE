using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MaxValentine
{
    public class DestructibleObjects : MonoBehaviour
    {
        
        public float objectHealth = 50;

        private void OnTriggerEnter(Collider other)
        {
            objectHealth -= (other.gameObject.GetComponent<ObjectDamager>().objectDamage);
        }
        private void Update()
        {
            if (objectHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}

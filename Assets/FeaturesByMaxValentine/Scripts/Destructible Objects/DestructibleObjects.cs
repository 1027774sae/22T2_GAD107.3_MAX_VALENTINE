using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MaxValentine
{
    public class DestructibleObjects : MonoBehaviour
    {
        [SerializeField] private GameObject structure;
        [SerializeField] public int objectHealth =50;
        [SerializeField] public int objectDamage = 10;

        private void OnEnable()
        {
            ObjectDamager.OnDamage += DestroyBuilding;
        }
        private void OnDisable()
        {
            ObjectDamager.OnDamage -= DestroyBuilding;
        }

        private void DestroyBuilding()
        {
            objectHealth -= objectDamage;
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

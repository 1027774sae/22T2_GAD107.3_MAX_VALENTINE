using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MaxValentine
{
    public class ObjectDamager : MonoBehaviour
    {
        [SerializeField] private GameObject structure;
        public int objectDamage = 10;

        public delegate void ObjectDamagerAction();
        public static event ObjectDamagerAction OnDamage;

        private void OnTriggerEnter(Collider structure)
        {
            if(OnDamage != null)
            {
                OnDamage();
            }
        }
    }
}

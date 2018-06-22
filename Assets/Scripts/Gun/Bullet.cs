using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrjtMgmtFPS
{
    public class Bullet : MonoBehaviour
    {
        public GameObject gunPrefab;
        public Rigidbody rigid;
        public float bulletSpeed = 50f;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            rigid.AddForce(transform.forward * bulletSpeed);
        }

        void OnTriggerEnter(Collider col)
        {
            if(col.name == "Wall")
            {
                Destroy(gameObject);
            }
        }
    }
}

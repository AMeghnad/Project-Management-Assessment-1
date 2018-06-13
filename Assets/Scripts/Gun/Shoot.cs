using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrjtMgmtFPS
{
    public class Shoot : MonoBehaviour        
    {
        public GameObject bulletPrefab;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                ShootGun();
            }
        }
        void ShootGun()
        {
            Instantiate(bulletPrefab, gameObject.transform.position, gameObject.transform.rotation);
            Debug.Log("Bullet fired");
        }
    }
}

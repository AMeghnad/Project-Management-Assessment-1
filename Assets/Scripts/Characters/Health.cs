using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PrjtMgmtFPS
{
    public class Health : MonoBehaviour
    {
        public int health;
        public int damage;
        // Use this for initialization
        protected virtual void Start()
        {

        }

        // Update is called once per frame
        protected virtual void Update()
        {
            if (health <= 0)
            {
                Death();
            }
        }

        protected virtual void OnCollisionEnter(Collision col)
        {
            
        }
        
        protected virtual void Death()
        {

        }
    }
}

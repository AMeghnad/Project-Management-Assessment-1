using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrjtMgmtFPS
{
    public class EnemyHealth : Health
    {
        // Use this for initialization
        protected override void Start()
        {
            health = 20;
            damage = 10;
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
        }

        protected override void OnCollisionEnter(Collision col)
        {
            Debug.Log("Bullet hit");
            if(col.gameObject.tag == "Bullet")
            {
                health -= damage;
                Destroy(col.gameObject);
            }
        }

        protected override void Death()
        {
            Destroy(gameObject);
        }
    }
}

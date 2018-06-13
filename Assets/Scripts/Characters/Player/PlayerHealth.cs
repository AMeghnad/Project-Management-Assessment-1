using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PrjtMgmtFPS
{
    public class PlayerHealth : Health
    {
        public Text death;
        // Use this for initialization
        protected override void Start()
        {
            health = 100;
            damage = 20;
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();
        }
        protected override void OnCollisionEnter(Collision col)
        {
            // if the other object is an enemy
            if (col.gameObject.name == "Enemy")
                health -= damage;
        }

        protected override void Death()
        {
            death.gameObject.SetActive(true);
        }

    }
}

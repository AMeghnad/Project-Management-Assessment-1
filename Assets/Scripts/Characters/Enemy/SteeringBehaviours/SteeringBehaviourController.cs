using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrjtMgmtFPS
{
    public class SteeringBehaviourController : MonoBehaviour
    {
        public Seek seek;
        public Patrol patrol;
        public Transform player;
        private float distance;
        public float triggerDistance = 20f;

        //Use this for initialisation
        void Start()
        {
            seek.weighting = 0.75f;
        }
        // Update is called once per frame
        void Update()
        {
            distance = (player.position - transform.position).magnitude;
            if (distance <= triggerDistance)
            {
                patrol.weighting = 0f;
                seek.weighting++;
            }
            if (distance > triggerDistance)
            {
                seek.weighting = 0;
                patrol.weighting = 2f;
            }           
        }
    }
}

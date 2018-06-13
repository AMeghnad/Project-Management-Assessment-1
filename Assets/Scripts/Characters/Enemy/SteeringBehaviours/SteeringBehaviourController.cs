using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrjtMgmtFPS
{
    public class SteeringBehaviourController : MonoBehaviour
    {
        private Seek seek;
        private Patrol patrol;
        public Transform player;
        private float distance;
        public float triggerDistance = 10f;

        // Update is called once per frame
        void Update()
        {
            distance = (player.position - transform.position).magnitude;
            if(distance <= triggerDistance)
            {
                patrol.weighting = 0f;
                seek.weighting = 1.5f;
            }
            if (distance > triggerDistance)
            {
                {
                    seek.weighting = 0;
                    patrol.weighting = 1.5f;
                }
            }
            else
            {
                seek.weighting = 0;
            }
        }
    }
}

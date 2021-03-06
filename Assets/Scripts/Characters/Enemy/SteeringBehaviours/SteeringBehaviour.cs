﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrjtMgmtFPS
{
    [RequireComponent(typeof(AIAgent))]
    public class SteeringBehaviour : MonoBehaviour
    {
        public float weighting = 0.75f;
        [HideInInspector]
        public AIAgent owner;
        protected virtual void Awake()
        {
            owner = GetComponent<AIAgent>();
        }

        public virtual Vector3 GetForce()
        {
            return Vector3.zero;
        }
    }
}

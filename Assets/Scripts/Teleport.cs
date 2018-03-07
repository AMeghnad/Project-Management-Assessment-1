using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrjMgmtFPS
{
    public class Teleport : MonoBehaviour
    {
        private int teleportDistance = 2;

        //// Use this for initialization
        //void Start()
        //{

        //}

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Vector3.Lerp(transform.position, Vector3.forward * teleportDistance, 10f);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrjMgmtFPS
{
    public class Teleport : MonoBehaviour
    {
        private int teleportDistance = 20;
        public float inputH, inputV;

        //// Use this for initialization
        //void Start()
        //{

        //}

        // Update is called once per frame
        void Update()
        {
            inputH = Input.GetAxis("Horizontal");
            inputV = Input.GetAxis("Vertical");
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {                
                transform.position += transform.forward * teleportDistance;
                Debug.Log("Teleport forward!");
            }
        }
    }
}

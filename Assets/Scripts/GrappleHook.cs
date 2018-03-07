using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrjMgmtFPS
{
    public class GrappleHook : MonoBehaviour
    {
        public Transform player, hook;
        public bool isGrounded;
        public float grappleSpeed = 10f;
        public RaycastHit hookHit;
        public LayerMask Building;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (isGrounded)
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    if (Physics.Raycast(player.position, Vector3.forward, 1000f, Building))
                    {

                        transform.position = Vector3.Lerp(player.position, hook.position, grappleSpeed);
                    }
                }
            }

            if (!isGrounded)
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {

                }
            }
        }
    }
}

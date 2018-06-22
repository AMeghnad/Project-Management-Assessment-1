using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace PrjMgmtFPS
{
    public class MultiplayerTeleport : NetworkBehaviour
    {
        private int teleportDistance = 20;
        public float inputH, inputV;
        public Material material;

        // Use this for initialization
        void Start()
        {
            material = gameObject.GetComponent<Material>();
        }

        // Update is called once per frame
        void Update()
        {
            if (!isLocalPlayer)
            {
                return;
            }
            inputH = Input.GetAxis("Horizontal");
            inputV = Input.GetAxis("Vertical");
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                transform.position += transform.forward * teleportDistance;
                //Debug.Log("Teleport forward!");
            }
        }

        public override void OnStartLocalPlayer()
        {
            material.color = Color.blue;
        }
    }
}

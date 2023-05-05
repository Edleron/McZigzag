namespace Ground
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using MiddleWare;

    public class Positioner : MonoBehaviour
    {
        private Rigidbody rb;
        private float yPosTrigger = -5.0f;
        private int direction;


        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            CheckGroundPos();
        }

        private void CheckGroundPos()
        {
            if (transform.position.y <= yPosTrigger)
            {
                if (gameObject.name == "MainGround")
                {
                    Destroy(gameObject, 1);
                }
                else
                {
                    SetRigidBodyValues();
                    GroundNewPosition();
                }
            }
        }

        private void GroundNewPosition()
        {
            // Todo
            direction = Random.Range(0, 2);

            if (direction == 0)
            {
                transform.position = new Vector3(Packer.lastTransform.x - 1f, Packer.lastTransform.y, Packer.lastTransform.z);
            }
            else
            {
                transform.position = new Vector3(Packer.lastTransform.x, Packer.lastTransform.y, Packer.lastTransform.z + 1f);
            }
            Packer.lastTransform = gameObject.transform.position;
        }

        private void SetRigidBodyValues()
        {
            rb.isKinematic = true;
            rb.useGravity = false;
        }
    }
}
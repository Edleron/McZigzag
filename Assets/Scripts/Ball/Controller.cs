namespace Ball
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Controller : MonoBehaviour
    {
        [HideInInspector] public Vector3 direction;

        private void Start()
        {
            direction = Vector3.left;
        }

        // Update is called once per frame
        private void Update()
        {
            HandleInputs();
        }

        private void HandleInputs()
        {
            if (Input.GetMouseButtonDown(0))
            {
                ChangeDirection();
            }
        }

        private void ChangeDirection()
        {
            direction = direction.x == -1 ? Vector3.forward : Vector3.left;
        }
    }
}
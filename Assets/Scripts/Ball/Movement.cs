namespace Ball
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Movement : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 2.5f;
        private Transmiter transmiter;

        private void Awake()
        {
            transmiter = GetComponent<Transmiter>();
        }

        private void Update()
        {
            SetBallMovement();
        }

        private void SetBallMovement()
        {
            transform.position += transmiter.GetDirection() * moveSpeed * Time.deltaTime;
        }
    }
}
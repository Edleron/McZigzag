using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private BallTransmiter ballTransmiter;
    [SerializeField] private float moveSpeed;

    private void Update()
    {
        SetBallMovement();
    }

    private void SetBallMovement()
    {
        transform.position += ballTransmiter.GetDirection() * moveSpeed * Time.deltaTime;
    }
}

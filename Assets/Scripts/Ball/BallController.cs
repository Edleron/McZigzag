using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [HideInInspector] public Vector3 ballDirection;

    private void Start()
    {
        ballDirection = Vector3.left;
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
        ballDirection = ballDirection.x == -1 ? Vector3.forward : Vector3.left;
    }
}

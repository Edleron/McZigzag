using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransmiter : MonoBehaviour
{
    [SerializeField] private BallController ballController;

    public Vector3 GetDirection()
    {
        return ballController.ballDirection;
    }
}

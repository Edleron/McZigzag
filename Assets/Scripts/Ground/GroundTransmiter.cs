using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTransmiter : MonoBehaviour
{
    [SerializeField] private GroundController groundController;

    public void SetRigidbodyValues()
    {
        StartCoroutine(groundController.RigidbodyValues());
    }
}

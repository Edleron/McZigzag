using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowController : MonoBehaviour
{
    [SerializeField] private Transform target;

    private Vector3 offset;
    private Vector3 newPosition;

    [SerializeField][Range(0, 3)] private float lerpValue;

    private void Start()
    {
        offset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        SetCameraSmoothFollow();
    }

    private void SetCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, target.position + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPositineor : MonoBehaviour
{
    private GroundSpawner groundSpawner;
    private Rigidbody rb;

    [SerializeField] private float endValue;
    private int groundDirection;


    void Start()
    {
        groundSpawner = FindObjectOfType<GroundSpawner>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckGroundPos();
    }

    private void CheckGroundPos()
    {
        if (transform.position.y <= endValue)
        {
            SetRigidBodyValues();
            GroundNewPosition();
        }
    }

    private void GroundNewPosition()
    {
        groundDirection = Random.Range(0, 2);

        if (groundDirection == 0)
        {
            transform.position = new Vector3(groundSpawner.lastObject.transform.position.x - 1f, groundSpawner.lastObject.transform.position.y, groundSpawner.lastObject.transform.position.z);
        }
        else
        {
            transform.position = new Vector3(groundSpawner.lastObject.transform.position.x, groundSpawner.lastObject.transform.position.y, groundSpawner.lastObject.transform.position.z + 1f);
        }

        groundSpawner.lastObject = gameObject;
    }

    private void SetRigidBodyValues()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject lastObject;
    [SerializeField] private GameObject groundPrefab;
    private GameObject newGroundObject;
    private int groundDirection;

    private void Start()
    {
        GenerateRandomGrounds();
    }

    public void GenerateRandomGrounds()
    {
        for (int i = 0; i < 75; i++)
        {
            CreateNewGround();
        }
    }

    private void CreateNewGround()
    {
        groundDirection = Random.Range(0, 2);

        if (groundDirection == 0)
        {
            newGroundObject = Instantiate(groundPrefab, new Vector3(lastObject.transform.position.x - 1f, lastObject.transform.position.y, lastObject.transform.position.z), Quaternion.identity);
            lastObject = newGroundObject;
        }
        else
        {
            newGroundObject = Instantiate(groundPrefab, new Vector3(lastObject.transform.position.x, lastObject.transform.position.y, lastObject.transform.position.z + 1f), Quaternion.identity);
            lastObject = newGroundObject;
        }
    }
}

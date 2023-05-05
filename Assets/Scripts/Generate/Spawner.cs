namespace Generate
{
    using System.Collections;
    using System.Collections.Generic;
    using MiddleWare;
    using UnityEngine;

    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject groundPrefab;
        private GameObject newGroundObject;
        private int groundDirection;

        private void Awake()
        {
            Packer.lastTransform = new Vector3(-2, 0, 3);
        }

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
                newGroundObject = Instantiate(groundPrefab, new Vector3(Packer.lastTransform.x - 1f, Packer.lastTransform.y, Packer.lastTransform.z), Quaternion.identity);
                Packer.lastTransform = newGroundObject.transform.position;
            }
            else
            {
                newGroundObject = Instantiate(groundPrefab, new Vector3(Packer.lastTransform.x, Packer.lastTransform.y, Packer.lastTransform.z + 1f), Quaternion.identity);
                Packer.lastTransform = newGroundObject.transform.position;
            }
        }
    }

}
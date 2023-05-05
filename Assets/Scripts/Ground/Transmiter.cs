namespace Ground
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Transmiter : MonoBehaviour
    {
        private Controller controller;

        private void Awake()
        {
            controller = GetComponent<Controller>();
        }

        public void SetRigidbodyValues()
        {
            StartCoroutine(controller.RigidbodyValues());
        }
    }
}
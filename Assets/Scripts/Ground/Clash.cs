namespace Ground
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Clash : MonoBehaviour
    {
        private Transmiter transmiter;

        private void Awake()
        {
            transmiter = GetComponent<Transmiter>();
        }

        private void OnCollisionExit(Collision other)
        {
            if (other.gameObject.CompareTag("Ball"))
            {
                transmiter.SetRigidbodyValues();
            }
        }
    }

}
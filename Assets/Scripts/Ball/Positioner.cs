namespace Ball
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.SceneManagement;

    public class Positioner : MonoBehaviour
    {
        private float yPosTrigger = -5.0f;

        void Update()
        {
            CheckGroundPos();
        }

        private void CheckGroundPos()
        {
            if (transform.position.y <= yPosTrigger)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class LoseScript : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D Collider)
        {
            if (Collider.gameObject.tag == "Player")
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
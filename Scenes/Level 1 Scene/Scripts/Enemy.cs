using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public UIScore lives;

    public AudioSource hit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            lives.Hits();
            Debug.Log("Collision");

            hit.Play();
        }
    }
    
}

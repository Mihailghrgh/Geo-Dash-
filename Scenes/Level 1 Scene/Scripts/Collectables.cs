using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    
    public UIScore scoreController;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        this.scoreController.Scoring();
    }

    
}

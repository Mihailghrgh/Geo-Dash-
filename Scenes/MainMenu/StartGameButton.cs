using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButoon : MonoBehaviour
{
    public void StartGameButton()
    {
        Debug.Log("Button PRESSED");
        SceneManager.LoadScene("Level1");
    }
}

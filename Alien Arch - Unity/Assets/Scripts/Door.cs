using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    // editable in unity
    public string targetScene;

    

    // CONDITION 1
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // CONDITION 2
        if (collision.CompareTag("Player"))
        {
            ChangeScene();
        }

        
    }

    // ACTION
    public void ChangeScene()
    {
        SceneManager.LoadScene(targetScene);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public string targetScene;


    //can change the starting health through unity
    public int startingHealth;

    // current health and will change as the game goes on
    int currentHealth;


    //calls when game starts, is called before start()
    private void Awake()
    {
        //ensures that at the start of the game, the player has max health
        currentHealth = startingHealth;
    }


    //will change the players health
    //kill() if health = 0
    //public so other scripts can access and change health
    public void changeHealth(int changeAmount)
    {
        // + for healing
        // - for damage
        currentHealth = currentHealth + changeAmount;


        //keeps our health between 0 - the max health we currently have
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);



        // GAME OVER MAN
        // can change to kll() if you dont want a scene change
        if (currentHealth == 0)
        {
            ChangeScene();
        }
    }


    public void ChangeScene()
    {
        SceneManager.LoadScene(targetScene);
    }


    public void kill()
    {
        // this will destroy the object it is attached to
        Destroy(gameObject);
    }

}


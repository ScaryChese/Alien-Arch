using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    public string startMessage;
    public string updateMessage;

    public string message1;
    public string message2;
    public string message3;
    
    public int messageChoice;

    public string[] messages;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.LogWarning(startMessage);


        //messageChoice = Random.Range(1, 4);






        /*
       if (messageChoice == 1)
        {
            Debug.Log(messages[0]);
        }
        else if (messageChoice == 2)
        {
            Debug.Log(messages[1]);
        }
        else if (messageChoice == 3)
        {
            Debug.Log(messages[2]);
        }
        else
        {
            Debug.Log("Invalid message choice");
        }
        */
        /*
        if (messages.Length - 1 >= messageChoice && messageChoice >= 0)
        {
            Debug.Log(messages[messageChoice]);
        }
        else 
        {
            Debug.Log("Invalid message choice");
        }
        */

        for (int i = 0; i < messages.Length; ++i)
        {
            Debug.Log(messages[i]);
        }

        



        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    float timeRemaining = 60; 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("you get" + timeRemaining + "seconds on the clock now, start to find the ball!");
    }

    // Update is called once per frame
    void Update()
    {
        if(timeRemaining == 0)
        {
            Debug.Log("your time is over, try your luck next time");
            Application.Quit();
        }
    }
}

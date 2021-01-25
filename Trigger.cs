using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
	float randomNumber = 0.0f;
    bool isAnswer = false;
    bool isExplode = false;
    public GameObject theBall;
    public GameObject[] ballCollection;

    public float explodingTime = 5f;
    public float explodeRadius = 3f;
    public GameObject explodeParticle;

    private float timer = 0;
    // Update is called once per frame


    void Update()
    {
        ballCollection = GameObject.FindGameObjectsWithTag("theBall");
        if (isExplode)
        {
            if (timer >= explodingTime)
            {
                Destroy(theBall);
                Destroy(GameObject.Find("FPSController"));
                Debug.Log("game over");
            }
            else
            {
                timer += Time.deltaTime;
            }
        }
    }

    bool numberGenerator(float number)
    {
        number = Random.Range(-10.0f, 10.0f);
        if(number >= 5.0f)
        {
            isAnswer = true;
        }
        randomNumber = number;
        return isAnswer;
    }

    private void OnTriggerEnter(Collider other)
    {
        isAnswer = numberGenerator(randomNumber);
        if (isAnswer)
        {
            Debug.Log("you are safe right now!");
            Application.Quit();
        }
        else {
            //Debug.Log(randomNumber);

            Debug.Log("enjoy your last 5 seconds");
            isExplode = true;
            Update();
        }
        
    }
}

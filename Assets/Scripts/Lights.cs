using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    private float timeLight = 0;
    private float timeLightOff = 0.5f;
    private float timeLightOn = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        ;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timeLight >= timeLightOff && gameObject.active)
        { 
            gameObject.SetActive(false);
            timeLight = 0;
        }
        else  /*(timeLight >= timeLightOn && gameObject.active == false)*/ 
        {
            gameObject.SetActive(true);
            timeLight = 0;
        }
        timeLight++;
    }
}

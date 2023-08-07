using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    public float time;
    public float amplitude = 0.25f;
    public float frequency = 2;
    public float offset;
    public Vector3 StartPos;


    // Start is called before the first frame update
    void Start()
    {
        StartPos= transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        offset = amplitude * Mathf.Sin(frequency * time);
        transform.position = StartPos + new Vector3(0,offset,0);
    }
}

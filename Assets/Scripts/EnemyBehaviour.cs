using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public SkeletonAnimation enemyanim;
    private Rigidbody2D rb;
    public static float speed = 5;
    private static bool ifCollision = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }        
    void Update()
    {        
        rb.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        if (ifCollision)
        {            
            enemyanim.state.SetAnimation(0, "win", true);
            speed= 0;
        }
        if (PlayerController.speed == 0)
        {
            enemyanim.state.SetAnimation(0, "idle", true);
            speed = 0;
        }
    }
    public void Destroy()
    {
        Destroy(gameObject);
        EnemySpawner.ifShot();
    }
    public static void AngryMood()
    {
        ifCollision = true;        
    }

}

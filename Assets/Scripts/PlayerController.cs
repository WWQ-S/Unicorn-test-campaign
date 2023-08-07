using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public static float speed = 4;
    private Rigidbody2D rigidbody;
    public GameObject poinOfWin;
    
    public SkeletonAnimation anim;

    static bool animShotPlay;
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();        
    }
    
    void Update()
    {
        rigidbody.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);   
        
        if (rigidbody.transform.position.x >= poinOfWin.transform.position.x) 
        {
            anim.state.ClearTrack(0);
            anim.state.SetAnimation(1, "walk", false);
            speed= 0;            
        }
        //if (animShotPlay)
        //{
        //    anim.state.ClearTrack(0);
        //    anim.state.SetAnimation(0, "shoot", false);
        //    anim.state.ClearTrack(0);
        //    anim.state.SetAnimation(0, "run", true);
        //}
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            speed = 0;
            anim.state.SetAnimation(0, "loose", false);
            EnemyBehaviour.AngryMood();
            AudioManager.ifGameOver();
        }
    }
    public static void AnimShot()
    {
        animShotPlay = true;
    }
}

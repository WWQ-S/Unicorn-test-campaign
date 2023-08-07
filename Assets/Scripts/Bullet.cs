using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public float speed;
    public float lifeTime;
    public float distatance;
    public LayerMask mask;
    
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, distatance, mask);
        if(hit.collider != null)
        {
            if (hit.collider.CompareTag("Enemy"))
            {                
                hit.collider.GetComponent<EnemyBehaviour>().Destroy();
                AudioManager.SoundPlayer("Death");                
            }            
            Destroy(gameObject);            
        }
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }    
}

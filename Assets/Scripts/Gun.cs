using Spine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public GameObject startPointBullet;
    static public bool wasShot = false;
    static PointerEventData eventD;
    private float timeToReload = 0.5f;
    private float startTimeToReload = 0f;
        
    static public void registerClick(PointerEventData eventData)
    {
        wasShot = true;
        eventD = eventData;        
    }
    private void Update()
    {
        startTimeToReload += Time.deltaTime;
        if (wasShot && startTimeToReload >= timeToReload && PlayerController.speed != 0)
        {
            Instantiate(bullet, startPointBullet.transform.position, Quaternion.Euler(eventD.position.x, eventD.position.y, 0));
            PlayerController.AnimShot();
            AudioManager.SoundPlayer("Shot");
            wasShot = false;
            startTimeToReload = 0;
        }        
    }    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;

    private int enemyCountMax = 5;
    public int enemyCountNow;
    public GameObject spawnPoint;
    private float intervalSpawn = 1f;
    private float timeStart;

    private static bool isShotEnemy = false;
    void Start()
    {        
        timeStart = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - timeStart > intervalSpawn && enemyCountNow <= enemyCountMax && PlayerController.speed != 0)
        {
            Instantiate(enemy, spawnPoint.transform.position, Quaternion.identity);
            EnemyCounter("plus");            
            timeStart = Time.time;
        }
        if (isShotEnemy)
        {            
            EnemyCounter("minus");
        }
    }
    public static void ifShot()
    {        
        isShotEnemy = true;
    }
    public void EnemyCounter(string operation)
    {
        if (operation == "minus")
        {
            enemyCountNow--;            
        }
        else if (operation == "plus")
        {
            enemyCountNow++;
        }

    }
    
}

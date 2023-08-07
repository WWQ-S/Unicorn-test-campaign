using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip SoundStartBullet;
    public AudioClip SoundDamage;
    public AudioClip majorSound;
    public AudioSource audiodSource;
    public AudioSource audiodSourceMajorSound;
    static string kindSound;

    private static bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        audiodSource = GetComponent<AudioSource>();        
    }    
    static public void SoundPlayer(string Sound)
    {
        kindSound = Sound;
    }
    private void Update()
    {
        if (kindSound == "Shot")
        {
            audiodSource.PlayOneShot(SoundStartBullet);
            kindSound = null;
        }
        else if (kindSound == "Death")
        {
            audiodSource.PlayOneShot(SoundDamage);
            kindSound = null;
        }
        if (gameOver)
        {
            audiodSourceMajorSound.Stop();
        }
    } 
    public static void ifGameOver()
    {
        gameOver = true;
    }
}

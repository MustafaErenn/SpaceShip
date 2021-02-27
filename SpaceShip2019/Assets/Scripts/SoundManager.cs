using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip playerShootSound, EnemyHurtSound, PlayerHurtSound, LaserGunFire;
    static AudioSource audioSrc;
    void Start()
    {
        playerShootSound = Resources.Load<AudioClip>("Shooting");
        EnemyHurtSound = Resources.Load<AudioClip>("HurtEnemy");
        PlayerHurtSound = Resources.Load<AudioClip>("HurtPlayer");
        LaserGunFire = Resources.Load<AudioClip>("LaserGun6");

        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "Shooting":
                audioSrc.PlayOneShot(playerShootSound);
                break;
            case "HurtEnemy":
                audioSrc.PlayOneShot(EnemyHurtSound);
                break;
            case "HurtPlayer":
                audioSrc.PlayOneShot(PlayerHurtSound);
                break;
            case "LaserGun6":
                audioSrc.PlayOneShot(LaserGunFire);
                break;
        }
    }
}

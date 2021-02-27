using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGunSpawn : MonoBehaviour
{

    public GameObject laserGun;
   
    private float respawnTimerA;
    
    private Vector2 screenBounds;

    public GameObject player;


    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        Debug.Log(screenBounds.y);
        respawnTimerA = Time.time + 10;
        player = GameObject.Find("SpaceShipv1");
    }

    private void FixedUpdate()
    {
        if(respawnTimerA<Time.time)
        {
            SpawnEnemy();
            respawnTimerA = Time.time + 10;
        }
    }
    void SpawnEnemy()
    {
        GameObject a = Instantiate(laserGun) as GameObject;

        //a.transform.position = new Vector2((-screenBounds.x), Random.Range(-screenBounds.y + (screenBounds.y/3),screenBounds.y)-(screenBounds.y/3));
        a.transform.position = new Vector2((-screenBounds.x + 0.5f) , player.transform.position.y  );


    }
    
}

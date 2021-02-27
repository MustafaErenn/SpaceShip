using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float respawnTime = 1.5f;
    private Vector2 screenBounds;


    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        
        StartCoroutine(enemyWave());
    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        GameObject a = Instantiate(enemyPrefab) as GameObject;
        GameObject b = Instantiate(enemyPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x - screenBounds.x*2, screenBounds.x + screenBounds.x*2), Random.Range(-screenBounds.y - 15, -screenBounds.y-5));
        b.transform.position = new Vector2(Random.Range(-screenBounds.x - screenBounds.x * 2, screenBounds.x + screenBounds.x * 2), Random.Range(screenBounds.y + 15, screenBounds.y+5));
    }

    IEnumerator enemyWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnEnemy();
        }
    }
}


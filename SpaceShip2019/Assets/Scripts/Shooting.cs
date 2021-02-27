using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform shotPoint1, shotPoint2;

    
    private float shootingCD=0;
    private bool fireButtonBool;


    private void Update()
    {
        if (shootingCD < Time.time && fireButtonBool)
        {
            fireButton();
            shootingCD = Time.time + 0.3f;
        }
    }
    public void fireButton()
    {

        
            SoundManager.PlaySound("Shooting");
            Instantiate(BulletPrefab, shotPoint1.position, gameObject.transform.rotation);
            Instantiate(BulletPrefab, shotPoint2.position, gameObject.transform.rotation);
        
        
    }

    public void fireButtonPressed()
    {
        
        fireButtonBool = true;
    }
    public void fireButtonReleased()
    {
        fireButtonBool = false;
    }
    
}

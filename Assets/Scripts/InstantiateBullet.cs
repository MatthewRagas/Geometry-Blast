using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBullet : MonoBehaviour
{

    public Rigidbody bullet;
    public Transform ballSpawner;
    public float attackInterval = 1;
    private float elapsedTime = 0;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > elapsedTime && bullet != null)
        {
            //Copy the bullet prefab
            Rigidbody bulletInstance;
            bulletInstance = Instantiate(bullet, ballSpawner.position, ballSpawner.rotation) as Rigidbody;
            bulletInstance.AddForce(ballSpawner.up * 350f);

            elapsedTime = Time.time + attackInterval;
        }        
    }
}

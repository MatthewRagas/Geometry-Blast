using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffScreen : MonoBehaviour
{
    //private Collider collider;

    // Update is called once per frame
    void Update()
    {
        //OnTriggerEnter(collider);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            Destroy(other.gameObject);
        }
    }
}

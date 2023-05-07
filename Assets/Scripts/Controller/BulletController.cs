using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MoveController
{
    private float time = 0;
    //public GameObject explosion;
    void Update()
    {
        if (time == 200)
        {
            Destroy(this.gameObject);
            //Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
        }
        time++;
        Move(transform.up);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class MeController : PlaneController
{
    public int time =0;
    int ShootDelay = 30;
    float timer;
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(horizontal,0,0);
        transform.Translate(direction * speed * Time.deltaTime);
        //var position = Input.mousePosition;
        timer += Time.deltaTime;
        if (timer >= ShootDelay)
        {
            timer = 0;
            Shoot();
        }
        timer++;
    }
}

public class Player : SingletonMonoBehaviour<MeController> { }

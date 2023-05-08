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
            if(gameManager.Instance.scorePlayer <= 100)
            {
                Shoot();
            }
            else
            {
                ShootUpgrade();
            }
        }
        timer++;
    }
    public void SecondTranshoot()
    {
        if (gameManager.Instance.scorePlayer >= 10)
        {
            Instantiate(transhoot, gameManager.Instance.transform.position, gameManager.Instance.transform.rotation);
        }
    }
}



public class Player : SingletonMonoBehaviour<MeController> { }

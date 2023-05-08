using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : PlaneController
{
    int ShootDelay = 200;
    float timer;
    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= ShootDelay)
        {
            timer = 0;
            Shoot();
        }
        timer++;
        EnemyMove();
    }
    public void EnemyMove()
    {
        this.transform.position += new Vector3(0, -1, 0) * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.gameObject.CompareTag("me"))
        {
            Destroy(this.gameObject);
            gameManager.Instance.addScore();
        }
    }
}

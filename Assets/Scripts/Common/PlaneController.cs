using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MoveController
{
    public Transform planeBody;
    public GameObject transhoot;
    public GameObject transhoot2nd;
    public GameObject transhoot3rd;
    public GameObject bullet;


    protected override void Move(Vector3 direction)
    {
        if (direction != Vector3.zero)
        {
            planeBody.up = direction;
        }
        base.Move(direction);
    }
    public void Shoot()
    {
        var nametag = Instantiate(bullet, transhoot.transform.position, transhoot.transform.rotation);
        nametag.transform.tag = this.gameObject.transform.tag;
    }
    public void ShootUpgrade()
    {
        var nametag = Instantiate(bullet, transhoot2nd.transform.position, 
            transhoot2nd.transform.rotation);
        var nametag1 = Instantiate(bullet, transhoot3rd.transform.position,
            transhoot3rd.transform.rotation);
        nametag.transform.tag = this.gameObject.transform.tag;
        nametag1.transform.tag = this.gameObject.transform.tag;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.gameObject.CompareTag("enemyPlane"))
        {
            Destroy(this.bullet);
        }
    }
}

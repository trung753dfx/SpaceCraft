using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class GameManager : MonoBehaviour
{
    public EnemyController planeEnemy;
    void Update()
    {
        
    }
    public void genPlaneEnemy()
    {
        Instantiate(planeEnemy, gameManager.Instance.transform.position, gameManager.Instance.transform.rotation);
        Instantiate(planeEnemy, gameManager.Instance.transform.position += new Vector3(1, 0, 0), gameManager.Instance.transform.rotation);
        Instantiate(planeEnemy, gameManager.Instance.transform.position += new Vector3(-1, 0, 0), gameManager.Instance.transform.rotation);
    }
}

public class gameManager : SingletonMonoBehaviour<GameManager>
{ }

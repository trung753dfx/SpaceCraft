using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LTAUnityBase.Base.DesignPattern;


public class GameManager : MonoBehaviour
{
    public EnemyController planeEnemy;
    public int SpawnDelay;
    public int scorePlayer;
    public Text scoreTxt;

    float timer;
    void Update()
    {
        //
        scoreTxt.text = "Score : " + scorePlayer.ToString();
        //

        timer += Time.deltaTime;

        if (timer >= SpawnDelay)
        {
            timer = 0;
            genPlaneEnemy();
        }
        timer++;

        //
    }
    public void genPlaneEnemy()
    {
        Instantiate(planeEnemy, gameManager.Instance.transform.position -= new Vector3(Random.Range(-1, 1), 0, 0), gameManager.Instance.transform.rotation);
        Instantiate(planeEnemy, gameManager.Instance.transform.position, gameManager.Instance.transform.rotation);
        Instantiate(planeEnemy, gameManager.Instance.transform.position += new Vector3(Random.Range(-1,1), 0, 0), gameManager.Instance.transform.rotation); 
    }
    public void addScore()
    {
        scorePlayer += 5;
    }
}

public class gameManager : SingletonMonoBehaviour<GameManager>
{ }

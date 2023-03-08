using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float timer = 0f;
    //private bool holdTimer = false; 
    public float timerDuration = 60f;
    public int grade = 0;
    public float moveSpeed = 10f;
    public float rotateSpeed = 120f;
    public PlayerController player;
    //public EnemyController greenZombie;
    //public EnemyController grayZombie;
    //public EnemyController ghoul;
    public UI ui;
    public GameObject failPaper;
    public GameObject passPaper;
    public GameObject paper;
    Vector3 vector;
    int frames = 0;

    // Start is called before the first frame update
    void Start()
    {
        timer = timerDuration;
        int i;
        //GameObject failPaper = GameObject.Find("FailPaper");
        //GameObject passPaper = GameObject.Find("PassPaper");


        for(i = 0; i < 2000; ++i)
        {
            vector = new Vector3(Random.Range(-100f, 100f), Random.Range(0.01f, 1f), Random.Range(-100f,100f));
            paper = Instantiate(passPaper, vector, Quaternion.identity);

        }

        for(i = 0; i < 500; ++i)
        {
            vector = new Vector3(Random.Range(-100f, 100f), Random.Range(0.01f, 1f), Random.Range(-100f,100f));
            paper = Instantiate(failPaper, vector, Quaternion.identity);
        }

        //vector = new Vector3(Random.Range(-1f, 1f), Random.Range(-0.02f, 0.02f), Random.Range(-1f,1f));
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        /*
        frames += 1;

        if(frames == 100)
        {

        }
        */

    }
}

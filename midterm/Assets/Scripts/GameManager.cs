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

    // Start is called before the first frame update
    void Start()
    {
        timer = timerDuration;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
    }
}

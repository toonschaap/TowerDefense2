using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomSpawner : MonoBehaviour
{
    public int PositionOne;
    public int PositionTwo;

    public int timerOne;
    public int timerTwo;
    
    public GameObject Enemy;
    GameObject Enemyclone;
    private float Timer = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            Enemyclone = Instantiate(Enemy, new Vector3(PositionOne, PositionTwo, 0), transform.rotation) as GameObject;
            Timer = Random.Range(timerOne, timerTwo);
        }
    }
}
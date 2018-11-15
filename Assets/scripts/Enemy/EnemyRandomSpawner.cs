using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomSpawner : MonoBehaviour
{

    public GameObject Enemy;
    GameObject Enemyclone;
    public float Timer = 2;
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
            Enemyclone = Instantiate(Enemy, new Vector3(7.0f, 3.0f, 0), transform.rotation) as GameObject;
            Timer = Random.Range(2.0f, 3.0f);
        }
    }
}
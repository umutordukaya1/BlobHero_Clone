using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    GameObject enemy;
    private void Start()
    {
        FindEnemy();

    }

    private void FindEnemy()
    {
        enemy = GameObject.Find("Enemy");
    }

    void Update()
    {
        if (enemy.transform.childCount > 0)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, enemy.transform.GetChild(0).position, Time.deltaTime * 3f);
        }

    }
    float distance;
    void OnCollisionEnter(Collision denetle)
    {

        if (denetle.gameObject.tag == "Enemy")
        {


            Destroy(denetle.gameObject);
            Destroy(gameObject,0.2f);

        }
    }

}

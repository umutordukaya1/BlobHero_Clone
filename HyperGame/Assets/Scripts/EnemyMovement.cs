using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    public float hiz;
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform; 
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, hiz * Time.deltaTime);
    }
   
}

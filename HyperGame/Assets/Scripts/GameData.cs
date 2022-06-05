using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameData : MonoBehaviour
{
    public static GameData instance;
    public int MissileCount;
    float randomX, randomZ;

    public GameObject _enemy;
    [SerializeField] GameObject enemyObject;

    Transform playerPos;
    GameObject target;
    private void Awake()
    {
        instance = this;
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Start()
    {
       
        StartCoroutine(SpawnEnemy());
       

    }
    void Update()
    {

    }
    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(3f);
        randomX = (Random.Range(0, 100) >= 50 ? -1 : 1) * Random.Range(playerPos.position.x + 40f, playerPos.position.x + 50f);
        randomZ = (Random.Range(0, 100) >= 50 ? -1 : 1) * Random.Range(playerPos.position.z + 40f, playerPos.position.z + 50f);
        for (int i = 0; i < 2; i++)
        {
            Instantiate(_enemy, new Vector3(randomX + i * 3, 0, randomZ + i * 3), Quaternion.identity, enemyObject.transform);
        }

        StartCoroutine(SpawnEnemy());
    }
   


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameData : MonoBehaviour
{
    public static GameData instance;
    public GameObject Missile;
    private Transform InstantiateMissile;
    public int MissileCount;
    float RandomX, RandomZ;

    private void Awake()
    {
        instance = this;

    }

    [System.Serializable]
    public class Enemy
    {
        public string name;
        public int numberEnemies;
        public int health;
        public float hiz;
        public GameObject enemy;


    }
    public Enemy[] enemyData;
    void Start()
    {
        InstantiateMissile = new GameObject(gameObject.name + "Spawner").transform;

        StartCoroutine(SpawnMissile());
        EnemySpawn();
    }
    void Update()
    {
        RandomX = Random.Range(-25f, 25f);
        RandomZ = Random.Range(-30f, 30f);
        Debug.Log(RandomX);
    }
    void EnemySpawn()
    {
        for (int i = 0; i < enemyData[0].numberEnemies; i++)
        {

            RandomX = Random.Range(-25f, 25f);
            RandomZ = Random.Range(-30f, 30f);
            Vector3 location = new Vector3(RandomX, 0, RandomZ);
            Instantiate(enemyData[0].enemy);
            enemyData[0].enemy.transform.position = location;

        }
        for (int i = 0; i < enemyData[1].numberEnemies; i++)
        {
            RandomX = Random.Range(-45f, 45f);
            RandomZ = Random.Range(-10f, 10f);
            Vector3 location = new Vector3(RandomX, 0, RandomZ);
            Instantiate(enemyData[1].enemy);
            enemyData[1].enemy.transform.position = location;
        }
       
    }

    IEnumerator SpawnMissile()
    {
        yield return new WaitForSeconds(2);
        Missile.transform.SetParent(InstantiateMissile);
        for (int i = 1; i < MissileCount; i++)
        {
            GameObject gameObject = Instantiate(Missile);
            gameObject.transform.SetParent(InstantiateMissile);
            yield return new WaitForSeconds(2);
        }

    }

}

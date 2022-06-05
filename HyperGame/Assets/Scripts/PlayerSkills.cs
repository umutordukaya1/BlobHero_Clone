using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkills : MonoBehaviour
{
    
    public GameObject createItems;
    public GameObject BulletSpawnItems;
    public float spawnSpeed;
    public float spawnDelay;
    public float spawnCount;

    public bool isActiveSkill = false;

    int count = 0;
    public IEnumerator CreateBullet()
    {
        Debug.Log("creating anyh  bullet");
        yield return new WaitForSeconds(spawnSpeed);

        StartCoroutine(DelayCountBullet());

        count = 0;
        StartCoroutine(CreateBullet());
    }

    public IEnumerator DelayCountBullet()
    {
        count++;
        if (count < spawnCount)
        {
            Instantiate(createItems, transform.parent.position, Quaternion.identity,BulletSpawnItems.transform);
            yield return new WaitForSeconds(spawnDelay);
            StartCoroutine(DelayCountBullet());

        }
    }

    
}

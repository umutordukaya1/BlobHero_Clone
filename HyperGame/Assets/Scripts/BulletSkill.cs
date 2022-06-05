using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSkill : PlayerSkills
{
    public static BulletSkill Instance;
     void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        StartCoroutine(CreateBullet());
    }
   

}

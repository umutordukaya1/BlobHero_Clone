using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketSkill : PlayerSkills
{
   
    void Start()
    {
        StartCoroutine(CreateBullet());
    }

    
}

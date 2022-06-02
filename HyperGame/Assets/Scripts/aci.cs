using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aci : MonoBehaviour
{
    public Transform pivotObject;
    public float AngleStep;
     void Update()
    {                                                          //kademeli olarak açý deðiþtirme
      transform.RotateAround(pivotObject.position, Vector3.up, AngleStep*Time.deltaTime);

    }
}

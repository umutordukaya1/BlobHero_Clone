using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSurRound : MonoBehaviour
{
    public GameObject OriginalSurrounderObject,ReferanceChild;
    private GameObject NewSurRoundGameObject;
    private Transform SurroundParentTransform;
    public int ParentObjectCount;
    float AngleStep;
    void Start()
    {
        SurroundParentTransform = new GameObject(gameObject.name + "Player Surround").transform;
        SurroundParentTransform.parent=ReferanceChild.transform;
        Surround();

    }

    void Update()
    {

    }
    void Surround()
    {
        AngleStep = 360.0f / ParentObjectCount;
        OriginalSurrounderObject.transform.SetParent(SurroundParentTransform);
        
        for (int i = 0; i < ParentObjectCount; i++)
        {
            NewSurRoundGameObject = Instantiate(OriginalSurrounderObject);
            NewSurRoundGameObject.transform.RotateAround(transform.position, Vector3.up, AngleStep * i);
            NewSurRoundGameObject.transform.SetParent(SurroundParentTransform);
        }
    }
}



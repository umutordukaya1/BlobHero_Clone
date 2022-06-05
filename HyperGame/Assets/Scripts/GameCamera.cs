using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour
{
    public GameObject hedef;
    public Vector3 mesafe;
    // Start is called before the first frame update
    void Start()
    {

    }

    
    private void LateUpdate()//Genelde kamera fonk. buraya yazýlýr
    {
        //ilk kendi pozisyonunu  //takip edecegi                   //hýzý
        this.transform.position = Vector3.Lerp(this.transform.position, hedef.transform.position + mesafe, Time.deltaTime*10f);

    }
}

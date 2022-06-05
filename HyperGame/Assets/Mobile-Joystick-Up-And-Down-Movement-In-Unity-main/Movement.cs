using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour,IDragHandler,IPointerUpHandler,IPointerDownHandler
{
	public Transform player;
	public RectTransform pad;
	Vector3 move;
	bool walking;
	public float movespeed;
	
	public void OnDrag(PointerEventData eventdata){
		transform.position = eventdata.position;
		transform.localPosition = Vector2.ClampMagnitude(eventdata.position - (Vector2)pad.position,pad.rect.width*0.3f);
		move = new Vector3(transform.localPosition.x,0,transform.localPosition.y).normalized;
		if (!walking)
		{
			walking = true;
			//player.GetComponent<Animator>().SetBool("running",true);
		}
	}
	
	
	public void OnPointerUp(PointerEventData eventdata){
		transform.localPosition = Vector3.zero;
		move = Vector3.zero;
		walking = false;
		//player.GetComponent<Animator>().SetBool("running",false);
		StopCoroutine(moving());
	}
	public void OnPointerDown(PointerEventData eventdata){
		StartCoroutine(moving());
	}
	
	
	IEnumerator moving(){
		while (true)
		{
			player.Translate(move*movespeed* Time.deltaTime,Space.World);
			if (move != Vector3.zero)
			{
				player.rotation = Quaternion.Slerp(player.rotation,Quaternion.LookRotation(move),5*Time.deltaTime);
			}
			yield return null;
		}
		
	}
	
	
}

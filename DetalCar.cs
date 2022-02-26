using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetalCar : MonoBehaviour
{
	//этот скрипт надо вешать на запчасть
	
	//сюда надо переместить запчасть
	public Transform me;
	
	//сюда надо переместить персонажа
	public Transform pers;
	
	//сюда надо переместить Rigidbody запчасти
	public Rigidbody rb;
	
	//место где будет закреплена запчасть
	public Transform point;
	
                     //сюда указываю колайдер запчасти
	public Collider mc;
	public Collider mc1;
	
	void OnTriggerStay(Collider col)
	{
		if (col.tag == "Player") //сюда указывай тег персонажа
		{
			if (Input.GetKey(KeyCode.F)) //взять запчасть
			{
				rb.isKinematic = true;
				mc.enabled = false;
				me.transform.SetParent(pers);
			}
			if (Input.GetKey(KeyCode.Q)) //отпустить запчасть
			{
				rb.isKinematic = false;
				mc.enabled = true;
				me.transform.SetParent(null);
			}
		}
		if (col.tag == "Engine") //сюда указывай тег места,где должна стоять запчасть
		{
			if (Input.GetKey(KeyCode.E))
			{
				mc.enabled = false;
				mc1.enabled = false;
			    me.transform.SetParent(point);
		     	rb.isKinematic = true;
			    me.transform.position = point.transform.position;
				me.transform.rotation = point.transform.rotation;
			}
		}
	}
}

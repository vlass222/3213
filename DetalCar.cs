using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetalCar : MonoBehaviour
{
	//���� ������ ���� ������ �� ��������
	
	//���� ���� ����������� ��������
	public Transform me;
	
	//���� ���� ����������� ���������
	public Transform pers;
	
	//���� ���� ����������� Rigidbody ��������
	public Rigidbody rb;
	
	//����� ��� ����� ���������� ��������
	public Transform point;
	
                     //���� �������� �������� ��������
	public Collider mc;
	public Collider mc1;
	
	void OnTriggerStay(Collider col)
	{
		if (col.tag == "Player") //���� �������� ��� ���������
		{
			if (Input.GetKey(KeyCode.F)) //����� ��������
			{
				rb.isKinematic = true;
				mc.enabled = false;
				me.transform.SetParent(pers);
			}
			if (Input.GetKey(KeyCode.Q)) //��������� ��������
			{
				rb.isKinematic = false;
				mc.enabled = true;
				me.transform.SetParent(null);
			}
		}
		if (col.tag == "Engine") //���� �������� ��� �����,��� ������ ������ ��������
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

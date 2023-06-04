using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour 
{
	//1
	public float m_minSpeed = -0.01f;
	//2
	public float m_maxSpeed = -0.3f;
	//3
	private float m_speed = 0.0f;

	void Start () 
	{
		//4
		m_speed = Random.Range (m_minSpeed, m_maxSpeed);
		//5
		Debug.Log (m_speed);
	}

	void Update () 
	{
		//6
		transform.Translate(new Vector2 (m_speed, 0));
	}
}

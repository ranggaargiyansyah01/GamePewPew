using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
	public float m_speed = 0.3f;

	// Use this for initialization
	void Start () {
		//2
		Destroy (gameObject, 3.0f);

	}

	// Update is called once per frame
	void Update () {
		//3
		transform.position += transform.right*m_speed;

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "enemy") {
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}
}

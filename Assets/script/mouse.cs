using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject m_bullet;
	[SerializeField] AudioSource Pew;
	void Start()
	{}
	// Update is called once per frame
	void Update()
	{
		//2
		if(Input.GetMouseButtonDown(0))
		{
			fire();
		}}
	private void fire()    
	{
		//3
		Pew.Play();
		Vector3 mouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		GameObject bullet = Instantiate (m_bullet) as GameObject;
		//4
		bullet.transform.position = transform.position;
		float rad = Mathf.Atan2 (mouse.y - transform.position.y, mouse.x - transform.position.x);
		bullet.transform.Rotate (new Vector3(0,0, Mathf.Rad2Deg*rad));
	}
	
	}
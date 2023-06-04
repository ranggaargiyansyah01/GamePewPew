using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverChecker : MonoBehaviour 
{
	//1
	public GameObject m_gameOver;
	//2
	public bool m_isOver = false;
	[SerializeField] AudioSource hiks;
	void Start () 
	{
	}

	void Update () 
	{
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		//3
		if (other.gameObject.tag == "enemy") {
			//4
			if (m_isOver == false) {
				m_isOver = true;
				hiks.Play();
				m_gameOver.SetActive (true);
				StartCoroutine ("restartGame");
			}
		}
		Destroy (other.gameObject);
	}

	private IEnumerator restartGame()
	{
		yield return new WaitForSeconds (3.0f);
		Application.LoadLevel ("pp");
		yield return null;
	}
}

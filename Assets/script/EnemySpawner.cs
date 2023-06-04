using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour 
{
	//1
	public Transform m_top;
	public Transform m_bot;
	public GameObject m_enemy;
	public GameObject checkGameOver; 

	void Start () 
	{
		//2
		StartCoroutine ("make");
	}

	void Update () 
	{

	}

	//3
	private IEnumerator make()
	{
		//4
		while (checkGameOver.GetComponent<GameOverChecker>().m_isOver != true) {
		//5
		yield return new WaitForSeconds (1.0f);
		//6
		GameObject enemy = Instantiate (m_enemy) as GameObject;
		//7
			enemy.transform.position = new Vector2 (m_top.transform.position.x, Random.Range(m_top.transform.position.y, m_bot.transform.position.y));
		}
	}
}

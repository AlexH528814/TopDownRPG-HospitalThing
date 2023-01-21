using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end_game : MonoBehaviour
{
		
	void OnTriggerEnter2D(Collider2D other)
	{
		StartCoroutine(End_Game());
	
		if (other.CompareTag("Player"))
		{
			SceneManager.LoadScene("end_scene");
		}
	}

	IEnumerator End_Game()
	{
		Debug.Log("Game Ending");

		yield return new WaitForSeconds(1/2);
	}

}

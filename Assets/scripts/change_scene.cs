using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_scene : MonoBehaviour
{	

	void OnTriggerEnter2D(Collider2D other)
	{
		StartCoroutine(Change_Scenes());
	}

	IEnumerator Change_Scenes()
	{
		Debug.Log("Changing Scenes");

		yield return new WaitForSeconds(1/2);
			
		Debug.Log(application_vars.item_count);

		if (SceneManager.GetActiveScene().name == "first_scene")
		{
		SceneManager.LoadScene("second_scene");
		}
		
		if (SceneManager.GetActiveScene().name == "second_scene")
		{
			SceneManager.LoadScene("first_scene");
		}

		switch(SceneManager.GetActiveScene().name)
		{
			case "first_scene":
		SceneManager.LoadScene("first_scene");
				break;

			case "second_scene":
		SceneManager.LoadScene("second_scene");
				break;

			default:
Debug.Log("Ummmmm wtf this shouldn't be happening");
break;
		}

		Debug.Log(application_vars.item_count);
	}


}

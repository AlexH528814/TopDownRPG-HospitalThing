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
			
		Debug.Log(application_vars.patients_saved);

		if (SceneManager.GetActiveScene().name == "hospital_room")
		{
		SceneManager.LoadScene("medicine_room");
		}
		
		if (SceneManager.GetActiveScene().name == "medicine_room")
		{
			SceneManager.LoadScene("hospital_room");
		}


		Debug.Log(application_vars.patients_saved);
	}


}

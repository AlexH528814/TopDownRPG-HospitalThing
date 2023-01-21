using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup_item : MonoBehaviour
{
	public GameObject obj;


	public string obj_name = "drug_item";

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
				{
				Destroy(obj);

				application_vars.player_has_item = true;
				application_vars.item_count++;
				}
		Debug.Log($"Picked up {obj_name}");
	}


}

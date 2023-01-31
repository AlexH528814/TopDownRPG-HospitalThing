using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup_item : MonoBehaviour
{
	public GameObject obj;
	public GameObject droptext;


	public string obj_name = "name";

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{

            if (obj_name == "pneumonia medicine" && !application_vars.has_pneumonia_medicine && !application_vars.has_item)
            {
                Debug.Log("Pickeup up pneumonia medicine");
                Destroy(obj);
                application_vars.has_pneumonia_medicine = true;
                application_vars.current_item = "pneumonia";
                application_vars.has_item = true;
            }

            else if (obj_name == "pneumonia medicine" && application_vars.has_item)
            {
                Debug.Log("You only have enough space for one type of medicine at a time. Please drop the medicine you currently have with Q");
		StartCoroutine(DropItemText());
            }

            if (obj_name == "cold medicine" && !application_vars.has_cold_medicine && !application_vars.has_item)
            {
                Debug.Log("Pickeup up cold medicine");
                Destroy(obj);
                application_vars.has_cold_medicine = true;
                application_vars.current_item = "cold";
                application_vars.has_item = true;
            }

            else if (obj_name == "cold medicine" && application_vars.has_item)
            {
                Debug.Log("You only have enough space for one type of medicine at a time. Please drop the medicine you currently have with Q");
		StartCoroutine(DropItemText());
            }
        }



    }

	IEnumerator DropItemText(){
		droptext.SetActive(true);
		yield return new WaitForSeconds(2);
		droptext.SetActive(false);
	}

}

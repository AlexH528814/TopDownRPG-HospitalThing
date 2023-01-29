using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_options : MonoBehaviour
{
    	public GameObject Canvas;
    	public GameObject face;
    	public GameObject dialogue;

	public GameObject cold_symptoms;
	public GameObject pneumonia_symptoms;
	public GameObject depression_symptoms;
	public GameObject trauma_symptoms;




    void HealOption()
	{
		
	}

    void Leave_Option()
    {
        Canvas.SetActive(false);
        face.SetActive(false);
        dialogue.SetActive(false);
    

        cold_symptoms.SetActive(false);
        pneumonia_symptoms.SetActive(false);
        depression_symptoms.SetActive(false);
        trauma_symptoms.SetActive(false);
    }

}

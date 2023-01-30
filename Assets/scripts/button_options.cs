using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_options : MonoBehaviour
{
    	public GameObject Canvas;
    	public GameObject face;

	public GameObject cold_symptoms;
	public GameObject pneumonia_symptoms;
	public GameObject depression_symptoms;
	public GameObject trauma_symptoms;

	public GameObject patient1_dialogue;
	public GameObject patient2_dialogue;
	public GameObject patient3_dialogue;
	public GameObject patient4_dialogue;

	public GameObject patient1_saved_box;
	public GameObject patient2_saved_box;
	public GameObject patient3_saved_box;
	public GameObject patient4_saved_box;


	public GameObject missing_medicine;

    public IEnumerator PneumoniaOptionP1()
    {
	if (application_vars.patient1_radius){
		if (application_vars.has_pneumonia_medicine){
			patient1_saved_box.SetActive(true);
			yield return new WaitForSeconds(3f);
			LeaveOption();
			application_vars.patient1_saved = true;
		}

		else {
			LeaveOption();
			Canvas.SetActive(true);
			missing_medicine.SetActive(true);
			yield return new WaitForSeconds(3f);
			LeaveOption();
		}
	}
    }

    public IEnumerator ColdOptionP1()
    {
	if (application_vars.patient1_radius){
		if (application_vars.has_cold_medicine){
			patient1_saved_box.SetActive(true);
			yield return new WaitForSeconds(3f);
			LeaveOption();
			application_vars.patient1_saved = true;
		}
		else {
			LeaveOption();
			Canvas.SetActive(true);
			missing_medicine.SetActive(true);
			yield return new WaitForSeconds(3f);
			LeaveOption();
		}
	}
    }

    public void LeaveOption()
    {
        Canvas.SetActive(false);
        face.SetActive(false);
        patient1_dialogue.SetActive(false);
	patient2_dialogue.SetActive(false);
	patient3_dialogue.SetActive(false);
	patient4_dialogue.SetActive(false);
	patient1_saved_box.SetActive(false);
	patient2_saved_box.SetActive(false);
	patient3_saved_box.SetActive(false);
	patient4_saved_box.SetActive(false);
        cold_symptoms.SetActive(false);
        pneumonia_symptoms.SetActive(false);
        depression_symptoms.SetActive(false);
        trauma_symptoms.SetActive(false);
	missing_medicine.SetActive(false);
    }


    public void ColdOptionPatient1()
    {
	StartCoroutine(ColdOptionP1());
    }

    public void PneumoniaOptionPatient1()
    {
	StartCoroutine(PneumoniaOptionP1());
    }

}

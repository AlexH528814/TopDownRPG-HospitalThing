using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clipboard_interact : MonoBehaviour
{
    public GameObject clipboard;

    public float radius;

    public Transform playerTransform;
    public Transform interactionTransform;

    public string patient_name;	

    public GameObject Canvas;
    public GameObject symptoms;
    public GameObject face;
    public GameObject dialogue;

    private void OnDrawGizmosSelected()
    {
        if (interactionTransform == null)
            interactionTransform = transform;


        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }

    private void Update()
    {
	if (application_vars.patient1_saved && patient_name == "patient1")
	{
		Destroy(clipboard);
		application_vars.patients_saved++;
	}
	if (application_vars.patient2_saved && patient_name == "patient2")
	{
		Destroy(clipboard);application_vars.patients_saved++;
	}
	if (application_vars.patient3_saved && patient_name == "patient3")
	{
		Destroy(clipboard);application_vars.patients_saved++;
	}
	if (application_vars.patient4_saved && patient_name == "patient4")
	{
		Destroy(clipboard);application_vars.patients_saved++;
	}

        float distance = Vector2.Distance(playerTransform.position, interactionTransform.position);

        if (distance <= radius)
        {
            StartCoroutine(CheckInput());

	    switch (patient_name)
	    {
		case "patient1":
			application_vars.patient1_radius = true;
			break;
		case "patient2":
			application_vars.patient2_radius = true;
			break;
		case "patient3":
			application_vars.patient3_radius = true;
			break;
		case "patient4":
			application_vars.patient4_radius = true;
			break;}
        }
    }

    IEnumerator CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Canvas.SetActive(true);
            symptoms.SetActive(true);

            yield return new WaitForSeconds(3);

            face.SetActive(true);

            yield return new WaitForSeconds(2);

            dialogue.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Canvas.SetActive(false);
            symptoms.SetActive(false);
            face.SetActive(false);
            dialogue.SetActive(false);
        }
    }
}

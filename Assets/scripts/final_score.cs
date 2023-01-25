using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class final_score : MonoBehaviour
{

	public TMP_Text score_text;

	void Start()
	{
		score_text.SetText($"Your final score is: {application_vars.patients_saved * 100}");
	}

	void Update()
	{
	}
}

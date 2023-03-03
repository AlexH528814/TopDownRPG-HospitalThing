using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_options : MonoBehaviour
{
	public cabinet_scripts script;

	void OnClick(){
		script.ChangeImage();
	}
}

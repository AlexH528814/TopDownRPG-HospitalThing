using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_options : MonoBehaviour
{
	public cabinet_scripts script;

	public void OnClickLeft(){
		script.ChangeImageLeft();
	}
	
	public void OnClickRight(){
		script.ChangeImageRight();
	}
}
